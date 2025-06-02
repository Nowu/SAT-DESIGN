<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EventPage))
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.picSideBar = New System.Windows.Forms.PictureBox()
        Me.lblBlurb = New System.Windows.Forms.Label()
        Me.btnJoinEvent = New System.Windows.Forms.Button()
        Me.lstboxAttedence = New System.Windows.Forms.ListBox()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        CType(Me.picSideBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.BackColor = System.Drawing.Color.Transparent
        Me.lblEventName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventName.ForeColor = System.Drawing.Color.White
        Me.lblEventName.Location = New System.Drawing.Point(12, 23)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(158, 24)
        Me.lblEventName.TabIndex = 0
        Me.lblEventName.Text = "[EVENT NAME]"
        '
        'picSideBar
        '
        Me.picSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picSideBar.Location = New System.Drawing.Point(-1, 73)
        Me.picSideBar.Name = "picSideBar"
        Me.picSideBar.Size = New System.Drawing.Size(804, 35)
        Me.picSideBar.TabIndex = 2
        Me.picSideBar.TabStop = False
        '
        'lblBlurb
        '
        Me.lblBlurb.AutoSize = True
        Me.lblBlurb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlurb.ForeColor = System.Drawing.Color.White
        Me.lblBlurb.Location = New System.Drawing.Point(13, 140)
        Me.lblBlurb.Name = "lblBlurb"
        Me.lblBlurb.Size = New System.Drawing.Size(60, 16)
        Me.lblBlurb.TabIndex = 3
        Me.lblBlurb.Text = "[BLURB]"
        '
        'btnJoinEvent
        '
        Me.btnJoinEvent.Location = New System.Drawing.Point(16, 403)
        Me.btnJoinEvent.Name = "btnJoinEvent"
        Me.btnJoinEvent.Size = New System.Drawing.Size(75, 23)
        Me.btnJoinEvent.TabIndex = 4
        Me.btnJoinEvent.Text = "Join Event?"
        Me.btnJoinEvent.UseVisualStyleBackColor = True
        '
        'lstboxAttedence
        '
        Me.lstboxAttedence.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstboxAttedence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstboxAttedence.ForeColor = System.Drawing.Color.White
        Me.lstboxAttedence.FormattingEnabled = True
        Me.lstboxAttedence.Items.AddRange(New Object() {" "})
        Me.lstboxAttedence.Location = New System.Drawing.Point(612, 140)
        Me.lstboxAttedence.Name = "lstboxAttedence"
        Me.lstboxAttedence.Size = New System.Drawing.Size(156, 197)
        Me.lstboxAttedence.TabIndex = 5
        '
        'lblFee
        '
        Me.lblFee.AutoSize = True
        Me.lblFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFee.ForeColor = System.Drawing.Color.Red
        Me.lblFee.Location = New System.Drawing.Point(12, 372)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(91, 15)
        Me.lblFee.TabIndex = 6
        Me.lblFee.Text = "[FEE AMOUNT]"
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.ForeColor = System.Drawing.Color.White
        Me.lblDueDate.Location = New System.Drawing.Point(109, 372)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(73, 15)
        Me.lblDueDate.TabIndex = 7
        Me.lblDueDate.Text = "[DUE DATE]"
        '
        'EventPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.lblFee)
        Me.Controls.Add(Me.lstboxAttedence)
        Me.Controls.Add(Me.btnJoinEvent)
        Me.Controls.Add(Me.lblBlurb)
        Me.Controls.Add(Me.picSideBar)
        Me.Controls.Add(Me.lblEventName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EventPage"
        Me.Text = "Event Page"
        CType(Me.picSideBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEventName As Label
    Friend WithEvents picSideBar As PictureBox
    Friend WithEvents lblBlurb As Label
    Friend WithEvents btnJoinEvent As Button
    Friend WithEvents lstboxAttedence As ListBox
    Friend WithEvents lblFee As Label
    Friend WithEvents lblDueDate As Label
End Class
