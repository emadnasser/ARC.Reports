Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports DevExpress.Data
Imports System.ComponentModel

Namespace DevExpress.XtraGrid.Demos.Tutorials
    Public Class VirtualPropertyDescriptor
        Inherits PropertyDescriptor
        Private fPropertyName As String
        Private fPropertyType As Type
        Private fIsReadOnly As Boolean
        Private fList As VirtualList
        Private fIndex As Integer
        Public Sub New(ByVal fList As VirtualList, ByVal fIndex As Integer, ByVal fPropertyName As String, ByVal fPropertyType As Type, ByVal fIsReadOnly As Boolean)
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
                Return GetType(VirtualList)
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
    Public Class VirtualList
        Implements IList, ITypedList
        Private fRecordCount As Integer
        Private fColumnCount As Integer
        Private fValues As Hashtable
        Private fColumnCollection As PropertyDescriptorCollection
        Private fUseDataStore As Boolean = False
        Public Sub New()
            fValues = New Hashtable()
            fRecordCount = 1000
            fColumnCount = 1000
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
        End Sub
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
            Dim pds As VirtualPropertyDescriptor() = New VirtualPropertyDescriptor(ColumnCount - 1) {}
            Dim n As Integer = 0
            Do While n < ColumnCount
                pds(n) = New VirtualPropertyDescriptor(Me, n, String.Format("Column{0}", n + 1), GetType(String), False)
                n += 1
            Loop
            fColumnCollection = New PropertyDescriptorCollection(pds)
        End Sub

#Region "ITypedList Interface"
        Private Function GetItemProperties(ByVal descs As PropertyDescriptor()) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
            Return fColumnCollection
        End Function
        Private Function GetListName(ByVal descs As PropertyDescriptor()) As String Implements ITypedList.GetListName
            Return ""
        End Function
#End Region
#Region "IList Interface"
        Public Overridable ReadOnly Property Count() As Integer Implements IList.Count
            Get
                Return RecordCount
            End Get
        End Property
        Public Overridable ReadOnly Property IsSynchronized() As Boolean Implements IList.IsSynchronized
            Get
                Return True
            End Get
        End Property
        Public Overridable ReadOnly Property SyncRoot() As Object Implements IList.SyncRoot
            Get
                Return True
            End Get
        End Property
        Public Overridable ReadOnly Property IsReadOnly() As Boolean Implements IList.IsReadOnly
            Get
                Return False
            End Get
        End Property
        Public Overridable ReadOnly Property IsFixedSize() As Boolean Implements IList.IsFixedSize
            Get
                Return True
            End Get
        End Property
        Public Overridable Function GetEnumerator() As IEnumerator Implements IList.GetEnumerator
            Return Nothing
        End Function
        Public Overridable Sub CopyTo(ByVal array As System.Array, ByVal fIndex As Integer) Implements IList.CopyTo
        End Sub
        Public Overridable Function Add(ByVal val As Object) As Integer Implements IList.Add
            Throw New NotImplementedException()
        End Function
        Public Overridable Sub Clear() Implements IList.Clear
            Throw New NotImplementedException()
        End Sub
        Public Overridable Function Contains(ByVal val As Object) As Boolean Implements IList.Contains
            Throw New NotImplementedException()
        End Function
        Public Overridable Function IndexOf(ByVal val As Object) As Integer Implements IList.IndexOf
            Throw New NotImplementedException()
        End Function
        Public Overridable Sub Insert(ByVal fIndex As Integer, ByVal val As Object) Implements IList.Insert
            Throw New NotImplementedException()
        End Sub
        Public Overridable Sub Remove(ByVal val As Object) Implements IList.Remove
            Throw New NotImplementedException()
        End Sub
        Public Overridable Sub RemoveAt(ByVal fIndex As Integer) Implements IList.RemoveAt
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
