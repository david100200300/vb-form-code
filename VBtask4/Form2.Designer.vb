<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnSong1 = New System.Windows.Forms.Button()
        Me.btnSong2 = New System.Windows.Forms.Button()
        Me.btnSong4 = New System.Windows.Forms.Button()
        Me.btnSong3 = New System.Windows.Forms.Button()
        Me.lblYourAnthem = New System.Windows.Forms.Label()
        Me.lblAnthem = New System.Windows.Forms.Label()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSong1
        '
        Me.btnSong1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSong1.Location = New System.Drawing.Point(168, 126)
        Me.btnSong1.Name = "btnSong1"
        Me.btnSong1.Size = New System.Drawing.Size(230, 151)
        Me.btnSong1.TabIndex = 0
        Me.btnSong1.Text = "Gangnam Style"
        Me.btnSong1.UseVisualStyleBackColor = True
        '
        'btnSong2
        '
        Me.btnSong2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSong2.Location = New System.Drawing.Point(422, 126)
        Me.btnSong2.Name = "btnSong2"
        Me.btnSong2.Size = New System.Drawing.Size(230, 151)
        Me.btnSong2.TabIndex = 1
        Me.btnSong2.Text = "Gentleman"
        Me.btnSong2.UseVisualStyleBackColor = True
        '
        'btnSong4
        '
        Me.btnSong4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSong4.Location = New System.Drawing.Point(936, 126)
        Me.btnSong4.Name = "btnSong4"
        Me.btnSong4.Size = New System.Drawing.Size(230, 151)
        Me.btnSong4.TabIndex = 3
        Me.btnSong4.Text = "Unregistered Hypercam 2"
        Me.btnSong4.UseVisualStyleBackColor = True
        '
        'btnSong3
        '
        Me.btnSong3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSong3.Location = New System.Drawing.Point(682, 126)
        Me.btnSong3.Name = "btnSong3"
        Me.btnSong3.Size = New System.Drawing.Size(230, 151)
        Me.btnSong3.TabIndex = 2
        Me.btnSong3.Text = "Party Rock is in the house"
        Me.btnSong3.UseVisualStyleBackColor = True
        '
        'lblYourAnthem
        '
        Me.lblYourAnthem.AutoSize = True
        Me.lblYourAnthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.lblYourAnthem.Location = New System.Drawing.Point(339, 354)
        Me.lblYourAnthem.Name = "lblYourAnthem"
        Me.lblYourAnthem.Size = New System.Drawing.Size(653, 59)
        Me.lblYourAnthem.TabIndex = 4
        Me.lblYourAnthem.Text = "YOUR ROCK ANTHEM IS:"
        '
        'lblAnthem
        '
        Me.lblAnthem.AutoSize = True
        Me.lblAnthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblAnthem.Location = New System.Drawing.Point(458, 439)
        Me.lblAnthem.Name = "lblAnthem"
        Me.lblAnthem.Size = New System.Drawing.Size(427, 39)
        Me.lblAnthem.TabIndex = 5
        Me.lblAnthem.Text = "YOU NEED TO PICK ONE"
        Me.lblAnthem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblSelect.Location = New System.Drawing.Point(415, 39)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(524, 39)
        Me.lblSelect.TabIndex = 6
        Me.lblSelect.Text = "SELECT YOUR ROCK ANTHEM"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1394, 727)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblAnthem)
        Me.Controls.Add(Me.lblYourAnthem)
        Me.Controls.Add(Me.btnSong4)
        Me.Controls.Add(Me.btnSong3)
        Me.Controls.Add(Me.btnSong2)
        Me.Controls.Add(Me.btnSong1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSong1 As Button
    Friend WithEvents btnSong2 As Button
    Friend WithEvents btnSong4 As Button
    Friend WithEvents btnSong3 As Button
    Friend WithEvents lblYourAnthem As Label
    Friend WithEvents lblSelect As Label
    Private WithEvents lblAnthem As Label
End Class
