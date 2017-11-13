Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class TotalsLocationDemo
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		pivotGrid.OptionsView.SetBothTotalsLocation(CType(ddlTotalsLocation.SelectedIndex, DevExpress.XtraPivotGrid.PivotTotalsLocation))
	End Sub
End Class
