Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web

Partial Public Class Columns_DataCellBands
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Grid.SettingsBehavior.ColumnMoveMode = CType(ColumnMoveMode.Value, GridColumnMoveMode)
	End Sub
End Class
