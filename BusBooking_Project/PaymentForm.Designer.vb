<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.date1 = New System.Windows.Forms.Label()
        Me.paidamount = New System.Windows.Forms.TextBox()
        Me.del5 = New System.Windows.Forms.Button()
        Me.update5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.amount = New System.Windows.Forms.Label()
        Me.bookId1 = New System.Windows.Forms.TextBox()
        Me.bookId = New System.Windows.Forms.Label()
        Me.pid = New System.Windows.Forms.TextBox()
        Me.payid = New System.Windows.Forms.Label()
        Me.add5 = New System.Windows.Forms.Button()
        Me.userid2 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.TextBox()
        Me.searchlist = New System.Windows.Forms.Button()
        Me.GoToMain = New System.Windows.Forms.Button()
        Me.totalpay = New System.Windows.Forms.Button()
        Me.s1 = New System.Windows.Forms.TextBox()
        Me.datetext = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.datetext)
        Me.GroupBox1.Controls.Add(Me.date1)
        Me.GroupBox1.Controls.Add(Me.paidamount)
        Me.GroupBox1.Controls.Add(Me.del5)
        Me.GroupBox1.Controls.Add(Me.update5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.amount)
        Me.GroupBox1.Controls.Add(Me.bookId1)
        Me.GroupBox1.Controls.Add(Me.bookId)
        Me.GroupBox1.Controls.Add(Me.pid)
        Me.GroupBox1.Controls.Add(Me.payid)
        Me.GroupBox1.Controls.Add(Me.add5)
        Me.GroupBox1.Controls.Add(Me.userid2)
        Me.GroupBox1.Controls.Add(Me.user)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(379, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 548)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'date1
        '
        Me.date1.AutoSize = True
        Me.date1.Location = New System.Drawing.Point(72, 310)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(157, 21)
        Me.date1.TabIndex = 25
        Me.date1.Text = "Date of Payment:"
        '
        'paidamount
        '
        Me.paidamount.Location = New System.Drawing.Point(75, 266)
        Me.paidamount.Name = "paidamount"
        Me.paidamount.Size = New System.Drawing.Size(439, 28)
        Me.paidamount.TabIndex = 23
        '
        'del5
        '
        Me.del5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.del5.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.del5.Location = New System.Drawing.Point(382, 470)
        Me.del5.Name = "del5"
        Me.del5.Size = New System.Drawing.Size(133, 46)
        Me.del5.TabIndex = 22
        Me.del5.Text = "Delete"
        Me.del5.UseVisualStyleBackColor = False
        '
        'update5
        '
        Me.update5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.update5.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.update5.Location = New System.Drawing.Point(228, 470)
        Me.update5.Name = "update5"
        Me.update5.Size = New System.Drawing.Size(133, 46)
        Me.update5.TabIndex = 21
        Me.update5.Text = "Update"
        Me.update5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAYMENT DETAILS"
        '
        'amount
        '
        Me.amount.AutoSize = True
        Me.amount.Location = New System.Drawing.Point(72, 242)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(123, 21)
        Me.amount.TabIndex = 17
        Me.amount.Text = "Paid Amount:"
        '
        'bookId1
        '
        Me.bookId1.Location = New System.Drawing.Point(76, 196)
        Me.bookId1.Name = "bookId1"
        Me.bookId1.Size = New System.Drawing.Size(439, 28)
        Me.bookId1.TabIndex = 14
        '
        'bookId
        '
        Me.bookId.AutoSize = True
        Me.bookId.Location = New System.Drawing.Point(72, 172)
        Me.bookId.Name = "bookId"
        Me.bookId.Size = New System.Drawing.Size(98, 21)
        Me.bookId.TabIndex = 13
        Me.bookId.Text = "BookingID:"
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(76, 123)
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(439, 28)
        Me.pid.TabIndex = 10
        '
        'payid
        '
        Me.payid.AutoSize = True
        Me.payid.Location = New System.Drawing.Point(72, 99)
        Me.payid.Name = "payid"
        Me.payid.Size = New System.Drawing.Size(106, 21)
        Me.payid.TabIndex = 9
        Me.payid.Text = "PaymentID:"
        '
        'add5
        '
        Me.add5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.add5.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.add5.Location = New System.Drawing.Point(75, 470)
        Me.add5.Name = "add5"
        Me.add5.Size = New System.Drawing.Size(133, 46)
        Me.add5.TabIndex = 5
        Me.add5.Text = "Add"
        Me.add5.UseVisualStyleBackColor = False
        '
        'userid2
        '
        Me.userid2.AutoSize = True
        Me.userid2.Location = New System.Drawing.Point(71, 378)
        Me.userid2.Name = "userid2"
        Me.userid2.Size = New System.Drawing.Size(68, 21)
        Me.userid2.TabIndex = 3
        Me.userid2.Text = "UserID:"
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(75, 402)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(439, 28)
        Me.user.TabIndex = 1
        '
        'searchlist
        '
        Me.searchlist.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.searchlist.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchlist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.searchlist.Location = New System.Drawing.Point(203, 91)
        Me.searchlist.Name = "searchlist"
        Me.searchlist.Size = New System.Drawing.Size(117, 32)
        Me.searchlist.TabIndex = 19
        Me.searchlist.Text = "Search"
        Me.searchlist.UseVisualStyleBackColor = False
        '
        'GoToMain
        '
        Me.GoToMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GoToMain.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoToMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GoToMain.Location = New System.Drawing.Point(64, 149)
        Me.GoToMain.Name = "GoToMain"
        Me.GoToMain.Size = New System.Drawing.Size(256, 46)
        Me.GoToMain.TabIndex = 18
        Me.GoToMain.Text = "Back to Main Form"
        Me.GoToMain.UseVisualStyleBackColor = False
        '
        'totalpay
        '
        Me.totalpay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.totalpay.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalpay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.totalpay.Location = New System.Drawing.Point(64, 222)
        Me.totalpay.Name = "totalpay"
        Me.totalpay.Size = New System.Drawing.Size(256, 46)
        Me.totalpay.TabIndex = 21
        Me.totalpay.Text = "Go to Total Payment"
        Me.totalpay.UseVisualStyleBackColor = False
        '
        's1
        '
        Me.s1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s1.Location = New System.Drawing.Point(64, 91)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(133, 28)
        Me.s1.TabIndex = 22
        '
        'datetext
        '
        Me.datetext.Location = New System.Drawing.Point(76, 334)
        Me.datetext.Name = "datetext"
        Me.datetext.Size = New System.Drawing.Size(439, 28)
        Me.datetext.TabIndex = 26
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 633)
        Me.Controls.Add(Me.s1)
        Me.Controls.Add(Me.totalpay)
        Me.Controls.Add(Me.searchlist)
        Me.Controls.Add(Me.GoToMain)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "PaymentForm"
        Me.Text = "PaymentForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents paidamount As TextBox
    Friend WithEvents del5 As Button
    Friend WithEvents update5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents amount As Label
    Friend WithEvents bookId1 As TextBox
    Friend WithEvents bookId As Label
    Friend WithEvents pid As TextBox
    Friend WithEvents payid As Label
    Friend WithEvents add5 As Button
    Friend WithEvents userid2 As Label
    Friend WithEvents user As TextBox
    Friend WithEvents date1 As Label
    Friend WithEvents searchlist As Button
    Friend WithEvents GoToMain As Button
    Friend WithEvents totalpay As Button
    Friend WithEvents s1 As TextBox
    Friend WithEvents datetext As TextBox
End Class
