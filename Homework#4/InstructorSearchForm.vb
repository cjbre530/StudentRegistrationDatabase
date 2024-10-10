Public Class InstructorSearchForm
    Private Sub InstructorSearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        InstructorForm.Show()
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.P1_Professors_ScheduleTableAdapter.Fill(Me.HW3_Project_SolutionDataSet.P1_Professors_Schedule, NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class