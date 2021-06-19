Public Class VIEW_SALES
    Private Sub VIEW_SALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group26DataSet3.SALES' table. You can move, or remove it, as needed.
        Me.SALESTableAdapter.Fill(Me.Group26DataSet3.SALES)

    End Sub
End Class