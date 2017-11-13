Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Xml
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos
	Public NotInheritable Class Utils
		Private Const path As String = "DevExpress.XtraCharts.Demos.Images."

		Private Sub New()
		End Sub
		Private Shared Function GetNonAbstractSubclasses(ByVal baseType As Type) As IEnumerable(Of Type)
			Dim xtraChartsAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetAssembly(GetType(Legend))
			Return xtraChartsAssembly.GetTypes().Where(Function(type) (Not type.IsAbstract) AndAlso type.IsSubclassOf(baseType) AndAlso type.IsPublic)
		End Function
		Private Shared Function IsCircularLine(ByVal seriesViewType As Type) As Boolean
			Return (seriesViewType.IsSubclassOf(GetType(RadarLineSeriesView)) OrElse seriesViewType Is GetType(RadarLineSeriesView)) AndAlso ((Not seriesViewType.IsSubclassOf(GetType(RadarAreaSeriesView))) AndAlso seriesViewType IsNot GetType(RadarAreaSeriesView))
		End Function
		Private Shared Function IsCircularArea(ByVal seriesViewType As Type) As Boolean
			Return seriesViewType.IsSubclassOf(GetType(RadarAreaSeriesView)) OrElse seriesViewType Is GetType(RadarAreaSeriesView)
		End Function

		Public Shared Function GetRelativePath(ByVal name As String) As String
			name = "Data\" & name
			Dim path As String = System.Windows.Forms.Application.StartupPath
			Dim s As String = "\"
			For i As Integer = 0 To 10
				If System.IO.File.Exists(path & s & name) Then
					Return (path & s & name)
				Else
					s &= "..\"
				End If
			Next i
			path = Environment.CurrentDirectory
			s = "\"
			For i As Integer = 0 To 10
				If System.IO.File.Exists(path & s & name) Then
					Return (path & s & name)
				Else
					s &= "..\"
				End If
			Next i
			Return ""
		End Function
		Public Shared Sub SetConnectionString(ByVal oleDbConnection As System.Data.OleDb.OleDbConnection, ByVal path As String)
			oleDbConnection.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path)
		End Sub
		Public Shared Function GetSeriesAnimationTypes(ByVal viewType As ViewType) As List(Of Type)
			Dim fakeSeries = New Series("Fake Series", viewType)
			Dim seriesViewType As Type = fakeSeries.View.GetType()
			Dim seriesAnimationProperties As IEnumerable(Of PropertyInfo) = seriesViewType.GetProperties().Where(Function(propertyInfo) propertyInfo.Name = "SeriesAnimation") '"property" is a keyword in VB
			If seriesAnimationProperties IsNot Nothing AndAlso seriesAnimationProperties.Count() = 1 Then
				Dim baseSeriesAnimationType As Type = seriesAnimationProperties.First().PropertyType
				Return New List(Of Type)(GetNonAbstractSubclasses(baseSeriesAnimationType))
			End If
			Return New List(Of Type)()
		End Function
		Public Shared Function GetPointAnimationTypes(ByVal viewType As ViewType) As List(Of Type)
			Dim fakeSeries = New Series("Fake Series", viewType)
			Dim seriesViewType As Type = fakeSeries.View.GetType()
			Dim pointAnimationProperty As PropertyInfo = seriesViewType.GetProperty("SeriesPointAnimation")
			If pointAnimationProperty Is Nothing Then
				pointAnimationProperty = seriesViewType.GetProperty("Animation")
			End If
			If pointAnimationProperty IsNot Nothing AndAlso pointAnimationProperty.GetCustomAttribute(GetType(BrowsableAttribute)) Is Nothing Then
				Dim basePointAnimationType As Type = pointAnimationProperty.PropertyType
				Return New List(Of Type)(GetNonAbstractSubclasses(basePointAnimationType))
			End If
			Return New List(Of Type)()
		End Function
		Public Shared Function LoadDataTableFromXml(ByVal fileName As String, ByVal tableName As String) As DataTable
			Dim xmlStream As Stream = AssemblyHelper.GetEmbeddedResourceStream(GetType(ChartDemoBase).Assembly, fileName, False)
			Dim xmlDataSet As New DataSet()
			xmlDataSet.ReadXml(xmlStream)
			xmlStream.Close()
			Return xmlDataSet.Tables(tableName)
		End Function
	End Class


	Public NotInheritable Class PieExplodingHelper
		Private Sub New()
		End Sub
		Private Shared Function CreateFilter(ByVal mode As String) As SeriesPointFilter
			Return New SeriesPointFilter(SeriesPointKey.Argument, DataFilterCondition.Equal, mode)
		End Function
		Private Shared Sub ApplyFilterMode(ByVal view As PieSeriesViewBase, ByVal mode As String)
			view.ExplodedPointsFilters.Clear()
			view.ExplodedPointsFilters.Add(CreateFilter(mode))
			view.ExplodeMode = PieExplodeMode.UseFilters
		End Sub

		Public Const None As String = "None"
		Public Const All As String = "All"
		Public Const MinValue As String = "Min Value"
		Public Const MaxValue As String = "Max Value"
		Public Const Custom As String = "Custom"

		Public Shared Function CreateModeList(ByVal points As SeriesPointCollection, ByVal supportCustom As Boolean) As List(Of String)
			Dim list As New List(Of String)()
			list.Add(None)
			list.Add(All)
			list.Add(MinValue)
			list.Add(MaxValue)
			For Each point As SeriesPoint In points
				list.Add(point.Argument)
			Next point
			If supportCustom Then
				list.Add(Custom)
			End If
			Return list
		End Function
		Public Shared Sub ApplyMode(ByVal view As PieSeriesViewBase, ByVal mode As String)
			Select Case mode
				Case Custom
				Case None
					view.ExplodeMode = PieExplodeMode.None
				Case All
					view.ExplodeMode = PieExplodeMode.All
				Case MinValue
					view.ExplodeMode = PieExplodeMode.MinValue
				Case MaxValue
					view.ExplodeMode = PieExplodeMode.MaxValue
				Case Else
					ApplyFilterMode(view, mode)
			End Select
		End Sub
	End Class


	Public MustInherit Class ScatterFunctionCalculatorBase
		Private Const archimedeanSpiralIndex As Integer = 0
		Private Const polarRoseIndex As Integer = 1
		Private Const polarFoliumIndex As Integer = 2
		Private Const spiralIntervalsCount As Integer = 72
		Private Const roseIntervalsCount As Integer = 288
		Private Const foliumSegmentIntervalsCount As Integer = 30

		Private Const roseParameter As Double = 7.0 / 4.0
		Private Const foliumDistanceLimit As Double = 3.0

		Protected MustOverride Function NormalizeAngle(ByVal angle As Double) As Double
		Protected MustOverride Function ToRadian(ByVal angle As Double) As Double
		Protected MustOverride Function FromDegrees(ByVal angle As Double) As Double

		Private Function FilterPointsByRange(ByVal points As List(Of SeriesPoint), ByVal min As Double, ByVal max As Double) As List(Of SeriesPoint)
			Dim resultPoints As New List(Of SeriesPoint)()
			For Each point As SeriesPoint In points
				Dim pointValue As Double = point.Values(0)
				If pointValue <= max AndAlso pointValue >= min Then
					resultPoints.Add(point)
				End If
			Next point
			Return resultPoints
		End Function
		Private Sub CreatePolarFunctionPoints(ByVal minAngleDegree As Double, ByVal maxAngleDegree As Double, ByVal intervalsCount As Integer, ByVal [function] As Func(Of Double, Double), ByVal points As List(Of SeriesPoint))
			Dim minAngle As Double = FromDegrees(minAngleDegree)
			Dim maxAngle As Double = FromDegrees(maxAngleDegree)
			Dim angleStep As Double = (maxAngle - minAngle) / CDbl(intervalsCount)
			For pointIndex As Integer = 0 To intervalsCount
				Dim angle As Double = minAngle + pointIndex * angleStep
				Dim angleRadians As Double = ToRadian(angle)
				Dim distance As Double = [function](angleRadians)
				Dim normalAngle As Double = NormalizeAngle(angle)
				points.Add(New SeriesPoint(normalAngle, distance))
			Next pointIndex
		End Sub
		Private Function ArchimedeanSpiralFunction(ByVal angleRadians As Double) As Double
			Return angleRadians
		End Function
		Private Function PolarRoseFunction(ByVal angleRadians As Double) As Double
			Return Math.Max(0.0, Math.Sin(roseParameter * angleRadians))
		End Function
		Private Function PolarFoliumFunction(ByVal angleRadians As Double) As Double
			Dim sin As Double = Math.Sin(angleRadians)
			Dim cos As Double = Math.Cos(angleRadians)
			Return (3.0 * sin * cos) / (Math.Pow(sin, 3.0) + Math.Pow(cos, 3.0))
		End Function

		Public Function GenerateScatterFunctionPoints(ByVal index As Integer) As SeriesPoint()
			Dim points As New List(Of SeriesPoint)()
			Select Case index
				Case archimedeanSpiralIndex
					CreatePolarFunctionPoints(0.0, 720.0, spiralIntervalsCount, AddressOf ArchimedeanSpiralFunction, points)
				Case polarRoseIndex
					CreatePolarFunctionPoints(0.0, 1440.0, roseIntervalsCount, AddressOf PolarRoseFunction, points)
				Case polarFoliumIndex
					CreatePolarFunctionPoints(120.0, 180.0, foliumSegmentIntervalsCount, AddressOf PolarFoliumFunction, points)
					CreatePolarFunctionPoints(0.0, 90.0, foliumSegmentIntervalsCount, AddressOf PolarFoliumFunction, points)
					CreatePolarFunctionPoints(270.0, 330.0, foliumSegmentIntervalsCount, AddressOf PolarFoliumFunction, points)
					points = FilterPointsByRange(points, 0.0, foliumDistanceLimit)
			End Select
			Return points.ToArray()
		End Function
	End Class


	Public Class RadianScatterFunctionCalculator
		Inherits ScatterFunctionCalculatorBase
		Protected Overrides Function NormalizeAngle(ByVal angle As Double) As Double
			Return angle Mod (Math.PI * 2.0)
		End Function
		Protected Overrides Function ToRadian(ByVal angle As Double) As Double
			Return angle
		End Function
		Protected Overrides Function FromDegrees(ByVal angle As Double) As Double
			Return angle * Math.PI / 180.0
		End Function
	End Class


	Public Class DegreeScatterFunctionCalculator
		Inherits ScatterFunctionCalculatorBase
		Protected Overrides Function NormalizeAngle(ByVal angle As Double) As Double
			Return angle Mod 360
		End Function
		Protected Overrides Function ToRadian(ByVal angle As Double) As Double
			Return angle * Math.PI / 180.0
		End Function
		Protected Overrides Function FromDegrees(ByVal angle As Double) As Double
			Return angle
		End Function
	End Class


	Public Class FinancialPoint
		Private argument_Renamed As String
		Private dateTimeArgument_Renamed As DateTime
		Private highValue_Renamed As Double
		Private lowValue_Renamed As Double
		Private openValue_Renamed As Double
		Private closeValue_Renamed As Double

		Public Property Argument() As String
			Get
				Return argument_Renamed
			End Get
			Set(ByVal value As String)
				argument_Renamed = value
			End Set
		End Property
		Public Property DateTimeArgument() As DateTime
			Get
				Return dateTimeArgument_Renamed
			End Get
			Set(ByVal value As DateTime)
				dateTimeArgument_Renamed = value
			End Set
		End Property
		Public Property HighValue() As Double
			Get
				Return highValue_Renamed
			End Get
			Set(ByVal value As Double)
				highValue_Renamed = value
			End Set
		End Property
		Public Property LowValue() As Double
			Get
				Return lowValue_Renamed
			End Get
			Set(ByVal value As Double)
				lowValue_Renamed = value
			End Set
		End Property
		Public Property OpenValue() As Double
			Get
				Return openValue_Renamed
			End Get
			Set(ByVal value As Double)
				openValue_Renamed = value
			End Set
		End Property
		Public Property CloseValue() As Double
			Get
				Return closeValue_Renamed
			End Get
			Set(ByVal value As Double)
				closeValue_Renamed = value
			End Set
		End Property
	End Class

	Public NotInheritable Class CsvReader
		Private Sub New()
		End Sub
		Public Shared Function ReadFinancialData(ByVal fileName As String) As List(Of FinancialPoint)
			Dim longFileName As String = String.Empty
			Dim reader As StreamReader
			Dim dataSource = New List(Of FinancialPoint)()
			Dim stream As Stream = AssemblyHelper.GetEmbeddedResourceStream(GetType(ChartDemoBase).Assembly, fileName, False)
			Try
				reader = New StreamReader(stream)
				Do While Not reader.EndOfStream
					Dim line As String = reader.ReadLine()
					Dim values = line.Split(","c)
					Dim point = New FinancialPoint()
					point.DateTimeArgument = DateTime.ParseExact(values(0), "yyyy.MM.dd", Nothing)
					point.OpenValue = Double.Parse(values(1), CultureInfo.InvariantCulture)
					point.HighValue = Double.Parse(values(2), CultureInfo.InvariantCulture)
					point.LowValue = Double.Parse(values(3), CultureInfo.InvariantCulture)
					point.CloseValue = Double.Parse(values(4), CultureInfo.InvariantCulture)
					dataSource.Add(point)
				Loop
			Catch
				Throw New Exception("It's impossible to load " & fileName)
			End Try
			Return dataSource
		End Function
	End Class

	Public Class BubbleDataItem
		Private year_Renamed As DateTime
		Private budget_Renamed As Double
		Private grosses_Renamed As Double
		Private title_Renamed As String

		Public ReadOnly Property Year() As DateTime
			Get
				Return year_Renamed
			End Get
		End Property
		Public ReadOnly Property Budget() As Double
			Get
				Return budget_Renamed
			End Get
		End Property
		Public ReadOnly Property Grosses() As Double
			Get
				Return grosses_Renamed
			End Get
		End Property
		Public ReadOnly Property Title() As String
			Get
				Return title_Renamed
			End Get
		End Property

		Public Sub New(ByVal year As DateTime, ByVal budget As Double, ByVal grosses As Double, ByVal title As String)
			Me.year_Renamed = year
			Me.budget_Renamed = budget
			Me.grosses_Renamed = grosses
			Me.title_Renamed = title
		End Sub
	End Class

	Public NotInheritable Class BubbleData
		Private Sub New()
		End Sub
		Public Shared Function GetData() As List(Of BubbleDataItem)
			Return New List(Of BubbleDataItem) (New BubbleDataItem() {New BubbleDataItem(New DateTime(2007, 1, 1), 300, 0.963, "Pirates of the Caribbean: At World's End"), New BubbleDataItem(New DateTime(2008, 1, 1), 185, 1.004, "The Dark Knight"), New BubbleDataItem(New DateTime(2009, 1, 1), 237, 2.788, "Avatar"), New BubbleDataItem(New DateTime(2010, 1, 1), 200, 1.067, "Toy Story 3"), New BubbleDataItem(New DateTime(2011, 1, 1), 250, 1.341, "Harry Potter and the Deathly Hallows Part 2"), New BubbleDataItem(New DateTime(2012, 1, 1), 220, 1.519, "Marvel's The Avengers"), New BubbleDataItem(New DateTime(2013, 1, 1), 150, 1.276, "Frozen"), New BubbleDataItem(New DateTime(2014, 1, 1), 210, 1.104, "Transformers: Age of Extinction"), New BubbleDataItem(New DateTime(2015, 1, 1), 245, 2.068, "Star Wars: The Force Awakens"), New BubbleDataItem(New DateTime(2016, 1, 1), 250, 1.153, "Captain America: Civil War")})
		End Function
	End Class


	Public Class GDP
		Private privateYear As Integer
		Public Property Year() As Integer
			Get
				Return privateYear
			End Get
			Private Set(ByVal value As Integer)
				privateYear = value
			End Set
		End Property
		Private privateProduct As Decimal
		Public Property Product() As Decimal
			Get
				Return privateProduct
			End Get
			Private Set(ByVal value As Decimal)
				privateProduct = value
			End Set
		End Property

		Public Sub New(ByVal year As Integer, ByVal product As Decimal)
			Me.Year = year
			Me.Product = product
		End Sub
	End Class

	Public Class G7Member
		Public ReadOnly Property GDPin2015() As Decimal
			Get
				Return GDPs.First(Function(gdp) gdp.Year = 2015).Product
			End Get
		End Property
		Private privateCountryName As String
		Public Property CountryName() As String
			Get
				Return privateCountryName
			End Get
			Private Set(ByVal value As String)
				privateCountryName = value
			End Set
		End Property
		Private privateGDPs As List(Of GDP)
		Public Property GDPs() As List(Of GDP)
			Get
				Return privateGDPs
			End Get
			Private Set(ByVal value As List(Of GDP))
				privateGDPs = value
			End Set
		End Property
		Private privateColorNumberInPalette As Integer
		Public Property ColorNumberInPalette() As Integer
			Get
				Return privateColorNumberInPalette
			End Get
			Private Set(ByVal value As Integer)
				privateColorNumberInPalette = value
			End Set
		End Property

		Public Sub New(ByVal country As String, ByVal colorNumberInPalette As Integer)
			Me.CountryName = country
			Me.GDPs = New List(Of GDP)()
			Me.ColorNumberInPalette = colorNumberInPalette
		End Sub
	End Class

	Public Class GDPofG7
		Public Shared Function GetData() As IList
			Dim data As DataTable = Utils.LoadDataTableFromXml("GDPofG7.xml", "GDP")
			Return data.AsEnumerable().Where(Function(row) row.Field(Of Integer)("Year") >= 2010).Select(Function(row) New With {Key .Country = row.Field(Of String)("Country"), Key .Year = row.Field(Of Integer)("Year"), Key .Product = row.Field(Of Double)("Product")}).ToList()
		End Function
		Public Shared Function GetDataByMember() As List(Of G7Member)
			Dim countries As New List(Of G7Member)()
			Dim xmlStream As Stream = AssemblyHelper.GetEmbeddedResourceStream(GetType(ChartDemoBase).Assembly, "GDPofG7.xml", False)
			Dim document As New XmlDocument()
			document.Load(xmlStream)
			If document IsNot Nothing Then
				Dim elements As XmlNodeList = document.DocumentElement.GetElementsByTagName("GDP")
				For Each element As XmlNode In elements
					Dim country As String = element.ChildNodes(0).InnerText
					Dim year As Integer = Integer.Parse(element.ChildNodes(1).InnerText)
					Dim product As Decimal = Convert.ToDecimal(element.ChildNodes(2).InnerText, CultureInfo.InvariantCulture)
