Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class TotalPaymentForm
    ' Private Sub TotalPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '   myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=Y1012Jqkhkpcrissa;database=bus_bookingdb"

    '  Try
    '      myconn.Open()
    'MessageBox.Show("Connection to MySQL bus_bookingdb is successful!", "TESTING MySQL CONNECT TO DB")
    'myconn.Close()

    ' Catch ex As MySql.Data.MySqlClient.MySqlException
    '    Select Case ex.Number
    '        Case 0
    '            MsgBox("Cannot Connect to Server")
    '        Case 1045
    '            MsgBox("Invalid Username or password")
    'End Select

    'End Try
    'End Sub
    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strsql = "Select * from totalpayment where user_ID = '" _
                & .search1.Text & "'"

            mycmd.CommandText = strsql
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .uID.Text = myreader.GetString(0)
                    .total.Text = myreader.GetDouble(1)
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
                strsql = "Insert into totalpayment values('" _
                & .uID.Text & "', '" _
                & .total.Text & "')"

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
                strsql = "Update totalpayment set total = '" _
                    & total.Text & "'
                    where user_ID = '" & .uID.Text & "'"
                mycmd.CommandText = strsql
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Updated!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            DisconnectToDB()
        End With
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        With Me
            Call ConnectToDB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strsql = "Delete from totalpayment" _
                        & " where user_ID = '" _
                        & .uID.Text & "'"

                    mycmd.CommandText = strsql
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Record Successfully Deleted!")
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

            .uID.Text = ""
            .total.Text = ""
        End With
    End Sub

    Private Sub GoToMain6_Click(sender As Object, e As EventArgs) Handles GoToMain6.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub loaddb_Click(sender As Object, e As EventArgs) Handles loaddb.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            strsql = "Select * FROM totalpayment"
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

    Private Sub TotalPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class