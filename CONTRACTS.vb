Public Class CONTRACTS
    Private Sub CONTRACTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblContracts' table. You can move, or remove it, as needed.
        Me.TblContractsTableAdapter.Fill(Me.SkyliteDB.tblContracts)
        'TODO: This line of code loads data into the 'Group26DataSet.CONTRACTS' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Group26Contracts.CONTRACTS' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim selectedCon As String = tblContracts.SelectedCells(0).Value

        Dim sql As String
        sql = "DELETE FROM tblContracts WHERE Contract_ID = '" & selectedCon & "';"

        saveData(sql)

        Me.tblContracts.DataSource = Nothing
        Me.tblContracts.DataSource = SkyliteDB.tblContracts
        Me.TblContractsTableAdapter.Fill(Me.SkyliteDB.tblContracts)

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
        Dim productTable As DataTable = SkyliteDB.tblContracts
        Dim resultTable As DataTable = SkyliteDB.tblContracts
        resultTable.Clear()

        For Each row As DataRow In resultTable.Rows
            If row.Field(Of String)("Product_Name").Contains(TextBox1.Text) Then
                resultTable.Rows.Add(row)
            End If
        Next

    End Sub
End Class