<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TotalPaymentForm
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
        Me.delete = New System.Windows.Forms.Button()
        Me.total = New System.Windows.Forms.TextBox()
        Me.update = New System.Windows.Forms.Button()
        Me.userid = New System.Windows.Forms.Label()
        Me.add1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.uID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.Button()
        Me.search1 = New System.Windows.Forms.TextBox()
        Me.GoToMain6 = New System.Windows.Forms.Button()
        Me.grid2 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.loaddb = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.delete)
        Me.GroupBox1.Controls.Add(Me.total)
        Me.GroupBox1.Controls.Add(Me.update)
        Me.GroupBox1.Controls.Add(Me.userid)
        Me.GroupBox1.Controls.Add(Me.add1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.uID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(64, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 325)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.delete.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.delete.Location = New System.Drawing.Point(345, 227)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(133, 46)
        Me.delete.TabIndex = 25
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = False
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(144, 172)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(319, 28)
        Me.total.TabIndex = 12
        '
        'update
        '
        Me.update.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.update.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.update.Location = New System.Drawing.Point(194, 227)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(133, 46)
        Me.update.TabIndex = 24
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = False
        '
        'userid
        '
        Me.userid.AutoSize = True
        Me.userid.Location = New System.Drawing.Point(57, 117)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(68, 21)
        Me.userid.TabIndex = 11
        Me.userid.Text = "UserID:"
        '
        'add1
        '
        Me.add1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.add1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.add1.Location = New System.Drawing.Point(39, 227)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(133, 46)
        Me.add1.TabIndex = 23
        Me.add1.Text = "Add"
        Me.add1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total:"
        '
        'uID
        '
        Me.uID.Location = New System.Drawing.Point(144, 117)
        Me.uID.Name = "uID"
        Me.uID.Size = New System.Drawing.Size(319, 28)
        Me.uID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL PAYMENT"
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(495, 86)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(114, 32)
        Me.search.TabIndex = 3
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = True
        '
        'search1
        '
        Me.search1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search1.Location = New System.Drawing.Point(64, 86)
        Me.search1.Name = "search1"
        Me.search1.Size = New System.Drawing.Size(425, 28)
        Me.search1.TabIndex = 10
        '
        'GoToMain6
        '
        Me.GoToMain6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GoToMain6.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoToMain6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GoToMain6.Location = New System.Drawing.Point(64, 32)
        Me.GoToMain6.Name = "GoToMain6"
        Me.GoToMain6.Size = New System.Drawing.Size(67, 32)
        Me.GoToMain6.TabIndex = 15
        Me.GoToMain6.Text = "<"
        Me.GoToMain6.UseVisualStyleBackColor = False
        '
        'grid2
        '
        Me.grid2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid2.Location = New System.Drawing.Point(671, 136)
        Me.grid2.Name = "grid2"
        Me.grid2.RowHeadersWidth = 51
        Me.grid2.RowTemplate.Height = 24
        Me.grid2.Size = New System.Drawing.Size(489, 325)
        Me.grid2.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(791, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(354, 18)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Overview of Total Payment Transaction Record"
        '
        'loaddb
        '
        Me.loaddb.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.loaddb.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.loaddb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.loaddb.Location = New System.Drawing.Point(671, 87)
        Me.loaddb.Name = "loaddb"
        Me.loaddb.Size = New System.Drawing.Size(114, 32)
        Me.loaddb.TabIndex = 45
        Me.loaddb.Text = "Load Table"
        Me.loaddb.UseVisualStyleBackColor = False
        '
        'TotalPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 717)
        Me.Controls.Add(Me.grid2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.loaddb)
        Me.Controls.Add(Me.GoToMain6)
        Me.Controls.Add(Me.search1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "TotalPaymentForm"
        Me.Text = "TotalPaymentForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents uID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents total As TextBox
    Friend WithEvents userid As Label
    Friend WithEvents search As Button
    Friend WithEvents search1 As TextBox
    Friend WithEvents delete As Button
    Friend WithEvents update As Button
    Friend WithEvents add1 As Button
    Friend WithEvents GoToMain6 As Button
    Friend WithEvents grid2 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents loaddb As Button
End Class
