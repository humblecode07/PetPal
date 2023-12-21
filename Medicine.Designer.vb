<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicine
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtMedicineID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.pcbMedicineProfile = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.txtConcentration = New System.Windows.Forms.TextBox()
        Me.txtAdminRoute = New System.Windows.Forms.TextBox()
        Me.txtBrandName = New System.Windows.Forms.TextBox()
        Me.txtGenericName = New System.Windows.Forms.TextBox()
        Me.txtMedicineName = New System.Windows.Forms.TextBox()
        Me.rtxtDosageInfo = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pcbMedicineProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.txtManufacturer)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnUpload)
        Me.Panel1.Controls.Add(Me.pcbMedicineProfile)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnConfirm)
        Me.Panel1.Controls.Add(Me.dtpExpiryDate)
        Me.Panel1.Controls.Add(Me.txtConcentration)
        Me.Panel1.Controls.Add(Me.txtAdminRoute)
        Me.Panel1.Controls.Add(Me.txtBrandName)
        Me.Panel1.Controls.Add(Me.txtGenericName)
        Me.Panel1.Controls.Add(Me.txtMedicineName)
        Me.Panel1.Controls.Add(Me.rtxtDosageInfo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 680)
        Me.Panel1.TabIndex = 0
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Location = New System.Drawing.Point(406, 506)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(200, 20)
        Me.txtManufacturer.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(403, 467)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Manufacturer:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.txtMedicineID)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(42, 325)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(231, 123)
        Me.Panel3.TabIndex = 20
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(63, 88)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(103, 32)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtMedicineID
        '
        Me.txtMedicineID.Location = New System.Drawing.Point(18, 51)
        Me.txtMedicineID.Name = "txtMedicineID"
        Me.txtMedicineID.Size = New System.Drawing.Size(200, 20)
        Me.txtMedicineID.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Medicine ID:"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(71, 254)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(174, 43)
        Me.btnUpload.TabIndex = 19
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'pcbMedicineProfile
        '
        Me.pcbMedicineProfile.BackColor = System.Drawing.Color.Gray
        Me.pcbMedicineProfile.Location = New System.Drawing.Point(88, 85)
        Me.pcbMedicineProfile.Name = "pcbMedicineProfile"
        Me.pcbMedicineProfile.Size = New System.Drawing.Size(137, 137)
        Me.pcbMedicineProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbMedicineProfile.TabIndex = 18
        Me.pcbMedicineProfile.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(678, 603)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(163, 43)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(491, 603)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(163, 43)
        Me.btnConfirm.TabIndex = 16
        Me.btnConfirm.Text = "Add"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'dtpExpiryDate
        '
        Me.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpiryDate.Location = New System.Drawing.Point(651, 189)
        Me.dtpExpiryDate.Name = "dtpExpiryDate"
        Me.dtpExpiryDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpExpiryDate.TabIndex = 15
        '
        'txtConcentration
        '
        Me.txtConcentration.Location = New System.Drawing.Point(651, 428)
        Me.txtConcentration.Name = "txtConcentration"
        Me.txtConcentration.Size = New System.Drawing.Size(200, 20)
        Me.txtConcentration.TabIndex = 14
        '
        'txtAdminRoute
        '
        Me.txtAdminRoute.Location = New System.Drawing.Point(406, 428)
        Me.txtAdminRoute.Name = "txtAdminRoute"
        Me.txtAdminRoute.Size = New System.Drawing.Size(200, 20)
        Me.txtAdminRoute.TabIndex = 13
        '
        'txtBrandName
        '
        Me.txtBrandName.Location = New System.Drawing.Point(406, 189)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(200, 20)
        Me.txtBrandName.TabIndex = 11
        '
        'txtGenericName
        '
        Me.txtGenericName.Location = New System.Drawing.Point(651, 114)
        Me.txtGenericName.Name = "txtGenericName"
        Me.txtGenericName.Size = New System.Drawing.Size(200, 20)
        Me.txtGenericName.TabIndex = 10
        '
        'txtMedicineName
        '
        Me.txtMedicineName.Location = New System.Drawing.Point(406, 114)
        Me.txtMedicineName.Name = "txtMedicineName"
        Me.txtMedicineName.Size = New System.Drawing.Size(200, 20)
        Me.txtMedicineName.TabIndex = 9
        '
        'rtxtDosageInfo
        '
        Me.rtxtDosageInfo.Location = New System.Drawing.Point(406, 266)
        Me.rtxtDosageInfo.Name = "rtxtDosageInfo"
        Me.rtxtDosageInfo.Size = New System.Drawing.Size(445, 96)
        Me.rtxtDosageInfo.TabIndex = 8
        Me.rtxtDosageInfo.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(403, 389)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Administration Route:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(648, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Concentration"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(403, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Dosage Info:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(648, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Expiry Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(403, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Brand Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(648, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Generic Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(403, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Medicine Name:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(883, 46)
        Me.Panel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(382, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MEDICINE"
        '
        'Medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 677)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Medicine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicine"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pcbMedicineProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtMedicineID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents pcbMedicineProfile As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents dtpExpiryDate As DateTimePicker
    Friend WithEvents txtConcentration As TextBox
    Friend WithEvents txtAdminRoute As TextBox
    Friend WithEvents txtBrandName As TextBox
    Friend WithEvents txtGenericName As TextBox
    Friend WithEvents txtMedicineName As TextBox
    Friend WithEvents rtxtDosageInfo As RichTextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents Label10 As Label
End Class
