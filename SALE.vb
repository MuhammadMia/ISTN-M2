﻿Public Class SALE
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As NEW_SALE
        form = New NEW_SALE
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub
End Class