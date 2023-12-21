Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Globalization
Imports System.Text.RegularExpressions

Module AdminModule
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlQuery As String
    Dim dtTable As New DataTable
    Dim adapter As New MySqlDataAdapter
    Dim ds As DataSet
    Dim bs As BindingSource

    Public Sub ConnectDbase()
        host = "127.0.0.1"
        dbname = "petpal"
        uname = "root"
        pwd = ""

        If Not con Is Nothing Then
            con.Close()
            con.ConnectionString = "server = " & host & "; user id = " & uname & "; password = " & pwd & "; database = " & dbname & ";"
            Try
                con.Open()
                MessageBox.Show("Connected!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    'USER TABS 

    'LOAD ALL USERS INFORMATION AND PUT IT INTO THE TABLE
    Public Sub LoadUsers()
        sqlQuery = "SELECT id, CONCAT(fName, ' ', lName) AS Name, birthDate AS BirthDate, 
                    contact AS Contact, email AS Email, home_address AS `Home Address`, 
                    city AS City, province AS Province, user_number FROM user_info"

        Try
            Using adapter As New MySqlDataAdapter(sqlQuery, con)
                dtTable = New DataTable
                adapter.Fill(dtTable)

                If dtTable.Rows.Count > 0 Then
                    AdminPanel.dgvUserTable.DataSource = dtTable
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading users: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'USER FILTER
    Public Sub UserNameFilter(id As Integer, nameFilter As String, cityFilter As String, contactFilter As String, provinceFilter As String)
        Dim dt As DataTable = CType(AdminPanel.dgvUserTable.DataSource, DataTable)

        If dt IsNot Nothing Then
            Dim compoundFilter As String = ""

            If id > 0 Then
                compoundFilter = $"id = '{id}'"
            End If

            If Not String.IsNullOrEmpty(nameFilter) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Name LIKE '%{nameFilter}%'"
            End If

            If Not String.IsNullOrEmpty(contactFilter) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Contact LIKE '%{contactFilter}%'"
            End If

            If Not String.IsNullOrEmpty(cityFilter) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"City LIKE '%{cityFilter}%'"
            End If

            If Not String.IsNullOrEmpty(provinceFilter) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Province LIKE '%{provinceFilter}%'"
            End If

            dt.DefaultView.RowFilter = compoundFilter
        End If
    End Sub


    'PET TABS

    'LOAD ALL PETS INFORMATION AND PUT IT INTO THE TABLE
    Public Sub LoadUserPets()
        sqlQuery = "SELECT pet_id AS PetID, pet_name AS Pet_Name, 
                    CONCAT(user_info.fName, ' ', user_info.lName) As Owner_Name, species AS Species, 
                    gender AS Gender, breed AS Breed, bio AS Bio, birthday As Birthday, 
                    current_food AS Current_Food, current_med AS Current_Medication, 
                    current_med_take As `Time of Medication`, weight AS Weight,
                    pet_info.user_number FROM pet_info 
                    INNER JOIN user_info ON pet_info.user_number = user_info.user_number"
        Try
            Using adapter As New MySqlDataAdapter(sqlQuery, con)
                dtTable = New DataTable
                adapter.Fill(dtTable)

                If dtTable.Rows.Count > 0 Then
                    AdminPanel.dgvPetTable.DataSource = dtTable
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading pets: " & ex.Message)
        Finally
            ' Close the connection in the Finally block
            con.Close()
        End Try
    End Sub

    'PET FILTER
    Public Sub PetFilter(id As Integer, petName As String, petSpecies As String, petBreed As String, ownerName As String)
        Dim dt As DataTable = CType(AdminPanel.dgvPetTable.DataSource, DataTable)

        If dt IsNot Nothing Then
            Dim compoundFilter As String = ""

            If id > 0 Then
                compoundFilter = $"PetID = '{id}'"
            End If

            If Not String.IsNullOrEmpty(petName) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Pet_Name LIKE '%{petName}%'"
            End If

            If Not String.IsNullOrEmpty(petSpecies) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Species LIKE '%{petSpecies}%'"
            End If

            If Not String.IsNullOrEmpty(petBreed) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Breed LIKE '%{petBreed}%'"
            End If

            If Not String.IsNullOrEmpty(ownerName) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Owner_Name LIKE '%{ownerName}%'"
            End If

            dt.DefaultView.RowFilter = compoundFilter
        End If
    End Sub


    'USER APPOINTMENT TABS

    'LOAD ALL USER APPOINTMENT INFORMATION AND PUT INTO THE TABLE
    Public Sub LoadUserAppointments()
        sqlQuery = "SELECT id AS Appointment_ID, petName AS Pet_Name, ownerName AS Pet_Owner, 
                    petBreed As Breed, petSpecies AS Species, 
                    petGender AS Gender, birthDate AS BirthDate, appointment_type AS Appointment_Type,
                    preferredDate As Preffered_Date_of_Appointment, assignedStaff AS Assigned_Staff,
                    appointmentStatus As Appointment_Status, pet_ID AS PetID, user_number AS user_number
                    FROM user_appointment"
        Try
            Using adapter As New MySqlDataAdapter(sqlQuery, con)
                dtTable = New DataTable
                adapter.Fill(dtTable)

                If dtTable.Rows.Count > 0 Then
                    AdminPanel.dgvUserAppointment.DataSource = dtTable
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading pets: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'APPOINTMENT FILTER
    Public Sub UserAppointmentFilter(id As Integer, clientName As String, petName As String, appointmentType As String, status As String, appointmentDate As String)
        Dim dt As DataTable = CType(AdminPanel.dgvUserAppointment.DataSource, DataTable)

        If dt IsNot Nothing Then
            Dim compoundFilter As String = ""

            If id > 0 Then
                compoundFilter = $"Appointment_ID = '{id}'"
            End If

            If Not String.IsNullOrEmpty(clientName) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Pet_Owner LIKE '%{clientName}%'"
            End If

            If Not String.IsNullOrEmpty(petName) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Pet_Name LIKE '%{petName}%'"
            End If

            If Not String.IsNullOrEmpty(appointmentType) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Appointment_Type LIKE '%{appointmentType}%'"
            End If

            If Not String.IsNullOrEmpty(status) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Appointment_Status LIKE '%{status}%'"
            End If

            If Not String.IsNullOrEmpty(appointmentDate) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"CONVERT(Preffered_Date_of_Appointment, 'System.String') LIKE '%{appointmentDate}%'"
            End If

            dt.DefaultView.RowFilter = compoundFilter
        End If
    End Sub

    'STAFF TABS

    ' LOAD ALL STAFFS INFORMATION AND PUT INTO THE TABLE
    Public Sub LoadStaffs()
        sqlQuery = "SELECT id AS StaffID, CONCAT(fName, ' ', mName, ' ', lName) AS Staff_Name, address AS Address,
                    position AS Position, specialization AS Specialization, department AS Department,
                    workingHours AS Working_Hours, salary AS Salary, startDate AS Date_of_Employment
                    FROM clinic_personnel_info"
        Try
            Using adapter As New MySqlDataAdapter(sqlQuery, con)
                dtTable = New DataTable
                adapter.Fill(dtTable)

                If dtTable.Rows.Count > 0 Then
                    AdminPanel.dgvStaffTable.DataSource = dtTable
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading staffs: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'STAFF FILTER
    Public Sub StaffFilter(id As Integer, staffName As String, staffPosition As String, staffSpecialization As String)
        Dim dt As DataTable = CType(AdminPanel.dgvStaffTable.DataSource, DataTable)

        If dt IsNot Nothing Then
            Dim compoundFilter As String = ""

            If id > 0 Then
                compoundFilter = $"StaffID = '{id}'"
            End If

            If Not String.IsNullOrEmpty(staffName) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Staff_Name LIKE '%{staffName}%'"
            End If

            If Not String.IsNullOrEmpty(staffPosition) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Position LIKE '%{staffPosition}%'"
            End If

            If Not String.IsNullOrEmpty(staffSpecialization) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Specialization LIKE '%{staffSpecialization}%'"
            End If

            dt.DefaultView.RowFilter = compoundFilter
        End If
    End Sub

    'LOAD ALL VACCINE INFORMATION AND PUT INTO THE TABLE
    Public Sub LoadVaccines()
        sqlQuery = "SELECT id AS Vaccine_ID, vaccineName AS Vaccine_Name, vaccineType AS Vaccine_Type,
                    manufacturer AS Manufacturer, expiryDate AS Expiry_Date, 
                    recommendedSpecies AS Recommended_Species, 
                    CONCAT('Php', ' ', cost) AS Cost, guidelines AS Guidelines, 
                    sideEffects AS Side_Effects FROM vaccine_info"
        Try
            Using adapter As New MySqlDataAdapter(sqlQuery, con)
                dtTable = New DataTable
                adapter.Fill(dtTable)

                If dtTable.Rows.Count > 0 Then
                    AdminPanel.dgvVaccineTable.DataSource = dtTable
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading staffs: " & ex.Message)
        Finally
            ' Close the connection in the Finally block
            con.Close()
        End Try
    End Sub

    'VACCINE FILTER
    Public Sub VaccineFilter(id As Integer, vaccineName As String, vaccineType As String, vaccineRecSpec As String, vaccineManufacturer As String)
        Dim dt As DataTable = CType(AdminPanel.dgvVaccineTable.DataSource, DataTable)

        If dt IsNot Nothing Then
            Dim compoundFilter As String = ""

            If id > 0 Then
                compoundFilter = $"Vaccine_ID = '{id}'"
            End If

            If Not String.IsNullOrEmpty(vaccineName) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Vaccine_Name LIKE '%{vaccineName}%'"
            End If

            If Not String.IsNullOrEmpty(vaccineType) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Vaccine_Type LIKE '%{vaccineType}%'"
            End If

            If Not String.IsNullOrEmpty(vaccineRecSpec) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Recommended_Species LIKE '%{vaccineRecSpec}%'"
            End If

            If Not String.IsNullOrEmpty(vaccineManufacturer) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Manufacturer LIKE '%{vaccineManufacturer}%'"
            End If

            dt.DefaultView.RowFilter = compoundFilter
        End If
    End Sub

    'LOAD ALL MEDICINE INFORMATION AND PUT INTO THE TABLE
    Public Sub LoadMedicines()
        sqlQuery = "SELECT id AS Medicine_ID, medicineName AS Medicine_Name, genericName AS Generic_Name,
                    brandName AS Brand_Name, dosageInfo AS Dosage_Info, 
                    administrationRoute AS Administration_Route, 
                    concentration AS Concentration, manufacturer AS Manufacturer, 
                    expiryDate AS Expiry_Date FROM medicine_info"
        Try
            Using adapter As New MySqlDataAdapter(sqlQuery, con)
                dtTable = New DataTable
                adapter.Fill(dtTable)

                If dtTable.Rows.Count > 0 Then
                    AdminPanel.dgvMedicineTable.DataSource = dtTable
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading staffs: " & ex.Message)
        Finally
            ' Close the connection in the Finally block
            con.Close()
        End Try
    End Sub

    'LOAD ALL PENDING APPOINTMENTS INFORMATIONS AND PUT INTO THE TABLE
    Public Sub LoadPendingAppointments()

        sqlQuery = "SELECT id AS Appointment_ID, petName AS Pet_Name, ownerName AS Pet_Owner, 
                    petBreed As Breed, petSpecies AS Species, 
                    petGender AS Gender, birthDate AS BirthDate, appointment_type AS Appointment_Type,
                    preferredDate As Preffered_Date_of_Appointment, assignedStaff AS Assigned_Staff,
                    appointmentStatus As Appointment_Status, pet_ID AS PetID, user_number AS user_number
                    FROM user_appointment WHERE appointmentStatus = 'Pending'"

        Try
            Using adapter As New MySqlDataAdapter(sqlQuery, con)
                dtTable = New DataTable
                adapter.Fill(dtTable)

                If dtTable.Rows.Count > 0 Then
                    Try
                        ' Collect columns to be removed
                        Dim columnsToRemove As New List(Of String)
                        For Each col As DataGridViewColumn In AdminPanel.dgvStaffAppointmentTable.Columns
                            If col.Name = "Accept" Or col.Name = "Decline" Or col.Name = "Finish" Then
                                columnsToRemove.Add(col.Name)
                            End If
                        Next

                        ' Remove the collected columns
                        For Each colName As String In columnsToRemove
                            AdminPanel.dgvStaffAppointmentTable.Columns.Remove(colName)
                        Next
                    Catch ex As Exception
                        ' Handle any exceptions that may occur during column removal
                        MsgBox("An error occurred while removing existing button columns: " & ex.Message)
                    End Try

                    Dim acceptAppointment As New DataGridViewButtonColumn()
                    acceptAppointment.Name = "Accept"
                    acceptAppointment.HeaderText = "Accept"
                    acceptAppointment.Text = "Accept"
                    acceptAppointment.UseColumnTextForButtonValue = True

                    Dim declineAppointment As New DataGridViewButtonColumn()
                    declineAppointment.Name = "Decline"
                    declineAppointment.HeaderText = "Decline"
                    declineAppointment.Text = "Decline"
                    declineAppointment.UseColumnTextForButtonValue = True

                    AdminPanel.dgvStaffAppointmentTable.DataSource = dtTable

                    AdminPanel.dgvStaffAppointmentTable.Columns.Add(acceptAppointment)
                    AdminPanel.dgvStaffAppointmentTable.Columns.Add(declineAppointment)
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading medicines: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub LoadOngoingAppointments()
        sqlQuery = "SELECT id AS Appointment_ID, petName AS Pet_Name, ownerName AS Pet_Owner, 
                    petBreed As Breed, petSpecies AS Species, 
                    petGender AS Gender, birthDate AS BirthDate, appointment_type AS Appointment_Type,
                    preferredDate As Preffered_Date_of_Appointment, assignedStaff AS Assigned_Staff,
                    appointmentStatus As Appointment_Status, pet_ID AS PetID, user_number AS user_number
                    FROM user_appointment WHERE appointmentStatus = 'Ongoing'"

        Try
            Using adapter As New MySqlDataAdapter(sqlQuery, con)
                dtTable = New DataTable
                adapter.Fill(dtTable)

                If dtTable.Rows.Count > 0 Then
                    Try
                        ' Collect columns to be removed
                        Dim columnsToRemove As New List(Of String)
                        For Each col As DataGridViewColumn In AdminPanel.dgvStaffAppointmentTable.Columns
                            If col.Name = "Accept" Or col.Name = "Decline" Or col.Name = "Finish" Then
                                columnsToRemove.Add(col.Name)
                            End If
                        Next

                        ' Remove the collected columns
                        For Each colName As String In columnsToRemove
                            AdminPanel.dgvStaffAppointmentTable.Columns.Remove(colName)
                        Next
                    Catch ex As Exception
                        ' Handle any exceptions that may occur during column removal
                        MsgBox("An error occurred while removing existing button columns: " & ex.Message)
                    End Try


                    Dim finishAppointment As New DataGridViewButtonColumn()
                    finishAppointment.Name = "Finish"
                    finishAppointment.HeaderText = "Finish"
                    finishAppointment.Text = "Finish"
                    finishAppointment.UseColumnTextForButtonValue = True

                    AdminPanel.dgvStaffAppointmentTable.DataSource = dtTable
                    AdminPanel.dgvStaffAppointmentTable.Columns.Add(finishAppointment)
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading medicines: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub LoadFinishedAppointments()
        sqlQuery = "SELECT id AS Appointment_ID, petName AS Pet_Name, ownerName AS Pet_Owner, 
                    petBreed As Breed, petSpecies AS Species, 
                    petGender AS Gender, birthDate AS BirthDate, appointment_type AS Appointment_Type,
                    preferredDate As Preffered_Date_of_Appointment, assignedStaff AS Assigned_Staff,
                    appointmentStatus As Appointment_Status, pet_ID AS PetID, user_number AS user_number
                    FROM user_appointment WHERE appointmentStatus = 'Finished'"

        Try
            Using adapter As New MySqlDataAdapter(sqlQuery, con)
                dtTable = New DataTable
                adapter.Fill(dtTable)

                If dtTable.Rows.Count > 0 Then
                    Try
                        ' Collect columns to be removed
                        Dim columnsToRemove As New List(Of String)
                        For Each col As DataGridViewColumn In AdminPanel.dgvStaffAppointmentTable.Columns
                            If col.Name = "Accept" Or col.Name = "Decline" Or col.Name = "Finish" Then
                                columnsToRemove.Add(col.Name)
                            End If
                        Next

                        ' Remove the collected columns
                        For Each colName As String In columnsToRemove
                            AdminPanel.dgvStaffAppointmentTable.Columns.Remove(colName)
                        Next
                    Catch ex As Exception
                        ' Handle any exceptions that may occur during column removal
                        MsgBox("An error occurred while removing existing button columns: " & ex.Message)
                    End Try


                    AdminPanel.dgvStaffAppointmentTable.DataSource = dtTable
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while loading medicines: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'MEDICINE FILTER
    Public Sub MedicineFilter(id As Integer, medicineName As String, genericName As String, brandName As String, medicineManufacturer As String)
        Dim dt As DataTable = CType(AdminPanel.dgvMedicineTable.DataSource, DataTable)

        If dt IsNot Nothing Then
            Dim compoundFilter As String = ""

            If id > 0 Then
                compoundFilter = $"Medicine_ID = '{id}'"
            End If

            If Not String.IsNullOrEmpty(medicineName) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Medicine_Name LIKE '%{medicineName}%'"
            End If

            If Not String.IsNullOrEmpty(genericName) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Generic_Name LIKE '%{genericName}%'"
            End If

            If Not String.IsNullOrEmpty(brandName) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Brand_Name LIKE '%{brandName}%'"
            End If

            If Not String.IsNullOrEmpty(medicineManufacturer) Then
                If Not String.IsNullOrEmpty(compoundFilter) Then
                    compoundFilter &= " AND "
                End If
                compoundFilter &= $"Manufacturer LIKE '%{medicineManufacturer}%'"
            End If

            dt.DefaultView.RowFilter = compoundFilter
        End If
    End Sub

    'PROFILE IMAGE : USER, PET, UAPPOINTMENT VACCINES, MEDICINES
    Public Sub LoadProfilePicture(id As Integer, otherId As Integer, pictureBox As PictureBox, tableName As String)
        If tableName = "user_info" Then
            sqlQuery = $"SELECT profileImage FROM {tableName} WHERE user_number = @userNum;"
        ElseIf tableName = "pet_info" Or tableName = "user_appointment" Then
            sqlQuery = $"SELECT profileImage FROM {tableName} WHERE user_number = @userNum AND pet_id = @petID;"
        ElseIf tableName = "vaccine_info" Then
            sqlQuery = $"SELECT profileImage FROM {tableName} WHERE id = @vacId"
        ElseIf tableName = "medicine_info" Then
            sqlQuery = $"SELECT profileImage FROM {tableName} WHERE id = @medId;"
        End If

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                If tableName = "user_info" Then
                    mysqlcmd.Parameters.AddWithValue("@userNum", id)
                ElseIf tableName = "pet_info" Or tableName = "user_appointment" Then
                    mysqlcmd.Parameters.AddWithValue("@userNum", id)
                    mysqlcmd.Parameters.AddWithValue("@petID", otherId)
                ElseIf tableName = "vaccine_info" Then
                    mysqlcmd.Parameters.AddWithValue("@vacId", id)
                ElseIf tableName = "medicine_info" Then
                    mysqlcmd.Parameters.AddWithValue("@medId", id)
                End If

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

    'TOTAL COUNT
    Public Sub GetTotal(tableName As String)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim sqlQuery As String = $"SELECT COUNT(*) FROM {tableName};"

            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                If tableName = "user_info" Then
                    AdminPanel.lblUserTotal.Text = Convert.ToInt32(mysqlcmd.ExecuteScalar())
                ElseIf tableName = "pet_info" Then
                    AdminPanel.lblPetCount.Text = Convert.ToInt32(mysqlcmd.ExecuteScalar())
                ElseIf tableName = "user_appointment" Then
                    AdminPanel.lblUserAppointmentTotal.Text = Convert.ToInt32(mysqlcmd.ExecuteScalar())
                ElseIf tableName = "clinic_personnel_info" Then
                    AdminPanel.lblStaffTotal.Text = Convert.ToInt32(mysqlcmd.ExecuteScalar())
                ElseIf tableName = "vaccine_info" Then
                    AdminPanel.lblVaccineTotal.Text = Convert.ToInt32(mysqlcmd.ExecuteScalar())
                ElseIf tableName = "medicine_info" Then
                    AdminPanel.lblMedicineTotal.Text = Convert.ToInt32(mysqlcmd.ExecuteScalar())
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while getting the total row count: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
End Module
