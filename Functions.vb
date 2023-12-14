Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Drawing.Text
Imports System.Drawing.Drawing2D
Imports System.IO

Module Functions
    Public Function GetSaltedHash(pw As String, salt As String) As String
        Dim tmp As String = pw & salt
        ' or SHA512Managed
        Using hash As HashAlgorithm = New SHA256Managed()
            ' convert pw+salt to bytes:
            Dim saltyPW = Encoding.UTF8.GetBytes(tmp)
            ' hash the pw+salt bytes:
            Dim hBytes = hash.ComputeHash(saltyPW)
            ' return a B64 string so it can be saved as text 
            Return Convert.ToBase64String(hBytes)
        End Using
    End Function

    Public Function ValidateStaffInput(exist As Boolean, skip As Boolean) As Boolean
        Dim parsedDate As DateTime

        If UserRole.txtFName.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "First name Required!"
            Return False
        ElseIf UserRole.txtLName.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Last name Required!"
            Return False
        ElseIf UserRole.txtMName.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Middle name Required!"
            Return False
        ElseIf UserRole.txtContact.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Contact Number Required!"
            Return False
        ElseIf UserRole.txtStAddress.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Street Address Required!"
            Return False
        ElseIf UserRole.txtCity.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "City Required!"
            Return False
        ElseIf UserRole.txtProvince.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Province Required!"
            Return False
        ElseIf UserRole.txtRegion.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Region Required!"
            Return False
        ElseIf UserRole.txtPosition.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Position Required!"
            Return False
        ElseIf UserRole.txtSpecialization.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Specialization Required!"
            Return False
        ElseIf UserRole.txtDepartment.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Department Required!"
            Return False
        ElseIf UserRole.txtResume.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Resume Required!"
            Return False
        ElseIf UserRole.txtCertification.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Certification Required!"
            Return False
        ElseIf UserRole.txtInitialHour.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Work Hours Required!"
            Return False
        ElseIf UserRole.txtSalary.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Salary Required!"
            Return False
        ElseIf UserRole.txtStartDate.Text = "" Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Date Required!"
            Return False
        ElseIf Regex.IsMatch(UserRole.txtStartDate.Text, "^\d{4}-\d{2}-\d{2}$") = False Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Date doesn't follow the expected format!"
            Return False
        ElseIf Not DateTime.TryParse(UserRole.txtStartDate.Text, parsedDate) Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Invalid date format!"
            Return False
        ElseIf exist = True AndAlso skip Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Username already exists!"
            Return False
        ElseIf UserRole.txtUserName.Text.Length < 6 AndAlso skip Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Username must be six characters or above!"
            Return False
        End If

        Return True
    End Function

    Public Function ValidateCredentials(exist As Boolean) As Boolean
        If exist = True Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Username already exists!"
            Return False
        ElseIf UserRole.txtUserName.Text.Length < 6 Then
            UserRole.StatusLabel.BackColor = Color.Red
            UserRole.StatusInfo.Text = "Username must be six characters or above!"
            Return False
        End If
        Return True
    End Function

    Public Function GetComponents(complete As String, separate As String) As String()
        Dim components() As String = complete.Split(separate.ToCharArray, StringSplitOptions.RemoveEmptyEntries)

        For i As Integer = 0 To components.Length - 1
            components(i) = components(i).Trim()
        Next

        Return components
    End Function

    Public Sub roundCorners(obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.White

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub

    Public Function LoadCustomFont(filePath As String, size As Single) As Font
        Dim privateFonts As New PrivateFontCollection()
        privateFonts.AddFontFile(filePath)
        Return New Font(privateFonts.Families(0), size)
    End Function

    Public Sub SetRoundedPanel(panel As Panel, cornerRadius As Integer)
        Dim graphicsPath As New GraphicsPath()
        graphicsPath.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        graphicsPath.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        graphicsPath.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        graphicsPath.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)

        panel.Region = New Region(graphicsPath)
    End Sub

    Public Sub SetRoundedButton(button As Button, cornerRadius As Integer)
        AddHandler button.Paint,
            Sub(sender As Object, e As PaintEventArgs)
                Dim buttonPath As New GraphicsPath()

                buttonPath.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90)
                buttonPath.AddArc(button.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90)
                buttonPath.AddArc(button.Width - cornerRadius * 2, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90)
                buttonPath.AddArc(0, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90)

                button.Region = New Region(buttonPath)
            End Sub
    End Sub

    Public Sub CreateRoundedPictureBox(pictureBox As PictureBox)
        AddHandler pictureBox.Paint, AddressOf PictureBox_Paint
    End Sub

    Private Sub PictureBox_Paint(sender As Object, e As PaintEventArgs)
        Dim pictureBox = DirectCast(sender, PictureBox)

        Using path As New Drawing2D.GraphicsPath()
            path.AddEllipse(0, 0, pictureBox.Width - 1, pictureBox.Height - 1)
            pictureBox.Region = New Region(path)
        End Using
    End Sub

    Public Function ValidateClientInput(exist As Boolean) As Boolean
        If Account.txtFName.Text = "" Then
            Account.StatusLabel.BackColor = Color.Red
            Account.StatusInfo.Text = "First name Required!"
            Return False
        ElseIf Account.txtLName.Text = "" Then
            Account.StatusLabel.BackColor = Color.Red
            Account.StatusInfo.Text = "Last name Required!"
            Return False
        ElseIf Account.txtContact.Text = "" Then
            Account.StatusLabel.BackColor = Color.Red
            Account.StatusInfo.Text = "Contact Number Required!"
            Return False
        ElseIf Account.txtHomeAddress.Text = "" Then
            Account.StatusLabel.BackColor = Color.Red
            Account.StatusInfo.Text = "Street Address Required!"
            Return False
        ElseIf Account.txtCity.Text = "" Then
            Account.StatusLabel.BackColor = Color.Red
            Account.StatusInfo.Text = "City Required!"
            Return False
        ElseIf Account.txtProvince.Text = "" Then
            Account.StatusLabel.BackColor = Color.Red
            Account.StatusInfo.Text = "Province Required!"
            Return False
        ElseIf exist = True Then
            Account.StatusLabel.BackColor = Color.Red
            Account.StatusInfo.Text = "Username already exists!"
            Return False
        ElseIf Account.txtUsername.Text.Length < 6 Then
            Account.StatusLabel.BackColor = Color.Red
            Account.StatusInfo.Text = "Username must be six characters or above!"
            Return False
        End If

        Return True
    End Function

    Public Function ConvertImageToByteArray(image As Image) As Byte()
        Try
            If image IsNot Nothing Then
                Using ms As New MemoryStream()
                    ' Specify the image format as JPEG (you can change it based on your requirement)
                    Appointment.pcbDisplay.Image.Save(ms, Appointment.pcbDisplay.Image.RawFormat)
                    ' Return the byte array
                    Return ms.ToArray()
                End Using
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return New Byte() {}
    End Function

End Module
