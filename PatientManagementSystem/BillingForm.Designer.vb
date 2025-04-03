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
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.txtService = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.cmbPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
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
        'txtPatientName
        '
        Me.txtPatientName.Location = New System.Drawing.Point(157, 51)
        Me.txtPatientName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(200, 20)
        Me.txtPatientName.TabIndex = 4
        '
        'txtService
        '
        Me.txtService.Location = New System.Drawing.Point(157, 97)
        Me.txtService.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(200, 20)
        Me.txtService.TabIndex = 5
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(157, 147)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(200, 20)
        Me.txtCost.TabIndex = 6
        '
        'cmbPaymentStatus
        '
        Me.cmbPaymentStatus.FormattingEnabled = True
        Me.cmbPaymentStatus.Location = New System.Drawing.Point(157, 190)
        Me.cmbPaymentStatus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbPaymentStatus.Name = "cmbPaymentStatus"
        Me.cmbPaymentStatus.Size = New System.Drawing.Size(200, 21)
        Me.cmbPaymentStatus.TabIndex = 7
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(288, 243)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 25)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(157, 243)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 25)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'BillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 317)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cmbPaymentStatus)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtService)
        Me.Controls.Add(Me.txtPatientName)
        Me.Controls.Add(Me.lblPaymentStatus)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblPatientName)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "BillingForm"
        Me.Text = "BillingForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblService As System.Windows.Forms.Label
    Friend WithEvents lblPaymentStatus As System.Windows.Forms.Label
    Friend WithEvents txtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents txtService As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents cmbPaymentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
