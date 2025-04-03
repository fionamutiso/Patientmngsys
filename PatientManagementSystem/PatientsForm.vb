Imports System.Data.SqlClient
Public Class frmPatients
    Dim con As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")

    Private Sub PatientAdd_Click(sender As Object, e As EventArgs) Handles PatientAdd.Click
        Dim name As String = txtName.Text
        Dim dob As Date = dtpDOB.Value
        Dim contact As String = txtContact.Text
        Dim gender As String = cmbGender.SelectedItem.ToString()

        Dim query As String = "INSERT INTO Patients (Name, DOB, Contact, Gender) VALUES (@Name, @DOB, @Contact, @Gender)"
        Dim cmd As New SqlCommand(query, con)

        cmd.Parameters.AddWithValue("@Name", name)
        cmd.Parameters.AddWithValue("@DOB", dob)
        cmd.Parameters.AddWithValue("@Contact", contact)
        cmd.Parameters.AddWithValue("@Gender", gender)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Patient Added Successfully!")
            LoadPatients() ' Refresh DataGridView
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub frmPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()
    End Sub

    Private Sub LoadPatients()
        Dim query As String = "SELECT * FROM Patients"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim table As New DataTable()

        Try
            con.Open()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("PatientID").Value)

            Dim query As String = "DELETE FROM Patients WHERE PatientID = @PatientID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@PatientID", selectedID)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Patient Deleted Successfully!")
                LoadPatients() ' Refresh DataGridView
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("Please select a patient to delete.")
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("PatientID").Value)

            Dim name As String = txtName.Text
            Dim dob As Date = dtpDOB.Value
            Dim contact As String = txtContact.Text
            Dim gender As String = cmbGender.SelectedItem.ToString()

            Dim query As String = "UPDATE Patients SET Name=@Name, DOB=@DOB, Contact=@Contact, Gender=@Gender WHERE PatientID=@PatientID"
            Dim cmd As New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@Name", name)
            cmd.Parameters.AddWithValue("@DOB", dob)
            cmd.Parameters.AddWithValue("@Contact", contact)
            cmd.Parameters.AddWithValue("@Gender", gender)
            cmd.Parameters.AddWithValue("@PatientID", selectedID)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Patient Updated Successfully!")
                LoadPatients() ' Refresh DataGridView
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("Please select a patient to update.")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class