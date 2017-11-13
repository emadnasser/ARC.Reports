Imports System.Data.Common
Imports System.Data.Entity
Imports System.Data.SQLite
Imports System.IO
Imports DevExpress.DemoData.Models.Mapping
Imports DevExpress.Internal

Namespace DevExpress.DemoData.Models
    Partial Public Class NWindEntities
        Inherits DbContext

        Shared Sub New()
            Database.SetInitializer(Of NWindEntities)(Nothing)
        End Sub
        Public Sub New()
            MyBase.New(CreateConnection(GenerateConnectionString()), contextOwnsConnection:= True)
        End Sub
        Public Sub New(ByVal connectionString As String)
            MyBase.New(CreateConnection(connectionString), contextOwnsConnection:= True)
        End Sub
        Private Shared filePath As String
        Private Shared Function GenerateConnectionString() As String
            If filePath Is Nothing Then
                filePath = DataDirectoryHelper.GetFile("nwind.db", DataDirectoryHelper.DataFolderName)
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
        Private Shared Function CreateConnection(ByVal connectionString As String) As DbConnection
            Dim connection As DbConnection = DbProviderFactories.GetFactory("System.Data.SQLite.EF6").CreateConnection()
            connection.ConnectionString = connectionString
            Return connection
        End Function
        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
            modelBuilder.Configurations.Add(New CategoryMap())
            modelBuilder.Configurations.Add(New EmployeeMap())
            modelBuilder.Configurations.Add(New ProductMap())
            modelBuilder.Configurations.Add(New SalesPersonMap())
        End Sub
        Public Property SalesPersons() As DbSet(Of SalesPerson)
        Public Property Categories() As DbSet(Of Category)
        Public Property Products() As DbSet(Of Product)
        Public Property Employees() As DbSet(Of Employee)
    End Class
End Namespace
