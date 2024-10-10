Public Class StudentSearchForm
    Private Sub StudentSearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        StudentForm.Show()
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.P2_Students_ScheduleTableAdapter.Fill(Me.HW3_Project_SolutionDataSet.P2_Students_Schedule, StudentIDToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class