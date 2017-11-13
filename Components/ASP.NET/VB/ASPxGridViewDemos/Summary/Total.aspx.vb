Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Summary_Total
	Inherits Page

	Protected Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As ASPxGridViewColumnDataEventArgs)
		If e.Column.FieldName = "Total" Then
			Dim price As Decimal = CDec(e.GetListSourceFieldValue("UnitPrice"))
			Dim quantity As Integer = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"))
			e.Value = price * quantity
		End If
	End Sub

End Class
