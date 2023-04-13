Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class DriverForm
    'Private Sub DriverForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=Y1012Jqkhkpcrissa;database=bus_bookingdb"


    'Try
    '       myconn.Open()
    'MessageBox.Show("Connection to MySQL bus_bookingdb is successful!", "TESTING MySQL CONNECT TO DB")
    'myconn.Close()

    '        Catch ex As MySql.Data.MySqlClient.MySqlException
    '            Select Case ex.Number
    '               Case 0
    '                  MsgBox("Cannot Connect to Server")
    '             Case 1045
    '                MsgBox("Invalid Username or password")
    'End Select

    'End Try
    'End Sub
    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strsql = "Select * from driver where driverID = '" _
                & .search4.Text & "'"

            mycmd.CommandText = strsql
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .dID.Text = myreader.GetString(0)
                    .dname.Text = myreader.GetString(1)
                    .dcontact.Text = myreader.GetString(2)
                    .u2.Text = myreader.GetString(3)
                End While
            Else
                MsgBox("UserID does not exist!")
            End If
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub add4_Click(sender As Object, e As EventArgs) Handles add4.Click
        With Me
            Dim mycmd As New MySqlCommand

            Try
                strsql = "Insert into driver values('" _
                    & .dID.Text & "', '" _
                    & .dname.Text & "','" _
                    & .dcontact.Text & "','" _
                    & .u2.Text & "')"

                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Driver Successfully Added!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)

            End Try
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub update4_Click(sender As Object, e As EventArgs) Handles update4.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                strsql = "Update driver set driver_name = '" _
                    & .dname.Text & "' driver_contact = '" _
                    & .dcontact.Text & "' userID = '" _
                    & .u2.Text & "'
                     WHERE driverID='" & dID.Text & "'"
                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Driver Successfully Updated!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub del4_Click(sender As Object, e As EventArgs) Handles del4.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this driver?", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strsql = "Delete from driver" _
                        & " where driverID = '" _
                        & .dID.Text & "'"

                    mycmd.CommandText = strsql
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Driver Successfully Deleted!")
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
            .dID.Text = ""
            .dname.Text = ""
            .dcontact.Text = ""
            .u2.Text = ""
        End With
    End Sub

    Private Sub GoToMain4_Click(sender As Object, e As EventArgs) Handles GoToMain4.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class