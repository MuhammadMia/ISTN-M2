Public Class VIEW_SALES
    Private Sub VIEW_SALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblSales' table. You can move, or remove it, as needed.
        Me.TblSalesTableAdapter.Fill(Me.SkyliteDB.tblSales)
        'TODO: This line of code loads data into the 'Group26DataSet3.SALES' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedSupp As String = DataGridView1.SelectedCells(0).Value
        Dim suppTable As DataTable = SkyliteDB.tblSales

        For Each row As DataRow In suppTable.Rows
            If row.ItemArray(0) = selectedSupp Then
                suppTable.Rows.Remove(row)
                Exit For
            End If
        Next

        SkyliteDB.AcceptChanges()

        TblSalesTableAdapter.Update(suppTable)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim productTable As DataTable = SkyliteDB.tblSales
        Dim resultTable As DataTable = SkyliteDB.tblSales
        resultTable.Clear()

        For Each row As DataRow In resultTable.Rows
            If row.Field(Of String)("Product_Name").Contains(TextBox1.Text) Then
                resultTable.Rows.Add(row)
            End If
        Next

    End Sub
End Class