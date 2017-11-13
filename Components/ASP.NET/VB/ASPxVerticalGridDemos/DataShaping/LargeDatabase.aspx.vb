Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Demos
Imports DevExpress.Web

Partial Public Class DataBinding_LargeDatabase
	Inherits Page

	Shared Sub New()
		EmailDataGenerator.Register()
	End Sub

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim ready As Boolean = DatabaseGenerator.IsReady(CreateDatabaseControl.TableKey)
		CreateDatabaseControl.Visible = Not ready
		Demo.Visible = ready
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		VerticalGrid.Settings.HeaderAreaWidth = If(Utils.IsLargeTheme, 130, 100)
		VerticalGrid.DataSourceID = If(rbEntityDevExpress.Checked, "EntityServerModeDataSource", "EntityDataSource")
	End Sub

	Protected Sub grid_CustomRowDisplayText(ByVal sender As Object, ByVal e As ASPxVerticalGridRowDisplayTextEventArgs)
		If e.Row.FieldName = "Size" Then
			e.DisplayText = Utils.FormatSize(e.Value)
		End If
	End Sub
End Class
