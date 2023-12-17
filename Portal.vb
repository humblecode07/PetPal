Public Class Portal
    Private Sub Portal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As String = InputBox("Welcome to the portal. Select which number you wish to enter: " &
                                        vbCrLf & "1. Admin" & vbCrLf & "2. Staffs" & vbCrLf & "1. Users", "")
    End Sub
End Class