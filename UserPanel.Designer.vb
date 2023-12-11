<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserPanel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNotif = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnPets = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.pcbProfile = New System.Windows.Forms.PictureBox()
        Me.lblMyPets = New System.Windows.Forms.Label()
        Me.dgvPets = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelAppointment = New System.Windows.Forms.Button()
        Me.btnUpdateAppointment = New System.Windows.Forms.Button()
        Me.btnCreateAppointment = New System.Windows.Forms.Button()
        Me.lblAppointment = New System.Windows.Forms.Label()
        Me.dgvAppointments = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnNotif)
        Me.Panel1.Controls.Add(Me.btnProfile)
        Me.Panel1.Controls.Add(Me.btnAppointment)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnPets)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 689)
        Me.Panel1.TabIndex = 0
        '
        'btnNotif
        '
        Me.btnNotif.FlatAppearance.BorderSize = 0
        Me.btnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotif.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotif.ForeColor = System.Drawing.Color.Transparent
        Me.btnNotif.Image = CType(resources.GetObject("btnNotif.Image"), System.Drawing.Image)
        Me.btnNotif.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNotif.Location = New System.Drawing.Point(0, 275)
        Me.btnNotif.Name = "btnNotif"
        Me.btnNotif.Size = New System.Drawing.Size(148, 137)
        Me.btnNotif.TabIndex = 5
        Me.btnNotif.Text = "Notification"
        Me.btnNotif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNotif.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.Color.Transparent
        Me.btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), System.Drawing.Image)
        Me.btnProfile.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProfile.Location = New System.Drawing.Point(0, 418)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(148, 137)
        Me.btnProfile.TabIndex = 2
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnAppointment
        '
        Me.btnAppointment.FlatAppearance.BorderSize = 0
        Me.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointment.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointment.ForeColor = System.Drawing.Color.Transparent
        Me.btnAppointment.Image = CType(resources.GetObject("btnAppointment.Image"), System.Drawing.Image)
        Me.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAppointment.Location = New System.Drawing.Point(0, 137)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Size = New System.Drawing.Size(148, 137)
        Me.btnAppointment.TabIndex = 4
        Me.btnAppointment.Text = "Appointment"
        Me.btnAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAppointment.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Transparent
        Me.btnLogOut.Image = CType(resources.GetObject("btnLogOut.Image"), System.Drawing.Image)
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogOut.Location = New System.Drawing.Point(0, 552)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(148, 137)
        Me.btnLogOut.TabIndex = 3
        Me.btnLogOut.Text = "Sign out"
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnPets
        '
        Me.btnPets.FlatAppearance.BorderSize = 0
        Me.btnPets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPets.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPets.ForeColor = System.Drawing.Color.Transparent
        Me.btnPets.Image = CType(resources.GetObject("btnPets.Image"), System.Drawing.Image)
        Me.btnPets.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPets.Location = New System.Drawing.Point(0, 0)
        Me.btnPets.Name = "btnPets"
        Me.btnPets.Size = New System.Drawing.Size(148, 137)
        Me.btnPets.TabIndex = 1
        Me.btnPets.Text = "Pets"
        Me.btnPets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPets.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.lblId)
        Me.Panel2.Controls.Add(Me.pcbProfile)
        Me.Panel2.Controls.Add(Me.lblMyPets)
        Me.Panel2.Controls.Add(Me.dgvPets)
        Me.Panel2.Location = New System.Drawing.Point(145, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(817, 689)
        Me.Panel2.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(382, 137)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(132, 43)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(213, 137)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(132, 43)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(651, 645)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "User ID:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(43, 137)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(132, 43)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add Pet"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(718, 645)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(47, 18)
        Me.lblId.TabIndex = 4
        Me.lblId.Text = "Label1"
        '
        'pcbProfile
        '
        Me.pcbProfile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbProfile.BackColor = System.Drawing.Color.Transparent
        Me.pcbProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbProfile.Image = CType(resources.GetObject("pcbProfile.Image"), System.Drawing.Image)
        Me.pcbProfile.Location = New System.Drawing.Point(610, 33)
        Me.pcbProfile.Name = "pcbProfile"
        Me.pcbProfile.Size = New System.Drawing.Size(155, 136)
        Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbProfile.TabIndex = 3
        Me.pcbProfile.TabStop = False
        '
        'lblMyPets
        '
        Me.lblMyPets.AutoSize = True
        Me.lblMyPets.ForeColor = System.Drawing.Color.DarkRed
        Me.lblMyPets.Location = New System.Drawing.Point(40, 43)
        Me.lblMyPets.Name = "lblMyPets"
        Me.lblMyPets.Size = New System.Drawing.Size(45, 13)
        Me.lblMyPets.TabIndex = 2
        Me.lblMyPets.Text = "My Pets"
        '
        'dgvPets
        '
        Me.dgvPets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPets.Location = New System.Drawing.Point(43, 214)
        Me.dgvPets.Name = "dgvPets"
        Me.dgvPets.Size = New System.Drawing.Size(722, 394)
        Me.dgvPets.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnCancelAppointment)
        Me.Panel3.Controls.Add(Me.btnUpdateAppointment)
        Me.Panel3.Controls.Add(Me.btnCreateAppointment)
        Me.Panel3.Controls.Add(Me.lblAppointment)
        Me.Panel3.Controls.Add(Me.dgvAppointments)
        Me.Panel3.Location = New System.Drawing.Point(145, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(814, 689)
        Me.Panel3.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(718, 645)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "User ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(651, 645)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "User ID:"
        '
        'btnCancelAppointment
        '
        Me.btnCancelAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnCancelAppointment.FlatAppearance.BorderSize = 0
        Me.btnCancelAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelAppointment.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancelAppointment.ForeColor = System.Drawing.Color.White
        Me.btnCancelAppointment.Location = New System.Drawing.Point(438, 137)
        Me.btnCancelAppointment.Name = "btnCancelAppointment"
        Me.btnCancelAppointment.Size = New System.Drawing.Size(132, 43)
        Me.btnCancelAppointment.TabIndex = 19
        Me.btnCancelAppointment.Text = "Cancel"
        Me.btnCancelAppointment.UseVisualStyleBackColor = False
        '
        'btnUpdateAppointment
        '
        Me.btnUpdateAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnUpdateAppointment.FlatAppearance.BorderSize = 0
        Me.btnUpdateAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateAppointment.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateAppointment.ForeColor = System.Drawing.Color.White
        Me.btnUpdateAppointment.Location = New System.Drawing.Point(268, 137)
        Me.btnUpdateAppointment.Name = "btnUpdateAppointment"
        Me.btnUpdateAppointment.Size = New System.Drawing.Size(132, 43)
        Me.btnUpdateAppointment.TabIndex = 18
        Me.btnUpdateAppointment.Text = "Update"
        Me.btnUpdateAppointment.UseVisualStyleBackColor = False
        '
        'btnCreateAppointment
        '
        Me.btnCreateAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnCreateAppointment.FlatAppearance.BorderSize = 0
        Me.btnCreateAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateAppointment.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCreateAppointment.ForeColor = System.Drawing.Color.White
        Me.btnCreateAppointment.Location = New System.Drawing.Point(41, 137)
        Me.btnCreateAppointment.Name = "btnCreateAppointment"
        Me.btnCreateAppointment.Size = New System.Drawing.Size(188, 43)
        Me.btnCreateAppointment.TabIndex = 17
        Me.btnCreateAppointment.Text = "Make an Appointment"
        Me.btnCreateAppointment.UseVisualStyleBackColor = False
        '
        'lblAppointment
        '
        Me.lblAppointment.AutoSize = True
        Me.lblAppointment.ForeColor = System.Drawing.Color.DarkRed
        Me.lblAppointment.Location = New System.Drawing.Point(40, 43)
        Me.lblAppointment.Name = "lblAppointment"
        Me.lblAppointment.Size = New System.Drawing.Size(108, 13)
        Me.lblAppointment.TabIndex = 3
        Me.lblAppointment.Text = "Current Appointments"
        '
        'dgvAppointments
        '
        Me.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAppointments.Location = New System.Drawing.Point(43, 214)
        Me.dgvAppointments.Name = "dgvAppointments"
        Me.dgvAppointments.Size = New System.Drawing.Size(722, 394)
        Me.dgvAppointments.TabIndex = 2
        '
        'UserPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(956, 688)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserPanel"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserPanel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPets As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnNotif As Button
    Friend WithEvents btnAppointment As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvPets As DataGridView
    Friend WithEvents lblMyPets As Label
    Friend WithEvents pcbProfile As PictureBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvAppointments As DataGridView
    Friend WithEvents btnCancelAppointment As Button
    Friend WithEvents btnUpdateAppointment As Button
    Friend WithEvents btnCreateAppointment As Button
    Friend WithEvents lblAppointment As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
