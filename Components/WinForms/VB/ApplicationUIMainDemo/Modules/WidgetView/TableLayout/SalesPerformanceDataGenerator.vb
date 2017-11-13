Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace DevExpress.ApplicationUI.Demos
	Public Class SalesPerformanceDataGenerator
		Inherits SalesDataGenerator
		Public Class TotalSalesItem
			Private uSoldYTDTarget As Integer
			Private uSoldYTD As Integer
			Private revQTDTarget As Decimal
			Private revQTD As Decimal
			Private revYTDTarget As Decimal
			Private revYTD As Decimal
			Private prod As String
			Private cat As String
			Private st As String
			Public Property State() As String
				Get
					Return st
				End Get
				Set(ByVal value As String)
					st = value
				End Set
			End Property
			Public Property Category() As String
				Get
					Return cat
				End Get
				Set(ByVal value As String)
					cat = value
				End Set
			End Property
			Public Property Product() As String
				Get
					Return prod
				End Get
				Set(ByVal value As String)
					prod = value
				End Set
			End Property
			Public Property RevenueYTD() As Decimal
				Get
					Return revYTD
				End Get
				Set(ByVal value As Decimal)
					revYTD = value
				End Set
			End Property
			Public Property RevenueYTDTarget() As Decimal
				Get
					Return revYTDTarget
				End Get
				Set(ByVal value As Decimal)
					revYTDTarget = value
				End Set
			End Property
			Public Property RevenueQTD() As Decimal
				Get
					Return revQTD
				End Get
				Set(ByVal value As Decimal)
					revQTD = value
				End Set
			End Property
			Public Property RevenueQTDTarget() As Decimal
				Get
					Return revQTDTarget
				End Get
				Set(ByVal value As Decimal)
					revQTDTarget = value
				End Set
			End Property
			Public Property UnitsSoldYTD() As Integer
				Get
					Return uSoldYTD
				End Get
				Set(ByVal value As Integer)
					uSoldYTD = value
				End Set
			End Property
			Public Property UnitsSoldYTDTarget() As Integer
				Get
					Return uSoldYTDTarget
				End Get
				Set(ByVal value As Integer)
					uSoldYTDTarget = value
				End Set
			End Property
		End Class
		Public Class MonthlySalesItem
			Private uSoldTarget As Integer
			Private uSold As Integer
			Private revTarget As Decimal
			Private rev As Decimal
			Private curtDate As DateTime
			Private cat As String
			Private prod As String
			Private st As String

			Public Property State() As String
				Get
					Return st
				End Get
				Set(ByVal value As String)
					st = value
				End Set
			End Property
			Public Property Product() As String
				Get
					Return prod
				End Get
				Set(ByVal value As String)
					prod = value
				End Set
			End Property
			Public Property Category() As String
				Get
					Return cat
				End Get
				Set(ByVal value As String)
					cat = value
				End Set
			End Property
			Public Property CurrentDate() As DateTime
				Get
					Return curtDate
				End Get
				Set(ByVal value As DateTime)
					curtDate = value
				End Set
			End Property
			Public Property Revenue() As Decimal
				Get
					Return rev
				End Get
				Set(ByVal value As Decimal)
					rev = value
				End Set
			End Property
			Public Property RevenueTarget() As Decimal
				Get
					Return revTarget
				End Get
				Set(ByVal value As Decimal)
					revTarget = value
				End Set
			End Property
			Public Property UnitsSold() As Integer
				Get
					Return uSold
				End Get
				Set(ByVal value As Integer)
					uSold = value
				End Set
			End Property
			Public Property UnitsSoldTarget() As Integer
				Get
					Return uSoldTarget
				End Get
				Set(ByVal value As Integer)
					uSoldTarget = value
				End Set
			End Property
		End Class

		Private ReadOnly monthlySales_Renamed As New List(Of MonthlySalesItem)()
		Private ReadOnly totalSales_Renamed As New List(Of TotalSalesItem)()
		Public Event UpdateDataSource As EventHandler
		Private filterCore As String
		Public Property Filter() As String
			Get
				Return filterCore
			End Get
			Set(ByVal value As String)
				filterCore = value
				RaiseEvent UpdateDataSource(Me, EventArgs.Empty)
			End Set
		End Property
		Public ReadOnly Property MonthlySales() As IEnumerable(Of MonthlySalesItem)
			Get
				Dim categories = _
					From p In monthlySales_Renamed _
					Where p.State = Filter _
					Group p By p.Product Into g = Group _
					Select New With {Key .Category = Product, Key .Item = g, Key .TotalRevenue = g.Sum(Function(p) p.Revenue)}
				categories.OrderByDescending(Function(d) d.TotalRevenue)
				Dim result As New List(Of MonthlySalesItem)()
				Dim xc = categories.Take(5).Select((Function(s) s.Item)).ToArray()
				For Each item In xc
					result.AddRange(item.ToArray())
				Next item
				Return result
			End Get
		End Property
		Public ReadOnly Property TotalSales() As IEnumerable(Of TotalSalesItem)
			Get
				Return totalSales_Renamed
			End Get
		End Property
		Public ReadOnly Property FilterTotalSales() As IEnumerable(Of TotalSalesItem)
			Get
				Return totalSales_Renamed.Where(Function(d) d.State = Filter)
			End Get
		End Property
		Public ReadOnly Property TotalSalesTop5() As IEnumerable(Of TotalSalesItem)
			Get
				Dim categories = _
					From p In totalSales_Renamed _
					Where p.State = Filter _
					Group p By p.Product Into g = Group _
					Select New With {Key .Category = Product, Key .Item = g, Key .TotalRevenue = g.Sum(Function(p) p.RevenueYTD)}
				categories.OrderByDescending(Function(d) d.TotalRevenue)
				Dim result As New List(Of TotalSalesItem)()
				Dim groupingData = categories.Take(5).Select((Function(s) s.Item)).ToArray()
				For Each item In groupingData
					result.AddRange(item.ToArray())
				Next item
				Return result
			End Get
		End Property
        Private Shared currentCore As SalesPerformanceDataGenerator
        Public Shared ReadOnly Property IsCurrentDataGeneratorExist() As Boolean
            Get
                Return currentCore IsNot Nothing
            End Get
        End Property
        Public Shared ReadOnly Property Current() As SalesPerformanceDataGenerator
			Get
				If currentCore Is Nothing Then
					currentCore = New SalesPerformanceDataGenerator(DataLoader.LoadSales())
					currentCore.Filter = "Montana"
					currentCore.Generate()
				End If
				Return currentCore

			End Get
		End Property

		Shared Sub New()
		End Sub
		Public Sub New(ByVal dataSet As DataSet)
			MyBase.New(dataSet)
		End Sub
		Protected Overrides Sub Generate(ByVal context As Context)
			Dim tsItem As TotalSalesItem = New TotalSalesItem With {.State = context.State, .Category = context.CategoryName, .Product = context.ProductName}
			Dim y As Integer = DateTime.Today.Year - 1
			For month As Integer = 1 To 12
				Dim dt As New DateTime(y, month, 1)
				context.UnitsSoldGenerator.Next()
				Dim uSold As Integer = context.UnitsSoldGenerator.UnitsSold
				Dim uSoldTarget As Integer = context.UnitsSoldGenerator.UnitsSoldTarget
				Dim rev As Decimal = uSold * context.ListPrice
				Dim revTarget As Decimal = uSoldTarget * context.ListPrice
				monthlySales_Renamed.Add(New MonthlySalesItem With {.State = context.State, .Product = context.ProductName, .Category = context.CategoryName, .CurrentDate = dt, .UnitsSold = uSold, .UnitsSoldTarget = uSoldTarget, .Revenue = rev, .RevenueTarget = revTarget})
				tsItem.RevenueYTD += rev
				tsItem.RevenueYTDTarget += revTarget
				tsItem.UnitsSoldYTD += uSold
				tsItem.UnitsSoldYTDTarget += uSoldTarget
				If month >= 10 AndAlso month <= 12 Then
					tsItem.RevenueQTD += rev
					tsItem.RevenueQTDTarget += revTarget
				End If
			Next month
			totalSales_Renamed.Add(tsItem)
		End Sub
	End Class
	Public NotInheritable Class DataHelper
		Private Sub New()
		End Sub
