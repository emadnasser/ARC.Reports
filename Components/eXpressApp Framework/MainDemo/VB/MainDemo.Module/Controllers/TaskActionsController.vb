Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Utils
Imports DevExpress.ExpressApp.Editors
Imports System.Collections
Imports DevExpress.Persistent.Base.General
Imports DevExpress.ExpressApp.Security
Imports MainDemo.Module.BusinessObjects

Namespace MainDemo.Module.Controllers
    Partial Public Class TaskActionsController
        Inherits ViewController
        Private setPriorityItem As ChoiceActionItem
        Private setStatusItem As ChoiceActionItem
        Private Sub UpdateSetTaskActionState()
            Dim isGranted As Boolean = True
            For Each selectedObject As Object In View.SelectedObjects
                Dim isPriorityGranted As Boolean = SecuritySystem.IsGranted(New PermissionRequest(ObjectSpace, GetType(DemoTask), SecurityOperations.Write, selectedObject, "Priority"))
                Dim isStatusGranted As Boolean = SecuritySystem.IsGranted(New PermissionRequest(ObjectSpace, GetType(DemoTask), SecurityOperations.Write, selectedObject, "Status"))
                If Not isPriorityGranted Or Not isStatusGranted Then
                    isGranted = False
                End If
            Next selectedObject
            SetTaskAction.Enabled.SetItemValue("SecurityAllowance", isGranted)
        End Sub
        Public Sub New()
            TypeOfView = GetType(ObjectView)
            InitializeComponent()
            RegisterActions(components)

            setPriorityItem = New ChoiceActionItem(CaptionHelper.GetMemberCaption(GetType(DemoTask), "Priority"), Nothing)
            SetTaskAction.Items.Add(setPriorityItem)
            FillItemWithEnumValues(setPriorityItem, GetType(Priority))
            setStatusItem = New ChoiceActionItem(CaptionHelper.GetMemberCaption(GetType(DemoTask), "Status"), Nothing)
            SetTaskAction.Items.Add(setStatusItem)
            FillItemWithEnumValues(setStatusItem, GetType(TaskStatus))
        End Sub
        Private Sub FillItemWithEnumValues(ByVal parentItem As ChoiceActionItem, ByVal enumType As Type)
            For Each current As Object In System.Enum.GetValues(enumType)
                Dim ed As New EnumDescriptor(enumType)
                Dim item As New ChoiceActionItem(ed.GetCaption(current), current)
                item.ImageName = ImageLoader.Instance.GetEnumValueImageName(current)
                parentItem.Items.Add(item)
            Next current
        End Sub
        Private Sub TaskActionsController_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
            AddHandler View.SelectionChanged, AddressOf View_SelectionChanged
            UpdateSetTaskActionState()
        End Sub
        Private Sub View_SelectionChanged(sender As Object, e As EventArgs)
            UpdateSetTaskActionState()
        End Sub
        Private Sub SetTaskAction_Execute(ByVal sender As Object, ByVal args As SingleChoiceActionExecuteEventArgs) Handles SetTaskAction.Execute
            Dim objectSpace As IObjectSpace
            If TypeOf View Is ListView Then
                objectSpace = Application.CreateObjectSpace()
            Else
                objectSpace = View.ObjectSpace
            End If
            Dim objectsToProcess As New ArrayList(args.SelectedObjects)
            If args.SelectedChoiceActionItem.ParentItem Is setPriorityItem Then
                For Each obj As Object In objectsToProcess
                    Dim objInNewObjectSpace As DemoTask = CType(objectSpace.GetObject(obj), DemoTask)
                    objInNewObjectSpace.Priority = CType(args.SelectedChoiceActionItem.Data, Priority)
                Next obj
            ElseIf args.SelectedChoiceActionItem.ParentItem Is setStatusItem Then
                For Each obj As Object In objectsToProcess
                    Dim objInNewObjectSpace As DemoTask = CType(objectSpace.GetObject(obj), DemoTask)
                    objInNewObjectSpace.Status = CType(args.SelectedChoiceActionItem.Data, TaskStatus)
                Next obj
            End If
            If TypeOf View Is DetailView AndAlso (CType(View, DetailView)).ViewEditMode = ViewEditMode.View Then
                objectSpace.CommitChanges()
            End If
            If TypeOf View Is ListView Then
                objectSpace.CommitChanges()
                View.ObjectSpace.Refresh()
            End If
        End Sub
    End Class
End Namespace
