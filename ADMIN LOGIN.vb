Public Class ADMIN_LOGIN
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username As String = txbUser.Text
        Dim password As String = txbPass.Text

        If String.Compare(username, "admin") = 0 Then
            If String.Compare(password, "admin") = 0 Then
                Me.Close()
            Else
                MessageBox.Show("Incorrect Password!")
            End If
        Else
            MessageBox.Show("Incorrect Username!")
        End If
    End Sub
End Class