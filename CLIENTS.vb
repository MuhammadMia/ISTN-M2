Public Class CLIENTS
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As INDIVIDUAL_CLIENTS
        form = New INDIVIDUAL_CLIENTS
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As BUSINESS_CLIENTS
        form = New BUSINESS_CLIENTS
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class