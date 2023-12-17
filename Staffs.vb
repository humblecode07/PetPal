Public Class Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim key As String = GetSaltedHash(txtPassword.Text, txtUName.Text)
        Dim entry As Boolean = False
        LoginStaff(key, entry)

        If entry = True Then
            MsgBox("Login Successfully!")
            Me.Hide()
            UserRole.Show()
        Else
            MsgBox("Username or password is incorrect!")
        End If
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        Module1.ConnectDbaseOne()
    End Sub
End Class
