Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class BusForm
    'Private Sub BusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '   myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=Y1012Jqkhkpcrissa;database=bus_bookingdb"

    ' Try
    '     myconn.Open()
    'MessageBox.Show("Connection to MySQL bus_bookingdb is successful!", "TESTING MySQL CONNECT TO DB")
    'myconn.Close()

    '   Catch ex As MySql.Data.MySqlClient.MySqlException
    '      Select Case ex.Number
    '          Case 0
    '              MsgBox("Cannot Connect to Server")
    '          Case 1045
    '             MsgBox("Invalid Username or password")
    'End Select
    '
    'End Try
    ' End Sub

    Private Sub add6_Click(sender As Object, e As EventArgs) Handles add6.Click
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

    Private Sub update6_Click(sender As Object, e As EventArgs) Handles update6.Click
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

    Private Sub del6_Click(sender As Object, e As EventArgs) Handles del6.Click
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

    Private Sub GoToMain6_Click(sender As Object, e As EventArgs) Handles GoToMain6.Click
        Me.Hide()
        MainForm.Show()
    End Sub

End Class