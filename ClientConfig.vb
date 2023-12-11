Imports MySql.Data.MySqlClient

Module ClientConfig
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlQuery As String
    Dim dtTable As New DataTable
    Dim adapter As New MySqlDataAdapter

    Dim firstName, lastName, contact, homeAddress, city, province,
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
        contact = Account.txtContact.Text
        homeAddress = Account.txtHomeAddress.Text
        city = Account.txtCity.Text
        province = Account.txtProvince.Text
        userName = Account.txtUsername.Text
        password = GetSaltedHash(Account.txtPassword.Text, userName)
        securityQuestion = Account.cmbSecurity.Text
        saltedAns = GetSaltedHash(Account.txtAnswer.Text, userName)

        'First Query
        sqlQuery = "
            SELECT MAX(user_number) FROM user_credentials
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)

        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read() Then
                If Not reader.IsDBNull(0) Then
                    userNum = reader.GetInt32(0) + 1
                Else
                    userNum = 1
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
            SELECT COUNT(*) FROM user_credentials WHERE user_name = @username
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

        sqlQuery = "
            INSERT INTO user_credentials(user_name, salted_hash, security_question, answer) VALUES (
	            @username, @password, @security, @answer
            );

            INSERT INTO user_info (fName, lName, contact, home_address, city, province, profileImage, user_number) 
            VALUES (
	            @fname,
                @lname,
                @contact,
                @home_address,
                @city,
                @province,
                @profile,
                @usernumber
            );
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@username", userName)
        mysqlcmd.Parameters.AddWithValue("@password", password)
        mysqlcmd.Parameters.AddWithValue("@security", securityQuestion)
        mysqlcmd.Parameters.AddWithValue("@answer", saltedAns)
        mysqlcmd.Parameters.AddWithValue("@fname", firstName)
        mysqlcmd.Parameters.AddWithValue("@lname", lastName)
        mysqlcmd.Parameters.AddWithValue("@contact", contact)
        mysqlcmd.Parameters.AddWithValue("@home_address", homeAddress)
        mysqlcmd.Parameters.AddWithValue("@city", city)
        mysqlcmd.Parameters.AddWithValue("@province", province)
        mysqlcmd.Parameters.AddWithValue("@profile", profile)
        mysqlcmd.Parameters.AddWithValue("@usernumber", userNum)

        Try
            If ValidateClientInput(existence) Then
                mysqlcmd.ExecuteNonQuery()
                MsgBox("Added!")
            End If
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
End Module
