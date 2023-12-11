<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrontPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrontPage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnContact = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnServices = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pnlWelcome = New System.Windows.Forms.Panel()
        Me.btnGetStart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnlWelcome.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAbout)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnContact)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnServices)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1086, 65)
        Me.Panel1.TabIndex = 0
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Location = New System.Drawing.Point(787, 0)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(126, 65)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(101, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(126, 65)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PetPal"
        '
        'btnContact
        '
        Me.btnContact.BackColor = System.Drawing.Color.Transparent
        Me.btnContact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContact.FlatAppearance.BorderSize = 0
        Me.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContact.ForeColor = System.Drawing.Color.White
        Me.btnContact.Location = New System.Drawing.Point(614, 0)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Size = New System.Drawing.Size(167, 65)
        Me.btnContact.TabIndex = 2
        Me.btnContact.Text = "Contact Us"
        Me.btnContact.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 73)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnServices
        '
        Me.btnServices.BackColor = System.Drawing.Color.Transparent
        Me.btnServices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnServices.FlatAppearance.BorderSize = 0
        Me.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServices.ForeColor = System.Drawing.Color.White
        Me.btnServices.Location = New System.Drawing.Point(462, 0)
        Me.btnServices.Name = "btnServices"
        Me.btnServices.Size = New System.Drawing.Size(146, 65)
        Me.btnServices.TabIndex = 1
        Me.btnServices.Text = "Services"
        Me.btnServices.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(330, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(126, 65)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.pnlWelcome)
        Me.Panel3.Location = New System.Drawing.Point(0, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1055, 681)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 631)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1052, 47)
        Me.Panel5.TabIndex = 0
        '
        'pnlWelcome
        '
        Me.pnlWelcome.BackColor = System.Drawing.Color.Transparent
        Me.pnlWelcome.Controls.Add(Me.btnGetStart)
        Me.pnlWelcome.Controls.Add(Me.Label3)
        Me.pnlWelcome.Controls.Add(Me.Label2)
        Me.pnlWelcome.Location = New System.Drawing.Point(50, 31)
        Me.pnlWelcome.Name = "pnlWelcome"
        Me.pnlWelcome.Size = New System.Drawing.Size(945, 567)
        Me.pnlWelcome.TabIndex = 0
        '
        'btnGetStart
        '
        Me.btnGetStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnGetStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnGetStart.FlatAppearance.BorderSize = 0
        Me.btnGetStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetStart.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetStart.ForeColor = System.Drawing.Color.White
        Me.btnGetStart.Location = New System.Drawing.Point(358, 236)
        Me.btnGetStart.Name = "btnGetStart"
        Me.btnGetStart.Size = New System.Drawing.Size(191, 48)
        Me.btnGetStart.TabIndex = 2
        Me.btnGetStart.Text = "Get Started"
        Me.btnGetStart.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(109, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(713, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(158, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(633, 116)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Embark on Your Pet Care" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Adventure with Us"
        '
        'FrontPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1047, 741)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "FrontPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrontPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.pnlWelcome.ResumeLayout(False)
        Me.pnlWelcome.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnContact As Button
    Friend WithEvents btnServices As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents pnlWelcome As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGetStart As Button
End Class
