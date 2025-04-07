<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentsForm
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
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDoctor = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.dtpAppointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dgvAppointments = New System.Windows.Forms.DataGridView()
        Me.txtDoctorID = New System.Windows.Forms.TextBox()
        Me.txtAppointmentID = New System.Windows.Forms.TextBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(11, 55)
        Me.lblPatientName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(51, 13)
        Me.lblPatientName.TabIndex = 0
        Me.lblPatientName.Text = "PatientID"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(11, 130)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(92, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Appointment Date"
        '
        'lblDoctor
        '
        Me.lblDoctor.AutoSize = True
        Me.lblDoctor.Location = New System.Drawing.Point(11, 91)
        Me.lblDoctor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDoctor.Name = "lblDoctor"
        Me.lblDoctor.Size = New System.Drawing.Size(50, 13)
        Me.lblDoctor.TabIndex = 3
        Me.lblDoctor.Text = "DoctorID"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DeepPink
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(221, 382)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 25)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DeepPink
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(523, 382)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 25)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(121, 55)
        Me.txtPatientID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(200, 20)
        Me.txtPatientID.TabIndex = 7
        '
        'dtpAppointmentDate
        '
        Me.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAppointmentDate.Location = New System.Drawing.Point(121, 130)
        Me.dtpAppointmentDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpAppointmentDate.Name = "dtpAppointmentDate"
        Me.dtpAppointmentDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpAppointmentDate.TabIndex = 10
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DeepPink
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(395, 382)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 25)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'dgvAppointments
        '
        Me.dgvAppointments.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAppointments.GridColor = System.Drawing.Color.Silver
        Me.dgvAppointments.Location = New System.Drawing.Point(395, 55)
        Me.dgvAppointments.Name = "dgvAppointments"
        Me.dgvAppointments.Size = New System.Drawing.Size(325, 295)
        Me.dgvAppointments.TabIndex = 13
        '
        'txtDoctorID
        '
        Me.txtDoctorID.Location = New System.Drawing.Point(121, 91)
        Me.txtDoctorID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDoctorID.Name = "txtDoctorID"
        Me.txtDoctorID.Size = New System.Drawing.Size(200, 20)
        Me.txtDoctorID.TabIndex = 14
        '
        'txtAppointmentID
        '
        Me.txtAppointmentID.Location = New System.Drawing.Point(121, 170)
        Me.txtAppointmentID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAppointmentID.Name = "txtAppointmentID"
        Me.txtAppointmentID.Size = New System.Drawing.Size(200, 20)
        Me.txtAppointmentID.TabIndex = 15
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Cancelled", "Schedualed", "Completed"})
        Me.cmbStatus.Location = New System.Drawing.Point(121, 211)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(200, 21)
        Me.cmbStatus.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "AppointmentID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Status"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DeepPink
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(656, 382)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 25)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'AppointmentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(769, 416)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtAppointmentID)
        Me.Controls.Add(Me.txtDoctorID)
        Me.Controls.Add(Me.dgvAppointments)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dtpAppointmentDate)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblDoctor)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblPatientName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AppointmentsForm"
        Me.Text = "AppointmentsForm"
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblDoctor As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents dtpAppointmentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dgvAppointments As DataGridView
    Friend WithEvents txtDoctorID As TextBox
    Friend WithEvents txtAppointmentID As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
End Class
