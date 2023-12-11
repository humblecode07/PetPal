Public Class Appointment
    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserModule.ConnectDbase()
        roundCorners(Me)
        dtpDateAppointment.CustomFormat = "yyyy-MM-dd | HH:mm:ss"
        LoadPetName(UserPanel.lblId.Text)
    End Sub

    Private Sub cmbPets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPets.SelectedIndexChanged
        UserModule.LoadPetInfo(cmbPets.SelectedItem.ToString(), UserPanel.lblId.Text)
    End Sub
End Class