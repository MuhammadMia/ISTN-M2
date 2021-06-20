Public Class NEW_SALE
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub NEW_SALE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.SkyliteDB.tblProducts)

        tblCart.DataSource = SkyliteDB.tblProducts
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProducts.CellContentClick

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        Dim productsTable As DataTable = SkyliteDB.tblProducts

        Dim selectedProducts As DataGridViewRow

        selectedProducts = tblProducts.CurrentRow()

        Dim cart As DataTable = SkyliteDB.tblSaleItems
        cart.Rows.Clear()

        cart.Rows.Add(selectedProducts)

        tblCart.Rows.Add(selectedProducts)


    End Sub

    Private Sub txbSearch_TextChanged(sender As Object, e As EventArgs) Handles txbSearch.TextChanged
        Dim productTable As DataTable = SkyliteDB.tblProducts
        Dim resultTable As DataTable = SkyliteDB.tblProducts
        resultTable.Clear()

        For Each row As DataRow In resultTable.Rows
            If row.Field(Of String)("Product_Name").Contains(txbSearch.Text) Then
                resultTable.Rows.Add(row)
            End If
        Next

    End Sub
End Class