Imports System.Data.SqlClient
Public Class frmPatients
    Dim dtPatients As New DataTable()
    Dim adapter As SqlDataAdapter
    Dim connection As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
    Dim con As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")

    Private Sub PatientAdd_Click(sender As Object, e As EventArgs) Handles PatientAdd.Click
        Dim newRow As DataRow = dtPatients.NewRow()
        newRow("PatientID") = txtID.Text
        newRow("PatientName") = txtName.Text
        newRow("DateOfBirth") = dtpDOB.Value
        newRow("Contact") = txtContact.Text
        newRow("Gender") = cmbGender.SelectedItem.ToString()
        newRow("Address") = txtAddress.Text
        dtPatients.Rows.Add(newRow)

        ' Save changes to database
        adapter.Update(dtPatients)

        ' Refresh DataGridView
        DataGridView1.Refresh()
    End Sub


    Private Sub frmPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()
    End Sub

    Private Sub LoadPatients()
        Dim query As String = "SELECT * FROM Patients"
        adapter = New SqlDataAdapter(query, connection)
        Dim commandBuilder As New SqlCommandBuilder(adapter)

        dtPatients.Clear()
        adapter.Fill(dtPatients)

        ' Bind the DataTable to the DataGridView
        DataGridView1.DataSource = dtPatients
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index
            dtPatients.Rows(rowIndex).Delete()

            ' Save changes to database
            adapter.Update(dtPatients)

            ' Refresh DataGridView
            DataGridView1.Refresh()
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index
            dtPatients.Rows(rowIndex)("PatientID") = txtID.Text
            dtPatients.Rows(rowIndex)("PatientName") = txtName.Text
            dtPatients.Rows(rowIndex)("DateOfBirth") = dtpDOB.Value
            dtPatients.Rows(rowIndex)("Contact") = txtContact.Text
            dtPatients.Rows(rowIndex)("Gender") = cmbGender.SelectedItem.ToString()
            dtPatients.Rows(rowIndex)("Address") = txtAddress.Text

            ' Save changes to database
            adapter.Update(dtPatients)

            ' Refresh DataGridView
            DataGridView1.Refresh()
        Else
            MessageBox.Show("Please select a row to update.")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class