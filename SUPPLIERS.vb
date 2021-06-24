Public Class SUPPLIERS
    Private Sub SUPPLIERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblSuplliers' table. You can move, or remove it, as needed.
        Me.TblSuplliersTableAdapter.Fill(Me.SkyliteDB.tblSuplliers)
        'TODO: This line of code loads data into the 'Group26DataSet2.SUPPLIERS' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim selectedSupp As String = tblSuplliers.SelectedCells(0).Value

        Dim sql As String
        sql = "DELETE FROM tblSuplliers WHERE Supplier_ID = '" & selectedSupp & "';"

        saveData(sql)

        Me.tblSuplliers.DataSource = Nothing
        Me.tblSuplliers.DataSource = SkyliteDB.tblSuplliers
        Me.TblSuplliersTableAdapter.Fill(Me.SkyliteDB.tblSuplliers)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim name As String = txbSuppName.Text
        Dim suppID As String = txbSuppID.Text
        Dim email As String = txbEmail.Text
        Dim phone As String = txbPhone.Text
        Dim address As String = txbAddress.Text

        Dim sql As String
        sql = "INSERT INTO tblSuplliers (Supplier_ID, Supplier_Name, Supplier_Email, Supplier_Telephone, Supplier_Address) VALUES ('" & suppID & "','" & name & "','" & email & "','" & phone & "','" & address & "')"

        saveData(sql)

        Me.tblSuplliers.DataSource = Nothing
        Me.tblSuplliers.DataSource = SkyliteDB.tblSuplliers
        Me.TblSuplliersTableAdapter.Fill(Me.SkyliteDB.tblSuplliers)

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

    Private Sub tblSuppliers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblSuplliers.CellContentClick
        Dim selectedProduct As String = tblSuplliers.SelectedCells(0).Value

        Dim rowNum As Int16 = tblSuplliers.CurrentCell.RowIndex


        txbSuppID.Text = tblSuplliers.Rows(rowNum).Cells(0).Value
        txbSuppName.Text = tblSuplliers.Rows(rowNum).Cells(1).Value
        txbEmail.Text = tblSuplliers.Rows(rowNum).Cells(2).Value
        txbPhone.Text = tblSuplliers.Rows(rowNum).Cells(3).Value
        txbAddress.Text = tblSuplliers.Rows(rowNum).Cells(4).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim name As String = txbSuppName.Text
        Dim suppID As String = txbSuppID.Text
        Dim email As String = txbEmail.Text
        Dim phone As String = txbPhone.Text
        Dim address As String = txbAddress.Text

        Dim sql As String
        sql = "UPDATE tblSuplliers SET Supplier_Name = '" & name & "', Supplier_ID = '" & suppID & "', " & "Supplier_Email = '" & email & "', " & "Supplier_Telephone = '" & phone & "', " & "Supplier_Address = '" & address & "' WHERE Supplier_ID = '" & suppID & "';"

        saveData(sql)

        Me.tblSuplliers.DataSource = Nothing
        Me.tblSuplliers.DataSource = SkyliteDB.tblSuplliers
        Me.TblSuplliersTableAdapter.Fill(Me.SkyliteDB.tblSuplliers)

    End Sub
End Class