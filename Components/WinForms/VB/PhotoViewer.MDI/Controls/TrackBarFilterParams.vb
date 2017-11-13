Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors

Namespace PhotoViewer
	Partial Public Class TrackBarFilterParams
		Inherits SimpleFilterParams
		Public Sub New()
			InitializeComponent()
			Dim trackBarItem As LayoutControlItem = New LayoutControlItem(Me.SimpleFilterParamsConvertedLayout, Me.trackBar)
			trackBarItem.Text = FilterText
			trackBarItem.SizeConstraintsType = SizeConstraintsType.Custom
			trackBarItem.MinSize = New Size(25, 50)
			trackBarItem.MaxSize = New Size(0, 50)
			trackBarItem.Move(Me.applyButtonItem, DevExpress.XtraLayout.Utils.InsertType.Top)
		End Sub
		Public Overrides Function GetParams() As Object()
			Return New Object() { GetValue() }
		End Function
		Protected Overridable Sub OnBeforeShowTrackBarValueToolTip(ByVal sender As Object, ByVal e As TrackBarValueToolTipEventArgs) Handles trackBar.Properties.BeforeShowValueToolTip
			e.ShowArgs.ToolTip = GetValue().ToString()
		End Sub
		Protected Overridable Function GetValue() As Single
			Return trackBar.Value * 0.001f
		End Function

		Private Sub trackBar_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar.EditValueChanged
			UpdatePreview()
		End Sub
		Protected Overridable ReadOnly Property FilterText() As String
			Get
				Return ""
			End Get
		End Property
	End Class

	Partial Public Class BrightnessFilterParams
		Inherits TrackBarFilterParams
		Protected Overrides ReadOnly Property FilterText() As String
			Get
				Return "Brightness"
			End Get
		End Property
		Protected Overrides Function GetValue() As Single
			Return trackBar.Value * 0.002f - 1.0f
		End Function
	End Class

	Partial Public Class ContrastFilterParams
		Inherits TrackBarFilterParams
		Protected Overrides ReadOnly Property FilterText() As String
			Get
				Return "Contrast"
			End Get
		End Property
		Protected Overrides Function GetValue() As Single
			Return trackBar.Value * 0.002f
		End Function
	End Class

	Partial Public Class SaturationFilterParams
		Inherits TrackBarFilterParams
		Protected Overrides ReadOnly Property FilterText() As String
			Get
				Return "Saturation"
			End Get
		End Property
		Protected Overrides Function GetValue() As Single
			Return trackBar.Value * 0.001f
		End Function
	End Class
End Namespace
