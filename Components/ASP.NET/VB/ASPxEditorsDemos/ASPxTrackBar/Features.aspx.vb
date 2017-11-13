Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class ASPxTrackBar_Features
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		trackBar.Orientation = If(orientationComboBox.SelectedIndex = 1, Orientation.Vertical, Orientation.Horizontal)
		trackBar.Direction = If(directionComboBox.SelectedIndex = 1, Direction.Reversed, Direction.Normal)
		trackBar.ScalePosition = CType(System.Enum.Parse(GetType(ScalePosition), scalePositionComboBox.Text), ScalePosition)
		trackBar.ValueToolTipPosition = CType(System.Enum.Parse(GetType(ValueToolTipPosition), valueToolTipPositionComboBox.Text), ValueToolTipPosition)
		trackBar.ScaleLabelHighlightMode = CType(System.Enum.Parse(GetType(ScaleLabelHighlightMode), highlightModeComboBox.Text), ScaleLabelHighlightMode)
		trackBar.ShowDragHandles = showDHCheckBox.Checked
		trackBar.ShowChangeButtons = showButtonsCheckBox.Checked
		trackBar.EqualTickMarks = equalizeTickCheckBox.Checked
		If trackBar.Orientation = Orientation.Vertical Then
			trackBar.Height = 256
		Else
			trackBar.Width = 256
		End If
	End Sub
End Class
