Public Class frmLessEqualsInstructions

    'exit instructions, go back to game...sb
    Private Sub BackToGameToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmLEMMain.Show()
        Me.Hide()
    End Sub

    'go back to main menu...sb
    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'show about...sb
        frmAbout.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'close instructions...sb
        Me.Hide()
    End Sub
End Class