Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.Demos

Partial Public Class Features_DataBinding
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ClubMemberCard.ChangeMode(DetailsViewMode.Edit)
		End If
	End Sub

	Protected Sub OnClubMemberDataSourceModifying(ByVal sender As Object, ByVal e As Microsoft.AspNet.EntityDataSource.EntityDataSourceChangingEventArgs)
		If Utils.IsSiteMode Then
			ReadonlyMessageHolder.InnerHtml = Utils.GetReadOnlyMessageHtml()
			e.Cancel = True
		End If
	End Sub
	Protected Sub OnDataBound(ByVal sender As Object, ByVal e As EventArgs)
		Dim detailsView As DetailsView = CType(sender, DetailsView)
		If detailsView.Rows.Count = 0 Then
			detailsView.ChangeMode(DetailsViewMode.Insert)
		End If
	End Sub
End Class
