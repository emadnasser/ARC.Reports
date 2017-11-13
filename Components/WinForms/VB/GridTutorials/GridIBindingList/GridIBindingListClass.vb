Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel

Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Class GridIBindingListRecord
		Implements IEditableObject
		Private fName As String
		Private fPayment As Double
		Private fDate As DateTime
		Private fRecords As GridIBindingListRecords

		Private committed As Boolean
		Private editing As Boolean
		Private fRecordCache As GridIBindingListRecord

		Public Sub New()
		End Sub
		Public Sub New(ByVal fRecords As GridIBindingListRecords)
			Me.fRecords = fRecords
			Me.fDate = DateTime.Now
			committed = False
		End Sub
		Public Sub New(ByVal fRecords As GridIBindingListRecords, ByVal fName As String, ByVal fPayment As Double, ByVal fDate As DateTime)
			Me.fRecords = fRecords
			Me.fName = fName
			Me.fPayment = fPayment
			Me.fDate = fDate
			committed = True
		End Sub
		Private Sub OnListChanged()
			If fRecords Is Nothing Then
			Return
			End If
			Dim index As Integer = fRecords.IndexOf(Me)
			fRecords.OnListChanged(New ListChangedEventArgs(ListChangedType.ItemChanged, index))
		End Sub
		Public Property Name() As String
			Get
				Return fName
			End Get
			Set
				fName = Value
				OnListChanged()
			End Set
		End Property
		Public Property Payment() As Double
			Get
				Return fPayment
			End Get
			Set
				fPayment = Value
				OnListChanged()
			End Set
		End Property
		Public Property PurchaseDate() As DateTime
			Get
				Return fDate
			End Get
			Set
				fDate = Value
				OnListChanged()
			End Set
		End Property
		Public Sub Assign(ByVal rec As GridIBindingListRecord)
			Me.Name = rec.Name
			Me.Payment = rec.Payment
			Me.PurchaseDate = rec.PurchaseDate
		End Sub
		Private ReadOnly Property RecordCache() As GridIBindingListRecord
			Get
				If fRecordCache Is Nothing Then
				fRecordCache = New GridIBindingListRecord()
				End If
				Return fRecordCache
			End Get
		End Property
		Public Sub BeginEdit() Implements IEditableObject.BeginEdit
			editing = True
			RecordCache.Assign(Me)
		End Sub
		Public Sub CancelEdit() Implements IEditableObject.CancelEdit
			If (Not committed) Then
				CType(fRecords, IList).Remove(Me)
			End If
			If editing Then
			Me.Assign(RecordCache)
			End If
		End Sub
		Public Sub EndEdit() Implements IEditableObject.EndEdit
			committed = True
			editing = False
		End Sub
	End Class

	Public Class GridIBindingListRecords
		Inherits CollectionBase
		Implements IBindingList
		Public Sub Add(ByVal record As GridIBindingListRecord)
			MyBase.List.Add(record)
		End Sub
		Public ReadOnly Default Property Item(ByVal idx As Integer) As GridIBindingListRecord
			Get
				Return CType(MyBase.List(idx), GridIBindingListRecord)
			End Get
		End Property

		Public Function IndexOf(ByVal record As GridIBindingListRecord) As Integer
			Return List.IndexOf(record)
		End Function

		Public Function AddNew() As Object Implements IBindingList.AddNew
			Dim record As GridIBindingListRecord = New GridIBindingListRecord(Me)
			List.Add(record)
			Return record
		End Function
		Public ReadOnly Property AllowEdit() As Boolean Implements IBindingList.AllowEdit
			Get
				Return True
			End Get
		End Property
		Public ReadOnly Property AllowNew() As Boolean Implements IBindingList.AllowNew
			Get
				Return True
			End Get
		End Property
		Public ReadOnly Property AllowRemove() As Boolean Implements IBindingList.AllowRemove
			Get
				Return True
			End Get
		End Property

		Private Event listChangedHandler As ListChangedEventHandler
		Public Custom Event ListChanged As ListChangedEventHandler Implements IBindingList.ListChanged
			AddHandler(ByVal value As ListChangedEventHandler)
				AddHandler listChangedHandler, value
			End AddHandler
			RemoveHandler(ByVal value As ListChangedEventHandler)
				RemoveHandler listChangedHandler, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs)
			End RaiseEvent
		End Event
		Friend Sub OnListChanged(ByVal args As ListChangedEventArgs)
			If Not listChangedHandlerEvent Is Nothing Then
				RaiseEvent listChangedHandler(Me, args)
			End If
		End Sub
		Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal value As Object)
			OnListChanged(New ListChangedEventArgs(ListChangedType.ItemDeleted, index))
		End Sub
		Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
			OnListChanged(New ListChangedEventArgs(ListChangedType.ItemAdded, index))
		End Sub

		Public Sub AddIndex(ByVal pd As PropertyDescriptor) Implements IBindingList.AddIndex
			Throw New NotSupportedException()
		End Sub
		Public Sub ApplySort(ByVal pd As PropertyDescriptor, ByVal dir As ListSortDirection) Implements IBindingList.ApplySort
			Throw New NotSupportedException()
		End Sub
		Public Function Find(ByVal [property] As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
			Throw New NotSupportedException()
		End Function
		Public ReadOnly Property IsSorted() As Boolean Implements IBindingList.IsSorted
			Get
				Return False
			End Get
		End Property
		Public Sub RemoveIndex(ByVal pd As PropertyDescriptor) Implements IBindingList.RemoveIndex
			Throw New NotSupportedException()
		End Sub
		Public Sub RemoveSort() Implements IBindingList.RemoveSort
			Throw New NotSupportedException()
		End Sub
		Public ReadOnly Property SortDirection() As ListSortDirection Implements IBindingList.SortDirection
			Get
				Throw New NotSupportedException()
			End Get
		End Property
		Public ReadOnly Property SortProperty() As PropertyDescriptor Implements IBindingList.SortProperty
			Get
				Throw New NotSupportedException()
			End Get
		End Property
		Public ReadOnly Property SupportsChangeNotification() As Boolean Implements IBindingList.SupportsChangeNotification
			Get
				Return True
			End Get
		End Property
		Public ReadOnly Property SupportsSearching() As Boolean Implements IBindingList.SupportsSearching
			Get
				Return False
			End Get
		End Property
		Public ReadOnly Property SupportsSorting() As Boolean Implements IBindingList.SupportsSorting
			Get
				Return False
			End Get
		End Property
	End Class
End Namespace
