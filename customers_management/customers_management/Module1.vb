Imports System.Data.Odbc

Module Module1

    Public connection As OdbcConnection
    Public Sub connect_db()
        Dim connectionString As String = ConfigManager.GetConnectionString("CustomerDB")
        connection = New OdbcConnection(connectionString)
    End Sub

End Module
