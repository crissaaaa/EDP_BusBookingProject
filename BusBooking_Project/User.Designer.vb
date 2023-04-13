<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.del = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.add1 = New System.Windows.Forms.Button()
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
        Me.logout = New System.Windows.Forms.Button()
        Me.GoToMain = New System.Windows.Forms.Button()
        Me.searchacc = New System.Windows.Forms.Button()
        Me.search2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.del)
        Me.GroupBox1.Controls.Add(Me.update)
        Me.GroupBox1.Controls.Add(Me.add1)
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
        Me.GroupBox1.Location = New System.Drawing.Point(67, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 596)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'del
        '
        Me.del.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.del.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.del.Location = New System.Drawing.Point(383, 520)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(133, 46)
        Me.del.TabIndex = 28
        Me.del.Text = "Delete"
        Me.del.UseVisualStyleBackColor = False
        '
        'update
        '
        Me.update.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.update.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.update.Location = New System.Drawing.Point(221, 520)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(133, 46)
        Me.update.TabIndex = 27
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = False
        '
        'add1
        '
        Me.add1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.add1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.add1.Location = New System.Drawing.Point(67, 520)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(133, 46)
        Me.add1.TabIndex = 26
        Me.add1.Text = "Add"
        Me.add1.UseVisualStyleBackColor = False
        '
        'emailadd
        '
        Me.emailadd.AutoSize = True
        Me.emailadd.Location = New System.Drawing.Point(71, 266)
        Me.emailadd.Name = "emailadd"
        Me.emailadd.Size = New System.Drawing.Size(129, 21)
        Me.emailadd.TabIndex = 18
        Me.emailadd.Text = "Email Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 21)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Contact Number:"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(75, 290)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(439, 28)
        Me.email.TabIndex = 16
        '
        'contact
        '
        Me.contact.Location = New System.Drawing.Point(75, 221)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(439, 28)
        Me.contact.TabIndex = 15
        '
        'nametext
        '
        Me.nametext.Location = New System.Drawing.Point(75, 157)
        Me.nametext.Name = "nametext"
        Me.nametext.Size = New System.Drawing.Size(439, 28)
        Me.nametext.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Name:"
        '
        'accstatus
        '
        Me.accstatus.FormattingEnabled = True
        Me.accstatus.Items.AddRange(New Object() {"1 = Active", "0 = Not Active"})
        Me.accstatus.Location = New System.Drawing.Point(317, 89)
        Me.accstatus.Name = "accstatus"
        Me.accstatus.Size = New System.Drawing.Size(197, 29)
        Me.accstatus.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Account Status:"
        '
        'userid1
        '
        Me.userid1.Location = New System.Drawing.Point(75, 89)
        Me.userid1.Name = "userid1"
        Me.userid1.Size = New System.Drawing.Size(204, 28)
        Me.userid1.TabIndex = 10
        '
        'userid
        '
        Me.userid.AutoSize = True
        Me.userid.Location = New System.Drawing.Point(71, 65)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(68, 21)
        Me.userid.TabIndex = 9
        Me.userid.Text = "UserID:"
        '
        'showpassword
        '
        Me.showpassword.AutoSize = True
        Me.showpassword.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpassword.Location = New System.Drawing.Point(75, 464)
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
        Me.Label3.Location = New System.Drawing.Point(71, 405)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(75, 429)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(439, 28)
        Me.password.TabIndex = 3
        Me.password.UseSystemPasswordChar = True
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(75, 360)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(439, 28)
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
        'logout
        '
        Me.logout.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.logout.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.logout.Location = New System.Drawing.Point(380, 701)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(256, 46)
        Me.logout.TabIndex = 7
        Me.logout.Text = "LOG OUT"
        Me.logout.UseVisualStyleBackColor = False
        '
        'GoToMain
        '
        Me.GoToMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GoToMain.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoToMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GoToMain.Location = New System.Drawing.Point(77, 701)
        Me.GoToMain.Name = "GoToMain"
        Me.GoToMain.Size = New System.Drawing.Size(256, 46)
        Me.GoToMain.TabIndex = 8
        Me.GoToMain.Text = "GO TO MAIN FORM"
        Me.GoToMain.UseVisualStyleBackColor = False
        '
        'searchacc
        '
        Me.searchacc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.searchacc.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchacc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.searchacc.Location = New System.Drawing.Point(481, 26)
        Me.searchacc.Name = "searchacc"
        Me.searchacc.Size = New System.Drawing.Size(179, 33)
        Me.searchacc.TabIndex = 9
        Me.searchacc.Text = "SEARCH ACCOUNT"
        Me.searchacc.UseVisualStyleBackColor = False
        '
        'search2
        '
        Me.search2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search2.Location = New System.Drawing.Point(67, 30)
        Me.search2.Name = "search2"
        Me.search2.Size = New System.Drawing.Size(408, 27)
        Me.search2.TabIndex = 11
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 800)
        Me.Controls.Add(Me.search2)
        Me.Controls.Add(Me.searchacc)
        Me.Controls.Add(Me.GoToMain)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "User"
        Me.Text = "User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents logout As Button
    Friend WithEvents GoToMain As Button
    Friend WithEvents searchacc As Button
    Friend WithEvents search2 As TextBox
    Friend WithEvents del As Button
    Friend WithEvents update As Button
    Friend WithEvents add1 As Button
End Class
