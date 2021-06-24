Public Class PRODUCTS
    Private Sub PRODUCTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.SkyliteDB.tblProducts)


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub tblProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProducts.CellContentClick
        Dim selectedProduct As String = tblProducts.SelectedCells(0).Value

        lblSelectedProduct.Text = selectedProduct

        Dim rowNum As Int16 = tblProducts.CurrentCell.RowIndex


        txbProdName.Text = tblProducts.Rows(rowNum).Cells(2).Value
        txbSuppID.Text = tblProducts.Rows(rowNum).Cells(1).Value
        txbManufacturer.Text = tblProducts.Rows(rowNum).Cells(3).Value
        txbColor.Text = tblProducts.Rows(rowNum).Cells(4).Value
        txbCost.Text = tblProducts.Rows(rowNum).Cells(5).Value
        txbPrice.Text = tblProducts.Rows(rowNum).Cells(6).Value
        txbQuantity.Text = tblProducts.Rows(rowNum).Cells(7).Value

    End Sub

    Private Sub btnRemoveProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveProduct.Click

        Dim selectedProd As String = tblProducts.SelectedCells(0).Value

        Dim sql As String
        sql = "DELETE FROM tblProducts WHERE Product_ID = '" & selectedProd & "';"

        saveData(sql)

        Me.tblProducts.DataSource = Nothing
        Me.tblProducts.DataSource = SkyliteDB.tblProducts
        Me.TblProductsTableAdapter.Fill(Me.SkyliteDB.tblProducts)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim prodID As String = txbProdID.Text
        Dim prodDes As String = txbDescription.Text
        Dim suppID As String = txbSuppID.Text
        Dim prodName As String = txbProdName.Text
        Dim manufacturer As String = txbManufacturer.Text
        Dim color As String = txbColor.Text
        Dim cost As String = txbCost.Text
        Dim sale As String = txbPrice.Text
        Dim stock As Integer = txbQuantity.Text

        Dim sql As String
        sql = "INSERT INTO tblProducts (Product_ID, Supplier_ID, Product_Name, Product_Description, Manufacturer, Colour, Cost_Price, Sale_Price, Current_Stock) VALUES ('" & prodID & "','" & suppID & "','" & prodName & "','" & prodDes & "','" & manufacturer & "','" & color & "','" & cost & "','" & sale & "','" & stock & "')"

        saveData(sql)

        Me.tblProducts.DataSource = Nothing
        Me.tblProducts.DataSource = SkyliteDB.tblProducts
        Me.TblProductsTableAdapter.Fill(Me.SkyliteDB.tblProducts)

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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim prodID As String = txbProdID.Text
        Dim prodDes As String = txbDescription.Text
        Dim suppID As String = txbSuppID.Text
        Dim prodName As String = txbProdName.Text
        Dim manufacturer As String = txbManufacturer.Text
        Dim color As String = txbColor.Text
        Dim cost As String = txbCost.Text
        Dim sale As String = txbPrice.Text
        Dim stock As Integer = txbQuantity.Text

        Dim sql As String
        sql = "UPDATE tblProducts SET Product_ID = '" & prodID & "', Supplier_ID = '" & suppID & "', " & "Product_Name = '" & prodName & "', " & "Product_Description = '" & prodDes & "', " & "Manufacturer = '" & manufacturer & "', " & "Colour = '" & color & "', " & "Cost_Price = '" & cost & "', " & "Sale_Price = '" & sale & "', " & "Current_Stock = '" & stock & "' WHERE Product_ID = '" & prodID & "';"

        saveData(sql)

        Me.tblProducts.DataSource = Nothing
        Me.tblProducts.DataSource = SkyliteDB.tblProducts
        Me.TblProductsTableAdapter.Fill(Me.SkyliteDB.tblProducts)

    End Sub
End Class