Imports System.IO
Public Class Pet
    Dim imageData As Byte()
    Dim type As String
    Private Sub AddPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserModule.ConnectDbase()
        roundCorners(Me)
        dtpBirthday.CustomFormat = "yyyy/MM/dd"
        Functions.CreateRoundedPictureBox(pbxProfile)
        Functions.SetRoundedButton(btnUpload, 15)
        Functions.SetRoundedButton(btnAdd, 15)
        Functions.SetRoundedButton(btnCancel, 15)

        If type = "Add" Then
            btnAdd.Text = "Add Pet"
            Panel1.Hide()
            MsgBox(type & "1")
        ElseIf type = "Edit" Then
            btnAdd.Text = "Update"
            Panel1.Show()
            MsgBox(type & "2")
        ElseIf type = "Delete" Then
            btnAdd.Text = "Delete"
            Panel1.Show()
            MsgBox(type & "3")
        End If

    End Sub

    Public Sub ReceiveValue(mode As String)
        type = mode
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
        UserPanel.Show()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim user_number As Integer = UserPanel.lblId.Text
        If type = "Add" Then
            AddPet(user_number, imageData)
            LoadPets(UserPanel.lblId.Text)
        ElseIf type = "Edit" Then
            UpdatePetInfo(user_number, imageData)
            LoadPets(UserPanel.lblId.Text)
        ElseIf type = "Delete" Then
            DeletePetInfo(user_number)
            LoadPets(UserPanel.lblId.Text)
            Me.Dispose()
            UserPanel.Show()
        End If
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        GetPetInfo()
    End Sub
End Class