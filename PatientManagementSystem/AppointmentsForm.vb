Imports System.Data.SqlClient

Public Class AppointmentsForm
    Dim dtAppointments As New DataTable()
    Dim adapter As SqlDataAdapter
    Dim connection As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
    Dim con As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Using connection As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
            Dim command As New SqlCommand("INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, Status, Notes) VALUES (@PatientID, @DoctorID, @AppointmentDate, @Status, @Notes)", connection)
            command.Parameters.AddWithValue("@PatientID", CInt(txtPatientID.Text))
            command.Parameters.AddWithValue("@DoctorID", CInt(txtDoctorID.Text))
            command.Parameters.AddWithValue("@AppointmentDate", dtpAppointmentDate.Value)
            command.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString())

            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Appointment added successfully!")
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Using connection As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
            Dim command As New SqlCommand("UPDATE Appointments SET DoctorID = @DoctorID, AppointmentDate = @AppointmentDate, Status = @Status, Notes = @Notes WHERE AppointmentID = @AppointmentID", connection)
            command.Parameters.AddWithValue("@AppointmentID", CInt(txtAppointmentID.Text))
            command.Parameters.AddWithValue("@DoctorID", CInt(txtDoctorID.Text))
            command.Parameters.AddWithValue("@AppointmentDate", dtpAppointmentDate.Value)
            command.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString())


            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Appointment updated successfully!")
            Else
                MessageBox.Show("Appointment not found.")
            End If
        End Using
    End Sub


    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Using connection As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
            Dim command As New SqlCommand("DELETE FROM Appointments WHERE AppointmentID = @AppointmentID", connection)
            command.Parameters.AddWithValue("@AppointmentID", CInt(txtAppointmentID.Text))

            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Appointment deleted successfully!")
            Else
                MessageBox.Show("Appointment not found.")
            End If
        End Using
    End Sub

    Private Sub AppointmentsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadAppointments()
    End Sub
    Private Sub LoadAppointments()
        Using connection As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
            Dim command As New SqlCommand("SELECT * FROM Appointments", connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            connection.Open()
            adapter.Fill(table)
            dgvAppointments.DataSource = table
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class