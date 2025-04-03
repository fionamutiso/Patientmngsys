Public Class BillingForm

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Try
            ' Validate fields
            If txtPatientName.Text = "" Or cmbPaymentStatus.SelectedItem Is Nothing Then
                MessageBox.Show("Please enter all details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Retrieve values
            Dim patientName As String = txtPatientName.Text
            Dim paymentStatus As String = cmbPaymentStatus.SelectedItem.ToString()

            ' Show confirmation
            MessageBox.Show("Billing Submitted!" & vbCrLf &
                            "Patient: " & patientName & vbCrLf &
                            "Payment Status: " & paymentStatus, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BillingForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmbPaymentStatus.Items.Clear()
        cmbPaymentStatus.Items.Add("Paid")
        cmbPaymentStatus.Items.Add("Unpaid")
    End Sub
End Class