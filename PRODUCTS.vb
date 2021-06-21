Public Class PRODUCTS
    Private Sub PRODUCTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.SkyliteDB.tblProducts)


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub tblProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProducts.CellContentClick
        Dim selectedProduct As String = tblProducts.SelectedCells(0).Value

        lblSelectedProduct.Text = selectedProduct
    End Sub

    Private Sub btnRemoveProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveProduct.Click
        Dim selectedProduct As String = tblProducts.SelectedCells(0).Value
        Dim productsTable As DataTable = SkyliteDB.tblProducts

        For Each row As DataRow In productsTable.Rows
            If row.ItemArray(0) = selectedProduct Then
                productsTable.Rows.Remove(row)
                Exit For
            End If
        Next

        SkyliteDB.AcceptChanges()

        TblProductsTableAdapter.Update(productsTable)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prodID As String
        Dim suppID As String = txbSuppID.Text
        Dim prodName As String = txbProdName.Text
        Dim manufacturer As String = txbManufacturer.Text
        Dim color As String = txbColor.Text
        Dim cost As String = txbCost.Text
        Dim sale As String = txbPrice.Text
        Dim stock As Integer = txbQuantity.Text

        Dim row As DataRow = SkyliteDB.tblProducts.NewRow()

        prodID = "P00000000" + (SkyliteDB.tblProducts.Rows.Count + 1).ToString()

        row("Product_ID") = prodID
        row("Supplier_ID") = suppID
        row("Product_Name") = prodName
        row("Product_Description") = "lorem Ipsum"
        row("Manufacturer") = manufacturer
        row("Colour") = color
        row("Cost_Price") = cost
        row("Sale_Price") = sale
        row("Current_Stock") = stock

        SkyliteDB.tblProducts.Rows.Add(row)
        SkyliteDB.AcceptChanges()
    End Sub
End Class