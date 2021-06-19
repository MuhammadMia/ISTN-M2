Public Class EMPLOYEES
    Private Sub EMPLOYEES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group26DataSet6.EMPLOYEES' table. You can move, or remove it, as needed.
        Me.EMPLOYEESTableAdapter.Fill(Me.Group26DataSet6.EMPLOYEES)

    End Sub
End Class