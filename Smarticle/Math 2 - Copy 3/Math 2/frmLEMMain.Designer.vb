<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLEMMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLEMMain))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnuLEMMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shpDesignBoxMain = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.rdoLevel1 = New System.Windows.Forms.RadioButton()
        Me.rdoLevel2 = New System.Windows.Forms.RadioButton()
        Me.rdoLevel3 = New System.Windows.Forms.RadioButton()
        Me.grpLEM = New System.Windows.Forms.GroupBox()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.mnuLEMMain.SuspendLayout()
        Me.grpLEM.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(162, 46)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(422, 48)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Less, Equals, More"
        '
        'mnuLEMMain
        '
        Me.mnuLEMMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuLEMMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuLEMMain.Name = "mnuLEMMain"
        Me.mnuLEMMain.Size = New System.Drawing.Size(764, 24)
        Me.mnuLEMMain.TabIndex = 3
        Me.mnuLEMMain.Text = "MenuStrip1"
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shpDesignBoxMain})
        Me.ShapeContainer1.Size = New System.Drawing.Size(764, 562)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'shpDesignBoxMain
        '
        Me.shpDesignBoxMain.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.shpDesignBoxMain.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shpDesignBoxMain.Location = New System.Drawing.Point(85, 148)
        Me.shpDesignBoxMain.Name = "shpDesignBoxMain"
        Me.shpDesignBoxMain.Size = New System.Drawing.Size(583, 363)
        '
        'cmdPlay
        '
        Me.cmdPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdPlay.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlay.Location = New System.Drawing.Point(328, 443)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(95, 34)
        Me.cmdPlay.TabIndex = 25
        Me.cmdPlay.Text = "Play"
        Me.cmdPlay.UseVisualStyleBackColor = False
        '
        'rdoLevel1
        '
        Me.rdoLevel1.AutoSize = True
        Me.rdoLevel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdoLevel1.Checked = True
        Me.rdoLevel1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLevel1.Location = New System.Drawing.Point(10, 42)
        Me.rdoLevel1.Name = "rdoLevel1"
        Me.rdoLevel1.Size = New System.Drawing.Size(97, 28)
        Me.rdoLevel1.TabIndex = 26
        Me.rdoLevel1.TabStop = True
        Me.rdoLevel1.Text = "Level 1"
        Me.rdoLevel1.UseVisualStyleBackColor = False
        '
        'rdoLevel2
        '
        Me.rdoLevel2.AutoSize = True
        Me.rdoLevel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdoLevel2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLevel2.Location = New System.Drawing.Point(162, 42)
        Me.rdoLevel2.Name = "rdoLevel2"
        Me.rdoLevel2.Size = New System.Drawing.Size(97, 28)
        Me.rdoLevel2.TabIndex = 27
        Me.rdoLevel2.Text = "Level 2"
        Me.rdoLevel2.UseVisualStyleBackColor = False
        '
        'rdoLevel3
        '
        Me.rdoLevel3.AutoSize = True
        Me.rdoLevel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdoLevel3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLevel3.Location = New System.Drawing.Point(305, 42)
        Me.rdoLevel3.Name = "rdoLevel3"
        Me.rdoLevel3.Size = New System.Drawing.Size(97, 28)
        Me.rdoLevel3.TabIndex = 28
        Me.rdoLevel3.Text = "Level 3"
        Me.rdoLevel3.UseVisualStyleBackColor = False
        '
        'grpLEM
        '
        Me.grpLEM.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpLEM.Controls.Add(Me.rdoLevel1)
        Me.grpLEM.Controls.Add(Me.rdoLevel3)
        Me.grpLEM.Controls.Add(Me.rdoLevel2)
        Me.grpLEM.Location = New System.Drawing.Point(170, 265)
        Me.grpLEM.Name = "grpLEM"
        Me.grpLEM.Size = New System.Drawing.Size(426, 100)
        Me.grpLEM.TabIndex = 29
        Me.grpLEM.TabStop = False
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDifficulty.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty.Location = New System.Drawing.Point(173, 261)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(110, 24)
        Me.lblDifficulty.TabIndex = 29
        Me.lblDifficulty.Text = "Difficulty:"
        '
        'frmLEMMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.grpLEM)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuLEMMain)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuLEMMain
        Me.Name = "frmLEMMain"
        Me.Text = "Less, Equals, More"
        Me.mnuLEMMain.ResumeLayout(False)
        Me.mnuLEMMain.PerformLayout()
        Me.grpLEM.ResumeLayout(False)
        Me.grpLEM.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents mnuLEMMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents shpDesignBoxMain As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents cmdPlay As System.Windows.Forms.Button
    Friend WithEvents rdoLevel1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLevel2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLevel3 As System.Windows.Forms.RadioButton
    Friend WithEvents grpLEM As System.Windows.Forms.GroupBox
    Friend WithEvents lblDifficulty As System.Windows.Forms.Label
End Class
