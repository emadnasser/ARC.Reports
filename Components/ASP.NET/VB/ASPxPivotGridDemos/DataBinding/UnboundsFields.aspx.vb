Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxPivotGrid

Partial Public Class UnboundFieldsDemo
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub pivotGrid_CustomUnboundFieldData(ByVal sender As Object, ByVal e As CustomFieldDataEventArgs)
		If Object.ReferenceEquals(e.Field, fieldSalesPerson) Then
			e.Value = String.Format(salesPersonFormat.SelectedItem.Value.ToString(), e.GetListSourceColumnValue("FirstName"), e.GetListSourceColumnValue("LastName"))
		End If
		If Object.ReferenceEquals(e.Field, fieldOrderAmount) Then
			Dim discount As Double = If(orderAmountRule.SelectedItem.Value.ToString() = "1", Convert.ToDouble(e.GetListSourceColumnValue("Discount")), 0)
			e.Value = Convert.ToDouble(e.GetListSourceColumnValue("UnitPrice")) * Convert.ToDouble(e.GetListSourceColumnValue("Quantity")) * (1 - discount)
		End If
	End Sub
	Protected Sub pivotGrid_CustomCellDisplayText(ByVal sender As Object, ByVal e As PivotCellDisplayTextEventArgs)
		If Object.ReferenceEquals(e.DataField, fieldPercent) Then
			Dim orderAmountField As PivotGridField = fieldOrderAmount
			Dim orderAmount As Object = e.GetCellValue(orderAmountField)
			If orderAmount Is Nothing Then
				Return
			End If
			Dim grandTotalOrderAmount As Decimal = CDec(e.GetRowGrandTotal(orderAmountField))
			If grandTotalOrderAmount = 0 Then
				Return
			End If
			Dim perc As Decimal = CDec(orderAmount) / grandTotalOrderAmount
			e.DisplayText = String.Format("{0:p}", perc)
		End If
		'The Bonus Amount field displays 15% if the order amount is greater than $50,000, or 10% of the amount is less.
		If Object.ReferenceEquals(e.DataField, fieldBonusAmount) Then
			Dim orderAmountField As PivotGridField = fieldOrderAmount
			Dim orderAmount As Object = e.GetCellValue(orderAmountField)
			Dim perc As Double = If(orderAmount IsNot Nothing AndAlso CDec(orderAmount) > 50000, 0.15, 0.1)
			e.DisplayText = If(e.RowValueType = DevExpress.XtraPivotGrid.PivotGridValueType.Value, String.Format("{0:p}", perc), "")
		End If

	End Sub
	Protected Sub salesPersonFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		pivotGrid.DataBind()
	End Sub
End Class
