<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblSelectRock = New System.Windows.Forms.Label()
        Me.lblOtherSongs = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnOther = New System.Windows.Forms.Button()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSelectRock
        '
        Me.lblSelectRock.AutoSize = True
        Me.lblSelectRock.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblSelectRock.Location = New System.Drawing.Point(94, 566)
        Me.lblSelectRock.Name = "lblSelectRock"
        Me.lblSelectRock.Size = New System.Drawing.Size(724, 54)
        Me.lblSelectRock.TabIndex = 3
        Me.lblSelectRock.Text = "SELECT YOUR ROCK ANTHEM!"
        '
        'lblOtherSongs
        '
        Me.lblOtherSongs.AutoSize = True
        Me.lblOtherSongs.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblOtherSongs.Location = New System.Drawing.Point(878, 566)
        Me.lblOtherSongs.Name = "lblOtherSongs"
        Me.lblOtherSongs.Size = New System.Drawing.Size(613, 54)
        Me.lblOtherSongs.TabIndex = 4
        Me.lblOtherSongs.Text = "OTHER JUKE BOX SONGS"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.lblWelcome.Location = New System.Drawing.Point(517, 71)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(624, 59)
        Me.lblWelcome.TabIndex = 5
        Me.lblWelcome.Text = "Welcome to VB Juke Box!"
        '
        'btnOther
        '
        Me.btnOther.BackgroundImage = Global.VBtask4.My.Resources.Resources.rock2
        Me.btnOther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOther.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOther.Location = New System.Drawing.Point(962, 166)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.Size = New System.Drawing.Size(428, 374)
        Me.btnOther.TabIndex = 2
        Me.btnOther.UseVisualStyleBackColor = True
        '
        'btnRock
        '
        Me.btnRock.BackgroundImage = Global.VBtask4.My.Resources.Resources.rock1
        Me.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRock.Location = New System.Drawing.Point(276, 166)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(428, 374)
        Me.btnRock.TabIndex = 1
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1693, 919)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblOtherSongs)
        Me.Controls.Add(Me.lblSelectRock)
        Me.Controls.Add(Me.btnOther)
        Me.Controls.Add(Me.btnRock)
        Me.Name = "Form1"
        Me.Text = "Welcome to VB Juke Box!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRock As Button
    Friend WithEvents btnOther As Button
    Friend WithEvents lblSelectRock As Label
    Friend WithEvents lblOtherSongs As Label
    Friend WithEvents lblWelcome As Label
End Class
