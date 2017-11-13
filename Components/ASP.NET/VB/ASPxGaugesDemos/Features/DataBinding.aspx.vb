Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports System.Xml
Imports System.Xml.XPath
Imports DevExpress.Web
Imports DevExpress.XtraGauges.Core.Model

Partial Public Class DataBindingPage
	Inherits Page
	Private carPropLimits As Car
	Private carsCore As IList(Of Car)
	'
	Protected ReadOnly Property Cars() As IList(Of Car)
		Get
			If carsCore Is Nothing Then
				carsCore = LoadCars()
			End If
			Return carsCore
		End Get
	End Property
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim firstCar As ASPxComboBox = GetCombo("firstCarID")
			Dim secondCar As ASPxComboBox = GetCombo("secondCarID")
			If Cars.Count > 0 Then
				For Each car As Car In Cars
					firstCar.Items.Add(New ListEditItem(car.Name, car.ID))
					secondCar.Items.Add(New ListEditItem(car.Name, car.ID))
				Next car
				firstCar.Text = Cars(0).Name
				secondCar.Text = Cars(1).Name
			End If
		End If
		If (Not IsCallback) Then
			cGauge1.Labels("criteria").Text = CStr(criteria.Value)
			gaugeControl.DataBind()
		End If
	End Sub
	Protected Sub OnGaugeCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		cGauge1.Labels("criteria").Text = CStr(criteria.Value)
		gaugeControl.DataBind()
	End Sub
	Protected Sub OnScale1DataBinding(ByVal sender As Object, ByVal e As EventArgs)
		UpdateScale(CType(sender, ArcScale), GetCarID("firstCarID"), GetCriteria("criteria"))
	End Sub
	Protected Sub OnScale2DataBinding(ByVal sender As Object, ByVal e As EventArgs)
		UpdateScale(CType(sender, ArcScale), GetCarID("secondCarID"), GetCriteria("criteria"))
	End Sub
	Private Sub UpdateScale(ByVal scale As ArcScale, ByVal id As Integer, ByVal criteria As String)
		If Cars.Count > 0 AndAlso id <= Cars.Count Then
			Dim car As Car = CarsExtension.GetCarByID(Cars, id)
			Dim maxValue As Single = CSng(CarsExtension.GetCarProperty(carPropLimits, criteria))
			scale.MaxValue = maxValue
			scale.MinValue = If((maxValue = 7), 1, 0)
			scale.Value = CSng(CarsExtension.GetCarProperty(car, criteria))
		End If
	End Sub
	Private Function GetCarID(ByVal comboID As String) As Integer
		Dim firstCar As ASPxComboBox = GetCombo(comboID)
		Dim id As Integer = 0
		Integer.TryParse(CStr(firstCar.Value), id)
		Return id
	End Function
	Private Function GetCriteria(ByVal comboID As String) As String
		Dim criteria As ASPxComboBox = GetCombo(comboID)
		Return CStr(criteria.Value)
	End Function
	Protected Function LoadCars() As List(Of Car)
		Dim cars As New List(Of Car)()
		Dim carIterator As XPathNodeIterator = GetCarsIterator()

		Dim maxLiter As Single = 0
		Dim maxMPGCity As Single = 0
		Dim maxMPGHighway As Single = 0
		Dim maxHP As Single = 0
		Dim maxCyl As Integer = 0
		Do While carIterator.MoveNext()
			Dim carNodeNavigator As XPathNavigator = carIterator.Current.Clone()
			Dim id As Integer = carNodeNavigator.SelectSingleNode("ID").ValueAsInt
			Dim displayName As String = String.Format("{0} {1}", carNodeNavigator.SelectSingleNode("Trademark").Value, carNodeNavigator.SelectSingleNode("Model").Value)
			Dim liter As Single = CSng(carNodeNavigator.SelectSingleNode("Liter").ValueAsDouble)
			Dim mpgCity As Single = CSng(carNodeNavigator.SelectSingleNode("MPG_x0020_City").ValueAsInt)
			Dim mpgHighway As Single = CSng(carNodeNavigator.SelectSingleNode("MPG_x0020_Highway").ValueAsInt)
			Dim hp As Single = CSng(carNodeNavigator.SelectSingleNode("HP").ValueAsDouble)
			Dim cyl As Integer = carNodeNavigator.SelectSingleNode("Cyl").ValueAsInt
			cars.Add(New Car(id, displayName, cyl, hp, liter, mpgCity, mpgHighway))
			maxLiter = Math.Max(liter, maxLiter)
			maxMPGCity = Math.Max(mpgCity, maxMPGCity)
			maxMPGHighway = Math.Max(mpgHighway, maxMPGHighway)
			maxHP = Math.Max(hp, maxHP)
			maxCyl = Math.Max(cyl, maxCyl)
		Loop
		carPropLimits = New Car(-1, "Limits", CInt(Fix(CorrectLimit(maxCyl))), CorrectLimit(maxHP), CorrectLimit(maxLiter), CorrectLimit(maxMPGCity), CorrectLimit(maxMPGHighway))
		Return cars
	End Function
	Private Function CorrectLimit(ByVal limit As Single) As Single
		Dim limits() As Integer = { 7, 12, 36, 360 }
		For i As Integer = 0 To limits.Length - 1
			If limit < limits(i) Then
				Return limits(i)
			End If
		Next i
		Return limit
	End Function
	Private Function GetCombo(ByVal id As String) As ASPxComboBox
		Return TryCast(ASPxRoundPanel1.FindControl(id), ASPxComboBox)
	End Function
	Private Function GetXPathNavigator() As XPathNavigator
		Dim doc As XmlDocument = carsDS.GetXmlDocument()
		Return doc.CreateNavigator()
	End Function
	Private Function GetCarsIterator() As XPathNodeIterator
		Dim navigator As XPathNavigator = GetXPathNavigator()
		Return navigator.Select(GetCarsQuery())
	End Function
	Private Function GetCarsQuery() As XPathExpression
		Return XPathExpression.Compile("//Cars")
	End Function

	Public Class Car
		Private nameCore As String
		Private idCore As Integer
		Private cylCore As Integer
		Private hpCore As Single
		Private literCore As Single
		Private mpgCityCore As Single
		Private mpgHighwayCore As Single

		Public Sub New(ByVal id As Integer, ByVal name As String, ByVal cyl As Integer, ByVal hp As Single, ByVal liter As Single, ByVal mpgCity As Single, ByVal mpgHighWay As Single)
			idCore = id
			nameCore = name
			cylCore = cyl
			hpCore = hp
			literCore = liter
			mpgCityCore = mpgCity
			mpgHighwayCore = mpgHighWay
		End Sub
		Public ReadOnly Property ID() As Integer
			Get
				Return idCore
			End Get
		End Property
		Public ReadOnly Property Name() As String
			Get
				Return nameCore
			End Get
		End Property
		Public ReadOnly Property Cyl() As Single
			Get
				Return cylCore
			End Get
		End Property
		Public ReadOnly Property HP() As Single
			Get
				Return hpCore
			End Get
		End Property
		Public ReadOnly Property MPG_City() As Single
			Get
				Return mpgCityCore
			End Get
		End Property
		Public ReadOnly Property MPG_Highway() As Single
			Get
				Return mpgHighwayCore
			End Get
		End Property
		Public ReadOnly Property Liter() As Single
			Get
				Return literCore
			End Get
		End Property
	End Class
	Public NotInheritable Class CarsExtension
		Private Sub New()
		End Sub
		Public Shared Function GetCarByID(ByVal list As IEnumerable(Of Car), ByVal id As Integer) As Car
			Dim result As Car = Nothing
			For Each c As Car In list
				If c.ID = id Then
					Return c
				End If
			Next c
			Return result
		End Function
		Public Shared Function GetCarProperty(ByVal car As Car, ByVal propName As String) As Object
			Select Case propName
				Case "Cylinders"
					Return car.Cyl
				Case "HP"
					Return car.HP
				Case "Liter"
					Return car.Liter
				Case "MPG City"
					Return car.MPG_City
				Case "MPG Highway"
					Return car.MPG_Highway
				Case Else
					Return car.Name
			End Select
		End Function
	End Class
End Class
