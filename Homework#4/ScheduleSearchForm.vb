Public Class ScheduleSearchForm
    Private Sub ScheduleSearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.P3_Course_ScheduleTableAdapter.Fill(Me.HW3_Project_SolutionDataSet.P3_Course_Schedule, CourseTitleToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        CourseForm.Show()
    End Sub
End Class