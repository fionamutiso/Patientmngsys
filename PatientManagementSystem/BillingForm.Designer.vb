<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingForm
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
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.lblPaymentStatus = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.txtServiceReceived = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.cmbPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvBilling = New System.Windows.Forms.DataGridView()
        Me.dtpBillingDate = New System.Windows.Forms.DateTimePicker()
        Me.txtBillID = New System.Windows.Forms.TextBox()
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(40, 51)
        Me.lblPatientName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(74, 13)
        Me.lblPatientName.TabIndex = 0
        Me.lblPatientName.Text = "Patient Name:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(40, 147)
        Me.lblCost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(31, 13)
        Me.lblCost.TabIndex = 1
        Me.lblCost.Text = "Cost:"
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Location = New System.Drawing.Point(40, 97)
        Me.lblService.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(46, 13)
        Me.lblService.TabIndex = 2
        Me.lblService.Text = "Service:"
        '
        'lblPaymentStatus
        '
        Me.lblPaymentStatus.AutoSize = True
        Me.lblPaymentStatus.Location = New System.Drawing.Point(40, 196)
        Me.lblPaymentStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPaymentStatus.Name = "lblPaymentStatus"
        Me.lblPaymentStatus.Size = New System.Drawing.Size(84, 13)
        Me.lblPaymentStatus.TabIndex = 3
        Me.lblPaymentStatus.Text = "Payment Status:"
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(157, 51)
        Me.txtPatientID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(200, 20)
        Me.txtPatientID.TabIndex = 4
        '
        'txtServiceReceived
        '
        Me.txtServiceReceived.Location = New System.Drawing.Point(157, 97)
        Me.txtServiceReceived.Margin = New System.Windows.Forms.Padding(2)
        Me.txtServiceReceived.Name = "txtServiceReceived"
        Me.txtServiceReceived.Size = New System.Drawing.Size(200, 20)
        Me.txtServiceReceived.TabIndex = 5
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(157, 147)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(200, 20)
        Me.txtAmount.TabIndex = 6
        '
        'cmbPaymentStatus
        '
        Me.cmbPaymentStatus.FormattingEnabled = True
        Me.cmbPaymentStatus.Location = New System.Drawing.Point(157, 190)
        Me.cmbPaymentStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPaymentStatus.Name = "cmbPaymentStatus"
        Me.cmbPaymentStatus.Size = New System.Drawing.Size(200, 21)
        Me.cmbPaymentStatus.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(261, 333)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 25)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(157, 333)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 25)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(411, 333)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(658, 333)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvBilling
        '
        Me.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBilling.Location = New System.Drawing.Point(411, 51)
        Me.dgvBilling.Name = "dgvBilling"
        Me.dgvBilling.Size = New System.Drawing.Size(322, 232)
        Me.dgvBilling.TabIndex = 13
        '
        'dtpBillingDate
        '
        Me.dtpBillingDate.Location = New System.Drawing.Point(157, 245)
        Me.dtpBillingDate.Name = "dtpBillingDate"
        Me.dtpBillingDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpBillingDate.TabIndex = 14
        '
        'txtBillID
        '
        Me.txtBillID.Location = New System.Drawing.Point(157, 292)
        Me.txtBillID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBillID.Name = "txtBillID"
        Me.txtBillID.Size = New System.Drawing.Size(200, 20)
        Me.txtBillID.TabIndex = 15
        '
        'BillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 413)
        Me.Controls.Add(Me.txtBillID)
        Me.Controls.Add(Me.dtpBillingDate)
        Me.Controls.Add(Me.dgvBilling)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cmbPaymentStatus)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtServiceReceived)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.lblPaymentStatus)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblPatientName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BillingForm"
        Me.Text = "BillingForm"
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblService As System.Windows.Forms.Label
    Friend WithEvents lblPaymentStatus As System.Windows.Forms.Label
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents txtServiceReceived As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmbPaymentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvBilling As DataGridView
    Friend WithEvents dtpBillingDate As DateTimePicker
    Friend WithEvents txtBillID As TextBox
End Class
