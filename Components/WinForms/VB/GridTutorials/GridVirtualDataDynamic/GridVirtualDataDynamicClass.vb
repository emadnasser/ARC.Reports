Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports DevExpress.Data
Imports System.ComponentModel

Namespace DevExpress.XtraGrid.Demos.Tutorials
    Public Class VirtualPropertyDescriptorDynamic
        Inherits PropertyDescriptor
        Private fPropertyName As String
        Private fPropertyType As Type
        Private fIsReadOnly As Boolean
        Private fList As VirtualListDynamic
        Private fIndex As Integer
        Public Sub New(ByVal fList As VirtualListDynamic, ByVal fIndex As Integer, ByVal fPropertyName As String, ByVal fPropertyType As Type, ByVal fIsReadOnly As Boolean)
            MyBase.New(fPropertyName, Nothing)
            Me.fPropertyName = fPropertyName
            Me.fPropertyType = fPropertyType
            Me.fIsReadOnly = fIsReadOnly
            Me.fList = fList
            Me.fIndex = fIndex
        End Sub
        Public Overrides Function CanResetValue(ByVal component As Object) As Boolean
            Return False
        End Function
        Public Overrides Function GetValue(ByVal component As Object) As Object
            Return fList.GetRowValue(component, fIndex)
        End Function
        Public Overrides Sub SetValue(ByVal component As Object, ByVal val As Object)
            fList.SetRowValue(component, fIndex, val)
        End Sub
        Public Overrides ReadOnly Property IsReadOnly() As Boolean
            Get
                Return fIsReadOnly
            End Get
        End Property
        Public Overrides ReadOnly Property Name() As String
            Get
                Return fPropertyName
            End Get
        End Property
        Public Overrides ReadOnly Property ComponentType() As Type
            Get
                Return GetType(VirtualListDynamic)
            End Get
        End Property
        Public Overrides ReadOnly Property PropertyType() As Type
            Get
                Return fPropertyType
            End Get
        End Property
        Public Overrides Sub ResetValue(ByVal component As Object)
        End Sub
        Public Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
            Return True
        End Function
    End Class
    Public Class VirtualListDynamic
        Implements IBindingList, ITypedList
        Private fRecordCount As Integer
        Private fColumnCount As Integer
        Private fValues As Hashtable
        Private fColumnCollection As PropertyDescriptorCollection
        Private fUseDataStore As Boolean = True
        Private Event listChangedHandler As ListChangedEventHandler
        Public Sub New()
            fValues = New Hashtable()
            fRecordCount = 7
            fColumnCount = 3
            CreateColumnCollection()
        End Sub
        Public Overridable ReadOnly Property Values() As Hashtable
            Get
                Return fValues
            End Get
        End Property
        Public Overridable Function GetRowKey(ByVal rowIndex As Integer, ByVal colIndex As Integer) As Object
            Return String.Format("row {0}, col {1}", rowIndex, colIndex)
        End Function
        Public Overridable Property UseDataStore() As Boolean
            Get
                Return fUseDataStore
            End Get
            Set(ByVal value As Boolean)
                fUseDataStore = Value
            End Set
        End Property
        Public Property RecordCount() As Integer
            Get
                Return fRecordCount
            End Get
            Set(ByVal value As Integer)
                If Value < 1 Then
                    Value = 0
                End If
                If RecordCount = Value Then
                    Return
                End If
                fRecordCount = Value
            End Set
        End Property
        Public Property ColumnCount() As Integer
            Get
                Return fColumnCount
            End Get
            Set(ByVal value As Integer)
                If Value < 1 Then
                    Value = 0
                End If
                If ColumnCount = Value Then
                    Return
                End If
                fColumnCount = Value
                CreateColumnCollection()
            End Set
        End Property
        Protected Overridable Sub CreateColumnCollection()
            Dim pds As VirtualPropertyDescriptorDynamic() = New VirtualPropertyDescriptorDynamic(ColumnCount - 1) {}
            Dim n As Integer = 0
            Do While n < ColumnCount
                pds(n) = New VirtualPropertyDescriptorDynamic(Me, n, GetColumnName(n), GetType(String), False)
                n += 1
            Loop
            fColumnCollection = New PropertyDescriptorCollection(pds)
        End Sub

        Friend Function GetRowValue(ByVal row As Object, ByVal colIndex As Integer) As Object
            Dim fIndex As Integer = CInt(Fix(row))
            If (Not UseDataStore) Then
                Return GetRowKey(fIndex, colIndex)
            End If
            Return Values(GetRowKey(fIndex, colIndex))
        End Function
        Friend Sub SetRowValue(ByVal row As Object, ByVal colIndex As Integer, ByVal val As Object)
            If (Not UseDataStore) Then
                Return
            End If
            Dim fIndex As Integer = CInt(Fix(row))
            Values(GetRowKey(fIndex, colIndex)) = val
            RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemChanged, fIndex, fIndex))
        End Sub

