Public Class PRODUCTS
    Private Sub PRODUCTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group26DataSet1.PRODUCTS' table. You can move, or remove it, as needed.
        Me.PRODUCTSTableAdapter.Fill(Me.Group26DataSet1.PRODUCTS)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class