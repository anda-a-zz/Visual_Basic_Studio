<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAskLevelDifficultyLostLetter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAskLevelDifficultyLostLetter))
        Me.lblLostLetter = New System.Windows.Forms.Label()
        Me.mnuLostLetter = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpDifficulty = New System.Windows.Forms.GroupBox()
        Me.rdoLevel3 = New System.Windows.Forms.RadioButton()
        Me.rdoLevel1 = New System.Windows.Forms.RadioButton()
        Me.rdoLevel2 = New System.Windows.Forms.RadioButton()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblLostProceed = New System.Windows.Forms.Label()
        Me.cmdLostNext = New System.Windows.Forms.Button()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.mnuLostLetter.SuspendLayout()
        Me.grpDifficulty.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLostLetter
        '
        Me.lblLostLetter.AutoSize = True
        Me.lblLostLetter.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLostLetter.Location = New System.Drawing.Point(240, 53)
        Me.lblLostLetter.Name = "lblLostLetter"
        Me.lblLostLetter.Size = New System.Drawing.Size(272, 48)
        Me.lblLostLetter.TabIndex = 0
        Me.lblLostLetter.Text = "Lost Letter"
        '
        'mnuLostLetter
        '
        Me.mnuLostLetter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuLostLetter.Location = New System.Drawing.Point(0, 0)
        Me.mnuLostLetter.Name = "mnuLostLetter"
        Me.mnuLostLetter.Size = New System.Drawing.Size(764, 24)
        Me.mnuLostLetter.TabIndex = 1
        Me.mnuLostLetter.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToMainMenuToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackToMainMenuToolStripMenuItem.Text = "&Main Menu"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InstructionsToolStripMenuItem.Text = "&Instructions"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'grpDifficulty
        '
        Me.grpDifficulty.BackColor = System.Drawing.Color.White
        Me.grpDifficulty.Controls.Add(Me.rdoLevel3)
        Me.grpDifficulty.Controls.Add(Me.rdoLevel1)
        Me.grpDifficulty.Controls.Add(Me.rdoLevel2)
        Me.grpDifficulty.Controls.Add(Me.ShapeContainer2)
        Me.grpDifficulty.Location = New System.Drawing.Point(98, 166)
        Me.grpDifficulty.Name = "grpDifficulty"
        Me.grpDifficulty.Size = New System.Drawing.Size(558, 89)
        Me.grpDifficulty.TabIndex = 2
        Me.grpDifficulty.TabStop = False
        '
        'rdoLevel3
        '
        Me.rdoLevel3.AutoSize = True
        Me.rdoLevel3.BackColor = System.Drawing.Color.Pink
        Me.rdoLevel3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLevel3.Location = New System.Drawing.Point(409, 37)
        Me.rdoLevel3.Name = "rdoLevel3"
        Me.rdoLevel3.Size = New System.Drawing.Size(97, 28)
        Me.rdoLevel3.TabIndex = 5
        Me.rdoLevel3.TabStop = True
        Me.rdoLevel3.Text = "Level 3"
        Me.rdoLevel3.UseVisualStyleBackColor = False
        '
        'rdoLevel1
        '
        Me.rdoLevel1.AutoSize = True
        Me.rdoLevel1.BackColor = System.Drawing.Color.Pink
        Me.rdoLevel1.Checked = True
        Me.rdoLevel1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLevel1.Location = New System.Drawing.Point(62, 36)
        Me.rdoLevel1.Name = "rdoLevel1"
        Me.rdoLevel1.Size = New System.Drawing.Size(97, 28)
        Me.rdoLevel1.TabIndex = 3
        Me.rdoLevel1.TabStop = True
        Me.rdoLevel1.Text = "Level 1"
        Me.rdoLevel1.UseVisualStyleBackColor = False
        '
        'rdoLevel2
        '
        Me.rdoLevel2.AutoSize = True
        Me.rdoLevel2.BackColor = System.Drawing.Color.Pink
        Me.rdoLevel2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLevel2.Location = New System.Drawing.Point(231, 37)
        Me.rdoLevel2.Name = "rdoLevel2"
        Me.rdoLevel2.Size = New System.Drawing.Size(97, 28)
        Me.rdoLevel2.TabIndex = 4
        Me.rdoLevel2.TabStop = True
        Me.rdoLevel2.Text = "Level 2"
        Me.rdoLevel2.UseVisualStyleBackColor = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(552, 70)
        Me.ShapeContainer2.TabIndex = 6
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape2.FillColor = System.Drawing.Color.Pink
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(-2, -11)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(555, 80)
        '
        'lblLostProceed
        '
        Me.lblLostProceed.AllowDrop = True
        Me.lblLostProceed.AutoSize = True
        Me.lblLostProceed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLostProceed.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLostProceed.Location = New System.Drawing.Point(288, 344)
        Me.lblLostProceed.Name = "lblLostProceed"
        Me.lblLostProceed.Size = New System.Drawing.Size(158, 24)
        Me.lblLostProceed.TabIndex = 3
        Me.lblLostProceed.Text = "Click to proceed"
        '
        'cmdLostNext
        '
        Me.cmdLostNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdLostNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLostNext.Location = New System.Drawing.Point(305, 394)
        Me.cmdLostNext.Name = "cmdLostNext"
        Me.cmdLostNext.Size = New System.Drawing.Size(119, 35)
        Me.cmdLostNext.TabIndex = 6
        Me.cmdLostNext.Text = "Next"
        Me.cmdLostNext.UseVisualStyleBackColor = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape1.FillColor = System.Drawing.Color.Pink
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(260, 326)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(213, 115)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(764, 562)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty.Location = New System.Drawing.Point(95, 158)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(110, 24)
        Me.lblDifficulty.TabIndex = 6
        Me.lblDifficulty.Text = "Difficulty:"
        '
        'frmAskLevelDifficultyLostLetter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.cmdLostNext)
        Me.Controls.Add(Me.lblLostProceed)
        Me.Controls.Add(Me.grpDifficulty)
        Me.Controls.Add(Me.lblLostLetter)
        Me.Controls.Add(Me.mnuLostLetter)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuLostLetter
        Me.Name = "frmAskLevelDifficultyLostLetter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lost Letter"
        Me.mnuLostLetter.ResumeLayout(False)
        Me.mnuLostLetter.PerformLayout()
        Me.grpDifficulty.ResumeLayout(False)
        Me.grpDifficulty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLostLetter As System.Windows.Forms.Label
    Friend WithEvents mnuLostLetter As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpDifficulty As System.Windows.Forms.GroupBox
    Friend WithEvents rdoLevel3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLevel1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLevel2 As System.Windows.Forms.RadioButton
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblLostProceed As System.Windows.Forms.Label
    Friend WithEvents cmdLostNext As System.Windows.Forms.Button
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lblDifficulty As System.Windows.Forms.Label
    Friend WithEvents BackToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
