<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInternetSpeed
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnEnterInternetSpeed = New System.Windows.Forms.Button()
        Me.lstInternetSpeed = New System.Windows.Forms.ListBox()
        Me.lblAverageInternetSpeed = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(326, 39)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(404, 34)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Internet Speed Test Survey"
        '
        'btnEnterInternetSpeed
        '
        Me.btnEnterInternetSpeed.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnEnterInternetSpeed.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterInternetSpeed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnterInternetSpeed.Location = New System.Drawing.Point(432, 98)
        Me.btnEnterInternetSpeed.Name = "btnEnterInternetSpeed"
        Me.btnEnterInternetSpeed.Size = New System.Drawing.Size(220, 52)
        Me.btnEnterInternetSpeed.TabIndex = 1
        Me.btnEnterInternetSpeed.Text = "Enter Internet Speed "
        Me.btnEnterInternetSpeed.UseVisualStyleBackColor = False
        '
        'lstInternetSpeed
        '
        Me.lstInternetSpeed.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInternetSpeed.FormattingEnabled = True
        Me.lstInternetSpeed.ItemHeight = 19
        Me.lstInternetSpeed.Location = New System.Drawing.Point(718, 98)
        Me.lstInternetSpeed.Name = "lstInternetSpeed"
        Me.lstInternetSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstInternetSpeed.ScrollAlwaysVisible = True
        Me.lstInternetSpeed.Size = New System.Drawing.Size(87, 156)
        Me.lstInternetSpeed.TabIndex = 3
        '
        'lblAverageInternetSpeed
        '
        Me.lblAverageInternetSpeed.AutoSize = True
        Me.lblAverageInternetSpeed.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAverageInternetSpeed.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageInternetSpeed.Location = New System.Drawing.Point(462, 401)
        Me.lblAverageInternetSpeed.Name = "lblAverageInternetSpeed"
        Me.lblAverageInternetSpeed.Size = New System.Drawing.Size(233, 22)
        Me.lblAverageInternetSpeed.TabIndex = 4
        Me.lblAverageInternetSpeed.Text = "Average Internet Speed:"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(615, 337)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 30)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmInternetSpeed
        '
        Me.AcceptButton = Me.btnEnterInternetSpeed
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WeeklyAssignment6.My.Resources.Resources.speed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(842, 473)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblAverageInternetSpeed)
        Me.Controls.Add(Me.lstInternetSpeed)
        Me.Controls.Add(Me.btnEnterInternetSpeed)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmInternetSpeed"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnEnterInternetSpeed As Button
    Friend WithEvents lstInternetSpeed As ListBox
    Friend WithEvents lblAverageInternetSpeed As Label
    Friend WithEvents btnClear As Button
End Class
