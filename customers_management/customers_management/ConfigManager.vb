Imports System.IO
Imports Newtonsoft.Json
Module ConfigManager
    Private Class AppConfig
        Public Property ConnectionStrings As Dictionary(Of String, String)
    End Class

    Private ReadOnly configFilePath As String = "appsettings.json"
    Private config As AppConfig

    ' Load configuration from JSON
    Public Sub LoadConfig()
        Dim jsonContent As String = File.ReadAllText(configFilePath)
        config = JsonConvert.DeserializeObject(Of AppConfig)(jsonContent)
    End Sub

    ' Get a connection string by name
    Public Function GetConnectionString(name As String) As String
        If config Is Nothing Then LoadConfig()
        Return config.ConnectionStrings(name)
    End Function
End Module
