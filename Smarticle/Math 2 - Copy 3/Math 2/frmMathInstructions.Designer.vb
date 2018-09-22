<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMathInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMathInstructions))
        Me.lblClicktoPlayButtonInfo = New System.Windows.Forms.Label()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.lblTextboxandVerifyInfo = New System.Windows.Forms.Label()
        Me.lblSecNumExample = New System.Windows.Forms.Label()
        Me.lblFirstNumExample = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.txtExample = New System.Windows.Forms.TextBox()
        Me.lblSymExample = New System.Windows.Forms.Label()
        Me.lblGiveUpButtonInfo = New System.Windows.Forms.Label()
        Me.lblNextButtonInfo = New System.Windows.Forms.Label()
        Me.lblScoreInfo = New System.Windows.Forms.Label()
        Me.lblQuestionLeftInfo = New System.Windows.Forms.Label()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.lblMathInstructionsTitle = New System.Windows.Forms.Label()
        Me.cmdGiveUpExample = New System.Windows.Forms.Button()
        Me.cmdNextExample = New System.Windows.Forms.Button()
        Me.cmdVerifyExample = New System.Windows.Forms.Button()
        Me.lblPercentNum = New System.Windows.Forms.Label()
        Me.lblIncorrectNum = New System.Windows.Forms.Label()
        Me.lblCorrectNum = New System.Windows.Forms.Label()
        Me.lblPercentTitle = New System.Windows.Forms.Label()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.lblCorrectTitle = New System.Windows.Forms.Label()
        Me.lblPictureInfo = New System.Windows.Forms.Label()
        Me.picHappy = New System.Windows.Forms.PictureBox()
        Me.picSad = New System.Windows.Forms.PictureBox()
        Me.lblUsernameExample = New System.Windows.Forms.Label()
        Me.lblGradeExample = New System.Windows.Forms.Label()
        Me.lblQuestionsLeftExample = New System.Windows.Forms.Label()
        Me.mnuMathIntructions = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMathIntructions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClicktoPlayButtonInfo
        '
        Me.lblClicktoPlayButtonInfo.AutoSize = True
        Me.lblClicktoPlayButtonInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblClicktoPlayButtonInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClicktoPlayButtonInfo.Location = New System.Drawing.Point(18, 85)
        Me.lblClicktoPlayButtonInfo.Name = "lblClicktoPlayButtonInfo"
        Me.lblClicktoPlayButtonInfo.Size = New System.Drawing.Size(311, 18)
        Me.lblClicktoPlayButtonInfo.TabIndex = 0
        Me.lblClicktoPlayButtonInfo.Text = "Click the ""Click to Play"" to begin the program."
        '
        'cmdPlay
        '
        Me.cmdPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdPlay.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlay.Location = New System.Drawing.Point(115, 128)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(107, 36)
        Me.cmdPlay.TabIndex = 1
        Me.cmdPlay.Text = "Click to Play!"
        Me.cmdPlay.UseVisualStyleBackColor = False
        '
        'lblTextboxandVerifyInfo
        '
        Me.lblTextboxandVerifyInfo.AutoSize = True
        Me.lblTextboxandVerifyInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTextboxandVerifyInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextboxandVerifyInfo.Location = New System.Drawing.Point(382, 85)
        Me.lblTextboxandVerifyInfo.Name = "lblTextboxandVerifyInfo"
        Me.lblTextboxandVerifyInfo.Size = New System.Drawing.Size(370, 36)
        Me.lblTextboxandVerifyInfo.TabIndex = 58
        Me.lblTextboxandVerifyInfo.Text = "Answer the math question directly underneath into the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "textbox, then click the """ & _
    "verify answer"" button."
        '
        'lblSecNumExample
        '
        Me.lblSecNumExample.AutoSize = True
        Me.lblSecNumExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSecNumExample.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecNumExample.Location = New System.Drawing.Point(497, 142)
        Me.lblSecNumExample.Name = "lblSecNumExample"
        Me.lblSecNumExample.Size = New System.Drawing.Size(20, 21)
        Me.lblSecNumExample.TabIndex = 60
        Me.lblSecNumExample.Text = "4"
        '
        'lblFirstNumExample
        '
        Me.lblFirstNumExample.AutoSize = True
        Me.lblFirstNumExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFirstNumExample.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNumExample.Location = New System.Drawing.Point(497, 124)
        Me.lblFirstNumExample.Name = "lblFirstNumExample"
        Me.lblFirstNumExample.Size = New System.Drawing.Size(20, 21)
        Me.lblFirstNumExample.TabIndex = 59
        Me.lblFirstNumExample.Text = "5"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RectangleShape7, Me.RectangleShape6, Me.RectangleShape1, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape4, Me.RectangleShape10})
        Me.ShapeContainer1.Size = New System.Drawing.Size(764, 561)
        Me.ShapeContainer1.TabIndex = 61
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.Location = New System.Drawing.Point(421, 163)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(100, 1)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape7.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape7.Location = New System.Drawing.Point(15, 80)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(739, 116)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape6.Location = New System.Drawing.Point(14, 202)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(740, 79)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(452, 334)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(206, 87)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.Location = New System.Drawing.Point(13, 287)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(741, 136)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.Location = New System.Drawing.Point(453, 498)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(210, 45)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape4.Location = New System.Drawing.Point(54, 498)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(224, 47)
        '
        'RectangleShape10
        '
        Me.RectangleShape10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape10.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape10.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape10.Location = New System.Drawing.Point(13, 431)
        Me.RectangleShape10.Name = "RectangleShape10"
        Me.RectangleShape10.Size = New System.Drawing.Size(742, 121)
        '
        'txtExample
        '
        Me.txtExample.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExample.Location = New System.Drawing.Point(426, 166)
        Me.txtExample.MaxLength = 2
        Me.txtExample.Name = "txtExample"
        Me.txtExample.Size = New System.Drawing.Size(91, 28)
        Me.txtExample.TabIndex = 2
        Me.txtExample.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSymExample
        '
        Me.lblSymExample.AutoSize = True
        Me.lblSymExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSymExample.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSymExample.Location = New System.Drawing.Point(471, 138)
        Me.lblSymExample.Name = "lblSymExample"
        Me.lblSymExample.Size = New System.Drawing.Size(20, 21)
        Me.lblSymExample.TabIndex = 63
        Me.lblSymExample.Text = "+"
        '
        'lblGiveUpButtonInfo
        '
        Me.lblGiveUpButtonInfo.AutoSize = True
        Me.lblGiveUpButtonInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblGiveUpButtonInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiveUpButtonInfo.Location = New System.Drawing.Point(18, 207)
        Me.lblGiveUpButtonInfo.Name = "lblGiveUpButtonInfo"
        Me.lblGiveUpButtonInfo.Size = New System.Drawing.Size(331, 36)
        Me.lblGiveUpButtonInfo.TabIndex = 64
        Me.lblGiveUpButtonInfo.Text = "If you don't know the answer, click the ""give up"" " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "button or wait until the time" & _
    "r ends."
        '
        'lblNextButtonInfo
        '
        Me.lblNextButtonInfo.AutoSize = True
        Me.lblNextButtonInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNextButtonInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextButtonInfo.Location = New System.Drawing.Point(386, 207)
        Me.lblNextButtonInfo.Name = "lblNextButtonInfo"
        Me.lblNextButtonInfo.Size = New System.Drawing.Size(340, 18)
        Me.lblNextButtonInfo.TabIndex = 65
        Me.lblNextButtonInfo.Text = "To go to the next question, click the ""Next"" button."
        '
        'lblScoreInfo
        '
        Me.lblScoreInfo.AutoSize = True
        Me.lblScoreInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblScoreInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreInfo.Location = New System.Drawing.Point(391, 291)
        Me.lblScoreInfo.Name = "lblScoreInfo"
        Me.lblScoreInfo.Size = New System.Drawing.Size(352, 36)
        Me.lblScoreInfo.TabIndex = 66
        Me.lblScoreInfo.Text = "The scoreboard will tell you how many you got right " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and wrong, as well as the c" & _
    "urrent percentage."
        '
        'lblQuestionLeftInfo
        '
        Me.lblQuestionLeftInfo.AutoSize = True
        Me.lblQuestionLeftInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblQuestionLeftInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionLeftInfo.Location = New System.Drawing.Point(391, 436)
        Me.lblQuestionLeftInfo.Name = "lblQuestionLeftInfo"
        Me.lblQuestionLeftInfo.Size = New System.Drawing.Size(335, 36)
        Me.lblQuestionLeftInfo.TabIndex = 67
        Me.lblQuestionLeftInfo.Text = "The ""Questions Left"" Box will tell you how many " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "questions you have left to comp" & _
    "lete."
        '
        'lblUserInfo
        '
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUserInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInfo.Location = New System.Drawing.Point(18, 436)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(344, 54)
        Me.lblUserInfo.TabIndex = 68
        Me.lblUserInfo.Text = "In the ""User Information"" box, your username and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your current percentage, from " & _
    "playing other games, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will be recorded for you to see."
        '
        'lblMathInstructionsTitle
        '
        Me.lblMathInstructionsTitle.AutoSize = True
        Me.lblMathInstructionsTitle.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMathInstructionsTitle.Location = New System.Drawing.Point(235, 29)
        Me.lblMathInstructionsTitle.Name = "lblMathInstructionsTitle"
        Me.lblMathInstructionsTitle.Size = New System.Drawing.Size(284, 48)
        Me.lblMathInstructionsTitle.TabIndex = 69
        Me.lblMathInstructionsTitle.Text = "Instructions"
        '
        'cmdGiveUpExample
        '
        Me.cmdGiveUpExample.BackColor = System.Drawing.Color.Red
        Me.cmdGiveUpExample.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGiveUpExample.Location = New System.Drawing.Point(115, 246)
        Me.cmdGiveUpExample.Name = "cmdGiveUpExample"
        Me.cmdGiveUpExample.Size = New System.Drawing.Size(124, 33)
        Me.cmdGiveUpExample.TabIndex = 4
        Me.cmdGiveUpExample.Text = "Give Up"
        Me.cmdGiveUpExample.UseVisualStyleBackColor = False
        '
        'cmdNextExample
        '
        Me.cmdNextExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdNextExample.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNextExample.Location = New System.Drawing.Point(501, 242)
        Me.cmdNextExample.Name = "cmdNextExample"
        Me.cmdNextExample.Size = New System.Drawing.Size(124, 33)
        Me.cmdNextExample.TabIndex = 5
        Me.cmdNextExample.Text = "Next"
        Me.cmdNextExample.UseVisualStyleBackColor = False
        '
        'cmdVerifyExample
        '
        Me.cmdVerifyExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdVerifyExample.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerifyExample.Location = New System.Drawing.Point(584, 140)
        Me.cmdVerifyExample.Name = "cmdVerifyExample"
        Me.cmdVerifyExample.Size = New System.Drawing.Size(124, 33)
        Me.cmdVerifyExample.TabIndex = 3
        Me.cmdVerifyExample.Text = "Verify Answer"
        Me.cmdVerifyExample.UseVisualStyleBackColor = False
        '
        'lblPercentNum
        '
        Me.lblPercentNum.AutoSize = True
        Me.lblPercentNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPercentNum.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentNum.Location = New System.Drawing.Point(614, 398)
        Me.lblPercentNum.Name = "lblPercentNum"
        Me.lblPercentNum.Size = New System.Drawing.Size(22, 18)
        Me.lblPercentNum.TabIndex = 78
        Me.lblPercentNum.Text = "75"
        '
        'lblIncorrectNum
        '
        Me.lblIncorrectNum.AutoSize = True
        Me.lblIncorrectNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIncorrectNum.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrectNum.Location = New System.Drawing.Point(614, 368)
        Me.lblIncorrectNum.Name = "lblIncorrectNum"
        Me.lblIncorrectNum.Size = New System.Drawing.Size(15, 18)
        Me.lblIncorrectNum.TabIndex = 77
        Me.lblIncorrectNum.Text = "1"
        '
        'lblCorrectNum
        '
        Me.lblCorrectNum.AutoSize = True
        Me.lblCorrectNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCorrectNum.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectNum.Location = New System.Drawing.Point(614, 342)
        Me.lblCorrectNum.Name = "lblCorrectNum"
        Me.lblCorrectNum.Size = New System.Drawing.Size(15, 18)
        Me.lblCorrectNum.TabIndex = 76
        Me.lblCorrectNum.Text = "3"
        '
        'lblPercentTitle
        '
        Me.lblPercentTitle.AutoSize = True
        Me.lblPercentTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPercentTitle.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentTitle.Location = New System.Drawing.Point(481, 398)
        Me.lblPercentTitle.Name = "lblPercentTitle"
        Me.lblPercentTitle.Size = New System.Drawing.Size(63, 18)
        Me.lblPercentTitle.TabIndex = 75
        Me.lblPercentTitle.Text = "Percent"
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIncorrect.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect.Location = New System.Drawing.Point(469, 368)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(75, 18)
        Me.lblIncorrect.TabIndex = 74
        Me.lblIncorrect.Text = "Incorrect"
        '
        'lblCorrectTitle
        '
        Me.lblCorrectTitle.AutoSize = True
        Me.lblCorrectTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCorrectTitle.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectTitle.Location = New System.Drawing.Point(484, 342)
        Me.lblCorrectTitle.Name = "lblCorrectTitle"
        Me.lblCorrectTitle.Size = New System.Drawing.Size(60, 18)
        Me.lblCorrectTitle.TabIndex = 73
        Me.lblCorrectTitle.Text = "Correct"
        '
        'lblPictureInfo
        '
        Me.lblPictureInfo.AutoSize = True
        Me.lblPictureInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPictureInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPictureInfo.Location = New System.Drawing.Point(18, 291)
        Me.lblPictureInfo.Name = "lblPictureInfo"
        Me.lblPictureInfo.Size = New System.Drawing.Size(369, 36)
        Me.lblPictureInfo.TabIndex = 80
        Me.lblPictureInfo.Text = "The picture that is outputed will tell you if you got the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "correct answer or not" & _
    "."
        '
        'picHappy
        '
        Me.picHappy.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picHappy.Image = CType(resources.GetObject("picHappy.Image"), System.Drawing.Image)
        Me.picHappy.Location = New System.Drawing.Point(70, 336)
        Me.picHappy.Name = "picHappy"
        Me.picHappy.Size = New System.Drawing.Size(92, 85)
        Me.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHappy.TabIndex = 81
        Me.picHappy.TabStop = False
        '
        'picSad
        '
        Me.picSad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picSad.Image = CType(resources.GetObject("picSad.Image"), System.Drawing.Image)
        Me.picSad.Location = New System.Drawing.Point(198, 336)
        Me.picSad.Name = "picSad"
        Me.picSad.Size = New System.Drawing.Size(92, 85)
        Me.picSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSad.TabIndex = 82
        Me.picSad.TabStop = False
        '
        'lblUsernameExample
        '
        Me.lblUsernameExample.AutoSize = True
        Me.lblUsernameExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUsernameExample.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameExample.Location = New System.Drawing.Point(71, 503)
        Me.lblUsernameExample.Name = "lblUsernameExample"
        Me.lblUsernameExample.Size = New System.Drawing.Size(182, 18)
        Me.lblUsernameExample.TabIndex = 83
        Me.lblUsernameExample.Text = "Username:            user342"
        '
        'lblGradeExample
        '
        Me.lblGradeExample.AutoSize = True
        Me.lblGradeExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGradeExample.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeExample.Location = New System.Drawing.Point(71, 524)
        Me.lblGradeExample.Name = "lblGradeExample"
        Me.lblGradeExample.Size = New System.Drawing.Size(148, 18)
        Me.lblGradeExample.TabIndex = 84
        Me.lblGradeExample.Text = "Current Grade:      87"
        '
        'lblQuestionsLeftExample
        '
        Me.lblQuestionsLeftExample.AutoSize = True
        Me.lblQuestionsLeftExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblQuestionsLeftExample.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionsLeftExample.Location = New System.Drawing.Point(472, 513)
        Me.lblQuestionsLeftExample.Name = "lblQuestionsLeftExample"
        Me.lblQuestionsLeftExample.Size = New System.Drawing.Size(164, 18)
        Me.lblQuestionsLeftExample.TabIndex = 85
        Me.lblQuestionsLeftExample.Text = "Questions Left:          9"
        '
        'mnuMathIntructions
        '
        Me.mnuMathIntructions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuMathIntructions.Location = New System.Drawing.Point(0, 0)
        Me.mnuMathIntructions.Name = "mnuMathIntructions"
        Me.mnuMathIntructions.Size = New System.Drawing.Size(764, 24)
        Me.mnuMathIntructions.TabIndex = 86
        Me.mnuMathIntructions.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'frmMathInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblQuestionsLeftExample)
        Me.Controls.Add(Me.lblGradeExample)
        Me.Controls.Add(Me.lblUsernameExample)
        Me.Controls.Add(Me.picSad)
        Me.Controls.Add(Me.picHappy)
        Me.Controls.Add(Me.lblPictureInfo)
        Me.Controls.Add(Me.lblPercentNum)
        Me.Controls.Add(Me.lblIncorrectNum)
        Me.Controls.Add(Me.lblCorrectNum)
        Me.Controls.Add(Me.lblPercentTitle)
        Me.Controls.Add(Me.lblIncorrect)
        Me.Controls.Add(Me.lblCorrectTitle)
        Me.Controls.Add(Me.cmdGiveUpExample)
        Me.Controls.Add(Me.cmdNextExample)
        Me.Controls.Add(Me.cmdVerifyExample)
        Me.Controls.Add(Me.lblMathInstructionsTitle)
        Me.Controls.Add(Me.lblUserInfo)
        Me.Controls.Add(Me.lblQuestionLeftInfo)
        Me.Controls.Add(Me.lblScoreInfo)
        Me.Controls.Add(Me.lblNextButtonInfo)
        Me.Controls.Add(Me.lblGiveUpButtonInfo)
        Me.Controls.Add(Me.lblSymExample)
        Me.Controls.Add(Me.txtExample)
        Me.Controls.Add(Me.lblSecNumExample)
        Me.Controls.Add(Me.lblFirstNumExample)
        Me.Controls.Add(Me.lblTextboxandVerifyInfo)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.lblClicktoPlayButtonInfo)
        Me.Controls.Add(Me.mnuMathIntructions)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMathIntructions
        Me.Name = "frmMathInstructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Math Operations Instructions"
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMathIntructions.ResumeLayout(False)
        Me.mnuMathIntructions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClicktoPlayButtonInfo As System.Windows.Forms.Label
    Friend WithEvents cmdPlay As System.Windows.Forms.Button
    Friend WithEvents lblTextboxandVerifyInfo As System.Windows.Forms.Label
    Friend WithEvents lblSecNumExample As System.Windows.Forms.Label
    Friend WithEvents lblFirstNumExample As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents txtExample As System.Windows.Forms.TextBox
    Friend WithEvents lblSymExample As System.Windows.Forms.Label
    Friend WithEvents lblGiveUpButtonInfo As System.Windows.Forms.Label
    Friend WithEvents lblNextButtonInfo As System.Windows.Forms.Label
    Friend WithEvents lblScoreInfo As System.Windows.Forms.Label
    Friend WithEvents lblQuestionLeftInfo As System.Windows.Forms.Label
    Friend WithEvents lblUserInfo As System.Windows.Forms.Label
    Friend WithEvents lblMathInstructionsTitle As System.Windows.Forms.Label
    Friend WithEvents cmdGiveUpExample As System.Windows.Forms.Button
    Friend WithEvents cmdNextExample As System.Windows.Forms.Button
    Friend WithEvents cmdVerifyExample As System.Windows.Forms.Button
    Friend WithEvents lblPercentNum As System.Windows.Forms.Label
    Friend WithEvents lblIncorrectNum As System.Windows.Forms.Label
    Friend WithEvents lblCorrectNum As System.Windows.Forms.Label
    Friend WithEvents lblPercentTitle As System.Windows.Forms.Label
    Friend WithEvents lblIncorrect As System.Windows.Forms.Label
    Friend WithEvents lblCorrectTitle As System.Windows.Forms.Label
    Friend WithEvents lblPictureInfo As System.Windows.Forms.Label
    Friend WithEvents picHappy As System.Windows.Forms.PictureBox
    Friend WithEvents picSad As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsernameExample As System.Windows.Forms.Label
    Friend WithEvents lblGradeExample As System.Windows.Forms.Label
    Friend WithEvents lblQuestionsLeftExample As System.Windows.Forms.Label
    Friend WithEvents mnuMathIntructions As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RectangleShape10 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
