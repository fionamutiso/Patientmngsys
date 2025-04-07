<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.btnAppointments = New System.Windows.Forms.Button()
        Me.btnPatients = New System.Windows.Forms.Button()
        Me.btnDoctors = New System.Windows.Forms.Button()
        Me.btnBilling = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAppointments
        '
        Me.btnAppointments.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointments.Location = New System.Drawing.Point(169, 85)
        Me.btnAppointments.Name = "btnAppointments"
        Me.btnAppointments.Size = New System.Drawing.Size(125, 40)
        Me.btnAppointments.TabIndex = 0
        Me.btnAppointments.Text = "Appointments "
        Me.btnAppointments.UseVisualStyleBackColor = False
        '
        'btnPatients
        '
        Me.btnPatients.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatients.Location = New System.Drawing.Point(12, 85)
        Me.btnPatients.Name = "btnPatients"
        Me.btnPatients.Size = New System.Drawing.Size(125, 40)
        Me.btnPatients.TabIndex = 1
        Me.btnPatients.Text = "Patients"
        Me.btnPatients.UseVisualStyleBackColor = False
        '
        'btnDoctors
        '
        Me.btnDoctors.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoctors.Location = New System.Drawing.Point(323, 85)
        Me.btnDoctors.Name = "btnDoctors"
        Me.btnDoctors.Size = New System.Drawing.Size(125, 40)
        Me.btnDoctors.TabIndex = 2
        Me.btnDoctors.Text = "Doctors"
        Me.btnDoctors.UseVisualStyleBackColor = False
        '
        'btnBilling
        '
        Me.btnBilling.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBilling.Location = New System.Drawing.Point(476, 85)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(125, 40)
        Me.btnBilling.TabIndex = 3
        Me.btnBilling.Text = "Billing"
        Me.btnBilling.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(227, 183)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(125, 40)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PatientManagementSystem.My.Resources.Resources.dashboardbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(614, 276)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnBilling)
        Me.Controls.Add(Me.btnDoctors)
        Me.Controls.Add(Me.btnPatients)
        Me.Controls.Add(Me.btnAppointments)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainMenu"
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAppointments As System.Windows.Forms.Button
    Friend WithEvents btnPatients As System.Windows.Forms.Button
    Friend WithEvents btnDoctors As System.Windows.Forms.Button
    Friend WithEvents btnBilling As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
