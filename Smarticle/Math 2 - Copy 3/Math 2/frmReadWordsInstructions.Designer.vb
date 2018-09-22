<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReadWordsInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReadWordsInstructions))
        Me.lblMathInstructionsTitle = New System.Windows.Forms.Label()
        Me.mnuReadWordsMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.lblClicktoPlayButtonInfo = New System.Windows.Forms.Label()
        Me.cmdVerifyExample = New System.Windows.Forms.Button()
        Me.lblTextboxandVerifyInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExample = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblWordExample = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdGiveUpExample = New System.Windows.Forms.Button()
        Me.cmdNextExample = New System.Windows.Forms.Button()
        Me.lblGiveUpButtonInfo = New System.Windows.Forms.Label()
        Me.picSad = New System.Windows.Forms.PictureBox()
        Me.picHappy = New System.Windows.Forms.PictureBox()
        Me.lblPictureInfo = New System.Windows.Forms.Label()
        Me.lblScoreInfo = New System.Windows.Forms.Label()
        Me.lblPercentNum = New System.Windows.Forms.Label()
        Me.lblIncorrectNum = New System.Windows.Forms.Label()
        Me.lblCorrectNum = New System.Windows.Forms.Label()
        Me.lblPercentTitle = New System.Windows.Forms.Label()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.lblCorrectTitle = New System.Windows.Forms.Label()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.lblGradeExample = New System.Windows.Forms.Label()
        Me.lblUsernameExample = New System.Windows.Forms.Label()
        Me.lblQuestionsLeftExample = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mnuReadWordsMenu.SuspendLayout()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMathInstructionsTitle
        '
        Me.lblMathInstructionsTitle.AutoSize = True
        Me.lblMathInstructionsTitle.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMathInstructionsTitle.Location = New System.Drawing.Point(240, 28)
        Me.lblMathInstructionsTitle.Name = "lblMathInstructionsTitle"
        Me.lblMathInstructionsTitle.Size = New System.Drawing.Size(284, 48)
        Me.lblMathInstructionsTitle.TabIndex = 70
        Me.lblMathInstructionsTitle.Text = "Instructions"
        '
        'mnuReadWordsMenu
        '
        Me.mnuReadWordsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuReadWordsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuReadWordsMenu.Name = "mnuReadWordsMenu"
        Me.mnuReadWordsMenu.Size = New System.Drawing.Size(764, 24)
        Me.mnuReadWordsMenu.TabIndex = 71
        Me.mnuReadWordsMenu.Text = "MenuStrip1"
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
        'cmdPlay
        '
        Me.cmdPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdPlay.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlay.Location = New System.Drawing.Point(133, 185)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(107, 36)
        Me.cmdPlay.TabIndex = 1
        Me.cmdPlay.Text = "Click to Play!"
        Me.cmdPlay.UseVisualStyleBackColor = False
        '
        'lblClicktoPlayButtonInfo
        '
        Me.lblClicktoPlayButtonInfo.AutoSize = True
        Me.lblClicktoPlayButtonInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblClicktoPlayButtonInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClicktoPlayButtonInfo.Location = New System.Drawing.Point(24, 163)
        Me.lblClicktoPlayButtonInfo.Name = "lblClicktoPlayButtonInfo"
        Me.lblClicktoPlayButtonInfo.Size = New System.Drawing.Size(311, 18)
        Me.lblClicktoPlayButtonInfo.TabIndex = 72
        Me.lblClicktoPlayButtonInfo.Text = "Click the ""Click to Play"" to begin the program."
        '
        'cmdVerifyExample
        '
        Me.cmdVerifyExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdVerifyExample.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerifyExample.Location = New System.Drawing.Point(137, 327)
        Me.cmdVerifyExample.Name = "cmdVerifyExample"
        Me.cmdVerifyExample.Size = New System.Drawing.Size(124, 33)
        Me.cmdVerifyExample.TabIndex = 4
        Me.cmdVerifyExample.Text = "Verify Answer"
        Me.cmdVerifyExample.UseVisualStyleBackColor = False
        '
        'lblTextboxandVerifyInfo
        '
        Me.lblTextboxandVerifyInfo.AutoSize = True
        Me.lblTextboxandVerifyInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTextboxandVerifyInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextboxandVerifyInfo.Location = New System.Drawing.Point(376, 163)
        Me.lblTextboxandVerifyInfo.Name = "lblTextboxandVerifyInfo"
        Me.lblTextboxandVerifyInfo.Size = New System.Drawing.Size(293, 18)
        Me.lblTextboxandVerifyInfo.TabIndex = 74
        Me.lblTextboxandVerifyInfo.Text = "Answer the question into the textbox below."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 72)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "If the question is..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Colour?     Answer with the colour of the word" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Word?     " & _
    " Answer with the word" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Location?  Answer with the location of the word" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtExample
        '
        Me.txtExample.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExample.Location = New System.Drawing.Point(515, 189)
        Me.txtExample.MaxLength = 2
        Me.txtExample.Name = "txtExample"
        Me.txtExample.Size = New System.Drawing.Size(91, 28)
        Me.txtExample.TabIndex = 2
        Me.txtExample.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape9, Me.RectangleShape8, Me.RectangleShape7, Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape6, Me.RectangleShape10})
        Me.ShapeContainer1.Size = New System.Drawing.Size(764, 562)
        Me.ShapeContainer1.TabIndex = 78
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BackColor = System.Drawing.Color.White
        Me.RectangleShape9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape9.Location = New System.Drawing.Point(576, 80)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(168, 52)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape8.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape8.Location = New System.Drawing.Point(13, 77)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(739, 79)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape7.Location = New System.Drawing.Point(13, 162)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(740, 64)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape5.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape5.Location = New System.Drawing.Point(12, 231)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(741, 131)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape4.Location = New System.Drawing.Point(431, 512)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(222, 38)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.Location = New System.Drawing.Point(430, 434)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(224, 47)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.Location = New System.Drawing.Point(58, 512)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(206, 38)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape6.Location = New System.Drawing.Point(59, 448)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(206, 61)
        '
        'RectangleShape10
        '
        Me.RectangleShape10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape10.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape10.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape10.Location = New System.Drawing.Point(11, 368)
        Me.RectangleShape10.Name = "RectangleShape10"
        Me.RectangleShape10.Size = New System.Drawing.Size(742, 187)
        '
        'lblWordExample
        '
        Me.lblWordExample.AutoSize = True
        Me.lblWordExample.BackColor = System.Drawing.Color.White
        Me.lblWordExample.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWordExample.ForeColor = System.Drawing.Color.Yellow
        Me.lblWordExample.Location = New System.Drawing.Point(630, 88)
        Me.lblWordExample.Name = "lblWordExample"
        Me.lblWordExample.Size = New System.Drawing.Size(53, 21)
        Me.lblWordExample.TabIndex = 79
        Me.lblWordExample.Text = "RED"
        Me.lblWordExample.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(376, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 54)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Look in the top rectangle to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "see the word needed to be " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "described." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(576, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 18)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "C: yellow W: red L: top" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdGiveUpExample
        '
        Me.cmdGiveUpExample.BackColor = System.Drawing.Color.Red
        Me.cmdGiveUpExample.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGiveUpExample.Location = New System.Drawing.Point(267, 327)
        Me.cmdGiveUpExample.Name = "cmdGiveUpExample"
        Me.cmdGiveUpExample.Size = New System.Drawing.Size(102, 33)
        Me.cmdGiveUpExample.TabIndex = 5
        Me.cmdGiveUpExample.Text = "Give Up"
        Me.cmdGiveUpExample.UseVisualStyleBackColor = False
        '
        'cmdNextExample
        '
        Me.cmdNextExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdNextExample.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNextExample.Location = New System.Drawing.Point(27, 327)
        Me.cmdNextExample.Name = "cmdNextExample"
        Me.cmdNextExample.Size = New System.Drawing.Size(104, 33)
        Me.cmdNextExample.TabIndex = 3
        Me.cmdNextExample.Text = "Next"
        Me.cmdNextExample.UseVisualStyleBackColor = False
        '
        'lblGiveUpButtonInfo
        '
        Me.lblGiveUpButtonInfo.AutoSize = True
        Me.lblGiveUpButtonInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblGiveUpButtonInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiveUpButtonInfo.Location = New System.Drawing.Point(24, 234)
        Me.lblGiveUpButtonInfo.Name = "lblGiveUpButtonInfo"
        Me.lblGiveUpButtonInfo.Size = New System.Drawing.Size(356, 90)
        Me.lblGiveUpButtonInfo.TabIndex = 82
        Me.lblGiveUpButtonInfo.Text = "Click the ""verify answer"" button once you have " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "inputed an answer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the ""gi" & _
    "ve up"" button once you have given up on " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the question" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the ""next"" button " & _
    "to go to the next question"
        '
        'picSad
        '
        Me.picSad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picSad.Image = CType(resources.GetObject("picSad.Image"), System.Drawing.Image)
        Me.picSad.Location = New System.Drawing.Point(598, 275)
        Me.picSad.Name = "picSad"
        Me.picSad.Size = New System.Drawing.Size(92, 85)
        Me.picSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSad.TabIndex = 88
        Me.picSad.TabStop = False
        '
        'picHappy
        '
        Me.picHappy.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picHappy.Image = CType(resources.GetObject("picHappy.Image"), System.Drawing.Image)
        Me.picHappy.Location = New System.Drawing.Point(460, 275)
        Me.picHappy.Name = "picHappy"
        Me.picHappy.Size = New System.Drawing.Size(92, 85)
        Me.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHappy.TabIndex = 87
        Me.picHappy.TabStop = False
        '
        'lblPictureInfo
        '
        Me.lblPictureInfo.AutoSize = True
        Me.lblPictureInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPictureInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPictureInfo.Location = New System.Drawing.Point(376, 234)
        Me.lblPictureInfo.Name = "lblPictureInfo"
        Me.lblPictureInfo.Size = New System.Drawing.Size(369, 36)
        Me.lblPictureInfo.TabIndex = 86
        Me.lblPictureInfo.Text = "The picture that is outputed will tell you if you got the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "correct answer or not" & _
    "."
        '
        'lblScoreInfo
        '
        Me.lblScoreInfo.AutoSize = True
        Me.lblScoreInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblScoreInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreInfo.Location = New System.Drawing.Point(24, 371)
        Me.lblScoreInfo.Name = "lblScoreInfo"
        Me.lblScoreInfo.Size = New System.Drawing.Size(352, 72)
        Me.lblScoreInfo.TabIndex = 89
        Me.lblScoreInfo.Text = "The scoreboard will tell you how many you got right " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and wrong, and the current " & _
    "percentage." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The questions left bar will tell you how many " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "questions you have " & _
    "left to answer."
        '
        'lblPercentNum
        '
        Me.lblPercentNum.AutoSize = True
        Me.lblPercentNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPercentNum.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentNum.Location = New System.Drawing.Point(225, 487)
        Me.lblPercentNum.Name = "lblPercentNum"
        Me.lblPercentNum.Size = New System.Drawing.Size(22, 18)
        Me.lblPercentNum.TabIndex = 95
        Me.lblPercentNum.Text = "75"
        '
        'lblIncorrectNum
        '
        Me.lblIncorrectNum.AutoSize = True
        Me.lblIncorrectNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIncorrectNum.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrectNum.Location = New System.Drawing.Point(225, 469)
        Me.lblIncorrectNum.Name = "lblIncorrectNum"
        Me.lblIncorrectNum.Size = New System.Drawing.Size(15, 18)
        Me.lblIncorrectNum.TabIndex = 94
        Me.lblIncorrectNum.Text = "1"
        '
        'lblCorrectNum
        '
        Me.lblCorrectNum.AutoSize = True
        Me.lblCorrectNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCorrectNum.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectNum.Location = New System.Drawing.Point(225, 451)
        Me.lblCorrectNum.Name = "lblCorrectNum"
        Me.lblCorrectNum.Size = New System.Drawing.Size(15, 18)
        Me.lblCorrectNum.TabIndex = 93
        Me.lblCorrectNum.Text = "3"
        '
        'lblPercentTitle
        '
        Me.lblPercentTitle.AutoSize = True
        Me.lblPercentTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPercentTitle.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentTitle.Location = New System.Drawing.Point(92, 487)
        Me.lblPercentTitle.Name = "lblPercentTitle"
        Me.lblPercentTitle.Size = New System.Drawing.Size(63, 18)
        Me.lblPercentTitle.TabIndex = 92
        Me.lblPercentTitle.Text = "Percent"
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIncorrect.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect.Location = New System.Drawing.Point(80, 469)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(75, 18)
        Me.lblIncorrect.TabIndex = 91
        Me.lblIncorrect.Text = "Incorrect"
        '
        'lblCorrectTitle
        '
        Me.lblCorrectTitle.AutoSize = True
        Me.lblCorrectTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCorrectTitle.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectTitle.Location = New System.Drawing.Point(95, 451)
        Me.lblCorrectTitle.Name = "lblCorrectTitle"
        Me.lblCorrectTitle.Size = New System.Drawing.Size(60, 18)
        Me.lblCorrectTitle.TabIndex = 90
        Me.lblCorrectTitle.Text = "Correct"
        '
        'lblUserInfo
        '
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUserInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInfo.Location = New System.Drawing.Point(392, 371)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(344, 54)
        Me.lblUserInfo.TabIndex = 96
        Me.lblUserInfo.Text = "In the ""User Information"" box, your username and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your current percentage, from " & _
    "playing other games, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will be recorded for you to see."
        '
        'lblGradeExample
        '
        Me.lblGradeExample.AutoSize = True
        Me.lblGradeExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGradeExample.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeExample.Location = New System.Drawing.Point(458, 459)
        Me.lblGradeExample.Name = "lblGradeExample"
        Me.lblGradeExample.Size = New System.Drawing.Size(148, 18)
        Me.lblGradeExample.TabIndex = 98
        Me.lblGradeExample.Text = "Current Grade:      87"
        '
        'lblUsernameExample
        '
        Me.lblUsernameExample.AutoSize = True
        Me.lblUsernameExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUsernameExample.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameExample.Location = New System.Drawing.Point(458, 437)
        Me.lblUsernameExample.Name = "lblUsernameExample"
        Me.lblUsernameExample.Size = New System.Drawing.Size(182, 18)
        Me.lblUsernameExample.TabIndex = 97
        Me.lblUsernameExample.Text = "Username:            user342"
        '
        'lblQuestionsLeftExample
        '
        Me.lblQuestionsLeftExample.AutoSize = True
        Me.lblQuestionsLeftExample.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblQuestionsLeftExample.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionsLeftExample.Location = New System.Drawing.Point(77, 523)
        Me.lblQuestionsLeftExample.Name = "lblQuestionsLeftExample"
        Me.lblQuestionsLeftExample.Size = New System.Drawing.Size(164, 18)
        Me.lblQuestionsLeftExample.TabIndex = 99
        Me.lblQuestionsLeftExample.Text = "Questions Left:          9"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(392, 488)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(311, 18)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "The time is used to cut you off after 5 seconds."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(457, 523)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 18)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Time                   3"
        '
        'frmReadWordsInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblQuestionsLeftExample)
        Me.Controls.Add(Me.lblGradeExample)
        Me.Controls.Add(Me.lblUsernameExample)
        Me.Controls.Add(Me.lblUserInfo)
        Me.Controls.Add(Me.lblPercentNum)
        Me.Controls.Add(Me.lblIncorrectNum)
        Me.Controls.Add(Me.lblCorrectNum)
        Me.Controls.Add(Me.lblPercentTitle)
        Me.Controls.Add(Me.lblIncorrect)
        Me.Controls.Add(Me.lblCorrectTitle)
        Me.Controls.Add(Me.lblScoreInfo)
        Me.Controls.Add(Me.picSad)
        Me.Controls.Add(Me.picHappy)
        Me.Controls.Add(Me.lblPictureInfo)
        Me.Controls.Add(Me.cmdGiveUpExample)
        Me.Controls.Add(Me.cmdNextExample)
        Me.Controls.Add(Me.lblGiveUpButtonInfo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblWordExample)
        Me.Controls.Add(Me.txtExample)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdVerifyExample)
        Me.Controls.Add(Me.lblTextboxandVerifyInfo)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.lblClicktoPlayButtonInfo)
        Me.Controls.Add(Me.lblMathInstructionsTitle)
        Me.Controls.Add(Me.mnuReadWordsMenu)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuReadWordsMenu
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReadWordsInstructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Read the Words Instructions"
        Me.mnuReadWordsMenu.ResumeLayout(False)
        Me.mnuReadWordsMenu.PerformLayout()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMathInstructionsTitle As System.Windows.Forms.Label
    Friend WithEvents mnuReadWordsMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPlay As System.Windows.Forms.Button
    Friend WithEvents lblClicktoPlayButtonInfo As System.Windows.Forms.Label
    Friend WithEvents cmdVerifyExample As System.Windows.Forms.Button
    Friend WithEvents lblTextboxandVerifyInfo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtExample As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lblWordExample As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdGiveUpExample As System.Windows.Forms.Button
    Friend WithEvents cmdNextExample As System.Windows.Forms.Button
    Friend WithEvents lblGiveUpButtonInfo As System.Windows.Forms.Label
    Friend WithEvents picSad As System.Windows.Forms.PictureBox
    Friend WithEvents picHappy As System.Windows.Forms.PictureBox
    Friend WithEvents lblPictureInfo As System.Windows.Forms.Label
    Friend WithEvents lblScoreInfo As System.Windows.Forms.Label
    Friend WithEvents lblPercentNum As System.Windows.Forms.Label
    Friend WithEvents lblIncorrectNum As System.Windows.Forms.Label
    Friend WithEvents lblCorrectNum As System.Windows.Forms.Label
    Friend WithEvents lblPercentTitle As System.Windows.Forms.Label
    Friend WithEvents lblIncorrect As System.Windows.Forms.Label
    Friend WithEvents lblCorrectTitle As System.Windows.Forms.Label
    Friend WithEvents lblUserInfo As System.Windows.Forms.Label
    Friend WithEvents lblGradeExample As System.Windows.Forms.Label
    Friend WithEvents lblUsernameExample As System.Windows.Forms.Label
    Friend WithEvents lblQuestionsLeftExample As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape10 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape9 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
