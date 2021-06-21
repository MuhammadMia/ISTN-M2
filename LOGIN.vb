Public Class LOGIN
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim uname As String = txbEmployeeNum.Text
        Dim pass As String = txbPassword.Text

        Dim empTable As DataTable = SkyliteDB.tblEmployees

        Dim userIndex As Int16

        For Each row As DataRow In empTable.Rows
            If row.ItemArray(0) = uname Then
                Exit For
            End If
            userIndex = userIndex + 1
        Next

        If empTable.Rows(userIndex)("Employee_Password") = pass Then
            Me.Close()
        Else
            MessageBox.Show("Incorrect Username / Password Combination!")
        End If



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class