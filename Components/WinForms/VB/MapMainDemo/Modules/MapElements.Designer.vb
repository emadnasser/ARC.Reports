Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraMap.Demos
	Partial Public Class MapElements
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
			OnDispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim mapItemAttributeMapping1 As New DevExpress.XtraMap.MapItemAttributeMapping()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MapElements))
			Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
			Me.MapBingDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
			Me.PathsLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.PathsDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
			Me.PlanesLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.PlanesDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
			Me.mapContainerPanel = New DevExpress.XtraEditors.PanelControl()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			CType(Me.mapContainerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mapContainerPanel.SuspendLayout()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' TilesLayer
			' 
			Me.TilesLayer.DataProvider = Me.MapBingDataProvider
			Me.TilesLayer.Name = "TilesLayer"
			' 
			' MapBingDataProvider
			' 
			Me.MapBingDataProvider.BingKey = "YOUR BING MAPS KEY"
			Me.MapBingDataProvider.Kind = DevExpress.XtraMap.BingMapKind.Road
			' 
			' PathsLayer
			' 
			Me.PathsLayer.Data = Me.PathsDataAdapter
			Me.PathsLayer.EnableHighlighting = False
			Me.PathsLayer.HighlightedItemStyle.Fill = System.Drawing.Color.Transparent
			Me.PathsLayer.HighlightedItemStyle.Stroke = System.Drawing.Color.Transparent
			Me.PathsLayer.ItemStyle.Fill = System.Drawing.Color.Transparent
			Me.PathsLayer.ItemStyle.Stroke = System.Drawing.Color.Transparent
			Me.PathsLayer.Name = "PathsLayer"
			Me.PathsLayer.SelectedItemStyle.Fill = System.Drawing.Color.Transparent
			Me.PathsLayer.SelectedItemStyle.Stroke = System.Drawing.Color.Transparent
'			Me.PathsLayer.DataLoaded += New DevExpress.XtraMap.DataLoadedEventHandler(Me.MapElements_DataLoaded);
			' 
			' PathsDataAdapter
			' 
			Me.PathsDataAdapter.Mappings.Latitude = "Latitude"
			Me.PathsDataAdapter.Mappings.Longitude = "Longitude"
			Me.PathsDataAdapter.Mappings.Type = "ItemType"
			' 
			' PlanesLayer
			' 
			Me.PlanesLayer.Data = Me.PlanesDataAdapter
			Me.PlanesLayer.EnableHighlighting = False
			Me.PlanesLayer.HighlightedItemStyle.Fill = System.Drawing.Color.Transparent
			Me.PlanesLayer.HighlightedItemStyle.Stroke = System.Drawing.Color.Transparent
			Me.PlanesLayer.HighlightedItemStyle.StrokeWidth = 0
			Me.PlanesLayer.ItemStyle.Fill = System.Drawing.Color.Transparent
			Me.PlanesLayer.ItemStyle.Stroke = System.Drawing.Color.Transparent
			Me.PlanesLayer.Name = "PlanesLayer"
			Me.PlanesLayer.SelectedItemStyle.Fill = System.Drawing.Color.Transparent
			Me.PlanesLayer.SelectedItemStyle.Stroke = System.Drawing.Color.Transparent
			Me.PlanesLayer.SelectedItemStyle.StrokeWidth = 0
			' 
			' PlanesDataAdapter
			' 
			mapItemAttributeMapping1.Member = "Icon"
			mapItemAttributeMapping1.Name = "Icon"
			Me.PlanesDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1)
			Me.PlanesDataAdapter.Mappings.Latitude = "Latitude"
			Me.PlanesDataAdapter.Mappings.Longitude = "Longitude"
			' 
			' mapContainerPanel
			' 
			Me.mapContainerPanel.Controls.Add(Me.mapControl1)
			Me.mapContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapContainerPanel.Location = New System.Drawing.Point(0, 0)
			Me.mapContainerPanel.Name = "mapContainerPanel"
			Me.mapContainerPanel.Size = New System.Drawing.Size(601, 480)
			Me.mapContainerPanel.TabIndex = 2
			' 
			' mapControl1
			' 
			Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(26R, -26R)
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapControl1.Layers.Add(Me.TilesLayer)
			Me.mapControl1.Layers.Add(Me.PathsLayer)
			Me.mapControl1.Layers.Add(Me.PlanesLayer)
			Me.mapControl1.Location = New System.Drawing.Point(2, 2)
			Me.mapControl1.MaxZoomLevel = 9R
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single
			Me.mapControl1.Size = New System.Drawing.Size(597, 476)
			Me.mapControl1.TabIndex = 0
			Me.mapControl1.ZoomLevel = 2R
'			Me.mapControl1.DrawMapItem += New DevExpress.XtraMap.DrawMapItemEventHandler(Me.mapControl1_DrawMapItem);
'			Me.mapControl1.SelectionChanging += New DevExpress.XtraMap.MapSelectionChangingEventHandler(Me.mapControl1_SelectionChanging);
'			Me.mapControl1.SelectionChanged += New DevExpress.XtraMap.MapSelectionChangedEventHandler(Me.mapControl1_SelectionChanged);
			' 
			' MapElements
			' 
			Me.Appearance.Options.UseFont = True
			Me.Controls.Add(Me.mapContainerPanel)
			Me.Name = "MapElements"
			Me.Size = New System.Drawing.Size(601, 480)
			Me.Controls.SetChildIndex(Me.mapContainerPanel, 0)
			CType(Me.mapContainerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mapContainerPanel.ResumeLayout(False)
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents mapControl1 As MapControl
		Private mapContainerPanel As XtraEditors.PanelControl
		Private TilesLayer As ImageLayer
		Private WithEvents PathsLayer As VectorItemsLayer
		Private PathsDataAdapter As ListSourceDataAdapter
		Private PlanesLayer As VectorItemsLayer
		Private PlanesDataAdapter As ListSourceDataAdapter
		Private MapBingDataProvider As BingMapDataProvider
	End Class
End Namespace
