<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLessEqualsMore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLessEqualsMore))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnuLessEqualsMore = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shpAnswerBox = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpDesignBox2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpDesignBox3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpDesignBox1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.lblIncorrectTitle = New System.Windows.Forms.Label()
        Me.lblCorrectTitle = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblUsernameTitle = New System.Windows.Forms.Label()
        Me.cmdGreater = New System.Windows.Forms.Button()
        Me.cmdEqual = New System.Windows.Forms.Button()
        Me.cmdLess = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdResults = New System.Windows.Forms.Button()
        Me.lblRightOrWrong = New System.Windows.Forms.Label()
        Me.lblSecondDigit = New System.Windows.Forms.Label()
        Me.lblFirstDigit = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.tmrAnswerTime = New System.Windows.Forms.Timer(Me.components)
        Me.cmdFinish = New System.Windows.Forms.Button()
        Me.tmrPlayTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblPlayingTime = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.mnuLessEqualsMore.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(173, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(422, 48)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Less, Equals, More"
        '
        'mnuLessEqualsMore
        '
        Me.mnuLessEqualsMore.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuLessEqualsMore.Location = New System.Drawing.Point(0, 0)
        Me.mnuLessEqualsMore.Name = "mnuLessEqualsMore"
        Me.mnuLessEqualsMore.Size = New System.Drawing.Size(764, 24)
        Me.mnuLessEqualsMore.TabIndex = 2
        Me.mnuLessEqualsMore.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartToolStripMenuItem, Me.MainMenuToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RestartToolStripMenuItem.Text = "&Restart"
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
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shpAnswerBox, Me.shpDesignBox2, Me.shpDesignBox3, Me.shpDesignBox1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(764, 562)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'shpAnswerBox
        '
        Me.shpAnswerBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.shpAnswerBox.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shpAnswerBox.Location = New System.Drawing.Point(349, 199)
        Me.shpAnswerBox.Name = "shpAnswerBox"
        Me.shpAnswerBox.Size = New System.Drawing.Size(75, 68)
        '
        'shpDesignBox2
        '
        Me.shpDesignBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.shpDesignBox2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shpDesignBox2.Location = New System.Drawing.Point(197, 108)
        Me.shpDesignBox2.Name = "shpDesignBox2"
        Me.shpDesignBox2.Size = New System.Drawing.Size(370, 434)
        '
        'shpDesignBox3
        '
        Me.shpDesignBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.shpDesignBox3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shpDesignBox3.Location = New System.Drawing.Point(578, 108)
        Me.shpDesignBox3.Name = "shpDesignBox3"
        Me.shpDesignBox3.Size = New System.Drawing.Size(169, 434)
        '
        'shpDesignBox1
        '
        Me.shpDesignBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.shpDesignBox1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shpDesignBox1.Location = New System.Drawing.Point(17, 108)
        Me.shpDesignBox1.Name = "shpDesignBox1"
        Me.shpDesignBox1.Size = New System.Drawing.Size(169, 434)
        '
        'lblUserInfo
        '
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUserInfo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInfo.Location = New System.Drawing.Point(54, 129)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(99, 24)
        Me.lblUserInfo.TabIndex = 9
        Me.lblUserInfo.Text = "User Info"
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIncorrect.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect.Location = New System.Drawing.Point(123, 491)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(20, 24)
        Me.lblIncorrect.TabIndex = 20
        Me.lblIncorrect.Text = "0"
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCorrect.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrect.Location = New System.Drawing.Point(123, 435)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(20, 24)
        Me.lblCorrect.TabIndex = 19
        Me.lblCorrect.Text = "0"
        '
        'lblIncorrectTitle
        '
        Me.lblIncorrectTitle.AutoSize = True
        Me.lblIncorrectTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIncorrectTitle.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrectTitle.Location = New System.Drawing.Point(28, 491)
        Me.lblIncorrectTitle.Name = "lblIncorrectTitle"
        Me.lblIncorrectTitle.Size = New System.Drawing.Size(90, 24)
        Me.lblIncorrectTitle.TabIndex = 18
        Me.lblIncorrectTitle.Text = "Incorrect:"
        '
        'lblCorrectTitle
        '
        Me.lblCorrectTitle.AutoSize = True
        Me.lblCorrectTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCorrectTitle.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectTitle.Location = New System.Drawing.Point(29, 434)
        Me.lblCorrectTitle.Name = "lblCorrectTitle"
        Me.lblCorrectTitle.Size = New System.Drawing.Size(73, 24)
        Me.lblCorrectTitle.TabIndex = 17
        Me.lblCorrectTitle.Text = "Correct:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblScore.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(29, 369)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(59, 24)
        Me.lblScore.TabIndex = 16
        Me.lblScore.Text = "Score:"
        '
        'lblUsernameTitle
        '
        Me.lblUsernameTitle.AutoSize = True
        Me.lblUsernameTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUsernameTitle.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameTitle.Location = New System.Drawing.Point(29, 214)
        Me.lblUsernameTitle.Name = "lblUsernameTitle"
        Me.lblUsernameTitle.Size = New System.Drawing.Size(98, 24)
        Me.lblUsernameTitle.TabIndex = 15
        Me.lblUsernameTitle.Text = "Username:"
        '
        'cmdGreater
        '
        Me.cmdGreater.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdGreater.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGreater.Location = New System.Drawing.Point(228, 410)
        Me.cmdGreater.Name = "cmdGreater"
        Me.cmdGreater.Size = New System.Drawing.Size(95, 34)
        Me.cmdGreater.TabIndex = 1
        Me.cmdGreater.Text = ">"
        Me.cmdGreater.UseVisualStyleBackColor = False
        '
        'cmdEqual
        '
        Me.cmdEqual.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdEqual.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEqual.Location = New System.Drawing.Point(337, 410)
        Me.cmdEqual.Name = "cmdEqual"
        Me.cmdEqual.Size = New System.Drawing.Size(95, 34)
        Me.cmdEqual.TabIndex = 2
        Me.cmdEqual.Text = "="
        Me.cmdEqual.UseVisualStyleBackColor = False
        '
        'cmdLess
        '
        Me.cmdLess.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLess.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLess.Location = New System.Drawing.Point(446, 410)
        Me.cmdLess.Name = "cmdLess"
        Me.cmdLess.Size = New System.Drawing.Size(95, 34)
        Me.cmdLess.TabIndex = 3
        Me.cmdLess.Text = "<"
        Me.cmdLess.UseVisualStyleBackColor = False
        '
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdNext.Enabled = False
        Me.cmdNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(615, 359)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(95, 34)
        Me.cmdNext.TabIndex = 4
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'cmdResults
        '
        Me.cmdResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdResults.Enabled = False
        Me.cmdResults.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResults.Location = New System.Drawing.Point(615, 421)
        Me.cmdResults.Name = "cmdResults"
        Me.cmdResults.Size = New System.Drawing.Size(95, 34)
        Me.cmdResults.TabIndex = 5
        Me.cmdResults.Text = "Results"
        Me.cmdResults.UseVisualStyleBackColor = False
        '
        'lblRightOrWrong
        '
        Me.lblRightOrWrong.AutoSize = True
        Me.lblRightOrWrong.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRightOrWrong.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRightOrWrong.Location = New System.Drawing.Point(620, 224)
        Me.lblRightOrWrong.Name = "lblRightOrWrong"
        Me.lblRightOrWrong.Size = New System.Drawing.Size(18, 24)
        Me.lblRightOrWrong.TabIndex = 26
        Me.lblRightOrWrong.Text = "-"
        '
        'lblSecondDigit
        '
        Me.lblSecondDigit.AutoSize = True
        Me.lblSecondDigit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSecondDigit.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondDigit.Location = New System.Drawing.Point(441, 217)
        Me.lblSecondDigit.Name = "lblSecondDigit"
        Me.lblSecondDigit.Size = New System.Drawing.Size(68, 38)
        Me.lblSecondDigit.TabIndex = 27
        Me.lblSecondDigit.Text = "100"
        '
        'lblFirstDigit
        '
        Me.lblFirstDigit.AutoSize = True
        Me.lblFirstDigit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFirstDigit.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstDigit.Location = New System.Drawing.Point(264, 216)
        Me.lblFirstDigit.Name = "lblFirstDigit"
        Me.lblFirstDigit.Size = New System.Drawing.Size(68, 38)
        Me.lblFirstDigit.TabIndex = 28
        Me.lblFirstDigit.Text = "100"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAnswer.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(374, 216)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(32, 38)
        Me.lblAnswer.TabIndex = 29
        Me.lblAnswer.Text = "?"
        '
        'tmrAnswerTime
        '
        Me.tmrAnswerTime.Interval = 1000
        '
        'cmdFinish
        '
        Me.cmdFinish.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdFinish.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFinish.Location = New System.Drawing.Point(615, 481)
        Me.cmdFinish.Name = "cmdFinish"
        Me.cmdFinish.Size = New System.Drawing.Size(95, 34)
        Me.cmdFinish.TabIndex = 6
        Me.cmdFinish.Text = "Finish"
        Me.cmdFinish.UseVisualStyleBackColor = False
        '
        'tmrPlayTime
        '
        Me.tmrPlayTime.Interval = 1000
        '
        'lblPlayingTime
        '
        Me.lblPlayingTime.AutoSize = True
        Me.lblPlayingTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPlayingTime.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayingTime.Location = New System.Drawing.Point(591, 131)
        Me.lblPlayingTime.Name = "lblPlayingTime"
        Me.lblPlayingTime.Size = New System.Drawing.Size(64, 24)
        Me.lblPlayingTime.TabIndex = 30
        Me.lblPlayingTime.Text = "Time:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(679, 131)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(32, 24)
        Me.lblTime.TabIndex = 31
        Me.lblTime.Text = "60"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUser.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(29, 244)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(48, 24)
        Me.lblUser.TabIndex = 32
        Me.lblUser.Text = "User"
        '
        'frmLessEqualsMore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblPlayingTime)
        Me.Controls.Add(Me.cmdFinish)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblFirstDigit)
        Me.Controls.Add(Me.lblSecondDigit)
        Me.Controls.Add(Me.lblRightOrWrong)
        Me.Controls.Add(Me.cmdResults)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdLess)
        Me.Controls.Add(Me.cmdEqual)
        Me.Controls.Add(Me.cmdGreater)
        Me.Controls.Add(Me.lblIncorrect)
        Me.Controls.Add(Me.lblCorrect)
        Me.Controls.Add(Me.lblIncorrectTitle)
        Me.Controls.Add(Me.lblCorrectTitle)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblUsernameTitle)
        Me.Controls.Add(Me.lblUserInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuLessEqualsMore)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuLessEqualsMore
        Me.Name = "frmLessEqualsMore"
        Me.Text = "Less, Equals, More"
        Me.mnuLessEqualsMore.ResumeLayout(False)
        Me.mnuLessEqualsMore.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents mnuLessEqualsMore As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents shpAnswerBox As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shpDesignBox2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shpDesignBox3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shpDesignBox1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblUserInfo As System.Windows.Forms.Label
    Friend WithEvents lblIncorrect As System.Windows.Forms.Label
    Friend WithEvents lblCorrect As System.Windows.Forms.Label
    Friend WithEvents lblIncorrectTitle As System.Windows.Forms.Label
    Friend WithEvents lblCorrectTitle As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblUsernameTitle As System.Windows.Forms.Label
    Friend WithEvents cmdGreater As System.Windows.Forms.Button
    Friend WithEvents cmdEqual As System.Windows.Forms.Button
    Friend WithEvents cmdLess As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdResults As System.Windows.Forms.Button
    Friend WithEvents lblRightOrWrong As System.Windows.Forms.Label
    Friend WithEvents lblSecondDigit As System.Windows.Forms.Label
    Friend WithEvents lblFirstDigit As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents tmrAnswerTime As System.Windows.Forms.Timer
    Friend WithEvents cmdFinish As System.Windows.Forms.Button
    Friend WithEvents tmrPlayTime As System.Windows.Forms.Timer
    Friend WithEvents lblPlayingTime As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label

End Class
