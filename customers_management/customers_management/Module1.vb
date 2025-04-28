Imports System.Data.Odbc
Imports Microsoft.Extensions.Configuration
Module Module1
    Public sql As String
    Public dml As OdbcCommand
    Public dr As OdbcDataReader
    Public connection As OdbcConnection



    'Dim config = New ConfigurationBuilder().
    'SetBasePath(AppDomain.CurrentDomain.BaseDirectory).
    'AddJsonFile("appsettings.json").
    'Build()

    'Dim connString As String = config.GetConnectionString("MySQL")
    Public Sub connect_db()
        connection = New OdbcConnection("DSN=db_customer;")
    End Sub
End Module
