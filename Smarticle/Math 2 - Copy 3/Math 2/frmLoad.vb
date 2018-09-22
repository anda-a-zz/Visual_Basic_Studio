Option Explicit On

Public Class frmLoad
    Dim xsize As Integer = 15

    Private Sub tmrSplashScreen_Tick(sender As Object, e As EventArgs) Handles tmrSplashScreen.Tick
        lblTime.Text = Val(lblTime.Text) + 1
        If xsize = 540 Then
            'Go to the next slide...aaa
            frmSplash.Show()
            Me.Hide()
            'Stop the timer...aaa
            tmrSplashScreen.Enabled = False
        Else
            'Make the white loading bar fill up...aaa
            RectangleShape2.Width = xsize
            xsize = xsize + 5
        End If
    End Sub

End Class