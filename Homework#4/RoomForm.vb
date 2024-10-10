Public Class RoomForm
    Private Sub RoomForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HW3_Project_SolutionDataSet1.Room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter1.Fill(Me.HW3_Project_SolutionDataSet1.Room)
    End Sub

    Private Sub RoomBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RoomBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RoomBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HW3_Project_SolutionDataSet)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If UnassRB.Checked() Then
            UnassignedForm.Show()
        End If
        Me.Hide()
    End Sub
End Class