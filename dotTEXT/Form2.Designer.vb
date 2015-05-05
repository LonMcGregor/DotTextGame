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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.gameNotes = New System.Windows.Forms.TextBox()
        Me.saveNotes = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.resetNotes = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gameNotes
        '
        Me.gameNotes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gameNotes.Location = New System.Drawing.Point(0, 20)
        Me.gameNotes.Multiline = True
        Me.gameNotes.Name = "gameNotes"
        Me.gameNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gameNotes.Size = New System.Drawing.Size(362, 601)
        Me.gameNotes.TabIndex = 0
        '
        'saveNotes
        '
        Me.saveNotes.BackColor = System.Drawing.Color.Lavender
        Me.saveNotes.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.saveNotes.Location = New System.Drawing.Point(3, 0)
        Me.saveNotes.Name = "saveNotes"
        Me.saveNotes.Size = New System.Drawing.Size(171, 24)
        Me.saveNotes.TabIndex = 0
        Me.saveNotes.Text = "Save Notes"
        Me.saveNotes.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.resetNotes)
        Me.Panel1.Controls.Add(Me.saveNotes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 25)
        Me.Panel1.TabIndex = 1
        '
        'resetNotes
        '
        Me.resetNotes.BackColor = System.Drawing.Color.Lavender
        Me.resetNotes.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.resetNotes.Location = New System.Drawing.Point(180, 0)
        Me.resetNotes.Name = "resetNotes"
        Me.resetNotes.Size = New System.Drawing.Size(179, 24)
        Me.resetNotes.TabIndex = 1
        Me.resetNotes.Text = "Reset Notes"
        Me.resetNotes.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(362, 621)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gameNotes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Opacity = 0.8R
        Me.ShowInTaskbar = False
        Me.Text = "Game Notes"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gameNotes As System.Windows.Forms.TextBox
    Friend WithEvents saveNotes As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents resetNotes As System.Windows.Forms.Button
End Class
