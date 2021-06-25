Public Class VIEW_SALES
    Private Sub VIEW_SALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblSales' table. You can move, or remove it, as needed.
        Me.TblSalesTableAdapter.Fill(Me.SkyliteDB.tblSales)
        'TODO: This line of code loads data into the 'Group26DataSet3.SALES' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim selectedSale As String = tblSales.SelectedCells(0).Value

        Dim sql As String
        sql = "DELETE FROM tblEmployees WHERE Employee_ID = '" & selectedSale & "';"

        saveData(sql)

        Me.tblSales.DataSource = Nothing
        Me.tblSales.DataSource = SkyliteDB.tblSales
        Me.TblSalesTableAdapter.Fill(Me.SkyliteDB.tblSales)

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim productTable As DataTable = SkyliteDB.tblSales
        Dim resultTable As DataTable = SkyliteDB.tblSales
        resultTable.Clear()

        For Each row As DataRow In resultTable.Rows
            If row.Field(Of String)("Product_Name").Contains(TextBox1.Text) Then
                resultTable.Rows.Add(row)
            End If
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class