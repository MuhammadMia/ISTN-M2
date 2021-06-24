Public Class NEW_SALE
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub NEW_SALE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.SkyliteDB.tblProducts)

        tblCart.DataSource = SkyliteDB.tblProducts
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProducts.CellContentClick

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click



    End Sub

    Private Sub txbSearch_TextChanged(sender As Object, e As EventArgs) Handles txbSearch.TextChanged
        Dim productTable As DataTable = SkyliteDB.tblProducts
        Dim resultTable As DataTable = SkyliteDB.tblProducts
        resultTable.Clear()

        If txbSearch.Text = Nothing Then
            Me.tblProducts.DataSource = Nothing
            Me.tblProducts.DataSource = SkyliteDB.tblProducts
            Me.TblProductsTableAdapter.Fill(SkyliteDB.tblProducts)
        Else
            For Each row As DataRow In productTable.Rows
                If row.Field(Of String)("Product_Name").Contains(txbSearch.Text) Then
                    resultTable.Rows.Add(row)
                End If
            Next

            Me.tblProducts.DataSource = Nothing
            Me.tblProducts.DataSource = resultTable
            Me.TblProductsTableAdapter.Fill(resultTable)
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txbContractLength_TextChanged(sender As Object, e As EventArgs) Handles txbContractLength.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

    End Sub
End Class