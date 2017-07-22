Public Class Form1



    Private Sub TextBox_SearchByFirstName_TextChanged(sender As Object, e As EventArgs) Handles TextBox_SearchByFirstName.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRDataTableDataSet.view_ListBox_Employee' table. You can move, or remove it, as needed.
        Me.View_ListBox_EmployeeTableAdapter.Fill(Me.HRDataTableDataSet.view_ListBox_Employee)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.View_ListBox_EmployeeTableAdapter.FillBy(Me.HRDataTableDataSet.view_ListBox_Employee)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
