Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports DevExpress.Utils
Imports System.Globalization
Imports DevExpress.DemoData.Helpers

Namespace DevExpress.DemoReports
    Public Class ConnectionStringConfigurator
        Private Const DataDirectoryMacro As String = "|DataDirectory|"
        Private Const SqlClientProviderName As String = "System.Data.SqlClient"
        Private Const SQLiteProviderName As String = "System.Data.SQLite"
        Private ReadOnly sqlClientConnectionStrings As IEnumerable(Of ConnectionStringSettings)
        Private ReadOnly sqliteConnectionStrings As IEnumerable(Of ConnectionStringSettings)

        Public Sub New(ByVal connectionStrings As ConnectionStringSettingsCollection)
            Guard.ArgumentNotNull(connectionStrings, "connectionStrings")
            Me.sqlClientConnectionStrings = GetConnectionStrings(connectionStrings, "", SqlClientProviderName)
            Me.sqliteConnectionStrings = GetConnectionStrings(connectionStrings, SQLiteProviderName)
        End Sub

        Public Function SelectDbEngine() As ConnectionStringConfigurator
            For Each settingsElement As ConnectionStringSettings In sqlClientConnectionStrings
                Dim connectionString = settingsElement.ConnectionString
                Dim builder = New DbConnectionStringBuilder With {.ConnectionString = connectionString}
                If Not builder.ContainsKey("AttachDbFilename") Then
                    Continue For
                End If
                PatchReadOnly(settingsElement)
                settingsElement.ConnectionString = DbEngineDetector.PatchConnectionString(settingsElement.ConnectionString)
            Next settingsElement

            Return Me
        End Function

        Public Function ExpandDataDirectory(ByVal findDataFile As Func(Of String, String)) As ConnectionStringConfigurator
            Guard.ArgumentNotNull(findDataFile, "findDataFile")

            For Each connectionStringSettings As ConnectionStringSettings In sqlClientConnectionStrings.Union(sqliteConnectionStrings)
                PatchReadOnly(connectionStringSettings)
                connectionStringSettings.ConnectionString = ExpandDataDirectory(connectionStringSettings.ConnectionString, findDataFile)
            Next connectionStringSettings
            Return Me
        End Function

        Private Function GetConnectionStrings(ByVal connectionStrings As ConnectionStringSettingsCollection, ParamArray ByVal providerNames() As String) As IEnumerable(Of ConnectionStringSettings)
            Dim filteredSettings As New List(Of ConnectionStringSettings)()
            For Each settingsElement As ConnectionStringSettings In connectionStrings
                If providerNames.Contains(If(settingsElement.ProviderName, String.Empty)) Then
                    filteredSettings.Add(settingsElement)
                End If
            Next settingsElement
            Return filteredSettings
        End Function

        Private Sub PatchReadOnly(ByVal element As ConfigurationElement)
            Dim fi As FieldInfo = GetType(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance Or BindingFlags.NonPublic)
            fi.SetValue(element, False)
        End Sub

        Private Function ExpandDataDirectory(ByVal connectionString As String, ByVal findDataFile As Func(Of String, String)) As String
            Dim dataSource As String = GetValue(connectionString, "Data Source")
            Dim attachDbFileName As String = GetValue(connectionString, "AttachDbFilename")
            If (Not attachDbFileName.Contains(DataDirectoryMacro)) AndAlso (Not dataSource.Contains(DataDirectoryMacro)) Then
                Return connectionString
            End If
            Dim dbFilePath As String = Nothing
            If dataSource.Contains(DataDirectoryMacro) Then
                dbFilePath = findDataFile(GetDbFileName(dataSource))
            ElseIf attachDbFileName.Contains(DataDirectoryMacro) Then
                dbFilePath = findDataFile(GetDbFileName(attachDbFileName))
            End If
            If String.IsNullOrEmpty(dbFilePath) Then
                Return connectionString
            End If
            dbFilePath = Path.GetFullPath(dbFilePath)
            Dim dataDirectory As String = Path.GetDirectoryName(dbFilePath)
            Dim patchedString As String = connectionString.Replace(DataDirectoryMacro, dataDirectory)
            Return patchedString
        End Function

        Private Function GetValue(ByVal connectionString As String, ByVal key As String) As String
            Dim dbCSB As New DbConnectionStringBuilder() With {.ConnectionString = connectionString}
            Dim value As Object = Nothing
            If dbCSB.TryGetValue(key, value) Then
                Try
                    Return DirectCast(value, IConvertible).ToString(CultureInfo.InvariantCulture)
                Catch e1 As InvalidCastException
                End Try
            End If
            Return ""
        End Function
        Private Function GetDbFileName(ByVal attachDbFileName As String) As String
            Dim dbFileName As String = attachDbFileName.Replace(DataDirectoryMacro, "")
            dbFileName = dbFileName.TrimStart("\"c, "/"c)
            Return dbFileName
        End Function
    End Class
End Namespace
