Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Filtering_FilterRow
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub

	Protected Sub Grid_Load(ByVal sender As Object, ByVal e As EventArgs)
		Grid.Settings.ShowFilterRowMenu = chkFilterRowMenu.Checked
		Grid.SettingsBehavior.FilterRowMode = CType(System.Enum.Parse(GetType(GridViewFilterRowMode), filterRowModeCombo.Text, True), GridViewFilterRowMode)
	End Sub
End Class
