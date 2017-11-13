Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Appearance_DataHeadersDisplayMode
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		pivotGrid.OptionsView.DataHeadersDisplayMode = CType(ddlDataHeadersStyle.SelectedIndex, DevExpress.Web.ASPxPivotGrid.PivotDataHeadersDisplayMode)
		pivotGrid.OptionsView.DataHeadersPopupMinCount = Convert.ToInt32(seDataHeadersLimit.Value)
	End Sub
End Class
