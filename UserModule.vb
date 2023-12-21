Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Globalization
Imports System.Text.RegularExpressions

Module UserModule
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlQuery As String
    Dim dtTable As New DataTable
    Dim adapter As New MySqlDataAdapter

    Dim petName, species, gender, breed, birthday, bio, currFood, currMed, currMedTake, weight As String
    Dim petId, appointmentId As Integer
    Dim behaveNotes, appointmentType, reason As String
    Dim profileImage As Byte()
    Dim preferredDateTime As String
    Dim dateObj As DateTime

    Dim firstName, lastName, contact, homeAddress, city, province,
        userName, password, securityQuestion As String

    Public Sub ConnectDbase()
        host = "127.0.0.1"
        dbname = "petpal"
        uname = "root"
        pwd = ""

        If Not con Is Nothing Then
            con.Close()
            con.ConnectionString = "server = " & host & "; user id = " & uname & "; password = " & pwd & "; database = " & dbname & ""
            Try
                con.Open()
                MessageBox.Show("Connected!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Public Sub LoadPets(id As Integer)
        sqlQuery = "SELECT pet_id, pet_name, species, gender, breed, birthday FROM pet_info WHERE user_number = @id"

        Try
            Using adapter As New MySqlDataAdapter(sqlQuery, con)
                adapter.SelectCommand.Parameters.AddWithValue("@id", id)

                dtTable = New DataTable
                adapter.Fill(dtTable)

                If dtTable.Rows.Count > 0 Then
                    ' Set the DataTable as the DataSource after clearing columns
                    UserPanel.dgvPets.DataSource = dtTable
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading pets: " & ex.Message)
        Finally
            ' Close the connection in the Finally block
            con.Close()
        End Try
    End Sub

    Public Sub LoadProfilePicture(petID As Integer, pictureBox As PictureBox)
        sqlQuery = "SELECT profileImage FROM pet_info WHERE pet_id = @petID AND user_number = @userNum;"

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                mysqlcmd.Parameters.AddWithValue("@petID", petID)
                mysqlcmd.Parameters.AddWithValue("@userNum", UserPanel.lblId.Text)

                Dim reader As MySqlDataReader = mysqlcmd.ExecuteReader()

                If reader.Read() Then

                    If Not reader.IsDBNull(reader.GetOrdinal("profileImage")) Then
                        Dim imageData As Byte() = DirectCast(reader("profileImage"), Byte())

                        Using imageStream As New MemoryStream(imageData)
                            Dim profileImage As Image = Image.FromStream(imageStream)
                            pictureBox.Image = profileImage
                        End Using
                    Else
                        pictureBox.Image = Nothing
                    End If
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading the profile picture: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub AddPet(id As Integer, profile As Byte())
        Dim selectedDate As DateTime = Pet.dtpTimeMedication.Value

        petName = Pet.txtPetName.Text
        species = Pet.cmbSpecies.Text
        gender = Pet.cmbGender.Text
        breed = Pet.txtBreed.Text
        birthday = Pet.dtpBirthday.Value.ToString("yyyy-MM-dd")
        bio = Pet.txtBio.Text
        currFood = Pet.txtCurrFood.Text
        currMed = Pet.txtCurrMed.Text
        currMedTake = selectedDate.ToString("yyyy-MM-dd hh:mm:ss")
        weight = Pet.txtWeight.Text

        '1st Query
        sqlQuery = "
            SELECT MAX(pet_id) FROM pet_info WHERE user_number = @userNum
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@userNum", id)

        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read() Then
                If Not reader.IsDBNull(0) Then
                    petId = reader.GetInt32(0) + 1
                Else
                    petId = 1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            reader.Close()
        End Try

        '2nd Query
        sqlQuery = "
            INSERT INTO pet_info(pet_id, pet_name, species, 
            gender, breed, birthday, bio, current_food, current_med, current_med_take, weight, profileImage, user_number)
            VALUES (@id, @petName, @species, @gender, @breed, @birthday, @bio, @currFood, @currMed, @currMedTake, 
            @weight, @profile, @userNum)
        "

        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@id", petId)
        mysqlcmd.Parameters.AddWithValue("@petName", petName)
        mysqlcmd.Parameters.AddWithValue("@species", species)
        mysqlcmd.Parameters.AddWithValue("@gender", gender)
        mysqlcmd.Parameters.AddWithValue("@breed", breed)
        mysqlcmd.Parameters.AddWithValue("@birthday", birthday)
        mysqlcmd.Parameters.AddWithValue("@bio", bio)
        mysqlcmd.Parameters.AddWithValue("@currFood", currFood)
        mysqlcmd.Parameters.AddWithValue("@currMed", currMed)
        mysqlcmd.Parameters.AddWithValue("@currMedTake", currMedTake)
        mysqlcmd.Parameters.AddWithValue("@weight", weight)
        mysqlcmd.Parameters.AddWithValue("@profile", profile)
        mysqlcmd.Parameters.AddWithValue("@userNum", id)

        Try
            mysqlcmd.ExecuteNonQuery()
            MsgBox("Added!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub

    Public Sub GetPetInfo(uid As String, pid As String)
        Dim id As String = pid
        Dim userNum As String = uid


        sqlQuery = "
            SELECT * FROM pet_info WHERE pet_id = @petId AND user_number = @userNum;
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@petId", id)
        mysqlcmd.Parameters.AddWithValue("@userNum", userNum)

        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read() Then
                Pet.txtPetName.Text = reader("pet_name").ToString
                Pet.cmbSpecies.Text = reader("species").ToString
                Pet.cmbGender.Text = reader("gender").ToString
                Pet.txtBreed.Text = reader("breed").ToString
                Pet.dtpBirthday.Value = reader.GetDateTime(reader.GetOrdinal("birthday"))
                Pet.txtBio.Text = reader("bio").ToString
                Pet.txtCurrFood.Text = reader("current_food").ToString
                Pet.txtCurrMed.Text = reader("current_med").ToString
                Pet.txtWeight.Text = reader("weight").ToString
            Else
                ' Handle the case where no records are found for the given pet_id
                MessageBox.Show("Pet not found.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            reader.Close()
        End Try

    End Sub

    'QUICK FIX: ERROR ON PET ID WHEN UPDATING PET INFO AS ADMIN
    Public Sub UpdatePetInfo(id As Integer, profile As Byte(), role As String)
        If role = "Admin" Then
            petId = Pet.txtAPetID.Text
        ElseIf role = "User" Then
            petId = Pet.txtPetId.Text
        End If
        petName = Pet.txtPetName.Text
        species = Pet.cmbSpecies.Text
        gender = Pet.cmbGender.Text
        breed = Pet.txtBreed.Text
        birthday = Pet.dtpBirthday.Value.ToString("yyyy-MM-dd")
        bio = Pet.txtBio.Text
        currFood = Pet.txtCurrFood.Text
        currMed = Pet.txtCurrMed.Text
        weight = Pet.txtWeight.Text

        sqlQuery = "
            UPDATE pet_info SET 
            pet_name = @petName, species = @species, gender = @gender, breed = @breed, bio = @bio, 
            birthday = @birthday, current_food = @currFood, current_med = @currMed, weight = @weight, 
            profileImage = @profile
            WHERE pet_id = @petID AND user_number = @userNum;
        "

        Try
            Using cmd As New MySqlCommand(sqlQuery, con)
                cmd.Parameters.AddWithValue("@petName", petName)
                cmd.Parameters.AddWithValue("@species", species)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@breed", breed)
                cmd.Parameters.AddWithValue("@bio", bio)
                cmd.Parameters.AddWithValue("@birthday", birthday)
                cmd.Parameters.AddWithValue("@currFood", currFood)
                cmd.Parameters.AddWithValue("@currMed", currMed)
                cmd.Parameters.AddWithValue("@weight", weight)
                cmd.Parameters.AddWithValue("@profile", profile)
                cmd.Parameters.AddWithValue("@petID", petId)
                cmd.Parameters.AddWithValue("@userNum", id)
                cmd.ExecuteNonQuery()
                MsgBox("Update Successfully")
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        End Try
    End Sub

    Public Sub DeletePetInfo(id As Integer, role As String)
        If role = "Admin" Then
            petId = Pet.txtAPetID.Text
        ElseIf role = "User" Then
            petId = Pet.txtPetId.Text
        End If

        sqlQuery = "DELETE from pet_info WHERE pet_id = @petID AND user_number = @userNum"

        Try
            Using cmd As New MySqlCommand(sqlQuery, con)
                cmd.Parameters.AddWithValue("@petID", petId)
                cmd.Parameters.AddWithValue("@userNum", id)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Deletion Successful!", vbInformation, "Delete Message")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        End Try
    End Sub

    Public Sub LoadUserInfo(id As Integer)

        '1st Query
        sqlQuery = "
            SELECT user_name, security_question FROM user_credentials WHERE user_number = @userNum;
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@userNum", id)

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            reader = mysqlcmd.ExecuteReader()

            If reader.Read Then
                UserPanel.lblUserName.Text = reader("user_name").ToString()
                UserPanel.lblQuestion.Text = reader("security_question").ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try

        '2nd Query
        sqlQuery = "
            SELECT * FROM user_info WHERE user_number = @userNum;
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@userNum", id)

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            reader = mysqlcmd.ExecuteReader()

            If reader.Read Then
                UserPanel.lblFName.Text = reader("fName").ToString()
                UserPanel.lblLName.Text = reader("lName").ToString()
                UserPanel.lblBirthdate.Text = reader("birthDate").ToString()
                UserPanel.lblContact.Text = reader("contact").ToString()
                UserPanel.lblHomeAdd.Text = reader("home_address").ToString()
                UserPanel.lblEmail.Text = reader("email").ToString()
                UserPanel.lblCity.Text = reader("city").ToString()
                UserPanel.lblProvince.Text = reader("province").ToString()

                If Not reader.IsDBNull(reader.GetOrdinal("profileImage")) Then
                    Dim imageData As Byte() = DirectCast(reader("profileImage"), Byte())

                    Dim imageStream As New MemoryStream(imageData)
                    Dim profileImage As Image = Image.FromStream(imageStream)

                    UserPanel.pcbUserProfile.Image = profileImage
                End If
            Else
                MsgBox("No Record")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub

    Public Sub LoadPetInfo(petID As String, id As String)
        sqlQuery = "SELECT pet_name, species, breed, gender, birthday, profileImage FROM pet_info 
                WHERE pet_id = @petID AND user_number = @userNum"

        Try
            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                mysqlcmd.Parameters.AddWithValue("@petID", petID)
                mysqlcmd.Parameters.AddWithValue("@userNum", id)

                Try
                    Using reader As MySqlDataReader = mysqlcmd.ExecuteReader()
                        If reader.Read() Then
                            Appointment.txtPetName.Text = reader("pet_name").ToString()
                            Appointment.txtSpecies.Text = reader("species").ToString()
                            Appointment.txtBreed.Text = reader("breed").ToString()
                            Appointment.txtGender.Text = reader("gender").ToString()
                            Appointment.dtpBirthDate.Value = reader("birthday").ToString()
                        End If

                        If Not reader.IsDBNull(reader.GetOrdinal("profileImage")) Then
                            Dim imageData As Byte() = DirectCast(reader("profileImage"), Byte())
                            If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                                ' Convert binary data to an Image
                                Using ms As New MemoryStream(imageData)
                                    Appointment.pcbDisplay.Image = Image.FromStream(ms)
                                End Using
                            End If
                        Else
                            Appointment.pcbDisplay.Image = Nothing
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading data from database: " & ex.Message)
                Finally
                    ' Check if the reader is not null before attempting to close it
                    If reader IsNot Nothing Then
                        reader.Close()
                    End If
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("Error executing SQL command: " & ex.Message)
        End Try
    End Sub

    'DONE
    Public Sub SubmitAppointment(uid As Integer)
        Dim selectedDateOne As DateTime = Appointment.dtpBirthDate.Value
        Dim selectedDateTwo As DateTime = Appointment.dtpDateAppo.Value

        petId = Appointment.txtPetID.Text
        petName = Appointment.txtPetName.Text
        species = Appointment.txtSpecies.Text
        birthday = selectedDateOne.ToString("yyyy-MM-dd")
        breed = Appointment.txtBreed.Text
        gender = Appointment.txtGender.Text
        behaveNotes = Appointment.txtNotes.Text

        appointmentType = Appointment.cmbAppointment.Text
        preferredDateTime = selectedDateTwo.ToString("yyyy-MM-dd hh:mm:ss")
        reason = Appointment.txtReason.Text

        '1st Query : Get the max appointment count
        sqlQuery = "
            SELECT MAX(id) FROM user_appointment WHERE user_number = @userNum
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@userNum", uid)

        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read() Then
                If Not reader.IsDBNull(0) Then
                    appointmentId = reader.GetInt32(0) + 1
                Else
                    appointmentId = 1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            reader.Close()
        End Try

        '2nd Query
        sqlQuery = "
            SELECT profileImage FROM pet_info WHERE user_number = @userNum AND pet_id = @petId
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@userNum", uid)
        mysqlcmd.Parameters.AddWithValue("@petId", petId)

        Try
            Dim result As Object = mysqlcmd.ExecuteScalar()

            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                profileImage = DirectCast(result, Byte())
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '3rd Query
        sqlQuery = "
            INSERT INTO user_appointment (
            id, petName, ownerName, petBreed, petSpecies, petGender, birthDate, 
            behavioralNotes, profileImage, appointment_type, preferredDate, assignedStaff, 
            appointmentReason, appointmentStatus, pet_ID, user_number
            )
        VALUES (
            @appId, @petName, 
            (SELECT CONCAT(fName, ' ', lName) FROM user_info WHERE user_number = @userNum), 
            @breed, @species, @gender, @birthday,
            @behavioralNotes, @profileImage, @appointmentType, @preferredDate, @assignedStaff, 
            @appointmentReason, @appointmentStatus, @petId, @userNum
            )
        "

        Using mysqlcmd As New MySqlCommand(sqlQuery, con)
            mysqlcmd.Parameters.AddWithValue("@appId", appointmentId)
            mysqlcmd.Parameters.AddWithValue("@petName", petName)
            mysqlcmd.Parameters.AddWithValue("@userNum", uid)
            mysqlcmd.Parameters.AddWithValue("@species", species)
            mysqlcmd.Parameters.AddWithValue("@breed", breed)
            mysqlcmd.Parameters.AddWithValue("@gender", gender)
            mysqlcmd.Parameters.AddWithValue("@birthday", birthday)
            mysqlcmd.Parameters.AddWithValue("@behavioralNotes", behaveNotes)
            mysqlcmd.Parameters.AddWithValue("@profileImage", profileImage)
            mysqlcmd.Parameters.AddWithValue("@appointmentType", appointmentType)
            mysqlcmd.Parameters.AddWithValue("@preferredDate", preferredDateTime)
            mysqlcmd.Parameters.AddWithValue("@assignedStaff", "")
            mysqlcmd.Parameters.AddWithValue("@appointmentReason", reason)
            mysqlcmd.Parameters.AddWithValue("@appointmentStatus", "Pending")
            mysqlcmd.Parameters.AddWithValue("@petId", petId)
            Try
                mysqlcmd.ExecuteNonQuery()
                MsgBox("Added!")
            Catch ex As Exception
                MsgBox("Error adding data to database: " & ex.Message)
            Finally
                con.Close()
            End Try
        End Using

    End Sub
    Public Sub GetAppointmentInfo(uid As Integer)
        Dim appoId As String = Appointment.txtAppointmentId.Text

        sqlQuery = "
            SELECT petName, petBreed, petSpecies, petGender, birthDate, behavioralNotes, profileImage,
            appointment_type, preferredDate, assignedStaff, appointmentReason, pet_ID
            FROM user_appointment 
            WHERE id = @appoId AND user_number = @userNum;
        "

        mysqlcmd = New MySqlCommand(sqlQuery, con)

        Try
            mysqlcmd.Parameters.AddWithValue("@appoId", appoId)
            mysqlcmd.Parameters.AddWithValue("@userNum", uid)

            Using reader As MySqlDataReader = mysqlcmd.ExecuteReader()
                If reader.Read() Then ' Move to the first row
                    Appointment.txtPetName.Text = reader("petName").ToString
                    Appointment.txtPetID.Text = reader("pet_ID").ToString
                    Appointment.txtBreed.Text = reader("petBreed").ToString
                    Appointment.txtSpecies.Text = reader("petSpecies").ToString
                    Appointment.dtpBirthDate.Value = Convert.ToDateTime(reader("birthDate"))
                    Appointment.txtGender.Text = reader("petGender").ToString
                    Appointment.txtNotes.Text = reader("behavioralNotes").ToString
                    Appointment.cmbAppointment.Text = reader("appointment_type").ToString
                    Appointment.dtpDateAppo.Text = Convert.ToDateTime(reader("preferredDate"))
                    Appointment.txtAssignedStaff.Text = reader("assignedStaff").ToString
                    Appointment.txtReason.Text = reader("appointmentReason").ToString

                    If Not reader.IsDBNull(reader.GetOrdinal("profileImage")) Then
                        Dim imageData As Byte() = DirectCast(reader("profileImage"), Byte())
                        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                            Using ms As New MemoryStream(imageData)
                                Appointment.pcbDisplay.Image = Image.FromStream(ms)
                            End Using
                        End If
                    Else
                        Appointment.pcbDisplay.Image = Nothing
                    End If
                Else
                    ' Handle the case where no records are found for the given pet_id
                    MessageBox.Show("Scheduled Appointment not found.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If reader IsNot Nothing Then
                reader.Close()
            End If
        End Try
    End Sub
    Public Sub UpdateAppointment(uid As Integer, appoStatus As String)
        Dim selectedDate As DateTime = Appointment.dtpDateAppo.Value
        Dim assignedStaff As String = Appointment.txtAssignedStaff.Text

        behaveNotes = Appointment.txtNotes.Text
        appointmentType = Appointment.cmbAppointment.Text
        preferredDateTime = selectedDate.ToString("yyyy-MM-dd hh:mm:ss")
        reason = Appointment.txtReason.Text

        sqlQuery = "
            UPDATE user_appointment SET 
            behavioralNotes = @notes, appointment_type = @appoType, preferredDate = @preferredDate, 
            appointmentReason = @reason, assignedStaff = @assignedStaff, appointmentStatus = @appoStatus
            WHERE id = @appointment_id AND user_number = @userNum
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)

        If con.State <> ConnectionState.Open Then
            con.Open()
        End If

        Try
            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                mysqlcmd.Parameters.AddWithValue("@appointment_id", Appointment.txtAppointmentId.Text)
                mysqlcmd.Parameters.AddWithValue("@userNum", uid)
                mysqlcmd.Parameters.AddWithValue("@notes", behaveNotes)
                mysqlcmd.Parameters.AddWithValue("@appoType", appointmentType)
                mysqlcmd.Parameters.AddWithValue("@preferredDate", preferredDateTime)
                mysqlcmd.Parameters.AddWithValue("@reason", reason)
                mysqlcmd.Parameters.AddWithValue("@assignedStaff", assignedStaff)
                mysqlcmd.Parameters.AddWithValue("@appoStatus", appoStatus)
                mysqlcmd.ExecuteNonQuery()
                MsgBox("Update Successfully")
            End Using
        Catch ex As Exception
            MsgBox("MySQL Error: " & ex.Message)
        End Try

    End Sub
    Public Sub CancelAppointment(uid As Integer)
        Dim appoId As String = Appointment.txtAppointmentId.Text

        sqlQuery = "
            DELETE FROM user_appointment WHERE id = @appoID AND user_number = @userNum
        "
        Try
            Using cmd As New MySqlCommand(sqlQuery, con)
                cmd.Parameters.AddWithValue("@appoID", appoId)
                cmd.Parameters.AddWithValue("@userNum", uid)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Appointment Has been Cancelled", vbInformation, "Delete Message")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        End Try

    End Sub
    Public Sub SearchStaffAssign(staffID As Integer)
        sqlQuery = "
            SELECT CONCAT(fName, ' ', mName, ' ', lName) AS staffName FROM clinic_personnel_info WHERE id = @staffID
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@staffID", staffID) ' Fixed parameter name

        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read Then
                Appointment.txtAssignedStaff.Text = reader("staffName").ToString()
            Else
                MsgBox("No Record")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If reader IsNot Nothing Then
                reader.Close()
            End If
        End Try
    End Sub
End Module
