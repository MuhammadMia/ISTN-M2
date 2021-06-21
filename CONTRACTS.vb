Public Class CONTRACTS
    Private Sub CONTRACTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblContracts' table. You can move, or remove it, as needed.
        Me.TblContractsTableAdapter.Fill(Me.SkyliteDB.tblContracts)
        'TODO: This line of code loads data into the 'Group26DataSet.CONTRACTS' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Group26Contracts.CONTRACTS' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub
End Class