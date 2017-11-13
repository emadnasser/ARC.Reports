Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.Threading
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleRangeTrackBar
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleRangeTrackBar.vb"
			TutorialInfo.WhatsThisXMLFile = "rangetrackbar.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleRangeTrackBar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			SetDefaultProgressBarPosition()
			InitComboBoxes()
			InitValues()
		End Sub

		Private Sub SetDefaultProgressBarPosition()
			UpdateTrackBarBounds(rangeTrackBarControl1)
		End Sub

		Private Sub UpdateTrackBarBounds(ByVal trackBar As TrackBarControl)
			If trackBar.Properties.Orientation = Orientation.Horizontal Then
				ControlUtils.HorzAlignControlInParent(trackBar, 16)
			Else
				ControlUtils.VertAlignControlInParent(trackBar, 32)
			End If
			ControlUtils.CenterControlInParent(trackBar)
		End Sub

		Private Sub InitComboBoxes()
			icbTickStyle.Properties.Items.AddEnum(GetType(TickStyle))
		End Sub


		Private Sub InitValues()
			updateValues = True
			checkEditVertical.Checked = rangeTrackBarControl1.Properties.Orientation = Orientation.Vertical
			icbTickStyle.EditValue = rangeTrackBarControl1.Properties.TickStyle
			seMinimum.Value = rangeTrackBarControl1.Properties.Minimum
			seMaximum.Value = rangeTrackBarControl1.Properties.Maximum
			seSmallChange.Value = rangeTrackBarControl1.Properties.SmallChange
			seLargeChange.Value = rangeTrackBarControl1.Properties.LargeChange
			seTickFrequency.Value = rangeTrackBarControl1.Properties.TickFrequency
			ceShowValue.Checked = rangeTrackBarControl1.Properties.ShowValueToolTip
			ceShowCustomValue.Enabled = rangeTrackBarControl1.Properties.ShowValueToolTip
			updateValues = False
			ShowValue()
		End Sub

		'<checkEditVertical>
		Private Sub checkEditVertical_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditVertical.CheckedChanged
			If updateValues Then
				Return
			End If
			rangeTrackBarControl1.Properties.Orientation = If(checkEditVertical.Checked, Orientation.Vertical, Orientation.Horizontal)
			UpdateTrackBarBounds(rangeTrackBarControl1)
		End Sub
		'</checkEditVertical>

		'<icbTickStyle>
		Private Sub icbTickStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbTickStyle.SelectedIndexChanged
			If updateValues Then
				Return
			End If
			rangeTrackBarControl1.Properties.TickStyle = CType(icbTickStyle.EditValue, TickStyle)
		End Sub
		'</icbTickStyle>

		'<seMinimum>
		Private Sub seMinimum_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seMinimum.EditValueChanged
			If updateValues Then
				Return
			End If
			rangeTrackBarControl1.Properties.Minimum = TutorialHelper.ConvertToInt(seMinimum.Value)
			seMinimum.Value = rangeTrackBarControl1.Properties.Minimum
		End Sub
		'</seMinimum>

		'<seMaximum>
		Private Sub seMaximum_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seMaximum.EditValueChanged
			If updateValues Then
				Return
			End If
			rangeTrackBarControl1.Properties.Maximum = TutorialHelper.ConvertToInt(seMaximum.Value)
			seMaximum.Value = rangeTrackBarControl1.Properties.Maximum
		End Sub
		'</seMaximum>

		'<seSmallChange>
		Private Sub seSmallChange_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seSmallChange.EditValueChanged
			If updateValues Then
				Return
			End If
			rangeTrackBarControl1.Properties.SmallChange = TutorialHelper.ConvertToInt(seSmallChange.Value)
			seSmallChange.Value = rangeTrackBarControl1.Properties.SmallChange
		End Sub
		'</seSmallChange>

		'<seLargeChange>
		Private Sub seLargeChange_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seLargeChange.EditValueChanged
			If updateValues Then
				Return
			End If
			rangeTrackBarControl1.Properties.LargeChange = TutorialHelper.ConvertToInt(seLargeChange.Value)
			seLargeChange.Value = rangeTrackBarControl1.Properties.LargeChange
		End Sub
		'</seLargeChange>

		'<seTickFrequency>
		Private Sub seTickFrequency_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seTickFrequency.EditValueChanged
			If updateValues Then
				Return
			End If
			rangeTrackBarControl1.Properties.TickFrequency = TutorialHelper.ConvertToInt(seTickFrequency.Value)
			seTickFrequency.Value = rangeTrackBarControl1.Properties.TickFrequency
		End Sub
		'</seTickFrequency>
		Private Sub rangeTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rangeTrackBarControl1.EditValueChanged
			ShowValue()
		End Sub
		Private Sub ShowValue()
			lbValue.Text = rangeTrackBarControl1.Value.ToString()
		End Sub
		'<ceShowValue>
		Private Sub ceShowValue_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowValue.CheckedChanged
			If updateValues Then
				Return
			End If
			rangeTrackBarControl1.Properties.ShowValueToolTip = ceShowValue.Checked
			ceShowCustomValue.Enabled = rangeTrackBarControl1.Properties.ShowValueToolTip
		End Sub
		'</ceShowValue>

		'<ceShowCustomValue>
		Private Sub rangeTrackBarControl1_BeforeShowValueToolTip(ByVal sender As Object, ByVal e As TrackBarValueToolTipEventArgs) Handles rangeTrackBarControl1.BeforeShowValueToolTip
			If Not ceShowCustomValue.Checked Then
				Return
			End If
			e.ShowArgs.ToolTip = String.Format("Interval = [{0}; {1}]", rangeTrackBarControl1.Value.Minimum, rangeTrackBarControl1.Value.Maximum)
		End Sub
		'</ceShowCustomValue>
	End Class
End Namespace

