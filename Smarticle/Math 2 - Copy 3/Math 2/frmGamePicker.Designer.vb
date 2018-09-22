<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGamePicker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGamePicker))
        Me.cmdMath = New System.Windows.Forms.Button()
        Me.cmdReadtheWords = New System.Windows.Forms.Button()
        Me.mnuPickaGame = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblGamePickerTitle = New System.Windows.Forms.Label()
        Me.cmdLessEqualsMore = New System.Windows.Forms.Button()
        Me.cmdLostLetter = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblMathQuestionsInfo = New System.Windows.Forms.Label()
        Me.lblReadtheWordsInfo = New System.Windows.Forms.Label()
        Me.lblSimonSaysInfo = New System.Windows.Forms.Label()
        Me.lblMissingLetterInfo = New System.Windows.Forms.Label()
        Me.mnuPickaGame.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdMath
        '
        Me.cmdMath.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdMath.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMath.Location = New System.Drawing.Point(97, 119)
        Me.cmdMath.Name = "cmdMath"
        Me.cmdMath.Size = New System.Drawing.Size(204, 60)
        Me.cmdMath.TabIndex = 1
        Me.cmdMath.Text = "Math Questions"
        Me.cmdMath.UseVisualStyleBackColor = False
        '
        'cmdReadtheWords
        '
        Me.cmdReadtheWords.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdReadtheWords.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReadtheWords.Location = New System.Drawing.Point(465, 119)
        Me.cmdReadtheWords.Name = "cmdReadtheWords"
        Me.cmdReadtheWords.Size = New System.Drawing.Size(204, 60)
        Me.cmdReadtheWords.TabIndex = 2
        Me.cmdReadtheWords.Text = "Read the Words"
        Me.cmdReadtheWords.UseVisualStyleBackColor = False
        '
        'mnuPickaGame
        '
        Me.mnuPickaGame.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuPickaGame.Location = New System.Drawing.Point(0, 0)
        Me.mnuPickaGame.Name = "mnuPickaGame"
        Me.mnuPickaGame.Size = New System.Drawing.Size(764, 24)
        Me.mnuPickaGame.TabIndex = 2
        Me.mnuPickaGame.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
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
        'lblGamePickerTitle
        '
        Me.lblGamePickerTitle.AutoSize = True
        Me.lblGamePickerTitle.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamePickerTitle.Location = New System.Drawing.Point(221, 40)
        Me.lblGamePickerTitle.Name = "lblGamePickerTitle"
        Me.lblGamePickerTitle.Size = New System.Drawing.Size(299, 48)
        Me.lblGamePickerTitle.TabIndex = 3
        Me.lblGamePickerTitle.Text = "Pick a Game!"
        '
        'cmdLessEqualsMore
        '
        Me.cmdLessEqualsMore.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLessEqualsMore.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLessEqualsMore.Location = New System.Drawing.Point(97, 345)
        Me.cmdLessEqualsMore.Name = "cmdLessEqualsMore"
        Me.cmdLessEqualsMore.Size = New System.Drawing.Size(204, 60)
        Me.cmdLessEqualsMore.TabIndex = 3
        Me.cmdLessEqualsMore.Text = "Less, Equals, More"
        Me.cmdLessEqualsMore.UseVisualStyleBackColor = False
        '
        'cmdLostLetter
        '
        Me.cmdLostLetter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLostLetter.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLostLetter.Location = New System.Drawing.Point(465, 345)
        Me.cmdLostLetter.Name = "cmdLostLetter"
        Me.cmdLostLetter.Size = New System.Drawing.Size(204, 60)
        Me.cmdLostLetter.TabIndex = 4
        Me.cmdLostLetter.Text = "Lost Letter"
        Me.cmdLostLetter.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape2, Me.RectangleShape1, Me.RectangleShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(764, 562)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape4.Location = New System.Drawing.Point(391, 333)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(345, 208)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.Location = New System.Drawing.Point(390, 103)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(345, 208)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(25, 103)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(345, 208)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.Location = New System.Drawing.Point(26, 332)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(345, 208)
        '
        'lblMathQuestionsInfo
        '
        Me.lblMathQuestionsInfo.AutoSize = True
        Me.lblMathQuestionsInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMathQuestionsInfo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMathQuestionsInfo.Location = New System.Drawing.Point(87, 182)
        Me.lblMathQuestionsInfo.Name = "lblMathQuestionsInfo"
        Me.lblMathQuestionsInfo.Size = New System.Drawing.Size(231, 96)
        Me.lblMathQuestionsInfo.TabIndex = 7
        Me.lblMathQuestionsInfo.Text = "Addition! Subtraction! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Multiplication! Division!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test your arthmetic skills!" & _
    ""
        Me.lblMathQuestionsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReadtheWordsInfo
        '
        Me.lblReadtheWordsInfo.AutoSize = True
        Me.lblReadtheWordsInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblReadtheWordsInfo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReadtheWordsInfo.Location = New System.Drawing.Point(409, 182)
        Me.lblReadtheWordsInfo.Name = "lblReadtheWordsInfo"
        Me.lblReadtheWordsInfo.Size = New System.Drawing.Size(312, 96)
        Me.lblReadtheWordsInfo.TabIndex = 8
        Me.lblReadtheWordsInfo.Text = "It's red! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "...or is it blue?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test your colour and location skills!"
        Me.lblReadtheWordsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSimonSaysInfo
        '
        Me.lblSimonSaysInfo.AutoSize = True
        Me.lblSimonSaysInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSimonSaysInfo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimonSaysInfo.Location = New System.Drawing.Point(87, 408)
        Me.lblSimonSaysInfo.Name = "lblSimonSaysInfo"
        Me.lblSimonSaysInfo.Size = New System.Drawing.Size(226, 96)
        Me.lblSimonSaysInfo.TabIndex = 9
        Me.lblSimonSaysInfo.Text = "Greater than! Less that!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Equal to!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test your aritmetic skills!"
        Me.lblSimonSaysInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMissingLetterInfo
        '
        Me.lblMissingLetterInfo.AutoSize = True
        Me.lblMissingLetterInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMissingLetterInfo.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissingLetterInfo.Location = New System.Drawing.Point(409, 408)
        Me.lblMissingLetterInfo.Name = "lblMissingLetterInfo"
        Me.lblMissingLetterInfo.Size = New System.Drawing.Size(309, 96)
        Me.lblMissingLetterInfo.TabIndex = 10
        Me.lblMissingLetterInfo.Text = "AL_UM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It's B!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test your language and word skills!"
        Me.lblMissingLetterInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGamePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMissingLetterInfo)
        Me.Controls.Add(Me.lblSimonSaysInfo)
        Me.Controls.Add(Me.lblReadtheWordsInfo)
        Me.Controls.Add(Me.lblMathQuestionsInfo)
        Me.Controls.Add(Me.cmdLostLetter)
        Me.Controls.Add(Me.cmdLessEqualsMore)
        Me.Controls.Add(Me.lblGamePickerTitle)
        Me.Controls.Add(Me.cmdReadtheWords)
        Me.Controls.Add(Me.cmdMath)
        Me.Controls.Add(Me.mnuPickaGame)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuPickaGame
        Me.Name = "frmGamePicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Which Game?"
        Me.mnuPickaGame.ResumeLayout(False)
        Me.mnuPickaGame.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdMath As System.Windows.Forms.Button
    Friend WithEvents cmdReadtheWords As System.Windows.Forms.Button
    Friend WithEvents mnuPickaGame As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblGamePickerTitle As System.Windows.Forms.Label
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLessEqualsMore As System.Windows.Forms.Button
    Friend WithEvents cmdLostLetter As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblMathQuestionsInfo As System.Windows.Forms.Label
    Friend WithEvents lblReadtheWordsInfo As System.Windows.Forms.Label
    Friend WithEvents lblSimonSaysInfo As System.Windows.Forms.Label
    Friend WithEvents lblMissingLetterInfo As System.Windows.Forms.Label
End Class
