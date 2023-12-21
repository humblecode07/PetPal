Public Class AdminPanel
    Dim userId As Integer
    Dim petId As Integer
    Dim staffID As Integer
    Dim userAppointmentID As Integer
    Dim vaccineID As Integer
    Dim medicineID As Integer
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        pnlStaffCashier.Visible = True
        pnlUser.Visible = True
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
        pnlLabResults.Visible = False
    End Sub
    Private Sub btnUserPets_Click(sender As Object, e As EventArgs) Handles btnUserPets.Click
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = True
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
        pnlLabResults.Visible = False
    End Sub
    Private Sub btnStaffCashier_Click_1(sender As Object, e As EventArgs) Handles btnStaffCashier.Click
        pnlStaffCashier.Visible = True
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
        pnlLabResults.Visible = False
    End Sub
    Private Sub btnUserAppointment_Click(sender As Object, e As EventArgs) Handles btnUserAppointment.Click
        pnlLabResults.Visible = False
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = True
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
    End Sub
    Private Sub btnUserNotifications_Click(sender As Object, e As EventArgs) Handles btnUserNotifications.Click
        pnlLabResults.Visible = False
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = True
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
    End Sub
    Private Sub btnUserMessages_Click(sender As Object, e As EventArgs) Handles btnUserMessages.Click
        pnlLabResults.Visible = False
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = True
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
    End Sub
    Private Sub btnUserInbox_Click(sender As Object, e As EventArgs) Handles btnUserInbox.Click
        pnlLabResults.Visible = False
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = True
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
    End Sub
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        pnlLabResults.Visible = False
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = True
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
    End Sub
    Private Sub btnStaffs_Click(sender As Object, e As EventArgs) Handles btnStaffs.Click
        pnlLabResults.Visible = False
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = True
        pnlStaffVaccine.Visible = False
    End Sub
    Private Sub btnVaccines_Click(sender As Object, e As EventArgs) Handles btnVaccines.Click
        pnlLabResults.Visible = False
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = True
    End Sub
    Private Sub btnStaffAppointment_Click(sender As Object, e As EventArgs) Handles btnStaffAppointment.Click
        pnlLabResults.Visible = False
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = True
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
    End Sub
    Private Sub btnMedicines_Click(sender As Object, e As EventArgs) Handles btnMedicines.Click
        pnlLabResults.Visible = False
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = True
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
    End Sub
    Private Sub btnStaffMessage_Click(sender As Object, e As EventArgs) Handles btnStaffMessage.Click

    End Sub
    Private Sub btnStaffInbox_Click(sender As Object, e As EventArgs) Handles btnStaffInbox.Click

    End Sub
    Private Sub btnPetMonitoring_Click(sender As Object, e As EventArgs) Handles btnPetMonitoring.Click
        pnlLabResults.Visible = False
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = True
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
    End Sub
    Private Sub btnPhysicalResults_Click(sender As Object, e As EventArgs) Handles btnPhysicalResults.Click
        pnlLabResults.Visible = False
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = True
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
    End Sub
    Private Sub btnLabReports_Click(sender As Object, e As EventArgs) Handles btnLabReports.Click
        pnlLabResults.Visible = True
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = False
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
    End Sub
    Private Sub btnKennels_Click(sender As Object, e As EventArgs) Handles btnKennels.Click
        pnlLabResults.Visible = False
        pnlStaffCashier.Visible = False
        pnlUser.Visible = False
        pnlUserAppointment.Visible = False
        pnlUserInbox.Visible = False
        pnlUserMessage.Visible = False
        pnlUserNotifications.Visible = False
        pnlUserPets.Visible = False
        pnlUserReport.Visible = False
        pnlStaffAppointment.Visible = False
        pnlStaffKennel.Visible = True
        pnlStaffMedicines.Visible = False
        pnlStaffPetMonitoring.Visible = False
        pnlStaffPhysical.Visible = False
        pnlStaffs.Visible = False
        pnlStaffVaccine.Visible = False
    End Sub

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminModule.ConnectDbase()
        'USER PANEL
        AdminModule.LoadUsers()
        AdminModule.GetTotal("user_info")
        'PET PANEL
        AdminModule.LoadUserPets()
        AdminModule.GetTotal("pet_info")
        'USER APPOINTMENT PANEL
        AdminModule.LoadUserAppointments()
        AdminModule.GetTotal("user_appointment")
        'STAFF PANEL
        AdminModule.LoadStaffs()
        AdminModule.GetTotal("clinic_personnel_info")
        'VACCINE PANEL
        AdminModule.LoadVaccines()
        AdminModule.GetTotal("vaccine_info")
        'MEDICINE PANEL
        AdminModule.LoadMedicines()
        AdminModule.GetTotal("medicine_info")
    End Sub

    'USER PANEL USER PANEL USER PANEL USER PANEL USER PANEL USER PANEL USER PANEL USER PANEL USER PANEL

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Me.Hide()
        Account.ReceiveValue("Add")
        Account.ReceiveRole("Admin")
        Account.Show()
    End Sub
    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        Me.Hide()
        Account.ReceiveValue("Edit")
        Account.ReceiveRole("Admin")
        Account.Show()
    End Sub
    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Me.Hide()
        Account.ReceiveValue("Delete")
        Account.ReceiveRole("Admin")
        Account.Show()
    End Sub

    'PROFILES

    'USER'S PROFILE 
    Private Sub dgvUserTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserTable.CellClick
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            ' Get the pet ID from the clicked row
            Dim idValue As Object = dgvUserTable.Rows(e.RowIndex).Cells("user_number").Value

            If Not Convert.IsDBNull(idValue) Then
                Dim id As Integer = Convert.ToInt32(idValue)

                ' Load and display the profile picture for the selected pet
                AdminModule.LoadProfilePicture(id, vbEmpty, pcbUserProfile, "user_info")
            Else
                ' Handle DBNull value, for example, show a message or take appropriate action
                MessageBox.Show("null.")
            End If
        End If
    End Sub

    'USER FILTER
    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        If Integer.TryParse(txtUserID.Text, userId) Then
            AdminModule.UserNameFilter(userId, txtUserName.Text, txtUserCity.Text, txtUserContact.Text, txtUserProvince.Text)
        Else
            AdminModule.UserNameFilter(0, txtUserName.Text, txtUserCity.Text, txtUserContact.Text, txtUserProvince.Text)
        End If
    End Sub
    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        If Integer.TryParse(txtUserID.Text, userId) Then
            AdminModule.UserNameFilter(userId, txtUserName.Text, txtUserCity.Text, txtUserContact.Text, txtUserProvince.Text)
        Else
            AdminModule.UserNameFilter(0, txtUserName.Text, txtUserCity.Text, txtUserContact.Text, txtUserProvince.Text)
        End If
    End Sub
    Private Sub txtUserContact_TextChanged(sender As Object, e As EventArgs) Handles txtUserContact.TextChanged
        If Integer.TryParse(txtUserID.Text, userId) Then
            AdminModule.UserNameFilter(userId, txtUserName.Text, txtUserCity.Text, txtUserContact.Text, txtUserProvince.Text)
        Else
            AdminModule.UserNameFilter(0, txtUserName.Text, txtUserCity.Text, txtUserContact.Text, txtUserProvince.Text)
        End If
    End Sub

    Private Sub txtUserCity_TextChanged(sender As Object, e As EventArgs) Handles txtUserCity.TextChanged
        If Integer.TryParse(txtUserID.Text, userId) Then
            AdminModule.UserNameFilter(userId, txtUserName.Text, txtUserCity.Text, txtUserContact.Text, txtUserProvince.Text)
        Else
            AdminModule.UserNameFilter(0, txtUserName.Text, txtUserCity.Text, txtUserContact.Text, txtUserProvince.Text)
        End If
    End Sub

    Private Sub txtUserProvince_TextChanged(sender As Object, e As EventArgs) Handles txtUserProvince.TextChanged
        If Integer.TryParse(txtUserID.Text, userId) Then
            AdminModule.UserNameFilter(userId, txtUserName.Text, txtUserCity.Text, txtUserContact.Text, txtUserProvince.Text)
        Else
            AdminModule.UserNameFilter(0, txtUserName.Text, txtUserCity.Text, txtUserContact.Text, txtUserProvince.Text)
        End If
    End Sub

    'PET PANEL PET PANEL PET PANEL PET PANEL
    Private Sub btnAddPet_Click(sender As Object, e As EventArgs) Handles btnAddPet.Click
        Me.Hide()
        Pet.ReceiveValue("Add")
        Pet.ReceiveRole("Admin")
        Pet.Show()
    End Sub
    Private Sub btnUpdatePet_Click(sender As Object, e As EventArgs) Handles btnUpdatePet.Click
        Me.Hide()
        Pet.ReceiveValue("Edit")
        Pet.ReceiveRole("Admin")
        Pet.Show()
    End Sub
    Private Sub btnDeletePet_Click(sender As Object, e As EventArgs) Handles btnDeletePet.Click
        Me.Hide()
        Pet.ReceiveValue("Delete")
        Pet.ReceiveRole("Admin")
        Pet.Show()
    End Sub

    'PET FILTER
    Private Sub txtPetsID_TextChanged(sender As Object, e As EventArgs) Handles txtPetsID.TextChanged
        If Integer.TryParse(txtPetsID.Text, petId) Then
            AdminModule.PetFilter(petId, txtPetName.Text, txtPetSpecies.Text, txtPetBreed.Text, txtPetOwnerName.Text)
        Else
            AdminModule.PetFilter(0, txtPetName.Text, txtPetSpecies.Text, txtPetBreed.Text, txtPetOwnerName.Text)
        End If
    End Sub
    Private Sub txtPetName_TextChanged(sender As Object, e As EventArgs) Handles txtPetName.TextChanged
        If Integer.TryParse(txtPetsID.Text, petId) Then
            AdminModule.PetFilter(petId, txtPetName.Text, txtPetSpecies.Text, txtPetBreed.Text, txtPetOwnerName.Text)
        Else
            AdminModule.PetFilter(0, txtPetName.Text, txtPetSpecies.Text, txtPetBreed.Text, txtPetOwnerName.Text)
        End If
    End Sub
    Private Sub txtPetSpecies_TextChanged(sender As Object, e As EventArgs) Handles txtPetSpecies.TextChanged
        If Integer.TryParse(txtPetsID.Text, petId) Then
            AdminModule.PetFilter(petId, txtPetName.Text, txtPetSpecies.Text, txtPetBreed.Text, txtPetOwnerName.Text)
        Else
            AdminModule.PetFilter(0, txtPetName.Text, txtPetSpecies.Text, txtPetBreed.Text, txtPetOwnerName.Text)
        End If
    End Sub
    Private Sub txtPetBreed_TextChanged(sender As Object, e As EventArgs) Handles txtPetBreed.TextChanged
        If Integer.TryParse(txtPetsID.Text, petId) Then
            AdminModule.PetFilter(petId, txtPetName.Text, txtPetSpecies.Text, txtPetBreed.Text, txtPetOwnerName.Text)
        Else
            AdminModule.PetFilter(0, txtPetName.Text, txtPetSpecies.Text, txtPetBreed.Text, txtPetOwnerName.Text)
        End If
    End Sub
    Private Sub txtPetOwnerName_TextChanged(sender As Object, e As EventArgs) Handles txtPetOwnerName.TextChanged
        If Integer.TryParse(txtPetsID.Text, petId) Then
            AdminModule.PetFilter(petId, txtPetName.Text, txtPetSpecies.Text, txtPetBreed.Text, txtPetOwnerName.Text)
        Else
            AdminModule.PetFilter(0, txtPetName.Text, txtPetSpecies.Text, txtPetBreed.Text, txtPetOwnerName.Text)
        End If
    End Sub

    'PET PROFILES
    Private Sub dgvPetTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPetTable.CellClick
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            ' Get the pet ID from the clicked row
            Dim idValue As Object = dgvPetTable.Rows(e.RowIndex).Cells("user_number").Value
            Dim dynamicIdValue As Object = dgvPetTable.Rows(e.RowIndex).Cells("PetID").Value

            If Not Convert.IsDBNull(idValue) Then
                Dim id As Integer = Convert.ToInt32(idValue)
                Dim petID As Integer = Convert.ToInt32(dynamicIdValue)
                ' Load and display the profile picture for the selected pet
                AdminModule.LoadProfilePicture(id, dynamicIdValue, pcbPetsProfile, "pet_info")
            Else
                ' Handle DBNull value, for example, show a message or take appropriate action
                MessageBox.Show("null.")
            End If
        End If
    End Sub

    'USER APPOINTMENT PANEL USER APPOINTMENT PANEL USER APPOINTMENT PANEL
    Private Sub btnScheduleAppointment_Click(sender As Object, e As EventArgs) Handles btnScheduleAppointment.Click
        Me.Hide()
        Appointment.ReceiveValue("Create")
        Appointment.ReceiveRole("Admin")
        Appointment.Show()
    End Sub
    Private Sub btnUpdateAppointment_Click(sender As Object, e As EventArgs) Handles btnUpdateAppointment.Click
        Me.Hide()
        Appointment.ReceiveValue("Edit")
        Appointment.ReceiveRole("Admin")
        Appointment.Show()
    End Sub
    Private Sub btnCancelAppointment_Click(sender As Object, e As EventArgs) Handles btnCancelAppointment.Click
        Me.Hide()
        Appointment.ReceiveValue("Cancel")
        Appointment.ReceiveRole("Admin")
        Appointment.Show()
    End Sub
    Private Sub btnAppointmentView_Click(sender As Object, e As EventArgs) Handles btnAppointmentView.Click
        Me.Hide()
        Appointment.ReceiveValue("View")
        Appointment.ReceiveRole("Admin")
        Appointment.Show()
    End Sub

    'USER APPOINTMENT PROFILE
    Private Sub dgvUserAppointment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserAppointment.CellClick
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            ' Get the pet ID from the clicked row
            Dim idValue As Object = dgvUserAppointment.Rows(e.RowIndex).Cells("user_number").Value
            Dim dynamicIdValue As Object = dgvUserAppointment.Rows(e.RowIndex).Cells("PetID").Value

            If Not Convert.IsDBNull(idValue) Then
                Dim id As Integer = Convert.ToInt32(idValue)
                Dim petID As Integer = Convert.ToInt32(dynamicIdValue)
                AdminModule.LoadProfilePicture(id, petID, pcbUserAppointmentProfile, "user_appointment")
            Else
                MessageBox.Show("null.")
            End If
        End If
    End Sub

    'USER APPOINTMENT FILTER
    Private Sub txtAppointmentID_TextChanged(sender As Object, e As EventArgs) Handles txtAppointmentID.TextChanged
        If Integer.TryParse(txtAppointmentID.Text, userAppointmentID) Then
            AdminModule.UserAppointmentFilter(userAppointmentID, txtUAClientName.Text,
                                    txtUAPetName.Text, txtUAppointmentType.Text,
                                    txtUAStatus.Text, txtUAppointmentDate.Text)
        Else
            AdminModule.UserAppointmentFilter(0, txtUAClientName.Text,
                                    txtUAPetName.Text, txtUAppointmentType.Text,
                                    txtUAStatus.Text, txtUAppointmentDate.Text)
        End If
    End Sub

    Private Sub txtUAClientName_TextChanged(sender As Object, e As EventArgs) Handles txtUAClientName.TextChanged
        If Integer.TryParse(txtAppointmentID.Text, userAppointmentID) Then
            AdminModule.UserAppointmentFilter(userAppointmentID, txtUAClientName.Text,
                                    txtUAPetName.Text, txtUAppointmentType.Text,
                                    txtUAStatus.Text, txtUAppointmentDate.Text)
        Else
            AdminModule.UserAppointmentFilter(0, txtUAClientName.Text,
                                    txtUAPetName.Text, txtUAppointmentType.Text,
                                    txtUAStatus.Text, txtUAppointmentDate.Text)
        End If
    End Sub

    Private Sub txtUAPetName_TextChanged(sender As Object, e As EventArgs) Handles txtUAPetName.TextChanged
        If Integer.TryParse(txtAppointmentID.Text, userAppointmentID) Then
            AdminModule.UserAppointmentFilter(userAppointmentID, txtUAClientName.Text,
                                    txtUAPetName.Text, txtUAppointmentType.Text,
                                    txtUAStatus.Text, txtUAppointmentDate.Text)
        Else
            AdminModule.UserAppointmentFilter(0, txtUAClientName.Text,
                                    txtUAPetName.Text, txtUAppointmentType.Text,
                                    txtUAStatus.Text, txtUAppointmentDate.Text)
        End If
    End Sub

    Private Sub txtUAppointmentType_TextChanged(sender As Object, e As EventArgs) Handles txtUAppointmentType.TextChanged
        If Integer.TryParse(txtAppointmentID.Text, userAppointmentID) Then
            AdminModule.UserAppointmentFilter(userAppointmentID, txtUAClientName.Text,
                                    txtUAPetName.Text, txtUAppointmentType.Text,
                                    txtUAStatus.Text, txtUAppointmentDate.Text)
        Else
            AdminModule.UserAppointmentFilter(0, txtUAClientName.Text,
                                    txtUAPetName.Text, txtUAppointmentType.Text,
                                    txtUAStatus.Text, txtUAppointmentDate.Text)
        End If
    End Sub

    Private Sub txtUAStatus_TextChanged(sender As Object, e As EventArgs) Handles txtUAStatus.TextChanged
        If Integer.TryParse(txtAppointmentID.Text, userAppointmentID) Then
            AdminModule.UserAppointmentFilter(userAppointmentID, txtUAClientName.Text,
                                    txtUAPetName.Text, txtUAppointmentType.Text,
                                    txtUAStatus.Text, txtUAppointmentDate.Text)
        Else
            AdminModule.UserAppointmentFilter(0, txtUAClientName.Text,
                                    txtUAPetName.Text, txtUAppointmentType.Text,
                                    txtUAStatus.Text, txtUAppointmentDate.Text)
        End If
    End Sub

    Private Sub txtUAppointmentDate_TextChanged(sender As Object, e As EventArgs) Handles txtUAppointmentDate.TextChanged
        If Integer.TryParse(txtAppointmentID.Text, userAppointmentID) Then
            AdminModule.UserAppointmentFilter(userAppointmentID, txtUAClientName.Text,
                                    txtUAPetName.Text, txtUAppointmentType.Text,
                                    txtUAStatus.Text, txtUAppointmentDate.Text)
        Else
            AdminModule.UserAppointmentFilter(0, txtUAClientName.Text,
                                    txtUAPetName.Text, txtUAppointmentType.Text,
                                    txtUAStatus.Text, txtUAppointmentDate.Text)
        End If
    End Sub

    'STAFF PANEL STAFF PANEL STAFF PANEL
    Private Sub btnStaffGoTo_Click(sender As Object, e As EventArgs) Handles btnStaffGoTo.Click
        Me.Hide()
        UserRole.ReceiveRole("Admin")
        UserRole.Show()
    End Sub

    'STAFF FILTER
    Private Sub txtStaffID_TextChanged(sender As Object, e As EventArgs) Handles txtStaffID.TextChanged
        If Integer.TryParse(txtStaffID.Text, staffID) Then
            AdminModule.StaffFilter(staffID, txtStaffName.Text, txtStaffPosition.Text, txtStaffSpecialization.Text)
        Else
            AdminModule.StaffFilter(0, txtStaffName.Text, txtStaffPosition.Text, txtStaffSpecialization.Text)
        End If
    End Sub
    Private Sub txtStaffName_TextChanged(sender As Object, e As EventArgs) Handles txtStaffName.TextChanged
        If Integer.TryParse(txtStaffID.Text, staffID) Then
            AdminModule.StaffFilter(staffID, txtStaffName.Text, txtStaffPosition.Text, txtStaffSpecialization.Text)
        Else
            AdminModule.StaffFilter(0, txtStaffName.Text, txtStaffPosition.Text, txtStaffSpecialization.Text)
        End If
    End Sub
    Private Sub txtStaffPosition_TextChanged(sender As Object, e As EventArgs) Handles txtStaffPosition.TextChanged
        If Integer.TryParse(txtStaffID.Text, staffID) Then
            AdminModule.StaffFilter(staffID, txtStaffName.Text, txtStaffPosition.Text, txtStaffSpecialization.Text)
        Else
            AdminModule.StaffFilter(0, txtStaffName.Text, txtStaffPosition.Text, txtStaffSpecialization.Text)
        End If
    End Sub
    Private Sub txtStaffSpecialization_TextChanged(sender As Object, e As EventArgs) Handles txtStaffSpecialization.TextChanged
        If Integer.TryParse(txtStaffID.Text, staffID) Then
            AdminModule.StaffFilter(staffID, txtStaffName.Text, txtStaffPosition.Text, txtStaffSpecialization.Text)
        Else
            AdminModule.StaffFilter(0, txtStaffName.Text, txtStaffPosition.Text, txtStaffSpecialization.Text)
        End If
    End Sub

    'VACCINE PANEL VACCINE PANEL VACCINE PANEL VACCINE PANEL VACCINE PANEL VACCINE PANEL
    Private Sub btnAddVaccine_Click(sender As Object, e As EventArgs) Handles btnAddVaccine.Click
        Me.Hide()
        Vaccination.ReceiveValue("Add")
        Vaccination.ReceiveRole("Admin")
        Vaccination.Show()
    End Sub
    Private Sub btnUpdateVaccine_Click(sender As Object, e As EventArgs) Handles btnUpdateVaccine.Click
        Me.Hide()
        Vaccination.ReceiveValue("Edit")
        Vaccination.ReceiveRole("Admin")
        Vaccination.Show()
    End Sub
    Private Sub btnDeleteVaccine_Click(sender As Object, e As EventArgs) Handles btnDeleteVaccine.Click
        Me.Hide()
        Vaccination.ReceiveValue("Delete")
        Vaccination.ReceiveRole("Admin")
        Vaccination.Show()
    End Sub

    'VACCINE PROFILE
    Private Sub dgvVaccineTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVaccineTable.CellClick
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            ' Get the pet ID from the clicked row
            Dim idValue As Object = dgvVaccineTable.Rows(e.RowIndex).Cells("Vaccine_ID").Value

            If Not Convert.IsDBNull(idValue) Then
                Dim id As Integer = Convert.ToInt32(idValue)
                ' Load and display the profile picture for the selected pet
                AdminModule.LoadProfilePicture(id, vbEmpty, pcbStaffVaccine, "vaccine_info")
            Else
                ' Handle DBNull value, for example, show a message or take appropriate action
                MessageBox.Show("null.")
            End If
        End If
    End Sub

    'VACCINE FILTER
    Private Sub txtVaccineID_TextChanged(sender As Object, e As EventArgs) Handles txtVaccineID.TextChanged
        If Integer.TryParse(txtVaccineID.Text, vaccineID) Then
            AdminModule.VaccineFilter(vaccineID, txtVaccineName.Text, txtVaccineType.Text,
                                      txtVRecSpecies.Text, txtVManufacturer.Text)
        Else
            AdminModule.VaccineFilter(0, txtVaccineName.Text, txtVaccineType.Text,
                                      txtVRecSpecies.Text, txtVManufacturer.Text)
        End If
    End Sub
    Private Sub txtVaccineName_TextChanged(sender As Object, e As EventArgs) Handles txtVaccineName.TextChanged
        If Integer.TryParse(txtVaccineID.Text, vaccineID) Then
            AdminModule.VaccineFilter(vaccineID, txtVaccineName.Text, txtVaccineType.Text,
                                      txtVRecSpecies.Text, txtVManufacturer.Text)
        Else
            AdminModule.VaccineFilter(0, txtVaccineName.Text, txtVaccineType.Text,
                                      txtVRecSpecies.Text, txtVManufacturer.Text)
        End If
    End Sub
    Private Sub txtVaccineType_TextChanged(sender As Object, e As EventArgs) Handles txtVaccineType.TextChanged
        If Integer.TryParse(txtVaccineID.Text, vaccineID) Then
            AdminModule.VaccineFilter(vaccineID, txtVaccineName.Text, txtVaccineType.Text,
                                      txtVRecSpecies.Text, txtVManufacturer.Text)
        Else
            AdminModule.VaccineFilter(0, txtVaccineName.Text, txtVaccineType.Text,
                                      txtVRecSpecies.Text, txtVManufacturer.Text)
        End If
    End Sub
    Private Sub txtVRecSpecies_TextChanged(sender As Object, e As EventArgs) Handles txtVRecSpecies.TextChanged
        If Integer.TryParse(txtVaccineID.Text, vaccineID) Then
            AdminModule.VaccineFilter(vaccineID, txtVaccineName.Text, txtVaccineType.Text,
                                      txtVRecSpecies.Text, txtVManufacturer.Text)
        Else
            AdminModule.VaccineFilter(0, txtVaccineName.Text, txtVaccineType.Text,
                                      txtVRecSpecies.Text, txtVManufacturer.Text)
        End If
    End Sub
    Private Sub txtVManufacturer_TextChanged(sender As Object, e As EventArgs) Handles txtVManufacturer.TextChanged
        If Integer.TryParse(txtVaccineID.Text, vaccineID) Then
            AdminModule.VaccineFilter(vaccineID, txtVaccineName.Text, txtVaccineType.Text,
                                      txtVRecSpecies.Text, txtVManufacturer.Text)
        Else
            AdminModule.VaccineFilter(0, txtVaccineName.Text, txtVaccineType.Text,
                                      txtVRecSpecies.Text, txtVManufacturer.Text)
        End If
    End Sub

    'STAFF APPOINTMENT PANEL

    'PENDING APPOINTMENT
    Private Sub rbtnPending_MouseClick(sender As Object, e As MouseEventArgs) Handles rbtnPending.MouseClick
        AdminModule.LoadPendingAppointments()
    End Sub

    'ONGOING APPOINTMENT
    Private Sub rbtnOngoing_MouseClick(sender As Object, e As MouseEventArgs) Handles rbtnOngoing.MouseClick
        AdminModule.LoadOngoingAppointments()
    End Sub

    'FINISHED APPOINTMENT
    Private Sub rbtnFinished_MouseClick(sender As Object, e As MouseEventArgs) Handles rbtnFinished.MouseClick
        AdminModule.LoadFinishedAppointments()
    End Sub

    'ADMIN APPOINTMENT OPTIONS
    Private Sub dgvStaffAppointmentTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaffAppointmentTable.CellContentClick
        Try
            If dgvStaffAppointmentTable.Columns(e.ColumnIndex).Name = "Accept" Then
                If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
                    Dim appoID As Object = dgvStaffAppointmentTable.Rows(e.RowIndex).Cells("Appointment_ID").Value
                    Dim userID As Object = dgvStaffAppointmentTable.Rows(e.RowIndex).Cells("user_number").Value

                    If Not Convert.IsDBNull(appoID) Then
                        Dim aid As Integer = Convert.ToInt32(appoID)
                        Dim uid As Integer = Convert.ToInt32(userID)

                        Me.Hide()
                        Appointment.txtAppointmentId.Text = aid
                        Appointment.txtUserID.Text = uid
                        Appointment.ReceiveValue("Accept")
                        Appointment.ReceiveRole("Admin")
                        Appointment.Show()
                    Else
                        ' Handle DBNull value, for example, show a message or take appropriate action
                        MessageBox.Show("null.")
                    End If
                End If
            ElseIf dgvStaffAppointmentTable.Columns(e.ColumnIndex).Name = "Decline" Then
                If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
                    Dim appoID As Object = dgvStaffAppointmentTable.Rows(e.RowIndex).Cells("Appointment_ID").Value
                    Dim userID As Object = dgvStaffAppointmentTable.Rows(e.RowIndex).Cells("user_number").Value

                    If Not Convert.IsDBNull(appoID) Then
                        Dim aid As Integer = Convert.ToInt32(appoID)
                        Dim uid As Integer = Convert.ToInt32(userID)

                        Me.Hide()
                        Appointment.txtAppointmentId.Text = aid
                        Appointment.txtUserID.Text = uid
                        Appointment.ReceiveValue("Decline")
                        Appointment.ReceiveRole("Admin")
                        Appointment.Show()
                    Else
                        MessageBox.Show("null.")
                    End If
                End If
            ElseIf dgvStaffAppointmentTable.Columns(e.ColumnIndex).Name = "Finish" Then
                If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
                    Dim appoID As Object = dgvStaffAppointmentTable.Rows(e.RowIndex).Cells("Appointment_ID").Value
                    Dim userID As Object = dgvStaffAppointmentTable.Rows(e.RowIndex).Cells("user_number").Value
                    Dim assignedStaff As Object = dgvStaffAppointmentTable.Rows(e.RowIndex).Cells("Assigned_Staff").Value

                    If Not Convert.IsDBNull(appoID) Then
                        Dim aid As Integer = Convert.ToInt32(appoID)
                        Dim uid As Integer = Convert.ToInt32(userID)
                        Dim aStaff As String = Convert.ToString(assignedStaff)

                        Me.Hide()
                        Appointment.txtAppointmentId.Text = aid
                        Appointment.txtUserID.Text = uid
                        Appointment.txtAssignedStaff.Text = aStaff
                        Appointment.ReceiveValue("Finish")
                        Appointment.ReceiveRole("Admin")
                        Appointment.Show()
                    Else
                        MessageBox.Show("null.")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'MEDICINE PANEL MEDICINE PANEL MEDICINE PANEL MEDICINE PANEL MEDICINE PANEL
    Private Sub btnAddMedicine_Click(sender As Object, e As EventArgs) Handles btnAddMedicine.Click
        Me.Hide()
        Medicine.ReceiveValue("Add")
        Medicine.ReceiveRole("Admin")
        Medicine.Show()
    End Sub
    Private Sub btnUpdateMedicine_Click(sender As Object, e As EventArgs) Handles btnUpdateMedicine.Click
        Me.Hide()
        Medicine.ReceiveValue("Edit")
        Medicine.ReceiveRole("Admin")
        Medicine.Show()
    End Sub
    Private Sub btnDeleteMedicine_Click(sender As Object, e As EventArgs) Handles btnDeleteMedicine.Click
        Me.Hide()
        Medicine.ReceiveValue("Delete")
        Medicine.ReceiveRole("Admin")
        Medicine.Show()
    End Sub

    'MEDICINE PROFILE
    Private Sub dgvMedicineTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedicineTable.CellClick
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            Dim idValue As Object = dgvMedicineTable.Rows(e.RowIndex).Cells("Medicine_ID").Value

            If Not Convert.IsDBNull(idValue) Then
                Dim id As Integer = Convert.ToInt32(idValue)
                AdminModule.LoadProfilePicture(id, vbEmpty, pcbMedicineProfile, "medicine_info")
            Else
                MessageBox.Show("null.")
            End If
        End If
    End Sub

    'MEDICINE FILTER
    Private Sub txtMedicineID_TextChanged(sender As Object, e As EventArgs) Handles txtMedicineID.TextChanged
        If Integer.TryParse(txtMedicineID.Text, medicineID) Then
            AdminModule.MedicineFilter(medicineID, txtMedicineName.Text, txtBrandName.Text,
                                      txtGenericName.Text, txtMedicineManufacturer.Text)
        Else
            AdminModule.MedicineFilter(0, txtMedicineName.Text, txtBrandName.Text,
                                      txtGenericName.Text, txtMedicineManufacturer.Text)
        End If
    End Sub
    Private Sub txtMedicineName_TextChanged(sender As Object, e As EventArgs) Handles txtMedicineName.TextChanged
        If Integer.TryParse(txtMedicineID.Text, medicineID) Then
            AdminModule.MedicineFilter(medicineID, txtMedicineName.Text, txtBrandName.Text,
                                      txtGenericName.Text, txtMedicineManufacturer.Text)
        Else
            AdminModule.MedicineFilter(0, txtMedicineName.Text, txtBrandName.Text,
                                      txtGenericName.Text, txtMedicineManufacturer.Text)
        End If
    End Sub
    Private Sub txtGenericName_TextChanged(sender As Object, e As EventArgs) Handles txtGenericName.TextChanged
        If Integer.TryParse(txtMedicineID.Text, medicineID) Then
            AdminModule.MedicineFilter(medicineID, txtMedicineName.Text, txtBrandName.Text,
                                      txtGenericName.Text, txtMedicineManufacturer.Text)
        Else
            AdminModule.MedicineFilter(0, txtMedicineName.Text, txtBrandName.Text,
                                      txtGenericName.Text, txtMedicineManufacturer.Text)
        End If
    End Sub
    Private Sub txtBrandName_TextChanged(sender As Object, e As EventArgs) Handles txtBrandName.TextChanged
        If Integer.TryParse(txtMedicineID.Text, medicineID) Then
            AdminModule.MedicineFilter(medicineID, txtMedicineName.Text, txtBrandName.Text,
                                      txtGenericName.Text, txtMedicineManufacturer.Text)
        Else
            AdminModule.MedicineFilter(0, txtMedicineName.Text, txtBrandName.Text,
                                      txtGenericName.Text, txtMedicineManufacturer.Text)
        End If
    End Sub
    Private Sub txtMedicineManufacturer_TextChanged(sender As Object, e As EventArgs) Handles txtMedicineManufacturer.TextChanged
        If Integer.TryParse(txtMedicineID.Text, medicineID) Then
            AdminModule.MedicineFilter(medicineID, txtMedicineName.Text, txtBrandName.Text,
                                      txtGenericName.Text, txtMedicineManufacturer.Text)
        Else
            AdminModule.MedicineFilter(0, txtMedicineName.Text, txtBrandName.Text,
                                      txtGenericName.Text, txtMedicineManufacturer.Text)
        End If
    End Sub

    'LOAD DATA 
    Public Sub LoadInfoAdmin()
        'USER PANEL
        AdminModule.LoadUsers()
        AdminModule.GetTotal("user_info")
        'PET PANEL
        AdminModule.LoadUserPets()
        AdminModule.GetTotal("pet_info")
        'USER APPOINTMENT PANEL
        AdminModule.LoadUserAppointments()
        AdminModule.GetTotal("user_appointment")
        'STAFF PANEL
        AdminModule.LoadStaffs()
        AdminModule.GetTotal("clinic_personnel_info")
        'VACCINE PANEL
        AdminModule.LoadVaccines()
        AdminModule.GetTotal("vaccine_info")
        'MEDICINE PANEL
        AdminModule.LoadMedicines()
        AdminModule.GetTotal("medicine_info")
    End Sub

    Private Sub btnUserLoadReports_Click(sender As Object, e As EventArgs) Handles btnUserLoadReports.Click
        CrystalReport.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddPetMonitoring_Click(sender As Object, e As EventArgs) Handles btnAddPetMonitoring.Click

    End Sub
End Class