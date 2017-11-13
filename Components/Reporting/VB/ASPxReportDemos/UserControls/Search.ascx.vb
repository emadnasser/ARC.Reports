Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class UserControls_Search
	Inherits System.Web.UI.UserControl
	Public Property FocusOnLoad() As Boolean

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If FocusOnLoad Then
			TbSearch.Focus()
		End If

		If Utils.IsAccessibilityDemo Then
			TbSearch.NullText = "Search"
		End If
	End Sub
	Protected Sub SearchPopup_WindowCallback(ByVal source As Object, ByVal e As DevExpress.Web.PopupWindowCallbackArgs)
		Dim text = e.Parameter
		Dim results = SearchUtils.DoSearch(text)
		Dim resultsPanel = SearchPopup.FindControl("ResultsPanel")
		Dim noResultsPanel = SearchPopup.FindControl("NoResultsPanel")
		If results.Count > 0 Then
			resultsPanel.Visible = True
			noResultsPanel.Visible = False
			Dim grouppedResults = results.GroupBy(Function(sr) sr.Product)
			For Each productGroup In grouppedResults
				Dim product = productGroup.Key
				Dim group = SearchResultsNavBar.Groups.Add(product.NavItemTitle.ToUpper(), String.Empty, String.Empty, Utils.GenerateDemoUrl(product.Intro))
				For Each res In productGroup
					group.Items.Add(res.Text, String.Empty, String.Empty, Utils.GenerateDemoUrl(res.Demo))
				Next res
			Next productGroup
		Else
			resultsPanel.Visible = False
			noResultsPanel.Visible = True
			Dim requestText = TryCast(noResultsPanel.FindControl("RequestText"), HtmlGenericControl)
			requestText.InnerHtml = text
		End If
	End Sub
End Class
