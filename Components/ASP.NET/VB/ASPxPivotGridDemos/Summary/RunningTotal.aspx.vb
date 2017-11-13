Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class SummaryVariationDemo
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPivotGrid1.Fields("fieldQuarter").RunningTotal = cbRunningTotals.Checked
		ASPxPivotGrid1.OptionsData.AllowCrossGroupVariation = cbAllowCrossGroupRunningTotals.Checked
	End Sub
End Class
