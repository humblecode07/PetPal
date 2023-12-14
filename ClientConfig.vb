Imports MySql.Data.MySqlClient
Imports System.IO

Module ClientConfig
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlQuery As String
    Dim dtTable As New DataTable
    Dim adapter As New MySqlDataAdapter

    Dim firstName, lastName, contact, birthdate, email, homeAddress, city, province,
        userName, password, securityQuestion, saltedAns As String
    Dim existence As Boolean

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

    Public Sub AddUser(profile As Byte())
        Dim userNum As Integer

        firstName = Account.txtFName.Text
        lastName = Account.txtLName.Text
        birthdate = Account.dtpBirthDate.Value.ToString("yyyy-MM-dd")
        contact = Account.txtContact.Text
        homeAddress = Account.txtHomeAddress.Text
        email = Account.txtEmail.Text
        city = Account.txtCity.Text
        province = Account.txtProvince.Text
        userName = Account.txtUsername.Text
        password = GetSaltedHash(Account.txtPassword.Text, userName)
        securityQuestion = Account.cmbSecurity.Text
        saltedAns = GetSaltedHash(Account.txtAnswer.Text, userName)

        '1st Query
        existence = False

        sqlQuery = "
            SELECT COUNT(*) FROM user_credentials WHERE user_name = @username
        "
        Using mysqlcmd As New MySqlCommand(sqlQuery, con)
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
        End Using

        '2nd Query
        sqlQuery = "
            INSERT INTO user_credentials(user_name, salted_hash, security_question, answer) VALUES (
	            @username, @password, @security, @answer
            );
        "
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            ' Instantiate MySqlCommand and associate it with the connection
            Using mysqlcmd As New MySqlCommand(sqlQuery, con)
                ' Set the command type (not strictly necessary, but good practice)
                mysqlcmd.CommandType = CommandType.Text

                ' Add parameters to the command
                mysqlcmd.Parameters.AddWithValue("@username", userName)
                mysqlcmd.Parameters.AddWithValue("@password", password)
                mysqlcmd.Parameters.AddWithValue("@security", securityQuestion)
                mysqlcmd.Parameters.AddWithValue("@answer", saltedAns)

                ' Execute the query
                mysqlcmd.ExecuteNonQuery()

                MsgBox("Added!")
            End Using ' MySqlCommand is automatically disposed when this block is exited
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Second Query
        sqlQuery = "
            SELECT MAX(user_number) FROM user_credentials
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)

        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read() Then
                If Not reader.IsDBNull(0) Then
                    userNum = reader.GetInt32(0)
                Else
                    userNum = 1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            reader.Close()
        End Try


        'Third Query

        sqlQuery = "
            INSERT INTO user_info (fName, lName, birthDate, contact, email, home_address, city, province, profileImage, user_number) 
            VALUES (
	            @fname,
                @lname,
                @birthDate,
                @contact,
                @email,
                @home_address,
                @city,
                @province,
                @profile,
                @usernumber
            );
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@fname", firstName)
        mysqlcmd.Parameters.AddWithValue("@lname", lastName)
        mysqlcmd.Parameters.AddWithValue("@birthDate", birthdate)
        mysqlcmd.Parameters.AddWithValue("@contact", contact)
        mysqlcmd.Parameters.AddWithValue("@email", email)
        mysqlcmd.Parameters.AddWithValue("@home_address", homeAddress)
        mysqlcmd.Parameters.AddWithValue("@city", city)
        mysqlcmd.Parameters.AddWithValue("@province", province)
        mysqlcmd.Parameters.AddWithValue("@profile", profile)
        mysqlcmd.Parameters.AddWithValue("@usernumber", userNum)

        Try
            mysqlcmd.ExecuteNonQuery()
            MsgBox("Added!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub

    Public Sub SearchClient(ByRef succeed As Boolean)

        sqlQuery = "SELECT user_name, security_question FROM user_credentials WHERE user_name = @uname"
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@uname", ForgorPass.txtUserName.Text)

        Try
            reader = mysqlcmd.ExecuteReader()

            ' Check if there are any rows
            If reader.HasRows Then
                ' Read the first row
                reader.Read()
                ' Retrieve the user_name from the first row
                userName = reader.GetString(0)
                ForgorPass.lblSecurity.Text = reader.GetString(1)
                succeed = True
            Else
                ' No rows found
                succeed = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            reader.Close()
        End Try
    End Sub

    Public Sub ResetPassword(access As String)
        Dim dbAns As String
        Dim reset As Boolean = False

        sqlQuery = "SELECT answer FROM user_credentials WHERE user_name = @uname"
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@uname", ForgorPass.txtUserName.Text)

        Try
            reader = mysqlcmd.ExecuteReader()
            reader.Read()
            dbAns = reader.GetString(0)

            If access = dbAns Then
                reset = True
            Else
                MsgBox("Answer Incorrect!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            reader.Close()
        End Try

        If reset Then
            Dim newPass As String = GetSaltedHash("123456", ForgorPass.txtUserName.Text)

            ' Create a new MySqlCommand for the UPDATE query
            Dim updateCmd As New MySqlCommand()

            sqlQuery = "UPDATE user_credentials SET salted_hash = @newpass WHERE user_name = @uname"

            Try
                Using cmd As New MySqlCommand(sqlQuery, con)
                    cmd.Parameters.AddWithValue("@newpass", newPass)
                    cmd.Parameters.AddWithValue("@uname", ForgorPass.txtUserName.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Password has been reset to default." & vbCrLf & "Password: 123456")
                    ForgorPass.Hide()
                    ClientLogin.Show()
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                reader.Close()
            End Try
        End If

    End Sub

    Public Sub ReadProfile()
        sqlQuery = "
            SELECT user_name, security_question FROM user_credentials WHERE user_number = @userNum;
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@userNum", UserPanel.lblId.Text)

        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read Then
                Account.txtUsername.Text = reader("user_name").ToString()
                Account.cmbSecurity.Text = reader("security_question").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            reader.Close()
        End Try

        sqlQuery = "
            SELECT * FROM user_info WHERE user_number = @userNum;
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@userNum", UserPanel.lblId.Text)

        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read Then
                Account.txtFName.Text = reader("fName").ToString()
                Account.txtLName.Text = reader("lName").ToString()
                Account.dtpBirthDate.Value = reader("birthDate").ToString()
                Account.txtContact.Text = reader("contact").ToString()
                Account.txtEmail.Text = reader("email").ToString()
                Account.txtHomeAddress.Text = reader("home_address").ToString()
                Account.txtCity.Text = reader("city").ToString()
                Account.txtProvince.Text = reader("province").ToString()

                If reader("profileImage") IsNot DBNull.Value Then
                    ' Convert the byte array to Image and set it to the PictureBox
                    Dim imageBytes() As Byte = DirectCast(reader("profileImage"), Byte())

                    If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                        Using stream As New MemoryStream(imageBytes)
                            Dim image As Image = Image.FromStream(stream)
                            Account.pbxProfile.BackgroundImage = image
                        End Using
                    Else
                        ' Handle the case where there is no image data
                        Account.pbxProfile.BackgroundImage = Nothing
                    End If
                Else
                    ' Handle the case where image_column is DBNull (no image data)
                    Account.pbxProfile.BackgroundImage = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            reader.Close()
        End Try

    End Sub

    Public Sub UpdateProfile(profile As Byte())
        userName = Account.txtUsername.Text
        password = GetSaltedHash(Account.txtPassword.Text, userName)
        securityQuestion = Account.cmbSecurity.Text
        saltedAns = GetSaltedHash(Account.txtAnswer.Text, userName)

        firstName = Account.txtFName.Text
        lastName = Account.txtLName.Text
        contact = Account.txtContact.Text
        birthdate = Account.dtpBirthDate.Value.ToString("yyyy-MM-dd")
        email = Account.txtEmail.Text
        homeAddress = Account.txtHomeAddress.Text
        city = Account.txtCity.Text
        province = Account.txtProvince.Text

        '1st Query
        existence = False

        sqlQuery = "
            SELECT COUNT(*) FROM user_credentials WHERE user_name = @username
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@username", userName)

        Try
            Dim count As Integer = Convert.ToInt32(mysqlcmd.ExecuteScalar())

            ' Check if the count is greater than 0, meaning the name exists
            If count > 1 Then
                existence = True
            Else
                existence = False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        '2nd Query get mysql profile pic value if pcb is unused

        '3nd Query
        sqlQuery = "
            UPDATE user_credentials SET
            user_name = @userName, salted_hash = @password, security_question = @question, answer = @answer
            WHERE user_number = @userNum;

            UPDATE user_info SET
            fName = @fname, lName = @lname, birthDate = @birthDate, contact = @contact, email = @email,
            home_address = @homeAdd, city = @city, province = @province, profileImage = @profile
            WHERE user_number = @userNum;
        "

        Try
            Using cmd As New MySqlCommand(sqlQuery, con)
                cmd.Parameters.AddWithValue("@userNum", UserPanel.lblId.Text)
                cmd.Parameters.AddWithValue("@userName", userName)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@question", securityQuestion)
                cmd.Parameters.AddWithValue("@answer", saltedAns)
                cmd.Parameters.AddWithValue("@fname", firstName)
                cmd.Parameters.AddWithValue("@lname", lastName)
                cmd.Parameters.AddWithValue("@birthDate", birthdate)
                cmd.Parameters.AddWithValue("@contact", contact)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@homeAdd", homeAddress)
                cmd.Parameters.AddWithValue("@city", city)
                cmd.Parameters.AddWithValue("@province", province)
                cmd.Parameters.AddWithValue("@profile", profile)
                cmd.ExecuteNonQuery()
                If ValidateClientInput(existence) Then
                    cmd.ExecuteNonQuery()
                    MsgBox("Update Successfully")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        End Try
    End Sub

End Module
