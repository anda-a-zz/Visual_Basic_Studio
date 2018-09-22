Option Explicit On

Public Module GlobalVariables
    'Variables for all forms...aaa
    Public x
    Public level As Byte
    Public difficulty As Byte
    Public counter As Byte = 0

    'Personal for all forms...aaa
    Public correct As Byte = 0
    Public incorrect As Byte = 0
    Public qLeft As Integer
    Public qLeftCounter As Byte = 0
    Public answer As String

    'User information...aaa
    Public username As String
    Public recentPercent As Double
    Public overallPercent As Double
    Public totalPercent As Double

    'Variables for Math Operations forms...aaa
    Public symbol As Byte
End Module

Public Class frmGamePicker

    Private Sub frmGamePicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ask the user for a username...aaa
        username = InputBox("Please enter a user name", "Enter a Username", "User")
        'Hide the splash screen...aaa
        frmSplash.Close()
    End Sub

    Private Sub cmdMath_Click(sender As Object, e As EventArgs) Handles cmdMath.Click
        'If clicked, go to the Math Operations form...aaa
        frmAskLevelDifficultyMath.Show()
        Me.Hide()
    End Sub

    Private Sub cmdReadtheWords_Click(sender As Object, e As EventArgs) Handles cmdReadtheWords.Click
        'If clicked, go to the Read the Words form...aaa
        frmAskLevelDifficultyReadWords.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Ask user if they want to exit...aaa
        x = MsgBox("Are you sure you want to exit?", 4 + 16, "Exit?")
        'If user submits "yes" then exit program...aaa
        If x = 6 Then End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Have the About form pop up...aaa
        frmAbout.Show()
    End Sub

    Private Sub cmdLostLetter_Click(sender As Object, e As EventArgs) Handles cmdLostLetter.Click
        'Go to the Lost Letter game...aaa
        frmAskLevelDifficultyLostLetter.Show()
    End Sub

    Private Sub cmdLessEqualsMore_Click(sender As Object, e As EventArgs) Handles cmdLessEqualsMore.Click
        'Go to the Less, Equals, More game...aaa
        frmLEMMain.Show()
    End Sub
End Class
