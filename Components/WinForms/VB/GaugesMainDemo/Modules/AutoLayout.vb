Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGauges.Core.Base

Namespace DevExpress.XtraGauges.Demos
	Partial Public Class AutoLayoutFeature
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
			trackBarControl1.Value = 6
			trackBarControl2.Value = 6
		End Sub
		Private Sub trackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBarControl1.EditValueChanged
			gaugeControl1.LayoutInterval = trackBarControl1.Value
			gaugeControl2.LayoutInterval = trackBarControl1.Value
		End Sub
		Private Sub trackBarControl2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBarControl2.EditValueChanged
			gaugeControl1.LayoutPadding = New Thickness(trackBarControl2.Value)
			gaugeControl2.LayoutPadding = New Thickness(trackBarControl2.Value)
		End Sub
	End Class
End Namespace
