Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmMain

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        frmBooking.Show()
    End Sub

    Private Sub btnBus_Click(sender As Object, e As EventArgs) Handles btnBus.Click
        frmBus.Show()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()
    End Sub

    Private Sub btnDriver_Click(sender As Object, e As EventArgs) Handles btnDriver.Click
        frmDriver.Show()
    End Sub

    Private Sub btnTravelSched_Click(sender As Object, e As EventArgs) Handles btnTravelSched.Click
        frmTravelSched.Show()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        frmPayment.Show()
    End Sub

    Private Sub btnTotalPayment_Click(sender As Object, e As EventArgs) Handles btnTotalPayment.Click
        frmTotalPayment.Show()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        frmUser.Show()
    End Sub


    Private Sub btnBackupDB_Click(sender As Object, e As EventArgs) Handles btnBackupDB.Click
        'Specify the database credentials
        Dim server As String = "localhost"
        Dim username As String = "root"
        Dim password As String = "Y1012Jqkhkpcrissa"
        Dim database As String = "bus_bookingdb"

        'Allow the user to specify the location of the backup file
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "SQL backup files (*.sql)|*.sql|All files (*.*)|*.*"
        saveFileDialog1.FileName = "bus_bookingdb.sql"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim backupFile As String = saveFileDialog1.FileName

            'Construct the mysqldump command process
            Dim mysqldump As New Process()
            mysqldump.StartInfo.FileName = "mysqldump.exe"
            mysqldump.StartInfo.Arguments = String.Format("--user={0} --password={1} --host={2} --protocol=tcp --port=3306 --default-character-set=utf8mb4 --skip-triggers --add-drop-table --result-file=""{3}"" ""{4}""", username, password, server, backupFile, database)
            mysqldump.StartInfo.UseShellExecute = False
            mysqldump.StartInfo.RedirectStandardOutput = True
            mysqldump.StartInfo.RedirectStandardError = True

            'Start the mysqldump process
            mysqldump.Start()
            'Wait to finish the process
            mysqldump.WaitForExit()

            'Condition if
            If mysqldump.ExitCode = 0 Then
                MessageBox.Show("Backup Completed Successfully")
            Else
                MessageBox.Show("Failed to Create Database Backup File")
            End If
        End If
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Close the current form
        Me.Close()
        ' Open the login form
        Dim frmLogin As New frmLogin
        frmLogin.Show()
    End Sub


End Class