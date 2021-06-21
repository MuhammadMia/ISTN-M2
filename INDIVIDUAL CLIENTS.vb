Public Class INDIVIDUAL_CLIENTS
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub INDIVIDUAL_CLIENTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblClientsIndividual' table. You can move, or remove it, as needed.
        Me.TblClientsIndividualTableAdapter.Fill(Me.SkyliteDB.tblClientsIndividual)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedClient As String = tblIndClients.SelectedCells(0).Value
        Dim clientTable As DataTable = SkyliteDB.tblClientsIndividual

        For Each row As DataRow In clientTable.Rows
            If row.ItemArray(0) = selectedClient Then
                clientTable.Rows.Remove(row)
                Exit For
            End If
        Next

        SkyliteDB.AcceptChanges()

        TblClientsIndividualTableAdapter.Update(clientTable)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim clientID As String = txbClientID.Text
        Dim indID As String = txbIndID.Text
        Dim fname As String = txbFName.Text
        Dim lname As String = txbLName.Text
        Dim email As String = txbEmail.Text
        Dim cell As String = txbCell.Text

        Dim row As DataRow = SkyliteDB.tblClientsIndividual.NewRow()

        Dim fullname As String = fname + " " + lname

        row("Client_ID") = clientID
        row("Individual_ID") = indID
        row("Individual_Name") = fullname
        row("Individual_Email") = email
        row("Individual_Cell") = cell


        SkyliteDB.tblClientsIndividual.Rows.Add(row)
        SkyliteDB.AcceptChanges()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class