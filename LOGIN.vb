Public Class LOGIN
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim uname As String = cmbUser.Text
        Dim pass As String = txbPassword.Text

        Dim empTable As DataTable = SkyliteDB.tblEmployees

        Dim userIndex As Int16 = 0

        For Each row As DataRow In empTable.Rows
            If uname = row.Field(Of String)("Employee_ID") Then
                Exit For
            Else
                userIndex = userIndex + 1
            End If

        Next

        If empTable.Rows(userIndex)("Employee_Password") = pass Then
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