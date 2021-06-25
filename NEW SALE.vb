Public Class NEW_SALE
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub NEW_SALE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblEmployees' table. You can move, or remove it, as needed.
        Me.TblEmployeesTableAdapter.Fill(Me.SkyliteDB.tblEmployees)
        'TODO: This line of code loads data into the 'SkyliteDB.tblSaleItems' table. You can move, or remove it, as needed.
        Me.TblSaleItemsTableAdapter.Fill(Me.SkyliteDB.tblSaleItems)
        'TODO: This line of code loads data into the 'SkyliteDB.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.SkyliteDB.tblProducts)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProducts.CellContentClick

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        Dim cart As DataTable = SkyliteDB.tblSaleItems

        cart.Rows.Add(cart.Rows.Count + 1, tblProducts.SelectedCells(1).Value, tblProducts.SelectedCells(0).Value, tblProducts.SelectedCells(2).Value, 0.0, tblProducts.SelectedCells(7).Value)

        tblCart.DataSource = cart
        'TblCartProductsAdapter.Fill()
    End Sub

    Private Sub txbSearch_TextChanged(sender As Object, e As EventArgs) Handles txbSearch.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txbContractLength_TextChanged(sender As Object, e As EventArgs) Handles txbContractLength.TextChanged

    End Sub

    Dim sql As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim clientID As String = txbClientID.Text
        Dim employeeID As String = cmbEmployeeID.SelectedItem.ToString
        Dim saleDate As Date = dtSaleDate.Value
        Dim saleType As String = cmbSaleType.SelectedItem.ToString
        Dim contractLength As String = txbContractLength.Text
        Dim paymentType As String = cmbPaymentType.SelectedItem.ToString

        Dim total As Decimal = 0
        For Each row As DataGridViewRow In tblCart.Rows
            total += row.Cells(2).Value
        Next

        If saleType = "Contract" Then
            sql = "INSERT INTO tblContracts (Contract_ID, Client_ID, Sale_Number, Contract_Amount, Contract_Length, Contract_Start, Monthly_Cost) VALUES ('" & (SkyliteDB.tblContracts.Rows.Count + 1) & "', '" & clientID & "', '0', '" & total & "', '" & contractLength & "', '" & saleDate & "', '" & total & "');"
            lblTotalMonthly.Text = "R" & total
            lblTotalOnce.Text = "R0.00"
        Else
            sql = "INSERT INTO tblSales (Sale_Number, Client_ID, Employee_ID, Sale_Date, Payment_Type, Amount_Due) VALUES ('" & (SkyliteDB.tblSales.Rows.Count + 1) & "', '" & clientID & "', '0', '" & employeeID & "', '" & saleDate & "', '" & paymentType & "', '" & total & "');"
            lblTotalOnce.Text = "R" & total
            lblTotalMonthly.Text = "R0.00"
        End If
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

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

    End Sub

    Private Sub TblProductsBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles TblProductsBindingSource.CurrentChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        saveData(sql)
    End Sub
End Class