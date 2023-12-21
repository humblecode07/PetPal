Imports System.IO
Public Class Medicine
    Dim imageData As Byte()
    Dim type As String
    Dim role As String
    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaffConfig.ConnectDbase()
        roundCorners(Me)

        If type = "Add" Then
            btnConfirm.Text = "Add Medicine"
            Panel3.Hide()
        ElseIf type = "Edit" Then
            btnConfirm.Text = "Update Medicine Info"
            Panel3.Show()
        ElseIf type = "Delete" Then
            btnConfirm.Text = "Delete Medicine"
            Panel3.Show()
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
                    pcbMedicineProfile.Image = newImage
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating image: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If type = "Add" Then
            StaffConfig.AddMedicine(imageData)
            AdminModule.LoadMedicines()
            AdminModule.GetTotal("medicine_info")
        ElseIf type = "Edit" Then
            StaffConfig.UpdateMedicineInfo(imageData)
            AdminModule.LoadMedicines()
            AdminModule.GetTotal("medicine_info")
        ElseIf type = "Delete" Then
            StaffConfig.DeleteMedicine()
            AdminModule.LoadMedicines()
            AdminModule.GetTotal("medicine_info")
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If role = "Admin" Then
            Me.Dispose()
            AdminPanel.Show()
        Else

        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        StaffConfig.ReadMedicineInfo()
    End Sub
    Public Sub ReceiveValue(mode As String)
        type = mode
    End Sub
    Public Sub ReceiveRole(authority As String)
        role = authority
    End Sub
End Class