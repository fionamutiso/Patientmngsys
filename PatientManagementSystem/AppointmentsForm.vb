Imports System.Data.SqlClient

Public Class AppointmentsForm
    Dim dtAppointments As New DataTable()
    Dim adapter As SqlDataAdapter
    Dim connection As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
    Dim con As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")
    Dim txtAppointmentID As New TextBox()
    Dim txtPatientId As New TextBox()
    Dim txtDoctorName As New TextBox()
    Dim dtpAppointmentDate As New DateTimePicker()
    Dim DataGridView1 As New DataGridView()

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim newRow As DataRow = dtAppointments.NewRow()
        newRow("AppointmentID") = txtAppointmentID.Text
        newRow("PatientID") = txtPatientID.Text
        newRow("DoctorName") = txtDoctorName.Text
        newRow("AppointmentDate") = dtpAppointmentDate.Value
        dtAppointments.Rows.Add(newRow)

        ' Save changes to database
        adapter.Update(dtAppointments)

        ' Refresh DataGridView
        DataGridView1.Refresh()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index
            dtAppointments.Rows(rowIndex)("PatientName") = txtPatientName.Text
            dtAppointments.Rows(rowIndex)("DoctorName") = txtDoctorName.Text
            dtAppointments.Rows(rowIndex)("AppointmentDate") = dtpAppointmentDate.Value

            ' Save changes
            adapter.Update(dtAppointments)

            ' Refresh DataGridView
            DataGridView1.Refresh()
        Else
            MessageBox.Show("Please select a row to update.")
        End If
    End Sub


    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index
            dtAppointments.Rows(rowIndex).Delete()

            ' Save changes
            adapter.Update(dtAppointments)

            ' Refresh DataGridView
            DataGridView1.Refresh()
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub AppointmentsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadAppointments()
    End Sub
    Private Sub LoadAppointments()
        Dim query As String = "SELECT * FROM Appointments"
        adapter = New SqlDataAdapter(query, connection)
        Dim commandBuilder As New SqlCommandBuilder(adapter)

        dtAppointments.Clear()
        adapter.Fill(dtAppointments)

        ' Bind the DataTable to the DataGridView
        DataGridView1.DataSource = dtAppointments
    End Sub
End Class