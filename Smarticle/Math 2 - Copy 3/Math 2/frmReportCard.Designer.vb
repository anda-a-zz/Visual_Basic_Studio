<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportCard))
        Me.lblReportCard = New System.Windows.Forms.Label()
        Me.mnuReportCard = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblOverallPercent = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblOverallGradeTitle = New System.Windows.Forms.Label()
        Me.lblUserTitle = New System.Windows.Forms.Label()
        Me.lblRecentGradeTitle = New System.Windows.Forms.Label()
        Me.lblRecentPercent = New System.Windows.Forms.Label()
        Me.lblRecentGrade = New System.Windows.Forms.Label()
        Me.lblOverallGrade = New System.Windows.Forms.Label()
        Me.cmdMarks = New System.Windows.Forms.Button()
        Me.mnuReportCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblReportCard
        '
        Me.lblReportCard.AutoSize = True
        Me.lblReportCard.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportCard.Location = New System.Drawing.Point(238, 37)
        Me.lblReportCard.Name = "lblReportCard"
        Me.lblReportCard.Size = New System.Drawing.Size(276, 48)
        Me.lblReportCard.TabIndex = 30
        Me.lblReportCard.Text = "Report Card"
        '
        'mnuReportCard
        '
        Me.mnuReportCard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuReportCard.Location = New System.Drawing.Point(0, 0)
        Me.mnuReportCard.Name = "mnuReportCard"
        Me.mnuReportCard.Size = New System.Drawing.Size(764, 24)
        Me.mnuReportCard.TabIndex = 31
        Me.mnuReportCard.Text = "MenuStrip1"
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
        'lblOverallPercent
        '
        Me.lblOverallPercent.AutoSize = True
        Me.lblOverallPercent.BackColor = System.Drawing.Color.White
        Me.lblOverallPercent.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverallPercent.Location = New System.Drawing.Point(702, 450)
        Me.lblOverallPercent.Name = "lblOverallPercent"
        Me.lblOverallPercent.Size = New System.Drawing.Size(25, 29)
        Me.lblOverallPercent.TabIndex = 56
        Me.lblOverallPercent.Text = "%"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.White
        Me.lblUserName.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(265, 227)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(63, 29)
        Me.lblUserName.TabIndex = 55
        Me.lblUserName.Text = "User"
        '
        'lblOverallGradeTitle
        '
        Me.lblOverallGradeTitle.AutoSize = True
        Me.lblOverallGradeTitle.BackColor = System.Drawing.Color.White
        Me.lblOverallGradeTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverallGradeTitle.Location = New System.Drawing.Point(53, 450)
        Me.lblOverallGradeTitle.Name = "lblOverallGradeTitle"
        Me.lblOverallGradeTitle.Size = New System.Drawing.Size(189, 29)
        Me.lblOverallGradeTitle.TabIndex = 54
        Me.lblOverallGradeTitle.Text = "Overall Grade:"
        '
        'lblUserTitle
        '
        Me.lblUserTitle.AutoSize = True
        Me.lblUserTitle.BackColor = System.Drawing.Color.White
        Me.lblUserTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserTitle.Location = New System.Drawing.Point(53, 227)
        Me.lblUserTitle.Name = "lblUserTitle"
        Me.lblUserTitle.Size = New System.Drawing.Size(147, 29)
        Me.lblUserTitle.TabIndex = 53
        Me.lblUserTitle.Text = "Username: "
        '
        'lblRecentGradeTitle
        '
        Me.lblRecentGradeTitle.AutoSize = True
        Me.lblRecentGradeTitle.BackColor = System.Drawing.Color.White
        Me.lblRecentGradeTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecentGradeTitle.Location = New System.Drawing.Point(53, 326)
        Me.lblRecentGradeTitle.Name = "lblRecentGradeTitle"
        Me.lblRecentGradeTitle.Size = New System.Drawing.Size(181, 29)
        Me.lblRecentGradeTitle.TabIndex = 57
        Me.lblRecentGradeTitle.Text = "Recent Grade:"
        '
        'lblRecentPercent
        '
        Me.lblRecentPercent.AutoSize = True
        Me.lblRecentPercent.BackColor = System.Drawing.Color.White
        Me.lblRecentPercent.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecentPercent.Location = New System.Drawing.Point(702, 305)
        Me.lblRecentPercent.Name = "lblRecentPercent"
        Me.lblRecentPercent.Size = New System.Drawing.Size(25, 29)
        Me.lblRecentPercent.TabIndex = 58
        Me.lblRecentPercent.Text = "%"
        '
        'lblRecentGrade
        '
        Me.lblRecentGrade.AutoSize = True
        Me.lblRecentGrade.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecentGrade.Location = New System.Drawing.Point(607, 305)
        Me.lblRecentGrade.Name = "lblRecentGrade"
        Me.lblRecentGrade.Size = New System.Drawing.Size(25, 29)
        Me.lblRecentGrade.TabIndex = 59
        Me.lblRecentGrade.Text = "0"
        '
        'lblOverallGrade
        '
        Me.lblOverallGrade.AutoSize = True
        Me.lblOverallGrade.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverallGrade.Location = New System.Drawing.Point(607, 450)
        Me.lblOverallGrade.Name = "lblOverallGrade"
        Me.lblOverallGrade.Size = New System.Drawing.Size(25, 29)
        Me.lblOverallGrade.TabIndex = 60
        Me.lblOverallGrade.Text = "0"
        '
        'cmdMarks
        '
        Me.cmdMarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdMarks.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMarks.Location = New System.Drawing.Point(270, 119)
        Me.cmdMarks.Name = "cmdMarks"
        Me.cmdMarks.Size = New System.Drawing.Size(201, 56)
        Me.cmdMarks.TabIndex = 1
        Me.cmdMarks.Text = "Click to See Your New Marks!"
        Me.cmdMarks.UseVisualStyleBackColor = False
        '
        'frmReportCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdMarks)
        Me.Controls.Add(Me.lblOverallGrade)
        Me.Controls.Add(Me.lblRecentGrade)
        Me.Controls.Add(Me.lblRecentPercent)
        Me.Controls.Add(Me.lblRecentGradeTitle)
        Me.Controls.Add(Me.lblOverallPercent)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblOverallGradeTitle)
        Me.Controls.Add(Me.lblUserTitle)
        Me.Controls.Add(Me.lblReportCard)
        Me.Controls.Add(Me.mnuReportCard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuReportCard
        Me.Name = "frmReportCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Card"
        Me.mnuReportCard.ResumeLayout(False)
        Me.mnuReportCard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReportCard As System.Windows.Forms.Label
    Friend WithEvents mnuReportCard As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblOverallPercent As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblOverallGradeTitle As System.Windows.Forms.Label
    Friend WithEvents lblUserTitle As System.Windows.Forms.Label
    Friend WithEvents lblRecentGradeTitle As System.Windows.Forms.Label
    Friend WithEvents lblRecentPercent As System.Windows.Forms.Label
    Friend WithEvents lblRecentGrade As System.Windows.Forms.Label
    Friend WithEvents lblOverallGrade As System.Windows.Forms.Label
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdMarks As System.Windows.Forms.Button
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
