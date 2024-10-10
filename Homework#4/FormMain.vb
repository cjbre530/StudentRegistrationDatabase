Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If AssignRB.Checked() Then
            AssignForm.Show()
        ElseIf CourseRB.Checked() Then
            CourseForm.Show()
        ElseIf InstructorRB.Checked() Then
            InstructorForm.Show()
        ElseIf PeriodRB.Checked() Then
            PeriodForm.Show()
        ElseIf RegisterRB.Checked() Then
            RegisterForm.Show()
        ElseIf RoomRB.Checked() Then
            RoomForm.Show()
        ElseIf StudentRB.Checked() Then
            StudentForm.Show()
        End If
        Me.Hide()
    End Sub
End Class
