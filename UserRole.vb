Public Class UserRole
    Dim mode As Integer
    Private Sub AddUserRole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        StaffConfig.ConnectDbase()
        pnlSearch.Hide()
        cmbInitialAnte.Text = "A.M"
        cmbFinalAnte.Text = "P.M"
        mode = 1
        btnChange.Hide()
    End Sub

    Private Sub btnAddRole_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        If mode = 1 Then
            StaffConfig.AddRole()
        ElseIf mode = 2 Then
            StaffConfig.UpdateUser()
        ElseIf mode = 3 Then
            MsgBox("3")
        End If

    End Sub

    'Add/Edit/Delete User
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        TextClear()
        pnlSearch.Hide()
        pnlUserCredentials.Show()
        lblnfo.Text = "Create User Info"
        lblUserCred.Text = "Create User's Credentials"
        btnOkay.Text = "Add"
        mode = 1
        btnChange.Hide()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        TextClear()
        pnlSearch.Show()
        pnlUserCredentials.Show()
        lblnfo.Text = "Update User Info"
        lblUserCred.Text = "Update User's Credentials"
        btnOkay.Text = "Edit"
        mode = 2
        btnChange.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        TextClear()
        pnlSearch.Show()
        pnlUserCredentials.Hide()
        lblnfo.Text = "Delete User Account"
        btnOkay.Text = "Delete"
        mode = 3
        btnChange.Hide()
    End Sub

    Private Sub txtFName_MouseClick(sender As Object, e As MouseEventArgs) Handles txtFName.MouseClick
        StatusInfo.Text = "First Name"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchUser()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ChangeCredentials()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class