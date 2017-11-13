Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.Threading
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleZoomTrackBar
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleZoomTrackBar.vb"
			TutorialInfo.WhatsThisXMLFile = "zoomTrackBar.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleZoomTrackBar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			SetDefaultProgressBarPosition()
			InitComboBoxes()
			InitValues()
		End Sub

		Private Sub SetDefaultProgressBarPosition()
			UpdateTrackBarBounds(zoomTrackBarControl1)
		End Sub

		Private Sub UpdateTrackBarBounds(ByVal trackBar As ZoomTrackBarControl)
			If trackBar.Properties.Orientation = Orientation.Horizontal Then
				ControlUtils.HorzAlignControlInParent(trackBar, 16)
			Else
				ControlUtils.VertAlignControlInParent(trackBar, 32)
			End If
			ControlUtils.CenterControlInParent(trackBar)
		End Sub

		Private Sub InitComboBoxes()
			icbScrollThumbStyle.Properties.Items.AddEnum(GetType(ScrollThumbStyle))
		End Sub


		Private Sub InitValues()
			updateValues = True
			checkEditVertical.Checked = zoomTrackBarControl1.Properties.Orientation = Orientation.Vertical
			icbScrollThumbStyle.EditValue = zoomTrackBarControl1.Properties.ScrollThumbStyle
			seMinimum.Value = zoomTrackBarControl1.Properties.Minimum
			seMaximum.Value = zoomTrackBarControl1.Properties.Maximum
			seSmallChange.Value = zoomTrackBarControl1.Properties.SmallChange
			seLargeChange.Value = zoomTrackBarControl1.Properties.LargeChange
			seMiddle.Value = zoomTrackBarControl1.Properties.Middle
			checkEditUseMiddleValue.Checked = zoomTrackBarControl1.Properties.AllowUseMiddleValue
			updateValues = False
			ShowValue()
		End Sub

		'<checkEditVertical>
		Private Sub checkEditVertical_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditVertical.CheckedChanged
			If updateValues Then
				Return
			End If
			zoomTrackBarControl1.Properties.Orientation = If(checkEditVertical.Checked, Orientation.Vertical, Orientation.Horizontal)
			UpdateTrackBarBounds(zoomTrackBarControl1)
		End Sub
		'</checkEditVertical>

		'<icbScrollThumbStyle>
		Private Sub icbScrollThumbStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbScrollThumbStyle.SelectedIndexChanged
			If updateValues Then
				Return
			End If
			zoomTrackBarControl1.Properties.ScrollThumbStyle = CType(icbScrollThumbStyle.EditValue, ScrollThumbStyle)
		End Sub
		'</icbScrollThumbStyle>

		Private Sub UpdateMiddleParameters()
			If Not checkEditUseMiddleValue.Checked Then
				Return
			End If
			seMiddle.Value = zoomTrackBarControl1.Properties.Middle
			checkEditUseMiddleValue.Checked = zoomTrackBarControl1.Properties.AllowUseMiddleValue
		End Sub

		'<seMinimum>
		Private Sub seMinimum_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seMinimum.EditValueChanged
			If updateValues Then
				Return
			End If
			zoomTrackBarControl1.Properties.Minimum = TutorialHelper.ConvertToInt(seMinimum.Value)
			seMinimum.Value = zoomTrackBarControl1.Properties.Minimum
			UpdateMiddleParameters()
		End Sub
		'</seMinimum>

		'<seMaximum>
		Private Sub seMaximum_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seMaximum.EditValueChanged
			If updateValues Then
				Return
			End If
			zoomTrackBarControl1.Properties.Maximum = TutorialHelper.ConvertToInt(seMaximum.Value)
			seMaximum.Value = zoomTrackBarControl1.Properties.Maximum
			UpdateMiddleParameters()
		End Sub
		'</seMaximum>

		'<seSmallChange>
		Private Sub seSmallChange_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seSmallChange.EditValueChanged
			If updateValues Then
				Return
			End If
			zoomTrackBarControl1.Properties.SmallChange = TutorialHelper.ConvertToInt(seSmallChange.Value)
			seSmallChange.Value = zoomTrackBarControl1.Properties.SmallChange
		End Sub
		'</seSmallChange>

		'<seLargeChange>
		Private Sub seLargeChange_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seLargeChange.EditValueChanged
			If updateValues Then
				Return
			End If
			zoomTrackBarControl1.Properties.LargeChange = TutorialHelper.ConvertToInt(seLargeChange.Value)
			seLargeChange.Value = zoomTrackBarControl1.Properties.LargeChange
		End Sub
		'</seLargeChange>
		Private Sub zoomTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles zoomTrackBarControl1.EditValueChanged
			ShowValue()
		End Sub
		Private Sub ShowValue()
			lbValue.Text = zoomTrackBarControl1.Value.ToString()
		End Sub
		'<checkEditUseMiddleValue>
		Private Sub checkEditUseMiddleValue_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditUseMiddleValue.CheckedChanged
			'<skip>
			If updateValues Then
				Return
			End If
			'</skip>
			If checkEditUseMiddleValue.Checked Then
				zoomTrackBarControl1.Properties.AllowUseMiddleValue = True
				seMiddle.Enabled = zoomTrackBarControl1.Properties.AllowUseMiddleValue
			Else
				zoomTrackBarControl1.Properties.AllowUseMiddleValue = False
				seMiddle.Enabled = zoomTrackBarControl1.Properties.AllowUseMiddleValue
			End If
			UpdateMiddleParameters()

			Try
				zoomTrackBarControl1.Properties.Middle = TutorialHelper.ConvertToInt(seMiddle.Value)
			Catch e1 As ArgumentException
				seMiddle.Value = zoomTrackBarControl1.Properties.Middle
			End Try
		End Sub
		'</checkEditUseMiddleValue>
		'<seMiddle>
		Private Sub seMiddle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seMiddle.EditValueChanged
			'<skip>
			If updateValues Then
				Return
			End If
			'</skip>
			Try
				zoomTrackBarControl1.Properties.Middle = TutorialHelper.ConvertToInt(seMiddle.Value)
				seMiddle.Value = zoomTrackBarControl1.Properties.Middle
			Catch e1 As ArgumentException
				seMiddle.Value = zoomTrackBarControl1.Properties.Middle
			End Try
		End Sub
		'</seMiddle>
	End Class
End Namespace

