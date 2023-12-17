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

    Dim petName, species, gender, breed, birthday, bio, currFood, currMed, weight As String
    Dim petId, appointmentId As Integer
    Dim behaveNotes, appointmentType, reason As String
    Dim profileImage As Byte()
    Dim preferredDateTime As String
    Dim dateObj As DateTime

    Dim firstName, lastName, contact, homeAddress, city, province,
        userName, password, securityQuestion As String

    Public Sub ConnectDbase()
        host = "192.168.56.1"
        dbname = "client_credentials"
        uname = "frieren"
        pwd = "pass"

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
                MsgBox(petID)
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
        petName = Pet.txtPetName.Text
        species = Pet.cmbSpecies.Text
        gender = Pet.cmbGender.Text
        breed = Pet.txtBreed.Text
        birthday = Pet.dtpBirthday.Value.ToString("yyyy-MM-dd")
        bio = Pet.txtBio.Text
        currFood = Pet.txtCurrFood.Text
        currMed = Pet.txtCurrMed.Text
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
            gender, breed, birthday, bio, current_food, current_med, weight, profileImage, user_number)
            VALUES (@id, @petName, @species, @gender, @breed, @birthday, @bio, @currFood, @currMed, @weight,
            @profile, @userNum)
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

    Public Sub GetPetInfo()
        Dim id As String = Pet.txtPetId.Text
        Dim userNum As String = UserPanel.lblId.Text


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

    Public Sub UpdatePetInfo(id As Integer, profile As Byte())
        petId = Pet.txtPetId.Text
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

    Public Sub DeletePetInfo(id As Integer)
        petId = Pet.txtPetId.Text

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

    Public Sub DeleteProfile()
        sqlQuery = "DELETE from user_info WHERE user_number = @userNum"

        Try
            Using cmd As New MySqlCommand(sqlQuery, con)
                cmd.Parameters.AddWithValue("@userNum", UserPanel.lblId.Text)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Deletion Successful!", vbInformation, "Delete Message")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        End Try

        sqlQuery = "DELETE from pet_info WHERE user_number = @userNum"
        Try
            Using cmd As New MySqlCommand(sqlQuery, con)
                cmd.Parameters.AddWithValue("@userNum", UserPanel.lblId.Text)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Deletion Successful!", vbInformation, "Delete Message")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        End Try

        sqlQuery = "DELETE from appointment_info WHERE user_number = @userNum"
        Try
            Using cmd As New MySqlCommand(sqlQuery, con)
                cmd.Parameters.AddWithValue("@userNum", UserPanel.lblId.Text)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Deletion Successful!", vbInformation, "Delete Message")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        End Try

        sqlQuery = "DELETE from user_credentials WHERE user_number = @userNum"
        Try
            Using cmd As New MySqlCommand(sqlQuery, con)
                cmd.Parameters.AddWithValue("@userNum", UserPanel.lblId.Text)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Deletion Successful!", vbInformation, "Delete Message")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        End Try
    End Sub

    Public Sub LoadPetName(id As Integer)
        sqlQuery = "SELECT pet_name FROM pet_info WHERE user_number = @userNum"

        Try
            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                mysqlcmd.Parameters.AddWithValue("@userNum", id)

                Using reader As MySqlDataReader = mysqlcmd.ExecuteReader()
                    Appointment.cmbPets.Items.Clear()

                    While reader.Read()
                        Appointment.cmbPets.Items.Add(reader("pet_name").ToString())
                    End While

                    ' Close the DataReader after reading the data
                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            ' Check if the reader is not null before attempting to close it
            If reader IsNot Nothing AndAlso Not reader.IsClosed Then
                reader.Close()
            End If
        End Try
    End Sub

    Public Sub LoadPetInfo(pet As String, id As String)
        sqlQuery = "SELECT pet_id, species, breed, gender, birthday, profileImage FROM pet_info 
                WHERE pet_name = @petName AND user_number = @userNum"

        Try
            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                mysqlcmd.Parameters.AddWithValue("@petName", pet)
                mysqlcmd.Parameters.AddWithValue("@userNum", id)

                Try
                    ' Execute the SQL command and read the data
                    Using reader As MySqlDataReader = mysqlcmd.ExecuteReader()

                        If reader.Read() Then
                            ' Populate TextBoxes with data from the database
                            Appointment.txtPetID.Text = reader("pet_id").ToString()
                            Appointment.txtSpecies.Text = reader("species").ToString()
                            Appointment.txtBreed.Text = reader("breed").ToString()
                            Appointment.txtGender.Text = reader("gender").ToString()
                            Appointment.txtBirth.Text = Convert.ToDateTime(reader("birthday")).ToString("MM/dd/yyyy")
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
                        MsgBox("a")
                        reader.Close()
                    End If
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("Error executing SQL command: " & ex.Message)
        End Try
    End Sub

    Public Sub SubmitAppointment()
        petId = Appointment.txtPetID.Text
        petName = Appointment.cmbPets.Text
        species = Appointment.txtSpecies.Text
        breed = Appointment.txtBreed.Text
        gender = Appointment.txtGender.Text
        behaveNotes = Appointment.txtNotes.Text

        appointmentType = Appointment.cmbAppointment.Text
        preferredDateTime = Appointment.dtpDateAppo.Value.ToString("yyyy-MM-dd") & " " &
            Appointment.dtpTimeAppo.Value.ToString("HH:mm:ss")
        reason = Appointment.txtReason.Text

        dateObj = DateTime.ParseExact(Appointment.txtBirth.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture)
        birthday = dateObj.ToString("yyyy-MM-dd")


        '1st Query : Get the max appointment count
        sqlQuery = "
            SELECT MAX(appointment_id) FROM appointment_info WHERE user_number = @userNum
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@userNum", UserPanel.lblId.Text)

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
        mysqlcmd.Parameters.AddWithValue("@userNum", UserPanel.lblId.Text)
        mysqlcmd.Parameters.AddWithValue("@petId", petId)

        Try
            ' Use ExecuteScalar to retrieve a single value
            Dim result As Object = mysqlcmd.ExecuteScalar()

            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                ' Successfully retrieved the BLOB, assuming profileImage is a Byte() data type
                profileImage = DirectCast(result, Byte())
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '3rd Query
        sqlQuery = "
            INSERT INTO appointment_info (
            appointment_id, pet_name, species, breed, gender, birthDate, behavioral_notes, pet_image, 
            appointment_type, preferredDate, appointment_reason, appointment_status, pet_id, user_number )
            VALUES (@appId, @petName, @species, @breed, @gender, @birthday, @behavioralNotes, 
            @petImage, @appointmentType, @preferredDate, @appointmentReason, @appointmentStatus, 
            @petId, @userNum)
        "
        Using mysqlcmd As New MySqlCommand(sqlQuery, con)
            mysqlcmd.Parameters.AddWithValue("@appId", appointmentId)
            mysqlcmd.Parameters.AddWithValue("@petName", petName)
            mysqlcmd.Parameters.AddWithValue("@species", species)
            mysqlcmd.Parameters.AddWithValue("@breed", breed)
            mysqlcmd.Parameters.AddWithValue("@gender", gender)
            mysqlcmd.Parameters.AddWithValue("@birthday", birthday)
            mysqlcmd.Parameters.AddWithValue("@behavioralNotes", behaveNotes)
            mysqlcmd.Parameters.AddWithValue("@petImage", profileImage)
            mysqlcmd.Parameters.AddWithValue("@appointmentType", appointmentType)
            mysqlcmd.Parameters.AddWithValue("@preferredDate", preferredDateTime)
            mysqlcmd.Parameters.AddWithValue("@appointmentReason", reason)
            mysqlcmd.Parameters.AddWithValue("@appointmentStatus", "Pending")
            mysqlcmd.Parameters.AddWithValue("@petId", petId)
            mysqlcmd.Parameters.AddWithValue("@userNum", UserPanel.lblId.Text)

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

    Public Sub GetAppointmentInfo()
        Dim appoId = Appointment.txtAppointmentId.Text
        Dim userNum = UserPanel.lblId.Text
        Dim wholeDate As String

        sqlQuery = "
            SELECT pet_name, species, breed, gender, birthDate, behavioral_notes, pet_image, appointment_type,
            preferredDate, appointment_reason, pet_id
            FROM appointment_info WHERE appointment_id = @appoId AND user_number = @userNum;
        "

        mysqlcmd = New MySqlCommand(sqlQuery, con)

        Try
            mysqlcmd.Parameters.AddWithValue("@appoId", appoId)
            mysqlcmd.Parameters.AddWithValue("@userNum", userNum)

            Using reader As MySqlDataReader = mysqlcmd.ExecuteReader()
                If reader.Read() Then
                    wholeDate = reader("preferredDate").ToString
                    Dim newDate = DateTime.ParseExact(wholeDate, "MM/dd/yyyy h:mm:ss tt",
               Globalization.CultureInfo.InvariantCulture)

                    Dim datePart As String = newDate.ToString("MM/dd/yyyy")
                    Dim timePart As String = newDate.ToString("HH:mm:ss")

                    Appointment.cmbPets.Text = reader("pet_name").ToString
                    Appointment.txtPetID.Text = reader("pet_id").ToString
                    Appointment.txtBreed.Text = reader("breed").ToString
                    Appointment.txtSpecies.Text = reader("species").ToString
                    Appointment.txtBirth.Text = reader("birthDate").ToString
                    Appointment.txtGender.Text = reader("gender").ToString
                    Appointment.txtNotes.Text = reader("behavioral_notes").ToString
                    Appointment.cmbAppointment.Text = reader("appointment_type").ToString
                    Appointment.dtpDateAppo.Text = datePart
                    Appointment.dtpTimeAppo.Text = timePart
                    Appointment.txtReason.Text = reader("appointment_reason").ToString

                    MsgBox("Appointment.cmbPets.Text: " & Appointment.cmbPets.Text)
                    MsgBox("reader: " & reader("pet_name").ToString)
                Else
                    ' Handle the case where no records are found for the given pet_id
                    MessageBox.Show("Scheduled Appointment not found.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            ' Check if the reader is not null before attempting to close it
            If reader IsNot Nothing Then
                MsgBox("a")
                reader.Close()
            End If
        End Try
    End Sub

    Public Sub UpdateAppointment()
        behaveNotes = Appointment.txtNotes.Text
        appointmentType = Appointment.cmbAppointment.Text
        preferredDateTime = Appointment.dtpDateAppo.Value.ToString("yyyy-MM-dd") & " " &
            Appointment.dtpTimeAppo.Value.ToString("HH:mm:ss")
        reason = Appointment.txtReason.Text

        'dateObj = DateTime.ParseExact(Appointment.txtBirth.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture)
        'birthday = dateObj.ToString("yyyy-MM-dd")

        sqlQuery = "
            UPDATE appointment_info SET 
            behavioral_notes = @notes, appointment_type = @appoType, preferredDate = @preferredDate, 
            appointment_reason = @reason
            WHERE appointment_id = @appointment_id AND user_number = @userNum
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)

        If con.State <> ConnectionState.Open Then
            con.Open()
        End If

        Try
            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                mysqlcmd.Parameters.AddWithValue("@appointment_id", Appointment.txtAppointmentId.Text)
                mysqlcmd.Parameters.AddWithValue("@userNum", UserPanel.lblId.Text)
                mysqlcmd.Parameters.AddWithValue("@notes", behaveNotes)
                mysqlcmd.Parameters.AddWithValue("@appoType", appointmentType)
                mysqlcmd.Parameters.AddWithValue("@preferredDate", preferredDateTime)
                mysqlcmd.Parameters.AddWithValue("@reason", reason)
                mysqlcmd.ExecuteNonQuery()
                MsgBox("Update Successfully")
            End Using
        Catch ex As Exception
            MsgBox("MySQL Error: " & ex.Message)
        End Try

    End Sub
    Public Sub CancelAppointment()
        sqlQuery = "
            INSERT INTO staff_notification(client_name, email, notif_message, user_number) VALUES(
            @email, @message, @userNum
            );
        "


    End Sub
End Module
