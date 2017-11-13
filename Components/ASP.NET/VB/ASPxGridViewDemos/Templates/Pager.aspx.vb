Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Templates_Pager
	Inherits Page
	Private Const PageSizeSessionKey As String = "ed5e843d-cff7-47a7-815e-832923f7fb09"

	Protected Property GridPageSize() As Integer
		Get
			If Session(PageSizeSessionKey) Is Nothing Then
				Return Grid.SettingsPager.PageSize
			End If
			Return CInt(Fix(Session(PageSizeSessionKey)))
		End Get
		Set(ByVal value As Integer)
			Session(PageSizeSessionKey) = value
		End Set
	End Property

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Grid.SettingsPager.PageSize = GridPageSize
	End Sub

	Protected Sub Grid_CustomCallback(ByVal sender As Object, ByVal e As ASPxGridViewCustomCallbackEventArgs)
		GridPageSize = Integer.Parse(e.Parameters)
		Grid.SettingsPager.PageSize = GridPageSize
		Grid.DataBind()
	End Sub

	Protected Sub PagerCombo_Load(ByVal sender As Object, ByVal e As EventArgs)
		TryCast(sender, ASPxComboBox).Value = Grid.SettingsPager.PageSize
	End Sub
End Class
