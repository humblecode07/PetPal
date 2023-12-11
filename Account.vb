Imports System.IO

Public Class Account
    Dim imageData As Byte()
    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientConfig.ConnectDbase()
        roundCorners(Me)
        CreateRoundedPictureBox(pbxProfile)
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim profile As New OpenFileDialog
        profile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        profile.Title = "Select An Image"

        If profile.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim imagePath As String = profile.FileName
            imageData = File.ReadAllBytes(imagePath)

            ' Display the image in the PictureBox
            pbxProfile.BackgroundImage = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        AddUser(imageData)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        ClientLogin.Show()
    End Sub
End Class