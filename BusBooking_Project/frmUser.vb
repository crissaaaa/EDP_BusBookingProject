Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class frmUser

    Private Sub searchacc_Click(sender As Object, e As EventArgs) Handles searchacc.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strsql = "Select * from user where userID = '" _
                & .search2.Text & "'"

            mycmd.CommandText = strsql
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .userid1.Text = myreader.GetString(0)
                    .nametext.Text = myreader.GetString(1)
                    .contact.Text = myreader.GetString(2)
                    .email.Text = myreader.GetString(3)
                    .username.Text = myreader.GetString(4)
                    .password.Text = myreader.GetString(5)
                    .accstatus.Text = myreader.GetString(6)

                End While
            Else
                MsgBox("UserID does not exist!")
            End If
            Call DisconnectToDB()
        End With
    End Sub

    ' Add new user
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand

            Try
                strsql = "Insert into user values('" _
                & .userid1.Text & "', '" _
                & .nametext.Text & "','" _
                & .contact.Text & "','" _
                & .email.Text & "','" _
                & .username.Text & "','" _
                & .password.Text & "','" _
                & .accstatus.Text & "')"

                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Added!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)

            End Try
            Call DisconnectToDB()
        End With
    End Sub

    ' Edit existing record
    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                strsql = "UPDATE user SET name='" & nametext.Text & "',contact='" _
                        & contact.Text & "', email = '" _
                        & email.Text & "', username = '" _
                        & username.Text & "', password = md5('" _
                        & password.Text & "'), acc_status = '" _
                        & accstatus.Text & "'
                        WHERE userID='" & userid1.Text & "'"
                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("User Successfully Updated!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            DisconnectToDB()
        End With
    End Sub

    ' Delete existing record
    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this user?", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strsql = "Delete from user" _
                        & " where userID = '" _
                        & .userid1.Text & "'"

                    mycmd.CommandText = strsql
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Record Successfully Deleted!")
                    Call Clear_Boxes()
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            DisconnectToDB()
        End With
    End Sub

    ' Show password
    Private Sub showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles showpassword.CheckedChanged
        If showpassword.Checked Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True

        End If
    End Sub

    ' Function for clearing the forms
    Private Sub Clear_Boxes()
        With Me

            .userid1.Text = ""
            .nametext.Text = ""
            .contact.Text = ""
            .email.Text = ""
            .username.Text = ""
            .password.Text = ""
            .accstatus.Text = ""
        End With
    End Sub

    Private Sub viewlistbtn_Click(sender As Object, e As EventArgs) Handles viewlistbtn.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            strsql = "Select * FROM user"
            mycmd = New MySqlCommand(strsql, myconn)
            SDA.SelectCommand = mycmd
            SDA.Fill(dbdata)
            bSource.DataSource = dbdata
            DataGridView8.DataSource = bSource
            ' Auto-size the columns of the DataGridView
            DataGridView8.AutoResizeColumns()
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
                          "INTO TABLE user " &
                          "FIELDS TERMINATED BY ',' " &
                          "LINES TERMINATED BY '\r\n' " &
                          "IGNORE 1 LINES"

                ' Execute the command
                cmd.ExecuteNonQuery()

                ' Create a DataTable to hold the uploaded data
                Dim dataTable As New DataTable()

                ' Create a MySQLDataAdapter to fill the DataTable
                Dim dataAdapter As New MySqlDataAdapter("SELECT * FROM user", myconn)

                ' Fill the DataTable
                dataAdapter.Fill(dataTable)

                ' Set the DataSource of the DataGridView to the DataTable
                DataGridView8.DataSource = dataTable

                ' Auto-size the columns of the DataGridView
                DataGridView8.AutoResizeColumns()

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

    Private Sub menubtn_Click(sender As Object, e As EventArgs) Handles menubtn.Click
        Me.Hide()
        frmMain.Show()
    End Sub
End Class