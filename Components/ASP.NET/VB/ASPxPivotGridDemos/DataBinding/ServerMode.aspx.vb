Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.Web.Demos

Partial Public Class ServerModeDemo
	Inherits Page

	Shared Sub New()
		PivotGridServerModeDataGenerator.Register()
	End Sub

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim ready As Boolean = DatabaseGenerator.IsReady(CreateDatabaseControl.TableKey)
		CreateDatabaseControl.Visible = Not ready
		Demo.Visible = ready
	End Sub

	Protected Sub ASPxPivotGrid1_CustomCallback(ByVal sender As Object, ByVal e As PivotGridCustomCallbackEventArgs)
		ASPxPivotGrid1.ReloadData()
	End Sub
End Class
