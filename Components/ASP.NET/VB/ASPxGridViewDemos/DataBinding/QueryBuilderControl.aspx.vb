Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web

Partial Public Class DataBinding_QueryBuilderControl
	Inherits System.Web.UI.Page
	Protected Sub NorthwindDataSource_Init(ByVal sender As Object, ByVal e As EventArgs)
		NorthwindDataSource.ConnectionString = QueryBuilderHelper.NorthwindConnectionString
		NorthwindDataSource.SelectCommand = QueryBuilderHelper.LoadSelectCommand(Session)
	End Sub
	Protected Sub grid_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		SetColumnsWidth(TryCast(sender, ASPxGridView))
	End Sub
	Private Sub SetColumnsWidth(ByVal grid As ASPxGridView)
		Dim demoAreaWidth = 918
		Dim columnWidth = Math.Max(115, demoAreaWidth/grid.Columns.Count)
		For i = 1 To grid.Columns.Count - 1
			grid.Columns(i).MinWidth = columnWidth
		Next i
		grid.Columns(0).MinWidth = demoAreaWidth - (grid.Columns.Count - 1)*columnWidth
	End Sub
End Class
