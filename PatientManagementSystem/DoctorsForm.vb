Imports System.Data.SqlClient

Public Class DoctorsForm
    ' Database connection strings
    Dim adapter As New SqlDataAdapter()
    Dim connection As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
    Dim cmd As New SqlCommand("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")

    ' Event handler for BtnUpdate click
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Using connection As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
            Dim command As New SqlCommand("UPDATE Doctors SET DoctorName = @DoctorName, Specialty = @Specialty, Contact = @Contact WHERE DoctorID = @DoctorID", connection)
            command.Parameters.AddWithValue("@DoctorID", CInt(txtDoctorID.Text))
            command.Parameters.AddWithValue("@DoctorName", txtDoctorName.Text)
            command.Parameters.AddWithValue("@Specialty", txtSpecialty.Text)
            command.Parameters.AddWithValue("@Contact", txtContact.Text)

            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Doctor updated successfully!")
                LoadDoctors() ' Refresh the DataGridView
            Else
                MessageBox.Show("Doctor not found.")
            End If
        End Using
    End Sub

    ' Event handler for Form Load
    Private Sub DoctorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDoctors()
    End Sub
    Private Sub LoadDoctors()
        Using connection As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
            Dim command As New SqlCommand("SELECT * FROM Doctors", connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            connection.Open()
            adapter.Fill(table)
            dgvDoctors.DataSource = table
        End Using

    End Sub

    ' Event handler for BtnDelete click
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Using connection As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
            Dim command As New SqlCommand("DELETE FROM Doctors WHERE DoctorID = @DoctorID", connection)
            command.Parameters.AddWithValue("@DoctorID", CInt(txtDoctorID.Text))

            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Doctor deleted successfully!")
                LoadDoctors() ' Refresh the DataGridView
            Else
                MessageBox.Show("Doctor not found.")
            End If
        End Using
    End Sub

    ' Event handler for BtnAdd click
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using connection As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
            Dim command As New SqlCommand("INSERT INTO Doctors (DoctorName, Specialty, Contact) VALUES (@DoctorName, @Specialty, @Contact)", connection)
            command.Parameters.AddWithValue("@DoctorName", txtDoctorName.Text)
            command.Parameters.AddWithValue("@Specialty", txtSpecialty.Text)
            command.Parameters.AddWithValue("@Contact", txtContact.Text)

            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Doctor added successfully!")
            LoadDoctors() ' Refresh the DataGridView
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class