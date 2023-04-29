Imports MySql.Data.MySqlClient

Public Class frmBooking

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

    Private Sub addbtn_Click_1(sender As Object, e As EventArgs) Handles addbtn.Click
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
                MsgBox("Customer Successfully Added!")
                mycmd.ExecuteNonQuery()
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Call DisconnectToDB()
        End With
    End Sub

    Private Sub editbtn_Click_1(sender As Object, e As EventArgs) Handles editbtn.Click
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

    Private Sub deletebtn_Click_1(sender As Object, e As EventArgs) Handles deletebtn.Click
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

    Private Sub viewlistbtn_Click(sender As Object, e As EventArgs) Handles viewlistbtn.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            strsql = "Select * FROM booking"
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
                          "INTO TABLE booking " &
                          "FIELDS TERMINATED BY ',' " &
                          "LINES TERMINATED BY '\r\n' " &
                          "IGNORE 1 LINES"

                ' Execute the command
                cmd.ExecuteNonQuery()

                ' Create a DataTable to hold the uploaded data
                Dim dataTable As New DataTable()

                ' Create a MySQLDataAdapter to fill the DataTable
                Dim dataAdapter As New MySqlDataAdapter("SELECT * FROM booking", myconn)

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
        Call ImportToExcel(Me.DataGridView1, "bookingReport.xlsx")
    End Sub
End Class