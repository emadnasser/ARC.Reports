Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleColorPickEdit
		Inherits TutorialControl

		Private updateValues As Boolean = False

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleColorPickEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "coloredit.xml"
		End Sub
		Private Sub ModuleColorEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DevExpress.Tutorials.ControlUtils.CenterControlInParent(colorEditSample)
			InitComboBoxes()
			InitValues()
		End Sub
		Private Sub InitComboBoxes()
			' <icbColorText>
			icbColorText.Properties.Items.AddEnum(GetType(ColorText))
			' </icbColorText>
			' <icbColorAlignment>
			icbColorAlignment.Properties.Items.AddEnum(GetType(HorzAlignment))
			' </icbColorAlignment>
			' <icbShowTabs>
			icbShowTabs.Properties.Items.AddEnum(GetType(ShowTabs))
			' </icbShowTabs>
			' <icbShowArrows>
			icbShowArrows.Properties.Items.AddEnum(GetType(ShowArrows))
			' </icbShowArrows>
			' <icbTooltipMode>
			icbTooltipMode.Properties.Items.AddEnum(GetType(ColorTooltipFormat))
			' </icbTooltipMode>
		End Sub
		Private Sub InitValues()
			updateValues = True
			icbColorAlignment.EditValue = colorEditSample.Properties.ColorAlignment
			icbColorText.EditValue = colorEditSample.Properties.ColorText
			ceShowColorDialog.Checked = colorEditSample.Properties.ShowColorDialog
			ceAsInteger.Checked = colorEditSample.Properties.StoreColorAsInteger

			icbShowTabs.EditValue = colorEditSample.Properties.ColorDialogOptions.ShowTabs
			icbShowArrows.EditValue = colorEditSample.Properties.ColorDialogOptions.ShowArrows
			icbTooltipMode.EditValue = colorEditSample.Properties.TooltipFormat
			ceShowMakeWebSafeBtn.Checked = colorEditSample.Properties.ColorDialogOptions.ShowMakeWebSafeButton
			ceShowPreview.Checked = colorEditSample.Properties.ColorDialogOptions.ShowPreview
			ceAllowTransparency.Checked = colorEditSample.Properties.ColorDialogOptions.AllowTransparency

			ceShowCustomTab.Checked = colorEditSample.Properties.ShowCustomColors
			ceShowWebTab.Checked = colorEditSample.Properties.ShowWebColors
			ceShowSystemTab.Checked = colorEditSample.Properties.ShowSystemColors
            ceShowWebSafeTab.Checked = colorEditSample.Properties.ShowWebSafeColors
            ceShowMoreColorsButton.Checked = colorEditSample.Properties.ShowMoreColorsButton
            ceShowAutomaticButton.Checked = colorEditSample.Properties.ShowAutomaticButton
            updateValues = False
		End Sub

		' <icbColorAlignment>
		Private Sub icbColorAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbColorAlignment.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			colorEditSample.Properties.ColorAlignment = CType(icbColorAlignment.EditValue, HorzAlignment)
		End Sub
		' </icbColorAlignment>

		' <icbColorText>
		Private Sub icbColorText_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbColorText.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			colorEditSample.Properties.ColorText = CType(icbColorText.EditValue, ColorText)
		End Sub
		' </icbColorText>

		' <ceShowColorDialog>
		Private Sub ceShowColorDialog_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowColorDialog.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			colorEditSample.Properties.ShowColorDialog = ceShowColorDialog.Checked
		End Sub
		' </ceShowColorDialog>

		' <ceAsInteger>
		Private Sub ceIsInteger_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceAsInteger.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			colorEditSample.Properties.StoreColorAsInteger = ceAsInteger.Checked
		End Sub
		' </ceAsInteger>
		' <icbShowTabs>
		Private Sub icbShowTabs_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbShowTabs.SelectedIndexChanged
			If updateValues Then
				Return
			End If
			colorEditSample.Properties.ColorDialogOptions.ShowTabs = CType(icbShowTabs.EditValue, ShowTabs)
		End Sub
		' </icbShowTabs>
		' <icbShowArrows>
		Private Sub icbShowArrows_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbShowArrows.SelectedIndexChanged
			If updateValues Then
				Return
			End If
			colorEditSample.Properties.ColorDialogOptions.ShowArrows = CType(icbShowArrows.EditValue, ShowArrows)
		End Sub
		' </icbShowArrows>
		' <icbTooltipMode>
		Private Sub icbTooltipMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbTooltipMode.SelectedIndexChanged
			If updateValues Then
				Return
			End If
			colorEditSample.Properties.TooltipFormat = CType(icbTooltipMode.EditValue, ColorTooltipFormat)
		End Sub
		' </icbTooltipMode>
		' <ceShowMakeWebSafeBtn>
		Private Sub ceShowMakeWebSafeBtn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowMakeWebSafeBtn.CheckedChanged
			If updateValues Then
				Return
			End If
			colorEditSample.Properties.ColorDialogOptions.ShowMakeWebSafeButton = ceShowMakeWebSafeBtn.Checked
		End Sub
		' </ceShowMakeWebSafeBtn>
		' <ceShowPreview>
		Private Sub ceShowPreview_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowPreview.CheckedChanged
			If updateValues Then
				Return
			End If
			colorEditSample.Properties.ColorDialogOptions.ShowPreview = ceShowPreview.Checked
		End Sub
		' </ceShowPreview>
		' <ceAllowTransparency>
		Private Sub ceAllowTransparency_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowTransparency.CheckedChanged
			If updateValues Then
				Return
			End If
			colorEditSample.Properties.ColorDialogOptions.AllowTransparency = ceAllowTransparency.Checked
		End Sub
		' </ceAllowTransparency>
		Private Sub SetButtonEnabled(ByVal enabled As Boolean)
			seAdd.Enabled = enabled
			seClear.Enabled = Not enabled
		End Sub
		' <ceShowCustom>
		Private Sub ceShowCustom_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowCustomTab.CheckedChanged
			If updateValues Then
				Return
			End If
			colorEditSample.Properties.ShowCustomColors = ceShowCustomTab.Checked
		End Sub
		' </ceShowCustom>
		' <ceShowWeb>
		Private Sub ceShowWebSafe_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowWebSafeTab.CheckedChanged
			If updateValues Then
				Return
			End If
			colorEditSample.Properties.ShowWebSafeColors = ceShowWebSafeTab.Checked
		End Sub
		' </ceShowWeb>
		' <ceShowSystem>
		Private Sub ceShowSystem_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowSystemTab.CheckedChanged
			If updateValues Then
				Return
			End If
			colorEditSample.Properties.ShowSystemColors = ceShowSystemTab.Checked
		End Sub
		' </ceShowSystem>
		' <ceShowWebColors>
		Private Sub ceShowWebColors_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowWebTab.CheckedChanged
			If updateValues Then
				Return
			End If
			colorEditSample.Properties.ShowWebColors = ceShowWebTab.Checked
		End Sub
        ' </ceShowWebColors>
        ' <ceShowAutomaticButton>
        Private Sub ceShowAutomaticButton_CheckedChanged(sender As Object, e As EventArgs) Handles ceShowAutomaticButton.CheckedChanged
            If updateValues Then
                Return
            End If
            colorEditSample.Properties.ShowAutomaticButton = ceShowAutomaticButton.Checked
        End Sub
        ' </ceShowAutomaticButton>
        ' <ceShowMoreColorsButton>
        Private Sub ceShowMoreColorsButton_CheckedChanged(sender As Object, e As EventArgs) Handles ceShowMoreColorsButton.CheckedChanged
            If updateValues Then
                Return
            End If
            colorEditSample.Properties.ShowMoreColorsButton = ceShowMoreColorsButton.Checked
        End Sub
        ' </ceShowMoreColorsButton>
        ' <seAdd>
        Private Sub seAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles seAdd.Click
            For Each color As Color In GetColorArray()
                colorEditSample.Properties.RecentColors.InsertColor(color)
            Next color
            SetButtonEnabled(False)
		End Sub
		' </seAdd>
		' <seClear>
		Private Sub seClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles seClear.Click
            colorEditSample.Properties.RecentColors.Clear()
			SetButtonEnabled(True)
		End Sub
		' </seClear>
        Private Const recentColorCount As Integer = 10
        Private Function GetColorArray() As Color()
            Dim rnd As New Random()
            Dim ret(recentColorCount - 1) As Color
            For i As Integer = 0 To ret.Length - 1
                ret.SetValue((Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))), i)
            Next i
            Return ret
        End Function
	End Class
End Namespace
