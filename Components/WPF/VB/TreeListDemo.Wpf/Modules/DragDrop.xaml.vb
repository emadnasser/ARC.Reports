Imports System
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.DemoBase.DataClasses
Imports DevExpress.Xpf.Bars
Imports System.Collections.ObjectModel
Imports System.Collections.Generic
Imports System.Collections
Imports DevExpress.Mvvm

Namespace TreeListDemo
    Partial Public Class DragDrop
        Inherits TreeListDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub dragDropManager_Drop(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.DragDrop.TreeListDropEventArgs)
            If e.TargetNode IsNot Nothing Then
                For Each obj As Object In e.DraggedRows
                    UpdateNode(e.TargetNode, e.SourceManager, obj)
                Next obj
            End If
        End Sub
        Private Sub UpdateNode(ByVal targetNode As TreeListNode, ByVal sourceManager As DragDropManagerBase, ByVal obj As Object)
            TryCast(sourceManager.GetObject(obj), Employee).GroupName = (TryCast(targetNode.Content, Employee)).GroupName
            Dim node As TreeListNode = TryCast(obj, TreeListNode)
            If node Is Nothing OrElse (Not node.HasChildren) Then
                Return
            End If
            For Each subObject As Object In node.Nodes
                UpdateNode(targetNode, sourceManager, subObject)
            Next subObject
        End Sub

        Private Sub BarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim barItem As BarButtonItem = TryCast(sender, BarButtonItem)
            If barItem Is Nothing Then
                Return
            End If
            Dim groupName As String = TryCast(barItem.Content, String)

            treeList.BeginDataUpdate()
            For Each empl As Employee In view.DataControl.SelectedItems
                empl.GroupName = groupName
            Next empl
            treeList.EndDataUpdate()
        End Sub
    End Class

    Public Class DragDropViewModel
        Inherits BindableBase

        Public Sub New()
            SelectionMode = MultiSelectMode.Row
            DragDropSourceGenerator.InitSources(Me)
        End Sub

        Private selectionModeCore As MultiSelectMode
        Public Property SelectionMode() As MultiSelectMode
            Get
                Return selectionModeCore
            End Get
            Set(ByVal value As MultiSelectMode)
                SetProperty(selectionModeCore, value, Function() SelectionMode)
            End Set
        End Property
        Private privateActiveEmployees As ObservableCollection(Of Employee)
        Public Property ActiveEmployees() As ObservableCollection(Of Employee)
            Get
                Return privateActiveEmployees
            End Get
            Friend Set(ByVal value As ObservableCollection(Of Employee))
                privateActiveEmployees = value
            End Set
        End Property
        Private privateNewEmployees As ObservableCollection(Of Employee)
        Public Property NewEmployees() As ObservableCollection(Of Employee)
            Get
                Return privateNewEmployees
            End Get
            Friend Set(ByVal value As ObservableCollection(Of Employee))
                privateNewEmployees = value
            End Set
        End Property
    End Class
End Namespace
