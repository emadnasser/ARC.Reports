Imports DevExpress.MVVM.Demos.Model
Imports DevExpress.Internal
Imports System.IO
Imports System.Data.SQLite
Imports System.Data.Entity
Imports System.Data.Common

Namespace DevExpress.MVVM.Demos.DataBase

    Public Class ExpensesDbContext
        Inherits DbContext

        Public Sub New()
            MyBase.New(CreateConnection(), True)
        End Sub
        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString)
        End Sub
        Public Sub New(ByVal connection As DbConnection)
            MyBase.New(connection, True)
        End Sub
        Shared Sub New()
            System.Data.Entity.Database.SetInitializer(Of ExpensesDbContext)(Nothing)
        End Sub
        Public Property Accounts() As DbSet(Of Account)
        Public Property Categories() As DbSet(Of Category)
        Public Property Transactions() As DbSet(Of Transaction)
        '
        Private Shared filePath As String
        Private Shared Function CreateConnection() As DbConnection
            If filePath Is Nothing Then
                filePath = DataDirectoryHelper.GetFile("expenses.sqlite3", DataDirectoryHelper.DataFolderName)
            End If
            File.SetAttributes(filePath, File.GetAttributes(filePath) And (Not FileAttributes.ReadOnly))
            Dim connection = DbProviderFactories.GetFactory("System.Data.SQLite.EF6").CreateConnection()
            connection.ConnectionString = New SQLiteConnectionStringBuilder With {.DataSource = filePath}.ConnectionString
            Return connection
        End Function
    End Class
End Namespace
