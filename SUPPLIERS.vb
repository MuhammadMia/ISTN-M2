Public Class SUPPLIERS
    Private Sub SUPPLIERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblSuplliers' table. You can move, or remove it, as needed.
        Me.TblSuplliersTableAdapter.Fill(Me.SkyliteDB.tblSuplliers)
        'TODO: This line of code loads data into the 'Group26DataSet2.SUPPLIERS' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedSupp As String = tblSuppliers.SelectedCells(0).Value
        Dim suppTable As DataTable = SkyliteDB.tblSuplliers

        For Each row As DataRow In suppTable.Rows
            If row.ItemArray(0) = selectedSupp Then
                suppTable.Rows.Remove(row)
                Exit For
            End If
        Next

        SkyliteDB.AcceptChanges()

        TblSuplliersTableAdapter.Update(suppTable)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = txbSuppName.Text
        Dim suppID As String = txbSuppID.Text
        Dim email As String = txbEmail.Text
        Dim phone As String = txbPhone.Text
        Dim address As String = txbAddress.Text

        Dim row As DataRow = SkyliteDB.tblSuplliers.NewRow()

        row("Supplier_ID") = suppID
        row("Supplier_Name") = name
        row("Supplier_Email") = email
        row("Supplier_Telephone") = phone
        row("Supplier_Address") = address

        SkyliteDB.tblSuplliers.Rows.Add(row)
        SkyliteDB.AcceptChanges()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class