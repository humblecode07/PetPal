<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PetHealthMonitor
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPetID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnLoadPHMReport = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pcbPetProfile = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chtWeight = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblReasonVisit = New System.Windows.Forms.Label()
        Me.lblTypeAppointment = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.lblAssignedStaff = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblBehaveNotes = New System.Windows.Forms.Label()
        Me.lblBreed = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblSpecies = New System.Windows.Forms.Label()
        Me.lblPetName = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblCurrWeight = New System.Windows.Forms.Label()
        Me.lblComparison = New System.Windows.Forms.Label()
        Me.lblCurrDate = New System.Windows.Forms.Label()
        Me.txtCurrWeight = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpCurrDate = New System.Windows.Forms.DateTimePicker()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.pcbPetProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.chtWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtPetID)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnConfirm)
        Me.Panel3.Controls.Add(Me.btnLoadPHMReport)
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.txtID)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.pcbPetProfile)
        Me.Panel3.Controls.Add(Me.btnBack)
        Me.Panel3.Location = New System.Drawing.Point(-1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(201, 674)
        Me.Panel3.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(87, 322)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(95, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "App.. ID:"
        '
        'txtPetID
        '
        Me.txtPetID.Location = New System.Drawing.Point(75, 291)
        Me.txtPetID.Name = "txtPetID"
        Me.txtPetID.Size = New System.Drawing.Size(108, 20)
        Me.txtPetID.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Pet ID:"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(20, 542)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(163, 45)
        Me.btnConfirm.TabIndex = 10
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnLoadPHMReport
        '
        Me.btnLoadPHMReport.Location = New System.Drawing.Point(20, 607)
        Me.btnLoadPHMReport.Name = "btnLoadPHMReport"
        Me.btnLoadPHMReport.Size = New System.Drawing.Size(163, 45)
        Me.btnLoadPHMReport.TabIndex = 9
        Me.btnLoadPHMReport.Text = "Load Report"
        Me.btnLoadPHMReport.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(45, 367)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(106, 36)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(75, 264)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(108, 20)
        Me.txtID.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(42, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID:"
        '
        'pcbPetProfile
        '
        Me.pcbPetProfile.BackColor = System.Drawing.Color.Gray
        Me.pcbPetProfile.Location = New System.Drawing.Point(32, 97)
        Me.pcbPetProfile.Name = "pcbPetProfile"
        Me.pcbPetProfile.Size = New System.Drawing.Size(136, 127)
        Me.pcbPetProfile.TabIndex = 1
        Me.pcbPetProfile.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(-1, -1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(203, 56)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(978, 56)
        Me.Panel2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(260, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(383, 33)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "PET HEALTH MONITORING"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.dtpCurrDate)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtCurrWeight)
        Me.Panel1.Controls.Add(Me.lblCurrDate)
        Me.Panel1.Controls.Add(Me.lblComparison)
        Me.Panel1.Controls.Add(Me.lblCurrWeight)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.chtWeight)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.lblReasonVisit)
        Me.Panel1.Controls.Add(Me.lblTypeAppointment)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblContact)
        Me.Panel1.Controls.Add(Me.lblOwnerName)
        Me.Panel1.Controls.Add(Me.lblAssignedStaff)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblBehaveNotes)
        Me.Panel1.Controls.Add(Me.lblBreed)
        Me.Panel1.Controls.Add(Me.lblBirthDate)
        Me.Panel1.Controls.Add(Me.lblSpecies)
        Me.Panel1.Controls.Add(Me.lblPetName)
        Me.Panel1.Location = New System.Drawing.Point(200, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 621)
        Me.Panel1.TabIndex = 6
        '
        'chtWeight
        '
        ChartArea2.Name = "ChartArea1"
        Me.chtWeight.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chtWeight.Legends.Add(Legend2)
        Me.chtWeight.Location = New System.Drawing.Point(203, 333)
        Me.chtWeight.Name = "chtWeight"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chtWeight.Series.Add(Series2)
        Me.chtWeight.Size = New System.Drawing.Size(315, 118)
        Me.chtWeight.TabIndex = 18
        Me.chtWeight.Text = "Chart1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(32, 300)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 19)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Weight Trend:"
        '
        'lblReasonVisit
        '
        Me.lblReasonVisit.AutoSize = True
        Me.lblReasonVisit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblReasonVisit.Location = New System.Drawing.Point(701, 120)
        Me.lblReasonVisit.Name = "lblReasonVisit"
        Me.lblReasonVisit.Size = New System.Drawing.Size(98, 13)
        Me.lblReasonVisit.TabIndex = 16
        Me.lblReasonVisit.Text = "Reason for Visit:"
        '
        'lblTypeAppointment
        '
        Me.lblTypeAppointment.AutoSize = True
        Me.lblTypeAppointment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTypeAppointment.Location = New System.Drawing.Point(700, 82)
        Me.lblTypeAppointment.Name = "lblTypeAppointment"
        Me.lblTypeAppointment.Size = New System.Drawing.Size(129, 13)
        Me.lblTypeAppointment.TabIndex = 15
        Me.lblTypeAppointment.Text = "Type of Appointment:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(699, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(153, 19)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Appointment Info"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAddress.Location = New System.Drawing.Point(381, 120)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(53, 13)
        Me.lblAddress.TabIndex = 10
        Me.lblAddress.Text = "Address"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.Location = New System.Drawing.Point(381, 159)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(37, 13)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblContact.Location = New System.Drawing.Point(381, 82)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(51, 13)
        Me.lblContact.TabIndex = 8
        Me.lblContact.Text = "Contact"
        '
        'lblOwnerName
        '
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblOwnerName.Location = New System.Drawing.Point(380, 45)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(120, 19)
        Me.lblOwnerName.TabIndex = 7
        Me.lblOwnerName.Text = "Owner Name:"
        '
        'lblAssignedStaff
        '
        Me.lblAssignedStaff.AutoSize = True
        Me.lblAssignedStaff.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAssignedStaff.Location = New System.Drawing.Point(154, 195)
        Me.lblAssignedStaff.Name = "lblAssignedStaff"
        Me.lblAssignedStaff.Size = New System.Drawing.Size(103, 13)
        Me.lblAssignedStaff.TabIndex = 6
        Me.lblAssignedStaff.Text = "Primary Provider"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(33, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Primary Provider:"
        '
        'lblBehaveNotes
        '
        Me.lblBehaveNotes.AutoSize = True
        Me.lblBehaveNotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblBehaveNotes.ForeColor = System.Drawing.Color.Red
        Me.lblBehaveNotes.Location = New System.Drawing.Point(33, 235)
        Me.lblBehaveNotes.Name = "lblBehaveNotes"
        Me.lblBehaveNotes.Size = New System.Drawing.Size(92, 13)
        Me.lblBehaveNotes.TabIndex = 4
        Me.lblBehaveNotes.Text = "Behavior Notes"
        '
        'lblBreed
        '
        Me.lblBreed.AutoSize = True
        Me.lblBreed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblBreed.Location = New System.Drawing.Point(35, 120)
        Me.lblBreed.Name = "lblBreed"
        Me.lblBreed.Size = New System.Drawing.Size(40, 13)
        Me.lblBreed.TabIndex = 3
        Me.lblBreed.Text = "Breed"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblBirthDate.Location = New System.Drawing.Point(156, 82)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(60, 13)
        Me.lblBirthDate.TabIndex = 2
        Me.lblBirthDate.Text = "Birthdate"
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecies.Location = New System.Drawing.Point(35, 82)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(50, 13)
        Me.lblSpecies.TabIndex = 1
        Me.lblSpecies.Text = "Species"
        '
        'lblPetName
        '
        Me.lblPetName.AutoSize = True
        Me.lblPetName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetName.Location = New System.Drawing.Point(32, 45)
        Me.lblPetName.Name = "lblPetName"
        Me.lblPetName.Size = New System.Drawing.Size(95, 19)
        Me.lblPetName.TabIndex = 0
        Me.lblPetName.Text = "Pet Name:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(35, 490)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 13)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Current Weight:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(248, 490)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 13)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Current Date: "
        '
        'lblCurrWeight
        '
        Me.lblCurrWeight.AutoSize = True
        Me.lblCurrWeight.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrWeight.Location = New System.Drawing.Point(35, 348)
        Me.lblCurrWeight.Name = "lblCurrWeight"
        Me.lblCurrWeight.Size = New System.Drawing.Size(50, 13)
        Me.lblCurrWeight.TabIndex = 22
        Me.lblCurrWeight.Text = "Weight:"
        '
        'lblComparison
        '
        Me.lblComparison.AutoSize = True
        Me.lblComparison.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComparison.Location = New System.Drawing.Point(35, 383)
        Me.lblComparison.Name = "lblComparison"
        Me.lblComparison.Size = New System.Drawing.Size(77, 13)
        Me.lblComparison.TabIndex = 23
        Me.lblComparison.Text = "Comparison:"
        '
        'lblCurrDate
        '
        Me.lblCurrDate.AutoSize = True
        Me.lblCurrDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrDate.Location = New System.Drawing.Point(35, 419)
        Me.lblCurrDate.Name = "lblCurrDate"
        Me.lblCurrDate.Size = New System.Drawing.Size(34, 13)
        Me.lblCurrDate.TabIndex = 24
        Me.lblCurrDate.Text = "Date"
        '
        'txtCurrWeight
        '
        Me.txtCurrWeight.Location = New System.Drawing.Point(36, 515)
        Me.txtCurrWeight.Name = "txtCurrWeight"
        Me.txtCurrWeight.Size = New System.Drawing.Size(167, 20)
        Me.txtCurrWeight.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 555)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 35)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Update Current Weight"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpCurrDate
        '
        Me.dtpCurrDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCurrDate.Location = New System.Drawing.Point(251, 515)
        Me.dtpCurrDate.Name = "dtpCurrDate"
        Me.dtpCurrDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpCurrDate.TabIndex = 28
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblGender.Location = New System.Drawing.Point(35, 159)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(48, 13)
        Me.lblGender.TabIndex = 29
        Me.lblGender.Text = "Gender"
        '
        'PetHealthMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 674)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "PetHealthMonitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PetHealthMonitor"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pcbPetProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.chtWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPetID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnLoadPHMReport As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pcbPetProfile As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAssignedStaff As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblBehaveNotes As Label
    Friend WithEvents lblBreed As Label
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents lblSpecies As Label
    Friend WithEvents lblPetName As Label
    Friend WithEvents chtWeight As DataVisualization.Charting.Chart
    Friend WithEvents Label19 As Label
    Friend WithEvents lblReasonVisit As Label
    Friend WithEvents lblTypeAppointment As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblOwnerName As Label
    Friend WithEvents dtpCurrDate As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCurrWeight As TextBox
    Friend WithEvents lblCurrDate As Label
    Friend WithEvents lblComparison As Label
    Friend WithEvents lblCurrWeight As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblGender As Label
End Class
