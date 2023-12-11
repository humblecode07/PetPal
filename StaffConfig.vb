Imports MySql.Data.MySqlClient

Module StaffConfig
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlQuery As String
    Dim dtTable As New DataTable
    Dim adapter As New MySqlDataAdapter

    Dim firstName, lastName, midName, contact, address, position, specialization, department, resumee,
           certification, workingHours, salary, startDate, userName, password As String
    Dim existence As Boolean
    Dim proceed As Boolean

    Public Sub ConnectDbase()
        host = "192.168.56.1"
        dbname = "staff_credentials"
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

    Public Sub AddRole()
        Dim userNum As Integer

        firstName = UserRole.txtFName.Text
        lastName = UserRole.txtLName.Text
        midName = UserRole.txtMName.Text
        contact = UserRole.txtContact.Text
        address = UserRole.txtStAddress.Text + ", " & UserRole.txtCity.Text + ", " +
            UserRole.txtProvince.Text + ", " + UserRole.txtRegion.Text
        position = UserRole.txtPosition.Text
        specialization = UserRole.txtSpecialization.Text
        department = UserRole.txtDepartment.Text
        resumee = UserRole.txtResume.Text
        certification = UserRole.txtCertification.Text
        workingHours = UserRole.txtInitialHour.Text + " " + UserRole.cmbInitialAnte.Text + " ~ " +
            UserRole.txtFinalHour.Text + " " + UserRole.cmbFinalAnte.Text
        salary = UserRole.txtSalary.Text
        startDate = UserRole.txtStartDate.Text
        userName = UserRole.txtUserName.Text
        password = GetSaltedHash(UserRole.txtPassword.Text, userName)

        'First Query
        sqlQuery = "
            SELECT MAX(user_number) FROM clinic_personnel_credentials
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)

        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read() Then
                ' Check if there are results before trying to read
                If Not reader.IsDBNull(0) Then
                    userNum = reader.GetInt32(0) + 1
                Else
                    ' Handle the case when the result is NULL
                    userNum = "No records"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            reader.Close()
        End Try

        'Second Query

        existence = False

        sqlQuery = "
            SELECT COUNT(*) FROM clinic_personnel_credentials WHERE user_name = @username
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@username", userName)

        Try
            Dim count As Integer = Convert.ToInt32(mysqlcmd.ExecuteScalar())

            ' Check if the count is greater than 0, meaning the name exists
            If count > 0 Then
                existence = True

            Else
                existence = False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


        'Third Query
        proceed = True

        sqlQuery = "
            INSERT INTO clinic_personnel_credentials(user_name, salted_hash) VALUES (
	            @username, @password
            );

            INSERT INTO clinic_personnel_info (fName, lName, mName, contact, address, position, specialization, department, resume_path,
            certification_path, workingHours, salary, startDate, user_number) 
            VALUES (
	            @fname,
                @lname,
                @mname,
                @contact,
                @address,
                @position,
                @specialization,
                @department,
                @resume,
                @certificate,
                @workhours,
	            @salary,
                @startDate,
                @usernumber
            );
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@username", userName)
        mysqlcmd.Parameters.AddWithValue("@password", password)
        mysqlcmd.Parameters.AddWithValue("@fname", firstName)
        mysqlcmd.Parameters.AddWithValue("@lname", lastName)
        mysqlcmd.Parameters.AddWithValue("@mname", midName)
        mysqlcmd.Parameters.AddWithValue("@contact", contact)
        mysqlcmd.Parameters.AddWithValue("@address", address)
        mysqlcmd.Parameters.AddWithValue("@position", position)
        mysqlcmd.Parameters.AddWithValue("@specialization", specialization)
        mysqlcmd.Parameters.AddWithValue("@department", department)
        mysqlcmd.Parameters.AddWithValue("@resume", resumee)
        mysqlcmd.Parameters.AddWithValue("@certificate", certification)
        mysqlcmd.Parameters.AddWithValue("@workhours", workingHours)
        mysqlcmd.Parameters.AddWithValue("@salary", salary)
        mysqlcmd.Parameters.AddWithValue("@startDate", startDate)
        mysqlcmd.Parameters.AddWithValue("@usernumber", userNum)

        Try
            If ValidateStaffInput(existence, proceed) Then
                mysqlcmd.ExecuteNonQuery()
                MsgBox("Added!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub

    Public Sub TextClear()
        UserRole.txtFName.Clear()
        UserRole.txtLName.Clear()
        UserRole.txtMName.Clear()
        UserRole.txtContact.Clear()
        UserRole.txtStAddress.Clear()
        UserRole.txtCity.Clear()
        UserRole.txtProvince.Clear()
        UserRole.txtRegion.Clear()
        UserRole.txtPosition.Clear()
        UserRole.txtSpecialization.Clear()
        UserRole.txtDepartment.Clear()
        UserRole.txtResume.Clear()
        UserRole.txtCertification.Clear()
        UserRole.txtInitialHour.Clear()
        UserRole.cmbInitialAnte.Text = "A.M"
        UserRole.txtFinalHour.Clear()
        UserRole.cmbFinalAnte.Text = "P.M"
        UserRole.txtSalary.Clear()
        UserRole.txtStartDate.Clear()
        UserRole.txtUserName.Clear()
        UserRole.txtPassword.Clear()
        UserRole.txtSearch.Clear()
    End Sub

    Public Sub SearchUser()
        Dim id As Integer = UserRole.txtSearch.Text

        sqlQuery = "
            SELECT * FROM clinic_personnel_info LEFT JOIN clinic_personnel_credentials ON 
            clinic_personnel_info.user_number = clinic_personnel_credentials.user_number
            WHERE clinic_personnel_info.user_number = @id;
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@id", id)

        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read Then
                Dim separator As String

                'Trimming address from DB
                separator = ", "
                Dim completeAddress As String = reader("address").ToString
                Dim addressComponents As String() = GetComponents(completeAddress, separator)

                Dim streetAddress As String = addressComponents(0)
                Dim city As String = addressComponents(1)
                Dim province As String = addressComponents(2)
                Dim region As String = addressComponents(3)

                'Trimming working hours from DB
                separator = " "
                Dim completeWorkingHours As String = reader("workingHours").ToString
                Dim workingHoursComp As String() = GetComponents(completeWorkingHours, separator)

                Dim initial As String = workingHoursComp(0)
                Dim initialAnte As String = workingHoursComp(1)
                Dim final As String = workingHoursComp(3)
                Dim finalAnte As String = workingHoursComp(4)

                'Trimming Date from DB
                Dim completeStartDate As String = reader("startDate").ToString
                Dim startDateComp As String() = GetComponents(completeStartDate, separator)

                startDate = startDateComp(0)


                UserRole.txtFName.Text = reader("fName").ToString
                UserRole.txtLName.Text = reader("lName").ToString
                UserRole.txtMName.Text = reader("mName").ToString
                UserRole.txtContact.Text = reader("contact").ToString
                UserRole.txtStAddress.Text = streetAddress
                UserRole.txtCity.Text = city
                UserRole.txtProvince.Text = province
                UserRole.txtRegion.Text = region
                UserRole.txtPosition.Text = reader("position").ToString
                UserRole.txtSpecialization.Text = reader("specialization").ToString
                UserRole.txtDepartment.Text = reader("department").ToString
                UserRole.txtResume.Text = reader("resume_path").ToString
                UserRole.txtCertification.Text = reader("certification_path").ToString
                UserRole.txtInitialHour.Text = initial
                UserRole.cmbInitialAnte.Text = initialAnte
                UserRole.txtFinalHour.Text = final
                UserRole.cmbFinalAnte.Text = finalAnte
                UserRole.txtSalary.Text = reader("salary").ToString
                UserRole.txtStartDate.Text = startDate
                UserRole.txtUserName.Text = reader("user_name").ToString
            Else
                UserRole.StatusLabel.BackColor = Color.Red
                UserRole.StatusInfo.Text = "No Record"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub

    Public Sub UpdateUser()
        Dim search As Integer = UserRole.txtSearch.Text

        firstName = UserRole.txtFName.Text
        lastName = UserRole.txtLName.Text
        midName = UserRole.txtMName.Text
        contact = UserRole.txtContact.Text
        address = UserRole.txtStAddress.Text + ", " & UserRole.txtCity.Text + ", " +
            UserRole.txtProvince.Text + ", " + UserRole.txtRegion.Text
        position = UserRole.txtPosition.Text
        specialization = UserRole.txtSpecialization.Text
        department = UserRole.txtDepartment.Text
        resumee = UserRole.txtResume.Text
        certification = UserRole.txtCertification.Text
        workingHours = UserRole.txtInitialHour.Text + " " + UserRole.cmbInitialAnte.Text + " ~ " +
            UserRole.txtFinalHour.Text + " " + UserRole.cmbFinalAnte.Text
        salary = UserRole.txtSalary.Text
        startDate = UserRole.txtStartDate.Text
        userName = UserRole.txtUserName.Text
        password = GetSaltedHash(UserRole.txtPassword.Text, userName)

        existence = False
        proceed = False

        'Third Query: Update user info
        sqlQuery = "
            UPDATE clinic_personnel_info SET
            fName = @fName, lName = @lName, mName = @mName, contact = @contact, address = @address,
            position = @position, specialization = @specialization, department = @department,
            resume_path = @resume, certification_path = @cert, workingHours = @workHours, 
            salary = @salary, startDate = @startDate WHERE user_number = @search
        "

        Try
            If ValidateStaffInput(existence, proceed) Then
                Using cmd As New MySqlCommand(sqlQuery, con)
                    cmd.Parameters.AddWithValue("@fName", firstName)
                    cmd.Parameters.AddWithValue("@lName", lastName)
                    cmd.Parameters.AddWithValue("@mName", midName)
                    cmd.Parameters.AddWithValue("@contact", contact)
                    cmd.Parameters.AddWithValue("@address", address)
                    cmd.Parameters.AddWithValue("@position", position)
                    cmd.Parameters.AddWithValue("@specialization", specialization)
                    cmd.Parameters.AddWithValue("@department", department)
                    cmd.Parameters.AddWithValue("@resume", resumee)
                    cmd.Parameters.AddWithValue("@cert", certification)
                    cmd.Parameters.AddWithValue("@workHours", workingHours)
                    cmd.Parameters.AddWithValue("@salary", salary)
                    cmd.Parameters.AddWithValue("@startDate", startDate)
                    cmd.Parameters.AddWithValue("@search", search)
                    cmd.ExecuteNonQuery()
                    MsgBox("Update Successfully")
                End Using
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        Finally
            TextClear()
        End Try
    End Sub

    Public Sub ChangeCredentials()
        userName = UserRole.txtUserName.Text
        password = UserRole.txtPassword.Text
        existence = False
        Dim salted As String = GetSaltedHash(password, userName)
        Dim search = UserRole.txtSearch.Text

        sqlQuery = "SELECT COUNT(*) FROM clinic_personnel_credentials WHERE user_name = @username"
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@username", userName)

        Try
            Dim count As Integer = Convert.ToInt32(mysqlcmd.ExecuteScalar())
            existence = (count > 0)
        Catch ex As Exception
            MsgBox("Error checking username existence: " & ex.Message)
            Return
        End Try

        If password = "" Then
            sqlQuery = "UPDATE clinic_personnel_credentials SET user_name = @uname WHERE user_number = @search"
        Else
            sqlQuery = "UPDATE clinic_personnel_credentials SET user_name = @uname, salted_hash = @pass WHERE user_number = @search"
        End If

        Try
            Using cmd As New MySqlCommand(sqlQuery, con)
                cmd.Parameters.AddWithValue("@uname", userName)
                If password <> "" Then
                    cmd.Parameters.AddWithValue("@pass", salted)
                End If
                cmd.Parameters.AddWithValue("@search", search)

                cmd.ExecuteNonQuery()
                MsgBox("Changed Successfully")
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        End Try
    End Sub

End Module
