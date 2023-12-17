Imports System.Drawing.Text

Public Class FrontPage
    Dim customFont As Font
    Dim customFontTwo As Font
    Dim customFontThree As Font
    Private Sub FrontPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        Me.KeyPreview = True
        Dim fontFileName As String = "cBomb.ttf"
        Dim fontFileNameTwo As String = "quickSand.ttf"
        Dim fontFilePath As String = System.IO.Path.Combine(Application.StartupPath, fontFileName)
        Dim fontFilePathTwo As String = System.IO.Path.Combine(Application.StartupPath, fontFileNameTwo)

        If System.IO.File.Exists(fontFilePath) Then
            customFont = Functions.LoadCustomFont(fontFilePath, 22.0F)
            customFontTwo = Functions.LoadCustomFont(fontFilePath, 18.0F)
            customFontThree = Functions.LoadCustomFont(fontFilePathTwo, 32.0F)

            Label1.Font = customFont
            btnHome.Font = customFontTwo
            btnServices.Font = customFontTwo
            btnContact.Font = customFontTwo
            btnAbout.Font = customFontTwo
        Else
            MessageBox.Show($"Font file not found at: {fontFilePath}")
        End If

        Functions.SetRoundedButton(btnGetStart, 20)
    End Sub

    Private Sub btnHome_MouseHover(sender As Object, e As EventArgs) Handles btnHome.MouseHover
        btnHome.ForeColor = Color.FromArgb(53, 63, 116)
    End Sub

    Private Sub btnHome_MouseLeave(sender As Object, e As EventArgs) Handles btnHome.MouseLeave
        btnHome.ForeColor = Color.White
    End Sub

    Private Sub btnServices_MouseHover(sender As Object, e As EventArgs) Handles btnServices.MouseHover
        btnServices.ForeColor = Color.FromArgb(53, 63, 116)
    End Sub

    Private Sub btnServices_MouseLeave(sender As Object, e As EventArgs) Handles btnServices.MouseLeave
        btnServices.ForeColor = Color.White
    End Sub

    Private Sub btnContact_MouseHover(sender As Object, e As EventArgs) Handles btnContact.MouseHover
        btnContact.ForeColor = Color.FromArgb(53, 63, 116)
    End Sub

    Private Sub btnContact_MouseLeave(sender As Object, e As EventArgs) Handles btnContact.MouseLeave
        btnContact.ForeColor = Color.White
    End Sub

    Private Sub btnAbout_MouseHover(sender As Object, e As EventArgs) Handles btnAbout.MouseHover
        btnAbout.ForeColor = Color.FromArgb(53, 63, 116)
    End Sub

    Private Sub btnAbout_MouseLeave(sender As Object, e As EventArgs) Handles btnAbout.MouseLeave
        btnAbout.ForeColor = Color.White
    End Sub

    Private Sub btnGetStart_Click_1(sender As Object, e As EventArgs) Handles btnGetStart.Click
        ClientLogin.Show()
    End Sub

    Private Sub btnHome_KeyDown(sender As Object, e As KeyEventArgs) Handles btnHome.KeyDown
        If e.Alt Then
            ' Prevent the default action
            e.SuppressKeyPress = True
        End If
    End Sub
End Class