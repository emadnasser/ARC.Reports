Imports System.Data.Common
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.SQLite
Imports System.IO
Imports DevExpress.Internal

Namespace DevExpress.DemoData.Models
    Public Class CountriesEntities
        Inherits DbContext

        Public Sub New()
            MyBase.New(CreateConnection(GenerateConnectionString()), contextOwnsConnection:= True)
        End Sub

        Public Sub New(ByVal connectionString As String)
            MyBase.New(CreateConnection(connectionString), contextOwnsConnection:= True)
        End Sub
        Public Sub New(ByVal connection As DbConnection)
            MyBase.New(connection, True)
        End Sub

        Shared Sub New()
            Database.SetInitializer(Of CountriesEntities)(Nothing)
        End Sub

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
             modelBuilder.Entity(Of AboutRegion)()
             modelBuilder.Entity(Of Hierarchy)()
        End Sub

        Private Shared Function CreateConnection(ByVal connectionString As String) As DbConnection
            Dim connection = DbProviderFactories.GetFactory("System.Data.SQLite.EF6").CreateConnection()
            connection.ConnectionString = connectionString
            Return connection
        End Function

        Private Shared filePath As String
        Private Shared Function GenerateConnectionString() As String
            If filePath Is Nothing Then
                filePath = DataDirectoryHelper.GetFile("countries.db", DataDirectoryHelper.DataFolderName)
            End If
            Try
                Dim attributes = File.GetAttributes(filePath)
                If attributes.HasFlag(FileAttributes.ReadOnly) Then
                    File.SetAttributes(filePath, attributes And (Not FileAttributes.ReadOnly))
                End If
            Catch
            End Try
            Return New SQLiteConnectionStringBuilder With {.DataSource = filePath}.ConnectionString
        End Function

        Public Overridable ReadOnly Property AboutRegions() As DbQuery(Of AboutRegion)
            Get
                Return [Set](Of AboutRegion)().AsNoTracking()
            End Get
        End Property
        Public Overridable ReadOnly Property Hierarchy() As DbQuery(Of Hierarchy)
            Get
                Return [Set](Of Hierarchy)().AsNoTracking()
            End Get
        End Property
    End Class
End Namespace
