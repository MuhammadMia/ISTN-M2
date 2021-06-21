Public Class EMPLOYEES
    Private Sub EMPLOYEES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblEmployees' table. You can move, or remove it, as needed.
        Me.TblEmployeesTableAdapter.Fill(Me.SkyliteDB.tblEmployees)
        'TODO: This line of code loads data into the 'Group26DataSet6.EMPLOYEES' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedEmp As String = tblEmployees.SelectedCells(0).Value
        Dim empTable As DataTable = SkyliteDB.tblEmployees

        For Each row As DataRow In empTable.Rows
            If row.ItemArray(0) = selectedEmp Then
                empTable.Rows.Remove(row)
                Exit For
            End If
        Next

        SkyliteDB.AcceptChanges()

        TblEmployeesTableAdapter.Update(empTable)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fname As String = txbFName.Text
        Dim lname As String = txbLName.Text
        Dim empID As String = txbEmpID.Text
        Dim email As String = txbEmail.Text
        Dim password As String = txbPass.Text
        Dim position As String = txbPosition.Text
        Dim cell As String = txbCell.Text

        Dim row As DataRow = SkyliteDB.tblEmployees.NewRow()

        Dim fullname As String = fname + " " + lname

        row("Employee_ID") = empID
        row("Employee_Name") = fullname
        row("Employee_Email") = email
        row("Employee_Telephone") = cell
        row("Employee_Password") = password
        row("Employee_Position") = position

        SkyliteDB.tblEmployees.Rows.Add(row)
        SkyliteDB.AcceptChanges()
    End Sub

    Private Sub txbLName_TextChanged(sender As Object, e As EventArgs) Handles txbLName.TextChanged

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class