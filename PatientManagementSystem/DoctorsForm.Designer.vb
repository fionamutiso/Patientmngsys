﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DoctorsForm
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
        Me.lblDoctorName = New System.Windows.Forms.Label()
        Me.lblSpecialty = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtDoctorName = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.doctorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cmbSpecialty = New System.Windows.Forms.ComboBox()
        Me.txtDoctorID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.doctorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDoctorName
        '
        Me.lblDoctorName.AutoSize = True
        Me.lblDoctorName.Location = New System.Drawing.Point(11, 63)
        Me.lblDoctorName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDoctorName.Name = "lblDoctorName"
        Me.lblDoctorName.Size = New System.Drawing.Size(73, 13)
        Me.lblDoctorName.TabIndex = 0
        Me.lblDoctorName.Text = "Doctor Name:"
        '
        'lblSpecialty
        '
        Me.lblSpecialty.AutoSize = True
        Me.lblSpecialty.Location = New System.Drawing.Point(11, 108)
        Me.lblSpecialty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSpecialty.Name = "lblSpecialty"
        Me.lblSpecialty.Size = New System.Drawing.Size(53, 13)
        Me.lblSpecialty.TabIndex = 1
        Me.lblSpecialty.Text = "Specialty:"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(11, 156)
        Me.lblContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(47, 13)
        Me.lblContact.TabIndex = 2
        Me.lblContact.Text = "Contact:"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(122, 153)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(200, 20)
        Me.txtContact.TabIndex = 3
        '
        'txtDoctorName
        '
        Me.txtDoctorName.Location = New System.Drawing.Point(122, 63)
        Me.txtDoctorName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDoctorName.Name = "txtDoctorName"
        Me.txtDoctorName.Size = New System.Drawing.Size(200, 20)
        Me.txtDoctorName.TabIndex = 5
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(490, 307)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 25)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(222, 240)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 25)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'doctorsDataGridView
        '
        Me.doctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.doctorsDataGridView.Location = New System.Drawing.Point(350, 63)
        Me.doctorsDataGridView.Name = "doctorsDataGridView"
        Me.doctorsDataGridView.Size = New System.Drawing.Size(240, 226)
        Me.doctorsDataGridView.TabIndex = 8
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(350, 307)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cmbSpecialty
        '
        Me.cmbSpecialty.FormattingEnabled = True
        Me.cmbSpecialty.Location = New System.Drawing.Point(122, 108)
        Me.cmbSpecialty.Name = "cmbSpecialty"
        Me.cmbSpecialty.Size = New System.Drawing.Size(200, 21)
        Me.cmbSpecialty.TabIndex = 10
        '
        'txtDoctorID
        '
        Me.txtDoctorID.Location = New System.Drawing.Point(122, 201)
        Me.txtDoctorID.Name = "txtDoctorID"
        Me.txtDoctorID.Size = New System.Drawing.Size(200, 20)
        Me.txtDoctorID.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "DoctorID"
        '
        'DoctorsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 360)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDoctorID)
        Me.Controls.Add(Me.cmbSpecialty)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.doctorsDataGridView)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtDoctorName)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblSpecialty)
        Me.Controls.Add(Me.lblDoctorName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "DoctorsForm"
        Me.Text = "DoctorsForm"
        CType(Me.doctorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDoctorName As System.Windows.Forms.Label
    Friend WithEvents lblSpecialty As System.Windows.Forms.Label
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtDoctorName As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents doctorsDataGridView As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cmbSpecialty As ComboBox
    Friend WithEvents txtDoctorID As TextBox
    Friend WithEvents Label1 As Label
End Class
