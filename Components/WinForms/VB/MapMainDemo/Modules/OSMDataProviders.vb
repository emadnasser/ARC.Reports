Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars

Namespace DevExpress.XtraMap.Demos

	Partial Public Class OSMDataProviders
		Inherits MapTutorialControl
		Protected Overrides ReadOnly Property Overlays() As MapOverlay()
			Get
				Return New MapOverlay() { OverlayUtils.OSMCopyrightOverlay }
			End Get
		End Property
		Public Overrides ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			InitializeListboxes()
			AutoMergeRibbon = True
		End Sub
		Private Sub InitializeListboxes()
			listBoxControl1.Items.AddRange(DemoUtils.GetOSMBaseLayers())
			listBoxControl1.SelectedIndex = 0
			listBoxControl2.Items.AddRange(DemoUtils.GetOSMOverlays())
			listBoxControl2.SelectedIndex = 0
		End Sub
		Private Sub listBoxControl1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxControl1.SelectedValueChanged
			BaseProvider.Kind = CType(listBoxControl1.SelectedItem, OpenStreetMapKind)
			MiniMapDataProvider.Kind = CType(listBoxControl1.SelectedItem, OpenStreetMapKind)
		End Sub
		Private Sub listBoxControl2_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxControl2.SelectedValueChanged
			If listBoxControl2.SelectedIndex = 0 Then
				OverlayLayer.Visible = False
			Else
				OverlayLayer.Visible = True
				OverlayProvider.Kind = CType(listBoxControl2.SelectedItem, OpenStreetMapKind)
			End If
			MoveMap(listBoxControl2.SelectedIndex)
		End Sub
		Private Sub trackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarControl1.EditValueChanged
			TilesLayer.Transparency = CByte(trackBarControl1.Value)
		End Sub
		Private Sub trackBarControl2_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarControl2.EditValueChanged
			OverlayLayer.Transparency = CByte(trackBarControl2.Value)
		End Sub
		Private Sub MoveMap(ByVal index As Integer)
			Select Case index
				Case 0
					mapControl1.CenterPoint = New GeoPoint(50.067, 14.417)

					mapControl1.ZoomLevel = 5
					Exit Select
				Case 1
					mapControl1.CenterPoint = New GeoPoint(54.15, 11.75)
					mapControl1.ZoomLevel = 14
					Exit Select
				Case 2
					mapControl1.CenterPoint = New GeoPoint(41.5, 2.0)
					mapControl1.ZoomLevel = 11
					Exit Select
				Case 3
					mapControl1.CenterPoint = New GeoPoint(51.5, -3.2)
					mapControl1.ZoomLevel = 13
					Exit Select
				Case 4
					mapControl1.CenterPoint = New GeoPoint(48.85, 2.3)
					mapControl1.ZoomLevel = 11
					Exit Select
			End Select
		End Sub
		Protected Overrides Sub RestoreInitialView()
			MapControl.CenterPoint = New GeoPoint(50.067, 14.417)
			MapControl.ZoomLevel = 5
		End Sub
	End Class
End Namespace
