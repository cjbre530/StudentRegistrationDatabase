Public Class CourseSummaryForm
    Private Sub CourseSummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HW3_Project_SolutionDataSet1.P4_Course_Summary' table. You can move, or remove it, as needed.
        Me.P4_Course_SummaryTableAdapter1.Fill(Me.HW3_Project_SolutionDataSet1.P4_Course_Summary)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        CourseForm.Show()
    End Sub
End Class