#Region "IBindingList Interface"
        Private Sub AddIndex(ByVal pd As PropertyDescriptor) Implements IBindingList.AddIndex
            Throw New NotImplementedException()
        End Sub
        Private Function AddNew() As Object Implements IBindingList.AddNew
            fRecordCount += 1
            RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemAdded, RecordCount - 1, -1))
            Return RecordCount - 1
        End Function
        Public Overridable Sub AddColumn()
            Dim cc As Integer = ColumnCount
            ColumnCount += 1
            If cc <> ColumnCount Then
                RaiseListChanged(New ListChangedEventArgs(ListChangedType.PropertyDescriptorAdded, ColumnCount - 1, -1))
            End If
        End Sub
        Public Overridable Function GetColumnName(ByVal columnIndex As Integer) As String
            Return String.Format("Column{0}", columnIndex + 1)
        End Function
        Public Overridable Sub RemoveLastColumn()
            Dim cc As Integer = ColumnCount
            ColumnCount -= 1
            If cc <> ColumnCount Then
                RaiseListChanged(New ListChangedEventArgs(ListChangedType.PropertyDescriptorDeleted, -1, ColumnCount))
            End If
        End Sub
        Public Sub AddNewRecord()
            CType(Me, IBindingList).AddNew()
        End Sub
        Private ReadOnly Property AllowEdit() As Boolean Implements IBindingList.AllowEdit
            Get
                Return True
            End Get
        End Property
        Private ReadOnly Property AllowNew() As Boolean Implements IBindingList.AllowNew
            Get
                Return True
            End Get
        End Property
        Private ReadOnly Property AllowRemove() As Boolean Implements IBindingList.AllowRemove
            Get
                Return False
            End Get
        End Property
        Private Sub ApplySort(ByVal pd As PropertyDescriptor, ByVal dir As ListSortDirection) Implements IBindingList.ApplySort
            Throw New NotImplementedException()
        End Sub
        Private Function Find(ByVal pd As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
            Throw New NotImplementedException()
        End Function
        Private ReadOnly Property IsSorted() As Boolean Implements IBindingList.IsSorted
            Get
                Return False
            End Get
        End Property
        Private Sub RemoveIndex(ByVal pd As PropertyDescriptor) Implements IBindingList.RemoveIndex
            Throw New NotImplementedException()
        End Sub
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
        Protected Overridable Sub RaiseListChanged(ByVal args As ListChangedEventArgs)
            If Not listChangedHandlerEvent Is Nothing Then
                RaiseEvent listChangedHandler(Me, args)
            End If
        End Sub
        Private Sub RemoveSort() Implements IBindingList.RemoveSort
            Throw New NotImplementedException()
        End Sub
        Private ReadOnly Property SortDirection() As ListSortDirection Implements IBindingList.SortDirection
            Get
                Return ListSortDirection.Ascending
            End Get
        End Property
        Private ReadOnly Property SortProperty() As PropertyDescriptor Implements IBindingList.SortProperty
            Get
                Return Nothing
            End Get
        End Property
        Private ReadOnly Property SupportsChangeNotification() As Boolean Implements IBindingList.SupportsChangeNotification
            Get
                Return True
            End Get
        End Property
        Private ReadOnly Property SupportsSorting() As Boolean Implements IBindingList.SupportsSorting
            Get
                Return False
            End Get
        End Property
        Private ReadOnly Property SupportsSearching() As Boolean Implements IBindingList.SupportsSearching
            Get
                Return False
            End Get
        End Property
#End Region
#Region "ITypedList Interface"
        Private Function GetItemProperties(ByVal descs As PropertyDescriptor()) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
            Return fColumnCollection
        End Function
        Private Function GetListName(ByVal descs As PropertyDescriptor()) As String Implements ITypedList.GetListName
            Return ""
        End Function
#End Region
#Region "IList Interface"
        Public Overridable ReadOnly Property Count() As Integer Implements IBindingList.Count
            Get
                Return RecordCount
            End Get
        End Property
        Public Overridable ReadOnly Property IsSynchronized() As Boolean Implements IBindingList.IsSynchronized
            Get
                Return True
            End Get
        End Property
        Public Overridable ReadOnly Property SyncRoot() As Object Implements IBindingList.SyncRoot
            Get
                Return True
            End Get
        End Property
        Public Overridable ReadOnly Property IsReadOnly() As Boolean Implements IBindingList.IsReadOnly
            Get
                Return False
            End Get
        End Property
        Public Overridable ReadOnly Property IsFixedSize() As Boolean Implements IBindingList.IsFixedSize
            Get
                Return True
            End Get
        End Property
        Public Overridable Function GetEnumerator() As IEnumerator Implements IBindingList.GetEnumerator
            Return Nothing
        End Function
        Public Overridable Sub CopyTo(ByVal array As System.Array, ByVal fIndex As Integer) Implements IBindingList.CopyTo
        End Sub
        Public Overridable Function Add(ByVal val As Object) As Integer Implements IBindingList.Add
            Throw New NotImplementedException()
        End Function
        Public Overridable Sub Clear() Implements IBindingList.Clear
            Throw New NotImplementedException()
        End Sub
        Public Overridable Function Contains(ByVal val As Object) As Boolean Implements IBindingList.Contains
            Throw New NotImplementedException()
        End Function
        Public Overridable Function IndexOf(ByVal val As Object) As Integer Implements IBindingList.IndexOf
            Throw New NotImplementedException()
        End Function
        Public Overridable Sub Insert(ByVal fIndex As Integer, ByVal val As Object) Implements IBindingList.Insert
            Throw New NotImplementedException()
        End Sub
        Public Overridable Sub Remove(ByVal val As Object) Implements IBindingList.Remove
            Throw New NotImplementedException()
        End Sub
        Public Overridable Sub RemoveAt(ByVal fIndex As Integer) Implements IBindingList.RemoveAt
            Throw New NotImplementedException()
        End Sub
        Default Property Item(ByVal fIndex As Integer) As Object Implements IList.Item
            Get
                Return fIndex
            End Get
            Set(ByVal value As Object)
            End Set
        End Property
#End Region
    End Class
End Namespace
