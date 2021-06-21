Public Class CONTRACTS
    Private Sub CONTRACTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblContracts' table. You can move, or remove it, as needed.
        Me.TblContractsTableAdapter.Fill(Me.SkyliteDB.tblContracts)
        'TODO: This line of code loads data into the 'Group26DataSet.CONTRACTS' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Group26Contracts.CONTRACTS' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedSupp As String = DataGridView1.SelectedCells(0).Value
        Dim suppTable As DataTable = SkyliteDB.tblContracts

        For Each row As DataRow In suppTable.Rows
            If row.ItemArray(0) = selectedSupp Then
                suppTable.Rows.Remove(row)
                Exit For
            End If
        Next

        SkyliteDB.AcceptChanges()

        TblContractsTableAdapter.Update(suppTable)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim productTable As DataTable = SkyliteDB.tblContracts
        Dim resultTable As DataTable = SkyliteDB.tblContracts
        resultTable.Clear()

        For Each row As DataRow In resultTable.Rows
            If row.Field(Of String)("Product_Name").Contains(TextBox1.Text) Then
                resultTable.Rows.Add(row)
            End If
        Next

    End Sub
End Class