<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMathOperations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMathOperations))
        Me.lblGradeNum = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblGradeTitle = New System.Windows.Forms.Label()
        Me.lblUserInfoTitle = New System.Windows.Forms.Label()
        Me.lblQLeftNum = New System.Windows.Forms.Label()
        Me.lblQLeftTitle = New System.Windows.Forms.Label()
        Me.lblUserTitle = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblPercentNum = New System.Windows.Forms.Label()
        Me.lblIncorrectNum = New System.Windows.Forms.Label()
        Me.lblCorrectNum = New System.Windows.Forms.Label()
        Me.lblPercentTitle = New System.Windows.Forms.Label()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.lblCorrectTitle = New System.Windows.Forms.Label()
        Me.txtUserAnswer = New System.Windows.Forms.TextBox()
        Me.cmdGiveUp = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdVerify = New System.Windows.Forms.Button()
        Me.lblTimeTitle = New System.Windows.Forms.Label()
        Me.lblOperationSym = New System.Windows.Forms.Label()
        Me.lblSecNumber = New System.Windows.Forms.Label()
        Me.lblFirstNumber = New System.Windows.Forms.Label()
        Me.lblTimeNum = New System.Windows.Forms.Label()
        Me.lblMathOperations = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.mnuMathOperations = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrUserTime = New System.Windows.Forms.Timer(Me.components)
        Me.picAnswer = New System.Windows.Forms.PictureBox()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.mnuMathOperations.SuspendLayout()
        CType(Me.picAnswer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGradeNum
        '
        Me.lblGradeNum.AutoSize = True
        Me.lblGradeNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGradeNum.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeNum.Location = New System.Drawing.Point(668, 508)
        Me.lblGradeNum.Name = "lblGradeNum"
        Me.lblGradeNum.Size = New System.Drawing.Size(25, 29)
        Me.lblGradeNum.TabIndex = 52
        Me.lblGradeNum.Text = "%"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUserName.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(475, 469)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(63, 29)
        Me.lblUserName.TabIndex = 51
        Me.lblUserName.Text = "User"
        '
        'lblGradeTitle
        '
        Me.lblGradeTitle.AutoSize = True
        Me.lblGradeTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGradeTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeTitle.Location = New System.Drawing.Point(300, 508)
        Me.lblGradeTitle.Name = "lblGradeTitle"
        Me.lblGradeTitle.Size = New System.Drawing.Size(178, 29)
        Me.lblGradeTitle.TabIndex = 50
        Me.lblGradeTitle.Text = "Current Grade:"
        '
        'lblUserInfoTitle
        '
        Me.lblUserInfoTitle.AutoSize = True
        Me.lblUserInfoTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUserInfoTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInfoTitle.Location = New System.Drawing.Point(298, 433)
        Me.lblUserInfoTitle.Name = "lblUserInfoTitle"
        Me.lblUserInfoTitle.Size = New System.Drawing.Size(224, 29)
        Me.lblUserInfoTitle.TabIndex = 49
        Me.lblUserInfoTitle.Text = "User Information"
        '
        'lblQLeftNum
        '
        Me.lblQLeftNum.AutoSize = True
        Me.lblQLeftNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblQLeftNum.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQLeftNum.Location = New System.Drawing.Point(666, 377)
        Me.lblQLeftNum.Name = "lblQLeftNum"
        Me.lblQLeftNum.Size = New System.Drawing.Size(27, 31)
        Me.lblQLeftNum.TabIndex = 48
        Me.lblQLeftNum.Text = "0"
        '
        'lblQLeftTitle
        '
        Me.lblQLeftTitle.AutoSize = True
        Me.lblQLeftTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblQLeftTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQLeftTitle.Location = New System.Drawing.Point(296, 377)
        Me.lblQLeftTitle.Name = "lblQLeftTitle"
        Me.lblQLeftTitle.Size = New System.Drawing.Size(186, 29)
        Me.lblQLeftTitle.TabIndex = 47
        Me.lblQLeftTitle.Text = "Questions Left"
        '
        'lblUserTitle
        '
        Me.lblUserTitle.AutoSize = True
        Me.lblUserTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUserTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserTitle.Location = New System.Drawing.Point(300, 469)
        Me.lblUserTitle.Name = "lblUserTitle"
        Me.lblUserTitle.Size = New System.Drawing.Size(137, 29)
        Me.lblUserTitle.TabIndex = 46
        Me.lblUserTitle.Text = "Username: "
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblScore.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(105, 312)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(81, 31)
        Me.lblScore.TabIndex = 45
        Me.lblScore.Text = "Score"
        '
        'lblPercentNum
        '
        Me.lblPercentNum.AutoSize = True
        Me.lblPercentNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPercentNum.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentNum.Location = New System.Drawing.Point(211, 481)
        Me.lblPercentNum.Name = "lblPercentNum"
        Me.lblPercentNum.Size = New System.Drawing.Size(25, 29)
        Me.lblPercentNum.TabIndex = 44
        Me.lblPercentNum.Text = "0"
        '
        'lblIncorrectNum
        '
        Me.lblIncorrectNum.AutoSize = True
        Me.lblIncorrectNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIncorrectNum.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrectNum.Location = New System.Drawing.Point(211, 425)
        Me.lblIncorrectNum.Name = "lblIncorrectNum"
        Me.lblIncorrectNum.Size = New System.Drawing.Size(25, 29)
        Me.lblIncorrectNum.TabIndex = 43
        Me.lblIncorrectNum.Text = "0"
        '
        'lblCorrectNum
        '
        Me.lblCorrectNum.AutoSize = True
        Me.lblCorrectNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCorrectNum.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectNum.Location = New System.Drawing.Point(211, 367)
        Me.lblCorrectNum.Name = "lblCorrectNum"
        Me.lblCorrectNum.Size = New System.Drawing.Size(25, 29)
        Me.lblCorrectNum.TabIndex = 42
        Me.lblCorrectNum.Text = "0"
        '
        'lblPercentTitle
        '
        Me.lblPercentTitle.AutoSize = True
        Me.lblPercentTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPercentTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentTitle.Location = New System.Drawing.Point(20, 481)
        Me.lblPercentTitle.Name = "lblPercentTitle"
        Me.lblPercentTitle.Size = New System.Drawing.Size(97, 29)
        Me.lblPercentTitle.TabIndex = 41
        Me.lblPercentTitle.Text = "Percent"
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIncorrect.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect.Location = New System.Drawing.Point(20, 425)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(114, 29)
        Me.lblIncorrect.TabIndex = 40
        Me.lblIncorrect.Text = "Incorrect"
        '
        'lblCorrectTitle
        '
        Me.lblCorrectTitle.AutoSize = True
        Me.lblCorrectTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCorrectTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectTitle.Location = New System.Drawing.Point(20, 367)
        Me.lblCorrectTitle.Name = "lblCorrectTitle"
        Me.lblCorrectTitle.Size = New System.Drawing.Size(92, 29)
        Me.lblCorrectTitle.TabIndex = 39
        Me.lblCorrectTitle.Text = "Correct"
        '
        'txtUserAnswer
        '
        Me.txtUserAnswer.Enabled = False
        Me.txtUserAnswer.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserAnswer.Location = New System.Drawing.Point(60, 237)
        Me.txtUserAnswer.MaxLength = 5
        Me.txtUserAnswer.Name = "txtUserAnswer"
        Me.txtUserAnswer.Size = New System.Drawing.Size(171, 42)
        Me.txtUserAnswer.TabIndex = 2
        Me.txtUserAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdGiveUp
        '
        Me.cmdGiveUp.BackColor = System.Drawing.Color.Red
        Me.cmdGiveUp.Enabled = False
        Me.cmdGiveUp.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGiveUp.Location = New System.Drawing.Point(302, 233)
        Me.cmdGiveUp.Name = "cmdGiveUp"
        Me.cmdGiveUp.Size = New System.Drawing.Size(226, 60)
        Me.cmdGiveUp.TabIndex = 4
        Me.cmdGiveUp.Text = "Give Up"
        Me.cmdGiveUp.UseVisualStyleBackColor = False
        '
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdNext.Enabled = False
        Me.cmdNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(302, 161)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(226, 60)
        Me.cmdNext.TabIndex = 5
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'cmdVerify
        '
        Me.cmdVerify.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdVerify.Enabled = False
        Me.cmdVerify.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerify.Location = New System.Drawing.Point(302, 92)
        Me.cmdVerify.Name = "cmdVerify"
        Me.cmdVerify.Size = New System.Drawing.Size(226, 60)
        Me.cmdVerify.TabIndex = 3
        Me.cmdVerify.Text = "Verify Answer"
        Me.cmdVerify.UseVisualStyleBackColor = False
        '
        'lblTimeTitle
        '
        Me.lblTimeTitle.AutoSize = True
        Me.lblTimeTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTimeTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeTitle.Location = New System.Drawing.Point(300, 319)
        Me.lblTimeTitle.Name = "lblTimeTitle"
        Me.lblTimeTitle.Size = New System.Drawing.Size(74, 29)
        Me.lblTimeTitle.TabIndex = 34
        Me.lblTimeTitle.Text = "Time"
        '
        'lblOperationSym
        '
        Me.lblOperationSym.AutoSize = True
        Me.lblOperationSym.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblOperationSym.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperationSym.Location = New System.Drawing.Point(70, 176)
        Me.lblOperationSym.Name = "lblOperationSym"
        Me.lblOperationSym.Size = New System.Drawing.Size(0, 34)
        Me.lblOperationSym.TabIndex = 33
        '
        'lblSecNumber
        '
        Me.lblSecNumber.AutoSize = True
        Me.lblSecNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSecNumber.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecNumber.Location = New System.Drawing.Point(185, 176)
        Me.lblSecNumber.Name = "lblSecNumber"
        Me.lblSecNumber.Size = New System.Drawing.Size(0, 34)
        Me.lblSecNumber.TabIndex = 32
        '
        'lblFirstNumber
        '
        Me.lblFirstNumber.AutoSize = True
        Me.lblFirstNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFirstNumber.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNumber.Location = New System.Drawing.Point(185, 118)
        Me.lblFirstNumber.Name = "lblFirstNumber"
        Me.lblFirstNumber.Size = New System.Drawing.Size(0, 34)
        Me.lblFirstNumber.TabIndex = 31
        '
        'lblTimeNum
        '
        Me.lblTimeNum.AutoSize = True
        Me.lblTimeNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTimeNum.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeNum.Location = New System.Drawing.Point(666, 317)
        Me.lblTimeNum.Name = "lblTimeNum"
        Me.lblTimeNum.Size = New System.Drawing.Size(27, 31)
        Me.lblTimeNum.TabIndex = 30
        Me.lblTimeNum.Text = "0"
        '
        'lblMathOperations
        '
        Me.lblMathOperations.AutoSize = True
        Me.lblMathOperations.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMathOperations.Location = New System.Drawing.Point(208, 33)
        Me.lblMathOperations.Name = "lblMathOperations"
        Me.lblMathOperations.Size = New System.Drawing.Size(376, 48)
        Me.lblMathOperations.TabIndex = 29
        Me.lblMathOperations.Text = "Math Operations"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape6, Me.RectangleShape2, Me.RectangleShape7, Me.RectangleShape5, Me.RectangleShape1, Me.RectangleShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(764, 562)
        Me.ShapeContainer1.TabIndex = 53
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape4.Location = New System.Drawing.Point(534, 94)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(219, 200)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape6.Location = New System.Drawing.Point(295, 368)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(460, 51)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.Location = New System.Drawing.Point(295, 303)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(460, 55)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape7.Location = New System.Drawing.Point(296, 431)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(459, 113)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.Location = New System.Drawing.Point(58, 220)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(177, 1)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(13, 92)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(277, 201)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.Location = New System.Drawing.Point(14, 303)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(276, 240)
        '
        'mnuMathOperations
        '
        Me.mnuMathOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMathOperations.Location = New System.Drawing.Point(0, 0)
        Me.mnuMathOperations.Name = "mnuMathOperations"
        Me.mnuMathOperations.Size = New System.Drawing.Size(764, 24)
        Me.mnuMathOperations.TabIndex = 54
        Me.mnuMathOperations.Text = "MenuStrip1"
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
        'tmrUserTime
        '
        Me.tmrUserTime.Interval = 1000
        '
        'picAnswer
        '
        Me.picAnswer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picAnswer.Location = New System.Drawing.Point(555, 106)
        Me.picAnswer.Name = "picAnswer"
        Me.picAnswer.Size = New System.Drawing.Size(180, 177)
        Me.picAnswer.TabIndex = 55
        Me.picAnswer.TabStop = False
        '
        'cmdPlay
        '
        Me.cmdPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdPlay.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlay.Location = New System.Drawing.Point(600, 42)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(107, 36)
        Me.cmdPlay.TabIndex = 1
        Me.cmdPlay.Text = "Click to Play!"
        Me.cmdPlay.UseVisualStyleBackColor = False
        '
        'frmMathOperations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.picAnswer)
        Me.Controls.Add(Me.lblGradeNum)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblGradeTitle)
        Me.Controls.Add(Me.lblUserInfoTitle)
        Me.Controls.Add(Me.lblQLeftNum)
        Me.Controls.Add(Me.lblQLeftTitle)
        Me.Controls.Add(Me.lblUserTitle)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblPercentNum)
        Me.Controls.Add(Me.lblIncorrectNum)
        Me.Controls.Add(Me.lblCorrectNum)
        Me.Controls.Add(Me.lblPercentTitle)
        Me.Controls.Add(Me.lblIncorrect)
        Me.Controls.Add(Me.lblCorrectTitle)
        Me.Controls.Add(Me.txtUserAnswer)
        Me.Controls.Add(Me.cmdGiveUp)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdVerify)
        Me.Controls.Add(Me.lblTimeTitle)
        Me.Controls.Add(Me.lblOperationSym)
        Me.Controls.Add(Me.lblSecNumber)
        Me.Controls.Add(Me.lblFirstNumber)
        Me.Controls.Add(Me.lblTimeNum)
        Me.Controls.Add(Me.lblMathOperations)
        Me.Controls.Add(Me.mnuMathOperations)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMathOperations
        Me.Name = "frmMathOperations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Math Operations"
        Me.mnuMathOperations.ResumeLayout(False)
        Me.mnuMathOperations.PerformLayout()
        CType(Me.picAnswer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGradeNum As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblGradeTitle As System.Windows.Forms.Label
    Friend WithEvents lblUserInfoTitle As System.Windows.Forms.Label
    Friend WithEvents lblQLeftNum As System.Windows.Forms.Label
    Friend WithEvents lblQLeftTitle As System.Windows.Forms.Label
    Friend WithEvents lblUserTitle As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblPercentNum As System.Windows.Forms.Label
    Friend WithEvents lblIncorrectNum As System.Windows.Forms.Label
    Friend WithEvents lblCorrectNum As System.Windows.Forms.Label
    Friend WithEvents lblPercentTitle As System.Windows.Forms.Label
    Friend WithEvents lblIncorrect As System.Windows.Forms.Label
    Friend WithEvents lblCorrectTitle As System.Windows.Forms.Label
    Friend WithEvents txtUserAnswer As System.Windows.Forms.TextBox
    Friend WithEvents cmdGiveUp As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdVerify As System.Windows.Forms.Button
    Friend WithEvents lblTimeTitle As System.Windows.Forms.Label
    Friend WithEvents lblOperationSym As System.Windows.Forms.Label
    Friend WithEvents lblSecNumber As System.Windows.Forms.Label
    Friend WithEvents lblFirstNumber As System.Windows.Forms.Label
    Friend WithEvents lblTimeNum As System.Windows.Forms.Label
    Friend WithEvents lblMathOperations As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents mnuMathOperations As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrUserTime As System.Windows.Forms.Timer
    Friend WithEvents picAnswer As System.Windows.Forms.PictureBox
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPlay As System.Windows.Forms.Button
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
