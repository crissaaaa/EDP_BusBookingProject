Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class User

    'Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '   myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=Y1012Jqkhkpcrissa;database=bus_bookingdb"

    '   Try
    '      myconn.Open()
    'MessageBox.Show("Connection to MySQL bus_bookingdb is successful!", "TESTING MySQL CONNECT TO DB")
    'myconn.Close()

    '  Catch ex As MySql.Data.MySqlClient.MySqlException
    '     Select Case ex.Number
    '         Case 0
    '            MsgBox("Cannot Connect to Server")
    '        Case 1045
    '            MsgBox("Invalid Username or password")
    ' End Select

    'End Try
    ' End Sub

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

    Private Sub add1_Click(sender As Object, e As EventArgs) Handles add1.Click
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

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
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

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
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

    Private Sub showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles showpassword.CheckedChanged
        If showpassword.Checked Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True

        End If
    End Sub

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

    Private Sub GoToMain_Click(sender As Object, e As EventArgs) Handles GoToMain.Click
        Me.Hide()
        MainForm.Show()
    End Sub

End Class