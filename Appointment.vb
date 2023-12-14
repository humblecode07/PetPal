Imports System.IO
Public Class Appointment
    Dim type As String
    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserModule.ConnectDbase()
        roundCorners(Me)
        dtpDateAppo.CustomFormat = "HH:mm:ss"
        dtpTimeAppo.CustomFormat = "HH:mm:ss"

        If type = "Create" Then
            LoadPetName(UserPanel.lblId.Text)
            btnSchedule.Text = "Schedule an Appointment"
            Panel1.Hide()
            MsgBox(type & "1")
        ElseIf type = "Edit" Then
            LoadPetName(UserPanel.lblId.Text)
            btnSchedule.Text = "Update"
            cmbPets.Enabled = False
            Panel1.Show()
            MsgBox(type & "2")
        ElseIf type = "Delete" Then
            btnSchedule.Text = "Cancel Appointment"
            Panel1.Show()
            MsgBox(type & "3")
        End If

    End Sub

    Private Sub cmbPets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPets.SelectedIndexChanged
        If type = "Create" Then
            UserModule.LoadPetInfo(cmbPets.SelectedItem.ToString(), UserPanel.lblId.Text)
        End If
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        If type = "Create" Then
            SubmitAppointment()
        ElseIf type = "Edit" Then
            UpdateAppointment()
        ElseIf type = "Delete" Then
            MsgBox("2")
            Me.Dispose()
            UserPanel.Show()
        End If

    End Sub

    Public Sub ReceiveValue(mode As String)
        type = mode
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        UserModule.GetAppointmentInfo()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
        UserPanel.Show()
    End Sub
End Class