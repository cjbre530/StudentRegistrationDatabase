Public Class AssignForm
    Private Sub AssignBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AssignBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AssignBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HW3_Project_SolutionDataSet)

    End Sub

    Private Sub AssignForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HW3_Project_SolutionDataSet.Course' table. You can move, or remove it, as needed.
        Me.AssignTableAdapter1.Fill(Me.HW3_Project_SolutionDataSet1.Assign)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        FormMain.Show()
    End Sub
    Private Sub AssignBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AssignBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AssignBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.HW3_Project_SolutionDataSet1)

    End Sub

    Private Sub AssignForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HW3_Project_SolutionDataSet1.Assign' table. You can move, or remove it, as needed.
        Me.AssignTableAdapter1.Fill(Me.HW3_Project_SolutionDataSet1.Assign)
    End Sub

    Private Sub BackB_Click(sender As Object, e As EventArgs) Handles BackB.Click
        Me.Hide()
        FormMain.Show()
    End Sub
End Class