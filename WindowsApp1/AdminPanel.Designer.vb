<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPanel))
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnManageUser = New System.Windows.Forms.Button()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.btnCreateEvent = New System.Windows.Forms.Button()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(12, 336)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(118, 53)
        Me.btnCreateUser.TabIndex = 0
        Me.btnCreateUser.Text = "Create User"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Location = New System.Drawing.Point(164, 336)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(118, 53)
        Me.btnDeleteUser.TabIndex = 1
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnManageUser
        '
        Me.btnManageUser.Location = New System.Drawing.Point(323, 336)
        Me.btnManageUser.Name = "btnManageUser"
        Me.btnManageUser.Size = New System.Drawing.Size(118, 53)
        Me.btnManageUser.TabIndex = 2
        Me.btnManageUser.Text = "Manage User"
        Me.btnManageUser.UseVisualStyleBackColor = True
        '
        'dgvUsers
        '
        Me.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(12, 28)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.Size = New System.Drawing.Size(589, 276)
        Me.dgvUsers.TabIndex = 3
        '
        'btnCreateEvent
        '
        Me.btnCreateEvent.Location = New System.Drawing.Point(483, 336)
        Me.btnCreateEvent.Name = "btnCreateEvent"
        Me.btnCreateEvent.Size = New System.Drawing.Size(118, 53)
        Me.btnCreateEvent.TabIndex = 4
        Me.btnCreateEvent.Text = "Create Event"
        Me.btnCreateEvent.UseVisualStyleBackColor = True
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(620, 450)
        Me.Controls.Add(Me.btnCreateEvent)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.btnManageUser)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminPanel"
        Me.Text = "Admin Panel"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreateUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnManageUser As Button
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnCreateEvent As Button
End Class
