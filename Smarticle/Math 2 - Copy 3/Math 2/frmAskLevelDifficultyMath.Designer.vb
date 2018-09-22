<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAskLevelDifficultyMath
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAskLevelDifficultyMath))
        Me.mnuLevelDifficultyMathO = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblLevelDifficulty = New System.Windows.Forms.Label()
        Me.lblChooseMathOTitle = New System.Windows.Forms.Label()
        Me.rdoAddition = New System.Windows.Forms.RadioButton()
        Me.rdoMultiplication = New System.Windows.Forms.RadioButton()
        Me.lblChooseLevelTitle = New System.Windows.Forms.Label()
        Me.rdoLevel2 = New System.Windows.Forms.RadioButton()
        Me.rdoLevel1 = New System.Windows.Forms.RadioButton()
        Me.rdoLevel3 = New System.Windows.Forms.RadioButton()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.grpMathOp = New System.Windows.Forms.GroupBox()
        Me.rdoDivision = New System.Windows.Forms.RadioButton()
        Me.rdoSubtraction = New System.Windows.Forms.RadioButton()
        Me.grpLevel = New System.Windows.Forms.GroupBox()
        Me.mnuLevelDifficultyMathO.SuspendLayout()
        Me.grpMathOp.SuspendLayout()
        Me.grpLevel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuLevelDifficultyMathO
        '
        Me.mnuLevelDifficultyMathO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuLevelDifficultyMathO.Location = New System.Drawing.Point(0, 0)
        Me.mnuLevelDifficultyMathO.Name = "mnuLevelDifficultyMathO"
        Me.mnuLevelDifficultyMathO.Size = New System.Drawing.Size(764, 24)
        Me.mnuLevelDifficultyMathO.TabIndex = 0
        Me.mnuLevelDifficultyMathO.Text = "MenuStrip1"
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
        'lblLevelDifficulty
        '
        Me.lblLevelDifficulty.AutoSize = True
        Me.lblLevelDifficulty.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelDifficulty.Location = New System.Drawing.Point(204, 36)
        Me.lblLevelDifficulty.Name = "lblLevelDifficulty"
        Me.lblLevelDifficulty.Size = New System.Drawing.Size(364, 48)
        Me.lblLevelDifficulty.TabIndex = 30
        Me.lblLevelDifficulty.Text = "Level Difficulty"
        '
        'lblChooseMathOTitle
        '
        Me.lblChooseMathOTitle.AutoSize = True
        Me.lblChooseMathOTitle.BackColor = System.Drawing.Color.White
        Me.lblChooseMathOTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseMathOTitle.Location = New System.Drawing.Point(106, 124)
        Me.lblChooseMathOTitle.Name = "lblChooseMathOTitle"
        Me.lblChooseMathOTitle.Size = New System.Drawing.Size(555, 29)
        Me.lblChooseMathOTitle.TabIndex = 48
        Me.lblChooseMathOTitle.Text = "Please choose one of the two math operations"
        '
        'rdoAddition
        '
        Me.rdoAddition.AutoSize = True
        Me.rdoAddition.Checked = True
        Me.rdoAddition.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAddition.Location = New System.Drawing.Point(15, 37)
        Me.rdoAddition.Name = "rdoAddition"
        Me.rdoAddition.Size = New System.Drawing.Size(118, 29)
        Me.rdoAddition.TabIndex = 1
        Me.rdoAddition.TabStop = True
        Me.rdoAddition.Text = "Addition"
        Me.rdoAddition.UseVisualStyleBackColor = True
        '
        'rdoMultiplication
        '
        Me.rdoMultiplication.AutoSize = True
        Me.rdoMultiplication.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMultiplication.Location = New System.Drawing.Point(354, 37)
        Me.rdoMultiplication.Name = "rdoMultiplication"
        Me.rdoMultiplication.Size = New System.Drawing.Size(182, 29)
        Me.rdoMultiplication.TabIndex = 50
        Me.rdoMultiplication.TabStop = True
        Me.rdoMultiplication.Text = "Multiplication "
        Me.rdoMultiplication.UseVisualStyleBackColor = True
        '
        'lblChooseLevelTitle
        '
        Me.lblChooseLevelTitle.AutoSize = True
        Me.lblChooseLevelTitle.BackColor = System.Drawing.Color.White
        Me.lblChooseLevelTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseLevelTitle.Location = New System.Drawing.Point(153, 311)
        Me.lblChooseLevelTitle.Name = "lblChooseLevelTitle"
        Me.lblChooseLevelTitle.Size = New System.Drawing.Size(449, 29)
        Me.lblChooseLevelTitle.TabIndex = 51
        Me.lblChooseLevelTitle.Text = "Please choose one of the three levels"
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
        Me.rdoLevel1.TabIndex = 2
        Me.rdoLevel1.TabStop = True
        Me.rdoLevel1.Text = "Level 1"
        Me.rdoLevel1.UseVisualStyleBackColor = True
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
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(266, 478)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(226, 60)
        Me.cmdNext.TabIndex = 3
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'grpMathOp
        '
        Me.grpMathOp.BackColor = System.Drawing.Color.White
        Me.grpMathOp.Controls.Add(Me.rdoDivision)
        Me.grpMathOp.Controls.Add(Me.rdoSubtraction)
        Me.grpMathOp.Controls.Add(Me.rdoAddition)
        Me.grpMathOp.Controls.Add(Me.rdoMultiplication)
        Me.grpMathOp.Location = New System.Drawing.Point(32, 184)
        Me.grpMathOp.Name = "grpMathOp"
        Me.grpMathOp.Size = New System.Drawing.Size(708, 100)
        Me.grpMathOp.TabIndex = 1
        Me.grpMathOp.TabStop = False
        '
        'rdoDivision
        '
        Me.rdoDivision.AutoSize = True
        Me.rdoDivision.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDivision.Location = New System.Drawing.Point(565, 37)
        Me.rdoDivision.Name = "rdoDivision"
        Me.rdoDivision.Size = New System.Drawing.Size(113, 29)
        Me.rdoDivision.TabIndex = 52
        Me.rdoDivision.TabStop = True
        Me.rdoDivision.Text = "Division"
        Me.rdoDivision.UseVisualStyleBackColor = True
        '
        'rdoSubtraction
        '
        Me.rdoSubtraction.AutoSize = True
        Me.rdoSubtraction.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSubtraction.Location = New System.Drawing.Point(180, 37)
        Me.rdoSubtraction.Name = "rdoSubtraction"
        Me.rdoSubtraction.Size = New System.Drawing.Size(150, 29)
        Me.rdoSubtraction.TabIndex = 51
        Me.rdoSubtraction.TabStop = True
        Me.rdoSubtraction.Text = "Subtraction "
        Me.rdoSubtraction.UseVisualStyleBackColor = True
        '
        'grpLevel
        '
        Me.grpLevel.Controls.Add(Me.rdoLevel3)
        Me.grpLevel.Controls.Add(Me.rdoLevel2)
        Me.grpLevel.Controls.Add(Me.rdoLevel1)
        Me.grpLevel.Location = New System.Drawing.Point(32, 361)
        Me.grpLevel.Name = "grpLevel"
        Me.grpLevel.Size = New System.Drawing.Size(708, 100)
        Me.grpLevel.TabIndex = 2
        Me.grpLevel.TabStop = False
        '
        'frmAskLevelDifficultyMath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpLevel)
        Me.Controls.Add(Me.grpMathOp)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.lblChooseLevelTitle)
        Me.Controls.Add(Me.lblChooseMathOTitle)
        Me.Controls.Add(Me.lblLevelDifficulty)
        Me.Controls.Add(Me.mnuLevelDifficultyMathO)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuLevelDifficultyMathO
        Me.Name = "frmAskLevelDifficultyMath"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Which Level?"
        Me.mnuLevelDifficultyMathO.ResumeLayout(False)
        Me.mnuLevelDifficultyMathO.PerformLayout()
        Me.grpMathOp.ResumeLayout(False)
        Me.grpMathOp.PerformLayout()
        Me.grpLevel.ResumeLayout(False)
        Me.grpLevel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuLevelDifficultyMathO As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblLevelDifficulty As System.Windows.Forms.Label
    Friend WithEvents lblChooseMathOTitle As System.Windows.Forms.Label
    Friend WithEvents rdoAddition As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMultiplication As System.Windows.Forms.RadioButton
    Friend WithEvents lblChooseLevelTitle As System.Windows.Forms.Label
    Friend WithEvents rdoLevel2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLevel1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLevel3 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents grpMathOp As System.Windows.Forms.GroupBox
    Friend WithEvents grpLevel As System.Windows.Forms.GroupBox
    Friend WithEvents rdoDivision As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSubtraction As System.Windows.Forms.RadioButton
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
