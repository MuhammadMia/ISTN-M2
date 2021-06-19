Public Class INDIVIDUAL_CLIENTS
    Private Sub INDIVIDUAL_CLIENTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group26DataSet5.INDIVIDUAL_CLIENTS' table. You can move, or remove it, as needed.
        Me.INDIVIDUAL_CLIENTSTableAdapter.Fill(Me.Group26DataSet5.INDIVIDUAL_CLIENTS)

    End Sub
End Class