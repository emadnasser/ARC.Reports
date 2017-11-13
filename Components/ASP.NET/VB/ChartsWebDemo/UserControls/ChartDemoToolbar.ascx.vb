Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.XtraCharts.Web

Partial Public Class ChartDemoToolbar
	Inherits System.Web.UI.UserControl
	Private Const appearanceKey As String = "appearanceKey"
	Private Const paletteKey As String = "paletteKey"
	Private webChartControl As WebChartControl
	Private cbAppearance As ASPxComboBox
	Private cbPalette As ASPxComboBox

	Private Sub webChartControl_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If webChartControl IsNot Nothing Then
			Select Case e.Parameter
				Case "Palette"
					If cbPalette IsNot Nothing Then
						Dim paletteName As String = Convert.ToString(cbPalette.Value)
						webChartControl.PaletteName = paletteName
						Page.Session(paletteKey) = paletteName
					End If
				Case "Appearance"
					If cbAppearance IsNot Nothing Then
						Dim appearanceName As String = Convert.ToString(cbAppearance.Value)
						webChartControl.AppearanceName = appearanceName
						Page.Session(appearanceKey) = appearanceName
					End If
					If cbPalette IsNot Nothing Then
						cbPalette.SelectedIndex = cbPalette.Items.IndexOfValue(webChartControl.PaletteName)
						Page.Session(paletteKey) = cbPalette.Value
					End If
			End Select
		End If
	End Sub
	Private Sub PrepareComboBox(ByVal comboBox As ASPxComboBox, ByVal items() As String, ByVal defaultItem As String)
		comboBox.Items.Clear()
		comboBox.Items.AddRange(items)
		comboBox.SelectedIndex = If(defaultItem IsNot Nothing, comboBox.Items.IndexOfValue(defaultItem), 0)
	End Sub
	Private Sub SetWebChartControl(ByVal webChartControl As WebChartControl)
		If Me.webChartControl IsNot Nothing Then
			RemoveHandler webChartControl.CustomCallback, AddressOf webChartControl_CustomCallback
		End If
		Me.webChartControl = webChartControl
		If webChartControl IsNot Nothing Then
			If String.IsNullOrEmpty(webChartControl.ClientSideEvents.EndCallback) Then
				webChartControl.ClientSideEvents.EndCallback = "function (s, e) { SetPaletteComboBox(s, e); }"
			Else
				Dim index As Integer = webChartControl.ClientSideEvents.EndCallback.LastIndexOf("}"c)
				webChartControl.ClientSideEvents.EndCallback = webChartControl.ClientSideEvents.EndCallback.Insert(index, Constants.vbTab & "SetPaletteComboBox(s, e);" & Constants.vbLf)
			End If
			AddHandler webChartControl.CustomCallback, AddressOf webChartControl_CustomCallback
			Dim currentAppearanceName As String = TryCast(Page.Session(appearanceKey), String)
			If (Not String.IsNullOrEmpty(currentAppearanceName)) Then
				webChartControl.AppearanceName = currentAppearanceName
			End If
			Dim currentPaletteName As String = TryCast(Page.Session(paletteKey), String)
			If (Not String.IsNullOrEmpty(currentPaletteName)) Then
				webChartControl.PaletteName = currentPaletteName
			End If
			If cbAppearance IsNot Nothing Then
				PrepareComboBox(cbAppearance, webChartControl.GetAppearanceNames(), webChartControl.AppearanceName)
			End If
			If cbPalette IsNot Nothing Then
				PrepareComboBox(cbPalette, webChartControl.GetPaletteNames(), webChartControl.PaletteName)
			End If
		End If
	End Sub
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim page As ChartBasePage = TryCast(Me.Page, ChartBasePage)
		If page Is Nothing Then
			Return
		End If
		page.ClientScript.RegisterClientScriptBlock(GetType(String), "SetPaletteComboBox", "<script type=""text/javascript"">" & Constants.vbLf & "<!--" & Constants.vbLf & "function SetPaletteComboBox(s, e) {" & Constants.vbLf+ Constants.vbTab & " if (typeof cbPalette != 'undefined') {" & Constants.vbLf + Constants.vbTab + Constants.vbTab & " for (var i = 0; i < cbPalette.GetItemCount(); i++) {" & Constants.vbLf + Constants.vbTab + Constants.vbTab + Constants.vbTab & " if (cbPalette.GetItem(i).value == s.GetChart().paletteName) {" & Constants.vbLf + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab & " cbPalette.SetSelectedIndex(i);" & Constants.vbLf + Constants.vbTab + Constants.vbTab + Constants.vbTab & " }" & Constants.vbLf + Constants.vbTab + Constants.vbTab & " }" & Constants.vbLf + Constants.vbTab & " }" & Constants.vbLf & "}" & Constants.vbLf & "// -->" & Constants.vbLf & "</script>")
		mnuToolbar.AutoSeparators = DevExpress.Web.AutoSeparatorMode.None
		mnuToolbar.Items(5).Visible = page.ShowPaletteComboBox()
		Dim webChartControl As WebChartControl = page.FindWebChartControl()
		If webChartControl IsNot Nothing Then
			Dim mnuAppearance As DevExpress.Web.MenuItem = mnuToolbar.Items.FindByName("mnuAppearance")
			If mnuAppearance IsNot Nothing Then
				cbAppearance = TryCast(mnuAppearance.FindControl("cbAppearance"), ASPxComboBox)
			End If
			Dim mnuPalette As DevExpress.Web.MenuItem = mnuToolbar.Items.FindByName("mnuPalette")
			If mnuPalette IsNot Nothing Then
				cbPalette = TryCast(mnuPalette.FindControl("cbPalette"), ASPxComboBox)
			End If
			SetWebChartControl(webChartControl)
		End If
	End Sub
End Class
