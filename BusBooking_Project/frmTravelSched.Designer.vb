<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTravelSched
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTravelSched))
        Me.s01 = New System.Windows.Forms.TextBox()
        Me.useridnum2 = New System.Windows.Forms.TextBox()
        Me.emailadd = New System.Windows.Forms.Label()
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.startpt = New System.Windows.Forms.TextBox()
        Me.busid0 = New System.Windows.Forms.TextBox()
        Me.search0 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tsID = New System.Windows.Forms.TextBox()
        Me.bookingid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dest = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.deletebtn = New System.Windows.Forms.PictureBox()
        Me.time1 = New System.Windows.Forms.TextBox()
        Me.editbtn = New System.Windows.Forms.PictureBox()
        Me.date1 = New System.Windows.Forms.TextBox()
        Me.addbtn = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bookid1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.menubtn = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.uploadbtn = New System.Windows.Forms.PictureBox()
        Me.printbtn = New System.Windows.Forms.PictureBox()
        Me.viewlistbtn = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.deletebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.uploadbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewlistbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        's01
        '
        Me.s01.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s01.Location = New System.Drawing.Point(895, 16)
        Me.s01.Name = "s01"
        Me.s01.Size = New System.Drawing.Size(296, 28)
        Me.s01.TabIndex = 35
        '
        'useridnum2
        '
        Me.useridnum2.Location = New System.Drawing.Point(876, 101)
        Me.useridnum2.Name = "useridnum2"
        Me.useridnum2.Size = New System.Drawing.Size(139, 28)
        Me.useridnum2.TabIndex = 19
        '
        'emailadd
        '
        Me.emailadd.AutoSize = True
        Me.emailadd.Location = New System.Drawing.Point(71, 159)
        Me.emailadd.Name = "emailadd"
        Me.emailadd.Size = New System.Drawing.Size(124, 21)
        Me.emailadd.TabIndex = 18
        Me.emailadd.Text = "Starting Point:"
        '
        'DataGridView7
        '
        Me.DataGridView7.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Location = New System.Drawing.Point(118, 460)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.RowHeadersWidth = 51
        Me.DataGridView7.RowTemplate.Height = 24
        Me.DataGridView7.Size = New System.Drawing.Size(1100, 289)
        Me.DataGridView7.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(575, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 21)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "BusID:"
        '
        'startpt
        '
        Me.startpt.Location = New System.Drawing.Point(212, 156)
        Me.startpt.Name = "startpt"
        Me.startpt.Size = New System.Drawing.Size(346, 28)
        Me.startpt.TabIndex = 16
        '
        'busid0
        '
        Me.busid0.Location = New System.Drawing.Point(657, 101)
        Me.busid0.Name = "busid0"
        Me.busid0.Size = New System.Drawing.Size(139, 28)
        Me.busid0.TabIndex = 15
        '
        'search0
        '
        Me.search0.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.search0.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.search0.Location = New System.Drawing.Point(1197, 16)
        Me.search0.Name = "search0"
        Me.search0.Size = New System.Drawing.Size(127, 32)
        Me.search0.TabIndex = 34
        Me.search0.Text = "Search"
        Me.search0.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(802, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "UserID:"
        '
        'tsID
        '
        Me.tsID.Location = New System.Drawing.Point(168, 101)
        Me.tsID.Name = "tsID"
        Me.tsID.Size = New System.Drawing.Size(140, 28)
        Me.tsID.TabIndex = 10
        '
        'bookingid
        '
        Me.bookingid.AutoSize = True
        Me.bookingid.Location = New System.Drawing.Point(71, 104)
        Me.bookingid.Name = "bookingid"
        Me.bookingid.Size = New System.Drawing.Size(85, 21)
        Me.bookingid.TabIndex = 9
        Me.bookingid.Text = "SchedID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(575, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Destination:"
        '
        'dest
        '
        Me.dest.Location = New System.Drawing.Point(690, 156)
        Me.dest.Name = "dest"
        Me.dest.Size = New System.Drawing.Size(325, 28)
        Me.dest.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.deletebtn)
        Me.GroupBox1.Controls.Add(Me.time1)
        Me.GroupBox1.Controls.Add(Me.editbtn)
        Me.GroupBox1.Controls.Add(Me.date1)
        Me.GroupBox1.Controls.Add(Me.addbtn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.bookid1)
        Me.GroupBox1.Controls.Add(Me.useridnum2)
        Me.GroupBox1.Controls.Add(Me.emailadd)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.startpt)
        Me.GroupBox1.Controls.Add(Me.busid0)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tsID)
        Me.GroupBox1.Controls.Add(Me.bookingid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dest)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(118, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1100, 275)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(580, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 21)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Time:"
        '
        'deletebtn
        '
        Me.deletebtn.Image = CType(resources.GetObject("deletebtn.Image"), System.Drawing.Image)
        Me.deletebtn.Location = New System.Drawing.Point(975, 43)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(40, 30)
        Me.deletebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.deletebtn.TabIndex = 46
        Me.deletebtn.TabStop = False
        '
        'time1
        '
        Me.time1.Location = New System.Drawing.Point(638, 204)
        Me.time1.Name = "time1"
        Me.time1.Size = New System.Drawing.Size(377, 28)
        Me.time1.TabIndex = 36
        '
        'editbtn
        '
        Me.editbtn.Image = CType(resources.GetObject("editbtn.Image"), System.Drawing.Image)
        Me.editbtn.Location = New System.Drawing.Point(911, 43)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(37, 30)
        Me.editbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editbtn.TabIndex = 45
        Me.editbtn.TabStop = False
        '
        'date1
        '
        Me.date1.Location = New System.Drawing.Point(162, 204)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(396, 28)
        Me.date1.TabIndex = 35
        '
        'addbtn
        '
        Me.addbtn.Image = CType(resources.GetObject("addbtn.Image"), System.Drawing.Image)
        Me.addbtn.Location = New System.Drawing.Point(852, 43)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(29, 30)
        Me.addbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addbtn.TabIndex = 44
        Me.addbtn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(429, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 23)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Travel Schedule Form"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(314, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 21)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "BookingID:"
        '
        'bookid1
        '
        Me.bookid1.Location = New System.Drawing.Point(418, 101)
        Me.bookid1.Name = "bookid1"
        Me.bookid1.Size = New System.Drawing.Size(140, 28)
        Me.bookid1.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(112, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 32)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Travel Schedule"
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
        Me.Panel1.Controls.Add(Me.s01)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.search0)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1359, 66)
        Me.Panel1.TabIndex = 40
        '
        'uploadbtn
        '
        Me.uploadbtn.Image = CType(resources.GetObject("uploadbtn.Image"), System.Drawing.Image)
        Me.uploadbtn.Location = New System.Drawing.Point(1029, 419)
        Me.uploadbtn.Name = "uploadbtn"
        Me.uploadbtn.Size = New System.Drawing.Size(40, 30)
        Me.uploadbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.uploadbtn.TabIndex = 47
        Me.uploadbtn.TabStop = False
        '
        'printbtn
        '
        Me.printbtn.Image = CType(resources.GetObject("printbtn.Image"), System.Drawing.Image)
        Me.printbtn.Location = New System.Drawing.Point(1102, 419)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(31, 30)
        Me.printbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.printbtn.TabIndex = 43
        Me.printbtn.TabStop = False
        '
        'viewlistbtn
        '
        Me.viewlistbtn.Image = CType(resources.GetObject("viewlistbtn.Image"), System.Drawing.Image)
        Me.viewlistbtn.Location = New System.Drawing.Point(970, 417)
        Me.viewlistbtn.Name = "viewlistbtn"
        Me.viewlistbtn.Size = New System.Drawing.Size(37, 32)
        Me.viewlistbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.viewlistbtn.TabIndex = 42
        Me.viewlistbtn.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(529, 426)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(248, 23)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Travel Schedule Records"
        '
        'frmTravelSched
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 794)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.uploadbtn)
        Me.Controls.Add(Me.printbtn)
        Me.Controls.Add(Me.viewlistbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTravelSched"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelSchedForm"
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.deletebtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menubtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.uploadbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewlistbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents s01 As TextBox
    Friend WithEvents useridnum2 As TextBox
    Friend WithEvents emailadd As Label
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents startpt As TextBox
    Friend WithEvents busid0 As TextBox
    Friend WithEvents search0 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tsID As TextBox
    Friend WithEvents bookingid As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dest As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents bookid1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents date1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents time1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents menubtn As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents deletebtn As PictureBox
    Friend WithEvents editbtn As PictureBox
    Friend WithEvents addbtn As PictureBox
    Friend WithEvents uploadbtn As PictureBox
    Friend WithEvents printbtn As PictureBox
    Friend WithEvents viewlistbtn As PictureBox
    Friend WithEvents Label7 As Label
End Class
