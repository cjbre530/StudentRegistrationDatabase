Public Class RegisterForm
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HW3_Project_SolutionDataSet1.Register' table. You can move, or remove it, as needed.
        Me.RegisterTableAdapter1.Fill(Me.HW3_Project_SolutionDataSet1.Register)
    End Sub

    Private Sub RegisterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RegisterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegisterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HW3_Project_SolutionDataSet)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs)

    End Sub
End Class