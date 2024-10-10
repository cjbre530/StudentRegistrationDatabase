Public Class InstructorForm
    Private Sub InstructorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HW3_Project_SolutionDataSet1.Instructor' table. You can move, or remove it, as needed.
        Me.InstructorTableAdapter1.Fill(Me.HW3_Project_SolutionDataSet1.Instructor)


    End Sub

    Private Sub InstructorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InstructorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InstructorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HW3_Project_SolutionDataSet)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If InstructorRB.Checked() Then
            InstructorSearchForm.Show()
        End If
        Me.Hide()
    End Sub
End Class