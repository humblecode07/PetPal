Public Class ClientLogin
    Private Sub ClientLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        ConnectDbaseTwo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        Account.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim key As String = GetSaltedHash(txtPassword.Text, txtUName.Text)
        Dim entry As Boolean = False
        LoginClient(key, entry)

        If entry = True Then
            MsgBox("Login Successfully!")
            Me.Hide()
            UserPanel.Show()
        Else
            MsgBox("Username or password is incorrect!")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkForgotPassword.LinkClicked
        Me.Hide()
        ForgorPass.Show()
    End Sub
End Class