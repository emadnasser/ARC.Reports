Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class SiteMap_FlowLayout
	Inherits Page
	Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxSiteMapControl1.FlowLayoutMaximumDisplayItems = Integer.Parse(ddlFlowLayoutMaximumDisplayItems.SelectedItem.Value.ToString())
	End Sub
End Class
