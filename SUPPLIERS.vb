Public Class SUPPLIERS
    Private Sub SUPPLIERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group26DataSet2.SUPPLIERS' table. You can move, or remove it, as needed.
        Me.SUPPLIERSTableAdapter.Fill(Me.Group26DataSet2.SUPPLIERS)

    End Sub
End Class