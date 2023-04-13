<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        Me.emailadd = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.emailtext = New System.Windows.Forms.TextBox()
        Me.contactnum = New System.Windows.Forms.TextBox()
        Me.nametext1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cust1 = New System.Windows.Forms.TextBox()
        Me.customerid = New System.Windows.Forms.Label()
        Me.GoToMain = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.showpw1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usernametext = New System.Windows.Forms.TextBox()
        Me.password1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.del3 = New System.Windows.Forms.Button()
        Me.update3 = New System.Windows.Forms.Button()
        Me.add3 = New System.Windows.Forms.Button()
        Me.useridnum = New System.Windows.Forms.TextBox()
        Me.search3 = New System.Windows.Forms.TextBox()
        Me.searchacc = New System.Windows.Forms.Button()
        Me.view = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'emailtext
        '
        Me.emailtext.Location = New System.Drawing.Point(75, 290)
        Me.emailtext.Name = "emailtext"
        Me.emailtext.Size = New System.Drawing.Size(439, 28)
        Me.emailtext.TabIndex = 16
        '
        'contactnum
        '
        Me.contactnum.Location = New System.Drawing.Point(75, 221)
        Me.contactnum.Name = "contactnum"
        Me.contactnum.Size = New System.Drawing.Size(439, 28)
        Me.contactnum.TabIndex = 15
        '
        'nametext1
        '
        Me.nametext1.Location = New System.Drawing.Point(75, 157)
        Me.nametext1.Name = "nametext1"
        Me.nametext1.Size = New System.Drawing.Size(439, 28)
        Me.nametext1.TabIndex = 14
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 502)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "UserID:"
        '
        'cust1
        '
        Me.cust1.Location = New System.Drawing.Point(75, 89)
        Me.cust1.Name = "cust1"
        Me.cust1.Size = New System.Drawing.Size(439, 28)
        Me.cust1.TabIndex = 10
        '
        'customerid
        '
        Me.customerid.AutoSize = True
        Me.customerid.Location = New System.Drawing.Point(71, 65)
        Me.customerid.Name = "customerid"
        Me.customerid.Size = New System.Drawing.Size(113, 21)
        Me.customerid.TabIndex = 9
        Me.customerid.Text = "CustomerID:"
        '
        'GoToMain
        '
        Me.GoToMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GoToMain.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoToMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GoToMain.Location = New System.Drawing.Point(46, 127)
        Me.GoToMain.Name = "GoToMain"
        Me.GoToMain.Size = New System.Drawing.Size(411, 46)
        Me.GoToMain.TabIndex = 15
        Me.GoToMain.Text = "GO TO MAIN FORM"
        Me.GoToMain.UseVisualStyleBackColor = False
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
        Me.showpw1.Location = New System.Drawing.Point(75, 464)
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
        'usernametext
        '
        Me.usernametext.Location = New System.Drawing.Point(75, 360)
        Me.usernametext.Name = "usernametext"
        Me.usernametext.Size = New System.Drawing.Size(439, 28)
        Me.usernametext.TabIndex = 1
        '
        'password1
        '
        Me.password1.Location = New System.Drawing.Point(75, 429)
        Me.password1.Name = "password1"
        Me.password1.Size = New System.Drawing.Size(439, 28)
        Me.password1.TabIndex = 3
        Me.password1.UseSystemPasswordChar = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.del3)
        Me.GroupBox1.Controls.Add(Me.update3)
        Me.GroupBox1.Controls.Add(Me.add3)
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
        Me.GroupBox1.Location = New System.Drawing.Point(518, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 675)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'del3
        '
        Me.del3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.del3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.del3.Location = New System.Drawing.Point(381, 582)
        Me.del3.Name = "del3"
        Me.del3.Size = New System.Drawing.Size(133, 46)
        Me.del3.TabIndex = 28
        Me.del3.Text = "Delete"
        Me.del3.UseVisualStyleBackColor = False
        '
        'update3
        '
        Me.update3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.update3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.update3.Location = New System.Drawing.Point(230, 582)
        Me.update3.Name = "update3"
        Me.update3.Size = New System.Drawing.Size(133, 46)
        Me.update3.TabIndex = 27
        Me.update3.Text = "Update"
        Me.update3.UseVisualStyleBackColor = False
        '
        'add3
        '
        Me.add3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.add3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.add3.Location = New System.Drawing.Point(75, 582)
        Me.add3.Name = "add3"
        Me.add3.Size = New System.Drawing.Size(133, 46)
        Me.add3.TabIndex = 26
        Me.add3.Text = "Add"
        Me.add3.UseVisualStyleBackColor = False
        '
        'useridnum
        '
        Me.useridnum.Location = New System.Drawing.Point(75, 526)
        Me.useridnum.Name = "useridnum"
        Me.useridnum.Size = New System.Drawing.Size(439, 28)
        Me.useridnum.TabIndex = 19
        '
        'search3
        '
        Me.search3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search3.Location = New System.Drawing.Point(46, 66)
        Me.search3.Name = "search3"
        Me.search3.Size = New System.Drawing.Size(227, 27)
        Me.search3.TabIndex = 18
        '
        'searchacc
        '
        Me.searchacc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.searchacc.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchacc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.searchacc.Location = New System.Drawing.Point(279, 66)
        Me.searchacc.Name = "searchacc"
        Me.searchacc.Size = New System.Drawing.Size(179, 33)
        Me.searchacc.TabIndex = 17
        Me.searchacc.Text = "SEARCH ACCOUNT"
        Me.searchacc.UseVisualStyleBackColor = False
        '
        'view
        '
        Me.view.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.view.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.view.Location = New System.Drawing.Point(46, 195)
        Me.view.Name = "view"
        Me.view.Size = New System.Drawing.Size(411, 46)
        Me.view.TabIndex = 19
        Me.view.Text = "VIEW CUSTOMER LIST"
        Me.view.UseVisualStyleBackColor = False
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 815)
        Me.Controls.Add(Me.view)
        Me.Controls.Add(Me.search3)
        Me.Controls.Add(Me.searchacc)
        Me.Controls.Add(Me.GoToMain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "CustomerForm"
        Me.Text = "CustomerForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents GoToMain As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents showpw1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents usernametext As TextBox
    Friend WithEvents password1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents useridnum As TextBox
    Friend WithEvents del3 As Button
    Friend WithEvents update3 As Button
    Friend WithEvents add3 As Button
    Friend WithEvents search3 As TextBox
    Friend WithEvents searchacc As Button
    Friend WithEvents view As Button
End Class
