Public Class AppointmentsForm

    Private Sub btnSchedule_Click(sender As System.Object, e As System.EventArgs) Handles btnSchedule.Click
        Try
            ' Validate input fields
            If txtPatientName.Text = "" Or cmbDoctor.SelectedItem Is Nothing Then
                MessageBox.Show("Please enter all details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Get selected values
            Dim patientName As String = txtPatientName.Text
            Dim selectedDoctor As String = cmbDoctor.SelectedItem.ToString()
            Dim appointmentDate As String = dtpDate.Value.ToShortDateString()
            Dim appointmentTime As String = dtpTime.Value.ToShortTimeString()

            ' Show confirmation
            MessageBox.Show("Appointment Scheduled!" & vbCrLf &
                            "Patient: " & patientName & vbCrLf &
                            "Doctor: " & selectedDoctor & vbCrLf &
                            "Date: " & appointmentDate & vbCrLf &
                            "Time: " & appointmentTime, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub AppointmentsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDate.Format = DateTimePickerFormat.Short ' Only shows date
        dtpTime.Format = DateTimePickerFormat.Time ' Only shows time
        dtpTime.ShowUpDown = True ' Makes it easier to select time

        ' Populate ComboBox with available doctors
        cmbDoctor.Items.Clear()
        cmbDoctor.Items.Add("Dr. Wekesa")
        cmbDoctor.Items.Add("Dr. Kalovoto")
        cmbDoctor.Items.Add("Dr. Koech")
        cmbDoctor.Items.Add("Dr. Njoroge")
    End Sub
End Class