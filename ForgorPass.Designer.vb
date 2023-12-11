<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgorPass
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.pnlSecurity = New System.Windows.Forms.Panel()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSecurity = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlSecurity.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(535, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Oh no! It seems you've forgotten your password. No worries, we're here to help."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Enter your username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Location = New System.Drawing.Point(12, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 5)
        Me.Panel1.TabIndex = 18
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(55, 108)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(252, 20)
        Me.txtUserName.TabIndex = 19
        '
        'pnlSecurity
        '
        Me.pnlSecurity.Controls.Add(Me.btnAnswer)
        Me.pnlSecurity.Controls.Add(Me.txtAnswer)
        Me.pnlSecurity.Controls.Add(Me.Label5)
        Me.pnlSecurity.Controls.Add(Me.lblSecurity)
        Me.pnlSecurity.Controls.Add(Me.Label2)
        Me.pnlSecurity.Location = New System.Drawing.Point(55, 154)
        Me.pnlSecurity.Name = "pnlSecurity"
        Me.pnlSecurity.Size = New System.Drawing.Size(532, 182)
        Me.pnlSecurity.TabIndex = 20
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(427, 96)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(88, 23)
        Me.btnAnswer.TabIndex = 22
        Me.btnAnswer.Text = "Enter"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(68, 98)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(334, 20)
        Me.txtAnswer.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-1, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Answer:"
        '
        'lblSecurity
        '
        Me.lblSecurity.AutoSize = True
        Me.lblSecurity.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecurity.Location = New System.Drawing.Point(-3, 55)
        Me.lblSecurity.Name = "lblSecurity"
        Me.lblSecurity.Size = New System.Drawing.Size(65, 16)
        Me.lblSecurity.TabIndex = 22
        Me.lblSecurity.Text = "Question"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Please answer this security question"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(331, 106)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(88, 23)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'ForgorPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 348)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.pnlSecurity)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "ForgorPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        Me.pnlSecurity.ResumeLayout(False)
        Me.pnlSecurity.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents pnlSecurity As Panel
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSecurity As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAnswer As Button
    Friend WithEvents btnSearch As Button
End Class
