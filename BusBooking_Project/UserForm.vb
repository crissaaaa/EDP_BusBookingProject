Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient
Public Class UserForm
    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=Y1012Jqkhkpcrissa;database=bus_bookingdb"

        Try
            myconn.Open()
            'MessageBox.Show("Connection to MySQL bus_bookingdb is successful!", "TESTING MySQL CONNECT TO DB")
            'myconn.Close()

        Catch ex As MySqlException
            Select Case ex.Number
                Case 0
                    MsgBox("Cannot Connect to Server")
                Case 1045
                    MsgBox("Invalid Username or password")
            End Select

        End Try
    End Sub
    Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles AddUser.Click
        myconn.Open()

        mycmd.Connection = myconn

        With mycmd
            .CommandText = "INSERT INTO user values (@userID, @name, @contact, @email, @username, @password, @acc_status);"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@userID", userid.Text)
            .Parameters.AddWithValue("@name", nametxt.Text)
            .Parameters.AddWithValue("@contact", contact.Text)
            .Parameters.AddWithValue("@email", email.Text)
            .Parameters.AddWithValue("@username", username.Text)
            .Parameters.AddWithValue("@password", password.Text)
            .Parameters.AddWithValue("@acc_status", accstatus.Text)


        End With
        mycmd.ExecuteNonQuery()
        MsgBox("User Account Updated Successfully!")
        myconn.Close()
    End Sub

    Private Sub EditAcc_Click(sender As Object, e As EventArgs) Handles EditAcc.Click
        myconn.Open()
        mycmd.Connection = myconn

        With mycmd
            .CommandText = "UPDATE user SET name = @name, contact = @contact, email = @email, username = @username, password = @password, acc_status = @acc_status where userID = @userID"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@name", nametxt.Text)
            .Parameters.AddWithValue("@contact", contact.Text)
            .Parameters.AddWithValue("@email", email.Text)
            .Parameters.AddWithValue("@username", username.Text)
            .Parameters.AddWithValue("@password = md5('", password.Text)
            .Parameters.AddWithValue("@acc_status", accstatus.Text)

        End With
        mycmd.ExecuteNonQuery()
        MsgBox("User Account Updated Successfully!")
        myconn.Close()
    End Sub

    Private Sub GoToMain_Click(sender As Object, e As EventArgs) Handles GoToMain.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class