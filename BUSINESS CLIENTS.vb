Public Class BUSINESS_CLIENTS
    Private Sub BUSINESS_CLIENTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblClientsBusiness' table. You can move, or remove it, as needed.
        Me.TblClientsBusinessTableAdapter.Fill(Me.SkyliteDB.tblClientsBusiness)
        'TODO: This line of code loads data into the 'Group26DataSet4.BUSINESS_CLIENTS' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim selectedCli As String = tblClientsBusiness.SelectedCells(0).Value

        Dim sql As String
        sql = "DELETE FROM tblClientsBusiness WHERE Client_ID = '" & selectedCli & "';"

        saveData(sql)

        Me.tblClientsBusiness.DataSource = Nothing
        Me.tblClientsBusiness.DataSource = SkyliteDB.tblClientsBusiness
        Me.TblClientsBusinessTableAdapter.Fill(Me.SkyliteDB.tblClientsBusiness)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim clientID As String = txbClientID.Text
        Dim salesID As String = txbSalesPersonID.Text
        Dim bname As String = txbBName.Text
        Dim phone As String = txbPhone.Text
        Dim email As String = txbEmail.Text
        Dim address As String = txbAddress.Text

        Dim sql As String
        sql = "INSERT INTO tblClientsBusiness (Client_ID, Employee_ID, Business_Name, Business_Email, Business_Telephone, Business_Address) VALUES ('" & clientID & "','" & salesID & "','" & bname & "','" & phone & "','" & email & "','" & address & "')"

        saveData(sql)

        Me.tblClientsBusiness.DataSource = Nothing
        Me.tblClientsBusiness.DataSource = SkyliteDB.tblClientsBusiness
        Me.TblClientsBusinessTableAdapter.Fill(Me.SkyliteDB.tblClientsBusiness)

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

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim clientID As String = txbClientID.Text
        Dim salesID As String = txbSalesPersonID.Text
        Dim bname As String = txbBName.Text
        Dim phone As String = txbPhone.Text
        Dim email As String = txbEmail.Text
        Dim address As String = txbAddress.Text

        Dim sql As String
        sql = "UPDATE tblClientsBusiness SET Client_ID = '" & clientID & "', Employee_ID = '" & salesID & "', " & "Business_Name = '" & bname & "', " & "Business_Email = '" & phone & "', " & "Business_Telephone = '" & email & "', " & "Business_Address = '" & address & "' WHERE Client_ID = '" & clientID & "';"

        saveData(sql)

        Me.tblClientsBusiness.DataSource = Nothing
        Me.tblClientsBusiness.DataSource = SkyliteDB.tblClientsBusiness
        Me.TblClientsBusinessTableAdapter.Fill(Me.SkyliteDB.tblClientsBusiness)

    End Sub

    Private Sub tblClientsBusiness_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblClientsBusiness.CellContentClick

    End Sub
End Class