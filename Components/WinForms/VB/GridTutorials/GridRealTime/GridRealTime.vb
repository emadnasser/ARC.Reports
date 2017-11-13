Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Columns

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridRealTime.
	''' </summary>
	Public Partial Class GridRealTime
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			gridControl1.DataSource = CreateData()
			SetCaption()
			gridView1.Columns(0).FilterInfo = New ColumnFilterInfo(ColumnFilterType.Custom, Nothing, "[Column0] >= 0")
		End Sub

		Private processing As Boolean = False
		Public Const ColumnCount As Integer = 10, RowCount As Integer = 40
		Private rnd As Random = New Random()
		Private count As Integer = 0

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
			If processing Then
			Return
			End If
			processing = True
			Try
				For n As Integer = 0 To 49
					SetRandomValue()
				Next n
			Finally
				processing = False
			End Try
		End Sub

		Public Function CreateData() As IList
			Dim rnd As Random = New Random(RowCount)
			Dim coll As RecordCollection = New RecordCollection()
			Dim n As Integer = 0
			Do While n < RowCount
				Dim row As Record = New Record()
				coll.Add(row)
				n += 1
			Loop
			Return coll
		End Function


		Private Sub SetRandomValue()
			'<label1>
			Dim c As Integer = rnd.Next(ColumnCount), r As Integer = rnd.Next(RowCount)
			SetValue(gridControl1.DataSource, r, c, rnd.Next(200) - 100)
			'</label1>
            count += 1
            If (count Mod 500) = 0 Then
                label1.Text = String.Format("Update Count = {0}", count)
            End If
		End Sub
		'<label1>
		Private Sub SetValue(ByVal data As Object, ByVal row As Integer, ByVal column As Integer, ByVal val As Object)
			Dim rc As RecordCollection = TryCast(data, RecordCollection)
			rc.SetValue(row, column, val)
		End Sub
		'</label1>

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			timer1.Enabled = Not timer1.Enabled
			SetCaption()
		End Sub

		Private Sub SetCaption()
			If timer1.Enabled Then
				simpleButton1.Text = "Stop timer"
			Else
				simpleButton1.Text = "Start timer"
			End If
		End Sub
	End Class
	#Region "record"
	Public Class RecordCollection
		Inherits CollectionBase
		Implements IBindingList, ITypedList
		Public ReadOnly Default Property Item(ByVal i As Integer) As Record
			Get
				Return CType(List(i), Record)
			End Get
		End Property
		Public Sub Add(ByVal record As Record)
			Dim res As Integer = List.Add(record)
			record.owner = Me
			record.Index = res
		End Sub
        Public Sub SetValue(ByVal row As Integer, ByVal col As Integer, ByVal val As Object)
            If Me.Count > row And row >= 0 Then
                Me(row).SetValue(col, val)
            End If
        End Sub
		Friend Sub OnListChanged(ByVal rec As Record)
			If Not listChangedHandlerEvent Is Nothing Then
			RaiseEvent listChangedHandler(Me, New ListChangedEventArgs(ListChangedType.ItemChanged, rec.Index, rec.Index))
			End If
		End Sub

		Private Function GetItemProperties(ByVal accessors As PropertyDescriptor()) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
			Dim coll As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(Record))
			Dim list As ArrayList = New ArrayList(coll)
			list.Sort(New PDComparer())
			Dim res As PropertyDescriptorCollection = New PropertyDescriptorCollection(Nothing)
			Dim n As Integer = 0
			Do While n < GridRealTime.ColumnCount
				res.Add(TryCast(list(n), PropertyDescriptor))
				n += 1
			Loop
			Return res
		End Function
		Private Class PDComparer
			Implements IComparer
			Private Function Compare(ByVal a As Object, ByVal b As Object) As Integer Implements IComparer.Compare
				Return Comparer.Default.Compare(GetName(a), GetName(b))
			End Function
			Private Function GetName(ByVal a As Object) As Integer
				Dim pd As PropertyDescriptor = CType(a, PropertyDescriptor)
				If pd.Name.StartsWith("Column") Then
				Return Convert.ToInt32(pd.Name.Substring(6))
				End If
				Return -1

			End Function
		End Class
		Private Function GetListName(ByVal accessors As PropertyDescriptor()) As String Implements ITypedList.GetListName
			Return ""
		End Function
		Public Function AddNew() As Object Implements IBindingList.AddNew
			Return Nothing
		End Function
		Public ReadOnly Property AllowEdit() As Boolean Implements IBindingList.AllowEdit
			Get
				Return True
			End Get
		End Property
		Public ReadOnly Property AllowNew() As Boolean Implements IBindingList.AllowNew
			Get
				Return False
			End Get
		End Property
		Public ReadOnly Property AllowRemove() As Boolean Implements IBindingList.AllowRemove
			Get
				Return False
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
	Public Class Record
		Friend Index As Integer = -1
		Friend owner As RecordCollection
		Private values As Integer() = New Integer(19){}
		Public Property Column0() As Integer
			Get
				Return values(0)
			End Get
			Set
				SetValue(0, Value)
			End Set
		End Property
		Public Property Column1() As Integer
			Get
				Return values(1)
			End Get
			Set
				SetValue(1, Value)
			End Set
		End Property
		Public Property Column2() As Integer
			Get
				Return values(2)
			End Get
			Set
				SetValue(2, Value)
			End Set
		End Property
		Public Property Column3() As Integer
			Get
				Return values(3)
			End Get
			Set
				SetValue(3, Value)
			End Set
		End Property
		Public Property Column4() As Integer
			Get
				Return values(4)
			End Get
			Set
				SetValue(4, Value)
			End Set
		End Property
		Public Property Column5() As Integer
			Get
				Return values(5)
			End Get
			Set
				SetValue(5, Value)
			End Set
		End Property
		Public Property Column6() As Integer
			Get
				Return values(6)
			End Get
			Set
				SetValue(6, Value)
			End Set
		End Property
		Public Property Column7() As Integer
			Get
				Return values(7)
			End Get
			Set
				SetValue(7, Value)
			End Set
		End Property
		Public Property Column8() As Integer
			Get
				Return values(8)
			End Get
			Set
				SetValue(8, Value)
			End Set
		End Property
		Public Property Column9() As Integer
			Get
				Return values(9)
			End Get
			Set
				SetValue(9, Value)
			End Set
		End Property
		Public Property Column10() As Integer
			Get
				Return values(10)
			End Get
			Set
				SetValue(10, Value)
			End Set
		End Property
		Public Property Column11() As Integer
			Get
				Return values(11)
			End Get
			Set
				SetValue(11, Value)
			End Set
		End Property
		Public Property Column12() As Integer
			Get
				Return values(12)
			End Get
			Set
				SetValue(12, Value)
			End Set
		End Property
		Public Property Column13() As Integer
			Get
				Return values(13)
			End Get
			Set
				SetValue(13, Value)
			End Set
		End Property
		Public Property Column14() As Integer
			Get
				Return values(14)
			End Get
			Set
				SetValue(14, Value)
			End Set
		End Property
		Public Property Column15() As Integer
			Get
				Return values(15)
			End Get
			Set
				SetValue(15, Value)
			End Set
		End Property
		Public Property Column16() As Integer
			Get
				Return values(16)
			End Get
			Set
				SetValue(16, Value)
			End Set
		End Property
		Public Property Column17() As Integer
			Get
				Return values(17)
			End Get
			Set
				SetValue(17, Value)
			End Set
		End Property
		Public Property Column18() As Integer
			Get
				Return values(18)
			End Get
			Set
				SetValue(18, Value)
			End Set
		End Property
		Public Property Column19() As Integer
			Get
				Return values(19)
			End Get
			Set
				SetValue(19, Value)
			End Set
		End Property
		Public Function GetValue(ByVal index As Integer) As Integer
			Return values(index)
		End Function
		'<label1>
		Public Sub SetValue(ByVal index As Integer, ByVal val As Object)
			values(index) = CInt(Fix(val))
			If Not Me.owner Is Nothing Then
			Me.owner.OnListChanged(Me)
			End If
		End Sub
		'</label1>
	End Class
	#End Region

End Namespace
