Public Class CONTRACTS
    Private Sub CONTRACTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group26DataSet.CONTRACTS' table. You can move, or remove it, as needed.
        Me.CONTRACTSTableAdapter1.Fill(Me.Group26DataSet.CONTRACTS)
        'TODO: This line of code loads data into the 'Group26Contracts.CONTRACTS' table. You can move, or remove it, as needed.
        Me.CONTRACTSTableAdapter.Fill(Me.Group26Contracts.CONTRACTS)

    End Sub
End Class