Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.XtraGrid

Partial Public Class GroupingSorting_IntervalGrouping
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim intervalGroup As ColumnGroupInterval = CType(System.Enum.Parse(GetType(ColumnGroupInterval), cbGroupInterval.Value.ToString()), ColumnGroupInterval)
		SetGroupInterval(intervalGroup)
	End Sub
	Protected Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As ASPxGridViewColumnDataEventArgs)
		If e.Column.FieldName = "Total" Then
			Dim price As Decimal = CDec(e.GetListSourceFieldValue("UnitPrice"))
			Dim quantity As Integer = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"))
			e.Value = price * quantity
		End If
	End Sub
	Protected Sub grid_CustomCallback(ByVal sender As Object, ByVal e As ASPxGridViewCustomCallbackEventArgs)
		Dim intervalGroup As ColumnGroupInterval = CType(System.Enum.Parse(GetType(ColumnGroupInterval), e.Parameters), ColumnGroupInterval)
		SetGroupInterval(intervalGroup)
	End Sub
	Private Sub SetGroupInterval(ByVal intervalGroup As ColumnGroupInterval)
		CType(grid.Columns("OrderDate"), GridViewDataColumn).Settings.GroupInterval = intervalGroup
		grid.DataBind()
	End Sub
End Class
