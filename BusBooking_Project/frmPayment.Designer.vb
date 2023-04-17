<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.datetext = New System.Windows.Forms.TextBox()
        Me.date1 = New System.Windows.Forms.Label()
        Me.paidamount = New System.Windows.Forms.TextBox()
        Me.amount = New System.Windows.Forms.Label()
        Me.bookId1 = New System.Windows.Forms.TextBox()
        Me.bookId = New System.Windows.Forms.Label()
        Me.pid = New System.Windows.Forms.TextBox()
        Me.payid = New System.Windows.Forms.Label()
        Me.userid2 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchlist = New System.Windows.Forms.Button()
        Me.s1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.menubtn = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.uploadbtn = New System.Windows.Forms.PictureBox()
        Me.deletebtn = New System.Windows.Forms.PictureBox()
        Me.editbtn = New System.Windows.Forms.PictureBox()
        Me.addbtn = New System.Windows.Forms.PictureBox()
        Me.printbtn = New System.Windows.Forms.PictureBox()
        Me.viewlistbtn = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uploadbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deletebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewlistbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.datetext)
        Me.GroupBox1.Controls.Add(Me.date1)
        Me.GroupBox1.Controls.Add(Me.paidamount)
        Me.GroupBox1.Controls.Add(Me.amount)
        Me.GroupBox1.Controls.Add(Me.bookId1)
        Me.GroupBox1.Controls.Add(Me.bookId)
        Me.GroupBox1.Controls.Add(Me.pid)
        Me.GroupBox1.Controls.Add(Me.payid)
        Me.GroupBox1.Controls.Add(Me.userid2)
        Me.GroupBox1.Controls.Add(Me.user)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(223, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(885, 257)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'datetext
        '
        Me.datetext.Location = New System.Drawing.Point(260, 173)
        Me.datetext.Name = "datetext"
        Me.datetext.Size = New System.Drawing.Size(216, 28)
        Me.datetext.TabIndex = 26
        '
        'date1
        '
        Me.date1.AutoSize = True
        Me.date1.Location = New System.Drawing.Point(102, 176)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(157, 21)
        Me.date1.TabIndex = 25
        Me.date1.Text = "Date of Payment:"
        '
        'paidamount
        '
        Me.paidamount.Location = New System.Drawing.Point(260, 121)
        Me.paidamount.Name = "paidamount"
        Me.paidamount.Size = New System.Drawing.Size(493, 28)
        Me.paidamount.TabIndex = 23
        '
        'amount
        '
        Me.amount.AutoSize = True
        Me.amount.Location = New System.Drawing.Point(102, 124)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(123, 21)
        Me.amount.TabIndex = 17
        Me.amount.Text = "Paid Amount:"
        '
        'bookId1
        '
        Me.bookId1.Location = New System.Drawing.Point(588, 68)
        Me.bookId1.Name = "bookId1"
        Me.bookId1.Size = New System.Drawing.Size(165, 28)
        Me.bookId1.TabIndex = 14
        '
        'bookId
        '
        Me.bookId.AutoSize = True
        Me.bookId.Location = New System.Drawing.Point(491, 71)
        Me.bookId.Name = "bookId"
        Me.bookId.Size = New System.Drawing.Size(98, 21)
        Me.bookId.TabIndex = 13
        Me.bookId.Text = "BookingID:"
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(260, 68)
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(216, 28)
        Me.pid.TabIndex = 10
        '
        'payid
        '
        Me.payid.AutoSize = True
        Me.payid.Location = New System.Drawing.Point(102, 71)
        Me.payid.Name = "payid"
        Me.payid.Size = New System.Drawing.Size(106, 21)
        Me.payid.TabIndex = 9
        Me.payid.Text = "PaymentID:"
        '
        'userid2
        '
        Me.userid2.AutoSize = True
        Me.userid2.Location = New System.Drawing.Point(491, 173)
        Me.userid2.Name = "userid2"
        Me.userid2.Size = New System.Drawing.Size(68, 21)
        Me.userid2.TabIndex = 3
        Me.userid2.Text = "UserID:"
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(588, 166)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(165, 28)
        Me.user.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gotham Rounded Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(572, 433)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payment Records"
        '
        'searchlist
        '
        Me.searchlist.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.searchlist.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchlist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.searchlist.Location = New System.Drawing.Point(1200, 16)
        Me.searchlist.Name = "searchlist"
        Me.searchlist.Size = New System.Drawing.Size(117, 32)
        Me.searchlist.TabIndex = 19
        Me.searchlist.Text = "Search"
        Me.searchlist.UseVisualStyleBackColor = False
        '
        's1
        '
        Me.s1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s1.Location = New System.Drawing.Point(930, 16)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(264, 28)
        Me.s1.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Panel1.Controls.Add(Me.menubtn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.searchlist)
        Me.Panel1.Controls.Add(Me.s1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1359, 66)
        Me.Panel1.TabIndex = 44
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(112, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(285, 32)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Payment Information"
        '
        'uploadbtn
        '
        Me.uploadbtn.Image = CType(resources.GetObject("uploadbtn.Image"), System.Drawing.Image)
        Me.uploadbtn.Location = New System.Drawing.Point(903, 425)
        Me.uploadbtn.Name = "uploadbtn"
        Me.uploadbtn.Size = New System.Drawing.Size(40, 30)
        Me.uploadbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.uploadbtn.TabIndex = 49
        Me.uploadbtn.TabStop = False
        '
        'deletebtn
        '
        Me.deletebtn.Image = CType(resources.GetObject("deletebtn.Image"), System.Drawing.Image)
        Me.deletebtn.Location = New System.Drawing.Point(1041, 115)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(40, 30)
        Me.deletebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.deletebtn.TabIndex = 48
        Me.deletebtn.TabStop = False
        '
        'editbtn
        '
        Me.editbtn.Image = CType(resources.GetObject("editbtn.Image"), System.Drawing.Image)
        Me.editbtn.Location = New System.Drawing.Point(979, 115)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(37, 30)
        Me.editbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editbtn.TabIndex = 47
        Me.editbtn.TabStop = False
        '
        'addbtn
        '
        Me.addbtn.Image = CType(resources.GetObject("addbtn.Image"), System.Drawing.Image)
        Me.addbtn.Location = New System.Drawing.Point(912, 115)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(40, 30)
        Me.addbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addbtn.TabIndex = 46
        Me.addbtn.TabStop = False
        '
        'printbtn
        '
        Me.printbtn.Image = CType(resources.GetObject("printbtn.Image"), System.Drawing.Image)
        Me.printbtn.Location = New System.Drawing.Point(1041, 425)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(31, 30)
        Me.printbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.printbtn.TabIndex = 45
        Me.printbtn.TabStop = False
        '
        'viewlistbtn
        '
        Me.viewlistbtn.Image = CType(resources.GetObject("viewlistbtn.Image"), System.Drawing.Image)
        Me.viewlistbtn.Location = New System.Drawing.Point(975, 423)
        Me.viewlistbtn.Name = "viewlistbtn"
        Me.viewlistbtn.Size = New System.Drawing.Size(37, 32)
        Me.viewlistbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.viewlistbtn.TabIndex = 43
        Me.viewlistbtn.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(223, 473)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(885, 309)
        Me.DataGridView1.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gotham Rounded Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(585, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 24)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Payment Form"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 794)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.uploadbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.printbtn)
        Me.Controls.Add(Me.viewlistbtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uploadbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deletebtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewlistbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents paidamount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents amount As Label
    Friend WithEvents bookId1 As TextBox
    Friend WithEvents bookId As Label
    Friend WithEvents pid As TextBox
    Friend WithEvents payid As Label
    Friend WithEvents userid2 As Label
    Friend WithEvents user As TextBox
    Friend WithEvents date1 As Label
    Friend WithEvents searchlist As Button
    Friend WithEvents s1 As TextBox
    Friend WithEvents datetext As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents menubtn As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents uploadbtn As PictureBox
    Friend WithEvents deletebtn As PictureBox
    Friend WithEvents editbtn As PictureBox
    Friend WithEvents addbtn As PictureBox
    Friend WithEvents printbtn As PictureBox
    Friend WithEvents viewlistbtn As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
End Class
