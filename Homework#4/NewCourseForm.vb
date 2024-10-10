Public Class NewCourseForm
    Private Sub NewCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HW3_Project_SolutionDataSet1.P5a_New_Course' table. You can move, or remove it, as needed.
        Me.P5a_New_CourseTableAdapter1.Fill(Me.HW3_Project_SolutionDataSet1.P5a_New_Course)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        CourseForm.Show()
    End Sub
End Class