Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.BaseImpl
Imports MainDemo.Module.BusinessObjects

Namespace MainDemo.Module.Controllers
    Partial Public Class PopupNotesController
        Inherits ViewController
        Public Sub New()
            MyBase.New()
            InitializeComponent()
            RegisterActions(components)
        End Sub
        Private Sub ShowNotesAction_Execute(ByVal sender As Object, ByVal args As PopupWindowShowActionExecuteEventArgs) Handles ShowNotesAction.Execute
            Dim task As DemoTask = CType(View.CurrentObject, DemoTask)
            ObjectSpace.SetModified(task)
            For Each note As Note In args.PopupWindowViewSelectedObjects
                If (Not String.IsNullOrEmpty(task.Description)) Then
                    task.Description += Environment.NewLine
                End If
                task.Description += note.Text
            Next note
            Dim item As ViewItem = (CType(View, DetailView)).FindItem("Description")
            CType(item, PropertyEditor).ReadValue()
            If TypeOf View Is DetailView AndAlso (CType(View, DetailView)).ViewEditMode = ViewEditMode.View Then
                View.ObjectSpace.CommitChanges()
            End If
        End Sub
        Private Sub ShowNotesAction_CustomizePopupWindowParams(ByVal sender As Object, ByVal args As CustomizePopupWindowParamsEventArgs)
            Dim objectSpace As IObjectSpace = Application.CreateObjectSpace(GetType(Note))
            Dim noteListViewId As String = Application.FindLookupListViewId(GetType(Note))
            Dim collectionSource As CollectionSourceBase = Application.CreateCollectionSource(objectSpace, GetType(Note), noteListViewId)
            args.View = Application.CreateListView(noteListViewId, collectionSource, True)
        End Sub
        Private Sub PopupNotesController_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
            ShowNotesAction.Active.SetItemValue("ObjectType", DirectCast(View, DetailView).ObjectTypeInfo.Type Is GetType(DemoTask))
        End Sub
    End Class
End Namespace
