Public Class frmReportCard

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        'Ask user if they want to exit...aaa
        x = MsgBox("Are you sure you want to exit? All your information will not be saved.", 4 + 16, "Please Don't Leave me..")
        'If user submits "yes" then exit program...aaa
        If x = 6 Then End
    End Sub

    Private Sub cmdMarks_Click(sender As Object, e As EventArgs) Handles cmdMarks.Click
        'Add one to the counter...aaa
        counter = counter + 1

        'If it's the user's first time playing, make their grade their only grade...aaa
        If counter = 1 Then
            'Output the user's old and new grade...aaa
            lblRecentGrade.Text = Math.Round(recentPercent * 100, 2)
            overallPercent = recentPercent
            lblOverallGrade.Text = Math.Round(overallPercent * 100, 2)
        Else
            'Add the user's new grade to their old one to find out their new grade...aaa
            totalPercent = totalPercent + recentPercent
            overallPercent = totalPercent / counter
            'Output the user's new and old grade...aaa
            lblRecentGrade.Text = Math.Round(recentPercent * 100, 2)
            lblOverallGrade.Text = Math.Round(overallPercent * 100, 2)
        End If

        'Ouput the user's name and make the new grade the old grade...aaa
        lblUserName.Text = username

        'Disable the button afterwards...aaa
        cmdMarks.Enabled = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Have the About form pop up...aaa
        frmAbout.Show()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        'Enable the Marks button if the user decides to play another game...aaa
        cmdMarks.Enabled = True

        'Go to the Game Picker form...aaa
        frmGamePicker.Show()
        Me.Hide()
    End Sub
End Class