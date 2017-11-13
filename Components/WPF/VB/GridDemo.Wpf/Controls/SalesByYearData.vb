Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports GridDemo
Imports System.Collections
Imports System.Globalization
Imports DevExpress.Data
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Editors.Settings
Imports DevExpress.Xpf.Editors
Imports System.Windows.Controls
Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.ComponentModel
Imports DevExpress.DemoData.Models

Namespace GridDemo
    Public Class SalesByEmployeeData

        Private data_Renamed As IList
        Public ReadOnly Property Data() As IList
            Get
                If data_Renamed Is Nothing Then
                    data_Renamed = GetSalesByEmployee()
                End If
                Return data_Renamed
            End Get
        End Property
        Public Shared Function GetSalesByEmployee() As IList
            Dim columns As New List(Of ColumnDescription)()
            columns.Add(New ColumnDescription() With {
                .PropertyName = "Employee", .PropertyType = GetType(String), .Attributes = New Attribute() {
                    New DisplayAttribute() With {.GroupName = "Employee"}
                }
            })

            For yearIndex As Integer = 10 To 1 Step -1
                Dim year As Integer = Date.Now.Year - yearIndex
                For month As Integer = 1 To 12
                    columns.Add(New ColumnDescription() With {
                        .PropertyName = year & "-" & month, .PropertyType = GetType(Integer), .DisplayName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month), .Attributes = New Attribute() {
                            New DisplayAttribute() With {.GroupName = year & "/Q" & Math.Floor(CDbl(month + 2) / 3)}
                        }
                    })
                Next month
            Next yearIndex

            Dim random As New Random()
            Dim source As New CellSelectionList(columns, True)
            For Each employee As Employee In NWindContext.Create().Employees
                Dim row = New Dictionary(Of String, Object)()
                row("Employee") = employee.FirstName & " " & employee.LastName
                Dim columnIndex As Integer = 1
                Do While columnIndex < columns.Count
                    row(columns(columnIndex).PropertyName) = random.Next(30000)
                    columnIndex += 1
                Loop
                source.Add(row)
            Next employee

            Return source
        End Function
    End Class
    Public NotInheritable Class SalesByYearData

        Private Sub New()
        End Sub

        Public Shared Function GetSalesByYearData(Optional ByVal byMonthReport As Boolean = False) As IList
            Dim columns As New List(Of ColumnDescription)()
            columns.Add(New ColumnDescription() With {.PropertyName = "Date", .PropertyType = GetType(Date)})
            If byMonthReport Then
                columns.Add(New ColumnDescription() With {.PropertyName = "DateMonth", .PropertyType = GetType(Date)})
            End If
            For Each employee As Employee In NWindContext.Create().Employees
                Dim name As String = employee.FirstName & " " & employee.LastName
                columns.Add(New ColumnDescription() With {.PropertyName = name, .PropertyType = GetType(Integer)})
            Next employee

            Dim source As New CellSelectionList(columns, False)

            Dim random As New Random()
            For yearIndex As Integer = 10 To 1 Step -1
                Dim year As Integer = Date.Now.Year - yearIndex
                For month As Integer = 1 To 12
                    Dim daysCount As Integer = If(byMonthReport, DateTime.DaysInMonth(year, month), 1)
                    For day As Integer = 1 To daysCount
                        Dim row As New Dictionary(Of String, Object)()
                        row("Date") = New Date(year, month, day)
                        Dim startColumnIndex As Integer = 1
                        If byMonthReport Then
                            row("DateMonth") = row("Date")
                            startColumnIndex += 1
                        End If
                        For columnIndex As Integer = startColumnIndex To columns.Count - 1
                            row(columns(columnIndex).PropertyName) = random.Next(30000 \ daysCount)
                        Next columnIndex
                        source.Add(row)
                    Next day
                Next month
            Next yearIndex
            Return source
        End Function
    End Class
    Public Class ColumnDescription
        Public Property PropertyName() As String
        Public Property DisplayName() As String
        Public Property PropertyType() As Type
        Public Property Attributes() As Attribute()
    End Class
    Public Class CellSelectionList
        Implements IList, ITypedList

        Private list As List(Of Dictionary(Of String, Object))
        Private columns As PropertyDescriptorCollection
        Public Sub New(ByVal columnNames As List(Of ColumnDescription), ByVal assignAttribute As Boolean)
            list = New List(Of Dictionary(Of String, Object))()

            columns = CreateColumnCollection(columnNames)
        End Sub
        Private Function CreateColumnCollection(ByVal columnDescriptions As List(Of ColumnDescription)) As PropertyDescriptorCollection
            Dim pds(columnDescriptions.Count - 1) As CellSelectionPropertyDescriptor
            For i As Integer = 0 To columnDescriptions.Count - 1
                pds(i) = New CellSelectionPropertyDescriptor(Me, columnDescriptions(i))
            Next i
            Return New PropertyDescriptorCollection(pds)
        End Function

        #Region "ITypedList Members"

        Private Function ITypedList_GetItemProperties(ByVal listAccessors() As PropertyDescriptor) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
            Return columns
        End Function

        Private Function ITypedList_GetListName(ByVal listAccessors() As PropertyDescriptor) As String Implements ITypedList.GetListName
            Return String.Empty
        End Function

        #End Region

        Public Sub SetPropertyValue(ByVal rowIndex As Integer, ByVal column As String, ByVal value As Object)
            list(rowIndex)(column) = value
        End Sub
        Public Function GetPropertyValue(ByVal rowIndex As Integer, ByVal column As String) As Object
            Return list(rowIndex)(column)
        End Function

        #Region "IList Members"

        Public Function Add(ByVal value As Object) As Integer Implements IList.Add
            list.Add(DirectCast(value, Dictionary(Of String, Object)))
            Return -1
        End Function

        Public Sub Clear() Implements IList.Clear
            Throw New NotImplementedException()
        End Sub

        Public Function Contains(ByVal value As Object) As Boolean Implements IList.Contains
            Throw New NotImplementedException()
        End Function

        Public Function IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
            Throw New NotImplementedException()
        End Function

        Public Sub Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
            Throw New NotImplementedException()
        End Sub

        Public ReadOnly Property IsFixedSize() As Boolean Implements IList.IsFixedSize
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property IsReadOnly() As Boolean Implements IList.IsReadOnly
            Get
                Return False
            End Get
        End Property

        Public Sub Remove(ByVal value As Object) Implements IList.Remove
            Throw New NotImplementedException()
        End Sub

        Public Sub RemoveAt(ByVal index As Integer) Implements IList.RemoveAt
            Throw New NotImplementedException()
        End Sub

        Default Public Property Item(ByVal index As Integer) As Object Implements IList.Item
            Get
                Return list(index)
            End Get
            Set(ByVal value As Object)
                Throw New NotImplementedException()
            End Set
        End Property

        #End Region

        #Region "ICollection Members"

        Public Sub CopyTo(ByVal array As Array, ByVal index As Integer) Implements System.Collections.ICollection.CopyTo
            Throw New NotImplementedException()
        End Sub

        Public ReadOnly Property Count() As Integer Implements System.Collections.ICollection.Count
            Get
                Return list.Count
            End Get
        End Property

        Public ReadOnly Property IsSynchronized() As Boolean Implements System.Collections.ICollection.IsSynchronized
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property SyncRoot() As Object Implements System.Collections.ICollection.SyncRoot
            Get
                Return True
            End Get
        End Property

        #End Region

        #Region "IEnumerable Members"

        Public Function GetEnumerator() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Nothing
        End Function

        #End Region
    End Class
    Public Class CellSelectionPropertyDescriptor
        Inherits PropertyDescriptor

        Private ReadOnly columnDescription As ColumnDescription
        Private ReadOnly list As CellSelectionList
        Public Sub New(ByVal list As CellSelectionList, ByVal columnDescription As ColumnDescription)
            MyBase.New(columnDescription.PropertyName, columnDescription.Attributes)
            Me.columnDescription = columnDescription
            Me.list = list
        End Sub
        Public Overrides Function GetValue(ByVal component As Object) As Object
            Return DirectCast(component, Dictionary(Of String, Object))(columnDescription.PropertyName)
        End Function
        Public Overrides Sub SetValue(ByVal component As Object, ByVal val As Object)
            DirectCast(component, Dictionary(Of String, Object))(columnDescription.PropertyName) = val
        End Sub
        Public Overrides Function CanResetValue(ByVal component As Object) As Boolean
            Return False
        End Function
        Public Overrides ReadOnly Property IsReadOnly() As Boolean
            Get
                Return False
            End Get
        End Property
        Public Overrides ReadOnly Property ComponentType() As Type
            Get
                Return GetType(MultiEditorsList)
            End Get
        End Property
        Public Overrides ReadOnly Property PropertyType() As Type
            Get
                Return columnDescription.PropertyType
            End Get
        End Property
        Public Overrides ReadOnly Property DisplayName() As String
            Get
                Return columnDescription.DisplayName
            End Get
        End Property
        Public Overrides Sub ResetValue(ByVal component As Object)
        End Sub
        Public Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
            Return True
        End Function
    End Class
    Public Class SalesByYearDataColumnTemplateSelector
        Inherits DataTemplateSelector

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim context As ColumnGeneratorItemContext = DirectCast(item, ColumnGeneratorItemContext)
            Dim grid As GridControl = CType(container, GridControl)
            Return CType(grid.Resources(If(context.PropertyDescriptor.Name = "Date", "DateColumnTemplate", "EmployeeColumnTemplate")), DataTemplate)
        End Function
    End Class
End Namespace
