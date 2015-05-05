<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.lblenemyLevel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblenemyhealth = New System.Windows.Forms.Label()
        Me.lblEnemyName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.strifeStrife = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblenemyLevel
        '
        Me.lblenemyLevel.AutoSize = True
        Me.lblenemyLevel.Location = New System.Drawing.Point(85, 63)
        Me.lblenemyLevel.Name = "lblenemyLevel"
        Me.lblenemyLevel.Size = New System.Drawing.Size(71, 13)
        Me.lblenemyLevel.TabIndex = 0
        Me.lblenemyLevel.Tag = "Enemy Level:"
        Me.lblenemyLevel.Text = "Enemy Level:"
        '
        'Timer1
        '
        '
        'lblenemyhealth
        '
        Me.lblenemyhealth.AutoSize = True
        Me.lblenemyhealth.Location = New System.Drawing.Point(85, 87)
        Me.lblenemyhealth.Name = "lblenemyhealth"
        Me.lblenemyhealth.Size = New System.Drawing.Size(74, 13)
        Me.lblenemyhealth.TabIndex = 1
        Me.lblenemyhealth.Tag = "Enemy health:"
        Me.lblenemyhealth.Text = "Enemy health:"
        '
        'lblEnemyName
        '
        Me.lblEnemyName.AutoSize = True
        Me.lblEnemyName.Location = New System.Drawing.Point(287, 136)
        Me.lblEnemyName.Name = "lblEnemyName"
        Me.lblEnemyName.Size = New System.Drawing.Size(73, 13)
        Me.lblEnemyName.TabIndex = 2
        Me.lblEnemyName.Tag = "Enemy Name: "
        Me.lblEnemyName.Text = "Enemy Name:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.strifeStrife)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 43)
        Me.Panel1.TabIndex = 5
        '
        'strifeStrife
        '
        Me.strifeStrife.Location = New System.Drawing.Point(12, 6)
        Me.strifeStrife.Name = "strifeStrife"
        Me.strifeStrife.Size = New System.Drawing.Size(78, 34)
        Me.strifeStrife.TabIndex = 0
        Me.strifeStrife.Text = "Strife!"
        Me.strifeStrife.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.dot_TEXT_game.My.Resources.Resources.zombie1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(264, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 115)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 286)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblEnemyName)
        Me.Controls.Add(Me.lblenemyhealth)
        Me.Controls.Add(Me.lblenemyLevel)
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.Text = "STRIFE!"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblenemyLevel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblenemyhealth As System.Windows.Forms.Label
    Friend WithEvents lblEnemyName As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents strifeStrife As System.Windows.Forms.Button
End Class
