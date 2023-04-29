Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class frmPayment
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

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
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

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
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

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
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

    Private Sub viewlistbtn_Click(sender As Object, e As EventArgs) Handles viewlistbtn.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            strsql = "Select * FROM payment"
            mycmd = New MySqlCommand(strsql, myconn)
            SDA.SelectCommand = mycmd
            SDA.Fill(dbdata)
            bSource.DataSource = dbdata
            DataGridView1.DataSource = bSource
            ' Auto-size the columns of the DataGridView
            DataGridView1.AutoResizeColumns()
            SDA.Update(dbdata)

            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub uploadbtn_Click(sender As Object, e As EventArgs) Handles uploadbtn.Click
        ' Create an OpenFileDialog to allow the user to select a file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv"
        openFileDialog.Multiselect = False
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Open the database connection
                ConnectToDB()

                ' Create the MySQL command to execute the LOAD DATA INFILE statement
                Dim cmd As MySqlCommand = New MySqlCommand()
                cmd.Connection = myconn
                cmd.CommandText = "LOAD DATA INFILE '" & openFileDialog.FileName.Replace("\", "/") & "' " &
                          "INTO TABLE payment " &
                          "FIELDS TERMINATED BY ',' " &
                          "LINES TERMINATED BY '\r\n' " &
                          "IGNORE 1 LINES"

                ' Execute the command
                cmd.ExecuteNonQuery()

                ' Create a DataTable to hold the uploaded data
                Dim dataTable As New DataTable()

                ' Create a MySQLDataAdapter to fill the DataTable
                Dim dataAdapter As New MySqlDataAdapter("SELECT * FROM payment", myconn)

                ' Fill the DataTable
                dataAdapter.Fill(dataTable)

                ' Set the DataSource of the DataGridView to the DataTable
                DataGridView1.DataSource = dataTable

                ' Auto-size the columns of the DataGridView
                DataGridView1.AutoResizeColumns()

                ' Display a message box to inform the user that the data has been uploaded and displayed
                MessageBox.Show("Data uploaded and displayed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                ' Handle any exceptions
                MessageBox.Show("An error occurred while uploading and displaying the data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                ' Close the database connection
                DisconnectToDB()

            End Try
        End If
    End Sub

    Private Sub menubtn_Click(sender As Object, e As EventArgs) Handles menubtn.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        Call ImportToExcel(Me.DataGridView1, "paymentReport1.xlsx")
    End Sub
End Class