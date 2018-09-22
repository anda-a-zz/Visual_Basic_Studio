Option Explicit On

Public Class frmMathOperations
    'Declare variables...aaa
    Dim firstNum As Integer
    Dim secNum As Integer
    Dim maxNumDigits As Byte

    Private Sub frmMathOperations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ouput the user's name on the form...aaa
        lblUserName.Text = username
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        'Ask user if they want to exit...aaa
        x = MsgBox("Are you sure you want to exit? All your information will not be saved.", 4 + 16, "Please Don't Leave me..")
        'If user submits "yes" then exit program...aaa
        If x = 6 Then End
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
        If answer = txtUserAnswer.Text Then
            picAnswer.ImageLocation = ("H:\Profile\Desktop\AWS\Unit 3\Assignments\Math 2 - Copy 3\Pics\happy.png")
            picAnswer.Load()
            'Add to the list of right answers...aaa
            correct = correct + 1
        Else
            picAnswer.ImageLocation = ("H:\Profile\Desktop\AWS\Unit 3\Assignments\Math 2 - Copy 3\Pics\sad.png")
            picAnswer.Load()
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
            frmMathInstructions.Hide()
            Me.Hide()
        Else
            'Disable the Next button and Enable the Verify and Give Up button...aaa
            cmdNext.Enabled = False
            cmdVerify.Enabled = True
            cmdGiveUp.Enabled = True

            'Clear, enable and focus on the textbox...aaa
            txtUserAnswer.Text = Nothing
            txtUserAnswer.Enabled = True
            txtUserAnswer.Focus()

            'Randomize the numbers to give the user a new problem...aaa
            Call randomizeNums()

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
        'Start the game with all new information and questions...aaa
        Call restartLevel()

        'Output the user's overall grade...aaa
        lblGradeNum.Text = Math.Round(overallPercent * 100, 2)
    End Sub

    Private Sub tmrUserTime_Tick(sender As Object, e As EventArgs) Handles tmrUserTime.Tick
        'Each time the timer ticks, add it to the timer label...aaa
        lblTimeNum.Text = Val(lblTimeNum.Text) + 1

        'After 5 seconds, give up on the user see if they inputted the right answer otherwise output the right answer...aaa
        If lblTimeNum.Text = 5 Then
            findAnswer()
            If answer = txtUserAnswer.Text Then
                'Show a happy picture...aaa
                picAnswer.ImageLocation = ("H:\Profile\Desktop\AWS\Unit 3\Assignments\Math 2 - Copy 3\Pics\happy.png")
                picAnswer.Load()
                'Add to the list of right answers...aaa
                correct = correct + 1
            Else
                'Show a sad picture...aaa
                picAnswer.ImageLocation = ("H:\Profile\Desktop\AWS\Unit 3\Assignments\Math 2 - Copy 3\Pics\sad.png")
                picAnswer.Load()
                'Output the right answer in the textbox...aaa
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

    Private Sub randomizeNums()
        'Using the level decided, create a new problem...aaa
        Randomize()
        If level = 1 Then
            'Randomize the problem up to 10...aaa
            maxNumDigits = 10
            firstNum = Int(maxNumDigits * Rnd() + 1)
            secNum = Int(maxNumDigits * Rnd() + 1)

            'Make sure the numbers are divisible if the user is doing division...aaa
            If symbol = 4 Then
                makeDivisible()
            End If

        ElseIf level = 2 Then
            'Make the maximum number for everything but "x" 50 but make "x" have a max num of 15...aaa
            If symbol = 1 Or symbol = 2 Or symbol = 4 Then
                maxNumDigits = 50
            ElseIf symbol = 3 Then
                maxNumDigits = 15
            End If
            'Randomize the problem...aaa
            firstNum = Int(maxNumDigits * Rnd() + 1)
            secNum = Int(maxNumDigits * Rnd() + 1)

            'Make sure the numbers are divisible if the user is doing division...aaa
            If symbol = 4 Then
                makeDivisible()
            End If

        ElseIf level = 3 Then
            'Make the maximum number for everything but "x" 200 but make "x" have a max num of 20...aaa
            If symbol = 1 Or symbol = 2 Or symbol = 4 Then
                maxNumDigits = 200
            ElseIf symbol = 3 Then
                maxNumDigits = 20
            End If
            'Randomize the problem...aaa
            firstNum = Int(maxNumDigits * Rnd() + 1)
            secNum = Int(maxNumDigits * Rnd() + 1)

            'Make sure the numbers are divisible if the user is doing division...aaa
            If symbol = 4 Then
                makeDivisible()
            End If
        End If

        'Output the new numbers into the labels...aaa
        lblFirstNumber.Text = firstNum
        lblSecNumber.Text = secNum
    End Sub

    Private Sub findAnswer()
        'Using the value of the symbols, find out the answer...aaa
        If symbol = 1 Then
            answer = firstNum + secNum
        ElseIf symbol = 2 Then
            answer = firstNum - secNum
        ElseIf symbol = 3 Then
            answer = firstNum * secNum
        ElseIf symbol = 4 Then
            answer = firstNum / secNum
        End If
    End Sub

    Private Sub makeDivisible()
        'Go through all the numbers possible until the two numbers are divisible...aaa
        For n = 1 To maxNumDigits
            If firstNum Mod secNum = 0 Then
                Exit For
            Else 'Keep randomizing the numbers until they are both divisible...aaa
                firstNum = Int(maxNumDigits * Rnd() + 1)
                secNum = Int(maxNumDigits * Rnd() + 1)
            End If
        Next
    End Sub

    Private Sub restartLevel()
        'Enable the verify and give up buttons, disable the play button...aaa
        cmdGiveUp.Enabled = True
        cmdVerify.Enabled = True
        cmdPlay.Enabled = False

        'Change the value of the symbol according to what the user chose...aaa
        If symbol = 1 Then
            lblOperationSym.Text = "+"
        ElseIf symbol = 2 Then
            lblOperationSym.Text = "-"
        ElseIf symbol = 3 Then
            lblOperationSym.Text = "x"
        ElseIf symbol = 4 Then
            lblOperationSym.Text = "÷"
        End If

        'Change the value of the questions asked according to what the user chose...aaa
        If level = 1 Then
            qLeft = 10
        ElseIf level = 2 Then
            qLeft = 15
        ElseIf level = 3 Then
            qLeft = 20
        End If

        'Randomize the numbers...aaa
        Call randomizeNums()

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

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Have the About form pop up...aaa
        frmAbout.Show()
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        'Have the Instructions form pop up...aaa
        frmMathInstructions.Show()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Call restartLevel()
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

    Private Sub lblMathOperations_Click(sender As Object, e As EventArgs) Handles lblMathOperations.Click

    End Sub
End Class
