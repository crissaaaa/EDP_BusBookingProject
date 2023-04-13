<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TravelSchedForm
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
        Me.s01 = New System.Windows.Forms.TextBox()
        Me.del0 = New System.Windows.Forms.Button()
        Me.update0 = New System.Windows.Forms.Button()
        Me.add0 = New System.Windows.Forms.Button()
        Me.useridnum2 = New System.Windows.Forms.TextBox()
        Me.emailadd = New System.Windows.Forms.Label()
        Me.grid2 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GoToMain0 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.startpt = New System.Windows.Forms.TextBox()
        Me.busid0 = New System.Windows.Forms.TextBox()
        Me.search0 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tsID = New System.Windows.Forms.TextBox()
        Me.bookingid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dest = New System.Windows.Forms.TextBox()
        Me.loaddb = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bookid1 = New System.Windows.Forms.TextBox()
        Me.date1 = New System.Windows.Forms.TextBox()
        Me.time1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        's01
        '
        Me.s01.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s01.Location = New System.Drawing.Point(54, 112)
        Me.s01.Name = "s01"
        Me.s01.Size = New System.Drawing.Size(570, 28)
        Me.s01.TabIndex = 35
        '
        'del0
        '
        Me.del0.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.del0.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.del0.Location = New System.Drawing.Point(377, 455)
        Me.del0.Name = "del0"
        Me.del0.Size = New System.Drawing.Size(133, 46)
        Me.del0.TabIndex = 28
        Me.del0.Text = "Delete"
        Me.del0.UseVisualStyleBackColor = False
        '
        'update0
        '
        Me.update0.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.update0.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.update0.Location = New System.Drawing.Point(226, 455)
        Me.update0.Name = "update0"
        Me.update0.Size = New System.Drawing.Size(133, 46)
        Me.update0.TabIndex = 27
        Me.update0.Text = "Update"
        Me.update0.UseVisualStyleBackColor = False
        '
        'add0
        '
        Me.add0.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.add0.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.add0.Location = New System.Drawing.Point(75, 455)
        Me.add0.Name = "add0"
        Me.add0.Size = New System.Drawing.Size(133, 46)
        Me.add0.TabIndex = 26
        Me.add0.Text = "Add"
        Me.add0.UseVisualStyleBackColor = False
        '
        'useridnum2
        '
        Me.useridnum2.Location = New System.Drawing.Point(340, 185)
        Me.useridnum2.Name = "useridnum2"
        Me.useridnum2.Size = New System.Drawing.Size(170, 28)
        Me.useridnum2.TabIndex = 19
        '
        'emailadd
        '
        Me.emailadd.AutoSize = True
        Me.emailadd.Location = New System.Drawing.Point(71, 230)
        Me.emailadd.Name = "emailadd"
        Me.emailadd.Size = New System.Drawing.Size(124, 21)
        Me.emailadd.TabIndex = 18
        Me.emailadd.Text = "Starting Point:"
        '
        'grid2
        '
        Me.grid2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid2.Location = New System.Drawing.Point(54, 159)
        Me.grid2.Name = "grid2"
        Me.grid2.RowHeadersWidth = 51
        Me.grid2.RowTemplate.Height = 24
        Me.grid2.Size = New System.Drawing.Size(925, 430)
        Me.grid2.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(123, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(447, 32)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Travel Schedule Information Form"
        '
        'GoToMain0
        '
        Me.GoToMain0.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GoToMain0.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoToMain0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GoToMain0.Location = New System.Drawing.Point(54, 40)
        Me.GoToMain0.Name = "GoToMain0"
        Me.GoToMain0.Size = New System.Drawing.Size(63, 32)
        Me.GoToMain0.TabIndex = 33
        Me.GoToMain0.Text = "<"
        Me.GoToMain0.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 21)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "BusID:"
        '
        'startpt
        '
        Me.startpt.Location = New System.Drawing.Point(106, 254)
        Me.startpt.Name = "startpt"
        Me.startpt.Size = New System.Drawing.Size(408, 28)
        Me.startpt.TabIndex = 16
        '
        'busid0
        '
        Me.busid0.Location = New System.Drawing.Point(106, 185)
        Me.busid0.Name = "busid0"
        Me.busid0.Size = New System.Drawing.Size(170, 28)
        Me.busid0.TabIndex = 15
        '
        'search0
        '
        Me.search0.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.search0.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.search0.Location = New System.Drawing.Point(630, 108)
        Me.search0.Name = "search0"
        Me.search0.Size = New System.Drawing.Size(167, 32)
        Me.search0.TabIndex = 34
        Me.search0.Text = "Search"
        Me.search0.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(356, 597)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(320, 18)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Overview of Recorded Travel Sched Table"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "UserID:"
        '
        'tsID
        '
        Me.tsID.Location = New System.Drawing.Point(106, 119)
        Me.tsID.Name = "tsID"
        Me.tsID.Size = New System.Drawing.Size(170, 28)
        Me.tsID.TabIndex = 10
        '
        'bookingid
        '
        Me.bookingid.AutoSize = True
        Me.bookingid.Location = New System.Drawing.Point(71, 95)
        Me.bookingid.Name = "bookingid"
        Me.bookingid.Size = New System.Drawing.Size(85, 21)
        Me.bookingid.TabIndex = 9
        Me.bookingid.Text = "SchedID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Destination"
        '
        'dest
        '
        Me.dest.Location = New System.Drawing.Point(106, 322)
        Me.dest.Name = "dest"
        Me.dest.Size = New System.Drawing.Size(408, 28)
        Me.dest.TabIndex = 1
        '
        'loaddb
        '
        Me.loaddb.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.loaddb.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.loaddb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.loaddb.Location = New System.Drawing.Point(810, 108)
        Me.loaddb.Name = "loaddb"
        Me.loaddb.Size = New System.Drawing.Size(169, 32)
        Me.loaddb.TabIndex = 38
        Me.loaddb.Text = "Load Table"
        Me.loaddb.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.time1)
        Me.GroupBox1.Controls.Add(Me.date1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.bookid1)
        Me.GroupBox1.Controls.Add(Me.del0)
        Me.GroupBox1.Controls.Add(Me.update0)
        Me.GroupBox1.Controls.Add(Me.add0)
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
        Me.GroupBox1.Location = New System.Drawing.Point(1014, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 559)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 23)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Travel Schedule Form"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(307, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 21)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "BookingID:"
        '
        'bookid1
        '
        Me.bookid1.Location = New System.Drawing.Point(340, 119)
        Me.bookid1.Name = "bookid1"
        Me.bookid1.Size = New System.Drawing.Size(174, 28)
        Me.bookid1.TabIndex = 31
        '
        'date1
        '
        Me.date1.Location = New System.Drawing.Point(106, 391)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(170, 28)
        Me.date1.TabIndex = 35
        '
        'time1
        '
        Me.time1.Location = New System.Drawing.Point(340, 391)
        Me.time1.Name = "time1"
        Me.time1.Size = New System.Drawing.Size(170, 28)
        Me.time1.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(307, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 21)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Time:"
        '
        'TravelSchedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1658, 807)
        Me.Controls.Add(Me.s01)
        Me.Controls.Add(Me.grid2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GoToMain0)
        Me.Controls.Add(Me.search0)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.loaddb)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TravelSchedForm"
        Me.Text = "TravelSchedForm"
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents s01 As TextBox
    Friend WithEvents del0 As Button
    Friend WithEvents update0 As Button
    Friend WithEvents add0 As Button
    Friend WithEvents useridnum2 As TextBox
    Friend WithEvents emailadd As Label
    Friend WithEvents grid2 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents GoToMain0 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents startpt As TextBox
    Friend WithEvents busid0 As TextBox
    Friend WithEvents search0 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tsID As TextBox
    Friend WithEvents bookingid As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dest As TextBox
    Friend WithEvents loaddb As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents bookid1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents date1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents time1 As TextBox
End Class
