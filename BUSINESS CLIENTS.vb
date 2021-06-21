Public Class BUSINESS_CLIENTS
    Private Sub BUSINESS_CLIENTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblClientsBusiness' table. You can move, or remove it, as needed.
        Me.TblClientsBusinessTableAdapter.Fill(Me.SkyliteDB.tblClientsBusiness)
        'TODO: This line of code loads data into the 'Group26DataSet4.BUSINESS_CLIENTS' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedClient As String = tblBusClients.SelectedCells(0).Value
        Dim businessTable As DataTable = SkyliteDB.tblClientsBusiness
        For Each row As DataRow In businessTable.Rows
            If row.ItemArray(0) = selectedClient Then
                businessTable.Rows.Remove(row)
                Exit For
            End If
        Next

        SkyliteDB.AcceptChanges()

        TblClientsBusinessTableAdapter.Update(businessTable)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim clientID As String = txbClientID.Text
        Dim salesID As String = txbSalesPersonID.Text
        Dim bname As String = txbBName.Text
        Dim phone As String = txbPhone.Text
        Dim email As String = txbEmail.Text
        Dim address As String = txbAddress.Text

        Dim row As DataRow = SkyliteDB.tblClientsBusiness.NewRow()


        row("Client_ID") = clientID
        row("Employee_ID") = salesID
        row("Business_Name") = bname
        row("Business_Email") = email
        row("Business_Telephone") = phone
        row("Business_Address") = address


        SkyliteDB.tblClientsBusiness.Rows.Add(row)
        SkyliteDB.AcceptChanges()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class