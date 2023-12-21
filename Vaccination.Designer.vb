<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vaccination
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rtxtSideEffects = New System.Windows.Forms.RichTextBox()
        Me.rtxtGuidelines = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtVaccineId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbVaccineType = New System.Windows.Forms.ComboBox()
        Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtRecSpecies = New System.Windows.Forms.TextBox()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.txtVaccineName = New System.Windows.Forms.TextBox()
        Me.btnUploadVaccine = New System.Windows.Forms.Button()
        Me.pcbVaccineProfile = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbVaccineProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.rtxtSideEffects)
        Me.Panel2.Controls.Add(Me.rtxtGuidelines)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.cmbVaccineType)
        Me.Panel2.Controls.Add(Me.dtpExpiryDate)
        Me.Panel2.Controls.Add(Me.txtCost)
        Me.Panel2.Controls.Add(Me.txtRecSpecies)
        Me.Panel2.Controls.Add(Me.txtManufacturer)
        Me.Panel2.Controls.Add(Me.txtVaccineName)
        Me.Panel2.Controls.Add(Me.btnUploadVaccine)
        Me.Panel2.Controls.Add(Me.pcbVaccineProfile)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnConfirm)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(1, -3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(906, 637)
        Me.Panel2.TabIndex = 26
        '
        'rtxtSideEffects
        '
        Me.rtxtSideEffects.Location = New System.Drawing.Point(360, 432)
        Me.rtxtSideEffects.Name = "rtxtSideEffects"
        Me.rtxtSideEffects.Size = New System.Drawing.Size(490, 77)
        Me.rtxtSideEffects.TabIndex = 46
        Me.rtxtSideEffects.Text = ""
        '
        'rtxtGuidelines
        '
        Me.rtxtGuidelines.Location = New System.Drawing.Point(360, 308)
        Me.rtxtGuidelines.Name = "rtxtGuidelines"
        Me.rtxtGuidelines.Size = New System.Drawing.Size(490, 77)
        Me.rtxtGuidelines.TabIndex = 45
        Me.rtxtGuidelines.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtVaccineId)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(49, 257)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 170)
        Me.Panel1.TabIndex = 44
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(61, 76)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(121, 34)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtVaccineId
        '
        Me.txtVaccineId.Location = New System.Drawing.Point(111, 25)
        Me.txtVaccineId.Name = "txtVaccineId"
        Me.txtVaccineId.Size = New System.Drawing.Size(124, 20)
        Me.txtVaccineId.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(14, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Vaccine ID:"
        '
        'cmbVaccineType
        '
        Me.cmbVaccineType.FormattingEnabled = True
        Me.cmbVaccineType.Items.AddRange(New Object() {"Core", "Non-core"})
        Me.cmbVaccineType.Location = New System.Drawing.Point(650, 66)
        Me.cmbVaccineType.Name = "cmbVaccineType"
        Me.cmbVaccineType.Size = New System.Drawing.Size(200, 21)
        Me.cmbVaccineType.TabIndex = 43
        '
        'dtpExpiryDate
        '
        Me.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpiryDate.Location = New System.Drawing.Point(650, 148)
        Me.dtpExpiryDate.Name = "dtpExpiryDate"
        Me.dtpExpiryDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpExpiryDate.TabIndex = 42
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(650, 225)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(184, 20)
        Me.txtCost.TabIndex = 41
        '
        'txtRecSpecies
        '
        Me.txtRecSpecies.Location = New System.Drawing.Point(360, 225)
        Me.txtRecSpecies.Name = "txtRecSpecies"
        Me.txtRecSpecies.Size = New System.Drawing.Size(184, 20)
        Me.txtRecSpecies.TabIndex = 40
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Location = New System.Drawing.Point(360, 149)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(184, 20)
        Me.txtManufacturer.TabIndex = 39
        '
        'txtVaccineName
        '
        Me.txtVaccineName.Location = New System.Drawing.Point(360, 66)
        Me.txtVaccineName.Name = "txtVaccineName"
        Me.txtVaccineName.Size = New System.Drawing.Size(184, 20)
        Me.txtVaccineName.TabIndex = 38
        '
        'btnUploadVaccine
        '
        Me.btnUploadVaccine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnUploadVaccine.FlatAppearance.BorderSize = 0
        Me.btnUploadVaccine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadVaccine.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadVaccine.Location = New System.Drawing.Point(86, 197)
        Me.btnUploadVaccine.Name = "btnUploadVaccine"
        Me.btnUploadVaccine.Size = New System.Drawing.Size(145, 43)
        Me.btnUploadVaccine.TabIndex = 37
        Me.btnUploadVaccine.Text = "Upload Vaccine"
        Me.btnUploadVaccine.UseVisualStyleBackColor = False
        '
        'pcbVaccineProfile
        '
        Me.pcbVaccineProfile.BackColor = System.Drawing.Color.Gray
        Me.pcbVaccineProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbVaccineProfile.Location = New System.Drawing.Point(101, 54)
        Me.pcbVaccineProfile.Name = "pcbVaccineProfile"
        Me.pcbVaccineProfile.Size = New System.Drawing.Size(115, 115)
        Me.pcbVaccineProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbVaccineProfile.TabIndex = 36
        Me.pcbVaccineProfile.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(748, 560)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 38)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(612, 560)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(110, 38)
        Me.btnConfirm.TabIndex = 34
        Me.btnConfirm.Text = "Add Vaccine"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(647, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 16)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Cost"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(357, 399)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Side Effects"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(357, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Guidelines"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(647, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Expiry Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(357, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Recommended Species"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(357, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Manufacturer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(647, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Vaccine Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(357, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Vaccine Name"
        '
        'Vaccination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(906, 627)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Vaccination"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vaccination"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pcbVaccineProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents rtxtSideEffects As RichTextBox
    Friend WithEvents rtxtGuidelines As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtVaccineId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbVaccineType As ComboBox
    Friend WithEvents dtpExpiryDate As DateTimePicker
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtRecSpecies As TextBox
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents txtVaccineName As TextBox
    Friend WithEvents btnUploadVaccine As Button
    Friend WithEvents pcbVaccineProfile As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
