Imports System.Data.SqlClient

Public Class DoctorsForm
    ' Database connection strings
    Dim adapter As New SqlDataAdapter()
    Dim connection As New SqlConnection("Server=your-server\SQLEXPRESS; DatabaseName=DoctorsDb; Integrated Security=True;")
    Dim cmd As New SqlCommand("Server=your-server\SQLEXPRESS; DatabaseName=DoctorsDb; Integrated Security=True;")

    ' Event handler for BtnUpdate click
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Update doctor details in database
        cmd.CommandText = "UPDATE Doctors SET "
        cmd.CommandText &= "DoctorName='" & txtDoctorName.Text & "', "
        cmd.CommandText &= "Specialty='" & cmbSpecialty.Text & "', "
        cmd.CommandText &= "Contact='" & txtContact.Text & "' "
        cmd.CommandText &= "WHERE DoctorID=" & txtDoctorID.Text

        ' Execute update operation
        adapter.UpdateCommand = cmd

        ' Refresh DataGridView
        doctorsDataGridView.Refresh()
    End Sub

    ' Event handler for Form Load
    Private Sub DoctorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load doctors data from database
        cmd.CommandText = "SELECT * FROM Doctors ORDER BY DoctorName"
        cmd.Connection = New SqlConnection("Server=your-server\SQLEXPRESS; DatabaseName=DoctorsDb;")

        ' Fill DataSet
        Dim dsDoctor As New DataSet()
        adapter.Fill(dsDoctor)

        ' Bind DataSet to DataGridView
        doctorsDataGridView.DataSource = dsDoctor
    End Sub

    Private Function GetDataGridView1() As DataGridView
        Return doctorsDataGridView
    End Function

    ' Event handler for DataGridView cell click

    ' Event handler for DataGridView cell click - Use CellClick instead of Click
    Private Sub doctorsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles doctorsDataGridView.CellClick
        If doctorsDataGridView.SelectedRows.Count > 0 Then
            Dim index As Integer = doctorsDataGridView.CurrentRow.Index
            txtDoctorID.Text = doctorsDataGridView.Rows(index).Cells("DoctorID").Value.ToString()
            txtDoctorName.Text = doctorsDataGridView.Rows(index).Cells("DoctorName").Value.ToString()
            cmbSpecialty.Text = doctorsDataGridView.Rows(index).Cells("Specialty").Value.ToString()
            txtContact.Text = doctorsDataGridView.Rows(index).Cells("Contact").Value.ToString()

            ' Update button enabled
            adapter.UpdateCommand = cmd

            ' Refresh DataGridView
            doctorsDataGridView.Refresh()
        Else
            MessageBox.Show("Please select a row to update.")
        End If
    End Sub

    ' Event handler for BtnDelete click
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If doctorsDataGridView.SelectedRows.Count > 0 Then
            Dim index As Integer = doctorsDataGridView.CurrentRow.Index
            cmd.CommandText = "DELETE FROM Doctors WHERE DoctorID=" & doctorsDataGridView.Rows(index).Cells("DoctorID").Value.ToString()
            cmd.Connection = connection

            ' Execute delete operation
            adapter.DeleteCommand = cmd

            Try
                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()

                ' Refresh DataGridView
                doctorsDataGridView.Refresh()

                ' Clear text fields
                txtDoctorID.Clear()
                txtDoctorName.Clear()
                cmbSpecialty.Text = ""
                txtContact.Clear()

                MessageBox.Show("Doctor record deleted successfully.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    ' Event handler for BtnAdd click
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        cmd.CommandText = "INSERT INTO Doctors (DoctorName, Specialty, Contact) VALUES ("
        cmd.CommandText &= "'" & txtDoctorName.Text & "', "
        cmd.CommandText &= "'" & cmbSpecialty.Text & "', "
        cmd.CommandText &= "'" & txtContact.Text & "')"

        cmd.Connection = connection

        ' Execute insert operation
        adapter.InsertCommand = cmd
        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

        ' Refresh DataGridView
        doctorsDataGridView.Refresh()

        MessageBox.Show("New doctor added successfully.")
    End Sub
End Class