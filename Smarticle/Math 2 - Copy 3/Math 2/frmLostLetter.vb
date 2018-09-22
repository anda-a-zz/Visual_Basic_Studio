Public Class frmLostLetter

    'variables...sb
    Dim levelOneWords(0 To 9) As String
    Dim levelTwoWords(0 To 9) As String
    Dim levelThreeWords(0 To 9) As String
    Dim levelOneAnswers(0 To 9) As Char
    Dim levelTwoAnswers(0 To 9) As Char
    Dim levelThreeAnswers(0 To 9) As Char
    Dim correct As Boolean
    Dim timer As Byte
    Dim counter1 As Byte = 0
    Dim totalQs As Byte = 0

    Private Sub frmLostLetter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Show username...sb
        lblUser.Text = username

        'create words...sb
        'level one words...sb
        levelOneWords(0) = "h_use" 'house...sb
        levelOneWords(1) = "wa_er" 'water...sb
        levelOneWords(2) = "g_apes" 'grapes...sb
        levelOneWords(3) = "ri_g" 'ring...sb
        levelOneWords(4) = "bott_e" 'bottle...sb
        levelOneWords(5) = "fro_n" 'frown...sb
        levelOneWords(6) = "_lants" 'plants...sb
        levelOneWords(7) = "hai_" 'hair...sb
        levelOneWords(8) = "p_one" 'phone...sb
        levelOneWords(9) = "je_lo" 'jello...sb

        'level one answers...sb
        levelOneAnswers(0) = "o"
        levelOneAnswers(1) = "t"
        levelOneAnswers(2) = "r"
        levelOneAnswers(3) = "n"
        levelOneAnswers(4) = "l"
        levelOneAnswers(5) = "w"
        levelOneAnswers(6) = "p"
        levelOneAnswers(7) = "r"
        levelOneAnswers(8) = "h"
        levelOneAnswers(9) = "l"

        'level two words...sb
        levelTwoWords(0) = "deser_ed" 'deserted...sb
        levelTwoWords(1) = "_urify" 'purify...sb
        levelTwoWords(2) = "je_elry" 'jewelry...sb
        levelTwoWords(3) = "la_ish" 'lavish...sb
        levelTwoWords(4) = "r_gue" 'rogue...sb
        levelTwoWords(5) = "extrava_ant" 'extravagant...sb
        levelTwoWords(6) = "de_irium" 'delirium...sb
        levelTwoWords(7) = "di_est" 'digest...sb
        levelTwoWords(8) = "ap_etite" 'appetite...sb
        levelTwoWords(9) = "ge_eral" 'general...sb

        'level two answers...sb
        levelTwoAnswers(0) = "t"
        levelTwoAnswers(1) = "p"
        levelTwoAnswers(2) = "w"
        levelTwoAnswers(3) = "v"
        levelTwoAnswers(4) = "o"
        levelTwoAnswers(5) = "g"
        levelTwoAnswers(6) = "l"
        levelTwoAnswers(7) = "g"
        levelTwoAnswers(8) = "p"
        levelTwoAnswers(9) = "n"

        'level 3 words...sb
        levelThreeWords(0) = "lacka_aisical" 'lackadaisical...sb
        levelThreeWords(1) = "fat_om" 'fathom...sb
        levelThreeWords(2) = "au_iliary" 'auxiliary...sb
        levelThreeWords(3) = "caden_e" 'cadence...sb
        levelThreeWords(4) = "chandel_er" 'chandelier...sb
        levelThreeWords(5) = "cosmopoli_an" 'cosmopolitan...sb
        levelThreeWords(6) = "_agabond" 'vagabond...sb
        levelThreeWords(7) = "es_ence" 'essence...sb
        levelThreeWords(8) = "neces_arily" 'necessarily...sb
        levelThreeWords(9) = "gla_ial" 'glacial...sb

        'level 3 answers...sb
        levelThreeAnswers(0) = "d"
        levelThreeAnswers(1) = "h"
        levelThreeAnswers(2) = "x"
        levelThreeAnswers(3) = "c"
        levelThreeAnswers(4) = "i"
        levelThreeAnswers(5) = "t"
        levelThreeAnswers(6) = "v"
        levelThreeAnswers(7) = "s"
        levelThreeAnswers(8) = "s"
        levelThreeAnswers(9) = "c"

        'reset score...sb
        currentGradeSum = 0

        'level one...sb
        If difficulty = 1 Then
            lblDiff.Text = "Easy"
            Call Level1()
        End If

        'level two...sb
        If difficulty = 2 Then
            lblDiff.Text = "Medium"
            Call Level2()
        End If

        'level three...sb
        If difficulty = 3 Then
            lblDiff.Text = "Hard"
            Call Level3()
        End If


    End Sub

    Private Sub tmrAnswer_Tick(sender As Object, e As EventArgs) Handles tmrAnswer.Tick
        'every interval add to counter, when counter reaches 5 the user won't have anymore time to guess...sb
        timer += 1
        'display countdown number...sb
        lblCountdownNumber.Visible = True
        If timer = 1 Then
            lblCountdownNumber.Text = "5"
        ElseIf timer = 2 Then
            lblCountdownNumber.Text = "4"
        ElseIf timer = 3 Then
            lblCountdownNumber.Text = "3"
        ElseIf timer = 4 Then
            lblCountdownNumber.Text = "2"
        ElseIf timer = 5 Then
            lblCountdownNumber.Text = "1"
        End If
        'if time has run out then verify answer...sb
        If timer > 5 Then
            Call VerifyAnswer()
        End If
    End Sub

    'verify answer  ...sb
    Sub VerifyAnswer()
        'make user answer lowercase...sb
        txtAnswer.Text = LCase(txtAnswer.Text)
        'add to total number of questions...sb
        totalQs += 1
        lblTotalQNum.Text = totalQs
        'hide countdown number...sb
        lblCountdownNumber.Visible = False

        'if level one, verify answer ones...sb
        If difficulty = 1 Then
            If txtAnswer.Text = levelOneAnswers(counter1) Then 'answer is correct...sb
                correct = True
                'Show a happy face...aaa
                picAnswer.Image = Math_2.My.Resources.happy
                picAnswer.Visible = True
                'add to score...sb
                currentGradeSum += 1
                lblCorrect.Text = currentGradeSum
            Else
                correct = False 'answer is incorrect...sb
                'Show a sad face...aaa
                picAnswer.Image = Math_2.My.Resources.sad
                picAnswer.Visible = True
            End If

            'if level two, verify answer twos...sb
        ElseIf difficulty = 2 Then
            If txtAnswer.Text = levelTwoAnswers(counter1) Then 'answer is correct...sb
                correct = True
                'Show a happy face...aaa
                picAnswer.Image = Math_2.My.Resources.happy
                picAnswer.Visible = True
                'add to score...sb
                currentGradeSum += 1
                lblCorrect.Text = currentGradeSum
            Else
                correct = False 'answer is incorrect...sb
                'Show a sad face...aaa            
                picAnswer.Image = Math_2.My.Resources.happy
                picAnswer.Visible = True
            End If

            'if level three, verify answer threes...sb
        ElseIf difficulty = 3 Then
            If txtAnswer.Text = levelThreeAnswers(counter1) Then 'answer is correct...sb
                correct = True
                'Show a happy face...aaa            
                picAnswer.Image = Math_2.My.Resources.happy
                picAnswer.Visible = True
                'add to score...sb
                currentGradeSum += 1
                lblCorrect.Text = currentGradeSum
            Else
                correct = False 'answer is incorrect...sb
                'Show a sad face...aaa            
                picAnswer.Image = Math_2.My.Resources.happy
                picAnswer.Visible = True
            End If
        End If

        'make current grade...sb
        currentGrade = (currentGradeSum / totalQs) * 100
        lblCGrade.Text = Math.Round(currentGrade)

        'reset timer, enable next level...sb
        tmrAnswer.Enabled = False
        timer = 0
        cmdNext.Enabled = True
        counter1 += 1
        'if at end of level (question 10), then go to result screen...sb
        If counter1 = 10 Then
            tmrAnswer.Enabled = False
            frmReportCard.Show()
            Me.Hide()
        End If
    End Sub

    'level 1...sb
    Sub Level1()
        'reset picture...sb
        picAnswer.Visible = False
        cmdNext.Enabled = False
        txtAnswer.Text = Nothing
        'go through all words...sb
        'show word...sb
        lblWord.Text = levelOneWords(counter1)
        tmrAnswer.Enabled = True
    End Sub

    'level 2...sb
    Sub Level2()
        'reset picture...sb
        picAnswer.Visible = False
        cmdNext.Enabled = False
        txtAnswer.Text = Nothing
        'go through all words...sb
        'show word...sb
        lblWord.Text = levelTwoWords(counter1)
        tmrAnswer.Enabled = True
    End Sub

    'level 3...sb
    Sub Level3()
        'reset picture...sb
        picAnswer.Visible = False
        cmdNext.Enabled = False
        txtAnswer.Text = Nothing
        'go through all words...sb
        'show word...sb
        lblWord.Text = levelThreeWords(counter1)
        tmrAnswer.Enabled = True
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        If difficulty = 1 Then
            'next question in level one...sb
            Call Level1()
        ElseIf difficulty = 2 Then
            'next question in level two...sb
            Call Level2()
        ElseIf difficulty = 3 Then
            'next question in level three...sb
            Call Level3()
        End If
    End Sub

    'quit button in menu...sb
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'go to difficulty select...sb
        frmAskLevelDifficultyLostLetter.Show()
        Me.Hide()
        'reset everything...sb
        lblCountdownNumber.Text = "5"
        currentGradeSum = 0
        totalQs = 0
        lblTotalQNum.Text = totalQs
        lblCorrect.Text = "0"
        txtAnswer.Text = Nothing
        timer = 0
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        'show instructions...sb
        frmLostLetterInstructions.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        'show about..sb
        frmAbout.Show()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        'go to game picker...sb
        frmGamePicker.Show()
        Me.Hide()
    End Sub
End Class