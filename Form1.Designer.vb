<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Window
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Window))
        Me.cmdCommand = New System.Windows.Forms.Button()
        Me.txtCommand = New System.Windows.Forms.TextBox()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.lblHealthCap = New System.Windows.Forms.Label()
        Me.journal = New System.Windows.Forms.TextBox()
        Me.lblSplash = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.itemDesc = New System.Windows.Forms.Label()
        Me.healthTime = New System.Windows.Forms.Timer(Me.components)
        Me.playTime = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.itemKey1 = New System.Windows.Forms.PictureBox()
        Me.itemSword = New System.Windows.Forms.PictureBox()
        Me.itemSplashDock = New System.Windows.Forms.PictureBox()
        Me.itemNotes = New System.Windows.Forms.PictureBox()
        Me.itemLoad = New System.Windows.Forms.PictureBox()
        Me.itemSave = New System.Windows.Forms.PictureBox()
        Me.itemHelp = New System.Windows.Forms.PictureBox()
        Me.itemClock = New System.Windows.Forms.PictureBox()
        Me.itemReset = New System.Windows.Forms.PictureBox()
        Me.Splash = New System.Windows.Forms.PictureBox()
        Me.debugEnemyLevelTime = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.itemKey1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemSword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemSplashDock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemClock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Splash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCommand
        '
        Me.cmdCommand.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.cmdCommand.Enabled = False
        Me.cmdCommand.Location = New System.Drawing.Point(3, 69)
        Me.cmdCommand.Name = "cmdCommand"
        Me.cmdCommand.Size = New System.Drawing.Size(49, 28)
        Me.cmdCommand.TabIndex = 2
        Me.cmdCommand.Text = "==>"
        Me.cmdCommand.UseVisualStyleBackColor = True
        '
        'txtCommand
        '
        Me.txtCommand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCommand.Location = New System.Drawing.Point(53, 74)
        Me.txtCommand.MaxLength = 32
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.ReadOnly = True
        Me.txtCommand.Size = New System.Drawing.Size(555, 20)
        Me.txtCommand.TabIndex = 3
        Me.txtCommand.Text = "ENTER COMMAND"
        '
        'lblInventory
        '
        Me.lblInventory.AutoSize = True
        Me.lblInventory.BackColor = System.Drawing.Color.Navy
        Me.lblInventory.Cursor = System.Windows.Forms.Cursors.No
        Me.lblInventory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblInventory.Location = New System.Drawing.Point(3, 10)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(33, 13)
        Me.lblInventory.TabIndex = 4
        Me.lblInventory.Text = "Tools"
        '
        'lblHealthCap
        '
        Me.lblHealthCap.AutoSize = True
        Me.lblHealthCap.BackColor = System.Drawing.Color.Navy
        Me.lblHealthCap.Cursor = System.Windows.Forms.Cursors.No
        Me.lblHealthCap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHealthCap.Location = New System.Drawing.Point(455, 10)
        Me.lblHealthCap.Name = "lblHealthCap"
        Me.lblHealthCap.Size = New System.Drawing.Size(38, 13)
        Me.lblHealthCap.TabIndex = 6
        Me.lblHealthCap.Text = "Health"
        '
        'journal
        '
        Me.journal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.journal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.journal.Dock = System.Windows.Forms.DockStyle.Right
        Me.journal.ForeColor = System.Drawing.SystemColors.Info
        Me.journal.Location = New System.Drawing.Point(614, 0)
        Me.journal.Multiline = True
        Me.journal.Name = "journal"
        Me.journal.ReadOnly = True
        Me.journal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.journal.Size = New System.Drawing.Size(212, 512)
        Me.journal.TabIndex = 7
        Me.journal.Text = "Press the reset button in the inventory to start"
        '
        'lblSplash
        '
        Me.lblSplash.AutoSize = True
        Me.lblSplash.BackColor = System.Drawing.Color.Navy
        Me.lblSplash.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.lblSplash.Font = New System.Drawing.Font("MS Reference Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSplash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSplash.Location = New System.Drawing.Point(12, 268)
        Me.lblSplash.Name = "lblSplash"
        Me.lblSplash.Size = New System.Drawing.Size(296, 118)
        Me.lblSplash.TabIndex = 8
        Me.lblSplash.Text = ".Text"
        '
        'lblHealth
        '
        Me.lblHealth.AutoSize = True
        Me.lblHealth.BackColor = System.Drawing.Color.Navy
        Me.lblHealth.Cursor = System.Windows.Forms.Cursors.No
        Me.lblHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHealth.Location = New System.Drawing.Point(463, 26)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(81, 42)
        Me.lblHealth.TabIndex = 10
        Me.lblHealth.Text = "000"
        '
        'itemDesc
        '
        Me.itemDesc.AutoSize = True
        Me.itemDesc.Cursor = System.Windows.Forms.Cursors.No
        Me.itemDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.itemDesc.Location = New System.Drawing.Point(109, 10)
        Me.itemDesc.Name = "itemDesc"
        Me.itemDesc.Size = New System.Drawing.Size(97, 13)
        Me.itemDesc.TabIndex = 11
        Me.itemDesc.Text = "Hover over an item"
        '
        'healthTime
        '
        Me.healthTime.Interval = 5
        '
        'playTime
        '
        Me.playTime.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.itemKey1)
        Me.Panel1.Controls.Add(Me.itemSword)
        Me.Panel1.Controls.Add(Me.itemSplashDock)
        Me.Panel1.Controls.Add(Me.itemNotes)
        Me.Panel1.Controls.Add(Me.itemLoad)
        Me.Panel1.Controls.Add(Me.itemSave)
        Me.Panel1.Controls.Add(Me.itemHelp)
        Me.Panel1.Controls.Add(Me.itemClock)
        Me.Panel1.Controls.Add(Me.itemDesc)
        Me.Panel1.Controls.Add(Me.cmdCommand)
        Me.Panel1.Controls.Add(Me.lblInventory)
        Me.Panel1.Controls.Add(Me.lblHealth)
        Me.Panel1.Controls.Add(Me.itemReset)
        Me.Panel1.Controls.Add(Me.lblHealthCap)
        Me.Panel1.Controls.Add(Me.txtCommand)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.No
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 404)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 108)
        Me.Panel1.TabIndex = 14
        '
        'itemKey1
        '
        Me.itemKey1.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.itemKey1.Enabled = False
        Me.itemKey1.Image = Global.dot_TEXT_game.My.Resources.Resources.key1
        Me.itemKey1.Location = New System.Drawing.Point(354, 26)
        Me.itemKey1.Name = "itemKey1"
        Me.itemKey1.Size = New System.Drawing.Size(32, 32)
        Me.itemKey1.TabIndex = 19
        Me.itemKey1.TabStop = False
        Me.itemKey1.Tag = "Key: a key marked key1"
        Me.itemKey1.Visible = False
        '
        'itemSword
        '
        Me.itemSword.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.itemSword.Enabled = False
        Me.itemSword.Image = Global.dot_TEXT_game.My.Resources.Resources.sword
        Me.itemSword.Location = New System.Drawing.Point(316, 26)
        Me.itemSword.Name = "itemSword"
        Me.itemSword.Size = New System.Drawing.Size(32, 32)
        Me.itemSword.TabIndex = 18
        Me.itemSword.TabStop = False
        Me.itemSword.Tag = "Sword: An iron sword"
        Me.itemSword.Visible = False
        '
        'itemSplashDock
        '
        Me.itemSplashDock.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.itemSplashDock.Enabled = False
        Me.itemSplashDock.Image = Global.dot_TEXT_game.My.Resources.Resources.itemundockimage
        Me.itemSplashDock.Location = New System.Drawing.Point(230, 26)
        Me.itemSplashDock.Name = "itemSplashDock"
        Me.itemSplashDock.Size = New System.Drawing.Size(32, 32)
        Me.itemSplashDock.TabIndex = 17
        Me.itemSplashDock.TabStop = False
        Me.itemSplashDock.Tag = "Toggle Image Docking"
        '
        'itemNotes
        '
        Me.itemNotes.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.itemNotes.Enabled = False
        Me.itemNotes.Image = Global.dot_TEXT_game.My.Resources.Resources.notes
        Me.itemNotes.Location = New System.Drawing.Point(192, 26)
        Me.itemNotes.Name = "itemNotes"
        Me.itemNotes.Size = New System.Drawing.Size(32, 32)
        Me.itemNotes.TabIndex = 16
        Me.itemNotes.TabStop = False
        Me.itemNotes.Tag = "Notes: toggle notepad"
        '
        'itemLoad
        '
        Me.itemLoad.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.itemLoad.Image = Global.dot_TEXT_game.My.Resources.Resources.itemload
        Me.itemLoad.Location = New System.Drawing.Point(154, 26)
        Me.itemLoad.Name = "itemLoad"
        Me.itemLoad.Size = New System.Drawing.Size(32, 32)
        Me.itemLoad.TabIndex = 15
        Me.itemLoad.TabStop = False
        Me.itemLoad.Tag = "Load: Loads the saved game"
        '
        'itemSave
        '
        Me.itemSave.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.itemSave.Image = Global.dot_TEXT_game.My.Resources.Resources.itemSave
        Me.itemSave.Location = New System.Drawing.Point(116, 26)
        Me.itemSave.Name = "itemSave"
        Me.itemSave.Size = New System.Drawing.Size(32, 32)
        Me.itemSave.TabIndex = 14
        Me.itemSave.TabStop = False
        Me.itemSave.Tag = "Save: Will save your game"
        '
        'itemHelp
        '
        Me.itemHelp.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.itemHelp.Enabled = False
        Me.itemHelp.Image = Global.dot_TEXT_game.My.Resources.Resources.helpsel
        Me.itemHelp.Location = New System.Drawing.Point(78, 26)
        Me.itemHelp.Name = "itemHelp"
        Me.itemHelp.Size = New System.Drawing.Size(32, 32)
        Me.itemHelp.TabIndex = 13
        Me.itemHelp.TabStop = False
        Me.itemHelp.Tag = "Help: "
        '
        'itemClock
        '
        Me.itemClock.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.itemClock.Enabled = False
        Me.itemClock.Image = Global.dot_TEXT_game.My.Resources.Resources.clock
        Me.itemClock.Location = New System.Drawing.Point(40, 26)
        Me.itemClock.Name = "itemClock"
        Me.itemClock.Size = New System.Drawing.Size(32, 32)
        Me.itemClock.TabIndex = 12
        Me.itemClock.TabStop = False
        Me.itemClock.Tag = "Clock: The time is"
        '
        'itemReset
        '
        Me.itemReset.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.itemReset.Image = Global.dot_TEXT_game.My.Resources.Resources.reset
        Me.itemReset.Location = New System.Drawing.Point(2, 26)
        Me.itemReset.Name = "itemReset"
        Me.itemReset.Size = New System.Drawing.Size(32, 32)
        Me.itemReset.TabIndex = 9
        Me.itemReset.TabStop = False
        Me.itemReset.Tag = "Reset: This item will reset the game"
        '
        'Splash
        '
        Me.Splash.BackColor = System.Drawing.Color.Navy
        Me.Splash.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Splash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Splash.InitialImage = Nothing
        Me.Splash.Location = New System.Drawing.Point(0, 0)
        Me.Splash.Name = "Splash"
        Me.Splash.Size = New System.Drawing.Size(826, 512)
        Me.Splash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Splash.TabIndex = 0
        Me.Splash.TabStop = False
        '
        'debugEnemyLevelTime
        '
        '
        'Main_Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(826, 512)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblSplash)
        Me.Controls.Add(Me.journal)
        Me.Controls.Add(Me.Splash)
        Me.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main_Window"
        Me.Text = ".text"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.itemKey1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemSword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemSplashDock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemClock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Splash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCommand As System.Windows.Forms.Button
    Friend WithEvents txtCommand As System.Windows.Forms.TextBox
    Friend WithEvents lblInventory As System.Windows.Forms.Label
    Friend WithEvents lblHealthCap As System.Windows.Forms.Label
    Friend WithEvents journal As System.Windows.Forms.TextBox
    Friend WithEvents Splash As System.Windows.Forms.PictureBox
    Friend WithEvents lblSplash As System.Windows.Forms.Label
    Friend WithEvents itemReset As System.Windows.Forms.PictureBox
    Friend WithEvents lblHealth As System.Windows.Forms.Label
    Friend WithEvents itemDesc As System.Windows.Forms.Label
    Friend WithEvents itemClock As System.Windows.Forms.PictureBox
    Friend WithEvents itemHelp As System.Windows.Forms.PictureBox
    Friend WithEvents healthTime As System.Windows.Forms.Timer
    Friend WithEvents playTime As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents itemSave As System.Windows.Forms.PictureBox
    Friend WithEvents itemLoad As System.Windows.Forms.PictureBox
    Friend WithEvents itemNotes As System.Windows.Forms.PictureBox
    Friend WithEvents itemSplashDock As System.Windows.Forms.PictureBox
    Friend WithEvents itemSword As System.Windows.Forms.PictureBox
    Friend WithEvents itemKey1 As System.Windows.Forms.PictureBox
    Friend WithEvents debugEnemyLevelTime As System.Windows.Forms.Timer

End Class
