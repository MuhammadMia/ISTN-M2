Public Class INDIVIDUAL_CLIENTS
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub INDIVIDUAL_CLIENTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.tblClientsIndividual' table. You can move, or remove it, as needed.
        Me.TblClientsIndividualTableAdapter.Fill(Me.SkyliteDB.tblClientsIndividual)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim selectedCli As String = tblClientsIndividual.SelectedCells(0).Value

        Dim sql As String
        sql = "DELETE FROM tblIndClients WHERE Client_ID = '" & selectedCli & "';"

        saveData(sql)

        Me.tblClientsIndividual.DataSource = Nothing
        Me.tblClientsIndividual.DataSource = SkyliteDB.tblClientsIndividual
        Me.TblClientsIndividualTableAdapter.Fill(Me.SkyliteDB.tblClientsIndividual)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim clientID As String = txbClientID.Text
        Dim indID As String = txbIndID.Text
        Dim name As String = txbName.Text
        Dim email As String = txbEmail.Text
        Dim cell As String = txbCell.Text

        Dim sql As String
        sql = "INSERT INTO tblClientsIndividual (Client_ID, Individual_ID, Individual_Name, Individual_Email, Individual_Cell) VALUES ('" & clientID & "','" & indID & "','" & name & "','" & email & "','" & cell & "')"

        saveData(sql)

        Me.tblClientsIndividual.DataSource = Nothing
        Me.tblClientsIndividual.DataSource = SkyliteDB.tblClientsIndividual
        Me.TblClientsIndividualTableAdapter.Fill(Me.SkyliteDB.tblClientsIndividual)

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim clientID As String = txbClientID.Text
        Dim indID As String = txbIndID.Text
        Dim name As String = txbName.Text
        Dim email As String = txbEmail.Text
        Dim cell As String = txbCell.Text

        Dim sql As String
        sql = "UPDATE tblIndClients SET Client_ID = '" & clientID & "', Individual_ID = '" & indID & "', " & "Individual_Name = '" & name & "', " & "Individual_Email = '" & email & "', " & "Individual_Cell = '" & cell & "' WHERE Employee_ID = '" & indID & "';"

        saveData(sql)

        Me.tblClientsIndividual.DataSource = Nothing
        Me.tblClientsIndividual.DataSource = SkyliteDB.tblClientsIndividual
        Me.TblClientsIndividualTableAdapter.Fill(Me.SkyliteDB.tblClientsIndividual)

    End Sub
End Class