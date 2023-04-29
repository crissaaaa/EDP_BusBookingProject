Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class frmTotalPayment
    ' Search a specific record (user_ID) 
    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strsql = "Select * from totalpayment where user_ID = '" _
                & .search1.Text & "'"

            mycmd.CommandText = strsql
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .uID.Text = myreader.GetString(0)
                    .total.Text = myreader.GetDouble(1)
                End While
            Else
                MsgBox("UserID does not exist!")
            End If
            Call DisconnectToDB()
        End With

    End Sub

    ' Update existing record
    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                strsql = "Update totalpayment set total = '" _
                    & total.Text & "'
                    where user_ID = '" & .uID.Text & "'"
                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Updated!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            DisconnectToDB()
        End With
    End Sub

    ' Delete existing record
    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strsql = "Delete from totalpayment" _
                        & " where user_ID = '" _
                        & .uID.Text & "'"

                    mycmd.CommandText = strsql
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Record Successfully Deleted!")
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
            .uID.Text = ""
            .total.Text = ""
        End With
    End Sub

    ' View totalpayment table (from database) to the data grid tool
    Private Sub viewlistbtn_Click(sender As Object, e As EventArgs) Handles viewlistbtn.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            strsql = "Select * FROM totalpayment"
            mycmd = New MySqlCommand(strsql, myconn)
            SDA.SelectCommand = mycmd
            SDA.Fill(dbdata)
            bSource.DataSource = dbdata
            DataGridView5.DataSource = bSource
            SDA.Update(dbdata)

            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    ' Go to Dashboard
    Private Sub menubtn_Click(sender As Object, e As EventArgs) Handles menubtn.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        Call ImportToExcel(Me.DataGridView5, "totalPaymentReport.xlsx")
    End Sub

    'Private Sub uploadbtn_Click(sender As Object, e As EventArgs)
    ' Create an OpenFileDialog to allow the user to select a file
    '   Dim openFileDialog As New OpenFileDialog()
    '  openFileDialog.Filter = "CSV Files (*.csv)|*.csv"
    ' openFileDialog.Multiselect = False
    'openFileDialog.RestoreDirectory = True

    ' If openFileDialog.ShowDialog() = DialogResult.OK Then
    '    Try
    ' Open the database connection
    '       ConnectToDB()

    ' Create the MySQL command to execute the LOAD DATA INFILE statement
    '      Dim cmd As MySqlCommand = New MySqlCommand()
    '     cmd.Connection = myconn
    '    cmd.CommandText = "LOAD DATA INFILE '" & openFileDialog.FileName.Replace("\", "/") & "' " &
    '             "INTO TABLE totalpayment " &
    '            "FIELDS TERMINATED BY ',' " &
    '           "LINES TERMINATED BY '\r\n' " &
    '          "IGNORE 1 LINES"

    ' Execute the command
    'cmd.ExecuteNonQuery()

    ' Create a DataTable to hold the uploaded data
    'Dim dataTable As New DataTable()

    ' Create a MySQLDataAdapter to fill the DataTable
    'Dim dataAdapter As New MySqlDataAdapter("SELECT * FROM totalpayment", myconn)

    ' Fill the DataTable
    '       dataAdapter.Fill(dataTable)

    ' Set the DataSource of the DataGridView to the DataTable
    '            DataGridView5.DataSource = dataTable

    ' Auto-size the columns of the DataGridView
    '           DataGridView5.AutoResizeColumns()

    ' Display a message box to inform the user that the data has been uploaded and displayed
    '          MessageBox.Show("Data uploaded and displayed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '     Catch ex As Exception
    ' Handle any exceptions
    '        MessageBox.Show("An error occurred while uploading and displaying the data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    Finally
    ' Close the database connection
    '       DisconnectToDB()

    'End Try
    'End If
    'End Sub


End Class