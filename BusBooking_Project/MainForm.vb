Public Class MainForm
    Private Sub book_Click(sender As Object, e As EventArgs) Handles book.Click
        BookingForm.Show()
    End Sub

    Private Sub sched_Click(sender As Object, e As EventArgs) Handles sched.Click
        TravelSchedForm.Show()
    End Sub

    Private Sub bus_Click(sender As Object, e As EventArgs) Handles bus.Click
        BusForm.Show()
    End Sub

    Private Sub payment_Click(sender As Object, e As EventArgs) Handles payment.Click
        PaymentForm.Show()
    End Sub

    Private Sub driver_Click(sender As Object, e As EventArgs) Handles driver.Click
        DriverForm.Show()
    End Sub

    Private Sub total_Click(sender As Object, e As EventArgs) Handles total.Click
        TotalPaymentForm.Show()
    End Sub

    Private Sub customer_Click(sender As Object, e As EventArgs) Handles customer.Click
        CustomerForm.Show()
    End Sub

    Private Sub userbtn_Click(sender As Object, e As EventArgs) Handles userbtn.Click
        User.Show()
    End Sub

    Private Sub backup_Click(sender As Object, e As EventArgs) Handles backup.Click
        Dim RetVal
        RetVal = Shell("D:\EDP\backupfunction.bat", 1)
    End Sub
End Class