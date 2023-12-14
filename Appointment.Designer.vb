<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Appointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appointment))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPets = New System.Windows.Forms.ComboBox()
        Me.txtBreed = New System.Windows.Forms.TextBox()
        Me.txtSpecies = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtBirth = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.pcbDisplay = New System.Windows.Forms.PictureBox()
        Me.dtpDateAppo = New System.Windows.Forms.DateTimePicker()
        Me.cmbAppointment = New System.Windows.Forms.ComboBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPetID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpTimeAppo = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAppointmentId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.pcbDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(354, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pet Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(633, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Species"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(387, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Breed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(386, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date of Birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(387, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Pet"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(354, 433)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Appointment Details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(385, 483)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Type of Appointment"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(385, 643)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Appointment Reason"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(387, 559)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Preferred Date and Time"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(385, 286)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Behavioral Notes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(633, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Gender"
        '
        'cmbPets
        '
        Me.cmbPets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPets.FormattingEnabled = True
        Me.cmbPets.Location = New System.Drawing.Point(390, 106)
        Me.cmbPets.Name = "cmbPets"
        Me.cmbPets.Size = New System.Drawing.Size(204, 21)
        Me.cmbPets.TabIndex = 16
        '
        'txtBreed
        '
        Me.txtBreed.Enabled = False
        Me.txtBreed.Location = New System.Drawing.Point(389, 177)
        Me.txtBreed.Name = "txtBreed"
        Me.txtBreed.ReadOnly = True
        Me.txtBreed.Size = New System.Drawing.Size(204, 20)
        Me.txtBreed.TabIndex = 17
        '
        'txtSpecies
        '
        Me.txtSpecies.Enabled = False
        Me.txtSpecies.Location = New System.Drawing.Point(635, 177)
        Me.txtSpecies.Name = "txtSpecies"
        Me.txtSpecies.ReadOnly = True
        Me.txtSpecies.Size = New System.Drawing.Size(204, 20)
        Me.txtSpecies.TabIndex = 18
        '
        'txtGender
        '
        Me.txtGender.Enabled = False
        Me.txtGender.Location = New System.Drawing.Point(635, 247)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(204, 20)
        Me.txtGender.TabIndex = 19
        '
        'txtBirth
        '
        Me.txtBirth.Location = New System.Drawing.Point(388, 247)
        Me.txtBirth.Name = "txtBirth"
        Me.txtBirth.ReadOnly = True
        Me.txtBirth.Size = New System.Drawing.Size(204, 20)
        Me.txtBirth.TabIndex = 20
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(388, 316)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(466, 74)
        Me.txtNotes.TabIndex = 21
        '
        'pcbDisplay
        '
        Me.pcbDisplay.Image = CType(resources.GetObject("pcbDisplay.Image"), System.Drawing.Image)
        Me.pcbDisplay.Location = New System.Drawing.Point(70, 74)
        Me.pcbDisplay.Name = "pcbDisplay"
        Me.pcbDisplay.Size = New System.Drawing.Size(193, 193)
        Me.pcbDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbDisplay.TabIndex = 9
        Me.pcbDisplay.TabStop = False
        '
        'dtpDateAppo
        '
        Me.dtpDateAppo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateAppo.Location = New System.Drawing.Point(388, 591)
        Me.dtpDateAppo.Name = "dtpDateAppo"
        Me.dtpDateAppo.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateAppo.TabIndex = 22
        '
        'cmbAppointment
        '
        Me.cmbAppointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAppointment.FormattingEnabled = True
        Me.cmbAppointment.Items.AddRange(New Object() {"Check-up", "Vaccination", "Dental Cleaning", "Grooming", "Surgery"})
        Me.cmbAppointment.Location = New System.Drawing.Point(388, 513)
        Me.cmbAppointment.Name = "cmbAppointment"
        Me.cmbAppointment.Size = New System.Drawing.Size(203, 21)
        Me.cmbAppointment.TabIndex = 23
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(388, 672)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(466, 74)
        Me.txtReason.TabIndex = 24
        '
        'btnSchedule
        '
        Me.btnSchedule.Location = New System.Drawing.Point(533, 802)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(183, 42)
        Me.btnSchedule.TabIndex = 25
        Me.btnSchedule.Text = "Schedule An Appointment"
        Me.btnSchedule.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(734, 802)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 42)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(56, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(224, 19)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Your Pet Will Appear Here"
        '
        'txtPetID
        '
        Me.txtPetID.Enabled = False
        Me.txtPetID.Location = New System.Drawing.Point(635, 106)
        Me.txtPetID.Name = "txtPetID"
        Me.txtPetID.ReadOnly = True
        Me.txtPetID.Size = New System.Drawing.Size(204, 20)
        Me.txtPetID.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(632, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Pet ID"
        '
        'dtpTimeAppo
        '
        Me.dtpTimeAppo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeAppo.Location = New System.Drawing.Point(635, 591)
        Me.dtpTimeAppo.Name = "dtpTimeAppo"
        Me.dtpTimeAppo.Size = New System.Drawing.Size(200, 20)
        Me.dtpTimeAppo.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(0, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 16)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Appointment ID"
        '
        'txtAppointmentId
        '
        Me.txtAppointmentId.Location = New System.Drawing.Point(3, 48)
        Me.txtAppointmentId.Name = "txtAppointmentId"
        Me.txtAppointmentId.Size = New System.Drawing.Size(204, 20)
        Me.txtAppointmentId.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtAppointmentId)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(60, 381)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 118)
        Me.Panel1.TabIndex = 35
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(3, 83)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 35
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(922, 877)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtpTimeAppo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPetID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSchedule)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.cmbAppointment)
        Me.Controls.Add(Me.dtpDateAppo)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtBirth)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtSpecies)
        Me.Controls.Add(Me.txtBreed)
        Me.Controls.Add(Me.cmbPets)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.pcbDisplay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Appointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment"
        CType(Me.pcbDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbPets As ComboBox
    Friend WithEvents txtBreed As TextBox
    Friend WithEvents txtSpecies As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtBirth As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents pcbDisplay As PictureBox
    Friend WithEvents dtpDateAppo As DateTimePicker
    Friend WithEvents cmbAppointment As ComboBox
    Friend WithEvents txtReason As TextBox
    Friend WithEvents btnSchedule As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPetID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpTimeAppo As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents txtAppointmentId As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
End Class
