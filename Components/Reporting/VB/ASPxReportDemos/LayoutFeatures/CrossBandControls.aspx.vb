Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class LayoutFeatures_CrossBandControls
	Inherits Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Response.Redirect("~/ReportControls/CrossBand.aspx")
	End Sub
End Class
