Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraRichEdit.Demos.Forms
	Public Partial Class MergeResultingDocumentForm
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()
		End Sub
		Public ReadOnly Property Document() As Document
			Get
				Return richEditControl.Document
			End Get
		End Property

		Private Sub ribbonControl1_ApplicationButtonDoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonControl1.ApplicationButtonDoubleClick
			Me.Close()
		End Sub

		Private Sub MergeResultingDocumentForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim zoomFactor As Single = richEditControl.ActiveView.ZoomFactor
			UpdateZoomTrackbarCore(zoomFactor)
			UpdateZoomCaption(zoomFactor)
			SubscribeZoomChangedEvent()
			SubscribeZoomTrackbarEvents()
		End Sub
		Private Sub SubscribeZoomTrackbarEvents()
			AddHandler repositoryItemZoomTrackBar1.EditValueChanging, AddressOf OnZoomTrackBarEditValueChanging
		End Sub
		Private Sub UnsubscribeZoomTrackbarEvents()
			RemoveHandler repositoryItemZoomTrackBar1.EditValueChanging, AddressOf OnZoomTrackBarEditValueChanging
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
			zoomTrackBar.Caption = String.Format("{0}%", CInt(Fix(Math.Round(zoomFactor * 100))))
		End Sub
		Private Sub richEditControl_ZoomChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.ZoomChanged
			UpdateZoomCaption(richEditControl.ActiveView.ZoomFactor)
		End Sub
	End Class
End Namespace
