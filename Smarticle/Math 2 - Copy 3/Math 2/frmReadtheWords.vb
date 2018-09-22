Option Explicit On

Public Class frmReadtheWords
    'Declare variables...aaa
    Dim questionAsked As Byte
    Dim wordTermNum As Byte
    Dim wordLocationNum As Byte
    Dim wordColourNum As Byte
    Dim wordTerm As String
    Dim wordColourTerm As String
    Dim wordLocationTerm As String

    Private Sub frmReadtheWords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ouput the user's information on the form...aaa
        lblUserName.Text = username
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        'Ask user if they want to exit...aaa
        x = MsgBox("Are you sure you want to exit? All your information will not be saved.", 4 + 16, "Please Don't Leave me..")
        'If user submits "yes" then exit program...aaa
        If x = 6 Then End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Have the About form pop up...aaa
        frmAbout.Show()
    End Sub

    Private Sub cmdVerify_Click(sender As Object, e As EventArgs) Handles cmdVerify.Click
        'Disable the Verify and Give Up button, Enable the Next button...aaa
        cmdVerify.Enabled = False
        cmdGiveUp.Enabled = False
        cmdNext.Enabled = True

        'Turn off the timer so it doesn't effect user's score...aaa
        tmrUserTime.Enabled = False

        'Disable the textbox...aaa
        txtUserAnswer.Enabled = False

        'Find out what the answer is...aaa
        Call findAnswer()

        'If the user answers correctly, send them a smiley face, otherwise send them a frowny face...aaa
        If LCase(answer) = LCase(txtUserAnswer.Text) Then 'Make sure the user's answer matches the real answer...aaa
            picAnswer.Image = Math_2.My.Resources.happy
            'Add to the list of right answers...aaa
            correct = correct + 1
        Else
            picAnswer.Image = Math_2.My.Resources.sad
            'Output the right answer in the textbox if the user gets it wrong...aaa
            txtUserAnswer.Text = answer
            'Add to the list of wrong answers...aaa
            incorrect = incorrect + 1
        End If
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        'Change the number of questions left...aaa
        qLeft = qLeft - 1
        lblQLeftNum.Text = qLeft
        qLeftCounter = qLeftCounter + 1

        'Calculate the percentage...aaa
        recentPercent = correct / qLeftCounter
        'Output the percentage, incorrect and correct values...aaa
        lblPercentNum.Text = Math.Round(recentPercent * 100, 2)
        lblCorrectNum.Text = correct
        lblIncorrectNum.Text = incorrect

        'Clear the picture in the box...aaa
        picAnswer.Image = Nothing

        'Exit when q = 0 to the report card form...aaa
        If qLeft = 0 Then
            'Disable all the 3 main buttons and enable the play button...aaa
            cmdNext.Enabled = False
            cmdGiveUp.Enabled = False
            cmdVerify.Enabled = False
            cmdPlay.Enabled = True

            'Go to the report card form...aaa
            frmReportCard.Show()
            frmReadWordsInstructions.Hide()
            Me.Hide()
        Else
            'Disable the Next button and Enable the Verify and Give Up button...aaa
            cmdNext.Enabled = False
            cmdVerify.Enabled = True
            cmdGiveUp.Enabled = True

            'Clear and enable the textbox, move the word back into the middle...aaa
            txtUserAnswer.Text = Nothing
            txtUserAnswer.Enabled = True
            lblWord.Location = New Point(200, 175)

            'Randomize the numbers to give the user a new problem...aaa
            Call randomizeWordInfo()
            Call findPossibleAnswer()

            'Restart the timer counter and restart the timer...aaa
            lblTimeNum.Text = 0
            tmrUserTime.Enabled = True
        End If
    End Sub

    Private Sub cmdGiveUp_Click(sender As Object, e As EventArgs) Handles cmdGiveUp.Click
        'Disable the Give Up and Verify button, Enable the Next button...aaa
        cmdGiveUp.Enabled = False
        cmdVerify.Enabled = False
        cmdNext.Enabled = True

        'Turn off the timer so it doesn't effect user's score...aaa
        tmrUserTime.Enabled = False

        'Find out the answer, output it in the textbox and output a sad face...aaa
        Call findAnswer()
        txtUserAnswer.Text = answer
        picAnswer.ImageLocation = ("H:\Profile\Desktop\AWS\Unit 3\Assignments\Math 2 - Copy 3\Pics\sad.png")
        picAnswer.Load()
        'Add to the incorrect answers list...aaa
        incorrect = incorrect + 1
        'Disable the textbox...aaa
        txtUserAnswer.Enabled = False
    End Sub

    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click
        'Start game with all new information and questions...aaa
        Call restartlevel()

        'Output the user's overall grade...aaa
        lblCurrentGrade.Text = Math.Round(overallPercent * 100, 2)
    End Sub

    Private Sub tmrUserTime_Tick(sender As Object, e As EventArgs) Handles tmrUserTime.Tick
        'Each time the timer ticks, add it to the timer label...aaa
        lblTimeNum.Text = Val(lblTimeNum.Text) + 1

        'After 5 seconds, give up on the user and output the answer...aaa
        If lblTimeNum.Text = 5 Then
            findAnswer()
            If LCase(answer) = LCase(txtUserAnswer.Text) Then
                'Show a happy picture...aaa
                picAnswer.Image = Math_2.My.Resources.happy
                'Add to the list of right answers...aaa
                correct = correct + 1
            Else
                'Show a sad picture...aaa
                picAnswer.Image = Math_2.My.Resources.sad
                'Output the right answer in and disable the textbox...aaa
                txtUserAnswer.Text = answer
                'Add to the list of wrong answers...aaa
                incorrect = incorrect + 1
            End If
            'Disable timer, textbox, give up and verify buttons and enable the next button...aaa
            tmrUserTime.Enabled = False
            txtUserAnswer.Enabled = False
            cmdGiveUp.Enabled = False
            cmdVerify.Enabled = False
            cmdNext.Enabled = True
        End If
    End Sub

    Private Sub findAnswer()
        'Find out what the user should be outputting in the textbox to get the answer right...aaa
        If questionAsked = 1 Then
            answer = wordColourTerm
        ElseIf questionAsked = 2 Then
            answer = wordTerm
        ElseIf questionAsked = 3 Then
            answer = wordLocationTerm
        End If
    End Sub

    Private Sub randomizeWordInfo()
        'Using the level decided, create a new problem...aaa
        Randomize()
        If level = 1 Then
            'Randomize the primary colours and have the location of the word be in the centre...aaa
            wordTermNum = Int(3 * Rnd() + 1)
            wordColourNum = Int(3 * Rnd() + 1)
            questionAsked = Int(2 * Rnd() + 1)
            wordLocationNum = 1
        ElseIf level = 2 Then
            'Randomize the colours in the rainbow and the location of the word, either right, left or centre...aaa
            wordTermNum = Int(6 * Rnd() + 1)
            wordColourNum = Int(6 * Rnd() + 1)
            questionAsked = Int(3 * Rnd() + 1)
            wordLocationNum = Int(3 * Rnd() + 1)
        ElseIf level = 3 Then
            'Randomize all the colours and all the locations of the word...aaa
            wordTermNum = Int(10 * Rnd() + 1)
            wordColourNum = Int(10 * Rnd() + 1)
            wordLocationNum = Int(5 * Rnd() + 1)
            questionAsked = Int(3 * Rnd() + 1)
        End If
    End Sub

    Private Sub findPossibleAnswer()
        'Using the randomized numbers, make the word this colour..aaa
        If wordColourNum = 1 Then
            wordColourTerm = "red"
            lblWord.ForeColor = Color.Red
        ElseIf wordColourNum = 2 Then
            wordColourTerm = "yellow"
            lblWord.ForeColor = Color.Yellow
        ElseIf wordColourNum = 3 Then
            wordColourTerm = "blue"
            lblWord.ForeColor = Color.Blue
        ElseIf wordColourNum = 4 Then
            wordColourTerm = "green"
            lblWord.ForeColor = Color.Green
        ElseIf wordColourNum = 5 Then
            wordColourTerm = "purple"
            lblWord.ForeColor = Color.Purple
        ElseIf wordColourNum = 6 Then
            wordColourTerm = "orange"
            lblWord.ForeColor = Color.Orange
        ElseIf wordColourNum = 7 Then
            wordColourTerm = "pink"
            lblWord.ForeColor = Color.Pink
        ElseIf wordColourNum = 8 Then
            wordColourTerm = "cyan"
            lblWord.ForeColor = Color.Cyan
        ElseIf wordColourNum = 9 Then
            wordColourTerm = "brown"
            lblWord.ForeColor = Color.Brown
        ElseIf wordColourNum = 10 Then
            wordColourTerm = "black"
            lblWord.ForeColor = Color.Black
        End If

        'Using the randomized numbers, find the name of a colour..aaa
        If wordTermNum = 1 Then
            wordTerm = "RED"
        ElseIf wordTermNum = 2 Then
            wordTerm = "YELLOW"
        ElseIf wordTermNum = 3 Then
            wordTerm = "BLUE"
        ElseIf wordTermNum = 4 Then
            wordTerm = "GREEN"
        ElseIf wordTermNum = 5 Then
            wordTerm = "PURPLE"
        ElseIf wordTermNum = 6 Then
            wordTerm = "ORANGE"
        ElseIf wordTermNum = 7 Then
            wordTerm = "PINK"
        ElseIf wordTermNum = 8 Then
            wordTerm = "CYAN"
        ElseIf wordTermNum = 9 Then
            wordTerm = "BROWN"
        ElseIf wordTermNum = 10 Then
            wordTerm = "BLACK"
        End If

        'Change the text to the word of a colour randomly generated...aaa
        lblWord.Text = wordTerm

        'Using the randomized numbers, ouput the location of the word...aaa
        If wordLocationNum = 1 Then
            wordLocationTerm = "centre"
        ElseIf wordLocationNum = 2 Then
            wordLocationTerm = "left"
            lblWord.Left = lblWord.Left - 180
        ElseIf wordLocationNum = 3 Then
            wordLocationTerm = "right"
            lblWord.Left = lblWord.Left + 130
        ElseIf wordLocationNum = 4 Then
            wordLocationTerm = "top"
            lblWord.Top = lblWord.Top - 80
        ElseIf wordLocationNum = 5 Then
            wordLocationTerm = "bottom"
            lblWord.Top = lblWord.Top + 80
        End If

        'Using the randomized numbers, find out what question will be asked...aaa
        If questionAsked = 1 Then
            lblWhereorWhatColour.Text = "Colour?"
        ElseIf questionAsked = 2 Then
            lblWhereorWhatColour.Text = "Word?"
        ElseIf questionAsked = 3 Then
            lblWhereorWhatColour.Text = "Location?"
        End If
    End Sub

    Private Sub restartlevel()
        'Enable the verify and give up buttons, disable the play button...aaa
        cmdGiveUp.Enabled = True
        cmdVerify.Enabled = True
        cmdPlay.Enabled = False

        'Change the value of the questions asked according to what the user chose...aaa
        If level = 1 Then
            qLeft = 10
        ElseIf level = 2 Then
            qLeft = 15
        ElseIf level = 3 Then
            qLeft = 20
        End If

        'Randomize the numbers...aaa
        Call randomizeWordInfo()
        Call findPossibleAnswer()

        'Start timer...aaa
        tmrUserTime.Enabled = True
        lblTimeNum.Text = 0

        'Show the number of questions left to complete...aaa
        lblQLeftNum.Text = qLeft
        qLeftCounter = 0

        'Delete any input in, enable and focus on the textbox...aaa
        txtUserAnswer.Text = Nothing
        txtUserAnswer.Enabled = True
        txtUserAnswer.Focus()

        'Have the scorebox be completely new...aaa
        correct = 0
        incorrect = 0
        recentPercent = 0
        lblCorrectNum.Text = correct
        lblIncorrectNum.Text = incorrect
        lblPercentNum.Text = recentPercent
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
