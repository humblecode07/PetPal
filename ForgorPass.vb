Public Class ForgorPass
    Private Sub ForgorPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientConfig.ConnectDbase()
        pnlSecurity.Hide()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim entry As Boolean = False
        SearchClient(entry)

        If entry = True Then
            MsgBox("Username Found!")
            txtUserName.ReadOnly = True
            pnlSecurity.Show()
        Else
            MsgBox("Username does not exist!")
        End If
    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Dim ans = GetSaltedHash(txtAnswer.Text, txtUserName.Text)
        ResetPassword(ans)
    End Sub
End Class