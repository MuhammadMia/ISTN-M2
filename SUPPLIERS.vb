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

    Private Sub tblSuppliers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblSuppliers.CellContentClick
        Dim selectedProduct As String = tblSuppliers.SelectedCells(0).Value

        Dim rowNum As Int16 = tblSuppliers.CurrentCell.RowIndex


        txbSuppID.Text = tblSuppliers.Rows(rowNum).Cells(0).Value
        txbSuppName.Text = tblSuppliers.Rows(rowNum).Cells(1).Value
        txbEmail.Text = tblSuppliers.Rows(rowNum).Cells(2).Value
        txbPhone.Text = tblSuppliers.Rows(rowNum).Cells(3).Value
        txbAddress.Text = tblSuppliers.Rows(rowNum).Cells(4).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rowNum As Int16 = tblSuppliers.CurrentCell.RowIndex

        SkyliteDB.tblSuplliers.Rows(rowNum)("Supplier_ID") = txbSuppID.Text
        SkyliteDB.tblSuplliers.Rows(rowNum)("Supplier_Name") = txbSuppName.Text
        SkyliteDB.tblSuplliers.Rows(rowNum)("Supplier_Email") = txbEmail.Text
        SkyliteDB.tblSuplliers.Rows(rowNum)("Supplier_Telephone") = txbPhone.Text
        SkyliteDB.tblSuplliers.Rows(rowNum)("Supplier_Address") = txbAddress.Text

        SkyliteDB.AcceptChanges()
        TblSuplliersTableAdapter.Update(SkyliteDB.tblSuplliers)
    End Sub
End Class