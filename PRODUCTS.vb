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

        Dim rowNum As Int16 = tblProducts.CurrentCell.RowIndex


        txbProdName.Text = tblProducts.Rows(rowNum).Cells(2).Value
        txbSuppID.Text = tblProducts.Rows(rowNum).Cells(1).Value
        txbManufacturer.Text = tblProducts.Rows(rowNum).Cells(3).Value
        txbColor.Text = tblProducts.Rows(rowNum).Cells(4).Value
        txbCost.Text = tblProducts.Rows(rowNum).Cells(5).Value
        txbPrice.Text = tblProducts.Rows(rowNum).Cells(6).Value
        txbQuantity.Text = tblProducts.Rows(rowNum).Cells(7).Value

    End Sub

    Private Sub btnRemoveProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveProduct.Click
        Dim selectedProduct As String = tblProducts.SelectedCells(0).Value

        For Each row As DataRow In SkyliteDB.tblProducts.Rows
            If row.ItemArray(0) = selectedProduct Then
                SkyliteDB.tblProducts.Rows.Remove(row)
                Exit For
            End If
        Next

        SkyliteDB.AcceptChanges()

        TblProductsTableAdapter.Update(SkyliteDB.tblProducts)
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
        SkyliteDB.tblProducts.AcceptChanges()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rowNum As Int16 = tblProducts.CurrentCell.RowIndex

        SkyliteDB.tblProducts.Rows(rowNum)("Product_Name") = txbProdName.Text
        SkyliteDB.tblProducts.Rows(rowNum)("Supplier_ID") = txbSuppID.Text
        SkyliteDB.tblProducts.Rows(rowNum)("Product_Description") = "Lorum Ipsum"
        SkyliteDB.tblProducts.Rows(rowNum)("Manufacturer") = txbManufacturer.Text
        SkyliteDB.tblProducts.Rows(rowNum)("Colour") = txbColor.Text
        SkyliteDB.tblProducts.Rows(rowNum)("Cost_Price") = txbCost.Text
        SkyliteDB.tblProducts.Rows(rowNum)("Sale_Price") = txbPrice.Text
        SkyliteDB.tblProducts.Rows(rowNum)("Current_Stock") = txbQuantity.Text

        SkyliteDB.AcceptChanges()
        TblProductsTableAdapter.Update(SkyliteDB.tblProducts)

    End Sub
End Class