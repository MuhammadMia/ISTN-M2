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

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProducts.CellContentClick

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        Dim productsTable As DataTable
        productsTable = SkyliteDB.tblProducts

        Dim selectedProduct As DataRow
        selectedProduct = productsTable.NewRow()
        'selectedProduct = tblProducts.SelectedRows()

        selectedProduct("Product_ID") = "123"

    End Sub

    Private Sub txbSearch_TextChanged(sender As Object, e As EventArgs) Handles txbSearch.TextChanged
        Dim resultTable As DataTable
        resultTable = SkyliteDB.tblProducts
        resultTable.Rows.Clear()

        For Each row As DataRow In SkyliteDB.tblProducts.Rows
            If row.Field(Of String)("Product_Name").Contains(txbSearch.Text) Then
                resultTable.Rows.Add(row)
            End If
        Next

        If txbSearch.Text = "" Then
            tblProducts.DataSource = SkyliteDB.tblProducts
        End If

        tblProducts.DataSource = resultTable
    End Sub
End Class