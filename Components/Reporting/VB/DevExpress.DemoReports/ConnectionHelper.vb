Imports System
Imports System.IO
Imports DevExpress.Internal
Imports System.Security
Namespace XtraReportsDemos
    Public NotInheritable Class ConnectionHelper

        Private Sub New()
        End Sub

        Private Shared dataDirectoryName As String = "DataDirectory"
        Private Shared dataDirectoryTag As String = "|DataDirectory|"

        Public Shared Sub ApplyDataDirectory(ByVal dataDirectory As String)
            ApplyDataDirectory(dataDirectory, True)
        End Sub
        Public Shared Sub ApplyDataDirectory(ByVal dataDirectory As String, ByVal forcePatch As Boolean)
            ApplyDataDirectoryCore(ValidateDirectory(dataDirectory))
        End Sub
        Private Shared Sub ApplyDataDirectoryCore(ByVal dataDirectory As String)
            If Not Directory.Exists(dataDirectory) Then
                Throw New ArgumentException("dataDirectory")
            End If

            Dim name As String = "countriesDBConnectionString"
            Dim connection As String = TryCast(My.Settings.Default(name), String)
            My.Settings.Default(name) = PatchConnection(connection, dataDirectory)
        End Sub
        Public Shared Function PatchConnection(ByVal connectionString As String, ByVal dataDirectory As String) As String
            Return PatchConnectionCore(connectionString, Function() dataDirectory)
        End Function
        Public Shared Function PatchConnectionCore(ByVal connectionString As String, ByVal getDataDirectory As Func(Of String)) As String
            If (Not String.IsNullOrEmpty(connectionString)) AndAlso connectionString.Contains(dataDirectoryTag) Then
                Return connectionString.Replace(dataDirectoryTag, getDataDirectory())
            End If
            Return connectionString
        End Function
        Private Shared Function ValidateDirectory(ByVal dataDirectory As String) As String
            Dim result As String = Path.GetFullPath(dataDirectory)
            Return result.TrimEnd("\"c)
        End Function
        Public Shared Function PatchDataDirectory(ByVal connectionString As String) As String
            Return PatchConnectionCore(connectionString, AddressOf GetDataDirectory)
        End Function
        Private Shared Function GetDataDirectory() As String
            Dim dataDirectory As String = TryCast(AppDomain.CurrentDomain.GetData(dataDirectoryName), String)
            If String.IsNullOrEmpty(dataDirectory) Then
                dataDirectory = AppDomain.CurrentDomain.BaseDirectory
            End If
            Return ValidateDirectory(dataDirectory)
        End Function
        Public Shared Sub SetDataDirectory(ByVal directory As String)
            AppDomain.CurrentDomain.SetData("DataDirectory", directory)
        End Sub
    End Class
End Namespace
