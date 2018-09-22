<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.mnuAbout = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCreatedByTitle = New System.Windows.Forms.Label()
        Me.lblDateCreatedTitle = New System.Windows.Forms.Label()
        Me.lblClassCreatedForTitle = New System.Windows.Forms.Label()
        Me.lblAboutTitle = New System.Windows.Forms.Label()
        Me.lblGameMakers = New System.Windows.Forms.Label()
        Me.lblDateCreated = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.mnuAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuAbout
        '
        Me.mnuAbout.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuAbout.Location = New System.Drawing.Point(0, 0)
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(764, 24)
        Me.mnuAbout.TabIndex = 0
        Me.mnuAbout.Text = "MenuStrip1"
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
        'lblCreatedByTitle
        '
        Me.lblCreatedByTitle.AutoSize = True
        Me.lblCreatedByTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblCreatedByTitle.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreatedByTitle.Location = New System.Drawing.Point(66, 163)
        Me.lblCreatedByTitle.Name = "lblCreatedByTitle"
        Me.lblCreatedByTitle.Size = New System.Drawing.Size(161, 31)
        Me.lblCreatedByTitle.TabIndex = 1
        Me.lblCreatedByTitle.Text = "Created By:"
        '
        'lblDateCreatedTitle
        '
        Me.lblDateCreatedTitle.AutoSize = True
        Me.lblDateCreatedTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblDateCreatedTitle.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateCreatedTitle.Location = New System.Drawing.Point(66, 303)
        Me.lblDateCreatedTitle.Name = "lblDateCreatedTitle"
        Me.lblDateCreatedTitle.Size = New System.Drawing.Size(184, 31)
        Me.lblDateCreatedTitle.TabIndex = 2
        Me.lblDateCreatedTitle.Text = "Date Created:"
        '
        'lblClassCreatedForTitle
        '
        Me.lblClassCreatedForTitle.AutoSize = True
        Me.lblClassCreatedForTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblClassCreatedForTitle.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassCreatedForTitle.Location = New System.Drawing.Point(66, 456)
        Me.lblClassCreatedForTitle.Name = "lblClassCreatedForTitle"
        Me.lblClassCreatedForTitle.Size = New System.Drawing.Size(242, 31)
        Me.lblClassCreatedForTitle.TabIndex = 3
        Me.lblClassCreatedForTitle.Text = "Class Created For:"
        '
        'lblAboutTitle
        '
        Me.lblAboutTitle.AutoSize = True
        Me.lblAboutTitle.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutTitle.Location = New System.Drawing.Point(206, 42)
        Me.lblAboutTitle.Name = "lblAboutTitle"
        Me.lblAboutTitle.Size = New System.Drawing.Size(364, 48)
        Me.lblAboutTitle.TabIndex = 4
        Me.lblAboutTitle.Text = "About Smarticle"
        '
        'lblGameMakers
        '
        Me.lblGameMakers.AutoSize = True
        Me.lblGameMakers.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblGameMakers.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameMakers.Location = New System.Drawing.Point(233, 163)
        Me.lblGameMakers.Name = "lblGameMakers"
        Me.lblGameMakers.Size = New System.Drawing.Size(452, 31)
        Me.lblGameMakers.TabIndex = 5
        Me.lblGameMakers.Text = "Anda Achimescu and Simran Bhella "
        '
        'lblDateCreated
        '
        Me.lblDateCreated.AutoSize = True
        Me.lblDateCreated.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblDateCreated.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateCreated.Location = New System.Drawing.Point(256, 303)
        Me.lblDateCreated.Name = "lblDateCreated"
        Me.lblDateCreated.Size = New System.Drawing.Size(166, 31)
        Me.lblDateCreated.TabIndex = 6
        Me.lblDateCreated.Text = "May 17, 2016"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblClass.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(314, 455)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(387, 31)
        Me.lblClass.TabIndex = 7
        Me.lblClass.Text = "Video Game Design (AWS3MI)"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(764, 561)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.Location = New System.Drawing.Point(26, 107)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(713, 132)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.Location = New System.Drawing.Point(25, 253)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(713, 132)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(25, 402)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(713, 132)
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblDateCreated)
        Me.Controls.Add(Me.lblGameMakers)
        Me.Controls.Add(Me.lblAboutTitle)
        Me.Controls.Add(Me.lblClassCreatedForTitle)
        Me.Controls.Add(Me.lblDateCreatedTitle)
        Me.Controls.Add(Me.lblCreatedByTitle)
        Me.Controls.Add(Me.mnuAbout)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuAbout
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "About the Program"
        Me.mnuAbout.ResumeLayout(False)
        Me.mnuAbout.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCreatedByTitle As System.Windows.Forms.Label
    Friend WithEvents lblDateCreatedTitle As System.Windows.Forms.Label
    Friend WithEvents lblClassCreatedForTitle As System.Windows.Forms.Label
    Friend WithEvents lblAboutTitle As System.Windows.Forms.Label
    Friend WithEvents lblGameMakers As System.Windows.Forms.Label
    Friend WithEvents lblDateCreated As System.Windows.Forms.Label
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
