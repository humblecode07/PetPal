Imports System.IO
Public Class Appointment
    Dim type As String
    Dim role As String
    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserModule.ConnectDbase()
        roundCorners(Me)
        dtpBirthDate.CustomFormat = "yyyy-MM-dd"
        dtpDateAppo.CustomFormat = "yyyy-MM-dd HH:mm:ss"

        If type = "Create" And role = "Admin" Then
            btnSchedule.Text = "Schedule an Appointment"
            Panel1.Hide()
            Panel2.Hide()
        ElseIf type = "Edit" And role = "Admin" Then
            btnSchedule.Text = "Update an Appointment"
            Panel1.Show()
            Panel2.Show()
        ElseIf type = "Accept" And role = "Admin" Then
            btnSchedule.Text = "Accept Appointment"
            Panel1.Show()
            Panel2.Show()
        ElseIf type = "Decline" And role = "Admin" Then
            btnSchedule.Text = "Decline Appointment"
            Panel1.Show()
            Panel2.Show()
        ElseIf type = "Finish" And role = "Admin" Then
            btnSchedule.Text = "Finish Appointment"
            Panel1.Show()
            Panel2.Show()
        ElseIf type = "Cancel" And role = "Admin" Then
            btnSchedule.Text = "Cancel Appointment"
            Panel1.Show()
            Panel2.Show()
        ElseIf type = "Create" Then
            btnSchedule.Text = "Schedule an Appointment"
            Panel1.Hide()
            Panel2.Hide()
        ElseIf type = "Edit" Then
            btnSchedule.Text = "Update an Appointment"
            Panel1.Show()
            Panel2.Hide()
        ElseIf type = "Cancel" Then
            btnSchedule.Text = "Cancel Appointment"
            Panel1.Show()
            Panel2.Hide()
        End If

    End Sub

    Private Sub btnPetSearch_Click(sender As Object, e As EventArgs) Handles btnPetSearch.Click
        If role = "Admin" Then
            UserModule.LoadPetInfo(txtPetID.Text, 1)
        Else
            UserModule.LoadPetInfo(txtPetID.Text, UserPanel.lblId.Text)
        End If

    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Dim user_number As Integer
        If role = "Admin" Then

        Else
            user_number = UserPanel.lblId.Text
        End If

        If type = "Create" And role = "Admin" Then
            UserModule.SubmitAppointment("1")
            AdminModule.LoadUserAppointments()
            AdminModule.GetTotal("user_appointment")
        ElseIf type = "Edit" And role = "Admin" Then
            user_number = txtUserID.Text
            UserModule.UpdateAppointment(user_number, "Pending")
            AdminModule.LoadUserAppointments()
            AdminModule.GetTotal("user_appointment")
        ElseIf type = "Accept" And role = "Admin" Then
            user_number = txtUserID.Text
            UserModule.UpdateAppointment(user_number, "Ongoing")
            AdminModule.LoadUserAppointments()
            AdminModule.GetTotal("user_appointment")
        ElseIf type = "Decline" And role = "Admin" Then
            user_number = txtUserID.Text
            UserModule.UpdateAppointment(user_number, "Declined")
            AdminModule.LoadUserAppointments()
            AdminModule.GetTotal("user_appointment")
        ElseIf type = "Finish" And role = "Admin" Then
            user_number = txtUserID.Text
            UserModule.UpdateAppointment(user_number, "Finished")
            AdminModule.LoadUserAppointments()
            AdminModule.GetTotal("user_appointment")
        ElseIf type = "Cancel" And role = "Admin" Then
            user_number = txtUserID.Text
            UserModule.CancelAppointment(user_number)
            AdminModule.LoadUserAppointments()
            AdminModule.GetTotal("user_appointment")
        ElseIf type = "Add" Then

        ElseIf type = "Edit" Then

        ElseIf type = "Cancel" Then

        End If

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If role = "Admin" Then
                UserModule.GetAppointmentInfo(txtUserID.Text)
            Else
                UserModule.GetAppointmentInfo(UserPanel.lblId.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Enter the user and appointment id.")
        End Try
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
    Private Sub btnStaffSearch_Click(sender As Object, e As EventArgs) Handles btnStaffSearch.Click
        UserModule.SearchStaffAssign(txtStaffID.Text)
    End Sub

    Public Sub ReceiveValue(mode As String)
        type = mode
    End Sub
    Public Sub ReceiveRole(authority As String)
        role = authority
    End Sub
End Class