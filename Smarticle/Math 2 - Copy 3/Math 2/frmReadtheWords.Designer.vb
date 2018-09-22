<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReadtheWords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReadtheWords))
        Me.lblReadtheWordsTitle = New System.Windows.Forms.Label()
        Me.mnuReadtheWords = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblWhereorWhatColour = New System.Windows.Forms.Label()
        Me.cmdGiveUp = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdVerify = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblPercentNum = New System.Windows.Forms.Label()
        Me.lblIncorrectNum = New System.Windows.Forms.Label()
        Me.lblCorrectNum = New System.Windows.Forms.Label()
        Me.lblPercentTitle = New System.Windows.Forms.Label()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.lblCorrectTitle = New System.Windows.Forms.Label()
        Me.txtUserAnswer = New System.Windows.Forms.TextBox()
        Me.lblUserTitle = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblGradeTitle = New System.Windows.Forms.Label()
        Me.picAnswer = New System.Windows.Forms.PictureBox()
        Me.lblTimeTitle = New System.Windows.Forms.Label()
        Me.lblTimeNum = New System.Windows.Forms.Label()
        Me.lblQLeftTitle = New System.Windows.Forms.Label()
        Me.lblQLeftNum = New System.Windows.Forms.Label()
        Me.lblCurrentGrade = New System.Windows.Forms.Label()
        Me.tmrUserTime = New System.Windows.Forms.Timer(Me.components)
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.mnuReadtheWords.SuspendLayout()
        CType(Me.picAnswer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblReadtheWordsTitle
        '
        Me.lblReadtheWordsTitle.AutoSize = True
        Me.lblReadtheWordsTitle.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReadtheWordsTitle.Location = New System.Drawing.Point(187, 33)
        Me.lblReadtheWordsTitle.Name = "lblReadtheWordsTitle"
        Me.lblReadtheWordsTitle.Size = New System.Drawing.Size(371, 48)
        Me.lblReadtheWordsTitle.TabIndex = 0
        Me.lblReadtheWordsTitle.Text = "Read the Words!"
        '
        'mnuReadtheWords
        '
        Me.mnuReadtheWords.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuReadtheWords.Location = New System.Drawing.Point(0, 0)
        Me.mnuReadtheWords.Name = "mnuReadtheWords"
        Me.mnuReadtheWords.Size = New System.Drawing.Size(764, 24)
        Me.mnuReadtheWords.TabIndex = 1
        Me.mnuReadtheWords.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.RestartToolStripMenuItem, Me.QuitToolStripMenuItem})
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
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.RestartToolStripMenuItem.Text = "&Restart"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.InstructionsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.InstructionsToolStripMenuItem.Text = "&Instructions"
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.BackColor = System.Drawing.Color.White
        Me.lblWord.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord.Location = New System.Drawing.Point(200, 175)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(96, 36)
        Me.lblWord.TabIndex = 2
        Me.lblWord.Text = "Word"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape7, Me.RectangleShape6, Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(764, 562)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape7.Location = New System.Drawing.Point(523, 303)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(225, 190)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape6.Location = New System.Drawing.Point(268, 432)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(248, 58)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape5.Location = New System.Drawing.Point(525, 90)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(225, 208)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape4.Location = New System.Drawing.Point(15, 432)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(248, 58)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.Location = New System.Drawing.Point(16, 497)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(732, 57)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.Location = New System.Drawing.Point(15, 304)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(501, 61)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.White
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(15, 90)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(503, 210)
        '
        'lblWhereorWhatColour
        '
        Me.lblWhereorWhatColour.AutoSize = True
        Me.lblWhereorWhatColour.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblWhereorWhatColour.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhereorWhatColour.Location = New System.Drawing.Point(26, 323)
        Me.lblWhereorWhatColour.Name = "lblWhereorWhatColour"
        Me.lblWhereorWhatColour.Size = New System.Drawing.Size(105, 34)
        Me.lblWhereorWhatColour.TabIndex = 41
        Me.lblWhereorWhatColour.Text = "Words"
        '
        'cmdGiveUp
        '
        Me.cmdGiveUp.BackColor = System.Drawing.Color.Red
        Me.cmdGiveUp.Enabled = False
        Me.cmdGiveUp.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGiveUp.Location = New System.Drawing.Point(15, 368)
        Me.cmdGiveUp.Name = "cmdGiveUp"
        Me.cmdGiveUp.Size = New System.Drawing.Size(167, 60)
        Me.cmdGiveUp.TabIndex = 4
        Me.cmdGiveUp.Text = "Give Up"
        Me.cmdGiveUp.UseVisualStyleBackColor = False
        '
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdNext.Enabled = False
        Me.cmdNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(183, 368)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(167, 60)
        Me.cmdNext.TabIndex = 5
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'cmdVerify
        '
        Me.cmdVerify.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdVerify.Enabled = False
        Me.cmdVerify.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerify.Location = New System.Drawing.Point(351, 368)
        Me.cmdVerify.Name = "cmdVerify"
        Me.cmdVerify.Size = New System.Drawing.Size(167, 60)
        Me.cmdVerify.TabIndex = 3
        Me.cmdVerify.Text = "Verify Answer"
        Me.cmdVerify.UseVisualStyleBackColor = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblScore.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(600, 92)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(81, 31)
        Me.lblScore.TabIndex = 52
        Me.lblScore.Text = "Score"
        '
        'lblPercentNum
        '
        Me.lblPercentNum.AutoSize = True
        Me.lblPercentNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPercentNum.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentNum.Location = New System.Drawing.Point(683, 252)
        Me.lblPercentNum.Name = "lblPercentNum"
        Me.lblPercentNum.Size = New System.Drawing.Size(25, 29)
        Me.lblPercentNum.TabIndex = 51
        Me.lblPercentNum.Text = "0"
        '
        'lblIncorrectNum
        '
        Me.lblIncorrectNum.AutoSize = True
        Me.lblIncorrectNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIncorrectNum.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrectNum.Location = New System.Drawing.Point(683, 184)
        Me.lblIncorrectNum.Name = "lblIncorrectNum"
        Me.lblIncorrectNum.Size = New System.Drawing.Size(25, 29)
        Me.lblIncorrectNum.TabIndex = 50
        Me.lblIncorrectNum.Text = "0"
        '
        'lblCorrectNum
        '
        Me.lblCorrectNum.AutoSize = True
        Me.lblCorrectNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCorrectNum.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectNum.Location = New System.Drawing.Point(683, 123)
        Me.lblCorrectNum.Name = "lblCorrectNum"
        Me.lblCorrectNum.Size = New System.Drawing.Size(25, 29)
        Me.lblCorrectNum.TabIndex = 49
        Me.lblCorrectNum.Text = "0"
        '
        'lblPercentTitle
        '
        Me.lblPercentTitle.AutoSize = True
        Me.lblPercentTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPercentTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentTitle.Location = New System.Drawing.Point(529, 252)
        Me.lblPercentTitle.Name = "lblPercentTitle"
        Me.lblPercentTitle.Size = New System.Drawing.Size(97, 29)
        Me.lblPercentTitle.TabIndex = 48
        Me.lblPercentTitle.Text = "Percent"
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIncorrect.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect.Location = New System.Drawing.Point(529, 184)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(114, 29)
        Me.lblIncorrect.TabIndex = 47
        Me.lblIncorrect.Text = "Incorrect"
        '
        'lblCorrectTitle
        '
        Me.lblCorrectTitle.AutoSize = True
        Me.lblCorrectTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCorrectTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectTitle.Location = New System.Drawing.Point(529, 123)
        Me.lblCorrectTitle.Name = "lblCorrectTitle"
        Me.lblCorrectTitle.Size = New System.Drawing.Size(92, 29)
        Me.lblCorrectTitle.TabIndex = 46
        Me.lblCorrectTitle.Text = "Correct"
        '
        'txtUserAnswer
        '
        Me.txtUserAnswer.Enabled = False
        Me.txtUserAnswer.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserAnswer.Location = New System.Drawing.Point(338, 314)
        Me.txtUserAnswer.MaxLength = 7
        Me.txtUserAnswer.Name = "txtUserAnswer"
        Me.txtUserAnswer.Size = New System.Drawing.Size(171, 42)
        Me.txtUserAnswer.TabIndex = 2
        Me.txtUserAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblUserTitle
        '
        Me.lblUserTitle.AutoSize = True
        Me.lblUserTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUserTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserTitle.Location = New System.Drawing.Point(27, 511)
        Me.lblUserTitle.Name = "lblUserTitle"
        Me.lblUserTitle.Size = New System.Drawing.Size(145, 29)
        Me.lblUserTitle.TabIndex = 54
        Me.lblUserTitle.Text = "User name: "
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUserName.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(166, 511)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(63, 29)
        Me.lblUserName.TabIndex = 55
        Me.lblUserName.Text = "User"
        '
        'lblGradeTitle
        '
        Me.lblGradeTitle.AutoSize = True
        Me.lblGradeTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGradeTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeTitle.Location = New System.Drawing.Point(345, 511)
        Me.lblGradeTitle.Name = "lblGradeTitle"
        Me.lblGradeTitle.Size = New System.Drawing.Size(178, 29)
        Me.lblGradeTitle.TabIndex = 56
        Me.lblGradeTitle.Text = "Current Grade:"
        '
        'picAnswer
        '
        Me.picAnswer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picAnswer.Location = New System.Drawing.Point(546, 310)
        Me.picAnswer.Name = "picAnswer"
        Me.picAnswer.Size = New System.Drawing.Size(180, 177)
        Me.picAnswer.TabIndex = 57
        Me.picAnswer.TabStop = False
        '
        'lblTimeTitle
        '
        Me.lblTimeTitle.AutoSize = True
        Me.lblTimeTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTimeTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeTitle.Location = New System.Drawing.Point(19, 447)
        Me.lblTimeTitle.Name = "lblTimeTitle"
        Me.lblTimeTitle.Size = New System.Drawing.Size(74, 29)
        Me.lblTimeTitle.TabIndex = 58
        Me.lblTimeTitle.Text = "Time"
        '
        'lblTimeNum
        '
        Me.lblTimeNum.AutoSize = True
        Me.lblTimeNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTimeNum.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeNum.Location = New System.Drawing.Point(213, 447)
        Me.lblTimeNum.Name = "lblTimeNum"
        Me.lblTimeNum.Size = New System.Drawing.Size(27, 31)
        Me.lblTimeNum.TabIndex = 59
        Me.lblTimeNum.Text = "0"
        '
        'lblQLeftTitle
        '
        Me.lblQLeftTitle.AutoSize = True
        Me.lblQLeftTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblQLeftTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQLeftTitle.Location = New System.Drawing.Point(271, 447)
        Me.lblQLeftTitle.Name = "lblQLeftTitle"
        Me.lblQLeftTitle.Size = New System.Drawing.Size(186, 29)
        Me.lblQLeftTitle.TabIndex = 60
        Me.lblQLeftTitle.Text = "Questions Left"
        '
        'lblQLeftNum
        '
        Me.lblQLeftNum.AutoSize = True
        Me.lblQLeftNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblQLeftNum.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQLeftNum.Location = New System.Drawing.Point(464, 447)
        Me.lblQLeftNum.Name = "lblQLeftNum"
        Me.lblQLeftNum.Size = New System.Drawing.Size(27, 31)
        Me.lblQLeftNum.TabIndex = 61
        Me.lblQLeftNum.Text = "0"
        '
        'lblCurrentGrade
        '
        Me.lblCurrentGrade.AutoSize = True
        Me.lblCurrentGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCurrentGrade.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentGrade.Location = New System.Drawing.Point(701, 511)
        Me.lblCurrentGrade.Name = "lblCurrentGrade"
        Me.lblCurrentGrade.Size = New System.Drawing.Size(25, 29)
        Me.lblCurrentGrade.TabIndex = 62
        Me.lblCurrentGrade.Text = "%"
        '
        'tmrUserTime
        '
        Me.tmrUserTime.Interval = 1000
        '
        'cmdPlay
        '
        Me.cmdPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdPlay.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlay.Location = New System.Drawing.Point(569, 40)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(107, 36)
        Me.cmdPlay.TabIndex = 1
        Me.cmdPlay.Text = "Click to Play!"
        Me.cmdPlay.UseVisualStyleBackColor = False
        '
        'frmReadtheWords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.lblCurrentGrade)
        Me.Controls.Add(Me.lblQLeftNum)
        Me.Controls.Add(Me.lblQLeftTitle)
        Me.Controls.Add(Me.lblTimeNum)
        Me.Controls.Add(Me.lblTimeTitle)
        Me.Controls.Add(Me.picAnswer)
        Me.Controls.Add(Me.lblGradeTitle)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblUserTitle)
        Me.Controls.Add(Me.txtUserAnswer)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblPercentNum)
        Me.Controls.Add(Me.lblIncorrectNum)
        Me.Controls.Add(Me.lblCorrectNum)
        Me.Controls.Add(Me.lblPercentTitle)
        Me.Controls.Add(Me.lblIncorrect)
        Me.Controls.Add(Me.lblCorrectTitle)
        Me.Controls.Add(Me.cmdGiveUp)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdVerify)
        Me.Controls.Add(Me.lblWhereorWhatColour)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.lblReadtheWordsTitle)
        Me.Controls.Add(Me.mnuReadtheWords)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuReadtheWords
        Me.Name = "frmReadtheWords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Read the Words!"
        Me.mnuReadtheWords.ResumeLayout(False)
        Me.mnuReadtheWords.PerformLayout()
        CType(Me.picAnswer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReadtheWordsTitle As System.Windows.Forms.Label
    Friend WithEvents mnuReadtheWords As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblWord As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblWhereorWhatColour As System.Windows.Forms.Label
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents cmdGiveUp As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdVerify As System.Windows.Forms.Button
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblPercentNum As System.Windows.Forms.Label
    Friend WithEvents lblIncorrectNum As System.Windows.Forms.Label
    Friend WithEvents lblCorrectNum As System.Windows.Forms.Label
    Friend WithEvents lblPercentTitle As System.Windows.Forms.Label
    Friend WithEvents lblIncorrect As System.Windows.Forms.Label
    Friend WithEvents lblCorrectTitle As System.Windows.Forms.Label
    Friend WithEvents txtUserAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblUserTitle As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblGradeTitle As System.Windows.Forms.Label
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents picAnswer As System.Windows.Forms.PictureBox
    Friend WithEvents RectangleShape7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblTimeTitle As System.Windows.Forms.Label
    Friend WithEvents lblTimeNum As System.Windows.Forms.Label
    Friend WithEvents lblQLeftTitle As System.Windows.Forms.Label
    Friend WithEvents lblQLeftNum As System.Windows.Forms.Label
    Friend WithEvents lblCurrentGrade As System.Windows.Forms.Label
    Friend WithEvents tmrUserTime As System.Windows.Forms.Timer
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPlay As System.Windows.Forms.Button
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
