Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class TabControl_Features
	Inherits Page
	Private ReadOnly Property CurrentTabAlign() As TabAlign
		Get
			Return CType(System.Enum.Parse(GetType(TabAlign), ddlTabAlign.SelectedItem.Value.ToString()), TabAlign)
		End Get
	End Property

	Private ReadOnly Property CurrentTabPosition() As TabPosition
		Get
			Return CType(System.Enum.Parse(GetType(TabPosition), ddlTabPosition.SelectedItem.Value.ToString()), TabPosition)
		End Get
	End Property

	Private ReadOnly Property CurrentActivateTabPageAction() As ActivateTabPageAction
		Get
			Return CType(System.Enum.Parse(GetType(ActivateTabPageAction), ddlActivateTabPageAction.SelectedItem.Value.ToString()), ActivateTabPageAction)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Return
		End If
		carTabPage.AutoPostBack = cbAutoPostBack.Checked
		carTabPage.EnableHotTrack = cbEnableHotTrack.Checked
		carTabPage.TabAlign = CurrentTabAlign
		carTabPage.TabPosition = CurrentTabPosition
		carTabPage.ActivateTabPageAction = CurrentActivateTabPageAction
	End Sub
End Class
