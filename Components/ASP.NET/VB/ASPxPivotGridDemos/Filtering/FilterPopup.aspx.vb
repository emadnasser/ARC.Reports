Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxPivotGrid

Partial Public Class FilterPopup
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ASPxPivotGrid1.Fields("Category").FilterValues.ValuesIncluded = New Object() { "Beverages" }
		End If
		ASPxPivotGrid1.OptionsFilter.ShowOnlyAvailableItems = cbShowOnlyAvailableItems.Checked
		ASPxPivotGrid1.ReloadData()
		Page.ClientScript.RegisterStartupScript(Me.GetType(), "startup", "setTimeout(""showFilterPopup('Product')"", 500)", True)
	End Sub
	Protected Sub cbShowHiddenItems_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPivotGrid1.OptionsFilter.ShowHiddenItems = cbShowHiddenItems.Checked
	End Sub
	Protected Sub cbShowOnlyAvailableItems_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		cbShowHiddenItems.Enabled = cbShowOnlyAvailableItems.Checked
	End Sub
	Protected Sub cbNativeCheckBoxes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPivotGrid1.OptionsFilter.NativeCheckBoxes = cbNativeCheckBoxes.Checked
	End Sub
End Class
