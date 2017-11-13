Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data.Linq
Imports System.Linq
Imports System.Web
Imports DevExpress.Internal

Namespace DataContext

    Partial Public Class SalesDataContext
        Private Const BatchSize As Integer = 2500

        Private Shared TotalDataRowsCount As Integer = 0
        Private Shared InsertedDataRowsCount As Integer = 0

        Protected fDataGenerator As DataGenerator = Nothing
        Protected ReadOnly Property DataGenerator() As DataGenerator
            Get
                If fDataGenerator Is Nothing Then
                    fDataGenerator = New DataGenerator()
                End If
                Return fDataGenerator
            End Get
        End Property

        Protected Shared ReadOnly Property ConnectionString() As String
            Get
                Return DbEngineDetector.PatchConnectionString(ConfigurationManager.ConnectionStrings("SalesViewerConnectionString").ConnectionString)
            End Get
        End Property
        Public Sub New()
            MyBase.New(ConnectionString)
        End Sub

        Public Shared Function IsDatabasePopulated() As Boolean
            Using dataContext As New SalesDataContext()
                Return dataContext.IsDatabaseTablesPopulated()
            End Using
        End Function
        Public Shared Sub PopulateDatabaseIfNecessary()
            If Not IsDatabasePopulated() Then
                Using dataContext As New SalesDataContext()
                    dataContext.PopulateDatabase()
                End Using
            End If
        End Sub
        Private Shared privateDatabasePopulatingProgressPercentValue As Integer
        Public Shared Property DatabasePopulatingProgressPercentValue() As Integer
            Get
                Return privateDatabasePopulatingProgressPercentValue
            End Get
            Private Set(ByVal value As Integer)
                privateDatabasePopulatingProgressPercentValue = value
            End Set
        End Property

        Private Function IsDatabaseTablesPopulated() As Boolean
            Dim hasAnyData As Boolean = Regions.Any() AndAlso Cities.Any() AndAlso Channels.Any() AndAlso Sectors.Any() AndAlso Contacts.Any() AndAlso Customers.Any() AndAlso Plants.Any() AndAlso Products.Any() AndAlso Sales.Any()
            Dim hasActualData As Boolean = Sales.Any(Function(s) s.SaleDate.Year = Date.Today.Year)
            Return hasAnyData AndAlso hasActualData
        End Function
        Private Sub PopulateDatabase()
            TotalDataRowsCount += DataGenerator.Regions.Count
            TotalDataRowsCount += DataGenerator.Cities.Count
            TotalDataRowsCount += DataGenerator.Channels.Count
            TotalDataRowsCount += DataGenerator.Sectors.Count
            TotalDataRowsCount += DataGenerator.Contacts.Count
            TotalDataRowsCount += DataGenerator.Customers.Count
            TotalDataRowsCount += DataGenerator.Plants.Count
            TotalDataRowsCount += DataGenerator.Products.Count
            TotalDataRowsCount += DataGenerator.Sales.Count

            PurgeTable(Of Sale)()
            PurgeTable(Of Product)()
            PurgeTable(Of Plant)()
            PurgeTable(Of Customer)()
            PurgeTable(Of Contact)()
            PurgeTable(Of Sector)()
            PurgeTable(Of Channel)()
            PurgeTable(Of City)()
            PurgeTable(Of Region)()

            PopulateTable(Of Region)(DataGenerator.Regions)
            PopulateTable(Of City)(DataGenerator.Cities)
            PopulateTable(Of Channel)(DataGenerator.Channels)
            PopulateTable(Of Sector)(DataGenerator.Sectors)
            PopulateTable(Of Contact)(DataGenerator.Contacts)
            PopulateTable(Of Customer)(DataGenerator.Customers)
            PopulateTable(Of Plant)(DataGenerator.Plants)
            PopulateTable(Of Product)(DataGenerator.Products)
            PopulateTable(Of Sale)(DataGenerator.Sales)

            InsertedDataRowsCount = 0
            TotalDataRowsCount = 0
        End Sub
        Private Sub PurgeTable(Of T As Class)()
            Dim dataTable As Table(Of T) = GetTable(Of T)()
            dataTable.DeleteAllOnSubmit(Of T)(dataTable)
            SubmitChanges()
        End Sub
        Private Sub PopulateTable(Of T As Class)(ByVal data As IEnumerable(Of T))
            Dim dataTable As Table(Of T) = GetTable(Of T)()
            Dim tableRowCount As Integer = dataTable.Count()
            If tableRowCount < data.Count() Then
                BulkInsert(Of T)(data.Skip(tableRowCount), dataTable)
            End If
        End Sub
        Private Sub BulkInsert(Of T As Class)(ByVal data As IEnumerable(Of T), ByVal table As Table(Of T))
            Dim maxPage As Integer = CInt((Math.Ceiling(data.Count() / CDbl(BatchSize))))
            For page As Integer = 0 To maxPage - 1
                Dim dataToInsert As IEnumerable(Of T) = data.Skip(page * BatchSize).Take(BatchSize)
                InsertedDataRowsCount += dataToInsert.Count()
                table.InsertAllOnSubmit(dataToInsert)
                SubmitChanges()
                ' Progress
                DatabasePopulatingProgressPercentValue = CInt(InsertedDataRowsCount * 100 \ TotalDataRowsCount)
            Next page
        End Sub
    End Class
End Namespace
