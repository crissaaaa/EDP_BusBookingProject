<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBus))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.driverid6 = New System.Windows.Forms.TextBox()
        Me.platenum6 = New System.Windows.Forms.TextBox()
        Me.driver = New System.Windows.Forms.Label()
        Me.capacity6 = New System.Windows.Forms.TextBox()
        Me.bustype6 = New System.Windows.Forms.ComboBox()
        Me.capacity = New System.Windows.Forms.Label()
        Me.user6 = New System.Windows.Forms.TextBox()
        Me.busid6 = New System.Windows.Forms.TextBox()
        Me.userid2 = New System.Windows.Forms.Label()
        Me.busid = New System.Windows.Forms.Label()
        Me.platenum = New System.Windows.Forms.Label()
        Me.bustype = New System.Windows.Forms.Label()
        Me.s6 = New System.Windows.Forms.TextBox()
        Me.search6 = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.PictureBox()
        Me.editbtn = New System.Windows.Forms.PictureBox()
        Me.addbtn = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.menubtn = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.uploadbtn = New System.Windows.Forms.PictureBox()
        Me.printbtn = New System.Windows.Forms.PictureBox()
        Me.viewlistbtn = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.deletebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uploadbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewlistbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.driverid6)
        Me.GroupBox1.Controls.Add(Me.platenum6)
        Me.GroupBox1.Controls.Add(Me.driver)
        Me.GroupBox1.Controls.Add(Me.capacity6)
        Me.GroupBox1.Controls.Add(Me.bustype6)
        Me.GroupBox1.Controls.Add(Me.capacity)
        Me.GroupBox1.Controls.Add(Me.user6)
        Me.GroupBox1.Controls.Add(Me.busid6)
        Me.GroupBox1.Controls.Add(Me.userid2)
        Me.GroupBox1.Controls.Add(Me.busid)
        Me.GroupBox1.Controls.Add(Me.platenum)
        Me.GroupBox1.Controls.Add(Me.bustype)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(142, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1051, 210)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'driverid6
        '
        Me.driverid6.Location = New System.Drawing.Point(634, 137)
        Me.driverid6.Name = "driverid6"
        Me.driverid6.Size = New System.Drawing.Size(295, 28)
        Me.driverid6.TabIndex = 19
        '
        'platenum6
        '
        Me.platenum6.Location = New System.Drawing.Point(634, 42)
        Me.platenum6.Name = "platenum6"
        Me.platenum6.Size = New System.Drawing.Size(295, 28)
        Me.platenum6.TabIndex = 14
        '
        'driver
        '
        Me.driver.AutoSize = True
        Me.driver.Location = New System.Drawing.Point(499, 140)
        Me.driver.Name = "driver"
        Me.driver.Size = New System.Drawing.Size(80, 21)
        Me.driver.TabIndex = 11
        Me.driver.Text = "driverID:"
        '
        'capacity6
        '
        Me.capacity6.Location = New System.Drawing.Point(634, 87)
        Me.capacity6.Name = "capacity6"
        Me.capacity6.Size = New System.Drawing.Size(295, 28)
        Me.capacity6.TabIndex = 16
        '
        'bustype6
        '
        Me.bustype6.FormattingEnabled = True
        Me.bustype6.Items.AddRange(New Object() {"1 = Air-Conditioned", "2 = Non-Air-Conditioned"})
        Me.bustype6.Location = New System.Drawing.Point(207, 87)
        Me.bustype6.Name = "bustype6"
        Me.bustype6.Size = New System.Drawing.Size(244, 29)
        Me.bustype6.TabIndex = 20
        '
        'capacity
        '
        Me.capacity.AutoSize = True
        Me.capacity.Location = New System.Drawing.Point(499, 90)
        Me.capacity.Name = "capacity"
        Me.capacity.Size = New System.Drawing.Size(94, 21)
        Me.capacity.TabIndex = 18
        Me.capacity.Text = "Capacity:"
        '
        'user6
        '
        Me.user6.Location = New System.Drawing.Point(207, 133)
        Me.user6.Name = "user6"
        Me.user6.Size = New System.Drawing.Size(244, 28)
        Me.user6.TabIndex = 1
        '
        'busid6
        '
        Me.busid6.Location = New System.Drawing.Point(207, 39)
        Me.busid6.Name = "busid6"
        Me.busid6.Size = New System.Drawing.Size(244, 28)
        Me.busid6.TabIndex = 10
        '
        'userid2
        '
        Me.userid2.AutoSize = True
        Me.userid2.Location = New System.Drawing.Point(125, 140)
        Me.userid2.Name = "userid2"
        Me.userid2.Size = New System.Drawing.Size(68, 21)
        Me.userid2.TabIndex = 3
        Me.userid2.Text = "UserID:"
        '
        'busid
        '
        Me.busid.AutoSize = True
        Me.busid.Location = New System.Drawing.Point(124, 42)
        Me.busid.Name = "busid"
        Me.busid.Size = New System.Drawing.Size(60, 21)
        Me.busid.TabIndex = 9
        Me.busid.Text = "BusID:"
        '
        'platenum
        '
        Me.platenum.AutoSize = True
        Me.platenum.Location = New System.Drawing.Point(499, 45)
        Me.platenum.Name = "platenum"
        Me.platenum.Size = New System.Drawing.Size(129, 21)
        Me.platenum.TabIndex = 13
        Me.platenum.Text = "Plate Number:"
        '
        'bustype
        '
        Me.bustype.AutoSize = True
        Me.bustype.Location = New System.Drawing.Point(124, 90)
        Me.bustype.Name = "bustype"
        Me.bustype.Size = New System.Drawing.Size(81, 21)
        Me.bustype.TabIndex = 17
        Me.bustype.Text = "Bus Type"
        '
        's6
        '
        Me.s6.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s6.Location = New System.Drawing.Point(959, 19)
        Me.s6.Name = "s6"
        Me.s6.Size = New System.Drawing.Size(265, 28)
        Me.s6.TabIndex = 24
        '
        'search6
        '
        Me.search6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.search6.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.search6.Location = New System.Drawing.Point(1230, 19)
        Me.search6.Name = "search6"
        Me.search6.Size = New System.Drawing.Size(117, 32)
        Me.search6.TabIndex = 23
        Me.search6.Text = "Search"
        Me.search6.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.Image = CType(resources.GetObject("deletebtn.Image"), System.Drawing.Image)
        Me.deletebtn.Location = New System.Drawing.Point(1125, 127)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(42, 30)
        Me.deletebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.deletebtn.TabIndex = 45
        Me.deletebtn.TabStop = False
        '
        'editbtn
        '
        Me.editbtn.Image = CType(resources.GetObject("editbtn.Image"), System.Drawing.Image)
        Me.editbtn.Location = New System.Drawing.Point(1053, 127)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(40, 30)
        Me.editbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editbtn.TabIndex = 44
        Me.editbtn.TabStop = False
        '
        'addbtn
        '
        Me.addbtn.Image = CType(resources.GetObject("addbtn.Image"), System.Drawing.Image)
        Me.addbtn.Location = New System.Drawing.Point(986, 127)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(34, 30)
        Me.addbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addbtn.TabIndex = 43
        Me.addbtn.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Panel1.Controls.Add(Me.menubtn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.s6)
        Me.Panel1.Controls.Add(Me.search6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1359, 66)
        Me.Panel1.TabIndex = 42
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
        Me.Label7.Size = New System.Drawing.Size(214, 32)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Bus Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(931, 376)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 37)
        Me.Label9.TabIndex = 41
        '
        'uploadbtn
        '
        Me.uploadbtn.Image = CType(resources.GetObject("uploadbtn.Image"), System.Drawing.Image)
        Me.uploadbtn.Location = New System.Drawing.Point(986, 405)
        Me.uploadbtn.Name = "uploadbtn"
        Me.uploadbtn.Size = New System.Drawing.Size(34, 33)
        Me.uploadbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.uploadbtn.TabIndex = 50
        Me.uploadbtn.TabStop = False
        '
        'printbtn
        '
        Me.printbtn.Image = CType(resources.GetObject("printbtn.Image"), System.Drawing.Image)
        Me.printbtn.Location = New System.Drawing.Point(1115, 407)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(42, 31)
        Me.printbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.printbtn.TabIndex = 49
        Me.printbtn.TabStop = False
        '
        'viewlistbtn
        '
        Me.viewlistbtn.Image = CType(resources.GetObject("viewlistbtn.Image"), System.Drawing.Image)
        Me.viewlistbtn.Location = New System.Drawing.Point(1053, 405)
        Me.viewlistbtn.Name = "viewlistbtn"
        Me.viewlistbtn.Size = New System.Drawing.Size(38, 33)
        Me.viewlistbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.viewlistbtn.TabIndex = 47
        Me.viewlistbtn.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(584, 767)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 18)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "s"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(142, 455)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1051, 309)
        Me.DataGridView2.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gotham Rounded Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(565, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 24)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Bus Details Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gotham Rounded Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(598, 414)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 24)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Bus Records"
        '
        'frmBus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 794)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uploadbtn)
        Me.Controls.Add(Me.printbtn)
        Me.Controls.Add(Me.viewlistbtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BusForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.deletebtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uploadbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewlistbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents userid2 As Label
    Friend WithEvents user6 As TextBox
    Friend WithEvents bustype6 As ComboBox
    Friend WithEvents s6 As TextBox
    Friend WithEvents search6 As Button
    Friend WithEvents deletebtn As PictureBox
    Friend WithEvents editbtn As PictureBox
    Friend WithEvents addbtn As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents menubtn As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents uploadbtn As PictureBox
    Friend WithEvents printbtn As PictureBox
    Friend WithEvents viewlistbtn As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
