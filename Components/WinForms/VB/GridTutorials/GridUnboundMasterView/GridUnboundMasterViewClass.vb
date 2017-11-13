Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports DevExpress.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	'<gridControl1>
	Public Class NestedRecords
		Inherits ArrayList
		Public Sub New()
			Add(New NestedRecord("Customers", New ChildRecordsCustomers()))
			Add(New NestedRecord("Products", New ChildRecordsProducts()))
			Add(New NestedRecord("Shippers", New ChildRecordsShippers()))
		End Sub
		Public Overridable Shadows ReadOnly Default Property Item(ByVal index As Integer) As NestedRecord
			Get
				Return CType(MyBase.Item(index), NestedRecord)
			End Get
		End Property
	End Class
	Public Class NestedRecord
		Private fName As String
		Private fChildList As ArrayList = Nothing

		Public Sub New(ByVal name As String, ByVal childList As ArrayList)
			Me.fName = name
			Me.fChildList = childList
		End Sub

		Public Property Name() As String
			Get
				Return fName
			End Get
			Set
				fName = Value
			End Set
		End Property

		Public Property ChildList() As ArrayList
			Get
				Return fChildList
			End Get
			Set
				fChildList = Value
			End Set
		End Property
	End Class
	Public Class IRelationListRecords
		Inherits ArrayList
		Implements DevExpress.Data.IRelationList
		Public Sub New()
			Add(New IRelationListRecord("Customers"))
			Add(New IRelationListRecord("Products"))
			Add(New IRelationListRecord("Shippers"))
		End Sub
		'IRelationList
		Private Function GetRelationName(ByVal index As Integer, ByVal relationIndex As Integer) As String Implements IRelationList.GetRelationName
			If index <> GridControl.InvalidRowHandle Then
				Return (CType(Me(index), IRelationListRecord)).Name
			Else
				Return ""
			End If
		End Function

		Private ReadOnly Property RelationCount() As Integer Implements IRelationList.RelationCount
			Get
				Return 1
			End Get
		End Property

		Private Function GetDetailList(ByVal index As Integer, ByVal relationIndex As Integer) As IList Implements IRelationList.GetDetailList
			Select Case (CType(Me(index), IRelationListRecord)).Name
				Case "Customers"
					Return New ChildRecordsCustomers()
				Case "Products"
					Return New ChildRecordsProducts()
				Case "Shippers"
					Return New ChildRecordsShippers()
			End Select
			Return Nothing
		End Function

		Private Function IsMasterRowEmpty(ByVal index As Integer, ByVal relationIndex As Integer) As Boolean Implements IRelationList.IsMasterRowEmpty
			Return False
		End Function
		'IRelationList

		Public Overridable Shadows ReadOnly Default Property Item(ByVal index As Integer) As IRelationListRecord
			Get
				Return CType(MyBase.Item(index), IRelationListRecord)
			End Get
		End Property
	End Class
	Public Class IRelationListRecord
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
	'</gridControl1>
	Public Class ChildRecordsProducts
		Inherits ArrayList
		Public Sub New()
			Add(New ChildRecordProduct("Grandma's Boysenberry Spread", 25.00, 120, 0, 25))
			Add(New ChildRecordProduct("Ikura", 31.00, 1, 0, 0))
			Add(New ChildRecordProduct("Tofu", 23.25, 35, 0, 0))
			Add(New ChildRecordProduct("Sir Rodney's Marmalade", 81.00, 40, 0, 0))
			Add(New ChildRecordProduct("Ipoh Coffee", 46.00, 17, 10, 25))
		End Sub
	End Class
	Public Class ChildRecordsCustomers
		Inherits ArrayList
		Public Sub New()
			Add(New ChildRecordCustomer("Thomas Hardy", "120 Hanover Sq.", False))
			Add(New ChildRecordCustomer("Hanna Moos", "Forsterstr. 57", True))
			Add(New ChildRecordCustomer("Ann Devon", "35 King George", False))
			Add(New ChildRecordCustomer("Roland Mendel", "Kirchgasse 6", True))
		End Sub
	End Class
	Public Class ChildRecordsShippers
		Inherits ArrayList
		Public Sub New()
			Add(New ChildRecordShipper("Speedy Express", "(503) 555-9831"))
			Add(New ChildRecordShipper("United Package", "(503) 555-3199"))
			Add(New ChildRecordShipper("Federal Shipping", "(503) 555-9931"))
		End Sub
	End Class
	Public Class ChildRecordShipper
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
	Public Class ChildRecordCustomer
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
	Public Class ChildRecordProduct
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