'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
					Dim currentG7Member As G7Member = countries.Find(Function(c) c.CountryName = country)
					If currentG7Member Is Nothing Then
						currentG7Member = New G7Member(country, countries.Count)
						countries.Add(currentG7Member)
					End If
					currentG7Member.GDPs.Add(New GDP(year, product))
				Next element
			End If
			xmlStream.Close()
			Return countries
		End Function
	End Class

	Public Class HPI
		Public Shared Function GetData() As DataTable
			Return Utils.LoadDataTableFromXml("HPI.xml", "CountryStatistics")
		End Function
	End Class

	Public Class DevAV
		Public Shared Function GetSales() As DataTable
			Dim prevYear As Integer = DateTime.Now.Year - 1
			Dim table As New DataTable()
			table.Columns.AddRange(New DataColumn() { New DataColumn("Year", GetType(Integer)), New DataColumn("Region", GetType(String)), New DataColumn("Sales", GetType(Decimal)) })

			table.Rows.Add(prevYear - 2, "Asia", 4.2372R)
			table.Rows.Add(prevYear - 2, "Australia", 1.7871R)
			table.Rows.Add(prevYear - 2, "Europe", 3.0884R)
			table.Rows.Add(prevYear - 2, "North America", 3.4855R)
			table.Rows.Add(prevYear - 2, "South America", 1.6027R)

			table.Rows.Add(prevYear - 1, "Asia", 4.7685R)
			table.Rows.Add(prevYear - 1, "Australia", 1.9576R)
			table.Rows.Add(prevYear - 1, "Europe", 3.3579R)
			table.Rows.Add(prevYear - 1, "North America", 3.7477R)
			table.Rows.Add(prevYear - 1, "South America", 1.8237R)

			table.Rows.Add(prevYear, "Asia", 5.2890R)
			table.Rows.Add(prevYear, "Australia", 2.2727R)
			table.Rows.Add(prevYear, "Europe", 3.7257R)
			table.Rows.Add(prevYear, "North America", 4.1825R)
			table.Rows.Add(prevYear, "South America", 2.1172R)

			Return table
		End Function
		Public Shared Function GetSalesMixByRegion() As DataTable
			Dim table As New DataTable()
			table.Columns.AddRange(New DataColumn() { New DataColumn("ProductCategory", GetType(String)), New DataColumn("Region", GetType(String)), New DataColumn("Sales", GetType(Decimal)) })

			table.Rows.Add("Video players", "Asia", 853R)
			table.Rows.Add("Video players", "Australia", 321R)
			table.Rows.Add("Video players", "Europe", 655R)
			table.Rows.Add("Video players", "North America", 1325R)
			table.Rows.Add("Video players", "South America", 653R)

			table.Rows.Add("Automation", "Asia", 172R)
			table.Rows.Add("Automation", "Australia", 255R)
			table.Rows.Add("Automation", "Europe", 981R)
			table.Rows.Add("Automation", "North America", 963R)
			table.Rows.Add("Automation", "South America", 123R)

			table.Rows.Add("Monitors", "Asia", 1011R)
			table.Rows.Add("Monitors", "Australia", 359R)
			table.Rows.Add("Monitors", "Europe", 721R)
			table.Rows.Add("Monitors", "North America", 565R)
			table.Rows.Add("Monitors", "South America", 532R)

			table.Rows.Add("Projectors", "Asia", 998R)
			table.Rows.Add("Projectors", "Australia", 222R)
			table.Rows.Add("Projectors", "Europe", 865R)
			table.Rows.Add("Projectors", "North America", 787R)
			table.Rows.Add("Projectors", "South America", 332R)

			table.Rows.Add("Televisions", "Asia", 1356R)
			table.Rows.Add("Televisions", "Australia", 232R)
			table.Rows.Add("Televisions", "Europe", 1323R)
			table.Rows.Add("Televisions", "North America", 1125R)
			table.Rows.Add("Televisions", "South America", 865R)

			Return table
		End Function
		Public Shared Function GetBranchesSales() As DataTable
			Dim lastYear As Integer = DateTime.Now.Year - 1
			Dim table As New DataTable()
			table.Columns.AddRange(New DataColumn() { New DataColumn("Year", GetType(DateTime)), New DataColumn("Company", GetType(String)), New DataColumn("Sales", GetType(Decimal)) })

			table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "DevAV North", 1.010)
			table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "DevAV Center", 3.032)
			table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "DevAV South", 1.31)

			table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "DevAV North", 1.512)
			table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "DevAV Center", 3.050)
			table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "DevAV South", 1.34)

			table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "DevAV North", 1.723)
			table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "DevAV West", 0.005)
			table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "DevAV Center", 3.054)
			table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "DevAV South", 1.30)

			table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "DevAV West", 0.31)
			table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "DevAV North", 2.001)
			table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "DevAV Center", 2.975)
			table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "DevAV South", 1.283)

			table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "DevAV West", 0.41)
			table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "DevAV North", 2.612)
			table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "DevAV Center", 2.066)
			table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "DevAV South", 0.88)

			table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "DevAV West", 0.95)
			table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "DevAV North", 2.666)
			table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "DevAV Center", 2.078)
			table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "DevAV South", 1.09)

			table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "DevAV West", 1.53)
			table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "DevAV North", 3.665)
			table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "DevAV Center", 3.888)
			table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "DevAV South", 1.01)

			table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV East", 0.003)
			table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV West", 1.75)
			table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV North", 3.555)
			table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV Center", 3.008)
			table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV South", 1.11)

			table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV East", 0.32)
			table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV West", 1.31)
			table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV North", 3.485)
			table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV Center", 3.088)
			table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV South", 1.12)

			table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV East", 0.51)
			table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV West", 1.31)
			table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV North", 3.747)
			table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV Center", 3.357)
			table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV South", 1.12)

			table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV East", 1.71)
			table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV West", 1.22)
			table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV North", 4.182)
			table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV Center", 3.725)
			table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV South", 1.111)

			Return table
		End Function
		Public Shared Function GetSalesByLast10Years() As DataTable
			Dim lastYear As Integer = DateTime.Now.Year - 1
			Dim table As New DataTable()
			table.Columns.AddRange(New DataColumn() { New DataColumn("Year", GetType(DateTime)), New DataColumn("Region", GetType(String)), New DataColumn("Sales", GetType(Decimal)) })

			table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "North America", 3.010D)
			table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "Europe", 3.032D)
			table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "Australia", 1.31D)

			table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "North America", 3.212D)
			table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "Europe", 3.050D)
			table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "Australia", 1.64D)

			table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "North America", 3.223D)
			table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "Europe", 3.054D)
			table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "Australia", 1.70D)

			table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "North America", 3.001D)
			table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "Europe", 2.775D)
			table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "Australia", 1.083D)

			table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "North America", 2.612D)
			table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "Europe", 2.066D)
			table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "Australia", 0.88D)

			table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "North America", 2.666D)
			table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "Europe", 2.078D)
			table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "Australia", 1.09D)

			table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "North America", 3.665D)
			table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "Europe", 3.888D)
			table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "Australia", 2.01D)

			table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "North America", 3.555D)
			table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "Europe", 3.008D)
			table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "Australia", 1.85D)

			table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "North America", 3.485D)
			table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "Europe", 3.088D)
			table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "Australia", 1.78D)

			table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "North America", 3.747D)
			table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "Europe", 3.357D)
			table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "Australia", 1.957D)

			table.Rows.Add(New DateTime(lastYear, 12, 31), "North America", 4.182D)
			table.Rows.Add(New DateTime(lastYear, 12, 31), "Europe", 3.725D)
			table.Rows.Add(New DateTime(lastYear, 12, 31), "Australia", 2.272D)

			Return table
		End Function
		Public Shared Function GetOutsideVendorCosts() As DataTable
			Dim lastYear As Integer = DateTime.Now.Year - 1
			Dim table As New DataTable()
			table.Columns.AddRange(New DataColumn() { New DataColumn("Year", GetType(DateTime)), New DataColumn("Company", GetType(String)), New DataColumn("Costs", GetType(Decimal)) })

			table.Rows.Add(New DateTime(lastYear - 6, 1, 1), "DevAV North", 362.5D)
			table.Rows.Add(New DateTime(lastYear - 5, 1, 1), "DevAV North", 348.4D)
			table.Rows.Add(New DateTime(lastYear - 4, 1, 1), "DevAV North", 279.0D)
			table.Rows.Add(New DateTime(lastYear - 3, 1, 1), "DevAV North", 230.9D)
			table.Rows.Add(New DateTime(lastYear - 2, 1, 1), "DevAV North", 203.5D)
			table.Rows.Add(New DateTime(lastYear - 1, 1, 1), "DevAV North", 197.1D)

			table.Rows.Add(New DateTime(lastYear - 6, 1, 1), "DevAV South", 277.0D)
			table.Rows.Add(New DateTime(lastYear - 5, 1, 1), "DevAV South", 328.5D)
			table.Rows.Add(New DateTime(lastYear - 4, 1, 1), "DevAV South", 297.0D)
			table.Rows.Add(New DateTime(lastYear - 3, 1, 1), "DevAV South", 255.3D)
			table.Rows.Add(New DateTime(lastYear - 2, 1, 1), "DevAV South", 173.5D)
			table.Rows.Add(New DateTime(lastYear - 1, 1, 1), "DevAV South", 131.8D)

			Return table
		End Function
	End Class

	Public Class AgeStructure
		Private Shared ageStructureTable_Renamed As DataTable
		Private Shared ReadOnly Property AgeStructureTable() As DataTable
			Get
				If ageStructureTable_Renamed Is Nothing Then
					ageStructureTable_Renamed = LoadPopulationAgeStructure()
				End If
				Return ageStructureTable_Renamed
			End Get
		End Property

		Private Shared Function LoadPopulationAgeStructure() As DataTable ' data for end of 2016
			Return Utils.LoadDataTableFromXml("Population.xml", "Population")
		End Function
		Public Shared Function GetDataByAgeAndGender() As IList
			Return AgeStructureTable.AsEnumerable().Select(Function(row) New With {Key .GenderAge = New GenderAgeInfo(row.Field(Of String)("Gender"), row.Field(Of String)("Age")), Key .Country = row.Field(Of String)("Country"), Key .Population = row.Field(Of Long)("Population")}).ToList()
		End Function
		Public Shared Function GetDataByMaleAge() As IList
			Return AgeStructureTable.AsEnumerable().Where(Function(row) row.Field(Of String)("Gender") = "Male").Select(Function(row) New With {Key .Age = row.Field(Of String)("Age"), Key .Country = row.Field(Of String)("Country"), Key .Population = row.Field(Of Long)("Population")}).ToList()
		End Function
		Public Shared Function GetDataByFemaleAge() As IList
			Return AgeStructureTable.AsEnumerable().Where(Function(row) row.Field(Of String)("Gender") = "Female").Select(Function(row) New With {Key .Age = row.Field(Of String)("Age"), Key .Country = row.Field(Of String)("Country"), Key .Population = row.Field(Of Long)("Population")}).ToList()
		End Function
		Public Shared Function GetPopulationAgeStructure() As IList
			Return AgeStructureTable.AsEnumerable().Select(Function(row) New AgePopulation(row.Field(Of String)("Country"), row.Field(Of String)("Age"), row.Field(Of String)("Gender"), row.Field(Of Long)("Population"))).ToList()
		End Function
	End Class
	Public Structure GenderAgeInfo
		Private gender_Renamed As String
		Private age_Renamed As String

		Public ReadOnly Property Gender() As String
			Get
				Return gender_Renamed
			End Get
		End Property
		Public ReadOnly Property Age() As String
			Get
				Return age_Renamed
			End Get
		End Property

		Public Sub New(ByVal gender As String, ByVal age As String)
			Me.gender_Renamed = gender
			Me.age_Renamed = age
		End Sub
		Public Overrides Function ToString() As String
			Return gender_Renamed & ": " & age_Renamed
		End Function
	End Structure
	Public Class AgePopulation
		Private name_Renamed As String
		Private age_Renamed As String
		Private gender_Renamed As String
		Private population_Renamed As Double

		Public ReadOnly Property Name() As String
			Get
				Return name_Renamed
			End Get
		End Property
		Public ReadOnly Property Age() As String
			Get
				Return age_Renamed
			End Get
		End Property
		Public ReadOnly Property Gender() As String
			Get
				Return gender_Renamed
			End Get
		End Property
		Public ReadOnly Property GenderAgeKey() As String
			Get
				Return gender_Renamed.ToString() & ": " & age_Renamed
			End Get
		End Property
		Public ReadOnly Property CountryAgeKey() As String
			Get
				Return name_Renamed & ": " & age_Renamed
			End Get
		End Property
		Public ReadOnly Property CountryGenderKey() As String
			Get
				Return name_Renamed & ": " & gender_Renamed.ToString()
			End Get
		End Property
		Public ReadOnly Property Population() As Double
			Get
				Return population_Renamed
			End Get
		End Property

		Public Sub New(ByVal name As String, ByVal age As String, ByVal gender As String, ByVal population As Double)
			Me.name_Renamed = name
			Me.age_Renamed = age
			Me.gender_Renamed = gender
			Me.population_Renamed = population
		End Sub
	End Class

	Public Class MarketPrices
		Public Shared Function GetGoogleStockPrices() As DataTable
			Return Utils.LoadDataTableFromXml("GoogleStock.xml", "StockPrice")
		End Function
		Public Shared Function GetAppleStockPrices() As DataTable
			Return Utils.LoadDataTableFromXml("AppleStock.xml", "StockPrice")
		End Function
	End Class

	Public Class SourceOfEnergy
		Public Shared Function GetEuropeBrentPrices() As DataTable
			Dim table As New DataTable("Europe Brent")
			table.Columns.AddRange(New DataColumn() { New DataColumn("Date", GetType(DateTime)), New DataColumn("Min", GetType(Single)), New DataColumn("Max", GetType(Single)) })
			table.Rows.Add(New DateTime(2015, 01, 1), 45.13, 55.38)
			table.Rows.Add(New DateTime(2015, 02, 1), 51.74, 61.89)
			table.Rows.Add(New DateTime(2015, 03, 1), 52.00, 61.18)
			table.Rows.Add(New DateTime(2015, 04, 1), 55.73, 63.97)
			table.Rows.Add(New DateTime(2015, 05, 1), 60.12, 66.33)
			table.Rows.Add(New DateTime(2015, 06, 1), 59.03, 64.68)
			table.Rows.Add(New DateTime(2015, 07, 1), 53.29, 61.73)
			table.Rows.Add(New DateTime(2015, 08, 1), 41.59, 49.49)
			table.Rows.Add(New DateTime(2015, 09, 1), 45.87, 50.41)
			table.Rows.Add(New DateTime(2015, 10, 1), 45.54, 52.13)
			table.Rows.Add(New DateTime(2015, 11, 1), 40.28, 48.00)
			table.Rows.Add(New DateTime(2015, 12, 1), 35.26, 42.97)
			Return table
		End Function
		Public Shared Function GetOkWtiPrices() As DataTable
			Dim table As New DataTable("OK WTI")
			table.Columns.AddRange(New DataColumn() { New DataColumn("Date", GetType(DateTime)), New DataColumn("Min", GetType(Single)), New DataColumn("Max", GetType(Single)) })
			table.Rows.Add(New DateTime(2015, 01, 1), 44.08, 52.72)
			table.Rows.Add(New DateTime(2015, 02, 1), 47.65, 49.84)
			table.Rows.Add(New DateTime(2015, 03, 1), 43.39, 51.53)
			table.Rows.Add(New DateTime(2015, 04, 1), 49.13, 59.62)
			table.Rows.Add(New DateTime(2015, 05, 1), 57.29, 60.93)
			table.Rows.Add(New DateTime(2015, 06, 1), 58.00, 61.36)
			table.Rows.Add(New DateTime(2015, 07, 1), 47.11, 56.94)
			table.Rows.Add(New DateTime(2015, 08, 1), 38.22, 49.20)
			table.Rows.Add(New DateTime(2015, 09, 1), 44.07, 47.12)
			table.Rows.Add(New DateTime(2015, 10, 1), 43.19, 49.67)
			table.Rows.Add(New DateTime(2015, 11, 1), 39.27, 47.88)
			table.Rows.Add(New DateTime(2015, 12, 1), 34.55, 41.08)
			Return table
		End Function
		Public Shared Function GetGasolinePrices() As DataTable
			Dim table As New DataTable("Gasoline")
			table.Columns.AddRange(New DataColumn() { New DataColumn("Date", GetType(DateTime)), New DataColumn("Price", GetType(Single)) })
			table.Rows.Add(New DateTime(2015, 01, 1), 2.208)
			table.Rows.Add(New DateTime(2015, 02, 1), 2.301)
			table.Rows.Add(New DateTime(2015, 03, 1), 2.546)
			table.Rows.Add(New DateTime(2015, 04, 1), 2.555)
			table.Rows.Add(New DateTime(2015, 05, 1), 2.802)
			table.Rows.Add(New DateTime(2015, 06, 1), 2.885)
			table.Rows.Add(New DateTime(2015, 07, 1), 2.880)
			table.Rows.Add(New DateTime(2015, 08, 1), 2.726)
			table.Rows.Add(New DateTime(2015, 09, 1), 2.462)
			table.Rows.Add(New DateTime(2015, 10, 1), 2.387)
			table.Rows.Add(New DateTime(2015, 11, 1), 2.260)
			table.Rows.Add(New DateTime(2015, 12, 1), 2.144)
			Return table
		End Function
		Public Shared Function GetFuelPrices() As DataTable
			Dim table As New DataTable()
			table.Columns.AddRange(New DataColumn() { New DataColumn("Date", GetType(DateTime)), New DataColumn("Price", GetType(Decimal)) })
			table.Rows.Add(New DateTime(2016, 1, 1, 0, 0, 0), 2.143D)
			table.Rows.Add(New DateTime(2016, 2, 1, 0, 0, 0), 1.998D)
			table.Rows.Add(New DateTime(2016, 3, 1, 0, 0, 0), 2.090D)
			table.Rows.Add(New DateTime(2016, 4, 1, 0, 0, 0), 2.152D)
			table.Rows.Add(New DateTime(2016, 5, 1, 0, 0, 0), 2.315D)
			table.Rows.Add(New DateTime(2016, 6, 1, 0, 0, 0), 2.423D)
			table.Rows.Add(New DateTime(2016, 7, 1, 0, 0, 0), 2.405D)
			table.Rows.Add(New DateTime(2016, 8, 1, 0, 0, 0), 2.351D)
			table.Rows.Add(New DateTime(2016, 9, 1, 0, 0, 0), 2.394D)
			table.Rows.Add(New DateTime(2016, 10, 1, 0, 0, 0), 2.454D)
			table.Rows.Add(New DateTime(2016, 11, 1, 0, 0, 0), 2.439D)
			table.Rows.Add(New DateTime(2016, 12, 1, 0, 0, 0), 2.510D)
			Return table
		End Function
		Public Shared Function GetCoalProduction() As DataTable
			Dim table As New DataTable()
			table.Columns.AddRange(New DataColumn() { New DataColumn("Date", GetType(DateTime)), New DataColumn("South Africa", GetType(Decimal)), New DataColumn("Poland", GetType(Decimal)), New DataColumn("Russia", GetType(Decimal)) })
			table.Rows.Add(New DateTime(2015, 12, 31, 0, 0, 0), 252.099, 135.523, 373.300)
			table.Rows.Add(New DateTime(2014, 12, 31, 0, 0, 0), 261.523, 137.148, 357.396)
			table.Rows.Add(New DateTime(2013, 12, 31, 0, 0, 0), 256.562, 142.906, 355.231)
			table.Rows.Add(New DateTime(2012, 12, 31, 0, 0, 0), 258.575, 144.093, 358.300)
			table.Rows.Add(New DateTime(2011, 12, 31, 0, 0, 0), 252.756, 139.289, 337.400)
			table.Rows.Add(New DateTime(2010, 12, 31, 0, 0, 0), 254.521, 133.238, 322.920)
			table.Rows.Add(New DateTime(2009, 12, 31, 0, 0, 0), 247.820, 135.172, 302.382)
			table.Rows.Add(New DateTime(2008, 12, 31, 0, 0, 0), 252.213, 144.013, 330.182)
			table.Rows.Add(New DateTime(2007, 12, 31, 0, 0, 0), 247.666, 145.850, 315.570)
			table.Rows.Add(New DateTime(2006, 12, 31, 0, 0, 0), 244.774, 156.065, 311.370)
			table.Rows.Add(New DateTime(2005, 12, 31, 0, 0, 0), 244.985, 159.540, 299.970)
			table.Rows.Add(New DateTime(2004, 12, 31, 0, 0, 0), 242.821, 161.284, 284.398)
			table.Rows.Add(New DateTime(2003, 12, 31, 0, 0, 0), 238.751, 163.790, 278.746)
			table.Rows.Add(New DateTime(2002, 12, 31, 0, 0, 0), 220.212, 161.920, 258.912)
			table.Rows.Add(New DateTime(2001, 12, 31, 0, 0, 0), 223.560, 163.540, 274.001)
			table.Rows.Add(New DateTime(2000, 12, 31, 0, 0, 0), 224.199, 162.820, 262.081)
			table.Rows.Add(New DateTime(1999, 12, 31, 0, 0, 0), 223.514, 172.730, 255.050)
			table.Rows.Add(New DateTime(1998, 12, 31, 0, 0, 0), 222.976, 178.550, 235.383)
			table.Rows.Add(New DateTime(1997, 12, 31, 0, 0, 0), 220.072, 200.930, 250.617)
			table.Rows.Add(New DateTime(1996, 12, 31, 0, 0, 0), 206.362, 201.720, 262.052)
			table.Rows.Add(New DateTime(1995, 12, 31, 0, 0, 0), 206.210, 200.720, 269.574)
			table.Rows.Add(New DateTime(1994, 12, 31, 0, 0, 0), 195.805, 200.700, 278.304)
			table.Rows.Add(New DateTime(1993, 12, 31, 0, 0, 0), 188.214, 198.580, 311.862)
			table.Rows.Add(New DateTime(1992, 12, 31, 0, 0, 0), 184.045, 198.380, 349.004)
			table.Rows.Add(New DateTime(1991, 12, 31, 0, 0, 0), 178.390, 209.790, 362.235)
			table.Rows.Add(New DateTime(1990, 12, 31, 0, 0, 0), 174.780, 215.320, 405.194)
			Return table
		End Function
		Public Shared Function GetGasPrices() As DataTable
			Return Utils.LoadDataTableFromXml("GasPrices.xml", "GasPrice")
		End Function
	End Class

	Public Class PowerConsumption
		Public Shared Function GetData() As DataTable
			Dim table As New DataTable()
			table.Columns.AddRange(New DataColumn() { New DataColumn("Branch", GetType(String)), New DataColumn("Time", GetType(DateTime)), New DataColumn("Power", GetType(Double)) })

			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 7, 0, 0), 429)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 8, 0, 0), 432)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 9, 0, 0), 301)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 10, 0, 0), 307)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 11, 0, 0), 310)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 12, 0, 0), 380)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 13, 0, 0), 384)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 14, 0, 0), 398)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 15, 0, 0), 379)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 16, 0, 0), 220)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 17, 0, 0), 321)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 18, 0, 0), 341)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 19, 0, 0), 368)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 20, 0, 0), 557)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 21, 0, 0), 523)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 22, 0, 0), 501)
			table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 23, 0, 0), 443)

			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 7, 0, 0), 260)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 8, 0, 0), 287)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 9, 0, 0), 285)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 10, 0, 0), 281)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 11, 0, 0), 294)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 12, 0, 0), 303)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 13, 0, 0), 325)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 14, 0, 0), 336)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 15, 0, 0), 325)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 16, 0, 0), 186)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 17, 0, 0), 420)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 18, 0, 0), 455)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 19, 0, 0), 481)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 20, 0, 0), 487)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 21, 0, 0), 490)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 22, 0, 0), 467)
			table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 23, 0, 0), 409)

			Return table
		End Function
	End Class
End Namespace
