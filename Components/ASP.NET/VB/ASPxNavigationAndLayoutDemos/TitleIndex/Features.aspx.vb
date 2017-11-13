Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports System.Web.UI.WebControls

Partial Public Class TitleIndex_IndexPanel
	Inherits Page
	Private ReadOnly Property CurrentIndexPanelBehavior() As IndexPanelBehavior
		Get
			Return CType(System.Enum.Parse(GetType(IndexPanelBehavior), ddlBehavior.SelectedItem.Value.ToString()), IndexPanelBehavior)
		End Get
	End Property
	Private ReadOnly Property CurrentIndexPanelPosition() As PagerPosition
		Get
			Return CType(System.Enum.Parse(GetType(PagerPosition), ddlPosition.SelectedItem.Value.ToString()), PagerPosition)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Return
		End If
		ASPxTitleIndex1.IndexPanel.Behavior = CurrentIndexPanelBehavior
		ASPxTitleIndex1.IndexPanel.Position = CurrentIndexPanelPosition
		ASPxTitleIndex1.ShowBackToTop = cbShowBackToTop.Checked
		ASPxTitleIndex1.Categorized = cbCategorized.Checked
	End Sub

	Protected Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim result As Integer = 0
		lblColumnCountError.Visible = (Not Integer.TryParse(tbColumnCount.Text, result)) OrElse result <= 0
		If (Not lblColumnCountError.Visible) Then
			ASPxTitleIndex1.ColumnCount = CByte(result)
		End If
	End Sub
End Class
