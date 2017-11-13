Imports System
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Collections
Imports DevExpress.Data.Browsing
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace GridDemo
    Public Class CountInfo
        Public Property Value() As Integer
        Public Property Description() As String
    End Class
    Public Class VirtualPropertyDescriptor
        Inherits PropertyDescriptor

        Private propertyName As String

        Private propertyType_Renamed As Type

        Private isReadOnly_Renamed As Boolean
        Private list As VirtualList
        Private index As Integer
        Public Sub New(ByVal list As VirtualList, ByVal index As Integer, ByVal propertyName As String, ByVal propertyType As Type, ByVal isReadOnly As Boolean)
            MyBase.New(propertyName, Nothing)
            Me.propertyName = propertyName
            Me.propertyType_Renamed = propertyType
            Me.isReadOnly_Renamed = isReadOnly
            Me.list = list
            Me.index = index
        End Sub
        Public Overrides Function CanResetValue(ByVal component As Object) As Boolean
            Return False
        End Function
        Public Overrides Function GetValue(ByVal component As Object) As Object
            Return list.GetPropertyValue(DirectCast(component, Integer), index)
        End Function
        Public Overrides Sub SetValue(ByVal component As Object, ByVal val As Object)
            list.SetPropertyValue(DirectCast(component, Integer), index, val)
        End Sub
        Public Overrides ReadOnly Property IsReadOnly() As Boolean
            Get
                Return isReadOnly_Renamed
            End Get
        End Property
        Public Overrides ReadOnly Property Name() As String
            Get
                Return propertyName
            End Get
        End Property
        Public Overrides ReadOnly Property ComponentType() As Type
            Get
                Return GetType(VirtualList)
            End Get
        End Property
        Public Overrides ReadOnly Property PropertyType() As Type
            Get
                Return propertyType_Renamed
            End Get
        End Property
        Public Overrides Sub ResetValue(ByVal component As Object)
        End Sub
        Public Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
            Return True
        End Function
    End Class
    Public Structure Location
        Public Property Row() As Integer
        Public Property Column() As Integer
        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            Dim l As Location = DirectCast(obj, Location)
            Return l.Row = Row AndAlso l.Column = Column
        End Function
        Public Overrides Function GetHashCode() As Integer
            Return Row Xor Column
        End Function
    End Structure
    Public Class VirtualList
        Implements IList, ITypedList

        Private Const BaseColumnCount As Integer = 7

        Private recordCount_Renamed As Integer

        Private columnCount_Renamed As Integer
        Private fValues As New Dictionary(Of Location, Object)()
        Private columnCollection As PropertyDescriptorCollection
        Public Sub New()
            recordCount_Renamed = 1000
            columnCount_Renamed = 1000
            CreateColumnCollection()
        End Sub
        Public Sub SetPropertyValue(ByVal rowIndex As Integer, ByVal columnIndex As Integer, ByVal value As Object)
            fValues(New Location() With {.Column = columnIndex, .Row = rowIndex}) = value
        End Sub
        Public Function GetPropertyValue(ByVal rowIndex As Integer, ByVal columnIndex As Integer) As Object
            Dim value As Object = Nothing
            If fValues.TryGetValue(New Location() With {.Column = columnIndex, .Row = rowIndex}, value) Then
                Return value
            End If
            If columnIndex = 0 Then
                Return rowIndex + 1
            End If
            Select Case (columnIndex - 1) Mod BaseColumnCount
                Case 0 'From
                    Return OutlookData.Users(GetPseudoRandomValue(rowIndex, columnIndex, OutlookData.Users.Length)).Name
                Case 1 'To
                    Return OutlookData.Users(GetPseudoRandomValue(rowIndex, columnIndex, OutlookData.Users.Length)).Name
                Case 2 'Sent
                    Return Date.Today.AddDays(GetPseudoRandomValue(rowIndex, columnIndex, 30))
                Case 3 'HasAttachment
                    Return If(GetPseudoRandomValue(rowIndex, columnIndex, 2) = 0, True, False)
                Case 4 'Size
                    Return GetPseudoRandomValue(rowIndex, columnIndex, 10000)
                Case 5 'Priority
                    Return CType(GetPseudoRandomValue(rowIndex, columnIndex, DevExpress.Utils.EnumExtensions.GetValues(GetType(Priority)).Length), Priority)
                Case 6 'Subject
                    Return OutlookDataGenerator.Subjects(GetPseudoRandomValue(rowIndex, columnIndex, OutlookDataGenerator.Subjects.Length))
            End Select
            Throw New NotImplementedException()
        End Function
        Public Function GetPropertyName(ByVal columnIndex As Integer) As String
            If columnIndex = 0 Then
                Return "ID(1)"
            End If
            Select Case (columnIndex - 1) Mod BaseColumnCount
                Case 0 'From
                    Return GetFullPropertyName("From", columnIndex)
                Case 1 'To
                    Return GetFullPropertyName("To", columnIndex)
                Case 2 'Sent
                    Return GetFullPropertyName("Sent", columnIndex)
                Case 3 'HasAttachment
                    Return GetFullPropertyName("HasAttachment", columnIndex)
                Case 4 'Size
                    Return GetFullPropertyName("Size", columnIndex)
                Case 5 'Priority
                    Return GetFullPropertyName("Priority", columnIndex)
                Case 6 'Subject
                    Return GetFullPropertyName("Subject", columnIndex)
            End Select
            Throw New NotImplementedException()
        End Function
        Private Function GetFullPropertyName(ByVal name As String, ByVal columnIndex As Integer) As String
            Return name & "(" & (columnIndex + 1) & ")"
        End Function
        Public Function GetPropertyType(ByVal columnIndex As Integer) As Type
            If columnIndex = 0 Then
                Return GetType(Integer)
            End If
            Select Case (columnIndex - 1) Mod BaseColumnCount
                Case 0 'From
                    Return GetType(String)
                Case 1 'To
                    Return GetType(String)
                Case 2 'Sent
                    Return GetType(Date)
                Case 3 'HasAttachment
                    Return GetType(Boolean)
                Case 4 'Size
                    Return GetType(Integer)
                Case 5 'Priority
                    Return GetType(Priority)
                Case 6 'Subject
                    Return GetType(String)
            End Select
            Throw New NotImplementedException()
        End Function
        Private Function GetPseudoRandomValue(ByVal rowIndex As Integer, ByVal columnIndex As Integer, ByVal maxValue As Integer) As Integer
            Return (rowIndex + columnIndex) Mod maxValue
        End Function
        Public Property RecordCount() As Integer
            Get
                Return recordCount_Renamed
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then
                    value = 0
                End If
                If RecordCount = value Then
                    Return
                End If
                recordCount_Renamed = value
            End Set
        End Property
        Public Property ColumnCount() As Integer
            Get
                Return columnCount_Renamed
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then
                    value = 0
                End If
                If ColumnCount = value Then
                    Return
                End If
                columnCount_Renamed = value
                CreateColumnCollection()
            End Set
        End Property
        Protected Overridable Sub CreateColumnCollection()
            Dim pds(ColumnCount - 1) As VirtualPropertyDescriptor
            For n As Integer = 0 To ColumnCount - 1
                pds(n) = New VirtualPropertyDescriptor(Me, n, GetPropertyName(n), GetPropertyType(n), False)
            Next n
            columnCollection = New PropertyDescriptorCollection(pds)
        End Sub

        #Region "ITypedList Interface"
        Private Function ITypedList_GetItemProperties(ByVal descs() As PropertyDescriptor) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
            Return columnCollection
        End Function
        Private Function ITypedList_GetListName(ByVal descs() As PropertyDescriptor) As String Implements ITypedList.GetListName
            Return ""
        End Function
        #End Region
        #Region "IList Interface"
        Public Overridable ReadOnly Property Count() As Integer Implements System.Collections.ICollection.Count
            Get
                Return RecordCount
            End Get
        End Property
        Public Overridable ReadOnly Property IsSynchronized() As Boolean Implements System.Collections.ICollection.IsSynchronized
            Get
                Return True
            End Get
        End Property
        Public Overridable ReadOnly Property SyncRoot() As Object Implements System.Collections.ICollection.SyncRoot
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
        Public Overridable Function GetEnumerator() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Nothing
        End Function
        Public Overridable Sub CopyTo(ByVal array As System.Array, ByVal fIndex As Integer) Implements System.Collections.ICollection.CopyTo
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
        Public Property IList_Item(ByVal fIndex As Integer) As Object Implements IList.Item
            Get
                Return fIndex
            End Get
            Set(ByVal value As Object)
            End Set
        End Property
        #End Region
    End Class
End Namespace
