Public Class CourseForm
    Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HW3_Project_SolutionDataSet.Course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter1.Fill(Me.HW3_Project_SolutionDataSet1.Course)

    End Sub

    Private Sub CourseBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CourseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CourseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HW3_Project_SolutionDataSet)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If SearchRB.Checked() Then
            ScheduleSearchForm.Show()
        ElseIf SummaryRB.Checked() Then
            CourseSummaryForm.Show()
        ElseIf NewRB.Checked() Then
            NewCourseForm.Show()
        ElseIf CourseLevelRB.Checked Then
            CourseLevelForm.Show()
        End If
        Me.Hide()
    End Sub
End Class