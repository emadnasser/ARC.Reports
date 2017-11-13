Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes
Imports System.Xml
Imports DevExpress.Data.Filtering
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Threading
Imports System.Threading
Imports System.ComponentModel
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.Data

Namespace PivotGridDemo.PivotGrid
    Public MustInherit Class BindingCollection
        Inherits CollectionBase
        Implements IBindingList

        Public Overridable Sub OnListChanged(ByVal item As Object)
        End Sub
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
                Return True
            End Get
        End Property

        Private listChangedHandler As ListChangedEventHandler
        Public Custom Event ListChanged As ListChangedEventHandler Implements IBindingList.ListChanged
            AddHandler(ByVal value As ListChangedEventHandler)
                listChangedHandler = DirectCast(System.Delegate.Combine(listChangedHandler, value), ListChangedEventHandler)
            End AddHandler
            RemoveHandler(ByVal value As ListChangedEventHandler)
                listChangedHandler = DirectCast(System.Delegate.Remove(listChangedHandler, value), ListChangedEventHandler)
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs)
                If listChangedHandler IsNot Nothing Then
                    For Each d As ListChangedEventHandler In listChangedHandler.GetInvocationList()
                        d.Invoke(sender, e)
                    Next d
                End If
            End RaiseEvent
        End Event
        Friend Sub OnListChanged(ByVal args As ListChangedEventArgs)
            If listChangedHandler IsNot Nothing Then
                listChangedHandler(Me, args)
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
    Public Class Task
        Private fID As Integer
        Private fName As String
        Private fDate As Date
        Private fPercentComplete As Integer
        Private fComplete As Boolean
        Private fNote As String

        Private fRelationCollection As BindingCollection
        Public Sub New(ByVal relationCollection As BindingCollection, ByVal id As Integer, ByVal name As String, ByVal [date] As Date)
            Me.fRelationCollection = relationCollection
            Me.fID = id
            Me.fName = name
            Me.fDate = [date]
            Me.fPercentComplete = 0
            Me.fComplete = False
            Me.fNote = ""
        End Sub

        Public ReadOnly Property ID() As Integer
            Get
                Return fID
            End Get
        End Property

        Public Property TaskName() As String
            Get
                Return fName
            End Get
            Set(ByVal value As String)
                fName = value
                OnListChanged()
            End Set
        End Property

        Public Property DueDate() As Date
            Get
                Return fDate
            End Get
            Set(ByVal value As Date)
                fDate = value
                OnListChanged()
            End Set
        End Property

        Public Property Complete() As Boolean
            Get
                Return fComplete
            End Get
            Set(ByVal value As Boolean)
                fComplete = value
                If fComplete Then
                    fPercentComplete = 100
                End If
                If (Not fComplete) AndAlso fPercentComplete = 100 Then
                    fPercentComplete = 0
                End If
                OnListChanged()
            End Set
        End Property

        Public Property PercentComplete() As Integer
            Get
                Return fPercentComplete
            End Get
            Set(ByVal value As Integer)
                fPercentComplete = value
                If fPercentComplete < 0 Then
                    fPercentComplete = 0
                End If
                If fPercentComplete > 100 Then
                    fPercentComplete = 100
                End If
                fComplete = fPercentComplete = 100
                OnListChanged()
            End Set
        End Property

        Public Property Note() As String
            Get
                Return fNote
            End Get
            Set(ByVal value As String)
                fNote = value
                OnListChanged()
            End Set
        End Property

        Public ReadOnly Property CategoryName() As String
            Get
                Return GetCategoryByTask(DirectCast(fRelationCollection, TasksWithCategories), Me)
            End Get
        End Property

        Private Shared Function GetCategoryByTask(ByVal collection As TasksWithCategories, ByVal task As Task) As String
            Dim ret As String = ""
            For i As Integer = 0 To collection.fCategories.Count - 1
                If collection.HasCategory(task, collection.fCategories(i)) Then
                    ret &= String.Format("{0}{1}", (If(ret = "", "", ", ")), collection.fCategories(i).CategoryName)
                End If
            Next i
            If ret = "" Then
                ret = "<None>"
            End If
            Return ret
        End Function

        Private Sub OnListChanged()
            fRelationCollection.OnListChanged(Me)
        End Sub
    End Class
    Public Class Category
        Private fID As Integer
        Private fName As String
        Public Sub New(ByVal id As Integer, ByVal name As String)
            Me.fID = id
            Me.fName = name
        End Sub

        Public ReadOnly Property ID() As Integer
            Get
                Return fID
            End Get
        End Property

        Public Property CategoryName() As String
            Get
                Return fName
            End Get
            Set(ByVal value As String)
                fName = value
            End Set
        End Property
    End Class
    Public Class Relation
        Friend fTask As Task
        Friend fCategory As Category
        Public Sub New(ByVal task As Task, ByVal category As Category)
            Me.fTask = task
            Me.fCategory = category
        End Sub
        Public Property TaskName() As String
            Get
                Return fTask.TaskName
            End Get
            Set(ByVal value As String)
                fTask.TaskName = value
            End Set
        End Property
        Public Property DueDate() As Date
            Get
                Return fTask.DueDate
            End Get
            Set(ByVal value As Date)
                fTask.DueDate = value
            End Set
        End Property
        Public ReadOnly Property CategoryName() As String
            Get
                Return fCategory.CategoryName
            End Get
        End Property
        Public Property Complete() As Boolean
            Get
                Return fTask.Complete
            End Get
            Set(ByVal value As Boolean)
                fTask.Complete = value
            End Set
        End Property

        Public Property PercentComplete() As Integer
            Get
                Return fTask.PercentComplete
            End Get
            Set(ByVal value As Integer)
                fTask.PercentComplete = value
            End Set
        End Property

        Public Property Note() As String
            Get
                Return fTask.Note
            End Get
            Set(ByVal value As String)
                fTask.Note = value
            End Set
        End Property
    End Class
    Public Class Tasks
        Inherits BindingCollection

        Public Shared MaxTasks As Integer = 7
        Public Shared Function GetTasks(ByVal collection As TasksWithCategories) As Tasks
            Dim ret As New Tasks()
            Dim rnd As New Random()
            For i As Integer = 0 To MaxTasks - 1
                ret.List.Add(New Task(collection, i + 1, "Task" & (i + 1).ToString(), Date.Today.AddDays(rnd.Next(5))))
                If i = 2 Then
                    ret(i).PercentComplete = 50
                End If
                If i = 6 Then
                    ret(i).PercentComplete = 100
                End If
            Next i
            Return ret
        End Function
        Default Public Property Item(ByVal index As Integer) As Task
            Get
                Return DirectCast(List(index), Task)
            End Get
            Set(ByVal value As Task)
                List(index) = value
            End Set
        End Property
    End Class
    Public Class Categories
        Inherits BindingCollection

        Public Shared MaxCategories As Integer = 6
        Public Shared Function GetCategories(ByVal collection As TasksWithCategories) As Categories
            Dim ret As New Categories()
            Dim names() As String = { "Business", "Competitor", "Favorites", "Gifts", "Goals", "Holiday", "Ideas", "International", "Personal" }
            For i As Integer = 0 To names.Length - 1
                ret.List.Add(New Category(i + 1, names(i)))
            Next i
            Return ret
        End Function
        Default Public Property Item(ByVal index As Integer) As Category
            Get
                Return DirectCast(List(index), Category)
            End Get
            Set(ByVal value As Category)
                List(index) = value
            End Set
        End Property
    End Class
    Public Class TasksWithCategories
        Inherits BindingCollection

        Friend fTasks As Tasks
        Friend fCategories As Categories
        Public Sub New()
            fTasks = Tasks.GetTasks(Me)
            fCategories = Categories.GetCategories(Me)
        End Sub
        Public Shared Function GetTasksWithCategories() As TasksWithCategories
            Dim ret As New TasksWithCategories()
            Dim rnd As New Random()
            For i As Integer = 0 To Tasks.MaxTasks - 1
                For j As Integer = 0 To (1 + rnd.Next(Categories.MaxCategories)) - 1
                    Dim cat As Category = ret.fCategories(rnd.Next(ret.fCategories.Count))
                    If Not ret.HasCategory(ret.fTasks(i), cat) Then
                        ret.List.Add(New Relation(ret.fTasks(i), cat))
                    End If
                Next j
            Next i
            Return ret
        End Function
        Default Public Property Item(ByVal index As Integer) As Relation
            Get
                Return DirectCast(List(index), Relation)
            End Get
            Set(ByVal value As Relation)
                List(index) = value
            End Set
        End Property
        Public Overrides Sub OnListChanged(ByVal item As Object)
            If item Is Nothing Then
                Return
            End If
            For i As Integer = 0 To Me.Count - 1
                If item.Equals(Me(i).fTask) Then
                    Me.OnListChanged(New ListChangedEventArgs(ListChangedType.ItemChanged, i))
                End If
            Next i
        End Sub
        Public Function HasCategory(ByVal task As Task, ByVal category As Category) As Boolean
            For i As Integer = 0 To Me.Count - 1
                If Me(i).fCategory Is category AndAlso Me(i).fTask Is task Then
                    Return True
                End If
            Next i
            Return False
        End Function
    End Class
End Namespace
