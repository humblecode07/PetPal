Public Class UserRole
    Dim mode As Integer
    Dim type As String
    Dim role As String
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
            AdminModule.LoadStaffs()
            AdminModule.GetTotal("clinic_personnel_info")
        ElseIf mode = 2 Then
            StaffConfig.UpdateUser()
            AdminModule.LoadStaffs()
            AdminModule.GetTotal("clinic_personnel_info")
        ElseIf mode = 3 Then
            MsgBox("3")
            AdminModule.LoadStaffs()
            AdminModule.GetTotal("clinic_personnel_info")
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

    Public Sub ReceiveValue(mode As String)
        type = mode
    End Sub
    Public Sub ReceiveRole(authority As String)
        role = authority
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If role = "Admin" Then
            Me.Dispose()
            AdminPanel.Show()
        Else

        End If
    End Sub
End Class