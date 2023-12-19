Imports System.IO
Public Class Pet
    Dim imageData As Byte()
    Dim type As String
    Dim role As String
    Private Sub AddPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserModule.ConnectDbase()
        roundCorners(Me)
        dtpBirthday.CustomFormat = "yyyy/MM/dd"
        dtpTimeMedication.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Functions.CreateRoundedPictureBox(pbxProfile)
        Functions.SetRoundedButton(btnUpload, 15)
        Functions.SetRoundedButton(btnAdd, 15)
        Functions.SetRoundedButton(btnCancel, 15)

        If type = "Add" And role = "Admin" Then
            btnAdd.Text = "Add Pet"
            Panel1.Hide()
            Panel2.Hide()
        ElseIf type = "Edit" And role = "Admin" Then
            btnAdd.Text = "Update"
            Panel1.Hide()
            Panel2.Show()
        ElseIf type = "Delete" And role = "Admin" Then
            btnAdd.Text = "Delete"
            Panel1.Hide()
            Panel2.Show()
        ElseIf type = "Add" Then
            btnAdd.Text = "Add Pet"
            Panel1.Hide()
        ElseIf type = "Edit" Then
            btnAdd.Text = "Update"
            Panel1.Show()
        ElseIf type = "Delete" Then
            btnAdd.Text = "Delete"
            Panel1.Show()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If role = "Admin" Then
            Me.Dispose()
            AdminPanel.Show()
        Else
            Me.Dispose()
            UserPanel.Show()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim user_number As Integer
        If role = "Admin" Then
            user_number = 1
        Else
            user_number = UserPanel.lblId.Text
        End If

        If type = "Add" And role = "Admin" Then
            AddPet(user_number, imageData)
            AdminModule.LoadUsers()
            AdminModule.GetTotal("user_info")
        ElseIf type = "Edit" And role = "Admin" Then
            UpdatePetInfo(user_number, imageData, "Admin")
            AdminModule.LoadUsers()
            AdminModule.GetTotal("user_info")
        ElseIf type = "Delete" And role = "Admin" Then
            DeletePetInfo(user_number, "Admin")
            AdminModule.LoadUsers()
            AdminModule.GetTotal("user_info")
        ElseIf type = "Add" Then
            AddPet(user_number, imageData)
            LoadPets(UserPanel.lblId.Text)
            Me.Dispose()
            UserPanel.Show()
        ElseIf type = "Edit" Then
            UpdatePetInfo(user_number, imageData, "User")
            LoadPets(UserPanel.lblId.Text)
        ElseIf type = "Delete" Then
            DeletePetInfo(user_number, "User")
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
        If role = "Admin" Then
            GetPetInfo("1", txtPetId.Text)
        Else
            GetPetInfo(UserPanel.lblId.Text, txtPetId.Text)
        End If
    End Sub

    'USE FOR SEARCHING CLIENT'S PET INFO : ONLY FOR ADMIN
    Private Sub btnAdminSearch_Click(sender As Object, e As EventArgs) Handles btnAdminSearch.Click
        GetPetInfo(txtAUserNumber.Text, txtAPetID.Text)
    End Sub

    Public Sub ReceiveValue(mode As String)
        type = mode
    End Sub
    Public Sub ReceiveRole(authority As String)
        role = authority
    End Sub
End Class