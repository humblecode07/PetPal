<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Account))
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtHomeAddress = New System.Windows.Forms.TextBox()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.cmbSecurity = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.StatusInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel = New System.Windows.Forms.StatusStrip()
        Me.pbxProfile = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.label = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.StatusLabel.SuspendLayout()
        CType(Me.pbxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnUpload.FlatAppearance.BorderSize = 0
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(90, 245)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(157, 43)
        Me.btnUpload.TabIndex = 3
        Me.btnUpload.Text = "Upload Picture"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(386, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(691, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(386, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Birthdate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(691, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(386, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(386, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Home Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(386, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Province"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(691, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(386, 450)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Username"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(386, 526)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(691, 526)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Confirm Password"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(820, 779)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 43)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOkay
        '
        Me.btnOkay.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnOkay.FlatAppearance.BorderSize = 0
        Me.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOkay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnOkay.ForeColor = System.Drawing.Color.White
        Me.btnOkay.Location = New System.Drawing.Point(661, 779)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(131, 43)
        Me.btnOkay.TabIndex = 16
        Me.btnOkay.Text = "Create User"
        Me.btnOkay.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(3, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(177, 16)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Select a security question"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(389, 89)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(232, 20)
        Me.txtFName.TabIndex = 19
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(694, 89)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(232, 20)
        Me.txtLName.TabIndex = 20
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(694, 166)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(232, 20)
        Me.txtContact.TabIndex = 22
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(389, 245)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(537, 20)
        Me.txtEmail.TabIndex = 23
        '
        'txtHomeAddress
        '
        Me.txtHomeAddress.Location = New System.Drawing.Point(389, 325)
        Me.txtHomeAddress.Name = "txtHomeAddress"
        Me.txtHomeAddress.Size = New System.Drawing.Size(537, 20)
        Me.txtHomeAddress.TabIndex = 24
        '
        'txtProvince
        '
        Me.txtProvince.Location = New System.Drawing.Point(389, 405)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(232, 20)
        Me.txtProvince.TabIndex = 25
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(389, 483)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(232, 20)
        Me.txtUsername.TabIndex = 26
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(389, 556)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(232, 20)
        Me.txtPassword.TabIndex = 27
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Location = New System.Drawing.Point(694, 556)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(232, 20)
        Me.txtConfirmPass.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(3, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Answer"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(6, 121)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(232, 20)
        Me.txtAnswer.TabIndex = 31
        '
        'cmbSecurity
        '
        Me.cmbSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSecurity.FormattingEnabled = True
        Me.cmbSecurity.Items.AddRange(New Object() {"What is your favorite pet's name?", "Where were you born?", "What is your mother's maiden name?", "What is the name of your first school?", "In what city or town did your parents meet?", "What is your favorite color?", "What is the name of your best childhood friend?", "What is the make and model of your first car?", "What is the name of your favorite teacher?", "What is your favorite book?", "What is your favorite movie?", "What is your favorite food?", "What is the name of your favorite sports team?", "What is your favorite vacation spot?", "What was your childhood nickname?"})
        Me.cmbSecurity.Location = New System.Drawing.Point(6, 42)
        Me.cmbSecurity.Name = "cmbSecurity"
        Me.cmbSecurity.Size = New System.Drawing.Size(537, 21)
        Me.cmbSecurity.TabIndex = 32
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(694, 405)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(232, 20)
        Me.txtCity.TabIndex = 33
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.CustomFormat = ""
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthDate.Location = New System.Drawing.Point(389, 166)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(232, 20)
        Me.dtpBirthDate.TabIndex = 34
        Me.dtpBirthDate.Value = New Date(2023, 12, 9, 0, 0, 0, 0)
        '
        'StatusInfo
        '
        Me.StatusInfo.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusInfo.ForeColor = System.Drawing.Color.Black
        Me.StatusInfo.Name = "StatusInfo"
        Me.StatusInfo.Size = New System.Drawing.Size(970, 17)
        Me.StatusInfo.Spring = True
        '
        'StatusLabel
        '
        Me.StatusLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusLabel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusInfo})
        Me.StatusLabel.Location = New System.Drawing.Point(0, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(985, 22)
        Me.StatusLabel.SizingGrip = False
        Me.StatusLabel.TabIndex = 35
        Me.StatusLabel.Text = "StatusStrip1"
        '
        'pbxProfile
        '
        Me.pbxProfile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxProfile.BackColor = System.Drawing.Color.Transparent
        Me.pbxProfile.BackgroundImage = CType(resources.GetObject("pbxProfile.BackgroundImage"), System.Drawing.Image)
        Me.pbxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxProfile.Location = New System.Drawing.Point(114, 101)
        Me.pbxProfile.Name = "pbxProfile"
        Me.pbxProfile.Size = New System.Drawing.Size(107, 107)
        Me.pbxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxProfile.TabIndex = 1
        Me.pbxProfile.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtAnswer)
        Me.Panel1.Controls.Add(Me.cmbSecurity)
        Me.Panel1.Location = New System.Drawing.Point(382, 593)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(555, 148)
        Me.Panel1.TabIndex = 36
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.txtUserID)
        Me.Panel2.Controls.Add(Me.label)
        Me.Panel2.Location = New System.Drawing.Point(24, 318)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(276, 89)
        Me.Panel2.TabIndex = 37
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label.Location = New System.Drawing.Point(3, 37)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(27, 16)
        Me.label.TabIndex = 38
        Me.label.Text = "ID:"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(36, 36)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(139, 20)
        Me.txtUserID.TabIndex = 39
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(181, 34)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 40
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 850)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.dtpBirthDate)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtProvince)
        Me.Controls.Add(Me.txtHomeAddress)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.pbxProfile)
        Me.Name = "Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateAccount"
        Me.StatusLabel.ResumeLayout(False)
        Me.StatusLabel.PerformLayout()
        CType(Me.pbxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxProfile As PictureBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOkay As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtHomeAddress As TextBox
    Friend WithEvents txtProvince As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents cmbSecurity As ComboBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents StatusInfo As ToolStripStatusLabel
    Friend WithEvents StatusLabel As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents label As Label
End Class
