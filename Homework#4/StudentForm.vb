Public Class StudentForm
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HW3_Project_SolutionDataSet1.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter1.Fill(Me.HW3_Project_SolutionDataSet1.Student)
    End Sub

    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HW3_Project_SolutionDataSet)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If StudentRB.Checked() Then
            StudentSearchForm.Show()
        End If
        Me.Hide()
    End Sub
End Class