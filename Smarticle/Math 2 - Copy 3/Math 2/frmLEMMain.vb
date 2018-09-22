Option Explicit On

Public Class frmLEMMain

    'quit program...sb
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub

    'level 1...sb
    Private Sub rdoLevel1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLevel1.CheckedChanged
        difficulty = 1
    End Sub

    'level 2...sb
    Private Sub rdoLevel2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLevel2.CheckedChanged
        difficulty = 2
    End Sub

    'level 3...sb
    Private Sub rdoLevel3_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLevel3.CheckedChanged
        difficulty = 3
    End Sub

    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click
        'hide this form, show the game playing form...sb
        frmLessEqualsMore.Show()
        Me.Hide()
    End Sub

    'show instructions...sb
    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        frmLessEqualsInstructions.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Go to about form...sb
        frmAbout.Show()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        'go to game picker...sb
        frmGamePicker.Show()
        Me.Hide()
    End Sub
End Class