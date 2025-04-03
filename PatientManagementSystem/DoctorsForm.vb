Public Class DoctorsForm

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Try
            If txtDoctorName.Text = "" Or txtSpecialty.Text = "" Or txtContact.Text = "" Then
                MessageBox.Show("Please enter all details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class