Imports MySql.Data.MySqlClient

Module Module1
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlQuery As String
    Dim dtTable As New DataTable
    Dim adapter As New MySqlDataAdapter

    Public Sub ConnectDbase()
        host = "127.0.0.1"
        dbname = "petpal"
        uname = "frieren"
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

    Public Sub LoginStaff(access As String, ByRef succeed As Boolean)
        Dim uName, password As String
        uName = Admin.txtUName.Text

        sqlQuery = "
            SELECT salted_hash FROM clinic_personnel_credentials WHERE user_name = @uName
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@uName", uName)

        Try
            reader = mysqlcmd.ExecuteReader
            If reader.Read() Then
                password = reader.GetString(0)
                If password = access Then
                    succeed = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex)
        Finally
            reader.Close()
        End Try
    End Sub

    Public Sub ConnectDbaseTwo()
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

    Public Sub LoginClient(access As String, ByRef succeed As Boolean)
        Dim uName, password As String
        Dim uNumber As Integer
        uName = ClientLogin.txtUName.Text

        sqlQuery = "
            SELECT user_number, salted_hash FROM user_credentials WHERE user_name = @uName
        "
        mysqlcmd = New MySqlCommand(sqlQuery, con)
        mysqlcmd.Parameters.AddWithValue("@uName", uName)

        Try
            reader = mysqlcmd.ExecuteReader
            If reader.Read() Then
                password = reader.GetString(1)
                uNumber = reader.GetInt32(0)
                If password = access Then
                    succeed = True
                    UserPanel.ReceiveValue(uNumber)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex)
        Finally
            reader.Close()
        End Try
    End Sub
End Module
