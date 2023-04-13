Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class CustomerForm

    '   Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '      myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=Y1012Jqkhkpcrissa;database=bus_bookingdb"

    '      Try
    '         myconn.Open()
    'MessageBox.Show("Connection to MySQL bus_bookingdb is successful!", "TESTING MySQL CONNECT TO DB")
    'myconn.Close()

    '    Catch ex As MySql.Data.MySqlClient.MySqlException
    '       Select Case ex.Number
    '          Case 0
    '             MsgBox("Cannot Connect to Server")
    '        Case 1045
    '           MsgBox("Invalid Username or password")
    'End Select

    'End Try
    'End Sub

    Private Sub searchacc_Click(sender As Object, e As EventArgs) Handles searchacc.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strsql = "Select * from customer where customerID = '" _
                & .search3.Text & "'"

            mycmd.CommandText = strsql
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .cust1.Text = myreader.GetString(0)
                    .nametext1.Text = myreader.GetString(1)
                    .contactnum.Text = myreader.GetString(2)
                    .emailtext.Text = myreader.GetString(3)
                    .usernametext.Text = myreader.GetString(4)
                    .password1.Text = myreader.GetString(5)
                    .useridnum.Text = myreader.GetString(6)

                End While
            Else
                MsgBox("CustomerID does not exist!")
            End If
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub add3_Click(sender As Object, e As EventArgs) Handles add3.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand

            Try
                strsql = "Insert into customer values('" _
                    & .cust1.Text & "', '" _
                    & .nametext1.Text & "', '" _
                    & .contactnum.Text & "' , '" _
                    & .emailtext.Text & "', '" _
                    & .usernametext.Text & "', '" _
                    & .password1.Text & "'), '" _
                    & .useridnum.Text & "')"

                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Customer Successfully Added!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)

            End Try
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub update3_Click(sender As Object, e As EventArgs) Handles update3.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                strsql = "Update customer set customer_name = '" _
                    & .nametext1.Text & "', customer_contact = '" _
                    & .contactnum.Text & "', customer_email = '" _
                    & .emailtext.Text & "', customer_username = '" _
                    & .usernametext.Text & "', password = '" _
                    & .password1.Text & "'
                    where userID = '" & .useridnum.Text & "'"
                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Customer Account Successfully Updated!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            DisconnectToDB()
        End With
    End Sub

    Private Sub del3_Click(sender As Object, e As EventArgs) Handles del3.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this customer?", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strsql = "Delete from customer" _
                        & " where customerID = '" _
                        & .cust1.Text & "'"

                    mycmd.CommandText = strsql
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Customer Successfully Deleted!")
                    Call Clear_Boxes()
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            DisconnectToDB()
        End With
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .cust1.Text = ""
            .nametext1.Text = ""
            .contactnum.Text = ""
            .emailtext.Text = ""
            .usernametext.Text = ""
            .password1.Text = ""
            .useridnum.Text = ""
        End With
    End Sub

    Private Sub showpw1_CheckedChanged(sender As Object, e As EventArgs) Handles showpw1.CheckedChanged
        If showpw1.Checked Then
            password1.UseSystemPasswordChar = False
        Else
            password1.UseSystemPasswordChar = True

        End If
    End Sub
    Private Sub GoToMain_Click(sender As Object, e As EventArgs) Handles GoToMain.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub view_Click(sender As Object, e As EventArgs) Handles view.Click

    End Sub
End Class