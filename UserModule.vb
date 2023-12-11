Imports MySql.Data.MySqlClient
Imports System.IO

Module UserModule
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlQuery As String
    Dim dtTable As New DataTable
    Dim adapter As New MySqlDataAdapter

    Dim petName, species, gender, breed, birthday, bio, currFood, currMed, weight As String
    Dim petId As Integer
    Dim behaveNotes, appointmentType, preferredDate, reason As String

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
        Dim sqlQuery As String = "SELECT profileImage FROM pet_info WHERE pet_id = @petID"

        Try
            ' Open the connection before using it
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                mysqlcmd.Parameters.AddWithValue("@petID", petID)

                Dim reader As MySqlDataReader = mysqlcmd.ExecuteReader()

                If reader.Read() Then
                    ' Check if the profileImage column is not null
                    If Not reader.IsDBNull(reader.GetOrdinal("profileImage")) Then
                        ' Get the BLOB data as a byte array
                        Dim imageData As Byte() = DirectCast(reader("profileImage"), Byte())

                        ' Convert the byte array to an Image
                        Dim imageStream As New MemoryStream(imageData)
                        Dim profileImage As Image = Image.FromStream(imageStream)

                        ' Set the image to the PictureBox control
                        pictureBox.Image = profileImage
                    Else
                        ' Handle the case where the profileImage column is null
                        ' Set a default image or do other handling
                        MsgBox("b")
                        pictureBox.Image = Nothing
                    End If
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading the profile picture: " & ex.Message)
        Finally
            ' Close the connection in the Finally block
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
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Public Sub LoadPetInfo(pet As String, id As String)
        sqlQuery = "SELECT species, breed, gender, birthday, profileImage FROM pet_info 
                WHERE pet_name = @petName AND user_number = @userNum
        "

        Using mysqlcmd As New MySqlCommand(sqlQuery, con)
            mysqlcmd.Parameters.AddWithValue("@petName", pet)
            mysqlcmd.Parameters.AddWithValue("@userNum", id)

            Try
                ' Execute the SQL command and read the data
                Using reader As MySqlDataReader = mysqlcmd.ExecuteReader()
                    If reader.Read() Then
                        ' Populate TextBoxes with data from the database
                        Appointment.txtSpecies.Text = reader("species").ToString()
                        Appointment.txtBreed.Text = reader("breed").ToString()
                        Appointment.txtGender.Text = reader("gender").ToString()
                        Appointment.txtBirth.Text = reader("birthday").ToString()
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
                        ' Handle the case when "profileImage" is NULL
                        ' You might want to set a default image or clear the PictureBox
                        Appointment.pcbDisplay.Image = Nothing
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data from database: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub SubmitAppointment()
        petName = Appointment.cmbPets.Text
        species = Appointment.txtSpecies.Text
        breed = Appointment.txtBreed.Text
        gender = Appointment.txtGender.Text
        birthday = Appointment.txtBirth.Text
        behaveNotes = Appointment.txtNotes.Text
        appointmentType = Appointment.cmbAppointment.Text
        preferredDate = Appointment.dtpDateAppointment.Value.ToString("yyyy-MM-dd")
        reason = Appointment.txtReason.Text
    End Sub
End Module
