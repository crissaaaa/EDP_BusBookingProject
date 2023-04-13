Imports MySql.Data.MySqlClient

Public Class BookingForm

    'Private Sub BookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=Y1012Jqkhkpcrissa;database=bus_bookingdb"

    '   Try
    '      myconn.Open()
    'MessageBox.Show("Connection to MySQL bus_bookingdb is successful!", "TESTING MySQL CONNECT TO DB")
    'myconn.Close()

    '        Catch ex As MySql.Data.MySqlClient.MySqlException
    '           Select Case ex.Number
    '               Case 0
    '                   MsgBox("Cannot Connect to Server")
    '              Case 1045
    '                   MsgBox("Invalid Username or password")
    '   End Select

    '   End Try
    '   End Sub

    Private Sub GoToMain0_Click(sender As Object, e As EventArgs) Handles GoToMain0.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub search1_Click(sender As Object, e As EventArgs) Handles search1.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strsql = "Select * from booking where bookingID = '" _
                & .s01.Text & "'"

            mycmd.CommandText = strsql
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .bID.Text = myreader.GetString(0)
                    .schedid1.Text = myreader.GetString(1)
                    .custid1.Text = myreader.GetString(2)
                    .seat.Text = myreader.GetString(3)
                    .fare.Text = myreader.GetDouble(4)
                    .total1.Text = myreader.GetDouble(5)
                    .bdate.Text = myreader.GetString(6)
                    .useridnum1.Text = myreader.GetString(7)

                End While
            Else
                MsgBox("BookingID does not exist!")
            End If
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub add1_Click(sender As Object, e As EventArgs) Handles add1.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand

            Try
                strsql = "Insert into booking values('" _
                    & .bID.Text & "', '" _
                    & .schedid1.Text & "', '" _
                    & .custid1.Text & "' , '" _
                    & .seat.Text & "', '" _
                    & .fare.Text & "', '" _
                    & .total1.Text & "', '" _
                    & bdate.Text & "', '" _
                    & .useridnum1.Text & "')"

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

    Private Sub update1_Click(sender As Object, e As EventArgs) Handles update1.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                strsql = "Update booking set schedID = '" _
                    & .schedid1.Text & "', customerID = '" _
                    & .custid1.Text & "', no_of_seats = '" _
                    & .seat.Text & "', fare_amount = '" _
                    & .fare.Text & "', total_amount = '" _
                    & .total1.Text & "', booking_date = '" _
                    & .bdate.Text & "', userID = '" _
                    & .useridnum1.Text & "'
                where bookingID = '" & .bID.Text & "'"
                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Customer Account Successfully Updated!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub del1_Click(sender As Object, e As EventArgs) Handles del1.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this customer?", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strsql = "Delete from booking" _
                        & " where bookingID = '" _
                        & .bID.Text & "'"

                    mycmd.CommandText = strsql
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Customer Successfully Deleted!")
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
            .bID.Text = ""
            .schedid1.Text = ""
            .custid1.Text = ""
            .seat.Text = ""
            .fare.Text = ""
            .total1.Text = ""
            .bdate.Text = ""
            .useridnum1.Text = ""
        End With
    End Sub

    Private Sub load_Click(sender As Object, e As EventArgs) Handles load.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            strsql = "Select * FROM booking"
            mycmd = New MySqlCommand(strsql, myconn)
            SDA.SelectCommand = mycmd
            SDA.Fill(dbdata)
            bSource.DataSource = dbdata
            grid.DataSource = bSource
            SDA.Update(dbdata)

            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub
End Class