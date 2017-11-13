Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Menu_Features
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Return
		End If
		nbMain.AllowExpanding = cbAllowExpanding.Checked
		nbMain.AllowSelectItem = cbAllowSelectItem.Checked
		nbMain.AutoCollapse = cbAutoCollapse.Checked
		nbMain.AutoPostBack = cbAutoPostBack.Checked
		nbMain.EnableHotTrack = cbEnableHotTrack.Checked
		nbMain.EnableAnimation = cbEnableAnimation.Checked
	End Sub
End Class
