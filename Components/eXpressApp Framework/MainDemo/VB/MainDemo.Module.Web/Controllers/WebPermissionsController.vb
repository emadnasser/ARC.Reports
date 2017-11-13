Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.Web
Imports DevExpress.ExpressApp.Web.Editors.ASPx
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.Persistent.Base.Security

Namespace MainDemo.Module.Web.Controllers
    Partial Public Class WebPermissionsController
        Inherits ViewController
        Public Sub New()
            TargetViewType = ViewType.Any
            TargetViewNesting = Nesting.Any
            TargetObjectType = GetType(IPersistentPermission)
        End Sub
        Protected Overloads Overrides Sub OnActivated()
            MyBase.OnActivated()

            Dim permissionsController As PermissionsController = Frame.GetController(Of PermissionsController)()
            AddHandler permissionsController.CollectDescendantPermissionTypes, AddressOf permissionsController_CollectCreatablePermissionTypes
        End Sub

        Private Sub permissionsController_CollectCreatablePermissionTypes(ByVal sender As Object, ByVal e As CollectTypesEventArgs)
            Dim typesToRemove As New List(Of Type)()

            For Each creatableType As Type In e.Types
                If creatableType.IsAssignableFrom(GetType(EditModelPermission)) Then
                    typesToRemove.Add(creatableType)
                End If
            Next creatableType

            For Each type As Type In typesToRemove
                e.Types.Remove(type)
            Next type
        End Sub
        Protected Overloads Overrides Sub OnDeactivated()
            MyBase.OnDeactivated()

            Dim permissionsController As PermissionsController = Frame.GetController(Of PermissionsController)()
            RemoveHandler permissionsController.CollectDescendantPermissionTypes, AddressOf permissionsController_CollectCreatablePermissionTypes
        End Sub
    End Class
End Namespace
