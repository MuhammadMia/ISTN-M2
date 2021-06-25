Public Class APPOINTMENTS
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub APPOINTMENTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.APPOINTMENTSTableAdapter.Fill(Me.SkyliteDB.APPOINTMENTS)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim appNum As String = txbAppNum.Text
        Dim cliId As String = txbClientID.Text
        Dim empID As String = txbEmpID.Text
        Dim date1 As Date = txbDate.Text
        Dim time As String = txbTime.Text
        Dim details As String = txbDetails.Text
        Dim status As String = txbStatus.Text

        Dim sql As String
        sql = "INSERT INTO APPOINTMENTS (App_Number, Client_ID, Employee_ID, App_Date, App_Time, App_Details, App_Status) VALUES ('" & appNum & "','" & cliId & "','" & empID & "','" & date1 & "','" & time & "','" & details & "','" & status & "')"

        saveData(sql)

        Me.tblAppointments.DataSource = Nothing
        Me.tblAppointments.DataSource = SkyliteDB.APPOINTMENTS
        Me.APPOINTMENTSTableAdapter.Fill(Me.SkyliteDB.APPOINTMENTS)

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim appNum As String = txbAppNum.Text
        Dim cliId As String = txbClientID.Text
        Dim empID As String = txbEmpID.Text
        Dim date1 As Date = txbDate.Text
        Dim time As String = txbTime.Text
        Dim details As String = txbDetails.Text
        Dim status As String = txbStatus.Text

        Dim sql As String
        sql = "UPDATE APPOINTMENTS SET App_Number = '" & appNum & "', Client_ID = '" & cliId & "', " & "Employee_ID = '" & empID & "', " & "App_Date = '" & date1 & "', " & "App_Time = '" & time & "', " & "App_Details = '" & details & "', " & "App_Status = '" & status & "' WHERE App_Number = '" & appNum & "';"

        saveData(sql)

        Me.tblAppointments.DataSource = Nothing
        Me.tblAppointments.DataSource = SkyliteDB.APPOINTMENTS
        Me.APPOINTMENTSTableAdapter.Fill(Me.SkyliteDB.APPOINTMENTS)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim selectedApp As String = tblAppointments.SelectedCells(0).Value

        Dim sql As String
        sql = "DELETE FROM APPOINTMENTS WHERE App_Number = '" & selectedApp & "';"

        saveData(sql)

        Me.tblAppointments.DataSource = Nothing
        Me.tblAppointments.DataSource = SkyliteDB.APPOINTMENTS
        Me.APPOINTMENTSTableAdapter.Fill(Me.SkyliteDB.APPOINTMENTS)

    End Sub
End Class