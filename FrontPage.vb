Imports System.Drawing.Text

Public Class FrontPage
    Private Sub FrontPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        Dim fontFileName As String = "cBomb.ttf"
        Dim fontFileNameTwo As String = "quickSand.ttf"
        Dim fontFilePath As String = System.IO.Path.Combine(Application.StartupPath, fontFileName)
        Dim fontFilePathTwo As String = System.IO.Path.Combine(Application.StartupPath, fontFileNameTwo)

        If System.IO.File.Exists(fontFilePath) Then
            Dim customFont As Font = Functions.LoadCustomFont(fontFilePath, 22.0F)
            Dim customFontTwo As Font = Functions.LoadCustomFont(fontFilePath, 18.0F)
            Dim customFontThree As Font = Functions.LoadCustomFont(fontFilePathTwo, 32.0F)

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
End Class