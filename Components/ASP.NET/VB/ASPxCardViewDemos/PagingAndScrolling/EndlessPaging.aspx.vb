Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class PagingAndScrolling_EndlessPaging
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			EndlessPagingModeComboBox.DataSource = System.Enum.GetValues(GetType(CardViewEndlessPagingMode))
			EndlessPagingModeComboBox.DataBind()
			EndlessPagingModeComboBox.SelectedIndex = 0
		End If
		CardView.SettingsPager.EndlessPagingMode = CType(System.Enum.Parse(GetType(CardViewEndlessPagingMode), EndlessPagingModeComboBox.Text), CardViewEndlessPagingMode)
		CardView.Settings.VerticalScrollBarMode = If(EnableScrollingCheckBox.Checked, ScrollBarMode.Visible, ScrollBarMode.Hidden)
	End Sub
End Class
