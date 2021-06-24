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
        Dim name As String = txbName.Text
        Dim empID As String = txbEmpID.Text
        Dim email As String = txbEmail.Text
        Dim password As String = txbPass.Text
        Dim position As String = txbPosition.Text
        Dim cell As String = txbCell.Text

        Dim row As DataRow = SkyliteDB.tblEmployees.NewRow()

        row("Employee_ID") = empID
        row("Employee_Name") = name
        row("Employee_Email") = email
        row("Employee_Telephone") = cell
        row("Employee_Password") = password
        row("Employee_Position") = position

        SkyliteDB.tblEmployees.Rows.Add(row)
        SkyliteDB.AcceptChanges()
    End Sub

    Private Sub txbLName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tblEmployees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblEmployees.CellContentClick
        Dim selectedProduct As String = tblEmployees.SelectedCells(0).Value

        Dim rowNum As Int16 = tblEmployees.CurrentCell.RowIndex


        txbEmpID.Text = tblEmployees.Rows(rowNum).Cells(0).Value
        txbName.Text = tblEmployees.Rows(rowNum).Cells(1).Value
        txbCell.Text = tblEmployees.Rows(rowNum).Cells(2).Value
        txbEmail.Text = tblEmployees.Rows(rowNum).Cells(3).Value
        txbPosition.Text = tblEmployees.Rows(rowNum).Cells(4).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rowNum As Int16 = tblEmployees.CurrentCell.RowIndex

        SkyliteDB.tblEmployees.Rows(rowNum)("Employee_ID") = txbEmpID.Text
        SkyliteDB.tblEmployees.Rows(rowNum)("Employee_Name") = txbName.Text
        SkyliteDB.tblEmployees.Rows(rowNum)("Employee_Email") = txbEmail.Text
        SkyliteDB.tblEmployees.Rows(rowNum)("Employee_Telephone") = txbCell.Text
        SkyliteDB.tblEmployees.Rows(rowNum)("Employee_Position") = txbPosition.Text
        SkyliteDB.tblEmployees.Rows(rowNum)("Employee_Password") = txbPass.Text

        SkyliteDB.AcceptChanges()
        TblEmployeesTableAdapter.Update(SkyliteDB.tblEmployees)
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class