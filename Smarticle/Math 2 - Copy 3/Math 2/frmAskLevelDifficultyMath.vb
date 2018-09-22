Public Class frmAskLevelDifficultyMath

    Private Sub rdoAddition_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAddition.CheckedChanged
        'Make the symbol = 1 if addition button is checked...aaa
        If rdoAddition.Checked = True Then
            symbol = 1
        End If
    End Sub

    Private Sub rdoSubtraction_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSubtraction.CheckedChanged
        'Make the symbol = 2 if subtraction button is checked...aaa
        If rdoSubtraction.Checked = True Then
            symbol = 2
        End If
    End Sub

    Private Sub lblMultiplication_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMultiplication.CheckedChanged
        'Make the symbol = 3 if multiplication button is checked...aaa
        If rdoMultiplication.Checked = True Then
            symbol = 3
        End If
    End Sub

    Private Sub rdoDivision_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDivision.CheckedChanged
        'Make the symbol = 4 if division button is checked...aaa
        If rdoDivision.Checked = True Then
            symbol = 4
        End If
    End Sub

    Private Sub rdoLevel1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLevel1.CheckedChanged
        'Make the level = 1 if level 1 button is checked...aaa
        If rdoLevel1.Checked = True Then
            level = 1
        End If
    End Sub

    Private Sub rdoLevel2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLevel2.CheckedChanged
        'Make the level = 2 if level 2 button is checked...aaa
        If rdoLevel2.Checked = True Then
            level = 2
        End If
    End Sub

    Private Sub rdoLevel3_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLevel3.CheckedChanged
        'Make the level = 3 if level 3 button is checked...aaa
        If rdoLevel3.Checked = True Then
            level = 3
        End If
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        'Open up the math instructions form and the actual math game...aaa
        frmMathInstructions.Show()
        frmMathOperations.Show()
        Me.Hide()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        'Ask user if they want to exit...aaa
        x = MsgBox("Are you sure you want to exit?", 4 + 16, "Exit?")
        'If user submits "yes" then exit program...aaa
        If x = 6 Then End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Have the About form pop up...aaa
        frmAbout.Show()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        'Ask user if they want to go back to the main menu...aaa
        x = MsgBox("Are you sure you want to go to the main menu? All your information will not be saved.", 4 + 16, "Please Don't Leave me..")

        'If user submits "yes" then go to the main menu...aaa
        If x = 6 Then
            'Go to the Game Picker form...aaa
            frmGamePicker.Show()
            Me.Hide()
        End If
    End Sub

End Class
