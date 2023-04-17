<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SideBarContainer = New System.Windows.Forms.Panel()
        Me.btnBackupDB = New System.Windows.Forms.Button()
        Me.btnTravelSched = New System.Windows.Forms.Button()
        Me.btnDriver = New System.Windows.Forms.Button()
        Me.btnTotalPayment = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnBus = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sidebartimer = New System.Windows.Forms.Timer(Me.components)
        Me.SideBarContainer.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBooking
        '
        Me.btnBooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnBooking.FlatAppearance.BorderSize = 0
        Me.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooking.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooking.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBooking.Location = New System.Drawing.Point(-1, 174)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnBooking.Size = New System.Drawing.Size(281, 42)
        Me.btnBooking.TabIndex = 9
        Me.btnBooking.Text = "Booking"
        Me.btnBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooking.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Gotham Rounded Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(630, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 72)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "WELCOME!"
        '
        'SideBarContainer
        '
        Me.SideBarContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SideBarContainer.Controls.Add(Me.btnBackupDB)
        Me.SideBarContainer.Controls.Add(Me.btnTravelSched)
        Me.SideBarContainer.Controls.Add(Me.btnDriver)
        Me.SideBarContainer.Controls.Add(Me.btnTotalPayment)
        Me.SideBarContainer.Controls.Add(Me.btnPayment)
        Me.SideBarContainer.Controls.Add(Me.btnUser)
        Me.SideBarContainer.Controls.Add(Me.btnLogout)
        Me.SideBarContainer.Controls.Add(Me.btnBus)
        Me.SideBarContainer.Controls.Add(Me.btnCustomer)
        Me.SideBarContainer.Controls.Add(Me.PanelLogo)
        Me.SideBarContainer.Controls.Add(Me.btnBooking)
        Me.SideBarContainer.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideBarContainer.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.SideBarContainer.Location = New System.Drawing.Point(0, 0)
        Me.SideBarContainer.Name = "SideBarContainer"
        Me.SideBarContainer.Size = New System.Drawing.Size(280, 794)
        Me.SideBarContainer.TabIndex = 19
        '
        'btnBackupDB
        '
        Me.btnBackupDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnBackupDB.FlatAppearance.BorderSize = 0
        Me.btnBackupDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackupDB.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackupDB.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBackupDB.Location = New System.Drawing.Point(0, 558)
        Me.btnBackupDB.Name = "btnBackupDB"
        Me.btnBackupDB.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnBackupDB.Size = New System.Drawing.Size(277, 42)
        Me.btnBackupDB.TabIndex = 18
        Me.btnBackupDB.Text = "Back-up Database"
        Me.btnBackupDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackupDB.UseVisualStyleBackColor = False
        '
        'btnTravelSched
        '
        Me.btnTravelSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnTravelSched.FlatAppearance.BorderSize = 0
        Me.btnTravelSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTravelSched.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTravelSched.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTravelSched.Location = New System.Drawing.Point(0, 414)
        Me.btnTravelSched.Name = "btnTravelSched"
        Me.btnTravelSched.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnTravelSched.Size = New System.Drawing.Size(280, 42)
        Me.btnTravelSched.TabIndex = 17
        Me.btnTravelSched.Text = "Travel Schedule"
        Me.btnTravelSched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTravelSched.UseVisualStyleBackColor = False
        '
        'btnDriver
        '
        Me.btnDriver.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnDriver.FlatAppearance.BorderSize = 0
        Me.btnDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDriver.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDriver.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDriver.Location = New System.Drawing.Point(0, 366)
        Me.btnDriver.Name = "btnDriver"
        Me.btnDriver.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnDriver.Size = New System.Drawing.Size(277, 42)
        Me.btnDriver.TabIndex = 16
        Me.btnDriver.Text = "Driver"
        Me.btnDriver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDriver.UseVisualStyleBackColor = False
        '
        'btnTotalPayment
        '
        Me.btnTotalPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnTotalPayment.FlatAppearance.BorderSize = 0
        Me.btnTotalPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTotalPayment.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalPayment.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTotalPayment.Location = New System.Drawing.Point(-3, 510)
        Me.btnTotalPayment.Name = "btnTotalPayment"
        Me.btnTotalPayment.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnTotalPayment.Size = New System.Drawing.Size(279, 42)
        Me.btnTotalPayment.TabIndex = 15
        Me.btnTotalPayment.Text = "Total Payment"
        Me.btnTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTotalPayment.UseVisualStyleBackColor = False
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnPayment.FlatAppearance.BorderSize = 0
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPayment.Location = New System.Drawing.Point(-1, 462)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnPayment.Size = New System.Drawing.Size(285, 42)
        Me.btnPayment.TabIndex = 14
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUser.Location = New System.Drawing.Point(0, 318)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnUser.Size = New System.Drawing.Size(280, 42)
        Me.btnUser.TabIndex = 13
        Me.btnUser.Text = "User"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(-3, 740)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(283, 42)
        Me.btnLogout.TabIndex = 12
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnBus
        '
        Me.btnBus.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnBus.FlatAppearance.BorderSize = 0
        Me.btnBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBus.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBus.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBus.Location = New System.Drawing.Point(0, 222)
        Me.btnBus.Name = "btnBus"
        Me.btnBus.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnBus.Size = New System.Drawing.Size(284, 42)
        Me.btnBus.TabIndex = 11
        Me.btnBus.Text = "Bus"
        Me.btnBus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBus.UseVisualStyleBackColor = False
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCustomer.Location = New System.Drawing.Point(-1, 270)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCustomer.Size = New System.Drawing.Size(277, 42)
        Me.btnCustomer.TabIndex = 10
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Location = New System.Drawing.Point(-1, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(281, 149)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.BusBooking_Project.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1359, 794)
        Me.Controls.Add(Me.SideBarContainer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.SideBarContainer.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBooking As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SideBarContainer As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents btnTravelSched As Button
    Friend WithEvents btnDriver As Button
    Friend WithEvents btnTotalPayment As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnBus As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnBackupDB As Button
    Friend WithEvents sidebartimer As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
