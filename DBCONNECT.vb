Module DBCONNECT
    Public dbcon As New OleDb.OleDbConnection
    Public Sub ConnectDB()
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; data source=" & Application.StartupPath & "\EMPLOYEE.accdb"
            dbcon.Open()
        End If
    End Sub
End Module
