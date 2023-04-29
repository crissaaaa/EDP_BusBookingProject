Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class frmDriver
    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strsql = "Select * from driver where driverID = '" _
                & .search4.Text & "'"

            mycmd.CommandText = strsql
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .dID.Text = myreader.GetString(0)
                    .dname.Text = myreader.GetString(1)
                    .dcontact.Text = myreader.GetString(2)
                    .u2.Text = myreader.GetString(3)
                End While
            Else
                MsgBox("UserID does not exist!")
            End If
            Call DisconnectToDB()
        End With
    End Sub

    ' Add new driver's record
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand

            Try
                strsql = "Insert into driver values('" _
                    & .dID.Text & "', '" _
                    & .dname.Text & "','" _
                    & .dcontact.Text & "','" _
                    & .u2.Text & "')"

                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Driver Successfully Added!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Call DisconnectToDB()
        End With
    End Sub

    ' Edit the existing record stored in database
    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                strsql = "UPDATE driver SET driver_name = '" _
                     & .dname.Text & "', driver_contact = '" _
                     & .dcontact.Text & "', userID = '" _
                     & .u2.Text & "'
                     WHERE driverID = '" & .dID.Text & "'"


                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Driver Successfully Updated!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Call DisconnectToDB()
        End With
    End Sub

    ' Delete a record
    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this driver?", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strsql = "Delete from driver" _
                        & " where driverID = '" _
                        & .dID.Text & "'"

                    mycmd.CommandText = strsql
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Driver Successfully Deleted!")
                    Call Clear_Boxes()
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .dID.Text = ""
            .dname.Text = ""
            .dcontact.Text = ""
            .u2.Text = ""
        End With
    End Sub

    'Return to Main Form
    Private Sub menubtn_Click(sender As Object, e As EventArgs) Handles menubtn.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    ' Viewing the contents of the driver table from database
    Private Sub viewlistbtn_Click(sender As Object, e As EventArgs) Handles viewlistbtn.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            strsql = "Select * FROM driver"
            mycmd = New MySqlCommand(strsql, myconn)
            SDA.SelectCommand = mycmd
            SDA.Fill(dbdata)
            bSource.DataSource = dbdata
            DataGridView4.DataSource = bSource
            SDA.Update(dbdata)

            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    ' Upload csv file and display it to the data grid provided
    Private Sub uploadbtn_Click(sender As Object, e As EventArgs) Handles uploadbtn.Click
        ' Create an OpenFileDialog to allow the user to select a file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv"
        openFileDialog.Multiselect = False
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Open the database connection
                ConnectToDB()

                ' Create the MySQL command to execute the LOAD DATA INFILE statement
                Dim cmd As MySqlCommand = New MySqlCommand()
                cmd.Connection = myconn
                cmd.CommandText = "LOAD DATA INFILE '" & openFileDialog.FileName.Replace("\", "/") & "' " &
                          "INTO TABLE driver " &
                          "FIELDS TERMINATED BY ',' " &
                          "LINES TERMINATED BY '\r\n' " &
                          "IGNORE 1 LINES"

                cmd.ExecuteNonQuery()

                ' Create a DataTable to hold the uploaded data
                Dim dataTable As New DataTable()

                ' Create a MySQLDataAdapter to fill the DataTable
                Dim dataAdapter As New MySqlDataAdapter("SELECT * FROM driver", myconn)

                ' Fill the DataTable
                dataAdapter.Fill(dataTable)

                ' Set the DataSource of the DataGridView to the DataTable
                DataGridView4.DataSource = dataTable

                ' Auto-size the columns of the DataGridView
                DataGridView4.AutoResizeColumns()

                ' Display a message box to inform the user that the data has been uploaded and displayed
                MessageBox.Show("Data uploaded and displayed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                ' Handle any exceptions
                MessageBox.Show("An error occurred while uploading and displaying the data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                ' Close the database connection
                DisconnectToDB()

            End Try
        End If
    End Sub

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        Call ImportToExcel(Me.DataGridView4, "driverReport1.xlsx")
    End Sub
End Class