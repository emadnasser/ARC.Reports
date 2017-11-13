Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.Demos

Partial Public Class Data_LargeDatabase
	Inherits System.Web.UI.Page
	Shared Sub New()
		EmailDataGenerator.Register()
	End Sub

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim ready As Boolean = DatabaseGenerator.IsReady(CreateDatabaseControl.TableKey)
		CreateDatabaseControl.Visible = Not ready
		Demo.Visible = ready
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		CardView.DataSourceID = If(rbEntityDevExpress.Checked, "EntityServerModeDataSource", "EntityDataSource")
	End Sub
End Class
