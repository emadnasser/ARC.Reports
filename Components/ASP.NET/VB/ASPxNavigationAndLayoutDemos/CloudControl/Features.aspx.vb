Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class CloudControl_Features
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxCloudControl1.ShowValues = cbShowValues.Checked
		ASPxCloudControl1.RankCount = Byte.Parse(ddlRankCount.SelectedItem.Value.ToString())
		Select Case ddlScales.SelectedItem.Value.ToString()
			Case "Linear"
				ASPxCloudControl1.Scale = Scales.Linear
			Case "Logarithmic"
				ASPxCloudControl1.Scale = Scales.Logarithmic
		End Select
	End Sub
End Class
