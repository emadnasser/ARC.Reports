Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.Demos

Partial Public Class UserControls_DemoTabs
	Inherits System.Web.UI.UserControl
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim index = 0
		If Utils.CurrentDemoPage IsNot Nothing Then
			For Each page As SourceCodePage In Utils.GetCurrentSourceCodePages()
				Dim tab = DemoPageControl.TabPages.Add(page.Title, page.Title)
				Dim codeViewer = CType(LoadControl("~\UserControls\CodeViewer.ascx"), CodeViewerControl)
				codeViewer.SourceCodePage = page
				codeViewer.Index = index
				Dim currentModel As DemosModel = DemosModel.Instance
				If currentModel IsNot Nothing Then
					codeViewer.DisableTextWrap = DemosModel.Instance.DisableTextWrap
				End If
				tab.Controls.Add(codeViewer)
				index += 1
			Next page
		End If
	End Sub
End Class
