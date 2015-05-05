<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.dockSplash = New System.Windows.Forms.PictureBox()
        Me.splashUpdate = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dockSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dockSplash
        '
        Me.dockSplash.BackColor = System.Drawing.Color.Navy
        Me.dockSplash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dockSplash.Location = New System.Drawing.Point(0, 0)
        Me.dockSplash.Name = "dockSplash"
        Me.dockSplash.Size = New System.Drawing.Size(600, 400)
        Me.dockSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dockSplash.TabIndex = 0
        Me.dockSplash.TabStop = False
        '
        'splashUpdate
        '
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.dockSplash)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.Text = "Level Image"
        Me.TopMost = True
        CType(Me.dockSplash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dockSplash As System.Windows.Forms.PictureBox
    Friend WithEvents splashUpdate As System.Windows.Forms.Timer
End Class
