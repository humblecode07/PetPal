Imports System.IO

Public Class Account
    Dim imageData As Byte()
    Dim type As String
    Dim role As String

    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientConfig.ConnectDbase()
        roundCorners(Me)
        CreateRoundedPictureBox(pbxProfile)

        If type = "Add" And role = "Admin" Then
            btnOkay.Text = "Create User"
            Panel1.Hide()
            Panel2.Hide()
        ElseIf type = "Edit" And role = "Admin" Then
            btnOkay.Text = "Update User"
            Panel1.Show()
            Panel2.Show()
        ElseIf type = "Delete" And role = "Admin" Then
            btnOkay.Text = "Delete User"
            Panel1.Show()
            Panel2.Show()
        ElseIf type = "Edit" Then
            btnOkay.Text = "Update"
            Panel1.Show()
            ReadProfile()
        End If
    End Sub

    'GET THE IMAGE
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim OpenFileDialog As New OpenFileDialog()
        OpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Read the selected file into a byte array
                imageData = File.ReadAllBytes(OpenFileDialog.FileName)

                ' Update the PictureBox with the new image
                Using stream As New MemoryStream(imageData)
                    Dim newImage As Image = Image.FromStream(stream)
                    pbxProfile.BackgroundImage = newImage
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating image: " & ex.Message)
            End Try
        End If
    End Sub

    'ADMIN: ADD, EDIT, AND DELETE | USER: EDIT ONLY
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        If type = "Add" And role = "Admin" Then
            AddUser(imageData)
            AdminModule.LoadUsers()
            AdminModule.GetTotal("user_info")
        ElseIf type = "Edit" And role = "Admin" Then
            UpdateProfile(imageData)
            AdminModule.LoadUsers()
            AdminModule.GetTotal("user_info")
        ElseIf type = "Delete" And role = "Admin" Then
            DeleteProfile(txtUserID.Text)
            AdminModule.LoadUsers()
            AdminModule.GetTotal("user_info")
        ElseIf type = "Edit" Then
            UpdateProfile(imageData)
            Me.Dispose()
            UserPanel.LoadInfo()
            UserPanel.Show()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If role = "Admin" Then
            Me.Dispose()
            AdminPanel.Show()
        ElseIf type = "Add" Then
            Me.Dispose()
            ClientLogin.Show()
        ElseIf type = "Edit" Then
            Me.Dispose()
            UserPanel.Show()
        End If
    End Sub

    'ADMIN: SEARCHING USER ID TO VIEW, UPDATE OR DELETE
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim nonNumericPattern As String = "[^0-9" & txtUserID.Text & "]"

        If String.IsNullOrEmpty(txtUserID.Text) Then
            MsgBox("User ID is empty!")
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(txtUserID.Text, nonNumericPattern) Then
            MsgBox("Please enter a valid number.")
        Else
            ClientConfig.ReadProfile()
        End If
    End Sub

    Public Sub ReceiveValue(mode As String)
        type = mode
    End Sub
    Public Sub ReceiveRole(authority As String)
        role = authority
    End Sub
End Class