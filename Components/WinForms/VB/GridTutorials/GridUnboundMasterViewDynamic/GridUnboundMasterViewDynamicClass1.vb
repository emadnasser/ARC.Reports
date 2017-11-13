Imports Microsoft.VisualBasic
Imports System
Imports System.Collections

Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Class GridUnboundMasterViewDynamicRecord
		Private fName As String

		Public Property Name() As String
			Get
				Return fName
			End Get
			Set
				fName = Value
			End Set
		End Property

		Public Sub New(ByVal fName As String)
			Me.fName = fName
		End Sub
	End Class
	Public Class ChildRecordsProductsDynamic
		Inherits ArrayList
		Public Sub New()
			Add(New ChildRecordProductDynamic("Grandma's Boysenberry Spread", 25.00, 120, 0, 25))
			Add(New ChildRecordProductDynamic("Ikura", 31.00, 1, 0, 0))
			Add(New ChildRecordProductDynamic("Tofu", 23.25, 35, 0, 0))
			Add(New ChildRecordProductDynamic("Sir Rodney's Marmalade", 81.00, 40, 0, 0))
			Add(New ChildRecordProductDynamic("Ipoh Coffee", 46.00, 17, 10, 25))
		End Sub
	End Class
	Public Class ChildRecordsCustomersDynamic
		Inherits ArrayList
		Public Sub New()
			Add(New ChildRecordCustomerDynamic("Thomas Hardy", "120 Hanover Sq.", False))
			Add(New ChildRecordCustomerDynamic("Hanna Moos", "Forsterstr. 57", True))
			Add(New ChildRecordCustomerDynamic("Ann Devon", "35 King George", False))
			Add(New ChildRecordCustomerDynamic("Roland Mendel", "Kirchgasse 6", True))
		End Sub
	End Class
	Public Class ChildRecordsShippersDynamic
		Inherits ArrayList
		Public Sub New()
			Add(New ChildRecordShipperDynamic("Speedy Express", "(503) 555-9831"))
			Add(New ChildRecordShipperDynamic("United Package", "(503) 555-3199"))
			Add(New ChildRecordShipperDynamic("Federal Shipping", "(503) 555-9931"))
		End Sub
	End Class
	Public Class ChildRecordShipperDynamic
		Private fName As String
		Private fPhone As String

		Public Property CompanyName() As String
			Get
				Return fName
			End Get
			Set
				fName = Value
			End Set
		End Property

		Public Property Phone() As String
			Get
				Return fPhone
			End Get
			Set
				fPhone = Value
			End Set
		End Property

		Public Sub New(ByVal fName As String, ByVal fPhone As String)
			Me.fName = fName
			Me.fPhone = fPhone
		End Sub
	End Class
	Public Class ChildRecordCustomerDynamic
		Private fName As String
		Private fAddress As String
		Private fHasDiscount As Boolean

		Public Property ContactName() As String
			Get
				Return fName
			End Get
			Set
				fName = Value
			End Set
		End Property

		Public Property Address() As String
			Get
				Return fAddress
			End Get
			Set
				fAddress = Value
			End Set
		End Property

		Public Property HasDiscount() As Boolean
			Get
				Return fHasDiscount
			End Get
			Set
				fHasDiscount = Value
			End Set
		End Property

		Public Sub New(ByVal fName As String, ByVal fAddress As String, ByVal fHasDiscount As Boolean)
			Me.fName = fName
			Me.fAddress = fAddress
			Me.fHasDiscount = fHasDiscount
		End Sub
	End Class
	Public Class ChildRecordProductDynamic
		Private fName As String
		Private fPrice As Double
		Private fUnitsInStock As Integer
		Private fUnitsOnOrder As Integer
		Private fLevel As Integer

		Public Property ProductName() As String
			Get
				Return fName
			End Get
			Set
				fName = Value
			End Set
		End Property

		Public Property UnitPrice() As Double
			Get
				Return fPrice
			End Get
			Set
				fPrice = Value
			End Set
		End Property

		Public Property UnitsInStock() As Integer
			Get
				Return fUnitsInStock
			End Get
			Set
				fUnitsInStock = Value
			End Set
		End Property

		Public Property UnitsOnOrder() As Integer
			Get
				Return fUnitsOnOrder
			End Get
			Set
				fUnitsOnOrder = Value
			End Set
		End Property

		Public Property ReorderLevel() As Integer
			Get
				Return fLevel
			End Get
			Set
				fLevel = Value
			End Set
		End Property

		Public Sub New(ByVal fName As String, ByVal fPrice As Double, ByVal fUnitsInStock As Integer, ByVal fUnitsOnOrder As Integer, ByVal fLevel As Integer)
			Me.fName = fName
			Me.fPrice = fPrice
			Me.fUnitsInStock = fUnitsInStock
			Me.fUnitsOnOrder = fUnitsOnOrder
			Me.fLevel = fLevel
		End Sub
	End Class
End Namespace
