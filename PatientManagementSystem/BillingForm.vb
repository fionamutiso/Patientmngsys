Imports System.Data.SqlClient

Public Class BillingForm
    Private connectionString As String = ("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("INSERT INTO Billing (PatientID, ServiceReceived, Amount, PaymentStatus, BillingDate) VALUES (@PatientID, @ServiceReceived, @Amount, @PaymentStatus, @BillingDate)", connection)
            command.Parameters.AddWithValue("@PatientID", CInt(txtPatientID.Text))
            command.Parameters.AddWithValue("@ServiceReceived", txtServiceReceived.Text)
            command.Parameters.AddWithValue("@Amount", Decimal.Parse(txtAmount.Text))
            command.Parameters.AddWithValue("@PaymentStatus", cmbPaymentStatus.SelectedItem.ToString())
            command.Parameters.AddWithValue("@BillingDate", dtpBillingDate.Value)

            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Billing record added successfully!")
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BillingForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadBilling()
    End Sub

    Private Sub LoadBilling()
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("SELECT * FROM Billing", connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            connection.Open()
            adapter.Fill(table)
            dgvBilling.DataSource = table
        End Using

    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("UPDATE Billing SET ServiceReceived = @ServiceReceived, Amount = @Amount, PaymentStatus = @PaymentStatus, BillingDate = @BillingDate WHERE BillID = @BillID", connection)
            command.Parameters.AddWithValue("@BillID", CInt(txtBillID.Text))
            command.Parameters.AddWithValue("@ServiceReceived", txtServiceReceived.Text)
            command.Parameters.AddWithValue("@Amount", Decimal.Parse(txtAmount.Text))
            command.Parameters.AddWithValue("@PaymentStatus", cmbPaymentStatus.SelectedItem.ToString())
            command.Parameters.AddWithValue("@BillingDate", dtpBillingDate.Value)

            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Billing record updated successfully!")
            Else
                MessageBox.Show("Billing record not found.")
            End If
        End Using
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("DELETE FROM Billing WHERE BillID = @BillID", connection)
            command.Parameters.AddWithValue("@BillID", CInt(txtBillID.Text))

            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Billing record deleted successfully!")
            Else
                MessageBox.Show("Billing record not found.")
            End If
        End Using
    End Sub
End Class