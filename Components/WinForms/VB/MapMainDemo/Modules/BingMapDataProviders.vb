Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars

Namespace DevExpress.XtraMap.Demos

	Partial Public Class BingMapDataProviders
		Inherits MapTutorialControl
		Protected Overrides ReadOnly Property Overlays() As MapOverlay()
			Get
				Return OverlayUtils.GetBingOverlays()
			End Get
		End Property
		Public Overrides ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property

		Public Sub New()
			AutoMergeRibbon = True
			InitializeComponent()
			DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider)
			DemoUtils.SetBingMapDataProviderKey(MiniMapDataProvider)
			chkBingHybrid.Checked = True
		End Sub
		Private Sub SetBingProviderMapKind(ByVal kind As BingMapKind)
			If BingMapDataProvider IsNot Nothing Then
				mapControl1.BackColor = If(Object.Equals(kind, BingMapKind.Road), Color.FromArgb(187, 208, 237), Color.FromArgb(1, 7, 21))
				BingMapDataProvider.Kind = kind
				MiniMapDataProvider.Kind = kind
			End If
		End Sub
		Private Sub chkBingArea_CheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles chkBingArea.CheckedChanged, chkBingRoad.CheckedChanged, chkBingHybrid.CheckedChanged
			SetBingProviderMapKind(GetCurrentMapKind())
		End Sub
		Private Function GetCurrentMapKind() As BingMapKind
			If chkBingArea.Checked Then
				Return BingMapKind.Area
			End If
			If chkBingRoad.Checked Then
				Return BingMapKind.Road
			End If
			If chkBingHybrid.Checked Then
				Return BingMapKind.Hybrid
			End If
			Return BingMapKind.Hybrid
		End Function

		Protected Overrides Sub InitRibbon()
			MyBase.InitRibbon()
			OptionsPage.Groups.Add(rpgDataProviders)
			OptionsPage.Ribbon.Items.AddRange(New BarItem() { chkBingArea, chkBingHybrid, chkBingRoad })
		End Sub
		Protected Overrides Sub RestoreInitialView()
			MapControl.CenterPoint = New GeoPoint()
			MapControl.ZoomLevel = 2
		End Sub
	End Class
End Namespace
