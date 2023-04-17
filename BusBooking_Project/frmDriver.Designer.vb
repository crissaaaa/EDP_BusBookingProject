<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDriver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDriver))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dcontact = New System.Windows.Forms.TextBox()
        Me.drivercon = New System.Windows.Forms.Label()
        Me.dname = New System.Windows.Forms.TextBox()
        Me.platenum = New System.Windows.Forms.Label()
        Me.dID = New System.Windows.Forms.TextBox()
        Me.busid = New System.Windows.Forms.Label()
        Me.userid2 = New System.Windows.Forms.Label()
        Me.u2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.search4 = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.menubtn = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.uploadbtn = New System.Windows.Forms.PictureBox()
        Me.deletebtn = New System.Windows.Forms.PictureBox()
        Me.editbtn = New System.Windows.Forms.PictureBox()
        Me.addbtn = New System.Windows.Forms.PictureBox()
        Me.printbtn = New System.Windows.Forms.PictureBox()
        Me.viewlistbtn = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.dcontact)
        Me.GroupBox1.Controls.Add(Me.drivercon)
        Me.GroupBox1.Controls.Add(Me.dname)
        Me.GroupBox1.Controls.Add(Me.platenum)
        Me.GroupBox1.Controls.Add(Me.dID)
        Me.GroupBox1.Controls.Add(Me.busid)
        Me.GroupBox1.Controls.Add(Me.userid2)
        Me.GroupBox1.Controls.Add(Me.u2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(232, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(827, 229)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'dcontact
        '
        Me.dcontact.Location = New System.Drawing.Point(345, 146)
        Me.dcontact.Name = "dcontact"
        Me.dcontact.Size = New System.Drawing.Size(352, 28)
        Me.dcontact.TabIndex = 23
        '
        'drivercon
        '
        Me.drivercon.AutoSize = True
        Me.drivercon.Location = New System.Drawing.Point(106, 153)
        Me.drivercon.Name = "drivercon"
        Me.drivercon.Size = New System.Drawing.Size(221, 21)
        Me.drivercon.TabIndex = 17
        Me.drivercon.Text = "Driver's Contact Number:"
        '
        'dname
        '
        Me.dname.Location = New System.Drawing.Point(245, 102)
        Me.dname.Name = "dname"
        Me.dname.Size = New System.Drawing.Size(452, 28)
        Me.dname.TabIndex = 14
        '
        'platenum
        '
        Me.platenum.AutoSize = True
        Me.platenum.Location = New System.Drawing.Point(106, 105)
        Me.platenum.Name = "platenum"
        Me.platenum.Size = New System.Drawing.Size(119, 21)
        Me.platenum.TabIndex = 13
        Me.platenum.Text = "Driver Name:"
        '
        'dID
        '
        Me.dID.Location = New System.Drawing.Point(204, 54)
        Me.dID.Name = "dID"
        Me.dID.Size = New System.Drawing.Size(200, 28)
        Me.dID.TabIndex = 10
        '
        'busid
        '
        Me.busid.AutoSize = True
        Me.busid.Location = New System.Drawing.Point(106, 57)
        Me.busid.Name = "busid"
        Me.busid.Size = New System.Drawing.Size(81, 21)
        Me.busid.TabIndex = 9
        Me.busid.Text = "DriverID:"
        '
        'userid2
        '
        Me.userid2.AutoSize = True
        Me.userid2.Location = New System.Drawing.Point(422, 57)
        Me.userid2.Name = "userid2"
        Me.userid2.Size = New System.Drawing.Size(68, 21)
        Me.userid2.TabIndex = 3
        Me.userid2.Text = "UserID:"
        '
        'u2
        '
        Me.u2.Location = New System.Drawing.Point(496, 54)
        Me.u2.Name = "u2"
        Me.u2.Size = New System.Drawing.Size(201, 28)
        Me.u2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gotham Rounded Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(516, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Driver Information Table"
        '
        'search4
        '
        Me.search4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search4.Location = New System.Drawing.Point(838, 22)
        Me.search4.Name = "search4"
        Me.search4.Size = New System.Drawing.Size(377, 28)
        Me.search4.TabIndex = 19
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(1223, 16)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(95, 38)
        Me.search.TabIndex = 18
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(385, 462)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 23)
        Me.Label2.TabIndex = 22
        '
        'DataGridView4
        '
        Me.DataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(232, 435)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(827, 309)
        Me.DataGridView4.TabIndex = 30
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Panel1.Controls.Add(Me.menubtn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.search4)
        Me.Panel1.Controls.Add(Me.search)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1359, 66)
        Me.Panel1.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(112, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 32)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Driver Information"
        '
        'uploadbtn
        '
        Me.uploadbtn.Image = CType(resources.GetObject("uploadbtn.Image"), System.Drawing.Image)
        Me.uploadbtn.Location = New System.Drawing.Point(854, 387)
        Me.uploadbtn.Name = "uploadbtn"
        Me.uploadbtn.Size = New System.Drawing.Size(40, 36)
        Me.uploadbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.uploadbtn.TabIndex = 48
        Me.uploadbtn.TabStop = False
        '
        'deletebtn
        '
        Me.deletebtn.Image = CType(resources.GetObject("deletebtn.Image"), System.Drawing.Image)
        Me.deletebtn.Location = New System.Drawing.Point(978, 106)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(38, 29)
        Me.deletebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.deletebtn.TabIndex = 47
        Me.deletebtn.TabStop = False
        '
        'editbtn
        '
        Me.editbtn.Image = CType(resources.GetObject("editbtn.Image"), System.Drawing.Image)
        Me.editbtn.Location = New System.Drawing.Point(923, 106)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(30, 29)
        Me.editbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editbtn.TabIndex = 46
        Me.editbtn.TabStop = False
        '
        'addbtn
        '
        Me.addbtn.Image = CType(resources.GetObject("addbtn.Image"), System.Drawing.Image)
        Me.addbtn.Location = New System.Drawing.Point(854, 106)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(40, 29)
        Me.addbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addbtn.TabIndex = 45
        Me.addbtn.TabStop = False
        '
        'printbtn
        '
        Me.printbtn.Image = CType(resources.GetObject("printbtn.Image"), System.Drawing.Image)
        Me.printbtn.Location = New System.Drawing.Point(978, 391)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(38, 32)
        Me.printbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.printbtn.TabIndex = 44
        Me.printbtn.TabStop = False
        '
        'viewlistbtn
        '
        Me.viewlistbtn.Image = CType(resources.GetObject("viewlistbtn.Image"), System.Drawing.Image)
        Me.viewlistbtn.Location = New System.Drawing.Point(923, 389)
        Me.viewlistbtn.Name = "viewlistbtn"
        Me.viewlistbtn.Size = New System.Drawing.Size(30, 34)
        Me.viewlistbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.viewlistbtn.TabIndex = 42
        Me.viewlistbtn.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gotham Rounded Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(561, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 24)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Driver Form"
        '
        'frmDriver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 794)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.uploadbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.printbtn)
        Me.Controls.Add(Me.viewlistbtn)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDriver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DriverForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents dcontact As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents drivercon As Label
    Friend WithEvents dname As TextBox
    Friend WithEvents platenum As Label
    Friend WithEvents dID As TextBox
    Friend WithEvents busid As Label
    Friend WithEvents userid2 As Label
    Friend WithEvents u2 As TextBox
    Friend WithEvents search4 As TextBox
    Friend WithEvents search As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents menubtn As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents uploadbtn As PictureBox
    Friend WithEvents deletebtn As PictureBox
    Friend WithEvents editbtn As PictureBox
    Friend WithEvents addbtn As PictureBox
    Friend WithEvents printbtn As PictureBox
    Friend WithEvents viewlistbtn As PictureBox
    Friend WithEvents Label3 As Label
End Class
