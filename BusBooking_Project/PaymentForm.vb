Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class PaymentForm
    ''Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    '  myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=Y1012Jqkhkpcrissa;database=bus_bookingdb"

    '  Try
    '      myconn.Open()
    'MessageBox.Show("Connection to MySQL bus_bookingdb is successful!", "TESTING MySQL CONNECT TO DB")
    'myconn.Close()

    '  Catch ex As MySql.Data.MySqlClient.MySqlException
    '      Select Case ex.Number
    '       Case 0
    '             MsgBox("Cannot Connect to Server")
    '         Case 1045
    ' MsgBox("Invalid Username or password")
    '   End Select

    ' End Try
    'End Sub

    Private Sub add5_Click(sender As Object, e As EventArgs) Handles add5.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand

            Try
                strsql = "Insert into payment values('" _
                & .pid.Text & "', '" _
                & .bookId1.Text & "','" _
                & .paidamount.Text & "','" _
                & .datetext.Text & "','" _
                & .user.Text & "')"

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

    Private Sub update5_Click(sender As Object, e As EventArgs) Handles update5.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                strsql = "UPDATE payment SET bookingID='" & bookId1.Text & "',paid_amount ='" _
                        & paidamount.Text & "', payment_date = '" _
                        & datetext.Text & "', userID = '" _
                        & user.Text & "'
                        WHERE paymentID='" & pid.Text & "'"
                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("User Successfully Updated!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub del5_Click(sender As Object, e As EventArgs) Handles del5.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strsql = "Delete from payment" _
                        & " where paymentID = '" _
                        & .pid.Text & "'"

                    mycmd.CommandText = strsql
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Payment Record Successfully Deleted!")
                    Call Clear_Boxes()
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub searchlist_Click(sender As Object, e As EventArgs) Handles searchlist.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strsql = "Select * from payment where paymentID = '" _
                & .s1.Text & "'"
            mycmd.CommandText = strsql
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .pid.Text = myreader.GetString(0)
                    .bookId1.Text = myreader.GetString(1)
                    .paidamount.Text = myreader.GetDouble(2)
                    .datetext.Text = myreader.GetDateTime(3)
                    .user.Text = myreader.GetString(4)

                End While
            Else
                MsgBox("UserID does not exist!")
            End If
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .pid.Text = ""
            .bookId1.Text = ""
            .paidamount.Text = ""
            .datetext.Text = ""
            .user.Text = ""
        End With
    End Sub

    Private Sub GoToMain_Click(sender As Object, e As EventArgs) Handles GoToMain.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub totalpay_Click(sender As Object, e As EventArgs) Handles totalpay.Click
        Me.Hide()
        TotalPaymentForm.Show()
    End Sub
End Class