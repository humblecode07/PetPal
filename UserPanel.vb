Public Class UserPanel
    Dim id As Integer
    Private Sub UserPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserModule.ConnectDbase()
        roundCorners(Me)
        CreateRoundedPictureBox(pcbProfile)
        CreateRoundedPictureBox(pcbUserProfile)
        Dim fontFileName As String = "cBomb.ttf"
        Dim fontFilePath As String = System.IO.Path.Combine(Application.StartupPath, fontFileName)

        If System.IO.File.Exists(fontFilePath) Then
            Dim customFont As Font = Functions.LoadCustomFont(fontFilePath, 21.0F)
            Dim customFontTwo As Font = Functions.LoadCustomFont(fontFilePath, 15.0F)

            btnPets.Font = customFont
            btnAppointment.Font = customFontTwo
            btnProfile.Font = customFontTwo
            btnNotif.Font = customFontTwo
            btnLogOut.Font = customFontTwo
            lblMyPets.Font = customFont
            lblAppointment.Font = customFont

            lblUserName.Font = customFont
        Else
            MessageBox.Show($"Font file not found at: {fontFilePath}")
        End If
        Panel2.Hide()
        LoadPets(id)
        LoadUserInfo(id)
    End Sub

    Public Sub ReceiveValue(ByVal value As String)
        lblId.Text = value
        id = value
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Pet.ReceiveValue("Add")
        Me.Hide()
        Pet.Show()
    End Sub

    Private Sub dgvPets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPets.CellClick
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            ' Get the pet ID from the clicked row
            Dim petIDValue As Object = dgvPets.Rows(e.RowIndex).Cells("pet_id").Value

            If Not Convert.IsDBNull(petIDValue) Then
                Dim petID As Integer = Convert.ToInt32(petIDValue)

                ' Load and display the profile picture for the selected pet
                LoadProfilePicture(petID, pcbProfile)
            Else
                ' Handle DBNull value, for example, show a message or take appropriate action
                MessageBox.Show("null.")
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Pet.ReceiveValue("Edit")
        Me.Hide()
        Pet.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Pet.ReceiveValue("Delete")
        Me.Hide()
        Pet.Show()
    End Sub

    Private Sub btnPets_Click(sender As Object, e As EventArgs) Handles btnPets.Click
        Panel2.Show()
        Panel3.Hide()
        Panel4.Hide()
    End Sub

    'Appointment
    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        Panel3.Show()
        Panel4.Hide()
        Panel2.Hide()
    End Sub
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Panel4.Show()
        Panel3.Hide()
        Panel2.Hide()
    End Sub

    Private Sub btnCreateAppointment_Click(sender As Object, e As EventArgs) Handles btnCreateAppointment.Click
        Appointment.ReceiveValue("Create")
        Appointment.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdateAppointment_Click(sender As Object, e As EventArgs) Handles btnUpdateAppointment.Click
        Appointment.ReceiveValue("Edit")
        Appointment.Show()
        Me.Hide()
    End Sub

    'Profile
    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        Account.ReceiveValue("Edit")
        Account.Show()
        Me.Hide()
    End Sub
    Private Sub btnDeleteProfile_Click(sender As Object, e As EventArgs) Handles btnDeleteProfile.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to delete your account?", "Confirmation",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            DeleteProfile()
            Me.Dispose()
            ClientLogin.Show()
        End If
    End Sub
    Public Sub LoadInfo()
        LoadPets(id)
        LoadUserInfo(id)
    End Sub

    'Log out
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to sign out?", "Confirmation",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Dispose()
            ClientLogin.Show()
        End If
    End Sub

    Private Sub btnCancelAppointment_Click(sender As Object, e As EventArgs) Handles btnCancelAppointment.Click

    End Sub
End Class