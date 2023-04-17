<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.showpassword = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.login = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.showpassword)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.login)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(180, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 379)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'showpassword
        '
        Me.showpassword.AutoSize = True
        Me.showpassword.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpassword.Location = New System.Drawing.Point(156, 208)
        Me.showpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.showpassword.Name = "showpassword"
        Me.showpassword.Size = New System.Drawing.Size(145, 24)
        Me.showpassword.TabIndex = 8
        Me.showpassword.Text = "show password"
        Me.showpassword.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(271, 301)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(52, 18)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Log In"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Already have an account?"
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.LightSkyBlue
        Me.login.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.login.Location = New System.Drawing.Point(41, 247)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(348, 46)
        Me.login.TabIndex = 5
        Me.login.Text = "Submit"
        Me.login.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(156, 171)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(222, 28)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(156, 114)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(222, 28)
        Me.txtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sign Up"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SignUp"
        Me.Text = "frmSignup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents showpassword As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents login As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
End Class
