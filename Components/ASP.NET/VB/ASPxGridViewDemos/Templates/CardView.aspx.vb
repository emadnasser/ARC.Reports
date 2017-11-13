Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Templates_CardView
	Inherits Page
	Protected Sub chkShowHeaders_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		grid.Settings.ShowColumnHeaders = chkShowHeaders.Checked
	End Sub
End Class
