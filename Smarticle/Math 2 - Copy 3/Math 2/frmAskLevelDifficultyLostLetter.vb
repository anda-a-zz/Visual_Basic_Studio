Option Explicit On

'make public variables...sb
Public Module globalVariables2

    Public currentGrade As Double
    Public currentGradeSum As Double = 0
End Module

Public Class frmAskLevelDifficultyLostLetter

    Private Sub cmdLostNext_Click(sender As Object, e As EventArgs) Handles cmdLostNext.Click
        'when next button is clicked, go to game...sb
        frmLostLetter.Show()
        Me.Hide()
    End Sub

    Private Sub rdoLevel1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLevel1.CheckedChanged
        'easy...sb
        difficulty = 1
    End Sub

    Private Sub rdoLevel2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLevel2.CheckedChanged
        'medium...sb
        difficulty = 2
    End Sub

    Private Sub rdoLevel3_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLevel3.CheckedChanged
        'hard...sb
        difficulty = 3
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        'quit program...sb
        End
    End Sub

    'show instructions...sb
    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        frmLostLetterInstructions.Show()
    End Sub

    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        'go to game picker...sb
        frmGamePicker.Show()
        Me.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Go to about form...sb
        frmAbout.Show()
    End Sub
End Class
