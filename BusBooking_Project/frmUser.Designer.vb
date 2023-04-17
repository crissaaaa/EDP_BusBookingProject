<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.emailadd = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.contact = New System.Windows.Forms.TextBox()
        Me.nametext = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.accstatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.userid1 = New System.Windows.Forms.TextBox()
        Me.userid = New System.Windows.Forms.Label()
        Me.showpassword = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchacc = New System.Windows.Forms.Button()
        Me.search2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.menubtn = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView8 = New System.Windows.Forms.DataGridView()
        Me.uploadbtn = New System.Windows.Forms.PictureBox()
        Me.deletebtn = New System.Windows.Forms.PictureBox()
        Me.editbtn = New System.Windows.Forms.PictureBox()
        Me.addbtn = New System.Windows.Forms.PictureBox()
        Me.printbtn = New System.Windows.Forms.PictureBox()
        Me.viewlistbtn = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.emailadd)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.email)
        Me.GroupBox1.Controls.Add(Me.contact)
        Me.GroupBox1.Controls.Add(Me.nametext)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.accstatus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.userid1)
        Me.GroupBox1.Controls.Add(Me.userid)
        Me.GroupBox1.Controls.Add(Me.showpassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.password)
        Me.GroupBox1.Controls.Add(Me.username)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(153, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1050, 294)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'emailadd
        '
        Me.emailadd.AutoSize = True
        Me.emailadd.Location = New System.Drawing.Point(526, 157)
        Me.emailadd.Name = "emailadd"
        Me.emailadd.Size = New System.Drawing.Size(129, 21)
        Me.emailadd.TabIndex = 18
        Me.emailadd.Text = "Email Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(161, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 21)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Contact Number:"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(661, 150)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(240, 28)
        Me.email.TabIndex = 16
        '
        'contact
        '
        Me.contact.Location = New System.Drawing.Point(325, 150)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(189, 28)
        Me.contact.TabIndex = 15
        '
        'nametext
        '
        Me.nametext.Location = New System.Drawing.Point(257, 99)
        Me.nametext.Name = "nametext"
        Me.nametext.Size = New System.Drawing.Size(644, 28)
        Me.nametext.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(163, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Name:"
        '
        'accstatus
        '
        Me.accstatus.FormattingEnabled = True
        Me.accstatus.Items.AddRange(New Object() {"1 = Active", "0 = Not Active"})
        Me.accstatus.Location = New System.Drawing.Point(677, 48)
        Me.accstatus.Name = "accstatus"
        Me.accstatus.Size = New System.Drawing.Size(224, 29)
        Me.accstatus.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(526, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Account Status:"
        '
        'userid1
        '
        Me.userid1.Location = New System.Drawing.Point(257, 48)
        Me.userid1.Name = "userid1"
        Me.userid1.Size = New System.Drawing.Size(257, 28)
        Me.userid1.TabIndex = 10
        '
        'userid
        '
        Me.userid.AutoSize = True
        Me.userid.Location = New System.Drawing.Point(161, 51)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(68, 21)
        Me.userid.TabIndex = 9
        Me.userid.Text = "UserID:"
        '
        'showpassword
        '
        Me.showpassword.AutoSize = True
        Me.showpassword.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpassword.Location = New System.Drawing.Point(625, 239)
        Me.showpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.showpassword.Name = "showpassword"
        Me.showpassword.Size = New System.Drawing.Size(145, 24)
        Me.showpassword.TabIndex = 8
        Me.showpassword.Text = "show password"
        Me.showpassword.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(526, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username:"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(625, 204)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(276, 28)
        Me.password.TabIndex = 3
        Me.password.UseSystemPasswordChar = True
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(279, 204)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(235, 28)
        Me.username.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 475)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 23)
        Me.Label1.TabIndex = 0
        '
        'searchacc
        '
        Me.searchacc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.searchacc.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchacc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.searchacc.Location = New System.Drawing.Point(1209, 15)
        Me.searchacc.Name = "searchacc"
        Me.searchacc.Size = New System.Drawing.Size(115, 33)
        Me.searchacc.TabIndex = 9
        Me.searchacc.Text = "Search"
        Me.searchacc.UseVisualStyleBackColor = False
        '
        'search2
        '
        Me.search2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search2.Location = New System.Drawing.Point(954, 17)
        Me.search2.Name = "search2"
        Me.search2.Size = New System.Drawing.Size(249, 27)
        Me.search2.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Panel1.Controls.Add(Me.menubtn)
        Me.Panel1.Controls.Add(Me.search2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.searchacc)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1359, 66)
        Me.Panel1.TabIndex = 36
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
        Me.Label7.Size = New System.Drawing.Size(226, 32)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "User Information"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(587, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 23)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "User Form"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(578, 440)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 23)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "User Records"
        '
        'DataGridView8
        '
        Me.DataGridView8.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView8.Location = New System.Drawing.Point(153, 475)
        Me.DataGridView8.Name = "DataGridView8"
        Me.DataGridView8.RowHeadersWidth = 51
        Me.DataGridView8.RowTemplate.Height = 24
        Me.DataGridView8.Size = New System.Drawing.Size(1050, 291)
        Me.DataGridView8.TabIndex = 44
        '
        'uploadbtn
        '
        Me.uploadbtn.Image = CType(resources.GetObject("uploadbtn.Image"), System.Drawing.Image)
        Me.uploadbtn.Location = New System.Drawing.Point(1080, 440)
        Me.uploadbtn.Name = "uploadbtn"
        Me.uploadbtn.Size = New System.Drawing.Size(40, 30)
        Me.uploadbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.uploadbtn.TabIndex = 50
        Me.uploadbtn.TabStop = False
        '
        'deletebtn
        '
        Me.deletebtn.Image = CType(resources.GetObject("deletebtn.Image"), System.Drawing.Image)
        Me.deletebtn.Location = New System.Drawing.Point(1134, 98)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(40, 30)
        Me.deletebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.deletebtn.TabIndex = 49
        Me.deletebtn.TabStop = False
        '
        'editbtn
        '
        Me.editbtn.Image = CType(resources.GetObject("editbtn.Image"), System.Drawing.Image)
        Me.editbtn.Location = New System.Drawing.Point(1076, 98)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(37, 30)
        Me.editbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editbtn.TabIndex = 48
        Me.editbtn.TabStop = False
        '
        'addbtn
        '
        Me.addbtn.Image = CType(resources.GetObject("addbtn.Image"), System.Drawing.Image)
        Me.addbtn.Location = New System.Drawing.Point(1025, 98)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(29, 30)
        Me.addbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addbtn.TabIndex = 47
        Me.addbtn.TabStop = False
        '
        'printbtn
        '
        Me.printbtn.Image = CType(resources.GetObject("printbtn.Image"), System.Drawing.Image)
        Me.printbtn.Location = New System.Drawing.Point(1143, 440)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(31, 30)
        Me.printbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.printbtn.TabIndex = 46
        Me.printbtn.TabStop = False
        '
        'viewlistbtn
        '
        Me.viewlistbtn.Image = CType(resources.GetObject("viewlistbtn.Image"), System.Drawing.Image)
        Me.viewlistbtn.Location = New System.Drawing.Point(1020, 437)
        Me.viewlistbtn.Name = "viewlistbtn"
        Me.viewlistbtn.Size = New System.Drawing.Size(37, 32)
        Me.viewlistbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.viewlistbtn.TabIndex = 45
        Me.viewlistbtn.TabStop = False
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 794)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.uploadbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.printbtn)
        Me.Controls.Add(Me.viewlistbtn)
        Me.Controls.Add(Me.DataGridView8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents userid As Label
    Friend WithEvents showpassword As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents userid1 As TextBox
    Friend WithEvents accstatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents emailadd As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents contact As TextBox
    Friend WithEvents nametext As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents searchacc As Button
    Friend WithEvents search2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents menubtn As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents uploadbtn As PictureBox
    Friend WithEvents deletebtn As PictureBox
    Friend WithEvents editbtn As PictureBox
    Friend WithEvents addbtn As PictureBox
    Friend WithEvents printbtn As PictureBox
    Friend WithEvents viewlistbtn As PictureBox
    Friend WithEvents DataGridView8 As DataGridView
End Class
