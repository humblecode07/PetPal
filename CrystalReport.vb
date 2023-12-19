Imports MySql.Data.MySqlClient

Public Class CrystalReport
    Dim con As New MySqlConnection
    Dim host, uname, pwd, dbname As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

        Dim dtTable As New DataTable
        Dim mysqlcmd As New MySqlCommand("SELECT * FROM user_info", con)
        Dim adapter As New MySqlDataAdapter(mysqlcmd)
        adapter.Fill(dtTable)
        con.Close()

        Dim cr As New AdminCrystalReport1
        cr.SetDataSource(dtTable)
        CrystalReportViewer1.ReportSource = cr
        CrystalReportViewer1.Refresh()
    End Sub
End Class