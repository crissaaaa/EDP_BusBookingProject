<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBooking))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bdate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.search1 = New System.Windows.Forms.Button()
        Me.s01 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.menubtn = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.uploadbtn = New System.Windows.Forms.PictureBox()
        Me.deletebtn = New System.Windows.Forms.PictureBox()
        Me.editbtn = New System.Windows.Forms.PictureBox()
        Me.addbtn = New System.Windows.Forms.PictureBox()
        Me.printbtn = New System.Windows.Forms.PictureBox()
        Me.viewlistbtn = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uploadbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deletebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewlistbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.bdate)
        Me.GroupBox1.Controls.Add(Me.Label1)
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
        Me.GroupBox1.Location = New System.Drawing.Point(157, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1051, 210)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'bdate
        '
        Me.bdate.Location = New System.Drawing.Point(662, 91)
        Me.bdate.Name = "bdate"
        Me.bdate.Size = New System.Drawing.Size(305, 28)
        Me.bdate.TabIndex = 31
        Me.bdate.Text = "yyyy-mm-dd"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(528, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Booking Date:"
        '
        'useridnum1
        '
        Me.useridnum1.Location = New System.Drawing.Point(869, 50)
        Me.useridnum1.Name = "useridnum1"
        Me.useridnum1.Size = New System.Drawing.Size(98, 28)
        Me.useridnum1.TabIndex = 19
        '
        'emailadd
        '
        Me.emailadd.AutoSize = True
        Me.emailadd.Location = New System.Drawing.Point(71, 94)
        Me.emailadd.Name = "emailadd"
        Me.emailadd.Size = New System.Drawing.Size(115, 21)
        Me.emailadd.TabIndex = 18
        Me.emailadd.Text = "No. of Seats:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(528, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 21)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "CustomerID:"
        '
        'seat
        '
        Me.seat.Location = New System.Drawing.Point(192, 91)
        Me.seat.Name = "seat"
        Me.seat.Size = New System.Drawing.Size(315, 28)
        Me.seat.TabIndex = 16
        '
        'custid1
        '
        Me.custid1.Location = New System.Drawing.Point(647, 46)
        Me.custid1.Name = "custid1"
        Me.custid1.Size = New System.Drawing.Size(98, 28)
        Me.custid1.TabIndex = 15
        '
        'schedid1
        '
        Me.schedid1.Location = New System.Drawing.Point(396, 46)
        Me.schedid1.Name = "schedid1"
        Me.schedid1.Size = New System.Drawing.Size(111, 28)
        Me.schedid1.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(305, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "SchedID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(795, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "UserID:"
        '
        'bID
        '
        Me.bID.Location = New System.Drawing.Point(175, 46)
        Me.bID.Name = "bID"
        Me.bID.Size = New System.Drawing.Size(98, 28)
        Me.bID.TabIndex = 10
        '
        'bookingid
        '
        Me.bookingid.AutoSize = True
        Me.bookingid.Location = New System.Drawing.Point(71, 49)
        Me.bookingid.Name = "bookingid"
        Me.bookingid.Size = New System.Drawing.Size(98, 21)
        Me.bookingid.TabIndex = 9
        Me.bookingid.Text = "BookingID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(529, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fare Amount:"
        '
        'total1
        '
        Me.total1.Location = New System.Drawing.Point(662, 138)
        Me.total1.Name = "total1"
        Me.total1.Size = New System.Drawing.Size(305, 28)
        Me.total1.TabIndex = 3
        '
        'fare
        '
        Me.fare.Location = New System.Drawing.Point(199, 138)
        Me.fare.Name = "fare"
        Me.fare.Size = New System.Drawing.Size(308, 28)
        Me.fare.TabIndex = 1
        '
        'search1
        '
        Me.search1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.search1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.search1.Location = New System.Drawing.Point(1235, 15)
        Me.search1.Name = "search1"
        Me.search1.Size = New System.Drawing.Size(111, 32)
        Me.search1.TabIndex = 26
        Me.search1.Text = "Search"
        Me.search1.UseVisualStyleBackColor = False
        '
        's01
        '
        Me.s01.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s01.Location = New System.Drawing.Point(987, 17)
        Me.s01.Name = "s01"
        Me.s01.Size = New System.Drawing.Size(242, 28)
        Me.s01.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(112, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(328, 32)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Bus Booking Information"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(157, 423)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1051, 309)
        Me.DataGridView1.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(571, 735)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(208, 18)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Overview of Booking Table"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(931, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 37)
        Me.Label9.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Panel1.Controls.Add(Me.menubtn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.s01)
        Me.Panel1.Controls.Add(Me.search1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1359, 66)
        Me.Panel1.TabIndex = 35
        '
        'menubtn
        '
        Me.menubtn.Image = CType(resources.GetObject("menubtn.Image"), System.Drawing.Image)
        Me.menubtn.Location = New System.Drawing.Point(40, 17)
        Me.menubtn.Name = "menubtn"
        Me.menubtn.Size = New System.Drawing.Size(42, 33)
        Me.menubtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.menubtn.TabIndex = 29
        Me.menubtn.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(596, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 23)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Booking Form"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(580, 387)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 23)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Booking Records"
        '
        'uploadbtn
        '
        Me.uploadbtn.Image = CType(resources.GetObject("uploadbtn.Image"), System.Drawing.Image)
        Me.uploadbtn.Location = New System.Drawing.Point(1043, 380)
        Me.uploadbtn.Name = "uploadbtn"
        Me.uploadbtn.Size = New System.Drawing.Size(40, 30)
        Me.uploadbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.uploadbtn.TabIndex = 41
        Me.uploadbtn.TabStop = False
        '
        'deletebtn
        '
        Me.deletebtn.Image = CType(resources.GetObject("deletebtn.Image"), System.Drawing.Image)
        Me.deletebtn.Location = New System.Drawing.Point(1111, 109)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(40, 30)
        Me.deletebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.deletebtn.TabIndex = 40
        Me.deletebtn.TabStop = False
        '
        'editbtn
        '
        Me.editbtn.Image = CType(resources.GetObject("editbtn.Image"), System.Drawing.Image)
        Me.editbtn.Location = New System.Drawing.Point(1041, 109)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(37, 30)
        Me.editbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editbtn.TabIndex = 39
        Me.editbtn.TabStop = False
        '
        'addbtn
        '
        Me.addbtn.Image = CType(resources.GetObject("addbtn.Image"), System.Drawing.Image)
        Me.addbtn.Location = New System.Drawing.Point(970, 109)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(29, 30)
        Me.addbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addbtn.TabIndex = 38
        Me.addbtn.TabStop = False
        '
        'printbtn
        '
        Me.printbtn.Image = CType(resources.GetObject("printbtn.Image"), System.Drawing.Image)
        Me.printbtn.Location = New System.Drawing.Point(1120, 380)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(31, 30)
        Me.printbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.printbtn.TabIndex = 37
        Me.printbtn.TabStop = False
        '
        'viewlistbtn
        '
        Me.viewlistbtn.Image = CType(resources.GetObject("viewlistbtn.Image"), System.Drawing.Image)
        Me.viewlistbtn.Location = New System.Drawing.Point(970, 378)
        Me.viewlistbtn.Name = "viewlistbtn"
        Me.viewlistbtn.Size = New System.Drawing.Size(37, 32)
        Me.viewlistbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.viewlistbtn.TabIndex = 30
        Me.viewlistbtn.TabStop = False
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 794)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.uploadbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.printbtn)
        Me.Controls.Add(Me.viewlistbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookingForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uploadbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deletebtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewlistbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents s01 As TextBox
    Friend WithEvents search1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bdate As TextBox
    Friend WithEvents menubtn As PictureBox
    Friend WithEvents viewlistbtn As PictureBox
    Friend WithEvents printbtn As PictureBox
    Friend WithEvents addbtn As PictureBox
    Friend WithEvents editbtn As PictureBox
    Friend WithEvents deletebtn As PictureBox
    Friend WithEvents uploadbtn As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
