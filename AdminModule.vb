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
            ' Close the connection in the Finally block
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


    'LOAD ALL USER APPOINTMENT INFORMATION AND PUT INTO THE TABLE


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
            ' Close the connection in the Finally block
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


    'PROFILE IMAGE : USER, PET
    Public Sub LoadProfilePicture(id As Integer, otherId As Integer, pictureBox As PictureBox, tableName As String)
        If tableName = "user_info" Then
            sqlQuery = $"SELECT profileImage FROM {tableName} WHERE user_number = @userNum;"
        ElseIf tableName = "pet_info" Then
            sqlQuery = $"SELECT profileImage FROM {tableName} WHERE user_number = @userNum AND pet_id = @petID;"
        End If

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                If tableName = "user_info" Then
                    mysqlcmd.Parameters.AddWithValue("@userNum", id)
                ElseIf tableName = "pet_info" Then
                    mysqlcmd.Parameters.AddWithValue("@userNum", id)
                    mysqlcmd.Parameters.AddWithValue("@petID", otherId)
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
                ElseIf tableName = "clinic_personnel_info" Then
                    AdminPanel.lblStaffTotal.Text = Convert.ToInt32(mysqlcmd.ExecuteScalar())
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
