<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserRole
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserRole))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.StatusLabel = New System.Windows.Forms.StatusStrip()
        Me.StatusInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.pnlAdd = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.pnlDelete = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblRemove = New System.Windows.Forms.Label()
        Me.pnlUserCredentials = New System.Windows.Forms.Panel()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.lblUserCred = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblnfo = New System.Windows.Forms.Label()
        Me.txtFinalHour = New System.Windows.Forms.TextBox()
        Me.cmbFinalAnte = New System.Windows.Forms.ComboBox()
        Me.cmbInitialAnte = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tx = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtResume = New System.Windows.Forms.TextBox()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSpecialization = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtCertification = New System.Windows.Forms.TextBox()
        Me.txtInitialHour = New System.Windows.Forms.TextBox()
        Me.StatusLabel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlEdit.SuspendLayout()
        Me.pnlAdd.SuspendLayout()
        Me.pnlDelete.SuspendLayout()
        Me.pnlUserCredentials.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = False
        Me.StatusLabel.BackColor = System.Drawing.Color.BurlyWood
        Me.StatusLabel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusInfo})
        Me.StatusLabel.Location = New System.Drawing.Point(0, 717)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(1104, 40)
        Me.StatusLabel.SizingGrip = False
        Me.StatusLabel.TabIndex = 32
        Me.StatusLabel.Text = "StatusStrip1"
        '
        'StatusInfo
        '
        Me.StatusInfo.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusInfo.ForeColor = System.Drawing.Color.White
        Me.StatusInfo.Name = "StatusInfo"
        Me.StatusInfo.Size = New System.Drawing.Size(1089, 35)
        Me.StatusInfo.Spring = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.pnlUserCredentials)
        Me.Panel1.Controls.Add(Me.pnlSearch)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.lblnfo)
        Me.Panel1.Controls.Add(Me.txtFinalHour)
        Me.Panel1.Controls.Add(Me.cmbFinalAnte)
        Me.Panel1.Controls.Add(Me.cmbInitialAnte)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtDepartment)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtFName)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.btnOkay)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtRegion)
        Me.Panel1.Controls.Add(Me.label)
        Me.Panel1.Controls.Add(Me.txtLName)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.tx)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtProvince)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtStartDate)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtResume)
        Me.Panel1.Controls.Add(Me.txtMName)
        Me.Panel1.Controls.Add(Me.txtPosition)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtCity)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtStAddress)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtSpecialization)
        Me.Panel1.Controls.Add(Me.txtSalary)
        Me.Panel1.Controls.Add(Me.txtCertification)
        Me.Panel1.Controls.Add(Me.txtInitialHour)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1104, 714)
        Me.Panel1.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pnlEdit)
        Me.Panel2.Controls.Add(Me.pnlAdd)
        Me.Panel2.Controls.Add(Me.pnlDelete)
        Me.Panel2.Location = New System.Drawing.Point(121, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(753, 99)
        Me.Panel2.TabIndex = 59
        '
        'pnlEdit
        '
        Me.pnlEdit.Controls.Add(Me.btnEdit)
        Me.pnlEdit.Controls.Add(Me.lblEdit)
        Me.pnlEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlEdit.Location = New System.Drawing.Point(243, 10)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(223, 81)
        Me.pnlEdit.TabIndex = 56
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.Transparent
        Me.btnEdit.Location = New System.Drawing.Point(14, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(70, 70)
        Me.btnEdit.TabIndex = 49
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblEdit
        '
        Me.lblEdit.AutoSize = True
        Me.lblEdit.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblEdit.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.ForeColor = System.Drawing.Color.White
        Me.lblEdit.Location = New System.Drawing.Point(97, 25)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(76, 33)
        Me.lblEdit.TabIndex = 50
        Me.lblEdit.Text = "EDIT"
        '
        'pnlAdd
        '
        Me.pnlAdd.Controls.Add(Me.btnAdd)
        Me.pnlAdd.Controls.Add(Me.lblAdd)
        Me.pnlAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAdd.Location = New System.Drawing.Point(27, 10)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(200, 74)
        Me.pnlAdd.TabIndex = 55
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Transparent
        Me.btnAdd.Location = New System.Drawing.Point(5, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 70)
        Me.btnAdd.TabIndex = 47
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblAdd.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.ForeColor = System.Drawing.Color.White
        Me.lblAdd.Location = New System.Drawing.Point(84, 22)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(66, 33)
        Me.lblAdd.TabIndex = 48
        Me.lblAdd.Text = "ADD"
        '
        'pnlDelete
        '
        Me.pnlDelete.Controls.Add(Me.btnDelete)
        Me.pnlDelete.Controls.Add(Me.lblRemove)
        Me.pnlDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlDelete.Location = New System.Drawing.Point(487, 10)
        Me.pnlDelete.Name = "pnlDelete"
        Me.pnlDelete.Size = New System.Drawing.Size(233, 77)
        Me.pnlDelete.TabIndex = 57
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.Transparent
        Me.btnDelete.Location = New System.Drawing.Point(15, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 70)
        Me.btnDelete.TabIndex = 51
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblRemove
        '
        Me.lblRemove.AutoSize = True
        Me.lblRemove.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblRemove.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemove.ForeColor = System.Drawing.Color.DarkRed
        Me.lblRemove.Location = New System.Drawing.Point(91, 22)
        Me.lblRemove.Name = "lblRemove"
        Me.lblRemove.Size = New System.Drawing.Size(116, 33)
        Me.lblRemove.TabIndex = 52
        Me.lblRemove.Text = "REMOVE"
        '
        'pnlUserCredentials
        '
        Me.pnlUserCredentials.Controls.Add(Me.btnChange)
        Me.pnlUserCredentials.Controls.Add(Me.lblUserCred)
        Me.pnlUserCredentials.Controls.Add(Me.txtUserName)
        Me.pnlUserCredentials.Controls.Add(Me.txtPassword)
        Me.pnlUserCredentials.Controls.Add(Me.Label14)
        Me.pnlUserCredentials.Controls.Add(Me.Label15)
        Me.pnlUserCredentials.Location = New System.Drawing.Point(211, 499)
        Me.pnlUserCredentials.Name = "pnlUserCredentials"
        Me.pnlUserCredentials.Size = New System.Drawing.Size(300, 215)
        Me.pnlUserCredentials.TabIndex = 58
        '
        'btnChange
        '
        Me.btnChange.Font = New System.Drawing.Font("Yu Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnChange.Location = New System.Drawing.Point(0, 177)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 57
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'lblUserCred
        '
        Me.lblUserCred.AutoSize = True
        Me.lblUserCred.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserCred.ForeColor = System.Drawing.Color.White
        Me.lblUserCred.Location = New System.Drawing.Point(-3, 21)
        Me.lblUserCred.Name = "lblUserCred"
        Me.lblUserCred.Size = New System.Drawing.Size(274, 30)
        Me.lblUserCred.TabIndex = 45
        Me.lblUserCred.Text = "Create User's Credentials"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(82, 76)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(111, 20)
        Me.txtUserName.TabIndex = 14
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(82, 125)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(111, 20)
        Me.txtPassword.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(-1, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "User Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(-1, 126)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 17)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Password"
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.Label24)
        Me.pnlSearch.Controls.Add(Me.Label23)
        Me.pnlSearch.Location = New System.Drawing.Point(598, 520)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(356, 95)
        Me.pnlSearch.TabIndex = 54
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Yu Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSearch.Location = New System.Drawing.Point(237, 51)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 56
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(95, 53)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(111, 20)
        Me.txtSearch.TabIndex = 55
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(5, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 17)
        Me.Label24.TabIndex = 55
        Me.Label24.Text = "User Number"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(3, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(137, 30)
        Me.Label23.TabIndex = 55
        Me.Label23.Text = "Search User"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.Transparent
        Me.btnBack.Location = New System.Drawing.Point(999, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(70, 70)
        Me.btnBack.TabIndex = 53
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblnfo
        '
        Me.lblnfo.AutoSize = True
        Me.lblnfo.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnfo.ForeColor = System.Drawing.Color.White
        Me.lblnfo.Location = New System.Drawing.Point(425, 114)
        Me.lblnfo.Name = "lblnfo"
        Me.lblnfo.Size = New System.Drawing.Size(180, 30)
        Me.lblnfo.TabIndex = 46
        Me.lblnfo.Text = "Create User Info"
        '
        'txtFinalHour
        '
        Me.txtFinalHour.Location = New System.Drawing.Point(110, 456)
        Me.txtFinalHour.Name = "txtFinalHour"
        Me.txtFinalHour.Size = New System.Drawing.Size(88, 20)
        Me.txtFinalHour.TabIndex = 44
        '
        'cmbFinalAnte
        '
        Me.cmbFinalAnte.FormattingEnabled = True
        Me.cmbFinalAnte.Items.AddRange(New Object() {"A.M", "P.M"})
        Me.cmbFinalAnte.Location = New System.Drawing.Point(211, 456)
        Me.cmbFinalAnte.Name = "cmbFinalAnte"
        Me.cmbFinalAnte.Size = New System.Drawing.Size(45, 21)
        Me.cmbFinalAnte.TabIndex = 43
        '
        'cmbInitialAnte
        '
        Me.cmbInitialAnte.FormattingEnabled = True
        Me.cmbInitialAnte.Items.AddRange(New Object() {"A.M", "P.M"})
        Me.cmbInitialAnte.Location = New System.Drawing.Point(211, 423)
        Me.cmbInitialAnte.Name = "cmbInitialAnte"
        Me.cmbInitialAnte.Size = New System.Drawing.Size(45, 21)
        Me.cmbInitialAnte.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(517, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Department"
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(598, 297)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(146, 20)
        Me.txtDepartment.TabIndex = 40
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(265, 177)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 17)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Last Name"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(89, 176)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(146, 20)
        Me.txtFName.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(741, 236)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 17)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Region"
        '
        'btnOkay
        '
        Me.btnOkay.BackColor = System.Drawing.Color.Gray
        Me.btnOkay.Font = New System.Drawing.Font("Yu Mincho Demibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOkay.ForeColor = System.Drawing.Color.Black
        Me.btnOkay.Location = New System.Drawing.Point(551, 423)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(166, 53)
        Me.btnOkay.TabIndex = 16
        Me.btnOkay.Text = "Add"
        Me.btnOkay.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "First Name"
        '
        'txtRegion
        '
        Me.txtRegion.Location = New System.Drawing.Point(794, 233)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(120, 20)
        Me.txtRegion.TabIndex = 35
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.label.ForeColor = System.Drawing.Color.White
        Me.label.Location = New System.Drawing.Point(511, 236)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(56, 17)
        Me.label.TabIndex = 37
        Me.label.Text = "Province"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(338, 176)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(146, 20)
        Me.txtLName.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(536, 364)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Start Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(14, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 17)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Resume"
        '
        'tx
        '
        Me.tx.AutoSize = True
        Me.tx.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.tx.ForeColor = System.Drawing.Color.White
        Me.tx.Location = New System.Drawing.Point(305, 236)
        Me.tx.Name = "tx"
        Me.tx.Size = New System.Drawing.Size(28, 17)
        Me.tx.TabIndex = 36
        Me.tx.Text = "City"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(266, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Position"
        '
        'txtProvince
        '
        Me.txtProvince.Location = New System.Drawing.Point(573, 233)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(120, 20)
        Me.txtProvince.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 18
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(597, 361)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(120, 20)
        Me.txtStartDate.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(306, 427)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 17)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Salary"
        '
        'txtResume
        '
        Me.txtResume.Location = New System.Drawing.Point(74, 361)
        Me.txtResume.Name = "txtResume"
        Me.txtResume.Size = New System.Drawing.Size(146, 20)
        Me.txtResume.TabIndex = 9
        '
        'txtMName
        '
        Me.txtMName.Location = New System.Drawing.Point(611, 176)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(146, 20)
        Me.txtMName.TabIndex = 3
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(325, 297)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(146, 20)
        Me.txtPosition.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(15, 425)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 17)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Working Hours"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(524, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Middle Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(264, 362)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Certification"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(339, 233)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(120, 20)
        Me.txtCity.TabIndex = 33
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(73, 297)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(146, 20)
        Me.txtContact.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Contact"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(790, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Specialization"
        '
        'txtStAddress
        '
        Me.txtStAddress.Location = New System.Drawing.Point(111, 235)
        Me.txtStAddress.Name = "txtStAddress"
        Me.txtStAddress.Size = New System.Drawing.Size(146, 20)
        Me.txtStAddress.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Street Address"
        '
        'txtSpecialization
        '
        Me.txtSpecialization.Location = New System.Drawing.Point(793, 322)
        Me.txtSpecialization.MinimumSize = New System.Drawing.Size(4, 40)
        Me.txtSpecialization.Multiline = True
        Me.txtSpecialization.Name = "txtSpecialization"
        Me.txtSpecialization.Size = New System.Drawing.Size(248, 123)
        Me.txtSpecialization.TabIndex = 8
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(353, 425)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtSalary.TabIndex = 12
        '
        'txtCertification
        '
        Me.txtCertification.Location = New System.Drawing.Point(345, 361)
        Me.txtCertification.Name = "txtCertification"
        Me.txtCertification.Size = New System.Drawing.Size(146, 20)
        Me.txtCertification.TabIndex = 10
        '
        'txtInitialHour
        '
        Me.txtInitialHour.Location = New System.Drawing.Point(110, 424)
        Me.txtInitialHour.Name = "txtInitialHour"
        Me.txtInitialHour.Size = New System.Drawing.Size(88, 20)
        Me.txtInitialHour.TabIndex = 11
        '
        'UserRole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1104, 757)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusLabel)
        Me.Name = "UserRole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddUserRole"
        Me.StatusLabel.ResumeLayout(False)
        Me.StatusLabel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        Me.pnlAdd.ResumeLayout(False)
        Me.pnlAdd.PerformLayout()
        Me.pnlDelete.ResumeLayout(False)
        Me.pnlDelete.PerformLayout()
        Me.pnlUserCredentials.ResumeLayout(False)
        Me.pnlUserCredentials.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusLabel As StatusStrip
    Friend WithEvents StatusInfo As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnOkay As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRegion As TextBox
    Friend WithEvents label As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tx As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProvince As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtResume As TextBox
    Friend WithEvents txtMName As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtStAddress As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSpecialization As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtCertification As TextBox
    Friend WithEvents txtInitialHour As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents cmbInitialAnte As ComboBox
    Friend WithEvents txtFinalHour As TextBox
    Friend WithEvents cmbFinalAnte As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblnfo As Label
    Friend WithEvents lblUserCred As Label
    Friend WithEvents lblRemove As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblEdit As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblAdd As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents pnlDelete As Panel
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents pnlAdd As Panel
    Friend WithEvents pnlUserCredentials As Panel
    Friend WithEvents btnChange As Button
    Friend WithEvents Panel2 As Panel
End Class
