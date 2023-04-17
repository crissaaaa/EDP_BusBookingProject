<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.emailadd = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.emailtext = New System.Windows.Forms.TextBox()
        Me.contactnum = New System.Windows.Forms.TextBox()
        Me.nametext1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cust1 = New System.Windows.Forms.TextBox()
        Me.customerid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.showpw1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usernametext = New System.Windows.Forms.TextBox()
        Me.password1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.useridnum = New System.Windows.Forms.TextBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.search3 = New System.Windows.Forms.TextBox()
        Me.searchacc = New System.Windows.Forms.Button()
        Me.editbtn = New System.Windows.Forms.PictureBox()
        Me.addbtn = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.menubtn = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.uploadbtn = New System.Windows.Forms.PictureBox()
        Me.printbtn = New System.Windows.Forms.PictureBox()
        Me.viewlistbtn = New System.Windows.Forms.PictureBox()
        Me.deletebtn = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uploadbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewlistbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deletebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'emailadd
        '
        Me.emailadd.AutoSize = True
        Me.emailadd.Location = New System.Drawing.Point(107, 198)
        Me.emailadd.Name = "emailadd"
        Me.emailadd.Size = New System.Drawing.Size(129, 21)
        Me.emailadd.TabIndex = 18
        Me.emailadd.Text = "Email Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(551, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 21)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Contact Number:"
        '
        'emailtext
        '
        Me.emailtext.Location = New System.Drawing.Point(242, 195)
        Me.emailtext.Name = "emailtext"
        Me.emailtext.Size = New System.Drawing.Size(286, 28)
        Me.emailtext.TabIndex = 16
        '
        'contactnum
        '
        Me.contactnum.Location = New System.Drawing.Point(715, 148)
        Me.contactnum.Name = "contactnum"
        Me.contactnum.Size = New System.Drawing.Size(212, 28)
        Me.contactnum.TabIndex = 15
        '
        'nametext1
        '
        Me.nametext1.Location = New System.Drawing.Point(226, 97)
        Me.nametext1.Name = "nametext1"
        Me.nametext1.Size = New System.Drawing.Size(701, 28)
        Me.nametext1.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(551, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "UserID:"
        '
        'cust1
        '
        Me.cust1.Location = New System.Drawing.Point(226, 59)
        Me.cust1.Name = "cust1"
        Me.cust1.Size = New System.Drawing.Size(302, 28)
        Me.cust1.TabIndex = 10
        '
        'customerid
        '
        Me.customerid.AutoSize = True
        Me.customerid.Location = New System.Drawing.Point(107, 62)
        Me.customerid.Name = "customerid"
        Me.customerid.Size = New System.Drawing.Size(113, 21)
        Me.customerid.TabIndex = 9
        Me.customerid.Text = "CustomerID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 464)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 23)
        Me.Label1.TabIndex = 11
        '
        'showpw1
        '
        Me.showpw1.AutoSize = True
        Me.showpw1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpw1.Location = New System.Drawing.Point(650, 230)
        Me.showpw1.Margin = New System.Windows.Forms.Padding(4)
        Me.showpw1.Name = "showpw1"
        Me.showpw1.Size = New System.Drawing.Size(145, 24)
        Me.showpw1.TabIndex = 8
        Me.showpw1.Text = "show password"
        Me.showpw1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(551, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username:"
        '
        'usernametext
        '
        Me.usernametext.Location = New System.Drawing.Point(226, 148)
        Me.usernametext.Name = "usernametext"
        Me.usernametext.Size = New System.Drawing.Size(302, 28)
        Me.usernametext.TabIndex = 1
        '
        'password1
        '
        Me.password1.Location = New System.Drawing.Point(650, 195)
        Me.password1.Name = "password1"
        Me.password1.Size = New System.Drawing.Size(277, 28)
        Me.password1.TabIndex = 3
        Me.password1.UseSystemPasswordChar = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.useridnum)
        Me.GroupBox1.Controls.Add(Me.emailadd)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.emailtext)
        Me.GroupBox1.Controls.Add(Me.contactnum)
        Me.GroupBox1.Controls.Add(Me.nametext1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cust1)
        Me.GroupBox1.Controls.Add(Me.customerid)
        Me.GroupBox1.Controls.Add(Me.showpw1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.password1)
        Me.GroupBox1.Controls.Add(Me.usernametext)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(106, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1051, 289)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'useridnum
        '
        Me.useridnum.Location = New System.Drawing.Point(650, 59)
        Me.useridnum.Name = "useridnum"
        Me.useridnum.Size = New System.Drawing.Size(277, 28)
        Me.useridnum.TabIndex = 19
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(106, 460)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(1051, 309)
        Me.DataGridView3.TabIndex = 57
        '
        'search3
        '
        Me.search3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search3.Location = New System.Drawing.Point(897, 19)
        Me.search3.Name = "search3"
        Me.search3.Size = New System.Drawing.Size(287, 27)
        Me.search3.TabIndex = 18
        '
        'searchacc
        '
        Me.searchacc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.searchacc.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchacc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.searchacc.Location = New System.Drawing.Point(1190, 17)
        Me.searchacc.Name = "searchacc"
        Me.searchacc.Size = New System.Drawing.Size(138, 33)
        Me.searchacc.TabIndex = 17
        Me.searchacc.Text = "Search"
        Me.searchacc.UseVisualStyleBackColor = False
        '
        'editbtn
        '
        Me.editbtn.Image = CType(resources.GetObject("editbtn.Image"), System.Drawing.Image)
        Me.editbtn.Location = New System.Drawing.Point(1190, 213)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(33, 38)
        Me.editbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editbtn.TabIndex = 55
        Me.editbtn.TabStop = False
        '
        'addbtn
        '
        Me.addbtn.Image = CType(resources.GetObject("addbtn.Image"), System.Drawing.Image)
        Me.addbtn.Location = New System.Drawing.Point(1190, 145)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(33, 34)
        Me.addbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addbtn.TabIndex = 54
        Me.addbtn.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Panel1.Controls.Add(Me.menubtn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.search3)
        Me.Panel1.Controls.Add(Me.searchacc)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1359, 66)
        Me.Panel1.TabIndex = 53
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
        Me.Label7.Size = New System.Drawing.Size(295, 32)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Customer Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(931, 391)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 37)
        Me.Label9.TabIndex = 52
        '
        'uploadbtn
        '
        Me.uploadbtn.Image = CType(resources.GetObject("uploadbtn.Image"), System.Drawing.Image)
        Me.uploadbtn.Location = New System.Drawing.Point(1190, 560)
        Me.uploadbtn.Name = "uploadbtn"
        Me.uploadbtn.Size = New System.Drawing.Size(40, 38)
        Me.uploadbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.uploadbtn.TabIndex = 61
        Me.uploadbtn.TabStop = False
        '
        'printbtn
        '
        Me.printbtn.Image = CType(resources.GetObject("printbtn.Image"), System.Drawing.Image)
        Me.printbtn.Location = New System.Drawing.Point(1190, 630)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(40, 37)
        Me.printbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.printbtn.TabIndex = 60
        Me.printbtn.TabStop = False
        '
        'viewlistbtn
        '
        Me.viewlistbtn.Image = CType(resources.GetObject("viewlistbtn.Image"), System.Drawing.Image)
        Me.viewlistbtn.Location = New System.Drawing.Point(1190, 495)
        Me.viewlistbtn.Name = "viewlistbtn"
        Me.viewlistbtn.Size = New System.Drawing.Size(40, 36)
        Me.viewlistbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.viewlistbtn.TabIndex = 58
        Me.viewlistbtn.TabStop = False
        '
        'deletebtn
        '
        Me.deletebtn.Image = CType(resources.GetObject("deletebtn.Image"), System.Drawing.Image)
        Me.deletebtn.Location = New System.Drawing.Point(1190, 282)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(40, 34)
        Me.deletebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.deletebtn.TabIndex = 56
        Me.deletebtn.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gotham Rounded Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(528, 424)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(222, 24)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Customer Data Table"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gotham Rounded Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(559, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 24)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Customer Form"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 794)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.uploadbtn)
        Me.Controls.Add(Me.printbtn)
        Me.Controls.Add(Me.viewlistbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uploadbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewlistbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deletebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents emailadd As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents emailtext As TextBox
    Friend WithEvents contactnum As TextBox
    Friend WithEvents nametext1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cust1 As TextBox
    Friend WithEvents customerid As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents showpw1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents usernametext As TextBox
    Friend WithEvents password1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents useridnum As TextBox
    Friend WithEvents search3 As TextBox
    Friend WithEvents searchacc As Button
    Friend WithEvents editbtn As PictureBox
    Friend WithEvents addbtn As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents menubtn As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents uploadbtn As PictureBox
    Friend WithEvents printbtn As PictureBox
    Friend WithEvents viewlistbtn As PictureBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents deletebtn As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
End Class
