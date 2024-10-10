Public Class PeriodForm
    Private Sub PeriodForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HW3_Project_SolutionDataSet1.Period' table. You can move, or remove it, as needed.
        Me.PeriodTableAdapter1.Fill(Me.HW3_Project_SolutionDataSet1.Period)
    End Sub

    Private Sub PeriodBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PeriodBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PeriodBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HW3_Project_SolutionDataSet)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) 

    End Sub
End Class