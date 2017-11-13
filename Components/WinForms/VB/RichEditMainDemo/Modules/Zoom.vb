Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraRichEdit.Utils

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class ZoomModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()
            RtfLoadHelper.Load("Zoom.rtf", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
		End Sub

		Public Overrides ReadOnly Property PrintingRichEditControl() As RichEditControl
			Get
				Return richEditControl
			End Get
		End Property

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			richEditControl.Focus()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Dim zoomFactor As Single = richEditControl.ActiveView.ZoomFactor
			UpdateZoomTrackbarCore(zoomFactor)
			UpdateZoomCaption(zoomFactor)
			SubscribeZoomChangedEvent()
			SubscribeZoomTrackbarEvents()
		End Sub
		Private Sub SubscribeZoomTrackbarEvents()
			AddHandler zoomTrackBar.Edit.EditValueChanging, AddressOf OnZoomTrackBarEditValueChanging
		End Sub
		Private Sub UnsubscribeZoomTrackbarEvents()
			RemoveHandler zoomTrackBar.Edit.EditValueChanging, AddressOf OnZoomTrackBarEditValueChanging
		End Sub
		Private Sub SubscribeZoomChangedEvent()
			AddHandler richEditControl.ZoomChanged, AddressOf OnZoomChanged
		End Sub
		Private Sub UnsubcribeZoomChangedEvent()
			RemoveHandler richEditControl.ZoomChanged, AddressOf OnZoomChanged
		End Sub
		Private Sub OnZoomTrackBarEditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs)
			OnZoomTrackBarEditValueChangedCore(CInt(Fix(e.NewValue)))
		End Sub
		Private Sub OnZoomTrackBarEditValueChangedCore(ByVal value As Integer)
			UnsubcribeZoomChangedEvent()
			richEditControl.ActiveView.ZoomFactor = CInt(Fix(value)) / 100.0f
			SubscribeZoomChangedEvent()
		End Sub
		Private Sub OnZoomChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim zoomFactor As Single = richEditControl.ActiveView.ZoomFactor
			UnsubscribeZoomTrackbarEvents()
			UpdateZoomTrackbarCore(zoomFactor)
			SubscribeZoomTrackbarEvents()
		End Sub
		Private Sub UpdateZoomTrackbarCore(ByVal zoomFactor As Single)
			zoomTrackBar.EditValue = CInt(Fix(Math.Round(zoomFactor * 100)))
		End Sub
		Private Sub UpdateZoomCaption(ByVal zoomFactor As Single)
			lblZoom.Caption = String.Format("{0}%", CInt(Fix(Math.Round(zoomFactor * 100))))
		End Sub
		Private Sub richEditControl_ZoomChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.ZoomChanged
			UpdateZoomCaption(richEditControl.ActiveView.ZoomFactor)
		End Sub
	End Class
End Namespace
