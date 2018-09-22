<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAskLevelDifficultyReadWords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAskLevelDifficultyReadWords))
        Me.grpLevel = New System.Windows.Forms.GroupBox()
        Me.rdoLevel3 = New System.Windows.Forms.RadioButton()
        Me.rdoLevel2 = New System.Windows.Forms.RadioButton()
        Me.rdoLevel1 = New System.Windows.Forms.RadioButton()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.lblLevelDifficulty = New System.Windows.Forms.Label()
        Me.mnuLevelDifficultyReadW = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblChooseLevelTitle = New System.Windows.Forms.Label()
        Me.grpLevel.SuspendLayout()
        Me.mnuLevelDifficultyReadW.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLevel
        '
        Me.grpLevel.Controls.Add(Me.rdoLevel3)
        Me.grpLevel.Controls.Add(Me.rdoLevel2)
        Me.grpLevel.Controls.Add(Me.rdoLevel1)
        Me.grpLevel.Location = New System.Drawing.Point(28, 236)
        Me.grpLevel.Name = "grpLevel"
        Me.grpLevel.Size = New System.Drawing.Size(708, 100)
        Me.grpLevel.TabIndex = 1
        Me.grpLevel.TabStop = False
        '
        'rdoLevel3
        '
        Me.rdoLevel3.AutoSize = True
        Me.rdoLevel3.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLevel3.Location = New System.Drawing.Point(576, 36)
        Me.rdoLevel3.Name = "rdoLevel3"
        Me.rdoLevel3.Size = New System.Drawing.Size(102, 29)
        Me.rdoLevel3.TabIndex = 54
        Me.rdoLevel3.TabStop = True
        Me.rdoLevel3.Text = "Level 3"
        Me.rdoLevel3.UseVisualStyleBackColor = True
        '
        'rdoLevel2
        '
        Me.rdoLevel2.AutoSize = True
        Me.rdoLevel2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLevel2.Location = New System.Drawing.Point(305, 36)
        Me.rdoLevel2.Name = "rdoLevel2"
        Me.rdoLevel2.Size = New System.Drawing.Size(102, 29)
        Me.rdoLevel2.TabIndex = 53
        Me.rdoLevel2.TabStop = True
        Me.rdoLevel2.Text = "Level 2"
        Me.rdoLevel2.UseVisualStyleBackColor = True
        '
        'rdoLevel1
        '
        Me.rdoLevel1.AutoSize = True
        Me.rdoLevel1.Checked = True
        Me.rdoLevel1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLevel1.Location = New System.Drawing.Point(15, 36)
        Me.rdoLevel1.Name = "rdoLevel1"
        Me.rdoLevel1.Size = New System.Drawing.Size(102, 29)
        Me.rdoLevel1.TabIndex = 1
        Me.rdoLevel1.TabStop = True
        Me.rdoLevel1.Text = "Level 1"
        Me.rdoLevel1.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(257, 410)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(226, 60)
        Me.cmdNext.TabIndex = 2
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'lblLevelDifficulty
        '
        Me.lblLevelDifficulty.AutoSize = True
        Me.lblLevelDifficulty.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelDifficulty.Location = New System.Drawing.Point(204, 51)
        Me.lblLevelDifficulty.Name = "lblLevelDifficulty"
        Me.lblLevelDifficulty.Size = New System.Drawing.Size(364, 48)
        Me.lblLevelDifficulty.TabIndex = 59
        Me.lblLevelDifficulty.Text = "Level Difficulty"
        '
        'mnuLevelDifficultyReadW
        '
        Me.mnuLevelDifficultyReadW.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuLevelDifficultyReadW.Location = New System.Drawing.Point(0, 0)
        Me.mnuLevelDifficultyReadW.Name = "mnuLevelDifficultyReadW"
        Me.mnuLevelDifficultyReadW.Size = New System.Drawing.Size(764, 24)
        Me.mnuLevelDifficultyReadW.TabIndex = 63
        Me.mnuLevelDifficultyReadW.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.MainMenuToolStripMenuItem.Text = "&Main Menu"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'lblChooseLevelTitle
        '
        Me.lblChooseLevelTitle.AutoSize = True
        Me.lblChooseLevelTitle.BackColor = System.Drawing.Color.White
        Me.lblChooseLevelTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseLevelTitle.Location = New System.Drawing.Point(157, 166)
        Me.lblChooseLevelTitle.Name = "lblChooseLevelTitle"
        Me.lblChooseLevelTitle.Size = New System.Drawing.Size(449, 29)
        Me.lblChooseLevelTitle.TabIndex = 61
        Me.lblChooseLevelTitle.Text = "Please choose one of the three levels"
        '
        'frmAskLevelDifficultyReadWords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpLevel)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.lblChooseLevelTitle)
        Me.Controls.Add(Me.lblLevelDifficulty)
        Me.Controls.Add(Me.mnuLevelDifficultyReadW)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuLevelDifficultyReadW
        Me.Name = "frmAskLevelDifficultyReadWords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Which Level?"
        Me.grpLevel.ResumeLayout(False)
        Me.grpLevel.PerformLayout()
        Me.mnuLevelDifficultyReadW.ResumeLayout(False)
        Me.mnuLevelDifficultyReadW.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpLevel As System.Windows.Forms.GroupBox
    Friend WithEvents rdoLevel3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLevel2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLevel1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents lblLevelDifficulty As System.Windows.Forms.Label
    Friend WithEvents mnuLevelDifficultyReadW As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblChooseLevelTitle As System.Windows.Forms.Label
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
