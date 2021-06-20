Public Class SKYLITE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SALE.Click
        Dim form As SALE
        form = New SALE
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form As PRODUCTS
        form = New PRODUCTS
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form As APPOINTMENTS
        form = New APPOINTMENTS
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As CLIENTS
        form = New CLIENTS
        Me.Hide()
        form.ShowDialog()
        Me.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim form As CONTRACTS
        form = New CONTRACTS
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form As SUPPLIERS
        form = New SUPPLIERS
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As EMPLOYEES
        form = New EMPLOYEES
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub
End Class
