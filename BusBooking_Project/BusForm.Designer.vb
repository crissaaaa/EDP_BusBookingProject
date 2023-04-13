<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BusForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.del6 = New System.Windows.Forms.Button()
        Me.update6 = New System.Windows.Forms.Button()
        Me.bustype6 = New System.Windows.Forms.ComboBox()
        Me.driverid6 = New System.Windows.Forms.TextBox()
        Me.capacity = New System.Windows.Forms.Label()
        Me.bustype = New System.Windows.Forms.Label()
        Me.capacity6 = New System.Windows.Forms.TextBox()
        Me.platenum6 = New System.Windows.Forms.TextBox()
        Me.platenum = New System.Windows.Forms.Label()
        Me.driver = New System.Windows.Forms.Label()
        Me.busid6 = New System.Windows.Forms.TextBox()
        Me.busid = New System.Windows.Forms.Label()
        Me.add6 = New System.Windows.Forms.Button()
        Me.userid2 = New System.Windows.Forms.Label()
        Me.user6 = New System.Windows.Forms.TextBox()
        Me.GoToMain6 = New System.Windows.Forms.Button()
        Me.s6 = New System.Windows.Forms.TextBox()
        Me.search6 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bus Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.del6)
        Me.GroupBox1.Controls.Add(Me.update6)
        Me.GroupBox1.Controls.Add(Me.bustype6)
        Me.GroupBox1.Controls.Add(Me.driverid6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.capacity)
        Me.GroupBox1.Controls.Add(Me.bustype)
        Me.GroupBox1.Controls.Add(Me.capacity6)
        Me.GroupBox1.Controls.Add(Me.platenum6)
        Me.GroupBox1.Controls.Add(Me.platenum)
        Me.GroupBox1.Controls.Add(Me.driver)
        Me.GroupBox1.Controls.Add(Me.busid6)
        Me.GroupBox1.Controls.Add(Me.busid)
        Me.GroupBox1.Controls.Add(Me.add6)
        Me.GroupBox1.Controls.Add(Me.userid2)
        Me.GroupBox1.Controls.Add(Me.user6)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(109, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 614)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'del6
        '
        Me.del6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.del6.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.del6.Location = New System.Drawing.Point(382, 529)
        Me.del6.Name = "del6"
        Me.del6.Size = New System.Drawing.Size(133, 46)
        Me.del6.TabIndex = 22
        Me.del6.Text = "Delete"
        Me.del6.UseVisualStyleBackColor = False
        '
        'update6
        '
        Me.update6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.update6.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.update6.Location = New System.Drawing.Point(229, 529)
        Me.update6.Name = "update6"
        Me.update6.Size = New System.Drawing.Size(133, 46)
        Me.update6.TabIndex = 21
        Me.update6.Text = "Update"
        Me.update6.UseVisualStyleBackColor = False
        '
        'bustype6
        '
        Me.bustype6.FormattingEnabled = True
        Me.bustype6.Items.AddRange(New Object() {"1 = Air-Conditioned", "2 = Non-Air-Conditioned"})
        Me.bustype6.Location = New System.Drawing.Point(75, 261)
        Me.bustype6.Name = "bustype6"
        Me.bustype6.Size = New System.Drawing.Size(439, 29)
        Me.bustype6.TabIndex = 20
        '
        'driverid6
        '
        Me.driverid6.Location = New System.Drawing.Point(75, 466)
        Me.driverid6.Name = "driverid6"
        Me.driverid6.Size = New System.Drawing.Size(439, 28)
        Me.driverid6.TabIndex = 19
        '
        'capacity
        '
        Me.capacity.AutoSize = True
        Me.capacity.Location = New System.Drawing.Point(71, 305)
        Me.capacity.Name = "capacity"
        Me.capacity.Size = New System.Drawing.Size(94, 21)
        Me.capacity.TabIndex = 18
        Me.capacity.Text = "Capacity:"
        '
        'bustype
        '
        Me.bustype.AutoSize = True
        Me.bustype.Location = New System.Drawing.Point(72, 237)
        Me.bustype.Name = "bustype"
        Me.bustype.Size = New System.Drawing.Size(81, 21)
        Me.bustype.TabIndex = 17
        Me.bustype.Text = "Bus Type"
        '
        'capacity6
        '
        Me.capacity6.Location = New System.Drawing.Point(75, 329)
        Me.capacity6.Name = "capacity6"
        Me.capacity6.Size = New System.Drawing.Size(439, 28)
        Me.capacity6.TabIndex = 16
        '
        'platenum6
        '
        Me.platenum6.Location = New System.Drawing.Point(76, 196)
        Me.platenum6.Name = "platenum6"
        Me.platenum6.Size = New System.Drawing.Size(439, 28)
        Me.platenum6.TabIndex = 14
        '
        'platenum
        '
        Me.platenum.AutoSize = True
        Me.platenum.Location = New System.Drawing.Point(72, 172)
        Me.platenum.Name = "platenum"
        Me.platenum.Size = New System.Drawing.Size(129, 21)
        Me.platenum.TabIndex = 13
        Me.platenum.Text = "Plate Number:"
        '
        'driver
        '
        Me.driver.AutoSize = True
        Me.driver.Location = New System.Drawing.Point(72, 442)
        Me.driver.Name = "driver"
        Me.driver.Size = New System.Drawing.Size(80, 21)
        Me.driver.TabIndex = 11
        Me.driver.Text = "driverID:"
        '
        'busid6
        '
        Me.busid6.Location = New System.Drawing.Point(76, 123)
        Me.busid6.Name = "busid6"
        Me.busid6.Size = New System.Drawing.Size(439, 28)
        Me.busid6.TabIndex = 10
        '
        'busid
        '
        Me.busid.AutoSize = True
        Me.busid.Location = New System.Drawing.Point(79, 99)
        Me.busid.Name = "busid"
        Me.busid.Size = New System.Drawing.Size(60, 21)
        Me.busid.TabIndex = 9
        Me.busid.Text = "BusID:"
        '
        'add6
        '
        Me.add6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.add6.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.add6.Location = New System.Drawing.Point(75, 529)
        Me.add6.Name = "add6"
        Me.add6.Size = New System.Drawing.Size(133, 46)
        Me.add6.TabIndex = 5
        Me.add6.Text = "Add"
        Me.add6.UseVisualStyleBackColor = False
        '
        'userid2
        '
        Me.userid2.AutoSize = True
        Me.userid2.Location = New System.Drawing.Point(71, 372)
        Me.userid2.Name = "userid2"
        Me.userid2.Size = New System.Drawing.Size(68, 21)
        Me.userid2.TabIndex = 3
        Me.userid2.Text = "UserID:"
        '
        'user6
        '
        Me.user6.Location = New System.Drawing.Point(75, 396)
        Me.user6.Name = "user6"
        Me.user6.Size = New System.Drawing.Size(439, 28)
        Me.user6.TabIndex = 1
        '
        'GoToMain6
        '
        Me.GoToMain6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GoToMain6.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoToMain6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GoToMain6.Location = New System.Drawing.Point(504, 18)
        Me.GoToMain6.Name = "GoToMain6"
        Me.GoToMain6.Size = New System.Drawing.Size(201, 32)
        Me.GoToMain6.TabIndex = 14
        Me.GoToMain6.Text = "Back to Main Form"
        Me.GoToMain6.UseVisualStyleBackColor = False
        '
        's6
        '
        Me.s6.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s6.Location = New System.Drawing.Point(109, 18)
        Me.s6.Name = "s6"
        Me.s6.Size = New System.Drawing.Size(265, 28)
        Me.s6.TabIndex = 24
        '
        'search6
        '
        Me.search6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.search6.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.search6.Location = New System.Drawing.Point(381, 18)
        Me.search6.Name = "search6"
        Me.search6.Size = New System.Drawing.Size(117, 32)
        Me.search6.TabIndex = 23
        Me.search6.Text = "Search"
        Me.search6.UseVisualStyleBackColor = False
        '
        'BusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 713)
        Me.Controls.Add(Me.s6)
        Me.Controls.Add(Me.search6)
        Me.Controls.Add(Me.GoToMain6)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BusForm"
        Me.Text = "BusForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents driverid6 As TextBox
    Friend WithEvents capacity As Label
    Friend WithEvents bustype As Label
    Friend WithEvents capacity6 As TextBox
    Friend WithEvents platenum6 As TextBox
    Friend WithEvents platenum As Label
    Friend WithEvents driver As Label
    Friend WithEvents busid6 As TextBox
    Friend WithEvents busid As Label
    Friend WithEvents add6 As Button
    Friend WithEvents userid2 As Label
    Friend WithEvents user6 As TextBox
    Friend WithEvents bustype6 As ComboBox
    Friend WithEvents del6 As Button
    Friend WithEvents update6 As Button
    Friend WithEvents GoToMain6 As Button
    Friend WithEvents s6 As TextBox
    Friend WithEvents search6 As Button
End Class
