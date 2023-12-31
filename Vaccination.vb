﻿Imports System.IO

Public Class Vaccination
    Dim imageData As Byte()
    Dim type As String
    Dim role As String
    Private Sub Vaccination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaffConfig.ConnectDbase()
        roundCorners(Me)

        If type = "Add" Then
            btnConfirm.Text = "Add Vaccine"
            Panel1.Hide()
        ElseIf type = "Edit" Then
            btnConfirm.Text = "Update Vaccine Info"
            Panel1.Show()
        ElseIf type = "Delete" Then
            btnConfirm.Text = "Delete Vaccine"
            Panel1.Show()
        End If

    End Sub
    Private Sub btnUploadVaccine_Click(sender As Object, e As EventArgs) Handles btnUploadVaccine.Click
        Dim OpenFileDialog As New OpenFileDialog()
        OpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Read the selected file into a byte array
                imageData = File.ReadAllBytes(OpenFileDialog.FileName)

                ' Update the PictureBox with the new image
                Using stream As New MemoryStream(imageData)
                    Dim newImage As Image = Image.FromStream(stream)
                    pcbVaccineProfile.Image = newImage
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating image: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If type = "Add" Then
            StaffConfig.AddVaccine(imageData)
            AdminModule.LoadVaccines()
            AdminModule.GetTotal("vaccine_info")
        ElseIf type = "Edit" Then
            StaffConfig.UpdateVaccineInfo(imageData)
            AdminModule.LoadVaccines()
            AdminModule.GetTotal("vaccine_info")
        ElseIf type = "Delete" Then
            StaffConfig.DeleteVaccine()
            AdminModule.LoadVaccines()
            AdminModule.GetTotal("vaccine_info")
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
        StaffConfig.ReadVaccineInfo()
    End Sub

    Public Sub ReceiveValue(mode As String)
        type = mode
    End Sub
    Public Sub ReceiveRole(authority As String)
        role = authority
    End Sub

End Class