Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports Excel = Microsoft.Office.Interop.Excel


Public Class frmTravelSched
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
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

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
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

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
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

    Private Sub viewlistbtn_Click(sender As Object, e As EventArgs) Handles viewlistbtn.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            strsql = "Select * FROM travel_sched"
            mycmd = New MySqlCommand(strsql, myconn)
            SDA.SelectCommand = mycmd
            SDA.Fill(dbdata)
            bSource.DataSource = dbdata
            DataGridView7.DataSource = bSource

            ' Auto-size the columns of the DataGridView
            DataGridView7.AutoResizeColumns()
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
                          "INTO TABLE travel_sched " &
                          "FIELDS TERMINATED BY ',' " &
                          "LINES TERMINATED BY '\r\n' " &
                          "IGNORE 1 LINES"

                ' Execute the command
                cmd.ExecuteNonQuery()

                ' Create a DataTable to hold the uploaded data
                Dim dataTable As New DataTable()

                ' Create a MySQLDataAdapter to fill the DataTable
                Dim dataAdapter As New MySqlDataAdapter("SELECT * FROM travel_sched", myconn)

                ' Fill the DataTable
                dataAdapter.Fill(dataTable)

                ' Set the DataSource of the DataGridView to the DataTable
                DataGridView7.DataSource = dataTable

                ' Auto-size the columns of the DataGridView
                DataGridView7.AutoResizeColumns()

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
        Call ImportToExcel(Me.DataGridView7, "travel_schedReport.xlsx")
    End Sub
End Class