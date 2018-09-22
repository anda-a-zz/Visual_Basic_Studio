<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLostLetterInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLostLetterInstructions))
        Me.lblInstructionsTitle = New System.Windows.Forms.Label()
        Me.mnuInstructions = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.shpDesignBox1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpDesignBox3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpDesignBox2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblInstructions1 = New System.Windows.Forms.Label()
        Me.lblInstructions2 = New System.Windows.Forms.Label()
        Me.lblInstructions3 = New System.Windows.Forms.Label()
        Me.lblInstructions4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblInstructions5 = New System.Windows.Forms.Label()
        Me.lbInstructions6 = New System.Windows.Forms.Label()
        Me.lblInstructions7 = New System.Windows.Forms.Label()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblInstruct1 = New System.Windows.Forms.Label()
        Me.picSmile = New System.Windows.Forms.PictureBox()
        Me.picFrown = New System.Windows.Forms.PictureBox()
        Me.lbInstruct2 = New System.Windows.Forms.Label()
        Me.lblInstruct3 = New System.Windows.Forms.Label()
        Me.lblInstruct4 = New System.Windows.Forms.Label()
        Me.lbInstruct5 = New System.Windows.Forms.Label()
        Me.lblInstruct6 = New System.Windows.Forms.Label()
        Me.lblOutOf = New System.Windows.Forms.Label()
        Me.lblInstruct7 = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblInstruct8 = New System.Windows.Forms.Label()
        Me.lblDiff = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblInstruct9 = New System.Windows.Forms.Label()
        Me.lblInstruct10 = New System.Windows.Forms.Label()
        Me.lblInstruct11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mnuInstructions.SuspendLayout()
        CType(Me.picSmile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFrown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstructionsTitle
        '
        Me.lblInstructionsTitle.AutoSize = True
        Me.lblInstructionsTitle.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsTitle.Location = New System.Drawing.Point(229, 42)
        Me.lblInstructionsTitle.Name = "lblInstructionsTitle"
        Me.lblInstructionsTitle.Size = New System.Drawing.Size(284, 48)
        Me.lblInstructionsTitle.TabIndex = 3
        Me.lblInstructionsTitle.Text = "Instructions"
        '
        'mnuInstructions
        '
        Me.mnuInstructions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuInstructions.Location = New System.Drawing.Point(0, 0)
        Me.mnuInstructions.Name = "mnuInstructions"
        Me.mnuInstructions.Size = New System.Drawing.Size(764, 24)
        Me.mnuInstructions.TabIndex = 4
        Me.mnuInstructions.Text = "MenuStrip1"
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
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'shpDesignBox1
        '
        Me.shpDesignBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.shpDesignBox1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shpDesignBox1.Location = New System.Drawing.Point(38, 135)
        Me.shpDesignBox1.Name = "shpDesignBox1"
        Me.shpDesignBox1.Size = New System.Drawing.Size(377, 399)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.shpDesignBox3, Me.RectangleShape1, Me.shpDesignBox2, Me.shpDesignBox1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(764, 562)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(424, 418)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(300, 116)
        '
        'shpDesignBox3
        '
        Me.shpDesignBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.shpDesignBox3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shpDesignBox3.Location = New System.Drawing.Point(424, 135)
        Me.shpDesignBox3.Name = "shpDesignBox3"
        Me.shpDesignBox3.Size = New System.Drawing.Size(299, 274)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.FillColor = System.Drawing.Color.White
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(91, 339)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(270, 31)
        '
        'shpDesignBox2
        '
        Me.shpDesignBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.shpDesignBox2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shpDesignBox2.Location = New System.Drawing.Point(102, 211)
        Me.shpDesignBox2.Name = "shpDesignBox2"
        Me.shpDesignBox2.Size = New System.Drawing.Size(244, 87)
        '
        'lblInstructions1
        '
        Me.lblInstructions1.AutoSize = True
        Me.lblInstructions1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInstructions1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions1.Location = New System.Drawing.Point(44, 147)
        Me.lblInstructions1.Name = "lblInstructions1"
        Me.lblInstructions1.Size = New System.Drawing.Size(370, 24)
        Me.lblInstructions1.TabIndex = 6
        Me.lblInstructions1.Text = "The goal of this game is to figure out what"
        '
        'lblInstructions2
        '
        Me.lblInstructions2.AutoSize = True
        Me.lblInstructions2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInstructions2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions2.Location = New System.Drawing.Point(79, 170)
        Me.lblInstructions2.Name = "lblInstructions2"
        Me.lblInstructions2.Size = New System.Drawing.Size(283, 24)
        Me.lblInstructions2.TabIndex = 7
        Me.lblInstructions2.Text = "the missing letter in the word is."
        '
        'lblInstructions3
        '
        Me.lblInstructions3.AutoSize = True
        Me.lblInstructions3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInstructions3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions3.Location = New System.Drawing.Point(191, 242)
        Me.lblInstructions3.Name = "lblInstructions3"
        Me.lblInstructions3.Size = New System.Drawing.Size(69, 24)
        Me.lblInstructions3.TabIndex = 8
        Me.lblInstructions3.Text = "fr_day"
        '
        'lblInstructions4
        '
        Me.lblInstructions4.AutoSize = True
        Me.lblInstructions4.BackColor = System.Drawing.Color.White
        Me.lblInstructions4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions4.Location = New System.Drawing.Point(95, 344)
        Me.lblInstructions4.Name = "lblInstructions4"
        Me.lblInstructions4.Size = New System.Drawing.Size(17, 24)
        Me.lblInstructions4.TabIndex = 9
        Me.lblInstructions4.Text = "i"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Type your answer in the input box:"
        '
        'lblInstructions5
        '
        Me.lblInstructions5.AutoSize = True
        Me.lblInstructions5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInstructions5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions5.Location = New System.Drawing.Point(43, 408)
        Me.lblInstructions5.Name = "lblInstructions5"
        Me.lblInstructions5.Size = New System.Drawing.Size(289, 21)
        Me.lblInstructions5.TabIndex = 11
        Me.lblInstructions5.Text = "When the time on the side runs out,"
        '
        'lbInstructions6
        '
        Me.lbInstructions6.AutoSize = True
        Me.lbInstructions6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbInstructions6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInstructions6.Location = New System.Drawing.Point(46, 428)
        Me.lbInstructions6.Name = "lbInstructions6"
        Me.lbInstructions6.Size = New System.Drawing.Size(228, 21)
        Me.lbInstructions6.TabIndex = 12
        Me.lbInstructions6.Text = "your answer will be verified."
        '
        'lblInstructions7
        '
        Me.lblInstructions7.AutoSize = True
        Me.lblInstructions7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInstructions7.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions7.Location = New System.Drawing.Point(347, 433)
        Me.lblInstructions7.Name = "lblInstructions7"
        Me.lblInstructions7.Size = New System.Drawing.Size(44, 50)
        Me.lblInstructions7.TabIndex = 13
        Me.lblInstructions7.Text = "5"
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 1000
        '
        'lblInstruct1
        '
        Me.lblInstruct1.AutoSize = True
        Me.lblInstruct1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInstruct1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct1.Location = New System.Drawing.Point(427, 142)
        Me.lblInstruct1.Name = "lblInstruct1"
        Me.lblInstruct1.Size = New System.Drawing.Size(295, 21)
        Me.lblInstruct1.TabIndex = 14
        Me.lblInstruct1.Text = "Depending on your answer you'll see:"
        '
        'picSmile
        '
        Me.picSmile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picSmile.Image = CType(resources.GetObject("picSmile.Image"), System.Drawing.Image)
        Me.picSmile.Location = New System.Drawing.Point(449, 166)
        Me.picSmile.Name = "picSmile"
        Me.picSmile.Size = New System.Drawing.Size(91, 87)
        Me.picSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSmile.TabIndex = 15
        Me.picSmile.TabStop = False
        '
        'picFrown
        '
        Me.picFrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picFrown.Image = CType(resources.GetObject("picFrown.Image"), System.Drawing.Image)
        Me.picFrown.Location = New System.Drawing.Point(607, 166)
        Me.picFrown.Name = "picFrown"
        Me.picFrown.Size = New System.Drawing.Size(91, 87)
        Me.picFrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFrown.TabIndex = 16
        Me.picFrown.TabStop = False
        '
        'lbInstruct2
        '
        Me.lbInstruct2.AutoSize = True
        Me.lbInstruct2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbInstruct2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInstruct2.Location = New System.Drawing.Point(461, 243)
        Me.lbInstruct2.Name = "lbInstruct2"
        Me.lbInstruct2.Size = New System.Drawing.Size(65, 21)
        Me.lbInstruct2.TabIndex = 17
        Me.lbInstruct2.Text = "Correct"
        '
        'lblInstruct3
        '
        Me.lblInstruct3.AutoSize = True
        Me.lblInstruct3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInstruct3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct3.Location = New System.Drawing.Point(612, 244)
        Me.lblInstruct3.Name = "lblInstruct3"
        Me.lblInstruct3.Size = New System.Drawing.Size(81, 21)
        Me.lblInstruct3.TabIndex = 18
        Me.lblInstruct3.Text = "Incorrect"
        '
        'lblInstruct4
        '
        Me.lblInstruct4.AutoSize = True
        Me.lblInstruct4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInstruct4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct4.Location = New System.Drawing.Point(448, 269)
        Me.lblInstruct4.Name = "lblInstruct4"
        Me.lblInstruct4.Size = New System.Drawing.Size(250, 21)
        Me.lblInstruct4.TabIndex = 19
        Me.lblInstruct4.Text = "and your user info will change!"
        '
        'lbInstruct5
        '
        Me.lbInstruct5.AutoSize = True
        Me.lbInstruct5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbInstruct5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInstruct5.Location = New System.Drawing.Point(427, 305)
        Me.lbInstruct5.Name = "lbInstruct5"
        Me.lbInstruct5.Size = New System.Drawing.Size(65, 24)
        Me.lbInstruct5.TabIndex = 20
        Me.lbInstruct5.Text = "Score:"
        '
        'lblInstruct6
        '
        Me.lblInstruct6.AutoSize = True
        Me.lblInstruct6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInstruct6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct6.Location = New System.Drawing.Point(498, 306)
        Me.lblInstruct6.Name = "lblInstruct6"
        Me.lblInstruct6.Size = New System.Drawing.Size(21, 24)
        Me.lblInstruct6.TabIndex = 25
        Me.lblInstruct6.Text = "2"
        '
        'lblOutOf
        '
        Me.lblOutOf.AutoSize = True
        Me.lblOutOf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblOutOf.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutOf.Location = New System.Drawing.Point(522, 305)
        Me.lblOutOf.Name = "lblOutOf"
        Me.lblOutOf.Size = New System.Drawing.Size(18, 25)
        Me.lblOutOf.TabIndex = 26
        Me.lblOutOf.Text = "/"
        '
        'lblInstruct7
        '
        Me.lblInstruct7.AutoSize = True
        Me.lblInstruct7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInstruct7.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct7.Location = New System.Drawing.Point(546, 306)
        Me.lblInstruct7.Name = "lblInstruct7"
        Me.lblInstruct7.Size = New System.Drawing.Size(21, 24)
        Me.lblInstruct7.TabIndex = 27
        Me.lblInstruct7.Text = "3"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblGrade.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(427, 339)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(148, 24)
        Me.lblGrade.TabIndex = 28
        Me.lblGrade.Text = "Current Grade:"
        '
        'lblInstruct8
        '
        Me.lblInstruct8.AutoSize = True
        Me.lblInstruct8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInstruct8.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct8.Location = New System.Drawing.Point(580, 340)
        Me.lblInstruct8.Name = "lblInstruct8"
        Me.lblInstruct8.Size = New System.Drawing.Size(43, 24)
        Me.lblInstruct8.TabIndex = 29
        Me.lblInstruct8.Text = "67%"
        '
        'lblDiff
        '
        Me.lblDiff.AutoSize = True
        Me.lblDiff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDiff.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiff.Location = New System.Drawing.Point(427, 372)
        Me.lblDiff.Name = "lblDiff"
        Me.lblDiff.Size = New System.Drawing.Size(173, 24)
        Me.lblDiff.TabIndex = 30
        Me.lblDiff.Text = "Difficulty:  Hard"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdClose.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(614, 486)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(96, 35)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'lblInstruct9
        '
        Me.lblInstruct9.AutoSize = True
        Me.lblInstruct9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInstruct9.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct9.Location = New System.Drawing.Point(43, 470)
        Me.lblInstruct9.Name = "lblInstruct9"
        Me.lblInstruct9.Size = New System.Drawing.Size(275, 21)
        Me.lblInstruct9.TabIndex = 32
        Me.lblInstruct9.Text = "So as long as the timer has not hit"
        '
        'lblInstruct10
        '
        Me.lblInstruct10.AutoSize = True
        Me.lblInstruct10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInstruct10.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct10.Location = New System.Drawing.Point(42, 491)
        Me.lblInstruct10.Name = "lblInstruct10"
        Me.lblInstruct10.Size = New System.Drawing.Size(250, 21)
        Me.lblInstruct10.TabIndex = 33
        Me.lblInstruct10.Text = "0, you can change your answer!"
        '
        'lblInstruct11
        '
        Me.lblInstruct11.AutoSize = True
        Me.lblInstruct11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInstruct11.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct11.Location = New System.Drawing.Point(436, 428)
        Me.lblInstruct11.Name = "lblInstruct11"
        Me.lblInstruct11.Size = New System.Drawing.Size(275, 21)
        Me.lblInstruct11.TabIndex = 34
        Me.lblInstruct11.Text = "After the answer has been verified"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(437, 449)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 21)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "click ""Next"":"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(441, 479)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmLostLetterInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblInstruct11)
        Me.Controls.Add(Me.lblInstruct10)
        Me.Controls.Add(Me.lblInstruct9)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblDiff)
        Me.Controls.Add(Me.lblInstruct8)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblInstruct7)
        Me.Controls.Add(Me.lblOutOf)
        Me.Controls.Add(Me.lblInstruct6)
        Me.Controls.Add(Me.lbInstruct5)
        Me.Controls.Add(Me.lblInstruct4)
        Me.Controls.Add(Me.lblInstruct3)
        Me.Controls.Add(Me.lbInstruct2)
        Me.Controls.Add(Me.picFrown)
        Me.Controls.Add(Me.picSmile)
        Me.Controls.Add(Me.lblInstruct1)
        Me.Controls.Add(Me.lblInstructions7)
        Me.Controls.Add(Me.lbInstructions6)
        Me.Controls.Add(Me.lblInstructions5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInstructions4)
        Me.Controls.Add(Me.lblInstructions3)
        Me.Controls.Add(Me.lblInstructions2)
        Me.Controls.Add(Me.lblInstructions1)
        Me.Controls.Add(Me.lblInstructionsTitle)
        Me.Controls.Add(Me.mnuInstructions)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuInstructions
        Me.Name = "frmLostLetterInstructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInstructions"
        Me.mnuInstructions.ResumeLayout(False)
        Me.mnuInstructions.PerformLayout()
        CType(Me.picSmile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFrown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInstructionsTitle As System.Windows.Forms.Label
    Friend WithEvents mnuInstructions As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents shpDesignBox1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lblInstructions1 As System.Windows.Forms.Label
    Friend WithEvents lblInstructions2 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shpDesignBox2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblInstructions3 As System.Windows.Forms.Label
    Friend WithEvents lblInstructions4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblInstructions5 As System.Windows.Forms.Label
    Friend WithEvents lbInstructions6 As System.Windows.Forms.Label
    Friend WithEvents lblInstructions7 As System.Windows.Forms.Label
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents shpDesignBox3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblInstruct1 As System.Windows.Forms.Label
    Friend WithEvents picSmile As System.Windows.Forms.PictureBox
    Friend WithEvents picFrown As System.Windows.Forms.PictureBox
    Friend WithEvents lbInstruct2 As System.Windows.Forms.Label
    Friend WithEvents lblInstruct3 As System.Windows.Forms.Label
    Friend WithEvents lblInstruct4 As System.Windows.Forms.Label
    Friend WithEvents lbInstruct5 As System.Windows.Forms.Label
    Friend WithEvents lblInstruct6 As System.Windows.Forms.Label
    Friend WithEvents lblOutOf As System.Windows.Forms.Label
    Friend WithEvents lblInstruct7 As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents lblInstruct8 As System.Windows.Forms.Label
    Friend WithEvents lblDiff As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents lblInstruct9 As System.Windows.Forms.Label
    Friend WithEvents lblInstruct10 As System.Windows.Forms.Label
    Friend WithEvents lblInstruct11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
