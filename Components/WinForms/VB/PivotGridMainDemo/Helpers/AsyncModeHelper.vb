Imports Microsoft.VisualBasic
Imports DevExpress.Data
Imports DevExpress.Data.PivotGrid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports System
Imports System.Data
Imports System.IO
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Helpers
	Public Enum InitializerDataSource
		OlapCube
		TableDataSource
	End Enum
	Public MustInherit Class AsynchronousPivotInitializer
		Public Const OlapError As String = "A connection error occurred. Please make sure that you have provided proper connection settings.To connect to OLAP cubes," & Constants.vbLf & "you should have Microsoft SQL Server 2005 Analysis Services 9.0 OLE DB provider installed on your system."
		Public Const TableError As String = "A connection error occurred. Please make sure that you have generated a data source and provided proper connection settings."
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
		Private privatePivotGrid As PivotGridControl
		Protected Property PivotGrid() As PivotGridControl
			Get
				Return privatePivotGrid
			End Get
			Set(ByVal value As PivotGridControl)
				privatePivotGrid = value
			End Set
		End Property
		Private privateInitializationCompletedCallback As AsyncCompletedHandler
		Protected Property InitializationCompletedCallback() As AsyncCompletedHandler
			Get
				Return privateInitializationCompletedCallback
			End Get
			Set(ByVal value As AsyncCompletedHandler)
				privateInitializationCompletedCallback = value
			End Set
		End Property
		Private Shared ReadOnly Property AdventureWorksSampleFileName() As String
			Get
				If String.IsNullOrEmpty(adventureWorksFileName) Then
					adventureWorksFileName = Path.GetFullPath(FilesHelper.FindingFileName(Application.StartupPath, GetAdventureWorksSampleFileName()))
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
			Return "Data\AdventureWorks.cub"
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
			If String.IsNullOrEmpty(pivot.OLAPConnectionString) Then
				pivot.Groups.Clear()
			End If
			pivot.Fields.Clear()
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
				PivotGrid.Enabled = False
				InitializationCompletedCallback.Invoke(Nothing)
				Return
			End If
			PivotGrid.SetDataSourceAsync(dataSet.Tables(0), AddressOf InitPivotLayoutGeneratedDB)
		End Sub
		Private Sub InitPivotLayoutGeneratedDB(ByVal obj As Object)
			PivotGrid.BeginUpdate()
			Dim fieldSalesPerson As PivotGridField = CreatePivotGridField("SalesPersonName", "Sales Person", PivotArea.RowArea)
			Dim fieldCustomer As PivotGridField = CreatePivotGridField("CustomerName", "Customer", PivotArea.FilterArea)
			Dim fieldQuantity As PivotGridField = CreatePivotGridField("Quantity", "Quantity", PivotArea.DataArea)
			Dim fieldUnitPrice As PivotGridField = CreatePivotGridField("UnitPrice", "Unit Price", PivotArea.DataArea)
			fieldUnitPrice.SummaryType = PivotSummaryType.Average
			fieldUnitPrice.Options.ShowSummaryTypeName = True
			Dim fieldOrderID As PivotGridField = CreatePivotGridField("OrderID", "Order ID", PivotArea.FilterArea)
			Dim fieldCategory As PivotGridField = CreatePivotGridField("CategoryName", "Category", PivotArea.RowArea)
			Dim fieldProduct As PivotGridField = CreatePivotGridField("ProductName", "Product", PivotArea.RowArea)
			Dim fieldOrderDateYear As PivotGridField = CreatePivotGridField("OrderDate", "Year", PivotArea.ColumnArea)
			fieldOrderDateYear.GroupInterval = PivotGroupInterval.DateYear
			Dim fieldOrderDateMonth As PivotGridField = CreatePivotGridField("OrderDate", "Month", PivotArea.ColumnArea)
			fieldOrderDateMonth.GroupInterval = PivotGroupInterval.DateMonth
			Dim fieldPrice As New PivotGridField()
			fieldPrice.Area = PivotArea.DataArea
			fieldPrice.Caption = "Price"
			fieldPrice.UnboundType = UnboundColumnType.Decimal

			fieldQuantity.Width = DefaultFieldWidth
			fieldUnitPrice.Width = DefaultFieldWidth
			fieldPrice.Width = DefaultFieldWidth

			PivotGrid.Fields.AddRange(New PivotGridField() { fieldSalesPerson, fieldCustomer, fieldQuantity, fieldUnitPrice, fieldOrderID, fieldCategory, fieldProduct, fieldOrderDateYear, fieldOrderDateMonth, fieldPrice })
			PivotGrid.Groups.Add(fieldOrderDateYear, fieldOrderDateMonth)

			fieldPrice.UnboundExpression = "[" & fieldQuantity.ExpressionFieldName & "] * [" & fieldUnitPrice.ExpressionFieldName & "]"
			PivotGrid.EndUpdateAsync(InitializationCompletedCallback)
		End Sub
		Private Function CreatePivotGridField(ByVal fieldName As String, ByVal caption As String, ByVal area As PivotArea) As PivotGridField
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
				PivotGrid.SetOLAPConnectionStringAsync(OLAPSampleConnectionString, AddressOf InitPivotLayoutSampleOlapDB)
			Catch e1 As OLAPConnectionException
				PivotGrid.OLAPConnectionString = Nothing
				PivotGrid.Enabled = False
				InitializationCompletedCallback.Invoke(Nothing)
			End Try
		End Sub
		Private Sub InitPivotLayoutSampleOlapDB(ByVal obj As Object)
			PivotGrid.RetrieveFields(PivotArea.FilterArea, False)
			If PivotGrid.Fields.Count = 0 Then
				InitializationCompletedCallback.Invoke(Nothing)
				Return
			End If
			PivotGrid.BeginUpdate()
			Dim fieldProduct As PivotGridField = PivotGrid.Fields(CategoryFieldName), fieldYear As PivotGridField = PivotGrid.Fields(YearFieldName), fieldTotalCost As PivotGridField = PivotGrid.Fields(TotalCostFieldName), fieldFreightCost As PivotGridField = PivotGrid.Fields(FreightFieldName), fieldOrderQuantity As PivotGridField = PivotGrid.Fields(QuantityOrderFieldName)
			PivotGrid.Groups(1).Caption = "Calendar"
			PivotGrid.Groups(2).Caption = "Products"

			fieldProduct.Area = PivotArea.RowArea
			fieldYear.Area = PivotArea.ColumnArea
			fieldYear.SortOrder = PivotSortOrder.Descending
			fieldTotalCost.Width = DefaultFieldWidth
			fieldTotalCost.CellFormat.FormatType = FormatType.Numeric
			fieldTotalCost.CellFormat.FormatString = "c2"
			fieldFreightCost.Width = DefaultFieldWidth
			fieldFreightCost.CellFormat.FormatType = FormatType.Numeric
			fieldFreightCost.CellFormat.FormatString = "c2"
			fieldOrderQuantity.Width = DefaultFieldWidth

			fieldProduct.Visible = True
			fieldYear.Visible = True
			fieldTotalCost.Visible = True
			fieldFreightCost.Visible = True
			fieldOrderQuantity.Visible = True

			PivotGrid.EndUpdateAsync(AddressOf ExpandAll)
		End Sub
		Private Sub ExpandAll(ByVal obj As Object)
			PivotGrid.ExpandAllAsync(InitializationCompletedCallback)
		End Sub
	End Class
End Namespace
