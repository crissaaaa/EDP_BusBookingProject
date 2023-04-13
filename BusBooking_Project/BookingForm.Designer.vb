<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingForm
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
        Me.bdate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.del1 = New System.Windows.Forms.Button()
        Me.update1 = New System.Windows.Forms.Button()
        Me.add1 = New System.Windows.Forms.Button()
        Me.useridnum1 = New System.Windows.Forms.TextBox()
        Me.emailadd = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.seat = New System.Windows.Forms.TextBox()
        Me.custid1 = New System.Windows.Forms.TextBox()
        Me.schedid1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bID = New System.Windows.Forms.TextBox()
        Me.bookingid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.total1 = New System.Windows.Forms.TextBox()
        Me.fare = New System.Windows.Forms.TextBox()
        Me.s01 = New System.Windows.Forms.TextBox()
        Me.search1 = New System.Windows.Forms.Button()
        Me.GoToMain0 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.load = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.bdate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.del1)
        Me.GroupBox1.Controls.Add(Me.update1)
        Me.GroupBox1.Controls.Add(Me.add1)
        Me.GroupBox1.Controls.Add(Me.useridnum1)
        Me.GroupBox1.Controls.Add(Me.emailadd)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.seat)
        Me.GroupBox1.Controls.Add(Me.custid1)
        Me.GroupBox1.Controls.Add(Me.schedid1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.bID)
        Me.GroupBox1.Controls.Add(Me.bookingid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.total1)
        Me.GroupBox1.Controls.Add(Me.fare)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(995, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 727)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'bdate
        '
        Me.bdate.Location = New System.Drawing.Point(75, 504)
        Me.bdate.Name = "bdate"
        Me.bdate.Size = New System.Drawing.Size(439, 28)
        Me.bdate.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 478)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Booking Date:"
        '
        'del1
        '
        Me.del1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.del1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.del1.Location = New System.Drawing.Point(381, 624)
        Me.del1.Name = "del1"
        Me.del1.Size = New System.Drawing.Size(133, 46)
        Me.del1.TabIndex = 28
        Me.del1.Text = "Delete"
        Me.del1.UseVisualStyleBackColor = False
        '
        'update1
        '
        Me.update1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.update1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.update1.Location = New System.Drawing.Point(226, 624)
        Me.update1.Name = "update1"
        Me.update1.Size = New System.Drawing.Size(133, 46)
        Me.update1.TabIndex = 27
        Me.update1.Text = "Update"
        Me.update1.UseVisualStyleBackColor = False
        '
        'add1
        '
        Me.add1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.add1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.add1.Location = New System.Drawing.Point(75, 624)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(133, 46)
        Me.add1.TabIndex = 26
        Me.add1.Text = "Add"
        Me.add1.UseVisualStyleBackColor = False
        '
        'useridnum1
        '
        Me.useridnum1.Location = New System.Drawing.Point(75, 573)
        Me.useridnum1.Name = "useridnum1"
        Me.useridnum1.Size = New System.Drawing.Size(439, 28)
        Me.useridnum1.TabIndex = 19
        '
        'emailadd
        '
        Me.emailadd.AutoSize = True
        Me.emailadd.Location = New System.Drawing.Point(71, 266)
        Me.emailadd.Name = "emailadd"
        Me.emailadd.Size = New System.Drawing.Size(115, 21)
        Me.emailadd.TabIndex = 18
        Me.emailadd.Text = "No. of Seats:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 21)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "CustomerID:"
        '
        'seat
        '
        Me.seat.Location = New System.Drawing.Point(75, 290)
        Me.seat.Name = "seat"
        Me.seat.Size = New System.Drawing.Size(439, 28)
        Me.seat.TabIndex = 16
        '
        'custid1
        '
        Me.custid1.Location = New System.Drawing.Point(75, 221)
        Me.custid1.Name = "custid1"
        Me.custid1.Size = New System.Drawing.Size(439, 28)
        Me.custid1.TabIndex = 15
        '
        'schedid1
        '
        Me.schedid1.Location = New System.Drawing.Point(75, 157)
        Me.schedid1.Name = "schedid1"
        Me.schedid1.Size = New System.Drawing.Size(439, 28)
        Me.schedid1.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "SchedID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 549)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "UserID:"
        '
        'bID
        '
        Me.bID.Location = New System.Drawing.Point(75, 89)
        Me.bID.Name = "bID"
        Me.bID.Size = New System.Drawing.Size(439, 28)
        Me.bID.TabIndex = 10
        '
        'bookingid
        '
        Me.bookingid.AutoSize = True
        Me.bookingid.Location = New System.Drawing.Point(71, 65)
        Me.bookingid.Name = "bookingid"
        Me.bookingid.Size = New System.Drawing.Size(98, 21)
        Me.bookingid.TabIndex = 9
        Me.bookingid.Text = "BookingID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 405)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fare Amount:"
        '
        'total1
        '
        Me.total1.Location = New System.Drawing.Point(75, 429)
        Me.total1.Name = "total1"
        Me.total1.Size = New System.Drawing.Size(439, 28)
        Me.total1.TabIndex = 3
        '
        'fare
        '
        Me.fare.Location = New System.Drawing.Point(75, 360)
        Me.fare.Name = "fare"
        Me.fare.Size = New System.Drawing.Size(439, 28)
        Me.fare.TabIndex = 1
        '
        's01
        '
        Me.s01.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s01.Location = New System.Drawing.Point(34, 135)
        Me.s01.Name = "s01"
        Me.s01.Size = New System.Drawing.Size(752, 28)
        Me.s01.TabIndex = 27
        '
        'search1
        '
        Me.search1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.search1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.search1.Location = New System.Drawing.Point(792, 135)
        Me.search1.Name = "search1"
        Me.search1.Size = New System.Drawing.Size(167, 32)
        Me.search1.TabIndex = 26
        Me.search1.Text = "Search"
        Me.search1.UseVisualStyleBackColor = False
        '
        'GoToMain0
        '
        Me.GoToMain0.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GoToMain0.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoToMain0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GoToMain0.Location = New System.Drawing.Point(34, 38)
        Me.GoToMain0.Name = "GoToMain0"
        Me.GoToMain0.Size = New System.Drawing.Size(63, 32)
        Me.GoToMain0.TabIndex = 25
        Me.GoToMain0.Text = "<"
        Me.GoToMain0.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(28, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(400, 32)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Bus Booking Information Form"
        '
        'grid
        '
        Me.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(34, 211)
        Me.grid.Name = "grid"
        Me.grid.RowHeadersWidth = 51
        Me.grid.RowTemplate.Height = 24
        Me.grid.Size = New System.Drawing.Size(925, 533)
        Me.grid.TabIndex = 29
        '
        'load
        '
        Me.load.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.load.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.load.Location = New System.Drawing.Point(790, 173)
        Me.load.Name = "load"
        Me.load.Size = New System.Drawing.Size(169, 32)
        Me.load.TabIndex = 30
        Me.load.Text = "Load Table"
        Me.load.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(372, 747)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(208, 18)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Overview of Booking Table"
        '
        'BookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1640, 822)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.load)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.s01)
        Me.Controls.Add(Me.search1)
        Me.Controls.Add(Me.GoToMain0)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BookingForm"
        Me.Text = "BookingForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents del1 As Button
    Friend WithEvents update1 As Button
    Friend WithEvents add1 As Button
    Friend WithEvents useridnum1 As TextBox
    Friend WithEvents emailadd As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents seat As TextBox
    Friend WithEvents custid1 As TextBox
    Friend WithEvents schedid1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bID As TextBox
    Friend WithEvents bookingid As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents total1 As TextBox
    Friend WithEvents fare As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bdate As TextBox
    Friend WithEvents s01 As TextBox
    Friend WithEvents search1 As Button
    Friend WithEvents GoToMain0 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents grid As DataGridView
    Friend WithEvents load As Button
    Friend WithEvents Label8 As Label
End Class
