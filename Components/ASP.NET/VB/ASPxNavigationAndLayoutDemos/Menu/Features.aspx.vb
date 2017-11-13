Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Menu_Features
	Inherits Page
	Private ReadOnly Property CurrentAutoSeparatorMode() As AutoSeparatorMode
		Get
			Return CType(System.Enum.Parse(GetType(AutoSeparatorMode), ddlAutoSeparators.SelectedItem.Value.ToString()), AutoSeparatorMode)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		mMain.AllowSelectItem = cbAllowSelectItem.Checked
		mMain.AutoPostBack = cbAutoPostBack.Checked
		mMain.EnableAnimation = cbEnableAnimation.Checked
		mMain.EnableHotTrack = cbEnableHotTrack.Checked
		mMain.AutoSeparators = CurrentAutoSeparatorMode
	End Sub

	Protected Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim result As Integer = 0

		lblAppearAfterError.Visible = (Not Integer.TryParse(tbAppearAfter.Text, result)) OrElse result < 0
		If (Not lblAppearAfterError.Visible) Then
			mMain.AppearAfter = result
		End If

		lblDisappearAfterError.Visible = (Not Integer.TryParse(tbDisappearAfter.Text, result)) OrElse result < 0
		If (Not lblDisappearAfterError.Visible) Then
			mMain.DisappearAfter = result
		End If

		lblMaximumDisplayError.Visible = (Not Integer.TryParse(tbMaximumDisplayLevels.Text, result)) OrElse result < 0
		If (Not lblMaximumDisplayError.Visible) Then
			mMain.MaximumDisplayLevels = result
		End If

		lblOpacityError.Visible = (Not Integer.TryParse(tbOpacity.Text, result)) OrElse result < 0 OrElse result > 100
		If (Not lblOpacityError.Visible) Then
			mMain.Opacity = result
		End If
	End Sub
End Class
