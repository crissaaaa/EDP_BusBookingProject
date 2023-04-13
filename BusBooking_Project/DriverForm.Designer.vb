<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriverForm
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
        Me.dcontact = New System.Windows.Forms.TextBox()
        Me.del4 = New System.Windows.Forms.Button()
        Me.update4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.drivercon = New System.Windows.Forms.Label()
        Me.dname = New System.Windows.Forms.TextBox()
        Me.platenum = New System.Windows.Forms.Label()
        Me.dID = New System.Windows.Forms.TextBox()
        Me.busid = New System.Windows.Forms.Label()
        Me.add4 = New System.Windows.Forms.Button()
        Me.userid2 = New System.Windows.Forms.Label()
        Me.u2 = New System.Windows.Forms.TextBox()
        Me.viewlist4 = New System.Windows.Forms.Button()
        Me.GoToMain4 = New System.Windows.Forms.Button()
        Me.search4 = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.dcontact)
        Me.GroupBox1.Controls.Add(Me.del4)
        Me.GroupBox1.Controls.Add(Me.update4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.drivercon)
        Me.GroupBox1.Controls.Add(Me.dname)
        Me.GroupBox1.Controls.Add(Me.platenum)
        Me.GroupBox1.Controls.Add(Me.dID)
        Me.GroupBox1.Controls.Add(Me.busid)
        Me.GroupBox1.Controls.Add(Me.add4)
        Me.GroupBox1.Controls.Add(Me.userid2)
        Me.GroupBox1.Controls.Add(Me.u2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(120, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 492)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'dcontact
        '
        Me.dcontact.Location = New System.Drawing.Point(75, 266)
        Me.dcontact.Name = "dcontact"
        Me.dcontact.Size = New System.Drawing.Size(439, 28)
        Me.dcontact.TabIndex = 23
        '
        'del4
        '
        Me.del4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.del4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.del4.Location = New System.Drawing.Point(382, 401)
        Me.del4.Name = "del4"
        Me.del4.Size = New System.Drawing.Size(133, 46)
        Me.del4.TabIndex = 22
        Me.del4.Text = "Delete"
        Me.del4.UseVisualStyleBackColor = False
        '
        'update4
        '
        Me.update4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.update4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.update4.Location = New System.Drawing.Point(231, 401)
        Me.update4.Name = "update4"
        Me.update4.Size = New System.Drawing.Size(133, 46)
        Me.update4.TabIndex = 21
        Me.update4.Text = "Update"
        Me.update4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Driver Information"
        '
        'drivercon
        '
        Me.drivercon.AutoSize = True
        Me.drivercon.Location = New System.Drawing.Point(72, 242)
        Me.drivercon.Name = "drivercon"
        Me.drivercon.Size = New System.Drawing.Size(221, 21)
        Me.drivercon.TabIndex = 17
        Me.drivercon.Text = "Driver's Contact Number:"
        '
        'dname
        '
        Me.dname.Location = New System.Drawing.Point(76, 196)
        Me.dname.Name = "dname"
        Me.dname.Size = New System.Drawing.Size(439, 28)
        Me.dname.TabIndex = 14
        '
        'platenum
        '
        Me.platenum.AutoSize = True
        Me.platenum.Location = New System.Drawing.Point(72, 172)
        Me.platenum.Name = "platenum"
        Me.platenum.Size = New System.Drawing.Size(119, 21)
        Me.platenum.TabIndex = 13
        Me.platenum.Text = "Driver Name:"
        '
        'dID
        '
        Me.dID.Location = New System.Drawing.Point(76, 123)
        Me.dID.Name = "dID"
        Me.dID.Size = New System.Drawing.Size(439, 28)
        Me.dID.TabIndex = 10
        '
        'busid
        '
        Me.busid.AutoSize = True
        Me.busid.Location = New System.Drawing.Point(72, 99)
        Me.busid.Name = "busid"
        Me.busid.Size = New System.Drawing.Size(81, 21)
        Me.busid.TabIndex = 9
        Me.busid.Text = "DriverID:"
        '
        'add4
        '
        Me.add4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.add4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.add4.Location = New System.Drawing.Point(76, 401)
        Me.add4.Name = "add4"
        Me.add4.Size = New System.Drawing.Size(133, 46)
        Me.add4.TabIndex = 5
        Me.add4.Text = "Add"
        Me.add4.UseVisualStyleBackColor = False
        '
        'userid2
        '
        Me.userid2.AutoSize = True
        Me.userid2.Location = New System.Drawing.Point(72, 316)
        Me.userid2.Name = "userid2"
        Me.userid2.Size = New System.Drawing.Size(68, 21)
        Me.userid2.TabIndex = 3
        Me.userid2.Text = "UserID:"
        '
        'u2
        '
        Me.u2.Location = New System.Drawing.Point(75, 340)
        Me.u2.Name = "u2"
        Me.u2.Size = New System.Drawing.Size(439, 28)
        Me.u2.TabIndex = 1
        '
        'viewlist4
        '
        Me.viewlist4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.viewlist4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewlist4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.viewlist4.Location = New System.Drawing.Point(408, 619)
        Me.viewlist4.Name = "viewlist4"
        Me.viewlist4.Size = New System.Drawing.Size(256, 46)
        Me.viewlist4.TabIndex = 17
        Me.viewlist4.Text = "View List"
        Me.viewlist4.UseVisualStyleBackColor = False
        '
        'GoToMain4
        '
        Me.GoToMain4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GoToMain4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoToMain4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GoToMain4.Location = New System.Drawing.Point(120, 619)
        Me.GoToMain4.Name = "GoToMain4"
        Me.GoToMain4.Size = New System.Drawing.Size(256, 46)
        Me.GoToMain4.TabIndex = 16
        Me.GoToMain4.Text = "Back to Main Form"
        Me.GoToMain4.UseVisualStyleBackColor = False
        '
        'search4
        '
        Me.search4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search4.Location = New System.Drawing.Point(120, 53)
        Me.search4.Name = "search4"
        Me.search4.Size = New System.Drawing.Size(495, 28)
        Me.search4.TabIndex = 19
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(621, 45)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(95, 43)
        Me.search.TabIndex = 18
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = True
        '
        'DriverForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 726)
        Me.Controls.Add(Me.search4)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.viewlist4)
        Me.Controls.Add(Me.GoToMain4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DriverForm"
        Me.Text = "DriverForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dcontact As TextBox
    Friend WithEvents del4 As Button
    Friend WithEvents update4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents drivercon As Label
    Friend WithEvents dname As TextBox
    Friend WithEvents platenum As Label
    Friend WithEvents dID As TextBox
    Friend WithEvents busid As Label
    Friend WithEvents add4 As Button
    Friend WithEvents userid2 As Label
    Friend WithEvents u2 As TextBox
    Friend WithEvents viewlist4 As Button
    Friend WithEvents GoToMain4 As Button
    Friend WithEvents search4 As TextBox
    Friend WithEvents search As Button
End Class
