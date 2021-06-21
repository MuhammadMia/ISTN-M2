Public Class LOGIN
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim uname As String = txbEmployeeNum.Text
        Dim pass As String = txbPassword.Text

        'Hash pword
        Dim hashedPass As String
        hashedPass = pass.GetHashCode()

        'Check if uname is in employees database
        'Check if hashed pword is same as employee password in database


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class