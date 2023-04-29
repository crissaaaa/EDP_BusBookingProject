Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class frmBus

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand

            Try
                strsql = "Insert into bus values('" _
                & .busid6.Text & "', '" _
                & .platenum6.Text & "','" _
                & .bustype6.Text & "','" _
                & .capacity6.Text & "','" _
                & .user6.Text & "','" _
                & .driverid6.Text & "')"

                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Bus Record Successfully Added!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)

            End Try
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .busid6.Text = ""
            .platenum6.Text = ""
            .bustype6.Text = ""
            .capacity6.Text = ""
            .user6.Text = ""
            .driverid6.Text = ""
        End With
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                strsql = "UPDATE bus SET bus_platenum='" _
                    & platenum6.Text & "',bus_type='" _
                        & bustype6.Text & "', capacity = '" _
                        & capacity6.Text & "', userID = '" _
                        & user6.Text & "', driverID = '" _
                        & driverid6.Text & "'
                WHERE busID='" & busid6.Text & "'"
                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Bus Information Successfully Updated!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this bus record?", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strsql = "Delete from bus" _
                        & " where busID = '" _
                        & .busid6.Text & "'"

                    mycmd.CommandText = strsql
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Bus Record Successfully Deleted!")
                    Call Clear_Boxes()
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Call DisconnectToDB()
        End With
    End Sub


    Private Sub search6_Click(sender As Object, e As EventArgs) Handles search6.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strsql = "Select * from bus where busID = '" _
                & .s6.Text & "'"

            mycmd.CommandText = strsql
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .busid6.Text = myreader.GetString(0)
                    .platenum6.Text = myreader.GetString(1)
                    .bustype6.Text = myreader.GetString(2)
                    .capacity6.Text = myreader.GetString(3)
                    .user6.Text = myreader.GetString(4)
                    .driverid6.Text = myreader.GetString(5)
                End While
            Else
                MsgBox("BusID does not exist!")
            End If
            Call DisconnectToDB()
        End With
    End Sub


    Private Sub menubtn_Click(sender As Object, e As EventArgs) Handles menubtn.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub viewlistbtn_Click(sender As Object, e As EventArgs) Handles viewlistbtn.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            strsql = "Select * FROM bus"
            mycmd = New MySqlCommand(strsql, myconn)
            SDA.SelectCommand = mycmd
            SDA.Fill(dbdata)
            bSource.DataSource = dbdata
            DataGridView2.DataSource = bSource
            SDA.Update(dbdata)

            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub


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
                          "INTO TABLE bus " &
                          "FIELDS TERMINATED BY ',' " &
                          "LINES TERMINATED BY '\r\n' " &
                          "IGNORE 1 LINES"

                ' Execute the command
                cmd.ExecuteNonQuery()

                ' Create a DataTable to hold the uploaded data
                Dim dataTable As New DataTable()

                ' Create a MySQLDataAdapter to fill the DataTable
                Dim dataAdapter As New MySqlDataAdapter("SELECT * FROM bus", myconn)

                ' Fill the DataTable
                dataAdapter.Fill(dataTable)

                ' Set the DataSource of the DataGridView to the DataTable
                DataGridView2.DataSource = dataTable

                ' Auto-size the columns of the DataGridView
                DataGridView2.AutoResizeColumns()

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
        Call ImportToExcel(Me.DataGridView2, "busReport.xlsx")
    End Sub
End Class