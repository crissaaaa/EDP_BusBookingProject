Imports MySql.Data.MySqlClient


Public Class TravelSchedForm
    ' Private Sub TravelSchedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=Y1012Jqkhkpcrissa;database=bus_bookingdb"
    '    Try
    '        myconn.Open()
    'MessageBox.Show("Connection to MySQL bus_bookingdb is successful!", "TESTING MySQL CONNECT TO DB")
    'myconn.Close()

    '    Catch ex As MySql.Data.MySqlClient.MySqlException
    '        Select Case ex.Number
    '            Case 0
    '                MsgBox("Cannot Connect to Server")
    '           Case 1045
    '               MsgBox("Invalid Username or password")
    'End Select
    ' End Try
    'End Sub

    Private Sub Clear_Boxes()
        With Me
            .tsID.Text = ""
            .busid0.Text = ""
            .startpt.Text = ""
            .dest.Text = ""
            .date1.Text = ""
            .time1.Text = ""
            .useridnum2.Text = ""
            .bookid1.Text = ""
        End With
    End Sub

    Private Sub add0_Click(sender As Object, e As EventArgs) Handles add0.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand

            Try
                strsql = "Insert into travel_sched values('" _
                    & .tsID.Text & "', '" _
                    & .busid0.Text & "' , '" _
                    & .startpt.Text & "', '" _
                    & .dest.Text & "', '" _
                    & .date1.Text & "', '" _
                    & .time1.Text & "', '" _
                    & .useridnum2.Text & "', '" _
                    & .bookid1.Text & "')"

                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Travel Schedule Added Successfully!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)

            End Try
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub update0_Click(sender As Object, e As EventArgs) Handles update0.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                strsql = "Update travel_sched set busID = '" _
                    & .busid0.Text & "', starting_pt = '" _
                    & .startpt.Text & "', destination = '" _
                    & .dest.Text & "', sched_date = '" _
                    & .date1.Text & "', sched_time = '" _
                    & .time1.Text & "', userID = '" _
                    & .useridnum2.Text & "', bookingID = '" _
                    & .bookid1.Text & "'
                where schedID = '" & .tsID.Text & "'"
                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Travel Schedule Updated Successfully!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub del0_Click(sender As Object, e As EventArgs) Handles del0.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this schedule record?", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strsql = "Delete from travel_sched" _
                        & " where schedID = '" _
                        & .tsID.Text & "'"

                    mycmd.CommandText = strsql
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Travel Schedule Successfully Deleted!")
                    Call Clear_Boxes()
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub search0_Click(sender As Object, e As EventArgs) Handles search0.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strsql = "Select * from travel_sched where schedID = '" _
                & .s01.Text & "'"

            mycmd.CommandText = strsql
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .tsID.Text = myreader.GetString(0)
                    .busid0.Text = myreader.GetString(1)
                    .startpt.Text = myreader.GetString(2)
                    .dest.Text = myreader.GetString(3)
                    .date1.Text = myreader.GetMySqlDateTime(4)
                    .time1.Text = myreader.GetString(5)
                    .useridnum2.Text = myreader.GetString(6)
                    .bookid1.Text = myreader.GetString(7)

                End While
            Else
                MsgBox("schedID does not exist!")
            End If
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub loaddb_Click(sender As Object, e As EventArgs) Handles loaddb.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            strsql = "Select * FROM travel_sched"
            mycmd = New MySqlCommand(strsql, myconn)
            SDA.SelectCommand = mycmd
            SDA.Fill(dbdata)
            bSource.DataSource = dbdata
            grid2.DataSource = bSource
            SDA.Update(dbdata)

            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub GoToMain0_Click(sender As Object, e As EventArgs) Handles GoToMain0.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class