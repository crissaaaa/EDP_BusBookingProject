Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=Y1012Jqkhkpcrissa;database=bus_bookingdb"
    End Sub

    Private Sub login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click

        strsql = "Select * from users_login where username = '" _
            & username.Text & "' and password = md5('" _
            & password.Text & "')"
        connect()
        'MsgBox(strsql)
        If myreader.Read Then
            MsgBox("Logged in Successfully")
            Me.Hide()
            MainForm.Show()
        Else
            MsgBox("Invalid Username or Password")
        End If
        myconn.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles showpassword.CheckedChanged
        If showpassword.Checked Then

            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True

        End If
    End Sub

End Class