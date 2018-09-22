<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLostLetter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLostLetter))
        Me.lblWord = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.mnuLostLetter = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.tmrAnswer = New System.Windows.Forms.Timer(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpAnswerBox = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpWordBox = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblLostLetter = New System.Windows.Forms.Label()
        Me.picAnswer = New System.Windows.Forms.PictureBox()
        Me.lblCountdownNumber = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTotalQNum = New System.Windows.Forms.Label()
        Me.lblOutOf = New System.Windows.Forms.Label()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.lblDiff = New System.Windows.Forms.Label()
        Me.lblCGrade = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.mnuLostLetter.SuspendLayout()
        CType(Me.picAnswer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWord
        '
        Me.lblWord.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWord.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWord.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblWord.Location = New System.Drawing.Point(0, 147)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(764, 65)
        Me.lblWord.TabIndex = 0
        Me.lblWord.Text = "Label1"
        Me.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(274, 359)
        Me.txtAnswer.MaxLength = 1
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(197, 42)
        Me.txtAnswer.TabIndex = 1
        '
        'mnuLostLetter
        '
        Me.mnuLostLetter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuLostLetter.Location = New System.Drawing.Point(0, 0)
        Me.mnuLostLetter.Name = "mnuLostLetter"
        Me.mnuLostLetter.Size = New System.Drawing.Size(764, 24)
        Me.mnuLostLetter.TabIndex = 8
        Me.mnuLostLetter.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.MainMenuToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Restart"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MainMenuToolStripMenuItem.Text = "&Main Menu"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsToolStripMenuItem, Me.AboutToolStripMenuItem1})
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
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdNext.Enabled = False
        Me.cmdNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(287, 421)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(168, 35)
        Me.cmdNext.TabIndex = 2
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'tmrAnswer
        '
        Me.tmrAnswer.Interval = 1000
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1, Me.shpAnswerBox, Me.shpWordBox, Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(764, 562)
        Me.ShapeContainer1.TabIndex = 11
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(519, 278)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(235, 232)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(11, 278)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(219, 234)
        '
        'shpAnswerBox
        '
        Me.shpAnswerBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.shpAnswerBox.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shpAnswerBox.Location = New System.Drawing.Point(238, 278)
        Me.shpAnswerBox.Name = "shpAnswerBox"
        Me.shpAnswerBox.Size = New System.Drawing.Size(273, 232)
        '
        'shpWordBox
        '
        Me.shpWordBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.shpWordBox.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shpWordBox.Location = New System.Drawing.Point(-7, 115)
        Me.shpWordBox.Name = "shpWordBox"
        Me.shpWordBox.Size = New System.Drawing.Size(776, 120)
        '
        'OvalShape1
        '
        Me.OvalShape1.Location = New System.Drawing.Point(562, 337)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(163, 154)
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(604, 281)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(64, 24)
        Me.lblTime.TabIndex = 12
        Me.lblTime.Text = "Time:"
        '
        'lblLostLetter
        '
        Me.lblLostLetter.AutoSize = True
        Me.lblLostLetter.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLostLetter.Location = New System.Drawing.Point(243, 44)
        Me.lblLostLetter.Name = "lblLostLetter"
        Me.lblLostLetter.Size = New System.Drawing.Size(272, 48)
        Me.lblLostLetter.TabIndex = 14
        Me.lblLostLetter.Text = "Lost Letter"
        '
        'picAnswer
        '
        Me.picAnswer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picAnswer.Location = New System.Drawing.Point(538, 308)
        Me.picAnswer.Name = "picAnswer"
        Me.picAnswer.Size = New System.Drawing.Size(202, 202)
        Me.picAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAnswer.TabIndex = 15
        Me.picAnswer.TabStop = False
        Me.picAnswer.Visible = False
        '
        'lblCountdownNumber
        '
        Me.lblCountdownNumber.AutoSize = True
        Me.lblCountdownNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCountdownNumber.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountdownNumber.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCountdownNumber.Location = New System.Drawing.Point(610, 371)
        Me.lblCountdownNumber.Name = "lblCountdownNumber"
        Me.lblCountdownNumber.Size = New System.Drawing.Size(58, 65)
        Me.lblCountdownNumber.TabIndex = 16
        Me.lblCountdownNumber.Text = "5"
        Me.lblCountdownNumber.Visible = False
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGrade.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(13, 429)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(148, 24)
        Me.lblGrade.TabIndex = 17
        Me.lblGrade.Text = "Current Grade:"
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDifficulty.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty.Location = New System.Drawing.Point(12, 478)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(110, 24)
        Me.lblDifficulty.TabIndex = 18
        Me.lblDifficulty.Text = "Difficulty:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUsername.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(13, 332)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(107, 24)
        Me.lblUsername.TabIndex = 19
        Me.lblUsername.Text = "Username:"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAnswer.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(334, 282)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(84, 24)
        Me.lblAnswer.TabIndex = 20
        Me.lblAnswer.Text = "Answer:"
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInformation.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.Location = New System.Drawing.Point(32, 282)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(179, 24)
        Me.lblInformation.TabIndex = 21
        Me.lblInformation.Text = "User Information:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblScore.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(15, 379)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(65, 24)
        Me.lblScore.TabIndex = 13
        Me.lblScore.Text = "Score:"
        '
        'lblTotalQNum
        '
        Me.lblTotalQNum.AutoSize = True
        Me.lblTotalQNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalQNum.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQNum.Location = New System.Drawing.Point(128, 381)
        Me.lblTotalQNum.Name = "lblTotalQNum"
        Me.lblTotalQNum.Size = New System.Drawing.Size(21, 24)
        Me.lblTotalQNum.TabIndex = 22
        Me.lblTotalQNum.Text = "0"
        '
        'lblOutOf
        '
        Me.lblOutOf.AutoSize = True
        Me.lblOutOf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOutOf.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutOf.Location = New System.Drawing.Point(111, 381)
        Me.lblOutOf.Name = "lblOutOf"
        Me.lblOutOf.Size = New System.Drawing.Size(18, 25)
        Me.lblOutOf.TabIndex = 23
        Me.lblOutOf.Text = "/"
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCorrect.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrect.Location = New System.Drawing.Point(83, 381)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(21, 24)
        Me.lblCorrect.TabIndex = 24
        Me.lblCorrect.Text = "0"
        '
        'lblDiff
        '
        Me.lblDiff.AutoSize = True
        Me.lblDiff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDiff.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiff.Location = New System.Drawing.Point(134, 478)
        Me.lblDiff.Name = "lblDiff"
        Me.lblDiff.Size = New System.Drawing.Size(86, 24)
        Me.lblDiff.TabIndex = 25
        Me.lblDiff.Text = "Medium"
        '
        'lblCGrade
        '
        Me.lblCGrade.AutoSize = True
        Me.lblCGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCGrade.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCGrade.Location = New System.Drawing.Point(162, 430)
        Me.lblCGrade.Name = "lblCGrade"
        Me.lblCGrade.Size = New System.Drawing.Size(21, 24)
        Me.lblCGrade.TabIndex = 26
        Me.lblCGrade.Text = "0"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPercent.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(203, 430)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(21, 24)
        Me.lblPercent.TabIndex = 27
        Me.lblPercent.Text = "%"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUser.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(120, 332)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(52, 24)
        Me.lblUser.TabIndex = 28
        Me.lblUser.Text = "User"
        '
        'frmLostLetter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblCGrade)
        Me.Controls.Add(Me.lblDiff)
        Me.Controls.Add(Me.lblCorrect)
        Me.Controls.Add(Me.lblOutOf)
        Me.Controls.Add(Me.lblTotalQNum)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblCountdownNumber)
        Me.Controls.Add(Me.lblLostLetter)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.mnuLostLetter)
        Me.Controls.Add(Me.picAnswer)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuLostLetter
        Me.Name = "frmLostLetter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lost Letter"
        Me.mnuLostLetter.ResumeLayout(False)
        Me.mnuLostLetter.PerformLayout()
        CType(Me.picAnswer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWord As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents mnuLostLetter As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents tmrAnswer As System.Windows.Forms.Timer
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblLostLetter As System.Windows.Forms.Label
    Friend WithEvents picAnswer As System.Windows.Forms.PictureBox
    Friend WithEvents lblCountdownNumber As System.Windows.Forms.Label
    Friend WithEvents shpAnswerBox As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shpWordBox As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents lblDifficulty As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblTotalQNum As System.Windows.Forms.Label
    Friend WithEvents lblOutOf As System.Windows.Forms.Label
    Friend WithEvents lblCorrect As System.Windows.Forms.Label
    Friend WithEvents lblDiff As System.Windows.Forms.Label
    Friend WithEvents lblCGrade As System.Windows.Forms.Label
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
End Class
