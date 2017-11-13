Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.Threading
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleTrackBar
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleTrackBar.vb"
			TutorialInfo.WhatsThisXMLFile = "TrackBar.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleTrackBar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			SetDefaultProgressBarPosition()
			InitComboBoxes()
			InitValues()
			CalcNewLocation()
		End Sub

		Private Sub SetDefaultProgressBarPosition()
			UpdateTrackBarBounds(trackBarControl1)
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
			checkEditVertical.Checked = trackBarControl1.Properties.Orientation = Orientation.Vertical
			icbTickStyle.EditValue = trackBarControl1.Properties.TickStyle
			seMinimum.Value = trackBarControl1.Properties.Minimum
			seMaximum.Value = trackBarControl1.Properties.Maximum
			seLabelDistance.Value = trackBarControl1.Properties.DistanceFromTickToLabel
			seSmallChange.Value = trackBarControl1.Properties.SmallChange
			seLargeChange.Value = trackBarControl1.Properties.LargeChange
			seTickFrequency.Value = trackBarControl1.Properties.TickFrequency
			ceShowValue.Checked = trackBarControl1.Properties.ShowValueToolTip
			ceShowCustomValue.Enabled = trackBarControl1.Properties.ShowValueToolTip
			ceShowTickLabels.Checked = trackBarControl1.Properties.ShowLabels
			updateValues = False
		End Sub

		'<checkEditVertical>
		Private Sub checkEditVertical_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditVertical.CheckedChanged
			If updateValues Then
				Return
			End If
			trackBarControl1.Properties.Orientation = If(checkEditVertical.Checked, Orientation.Vertical, Orientation.Horizontal)
			UpdateTrackBarBounds(trackBarControl1)
			CalcNewLocation()
		End Sub
		'</checkEditVertical>

		'<icbTickStyle>
		Private Sub icbTickStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbTickStyle.SelectedIndexChanged
			If updateValues Then
				Return
			End If
			trackBarControl1.Properties.TickStyle = CType(icbTickStyle.EditValue, TickStyle)
			CalcNewLocation()
		End Sub
		'</icbTickStyle>

		'<seMinimum>
		Private Sub seMinimum_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seMinimum.EditValueChanged
			If updateValues Then
				Return
			End If
			trackBarControl1.Properties.Minimum = TutorialHelper.ConvertToInt(seMinimum.Value)
			seMinimum.Value = trackBarControl1.Properties.Minimum
			If trackBarControl1.Properties.ShowLabels Then
				CreateNewLabelCollection()
				CalcNewLocation()
			End If
		End Sub
		'</seMinimum>

		'<seMaximum>
		Private Sub seMaximum_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seMaximum.EditValueChanged
			If updateValues Then
				Return
			End If
			trackBarControl1.Properties.Maximum = TutorialHelper.ConvertToInt(seMaximum.Value)
			seMaximum.Value = trackBarControl1.Properties.Maximum
			If trackBarControl1.Properties.ShowLabels Then
				CreateNewLabelCollection()
				CalcNewLocation()
			End If
		End Sub
		'</seMaximum>

		'<seSmallChange>
		Private Sub seSmallChange_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seSmallChange.EditValueChanged
			If updateValues Then
				Return
			End If
			trackBarControl1.Properties.SmallChange = TutorialHelper.ConvertToInt(seSmallChange.Value)
			seSmallChange.Value = trackBarControl1.Properties.SmallChange
		End Sub
		'</seSmallChange>

		'<seLargeChange>
		Private Sub seLargeChange_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seLargeChange.EditValueChanged
			If updateValues Then
				Return
			End If
			trackBarControl1.Properties.LargeChange = TutorialHelper.ConvertToInt(seLargeChange.Value)
			seLargeChange.Value = trackBarControl1.Properties.LargeChange
		End Sub
		'</seLargeChange>

		'<seTickFrequency>
		Private Sub seTickFrequency_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seTickFrequency.EditValueChanged
			If updateValues Then
				Return
			End If
			trackBarControl1.Properties.TickFrequency = TutorialHelper.ConvertToInt(seTickFrequency.Value)
			seTickFrequency.Value = trackBarControl1.Properties.TickFrequency
		End Sub
		'</seTickFrequency>
		'<ceShowValue>
		Private Sub ceShowValue_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowValue.CheckedChanged
			If updateValues Then
				Return
			End If
			trackBarControl1.Properties.ShowValueToolTip = ceShowValue.Checked
			ceShowCustomValue.Enabled = trackBarControl1.Properties.ShowValueToolTip
		End Sub
		'</ceShowValue>
		'<ceShowCustomValue>
		Private Sub trackBarControl1_BeforeShowValueToolTip(ByVal sender As Object, ByVal e As TrackBarValueToolTipEventArgs) Handles trackBarControl1.BeforeShowValueToolTip
			If Not ceShowCustomValue.Checked Then
				Return
			End If
			e.ShowArgs.ToolTip = String.Format("Value = {0}", trackBarControl1.Value)
		End Sub
		'</ceShowCustomValue>
		'<ceShowTickLabels>
		Private Sub ceShowTickLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowTickLabels.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			trackBarControl1.Properties.ShowLabels = ceShowTickLabels.Checked
			If trackBarControl1.Properties.ShowLabels Then
				CreateNewLabelCollection()
			End If
			seLabelDistance.Enabled = trackBarControl1.Properties.ShowLabels
			CalcNewLocation()
		End Sub
		'</ceShowTickLabels>
		'<seLabelDistance>
		Private Sub seLabelDistance_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seLabelDistance.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			trackBarControl1.Properties.DistanceFromTickToLabel = TutorialHelper.ConvertToInt(seLabelDistance.Value)
			CalcNewLocation()
		End Sub
		'</seLabelDistance>
		Private Sub CalcNewLocation()
			trackBarControl1.Left = (groupControl3.Width - trackBarControl1.Size.Width) \ 2
			trackBarControl1.Top = (groupControl3.Height - trackBarControl1.Size.Height) \ 2
		End Sub
		'<ceShowTickLabels>
		Private Sub CreateNewLabelCollection()
			Dim [step] As Integer = 1
			Dim itemsCount As Integer = trackBarControl1.Properties.Maximum - trackBarControl1.Properties.Minimum + 1
			trackBarControl1.Properties.Labels.Clear()
			If itemsCount > 5 Then
				[step] = itemsCount \ 5
			End If
			For i As Integer = trackBarControl1.Properties.Minimum To trackBarControl1.Properties.Maximum Step [step]
				Dim label As New TrackBarLabel() With {.Value = i, .Label = i.ToString()}
				trackBarControl1.Properties.Labels.Add(label)
			Next i
		End Sub
		'</ceShowTickLabels>
	End Class
End Namespace
