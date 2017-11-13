Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web

Partial Public Class DataView_EndlessPaging
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			PrepareControls()
		End If
		If IsCallback Then
			' Intentionally pauses server-side processing, 
			' to demonstrate the Loading Panel functionality.
			System.Threading.Thread.Sleep(500)
		End If
	End Sub
	Protected Sub cmbEndlessPagingMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim mode As DataViewEndlessPagingMode = CType(System.Enum.Parse(GetType(DataViewEndlessPagingMode), cmbEndlessPagingMode.Text), DataViewEndlessPagingMode)
		dataView.PagerSettings.EndlessPagingMode = mode
	End Sub
	Private Sub PrepareControls()
		cmbEndlessPagingMode.Items.Add(System.Enum.GetName(GetType(DataViewEndlessPagingMode), DataViewEndlessPagingMode.OnClick))
		cmbEndlessPagingMode.Items.Add(System.Enum.GetName(GetType(DataViewEndlessPagingMode), DataViewEndlessPagingMode.OnScroll))
		cmbEndlessPagingMode.SelectedIndex = 0
		dataView.PagerSettings.EndlessPagingMode = DataViewEndlessPagingMode.OnClick
		dataView.PagerSettings.EllipsisMode = PagerEllipsisMode.None
	End Sub
End Class
