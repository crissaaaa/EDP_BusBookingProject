<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Me.EditAcc = New System.Windows.Forms.Button()
        Me.ViewAcc = New System.Windows.Forms.Button()
        Me.accstatus = New System.Windows.Forms.ComboBox()
        Me.nametxt = New System.Windows.Forms.TextBox()
        Me.AddUser = New System.Windows.Forms.Button()
        Me.username = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.userid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.contact = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Button()
        Me.Userform1 = New System.Windows.Forms.GroupBox()
        Me.GoToMain = New System.Windows.Forms.Button()
        Me.Userform1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditAcc
        '
        Me.EditAcc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EditAcc.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EditAcc.Location = New System.Drawing.Point(81, 176)
        Me.EditAcc.Name = "EditAcc"
        Me.EditAcc.Size = New System.Drawing.Size(199, 46)
        Me.EditAcc.TabIndex = 28
        Me.EditAcc.Text = "Edit Account"
        Me.EditAcc.UseVisualStyleBackColor = False
        '
        'ViewAcc
        '
        Me.ViewAcc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ViewAcc.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ViewAcc.Location = New System.Drawing.Point(81, 111)
        Me.ViewAcc.Name = "ViewAcc"
        Me.ViewAcc.Size = New System.Drawing.Size(199, 46)
        Me.ViewAcc.TabIndex = 26
        Me.ViewAcc.Text = "View Account"
        Me.ViewAcc.UseVisualStyleBackColor = False
        '
        'accstatus
        '
        Me.accstatus.FormattingEnabled = True
        Me.accstatus.Items.AddRange(New Object() {"1 = Active", "0 = Inactive"})
        Me.accstatus.Location = New System.Drawing.Point(292, 66)
        Me.accstatus.Name = "accstatus"
        Me.accstatus.Size = New System.Drawing.Size(227, 29)
        Me.accstatus.TabIndex = 24
        '
        'nametxt
        '
        Me.nametxt.Location = New System.Drawing.Point(87, 131)
        Me.nametxt.Name = "nametxt"
        Me.nametxt.Size = New System.Drawing.Size(432, 28)
        Me.nametxt.TabIndex = 23
        '
        'AddUser
        '
        Me.AddUser.BackColor = System.Drawing.Color.LightSkyBlue
        Me.AddUser.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AddUser.Location = New System.Drawing.Point(87, 446)
        Me.AddUser.Name = "AddUser"
        Me.AddUser.Size = New System.Drawing.Size(432, 46)
        Me.AddUser.TabIndex = 21
        Me.AddUser.Text = "Add User Account"
        Me.AddUser.UseVisualStyleBackColor = False
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(87, 328)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(432, 28)
        Me.username.TabIndex = 18
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(87, 262)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(432, 28)
        Me.email.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(83, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 21)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Email Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(83, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Username:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(288, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Account Status:"
        '
        'userid
        '
        Me.userid.Location = New System.Drawing.Point(87, 66)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(182, 28)
        Me.userid.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "UserID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contact No.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name:"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(87, 395)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(432, 28)
        Me.password.TabIndex = 3
        Me.password.UseSystemPasswordChar = True
        '
        'contact
        '
        Me.contact.Location = New System.Drawing.Point(87, 197)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(432, 28)
        Me.contact.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 23)
        Me.Label1.TabIndex = 0
        '
        'logout
        '
        Me.logout.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.logout.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.logout.Location = New System.Drawing.Point(81, 242)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(201, 46)
        Me.logout.TabIndex = 27
        Me.logout.Text = "Logout"
        Me.logout.UseVisualStyleBackColor = False
        '
        'Userform1
        '
        Me.Userform1.BackColor = System.Drawing.Color.White
        Me.Userform1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Userform1.Controls.Add(Me.accstatus)
        Me.Userform1.Controls.Add(Me.nametxt)
        Me.Userform1.Controls.Add(Me.AddUser)
        Me.Userform1.Controls.Add(Me.username)
        Me.Userform1.Controls.Add(Me.email)
        Me.Userform1.Controls.Add(Me.Label9)
        Me.Userform1.Controls.Add(Me.Label8)
        Me.Userform1.Controls.Add(Me.Label7)
        Me.Userform1.Controls.Add(Me.Label6)
        Me.Userform1.Controls.Add(Me.userid)
        Me.Userform1.Controls.Add(Me.Label5)
        Me.Userform1.Controls.Add(Me.Label3)
        Me.Userform1.Controls.Add(Me.Label2)
        Me.Userform1.Controls.Add(Me.password)
        Me.Userform1.Controls.Add(Me.contact)
        Me.Userform1.Controls.Add(Me.Label1)
        Me.Userform1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userform1.Location = New System.Drawing.Point(349, 45)
        Me.Userform1.Name = "Userform1"
        Me.Userform1.Size = New System.Drawing.Size(608, 537)
        Me.Userform1.TabIndex = 24
        Me.Userform1.TabStop = False
        '
        'GoToMain
        '
        Me.GoToMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GoToMain.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoToMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GoToMain.Location = New System.Drawing.Point(81, 45)
        Me.GoToMain.Name = "GoToMain"
        Me.GoToMain.Size = New System.Drawing.Size(199, 46)
        Me.GoToMain.TabIndex = 25
        Me.GoToMain.Text = "Go to Main Form"
        Me.GoToMain.UseVisualStyleBackColor = False
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 627)
        Me.Controls.Add(Me.EditAcc)
        Me.Controls.Add(Me.ViewAcc)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.Userform1)
        Me.Controls.Add(Me.GoToMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "UserForm"
        Me.Text = "UserForm"
        Me.Userform1.ResumeLayout(False)
        Me.Userform1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EditAcc As Button
    Friend WithEvents ViewAcc As Button
    Friend WithEvents accstatus As ComboBox
    Friend WithEvents nametxt As TextBox
    Friend WithEvents AddUser As Button
    Friend WithEvents username As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents userid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents contact As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents logout As Button
    Friend WithEvents Userform1 As GroupBox
    Friend WithEvents GoToMain As Button
End Class
