Imports System.IO

Public Class Account
    Dim imageData As Byte()
    Dim type As String
    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientConfig.ConnectDbase()
        roundCorners(Me)
        CreateRoundedPictureBox(pbxProfile)

        If Type = "Add" Then
            btnOkay.Text = "Sign Up"
            MsgBox(Type & "1")
        ElseIf Type = "Edit" Then
            btnOkay.Text = "Update"
            ReadProfile()
            MsgBox(Type & "2")
        End If
    End Sub

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

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        If type = "Add" Then
            AddUser(imageData)
        ElseIf type = "Edit" Then
            UpdateProfile(imageData)
            Me.Dispose()
            UserPanel.LoadInfo()
            UserPanel.Show()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If type = "Add" Then
            Me.Dispose()
            ClientLogin.Show()
        ElseIf type = "Edit" Then
            Me.Dispose()
            UserPanel.Show()
        End If
    End Sub

    Public Sub ReceiveValue(mode As String)
        type = mode
    End Sub
End Class