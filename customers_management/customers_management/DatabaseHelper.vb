Imports System.Data.Odbc

Public Class DatabaseHelper
    Private ReadOnly connection As OdbcConnection

    Public Sub New()
        connection = New OdbcConnection(ConfigManager.GetConnectionString("CustomerDB"))
    End Sub

    ' Execute a query and return a DataTable
    Public Function ExecuteQuery(query As String, parameters As List(Of OdbcParameter)) As DataTable
        Dim dt As New DataTable()
        Try
            connection.Open()
            Using cmd As New OdbcCommand(query, connection)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                Using adapter As New OdbcDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Database error: " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return dt
    End Function

    ' Execute a non-query (INSERT, UPDATE, DELETE)
    Public Sub ExecuteNonQuery(query As String, parameters As List(Of OdbcParameter))
        Try
            connection.Open()
            Using cmd As New OdbcCommand(query, connection)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception("Database error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class
