Option Explicit On

Public Class frmLessEqualsMore
    'variables...sb
    Dim firstDigit As Integer
    Dim secondDigit As Integer
    Dim answer As String
    Dim reply As String
    Dim timeForAnswering As Byte = 0
    Dim correct As Byte = 0
    Dim incorrect As Byte = 0
    Dim playingTime As Byte = 60
    Dim total As Byte = 0

    'when the form loads, create the first question...sb
    Private Sub frmLessEqualsMore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Show username...sb
        lblUser.Text = username

        'start play timer...sb
        playingTime = 60
        tmrPlayTime.Enabled = True
        lblRightOrWrong.Text = Nothing

        'reset number of questions...sb
        total = 0

        'based on level (difficulty), create first question...sb
        If difficulty = 1 Then
            Call CreateAnswer1()
        ElseIf difficulty = 2 Then
            Call CreateAnswer2()
        ElseIf difficulty = 3 Then
            Call CreateAnswer3()
        End If
    End Sub

    'create easy question...sb
    Sub CreateAnswer1()
        'Reset answer and user’s answer (reply)...sb
        lblRightOrWrong.Text = Nothing
        answer = Nothing
        reply = Nothing
        lblAnswer.Text = "?"

        'reset time...sb
        timeForAnswering = 0

        're-enable answer buttons...sb
        cmdGreater.Enabled = True
        cmdEqual.Enabled = True
        cmdLess.Enabled = True

        'Create random numbers (first and second)...sb
        Randomize()
        firstDigit = Int(100 * Rnd() + 1)
        secondDigit = Int(100 * Rnd() + 1)

        'Show digits...sb
        lblFirstDigit.Text = firstDigit
        lblSecondDigit.Text = secondDigit

        'Greater than...sb
        If firstDigit > secondDigit Then
            answer = "greater"
            'equal...sb
        ElseIf firstDigit = secondDigit Then
            answer = "equal"
            'Less than...sb
        ElseIf firstDigit < secondDigit Then
            answer = "less"
        End If

        'set reply to something in case user does not pick an aswer...sb
        reply = "???"

        'enable timer...sb
        tmrAnswerTime.Enabled = True

    End Sub

    Sub CreateAnswer2()
        'Reset answer and user’s answer (reply)...sb
        lblRightOrWrong.Text = Nothing
        answer = Nothing
        reply = Nothing
        lblAnswer.Text = "?"

        'reset time...sb
        timeForAnswering = 0

        're-enable answer buttons...sb
        cmdGreater.Enabled = True
        cmdEqual.Enabled = True
        cmdLess.Enabled = True

        'Create random numbers (first and second)...sb
        Randomize()
        firstDigit = Int(1000 * Rnd() + 1)
        secondDigit = Int(1000 * Rnd() + 1)

        'Show digits...sb
        lblFirstDigit.Text = firstDigit
        lblSecondDigit.Text = secondDigit

        'Greater than...sb
        If firstDigit > secondDigit Then
            answer = "greater"
            'equal...sb
        ElseIf firstDigit = secondDigit Then
            answer = "equal"
            'Less than...sb
        ElseIf firstDigit < secondDigit Then
            answer = "less"
        End If

        'set reply to something in case user does not pick an aswer...sb
        reply = "???"

        'enable timer...sb
        tmrAnswerTime.Enabled = True
    End Sub

    Sub CreateAnswer3()
        'Reset answer and user’s answer (reply)...sb
        lblRightOrWrong.Text = Nothing
        answer = Nothing
        reply = Nothing
        lblAnswer.Text = "?"

        'reset time...sb
        timeForAnswering = 0

        're-enable answer buttons...sb
        cmdGreater.Enabled = True
        cmdEqual.Enabled = True
        cmdLess.Enabled = True

        'Create random numbers (first and second)...sb
        Randomize()
        firstDigit = Int(10000 * Rnd() + 1)
        secondDigit = Int(10000 * Rnd() + 1)

        'Show digits...sb
        lblFirstDigit.Text = firstDigit
        lblSecondDigit.Text = secondDigit

        'Greater than...sb
        If firstDigit > secondDigit Then
            answer = "greater"
            'equal...sb
        ElseIf firstDigit = secondDigit Then
            answer = "equal"
            'Less than...sb
        ElseIf firstDigit < secondDigit Then
            answer = "less"
        End If

        'set reply to something in case user does not pick an aswer...sb
        reply = "???"

        'enable timer...sb
        tmrAnswerTime.Enabled = True
    End Sub

    'user says greater than...sb
    Private Sub cmdGreater_Click(sender As Object, e As EventArgs) Handles cmdGreater.Click
        reply = "greater"
        lblAnswer.Text = ">"
        'check answer...sb
        Call verifyAnswer()
    End Sub

    'user says equal to...sb
    Private Sub cmdEqual_Click(sender As Object, e As EventArgs) Handles cmdEqual.Click
        reply = "equal"
        lblAnswer.Text = "="
        'check answer...sb
        Call verifyAnswer()
    End Sub

    'user says less than...sb
    Private Sub cmdLess_Click(sender As Object, e As EventArgs) Handles cmdLess.Click
        reply = "less"
        lblAnswer.Text = "<"
        'check answer...sb
        Call verifyAnswer()
    End Sub

    'this timer creates a time limit of 3 seconds for answering...sb
    Private Sub tmrAnswerTime_Tick(sender As Object, e As EventArgs) Handles tmrAnswerTime.Tick
        timeForAnswering += 1
        'if time has run out, verify answer...sb
        If timeForAnswering >= 3 Then
            Call verifyAnswer()
        End If
    End Sub

    Sub verifyAnswer()
        'disable all answer buttons...sb
        cmdGreater.Enabled = False
        cmdEqual.Enabled = False
        cmdLess.Enabled = False

        'if answer is correct...sb
        If reply = answer And timeForAnswering < 4 Then
            lblRightOrWrong.Text = "Correct"
            'add to score...sb
            correct += 1
            lblCorrect.Text = correct
            'disable timer...sb
            tmrAnswerTime.Enabled = False
            'enable next button...sb
            Call enableNext()
        Else
            lblRightOrWrong.Text = "Incorrect"
            'add to score...sb
            incorrect += 1
            lblIncorrect.Text = incorrect
            'disable timer...sb
            tmrAnswerTime.Enabled = False
            'enable next button...sb
            Call enableNext()
        End If

    End Sub

    Sub enableNext()
        'enable the next button for next question...sb
        cmdNext.Enabled = True
    End Sub

    Sub enableResults()
        'enable report card button to see results...sb
        cmdResults.Enabled = True
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        'disable this button...sb
        cmdNext.Enabled = False
        'go to next question (according to difficulty)...sb
        If difficulty = 1 Then
            Call CreateAnswer1()
        ElseIf difficulty = 2 Then
            Call CreateAnswer2()
        ElseIf difficulty = 3 Then
            Call CreateAnswer3()
        End If
    End Sub

    Private Sub cmdResults_Click(sender As Object, e As EventArgs) Handles cmdResults.Click
        'disable timers...sb
        tmrAnswerTime.Enabled = False
        cmdResults.Enabled = True

        'Calculate percentage...sb
        'get total number of questions...sb
        total = correct + incorrect
        recentPercent = correct / total

        'hide this form, show report card...sb
        frmReportCard.Show()
        Me.Hide()

    End Sub

    'quit button in menu...sb
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        'show instructions form...sb
        frmLessEqualsInstructions.Show()
    End Sub

    'restart from game menu...sb
    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'reset all variables
        tmrAnswerTime.Enabled = False
        correct = 0
        incorrect = 0
        lblCorrect.Text = correct
        lblIncorrect.Text = incorrect
        timeForAnswering = 0
        lblRightOrWrong.Text = Nothing
        answer = Nothing
        reply = Nothing
        lblAnswer.Text = "?"

        'switch forms...sb
        frmLEMMain.Show()
        Me.Hide()
    End Sub

    Private Sub tmrPlayTime_Tick(sender As Object, e As EventArgs) Handles tmrPlayTime.Tick
        'every time tick, subtract one from the playing time left...sb
        playingTime = playingTime - 1
        lblTime.Text = playingTime

        If playingTime = 0 Then
            'disable all timers and buttons except results...sb
            lblRightOrWrong.Text = "Time's Up!"
            cmdGreater.Enabled = False
            cmdEqual.Enabled = False
            cmdLess.Enabled = False
            cmdNext.Enabled = False
            tmrPlayTime.Enabled = False
            tmrAnswerTime.Enabled = False

            'enable results button...sb
            cmdResults.Enabled = True

        End If
    End Sub

    'click this if not wanting to wait the whole time and want to see results...sb
    Private Sub cmdFinish_Click(sender As Object, e As EventArgs) Handles cmdFinish.Click
        'disable all timers and buttons except results...sb
        lblRightOrWrong.Text = "Finish!"
        cmdGreater.Enabled = False
        cmdEqual.Enabled = False
        cmdLess.Enabled = False
        cmdNext.Enabled = False
        tmrPlayTime.Enabled = False
        tmrAnswerTime.Enabled = False

        'enable results button...sb
        cmdResults.Enabled = True
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'show about..sb
        frmAbout.Show()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        'go to game picker...sb
        frmGamePicker.Show()
        Me.Hide()
    End Sub
End Class

