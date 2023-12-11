<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pet))
        Me.pbxProfile = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtPetName = New System.Windows.Forms.TextBox()
        Me.txtBio = New System.Windows.Forms.TextBox()
        Me.txtCurrFood = New System.Windows.Forms.TextBox()
        Me.txtCurrMed = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.cmbSpecies = New System.Windows.Forms.ComboBox()
        Me.txtBreed = New System.Windows.Forms.TextBox()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPetId = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.pbxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxProfile
        '
        Me.pbxProfile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxProfile.BackColor = System.Drawing.Color.Transparent
        Me.pbxProfile.BackgroundImage = CType(resources.GetObject("pbxProfile.BackgroundImage"), System.Drawing.Image)
        Me.pbxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxProfile.Location = New System.Drawing.Point(68, 102)
        Me.pbxProfile.Name = "pbxProfile"
        Me.pbxProfile.Size = New System.Drawing.Size(155, 136)
        Me.pbxProfile.TabIndex = 0
        Me.pbxProfile.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "(file size limit: 2MB)"
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnUpload.FlatAppearance.BorderSize = 0
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(68, 288)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(157, 43)
        Me.btnUpload.TabIndex = 2
        Me.btnUpload.Text = "Upload Picture"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(343, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pet's Name*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(591, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Species*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(343, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Gender*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(591, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Breed*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(343, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Birthday*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(343, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Bio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(343, 484)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Current Food*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(591, 484)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Current Medication"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(343, 573)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Weight (in kgs)*"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(580, 678)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(117, 43)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add Pet"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(725, 678)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 43)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtPetName
        '
        Me.txtPetName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetName.Location = New System.Drawing.Point(346, 129)
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(184, 22)
        Me.txtPetName.TabIndex = 14
        Me.txtPetName.WordWrap = False
        '
        'txtBio
        '
        Me.txtBio.Location = New System.Drawing.Point(346, 374)
        Me.txtBio.Multiline = True
        Me.txtBio.Name = "txtBio"
        Me.txtBio.Size = New System.Drawing.Size(432, 69)
        Me.txtBio.TabIndex = 17
        '
        'txtCurrFood
        '
        Me.txtCurrFood.Location = New System.Drawing.Point(346, 514)
        Me.txtCurrFood.Name = "txtCurrFood"
        Me.txtCurrFood.Size = New System.Drawing.Size(184, 20)
        Me.txtCurrFood.TabIndex = 18
        '
        'txtCurrMed
        '
        Me.txtCurrMed.Location = New System.Drawing.Point(594, 514)
        Me.txtCurrMed.Name = "txtCurrMed"
        Me.txtCurrMed.Size = New System.Drawing.Size(184, 20)
        Me.txtCurrMed.TabIndex = 19
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(346, 603)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(184, 20)
        Me.txtWeight.TabIndex = 20
        '
        'cmbSpecies
        '
        Me.cmbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSpecies.FormattingEnabled = True
        Me.cmbSpecies.Items.AddRange(New Object() {"Dog", "Cat", "Bird"})
        Me.cmbSpecies.Location = New System.Drawing.Point(594, 128)
        Me.cmbSpecies.Name = "cmbSpecies"
        Me.cmbSpecies.Size = New System.Drawing.Size(184, 21)
        Me.cmbSpecies.TabIndex = 22
        '
        'txtBreed
        '
        Me.txtBreed.Location = New System.Drawing.Point(594, 213)
        Me.txtBreed.Name = "txtBreed"
        Me.txtBreed.Size = New System.Drawing.Size(184, 20)
        Me.txtBreed.TabIndex = 23
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthday.Location = New System.Drawing.Point(346, 297)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(200, 20)
        Me.dtpBirthday.TabIndex = 24
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(346, 213)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(184, 21)
        Me.cmbGender.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(-3, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Pet ID: "
        '
        'txtPetId
        '
        Me.txtPetId.Location = New System.Drawing.Point(60, 24)
        Me.txtPetId.Name = "txtPetId"
        Me.txtPetId.Size = New System.Drawing.Size(100, 20)
        Me.txtPetId.TabIndex = 27
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(183, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 28
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtPetId)
        Me.Panel1.Location = New System.Drawing.Point(346, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 54)
        Me.Panel1.TabIndex = 29
        '
        'Pet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(897, 767)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.dtpBirthday)
        Me.Controls.Add(Me.txtBreed)
        Me.Controls.Add(Me.cmbSpecies)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtCurrMed)
        Me.Controls.Add(Me.txtCurrFood)
        Me.Controls.Add(Me.txtBio)
        Me.Controls.Add(Me.txtPetName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbxProfile)
        Me.Name = "Pet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddPet"
        CType(Me.pbxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxProfile As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtPetName As TextBox
    Friend WithEvents txtBio As TextBox
    Friend WithEvents txtCurrFood As TextBox
    Friend WithEvents txtCurrMed As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents cmbSpecies As ComboBox
    Friend WithEvents txtBreed As TextBox
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPetId As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel1 As Panel
End Class
