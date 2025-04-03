Public Class MainMenu

    Private Sub btnPatients_Click(sender As System.Object, e As System.EventArgs) Handles btnPatients.Click
        Dim patients As New PatientsForm
        patientsForm.Show()
    End Sub

    Private Sub btnAppointments_Click(sender As System.Object, e As System.EventArgs) Handles btnAppointments.Click
        Dim ppointments As New AppointmentsForm
        AppointmentsForm.Show()
    End Sub

    Private Sub btnDoctors_Click(sender As System.Object, e As System.EventArgs) Handles btnDoctors.Click
        Dim doctors As New DoctorsForm
        doctorsForm.Show()
    End Sub

    Private Sub btnBilling_Click(sender As System.Object, e As System.EventArgs) Handles btnBilling.Click
        Dim billing As New BillingForm
        billingForm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As System.Object, e As System.EventArgs) Handles btnLogout.Click
        Me.Hide()
        Dim login As New LoginForm
        loginForm.Show()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class