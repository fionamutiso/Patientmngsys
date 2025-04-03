Imports System.Data.SqlClient
Public Class DoctorsForm
    Dim con As New SqlConnection("Server=HP-ZBOOK\SQLEXPRESS; Database=Patientmngsys; Integrated Security=True;")


    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        Try
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Doctors (DoctorName, Specialty, Contact) VALUES (@name, @specialty, @contact)", con)
            cmd.Parameters.AddWithValue("@name", txtDoctorName.Text)
            cmd.Parameters.AddWithValue("@specialty", txtSpecialty.Text)
            cmd.Parameters.AddWithValue("@contact", txtContact.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Doctor Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DoctorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class