Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp.Actions
Imports MainDemo.Module.BusinessObjects

Namespace MainDemo.Module.Controllers
    Partial Public Class FindBySubjectController
        Inherits ViewController
        Public Sub New()
            MyBase.New()
            InitializeComponent()
            RegisterActions(components)
        End Sub
        Private Sub FindBySubjectAction_Execute(ByVal sender As Object, ByVal e As ParametrizedActionExecuteEventArgs) Handles FindBySubjectAction.Execute
            Dim objectSpace As IObjectSpace = Application.CreateObjectSpace()
            Dim paramValue As String = TryCast(e.ParameterCurrentValue, String)

            Dim obj As Object = objectSpace.FindObject(DirectCast(View, ListView).ObjectTypeInfo.Type, CriteriaOperator.Parse(String.Format("Contains([Subject], '{0}')", paramValue)))
            If obj IsNot Nothing Then
                e.ShowViewParameters.CreatedView = Application.CreateDetailView(objectSpace, obj)
            End If
        End Sub

        Private Sub FindBySubjectController_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
            FindBySubjectAction.Active.SetItemValue("ObjectType", DirectCast(View, ListView).ObjectTypeInfo.Type Is GetType(DemoTask))
        End Sub
    End Class
End Namespace
