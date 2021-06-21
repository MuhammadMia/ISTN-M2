Public Class APPOINTMENTS_TABLE
    Private Sub APPOINTMENTS_TABLE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkyliteDB.APPOINTMENTS' table. You can move, or remove it, as needed.
        Me.APPOINTMENTSTableAdapter.Fill(Me.SkyliteDB.APPOINTMENTS)

    End Sub
End Class