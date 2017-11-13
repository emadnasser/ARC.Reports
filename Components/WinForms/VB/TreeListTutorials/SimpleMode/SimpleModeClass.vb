Imports Microsoft.VisualBasic
Imports System
Imports System.Collections

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Enum RecordType
		Category
		Product
	End Enum
	'<treeList1>
	Public Class SimpleModeRecords
		Inherits ArrayList
		Public Sub New()
			Me.Add(New SimpleModeRecord("Dairy Products", RecordType.Category, 0, "", 0))
			Me.Add(New SimpleModeRecord("Queso Manchego La Pastora", RecordType.Product, 37.89, "Cooperativa de Quesos", 1, 0))
			Me.Add(New SimpleModeRecord("Queso Cabrales", RecordType.Product, 21.0, "Cooperativa de Quesos", 2, 0))
			Me.Add(New SimpleModeRecord("Gorgonzola Telino", RecordType.Product, 12.5, "Formaggi Fortini", 3, 0))
			Me.Add(New SimpleModeRecord("Confections", RecordType.Category, 0, "", 4))
			Me.Add(New SimpleModeRecord("Sir Rodney's Marmalade", RecordType.Product, 81.0, "Specialty Biscuits, Ltd.", 5, 4))
			Me.Add(New SimpleModeRecord("Sir Rodney's Scones", RecordType.Product, 10.1, "Specialty Biscuits, Ltd.", 6, 4))
			Me.Add(New SimpleModeRecord("Gula Malacca", RecordType.Product, 19.45, "Leka Trading", 7, 4))
			Me.Add(New SimpleModeRecord("Grandma's Boysenberry Spread", RecordType.Product, 25.0, "Grandma Kelly's Homestead", 8, 4))
			Me.Add(New SimpleModeRecord("Pavlova", RecordType.Product, 17.45, "Pavlova, Ltd.", 9, 4))
		End Sub
	End Class
	'</treeList1>
	Public Class SimpleModeRecord
		Private id_Renamed As Integer
		Private parentID_Renamed As Integer
		Private name_Renamed As String
		Private status_Renamed As RecordType
		Private price_Renamed As Double
		Private supplier_Renamed As String
		Public Sub New(ByVal name_Renamed As String, ByVal status_Renamed As RecordType, ByVal price_Renamed As Double, ByVal supplier_Renamed As String, ByVal id_Renamed As Integer)
			Me.New(name_Renamed, status_Renamed, price_Renamed, supplier_Renamed, id_Renamed, -1)
		End Sub
		Public Sub New(ByVal name_Renamed As String, ByVal status_Renamed As RecordType, ByVal price_Renamed As Double, ByVal supplier_Renamed As String, ByVal id_Renamed As Integer, ByVal parentID_Renamed As Integer)
			Me.id_Renamed = id_Renamed
			Me.parentID_Renamed = parentID_Renamed
			Me.name_Renamed = name_Renamed
			Me.status_Renamed = status_Renamed
			Me.price_Renamed = price_Renamed
			Me.supplier_Renamed = supplier_Renamed
		End Sub
		Public ReadOnly Property ID() As Integer
			Get
				Return id_Renamed
			End Get
		End Property
		Public ReadOnly Property ParentID() As Integer
			Get
				Return parentID_Renamed
			End Get
		End Property
		Public ReadOnly Property ImageIndex() As Integer
			Get
				If status_Renamed = RecordType.Category Then
					Return 0
				Else
					Return 1
				End If
			End Get
		End Property
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set
				name_Renamed = Value
			End Set
		End Property
		Public ReadOnly Property Status() As RecordType
			Get
				Return status_Renamed
			End Get
		End Property
		Public Property Price() As Double
			Get
				Return price_Renamed
			End Get
			Set
				If status_Renamed = RecordType.Product Then
					price_Renamed = Value
				End If
			End Set
		End Property
		Public Property Supplier() As String
			Get
				Return supplier_Renamed
			End Get
			Set
				supplier_Renamed = Value
			End Set
		End Property
	End Class
End Namespace
