Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleToolTipController
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
		End Sub

		Private updateValues As Boolean = False
		Private titleStyleToolTip() As String = { "ToolTip Controller component", "<b>ToolTip <i>Controller  </i>component"}
		Private textStyleToolTip() As String = { "Enables you to customize the appearance and behavior of hints displayed for controls or their elements.", "Enables<size=8> you to <size=14>customize <size=8>the appearance and behavior of <u>hints</u> displayed for controls or their elements."}
		Private footerStyleToolTip() As String = { "To learn more, see the help documentation", "<color=Blue>To learn more, see the <u>help documentation"}

		Private Sub ModuleToolTipController_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DevExpress.Tutorials.ControlUtils.CenterControlInParent(lbSample)
			lbSample.Top += 5
			DevExpress.Tutorials.ControlUtils.CenterControlInParent(lbSampleManual)
			lbSampleManual.Top += 5
			DevExpress.Tutorials.ControlUtils.CenterControlInParent(lbStyleSample)
			lbStyleSample.Top += 5
			InitValues()
			InitToolTips()
		End Sub

		Private Sub InitToolTips()
		End Sub


		Private Sub InitValues()
			updateValues = True
			toolTipControllerContentProperties1.Init(toolTipController1, lbSample, "This tooltip is automatically displayed" & vbCrLf & "when the mouse hovers over the control.", "Auto-popup tooltip.", False)
			toolTipControllerContentProperties2.Init(toolTipController1, lbSampleManual, "This tooltip is displayed using the ShowHint method.", "Manually-popup tooltip.", True)
			seAutoPopDelay.Value = toolTipController1.AutoPopDelay
			seInitialDelay.Value = toolTipController1.InitialDelay
			seRoundRadius.Value = toolTipController1.RoundRadius
			ceRounded.Checked = toolTipController1.Rounded
			ceShowBeak.Checked = toolTipController1.ShowBeak
			ceShowShadow.Checked = toolTipController1.ShowShadow
			propertyGrid1.SelectedObject = New DevExpress.Utils.Design.FilterObject(toolTipController1.Appearance, New String() { "BackColor", "BackColor2", "BorderColor", "GradientMode", "Font", "ForeColor", "TextOptions" })
			propertyGrid2.SelectedObject = New DevExpress.Utils.Design.FilterObject(toolTipController1.AppearanceTitle, New String() { "Font", "ForeColor", "TextOptions" })
			Dim arr As Array = System.Enum.GetValues(GetType(ToolTipType))
			For Each type As ToolTipType In arr
                If type = ToolTipType.Default Then
                    Continue For
                End If
				icbType.Properties.Items.Add(New ImageComboBoxItem(type.ToString(), type, -1))
			Next type
			icbType.EditValue = toolTipStyleController.ToolTipType
			chAllowHTML.Checked = toolTipStyleController.AllowHtmlText
			SetStyleTooltip()
			updateValues = False
		End Sub

		Private Sub seAutoPopDelay_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seAutoPopDelay.EditValueChanged
			If updateValues Then
				Return
			End If
			toolTipController1.AutoPopDelay = Convert.ToInt32(seAutoPopDelay.Value)
		End Sub

		Private Sub seInitialDelay_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seInitialDelay.EditValueChanged
			If updateValues Then
				Return
			End If
			toolTipController1.InitialDelay = Convert.ToInt32(seInitialDelay.Value)
		End Sub

		Private Sub seRoundRadius_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seRoundRadius.EditValueChanged
			If updateValues Then
				Return
			End If
			toolTipController1.RoundRadius = Convert.ToInt32(seRoundRadius.Value)
		End Sub

		Private Sub ceRounded_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceRounded.CheckedChanged
			If updateValues Then
				Return
			End If
			toolTipController1.Rounded = ceRounded.Checked
		End Sub

		Private Sub ceShowBeak_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowBeak.CheckedChanged
			If updateValues Then
				Return
			End If
			toolTipController1.ShowBeak = ceShowBeak.Checked
		End Sub

		Private Sub ceShowShadow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowShadow.CheckedChanged
			If updateValues Then
				Return
			End If
			toolTipController1.ShowShadow = ceShowShadow.Checked
		End Sub

		Private Sub pceToolTipLocation_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles pceToolTipLocation.QueryPopUp
			pceToolTipLocation.Properties.PopupFormMinSize = toolTipLocationControl.Size
			pceToolTipLocation.Properties.PopupSizeable = False
		End Sub

		Private Sub pceToolTipLocation_QueryDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryDisplayTextEventArgs) Handles pceToolTipLocation.QueryDisplayText
			e.DisplayText = toolTipLocationControl.ToolTipLocationName
		End Sub

		Private Sub toolTipLocationControl_ToolTipLocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles toolTipLocationControl.ToolTipLocationChanged
			pceToolTipLocation.Refresh()
			Dim args As ToolTipControllerShowEventArgs = toolTipController1.CreateShowArgs()
			args.ToolTip = "Test"
			args.IconType = ToolTipIconType.Information
			args.ImageIndex = -1
			args.IconSize = ToolTipIconSize.Small
			toolTipController1.ShowHint(args, lbSample)
		End Sub

		Private Sub lbSampleManual_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbSampleManual.MouseDown
			Dim args As ToolTipControllerShowEventArgs = toolTipControllerContentProperties2.CreateShowArgs()
			toolTipController1.ShowHint(args, lbSampleManual.PointToScreen(New Point(e.X, e.Y)))
		End Sub

		Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtraTabControl1.SelectedPageChanged
			toolTipController1.HideHint()
		End Sub

		Protected Overrides Sub DoHide()
			toolTipController1.HideHint()
		End Sub

		Private Sub icbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbType.SelectedIndexChanged
			If updateValues Then
				Return
			End If
			toolTipStyleController.ToolTipType = CType(icbType.EditValue, ToolTipType)
			SetStyleTooltip()
		End Sub

		Private Sub chAllowHTML_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chAllowHTML.CheckedChanged
			If updateValues Then
				Return
			End If
			toolTipStyleController.AllowHtmlText = chAllowHTML.Checked
			SetStyleTooltip()
		End Sub

		Private Sub SetStyleTooltip()
			Dim index As Integer = If(toolTipStyleController.AllowHtmlText, 1, 0)
			If toolTipStyleController.ToolTipType = ToolTipType.SuperTip Then
				Dim superToolTip As New DevExpress.Utils.SuperToolTip()
				Dim toolTipItem As New DevExpress.Utils.ToolTipItem()
				toolTipItem.Text = textStyleToolTip(index)
				toolTipItem.Image = My.Resources.note_32x32
				superToolTip.Items.AddTitle(titleStyleToolTip(index))
				superToolTip.Items.Add(toolTipItem)
				superToolTip.Items.AddSeparator()
				superToolTip.Items.AddTitle(footerStyleToolTip(index))
				toolTipStyleController.SetSuperTip(lbStyleSample, superToolTip)
			Else
				toolTipStyleController.SetToolTip(lbStyleSample, textStyleToolTip(index))
				toolTipStyleController.SetTitle(lbStyleSample, titleStyleToolTip(index))
				toolTipStyleController.SetToolTipIconType(lbStyleSample, ToolTipIconType.Information)
			End If
		End Sub
	End Class
End Namespace

