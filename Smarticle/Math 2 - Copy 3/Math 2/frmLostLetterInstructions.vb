Option Explicit On

Public Class frmLostLetterInstructions

    Dim time As Byte = 5

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'quit program...sb
        End
    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        'make time label flash...sb
        If time > 1 Then
            time = time - 1
        End If
        lblInstructions7.Text = time
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        'hide the instructions...sb
        Me.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'show about..sb
        frmAbout.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'close instructions...sb
        Me.Hide()
    End Sub
End Class