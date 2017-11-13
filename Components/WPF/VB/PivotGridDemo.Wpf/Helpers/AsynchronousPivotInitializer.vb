Imports System
Imports System.Data
Imports System.IO
Imports System.Windows
Imports DevExpress.DemoData.Helpers
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.XtraPivotGrid.Data

Namespace PivotGridDemo.PivotGrid.Helpers
    Public Enum InitializerDataSource
        OlapCube
        TableDataSource
    End Enum
    Public MustInherit Class AsynchronousPivotInitializer
        Private Shared adventureWorksFileName As String
        Protected Const DefaultFieldWidth As Integer = 90

        Public Shared Sub Initialize(ByVal pivot As PivotGridControl, ByVal initCompletedCallback As AsyncCompletedHandler, ByVal dataSource As InitializerDataSource)
            Dim initializer As AsynchronousPivotInitializer
            Select Case dataSource
                Case InitializerDataSource.OlapCube
                    initializer = New AsynchronousPivotInitializerSampleOlapDB(pivot, initCompletedCallback)
                    initializer.Initialize()
                Case InitializerDataSource.TableDataSource
                    initializer = New AsynchronousPivotInitializerGeneratedDB(pivot, initCompletedCallback)
                    initializer.Initialize()
                Case Else
                    Throw New ArgumentException("Incorrect InitializerDataSource enum value.", "dataSource")
            End Select
        End Sub
        Protected Sub New(ByVal pivot As PivotGridControl, ByVal initCompletedCallback As AsyncCompletedHandler)
            PivotGrid = pivot
            ResetPivotGrid(PivotGrid)
            InitializationCompletedCallback = initCompletedCallback
        End Sub
        Protected Property PivotGrid() As PivotGridControl
        Protected Property InitializationCompletedCallback() As AsyncCompletedHandler
        Private Shared ReadOnly Property AdventureWorksSampleFileName() As String
            Get
                If String.IsNullOrEmpty(adventureWorksFileName) Then
                    adventureWorksFileName = Path.GetFullPath(DataFilesHelper.FindFile(GetAdventureWorksSampleFileName(), DataFilesHelper.DataPath))
                    If File.Exists(adventureWorksFileName) Then
      Try
       File.SetAttributes(adventureWorksFileName, FileAttributes.Normal)
      Catch
      End Try
                    End If
                End If
                Return adventureWorksFileName
            End Get
        End Property
        Private Shared Function GetAdventureWorksSampleFileName() As String
            Return "AdventureWorks.cub"
        End Function
        Protected Shared ReadOnly Property OLAPSampleConnectionString() As String
            Get
                If String.IsNullOrEmpty(AdventureWorksSampleFileName) Then
                    Return Nothing
                End If
                Return "Provider=msolap;Data Source=" & AdventureWorksSampleFileName & ";Initial Catalog=Adventure Works;Cube Name=Adventure Works"
            End Get
        End Property
        Private Shared Sub ResetPivotGrid(ByVal pivot As PivotGridControl)
   pivot.Fields.Clear()
            If String.IsNullOrEmpty(pivot.OlapConnectionString) Then
                pivot.Groups.Clear()
            End If
            pivot.DataSource = Nothing
        End Sub
        Protected MustOverride Sub Initialize()
    End Class

    Friend Class AsynchronousPivotInitializerGeneratedDB
        Inherits AsynchronousPivotInitializer

        Public Sub New(ByVal pivot As PivotGridControl, ByVal initCompletedCallback As AsyncCompletedHandler)
            MyBase.New(pivot, initCompletedCallback)
        End Sub
        Protected Overrides Sub Initialize()
            DatabaseHelper.GetDataSetAsync(DatabaseHelper.AsyncDataSetSql, AddressOf SetDataSourceGeneratedDatabase)
        End Sub
        Private Sub SetDataSourceGeneratedDatabase(ByVal dataSet As DataSet)
            If dataSet Is Nothing Then
                PivotGrid.IsEnabled = False
                InitializationCompletedCallback.Invoke(Nothing)
                Return
            End If
            PivotGrid.SetDataSourceAsync(dataSet.Tables(0), AddressOf InitPivotLayoutGeneratedDB)
        End Sub
        Private Sub InitPivotLayoutGeneratedDB(ByVal result As AsyncOperationResult)
            PivotGrid.BeginUpdate()
            Dim fieldSalesPerson As PivotGridField = CreatePivotGridField("SalesPersonName", "Sales Person", FieldArea.RowArea)
            Dim fieldCustomer As PivotGridField = CreatePivotGridField("CustomerName", "Customer", FieldArea.FilterArea)
            Dim fieldQuantity As PivotGridField = CreatePivotGridField("Quantity", "Quantity", FieldArea.DataArea)
            Dim fieldUnitPrice As PivotGridField = CreatePivotGridField("UnitPrice", "Unit Price", FieldArea.DataArea)
            fieldUnitPrice.SummaryType = FieldSummaryType.Average
            fieldUnitPrice.ShowSummaryTypeName = True
            Dim fieldOrderID As PivotGridField = CreatePivotGridField("OrderID", "Order ID", FieldArea.FilterArea)
            Dim fieldCategory As PivotGridField = CreatePivotGridField("CategoryName", "Category", FieldArea.RowArea)
            Dim fieldProduct As PivotGridField = CreatePivotGridField("ProductName", "Product", FieldArea.RowArea)
            Dim fieldOrderDateYear As PivotGridField = CreatePivotGridField("OrderDate", "Year", FieldArea.ColumnArea)
            fieldOrderDateYear.GroupInterval = FieldGroupInterval.DateYear
            Dim fieldOrderDateMonth As PivotGridField = CreatePivotGridField("OrderDate", "Month", FieldArea.ColumnArea)
            fieldOrderDateMonth.GroupInterval = FieldGroupInterval.DateMonth
            Dim fieldPrice As New PivotGridField()
            fieldPrice.Area = FieldArea.DataArea
            fieldPrice.Caption = "Price"
            fieldPrice.UnboundType = FieldUnboundColumnType.Decimal

            fieldQuantity.Width = DefaultFieldWidth
            fieldUnitPrice.Width = DefaultFieldWidth
            fieldPrice.Width = DefaultFieldWidth

            PivotGrid.Fields.AddRange(New PivotGridField() { fieldSalesPerson, fieldCustomer, fieldQuantity, fieldUnitPrice, fieldOrderID, fieldCategory, fieldProduct, fieldOrderDateYear, fieldOrderDateMonth, fieldPrice })
            PivotGrid.Groups.Add(fieldOrderDateYear, fieldOrderDateMonth)

            fieldPrice.UnboundExpression = "[" & fieldQuantity.ExpressionFieldName & "] * [" & fieldUnitPrice.ExpressionFieldName & "]"
            PivotGrid.EndUpdateAsync(InitializationCompletedCallback)
        End Sub
        Private Function CreatePivotGridField(ByVal fieldName As String, ByVal caption As String, ByVal area As FieldArea) As PivotGridField
            Dim field As New PivotGridField(fieldName, area)
            field.Caption = caption
            Return field
        End Function
    End Class

    Friend Class AsynchronousPivotInitializerSampleOlapDB
        Inherits AsynchronousPivotInitializer

        Private Const YearFieldName As String = "[Date].[Calendar].[Calendar Year]"
        Private Const CategoryFieldName As String = "[Product].[Product Categories].[Category]"
        Private Const TotalCostFieldName As String = "[Measures].[Total Product Cost]"
        Private Const FreightFieldName As String = "[Measures].[Freight Cost]"
        Private Const QuantityOrderFieldName As String = "[Measures].[Order Quantity]"

        Public Sub New(ByVal pivot As PivotGridControl, ByVal initCompletedCallback As AsyncCompletedHandler)
            MyBase.New(pivot, initCompletedCallback)
        End Sub
        Protected Overrides Sub Initialize()
            Try
                PivotGrid.SetOlapConnectionStringAsync(OLAPSampleConnectionString, AddressOf InitPivotLayoutSampleOlapDB)
            Catch e1 As OLAPConnectionException
                PivotGrid.OlapConnectionString = Nothing
                PivotGrid.IsEnabled = False
                InitializationCompletedCallback.Invoke(Nothing)
            End Try
        End Sub
        Private Sub InitPivotLayoutSampleOlapDB(ByVal result As AsyncOperationResult)
            PivotGrid.RetrieveFields(FieldArea.FilterArea, False)
            If PivotGrid.Fields.Count = 0 Then
                InitializationCompletedCallback.Invoke(Nothing)
                Return
            End If
            PivotGrid.BeginUpdate()
            Dim fieldProduct As PivotGridField = PivotGrid.Fields(CategoryFieldName), fieldYear As PivotGridField = PivotGrid.Fields(YearFieldName), fieldTotalCost As PivotGridField = PivotGrid.Fields(TotalCostFieldName), fieldFreightCost As PivotGridField = PivotGrid.Fields(FreightFieldName), fieldOrderQuantity As PivotGridField = PivotGrid.Fields(QuantityOrderFieldName)
            PivotGrid.Groups(1).Caption = "Calendar"
            PivotGrid.Groups(2).Caption = "Products"

            fieldProduct.Area = FieldArea.RowArea
            fieldYear.Area = FieldArea.ColumnArea
            fieldYear.SortOrder = FieldSortOrder.Descending
            fieldTotalCost.Width = DefaultFieldWidth
            fieldTotalCost.CellFormat = "c2"
            fieldFreightCost.Width = DefaultFieldWidth
            fieldFreightCost.CellFormat = "c2"
            fieldOrderQuantity.Width = DefaultFieldWidth

            fieldProduct.Visible = True
            fieldYear.Visible = True
            fieldTotalCost.Visible = True
            fieldFreightCost.Visible = True
            fieldOrderQuantity.Visible = True

            PivotGrid.EndUpdateAsync(AddressOf ExpandAll)
        End Sub
        Private Sub ExpandAll(ByVal result As AsyncOperationResult)
            PivotGrid.ExpandAllAsync(InitializationCompletedCallback)
        End Sub
    End Class
End Namespace