'INSTANT VB NOTE: The parameter random was renamed since Visual Basic will not allow parameters with the same name as their enclosing function or property:
		Public Shared Function Random(ByVal random_Renamed As Random, ByVal deviation As Double, ByVal positive As Boolean) As Double
			Dim rand As Integer = random_Renamed.Next(If(positive, 0, -1000000), 1000000)
			Return CDbl(rand) / 1000000 * deviation
		End Function
'INSTANT VB NOTE: The parameter random was renamed since Visual Basic will not allow parameters with the same name as their enclosing function or property:
		Public Shared Function Random(ByVal random_Renamed As Random, ByVal deviation As Double) As Double
			Return DataHelper.Random(random_Renamed, deviation, False)
		End Function
	End Class
	Public MustInherit Class SalesDataGenerator
		Public Class Context
			Private ReadOnly st As String
			Private ReadOnly prodName As String
			Private ReadOnly catName As String
			Private ReadOnly lPrice As Decimal
			Private ReadOnly uSoldGenerator As UnitsSoldRandomGenerator

			Public ReadOnly Property State() As String
				Get
					Return st
				End Get
			End Property
			Public ReadOnly Property ProductName() As String
				Get
					Return prodName
				End Get
			End Property
			Public ReadOnly Property CategoryName() As String
				Get
					Return catName
				End Get
			End Property
			Public ReadOnly Property ListPrice() As Decimal
				Get
					Return lPrice
				End Get
			End Property
			Public ReadOnly Property UnitsSoldGenerator() As UnitsSoldRandomGenerator
				Get
					Return uSoldGenerator
				End Get
			End Property

			Public Sub New(ByVal st As String, ByVal prodName As String, ByVal catName As String, ByVal lPrice As Decimal, ByVal uSoldGenerator As UnitsSoldRandomGenerator)
				Me.st = st
				Me.prodName = prodName
				Me.catName = catName
				Me.lPrice = lPrice
				Me.uSoldGenerator = uSoldGenerator
			End Sub
		End Class

		Protected Shared Function GetState(ByVal region As DataRow) As String
			Return CStr(region("Region"))
		End Function
		Protected Shared Function GetProductName(ByVal product As DataRow) As String
			Return CStr(product("Name"))
		End Function
		Protected Shared Function GetListPrice(ByVal product As DataRow) As Decimal
			Return CDec(product("ListPrice"))
		End Function

		Private ReadOnly ds As DataSet
		Private ReadOnly categoriesTable As DataTable
		Private ReadOnly productsTable As DataTable
		Private ReadOnly regionsTable As DataTable
		Private ReadOnly rand As New Random(1)
		Private ReadOnly prodClasses_Renamed As ProductClasses
		Private ReadOnly regClasses_Renamed As RegionClasses

		Protected ReadOnly Property Regions() As DataRowCollection
			Get
				Return regionsTable.Rows
			End Get
		End Property
		Protected ReadOnly Property Products() As DataRowCollection
			Get
				Return productsTable.Rows
			End Get
		End Property
		Protected ReadOnly Property ProdClasses() As ProductClasses
			Get
				Return prodClasses_Renamed
			End Get
		End Property
		Protected ReadOnly Property RegClasses() As RegionClasses
			Get
				Return regClasses_Renamed
			End Get
		End Property
		Protected ReadOnly Property Random() As Random
			Get
				Return rand
			End Get
		End Property

		Protected Sub New(ByVal ds As DataSet)
			Me.ds = ds
            If ds.Tables.Count > 0 Then
                categoriesTable = ds.Tables("Categories")
                productsTable = ds.Tables("Products")
                regionsTable = ds.Tables("Regions")
            Else
                categoriesTable = New DataTable()
                productsTable = New DataTable()
                regionsTable = New DataTable()
            End If
            prodClasses_Renamed = New ProductClasses(productsTable.Rows)
			regClasses_Renamed = New RegionClasses(regionsTable.Rows)
		End Sub
		Protected Function GetRegionWeigtht(ByVal region As DataRow) As Double
			Return regClasses_Renamed(CInt(Fix(region("RegionID"))))
		End Function
		Protected Function GetProductClass(ByVal product As DataRow) As ProductClass
			Return prodClasses_Renamed(CInt(Fix(product("ProductID"))))
		End Function
		Protected Function GetCategoryName(ByVal product As DataRow) As String
			Return CStr(categoriesTable.Select(String.Format("CategoryID = {0}", product("CategoryID")))(0)("CategoryName"))
		End Function
		Protected Function CreateUnitsSoldGenerator(ByVal regionWeight As Double, ByVal productClass As ProductClass) As UnitsSoldRandomGenerator
			Return New UnitsSoldRandomGenerator(rand, CInt(Fix(Math.Ceiling(productClass.SaleProbability * regionWeight))))
		End Function
		Protected MustOverride Sub Generate(ByVal context As Context)
		Protected Overridable Sub EndGenerate()
		End Sub
		Public Sub Generate()
			For Each region As DataRow In Regions
				Dim state As String = GetState(region)
				Dim regionWeight As Double = GetRegionWeigtht(region)
				For Each product As DataRow In Products
					Dim unitsSoldgenerator As UnitsSoldRandomGenerator = CreateUnitsSoldGenerator(regionWeight, GetProductClass(product))
					Generate(New Context(state, GetProductName(product), GetCategoryName(product), GetListPrice(product), unitsSoldgenerator))
				Next product
			Next region
			EndGenerate()
		End Sub
	End Class
	Public Class UnitsSoldRandomGenerator
		Private Const MinUnitsSold As Integer = 5

		Private ReadOnly rand As Random
		Private ReadOnly startUnitsSold As Integer
		Private prevUnitsSold? As Integer
		Private prevPrevUnitsSold? As Integer
		Private unitsSold_Renamed As Integer
		Private unitsSoldTarget_Renamed As Integer
		Private isFirst As Boolean = True

		Public ReadOnly Property UnitsSold() As Integer
			Get
				Return unitsSold_Renamed
			End Get
		End Property
		Public ReadOnly Property UnitsSoldTarget() As Integer
			Get
				Return unitsSoldTarget_Renamed
			End Get
		End Property

		Public Sub New(ByVal rand As Random, ByVal startUnitsSold As Integer)
			Me.rand = rand
			Me.startUnitsSold = Math.Max(startUnitsSold, MinUnitsSold)
		End Sub
		Public Sub [Next]()
			If isFirst Then
				unitsSold_Renamed = startUnitsSold
				isFirst = False
			Else
				unitsSold_Renamed = unitsSold_Renamed + CInt(Fix(Math.Round(DataHelper.Random(rand, unitsSold_Renamed * 0.5))))
				unitsSold_Renamed = Math.Max(unitsSold_Renamed, MinUnitsSold)
			End If
			Dim unitsSoldSum As Integer = unitsSold_Renamed
			Dim count As Integer = 1
			If prevUnitsSold.HasValue Then
				unitsSoldSum += prevUnitsSold.Value
				count += 1
			End If
			If prevPrevUnitsSold.HasValue Then
				unitsSoldSum += prevPrevUnitsSold.Value
				count += 1
			End If
			unitsSoldTarget_Renamed = CInt(Fix(Math.Round(CDbl(unitsSoldSum) / count)))
			unitsSoldTarget_Renamed = unitsSoldTarget_Renamed + CInt(Fix(Math.Round(DataHelper.Random(rand, unitsSoldTarget_Renamed))))
			prevPrevUnitsSold = prevUnitsSold
			prevUnitsSold = unitsSold_Renamed
		End Sub
	End Class
	Public Class ProductClass
		Private ReadOnly productIDs As New List(Of Integer)()
		Private ReadOnly minPrice? As Decimal
		Private ReadOnly maxPrice? As Decimal
		Private ReadOnly saleProbability_Renamed As Double

		Public ReadOnly Property SaleProbability() As Double
			Get
				Return saleProbability_Renamed
			End Get
		End Property

		Public Sub New(ByVal minPrice? As Decimal, ByVal maxPrice? As Decimal, ByVal saleProbability As Double)
			Me.minPrice = minPrice
			Me.maxPrice = maxPrice
			Me.saleProbability_Renamed = saleProbability
		End Sub
		Public Function AddProduct(ByVal productID As Integer, ByVal price As Decimal) As Boolean
			Dim satisfyMinPrice As Boolean = (Not minPrice.HasValue) OrElse price >= minPrice.Value
			Dim satisfyMaxPrice As Boolean = (Not maxPrice.HasValue) OrElse price < maxPrice.Value
			If satisfyMinPrice AndAlso satisfyMaxPrice Then
				productIDs.Add(productID)
				Return True
			End If
			Return False
		End Function
		Public Function ContainsProduct(ByVal productID As Integer) As Boolean
			Return productIDs.Contains(productID)
		End Function
	End Class
	Public Class ProductClasses
		Inherits List(Of ProductClass)
		Default Public Shadows ReadOnly Property Item(ByVal productID As Integer) As ProductClass
			Get
				For Each productClass As ProductClass In Me
					If productClass.ContainsProduct(productID) Then
						Return productClass
					End If
				Next productClass
				Throw New ArgumentException("procutID")
			End Get
		End Property

		Public Sub New(ByVal products As ICollection)
			Add(New ProductClass(Nothing, 100D, 0.5))
			Add(New ProductClass(100D, 500D, 0.4))
			Add(New ProductClass(500D, 1500D, 0.3))
			Add(New ProductClass(1500D, Nothing, 0.2))
			For Each product As DataRow In products
				Dim productID As Integer = CInt(Fix(product("ProductID")))
				Dim listPrice As Decimal = CDec(product("ListPrice"))
				For Each productClass As ProductClass In Me
					If productClass.AddProduct(productID, listPrice) Then
						Exit For
					End If
				Next productClass
			Next product
		End Sub
	End Class
	Public Class RegionClasses
		Inherits Dictionary(Of Integer, Double)
		Public Sub New(ByVal regions As ICollection)
			Dim numberEmployeesMin? As Integer = Nothing
			For Each region As DataRow In regions
				Dim numberEmployees As Short = CShort(Fix(region("NumberEmployees")))
				numberEmployeesMin = If(numberEmployeesMin.HasValue, Math.Min(numberEmployeesMin.Value, numberEmployees), numberEmployees)
			Next region
			For Each region As DataRow In regions
				Add(CInt(Fix(region("RegionID"))), CShort(Fix(region("NumberEmployees"))) / CDbl(numberEmployeesMin.Value))
			Next region
		End Sub
	End Class
    Public NotInheritable Class DataLoader
        Private Sub New()
        End Sub
        Public Shared Function NormalizePath(ByVal path As String) As String
            Return System.IO.Path.GetFullPath(New Uri(path).LocalPath)
        End Function
        Public Shared Function GetRelativePath(ByVal name As String) As String
            name = "Data\" & name
            Dim path As String = System.Windows.Forms.Application.StartupPath
            Dim s As String = "\"
            For i As Integer = 0 To 10
                If System.IO.File.Exists(NormalizePath(path & s & name)) Then
                    Return NormalizePath(path & s & name)
                Else
                    s &= "..\"
                End If
            Next i
            path = Environment.CurrentDirectory
            s = "\"
            For i As Integer = 0 To 10
                If System.IO.File.Exists(NormalizePath(path & s & name)) Then
                    Return NormalizePath(path & s & name)
                Else
                    s &= "..\"
                End If
            Next i
            Return ""
        End Function
        Private Shared Function LoadData(ByVal fileName As String) As DataSet
            Dim path As String = GetRelativePath(String.Format("{0}.xml", fileName))
            If String.IsNullOrEmpty(path) Then
                Return New DataSet()
            End If
            Dim ds As New DataSet()
            ds.ReadXml(path, XmlReadMode.ReadSchema)
            Return ds
        End Function
        Public Shared Function LoadSales() As DataSet
            Return LoadData("DashboardSales")
        End Function
        Public Shared Function LoadEmployees() As DataSet
            Return LoadData("DashboardEmployeesAndDepartments")
        End Function
        Public Shared Function LoadCustomerSupport() As DataSet
            Return LoadData("DashboardCustomerSupport")
        End Function
    End Class
End Namespace
