Public Class EMPLOYEES
    Private Sub EMPLOYEES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblEmployees' table. You can move, or remove it, as needed.
        Me.TblEmployeesTableAdapter.Fill(Me.SkyliteDB.tblEmployees)
        'TODO: This line of code loads data into the 'Group26DataSet6.EMPLOYEES' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim selectedEmp As String = tblEmployees.SelectedCells(0).Value

        Dim sql As String
        sql = "DELETE FROM tblEmployees WHERE Employee_ID = '" & selectedEmp & "';"

        saveData(sql)

        Me.tblEmployees.DataSource = Nothing
        Me.tblEmployees.DataSource = SkyliteDB.tblEmployees
        Me.TblEmployeesTableAdapter.Fill(Me.SkyliteDB.tblEmployees)

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

        Dim sql As String
        sql = "INSERT INTO tblEmployees (Employee_ID, Employee_Name, Employee_Email, Employee_Cell, Employee_Password, Employee_Position) VALUES ('" & empID & "','" & name & "','" & email & "','" & cell & "','" & password & "','" & position & "')"

        saveData(sql)

        Me.tblEmployees.DataSource = Nothing
        Me.tblEmployees.DataSource = SkyliteDB.tblEmployees
        Me.TblEmployeesTableAdapter.Fill(Me.SkyliteDB.tblEmployees)

    End Sub

    Private Sub saveData(sql As String)

        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=34.67.177.192;Initial Catalog=SkyliteDB;Persist Security Info=True;User ID=sqlserver;Password=istn")
        Dim cmd As System.Data.SqlClient.SqlCommand
        Dim result As Integer
        Try
            con.Open()
            cmd = New System.Data.SqlClient.SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then
                MsgBox("Data has been saved in the databse")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

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

        Dim name As String = txbName.Text
        Dim empID As String = txbEmpID.Text
        Dim email As String = txbEmail.Text
        Dim password As String = txbPass.Text
        Dim position As String = txbPosition.Text
        Dim cell As String = txbCell.Text

        Dim sql As String
        sql = "UPDATE tblEmployees SET Employee_Name = '" & name & "', Employee_ID = '" & empID & "', " & "Employee_Email = '" & email & "', " & "Employee_Cell = '" & cell & "', " & "Employee_Password = '" & password & "', " & "Employee_Position = '" & position & "' WHERE Employee_ID = '" & empID & "';"

        saveData(sql)

        Me.tblEmployees.DataSource = Nothing
        Me.tblEmployees.DataSource = SkyliteDB.tblEmployees
        Me.TblEmployeesTableAdapter.Fill(Me.SkyliteDB.tblEmployees)

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class