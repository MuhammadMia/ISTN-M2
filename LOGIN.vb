Public Class LOGIN
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim uname As String = cmbUser.Text
        Dim pass As String = txbPassword.Text

        Dim empTable As DataTable = SkyliteDB.tblEmployees

        Dim userIndex As Int16 = 0

        For Each row As DataRow In empTable.Rows
            If String.Compare(uname, empTable.Rows(userIndex).ItemArray(0).ToString) = 0 Then
                Exit For
            Else
                userIndex += 1
            End If

        Next

        If userIndex >= empTable.Rows.Count Then
            MessageBox.Show("Incorrect Username / Password Combination!")
            Exit Sub
        End If

        Dim empPass As String = empTable.Rows(userIndex)("Employee_Password")

        If String.Compare(pass, empPass) = 0 Then
            Me.Close()
        Else
            MessageBox.Show("Incorrect Username / Password Combination!")
        End If



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblEmployees' table. You can move, or remove it, as needed.
        Me.TblEmployeesTableAdapter.Fill(Me.SkyliteDB.tblEmployees)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class