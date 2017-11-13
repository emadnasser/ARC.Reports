Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraMap.Demos
	Partial Public Class DataSource
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
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
			Me.components = New System.ComponentModel.Container()
			Dim mapDotSizeMapping1 As New DevExpress.XtraMap.MapDotSizeMapping()
			Dim mapItemAttributeMapping1 As New DevExpress.XtraMap.MapItemAttributeMapping()
			Dim mapItemAttributeMapping2 As New DevExpress.XtraMap.MapItemAttributeMapping()
			Dim miniMap1 As New DevExpress.XtraMap.MiniMap()
			Dim fixedMiniMapBehavior1 As New DevExpress.XtraMap.FixedMiniMapBehavior()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DataSource))
			Me.MiniMapImageTilesLayer = New DevExpress.XtraMap.MiniMapImageTilesLayer()
			Me.MiniMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
			Me.MiniMapVectorItemsLayer = New DevExpress.XtraMap.MiniMapVectorItemsLayer()
			Me.MiniMapDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
			Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
			Me.BingMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
			Me.ItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.ListSourceDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			Me.panelSeparator = New DevExpress.XtraEditors.PanelControl()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelSeparator, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' MiniMapImageTilesLayer
			' 
			Me.MiniMapImageTilesLayer.DataProvider = Me.MiniMapDataProvider
			Me.MiniMapImageTilesLayer.Name = "ImageTilesLayer"
			' 
			' MiniMapVectorItemsLayer
			' 
			Me.MiniMapVectorItemsLayer.Data = Me.MiniMapDataAdapter
			Me.MiniMapVectorItemsLayer.ItemStyle.Fill = System.Drawing.Color.Red
			Me.MiniMapVectorItemsLayer.ItemStyle.Stroke = System.Drawing.Color.White
			Me.MiniMapVectorItemsLayer.ItemStyle.StrokeWidth = 1
			Me.MiniMapVectorItemsLayer.Name = "DataLayer"
			' 
			' MiniMapDataAdapter
			' 
			Me.MiniMapDataAdapter.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Dot
			Me.MiniMapDataAdapter.Mappings.Latitude = "Latitude"
			Me.MiniMapDataAdapter.Mappings.Longitude = "Longitude"
			mapDotSizeMapping1.DefaultValue = 8R
			Me.MiniMapDataAdapter.PropertyMappings.Add(mapDotSizeMapping1)
			' 
			' TilesLayer
			' 
			Me.TilesLayer.DataProvider = Me.BingMapDataProvider
			Me.TilesLayer.Name = "TilesLayer"
			' 
			' ItemsLayer
			' 
			Me.ItemsLayer.Data = Me.ListSourceDataAdapter
			Me.ItemsLayer.ItemImageIndex = 0
			Me.ItemsLayer.ItemStyle.Fill = System.Drawing.Color.Transparent
			Me.ItemsLayer.ItemStyle.Stroke = System.Drawing.Color.Transparent
			Me.ItemsLayer.ItemStyle.StrokeWidth = 0
			Me.ItemsLayer.Name = "ItemsLayer"
			Me.ItemsLayer.ToolTipPattern = "{Desc}"
			' 
			' ListSourceDataAdapter
			' 
			mapItemAttributeMapping1.Member = "Description"
			mapItemAttributeMapping1.Name = "Desc"
			mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.String
			mapItemAttributeMapping2.Member = "Name"
			mapItemAttributeMapping2.Name = "Name"
			mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.String
			Me.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1)
			Me.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2)
			Me.ListSourceDataAdapter.Mappings.Latitude = "Latitude"
			Me.ListSourceDataAdapter.Mappings.Longitude = "Longitude"
			' 
			' mapControl1
			' 
			Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(-36R, 145R)
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapControl1.EnableZooming = False
			Me.mapControl1.ImageList = Me.imageCollection1
			Me.mapControl1.Layers.Add(Me.TilesLayer)
			Me.mapControl1.Layers.Add(Me.ItemsLayer)
			Me.mapControl1.Location = New System.Drawing.Point(0, 147)
			miniMap1.Alignment = DevExpress.XtraMap.MiniMapAlignment.TopLeft
			fixedMiniMapBehavior1.CenterPoint = New DevExpress.XtraMap.GeoPoint(-30R, 133R)
			fixedMiniMapBehavior1.ZoomLevel = 2.7R
			miniMap1.Behavior = fixedMiniMapBehavior1
			miniMap1.Height = 200
			miniMap1.Layers.Add(Me.MiniMapImageTilesLayer)
			miniMap1.Layers.Add(Me.MiniMapVectorItemsLayer)
			miniMap1.Width = 260
			Me.mapControl1.MiniMap = miniMap1
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.NavigationPanelOptions.Visible = False
			Me.mapControl1.Size = New System.Drawing.Size(601, 333)
			Me.mapControl1.TabIndex = 0
			Me.mapControl1.ToolTipController = Me.toolTipController1
			Me.mapControl1.ZoomLevel = 6R
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageSize = New System.Drawing.Size(40, 40)
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "SunkShipImage.png")
			' 
			' toolTipController1
			' 
'			Me.toolTipController1.BeforeShow += New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(Me.toolTipController1_BeforeShow);
			' 
			' panelSeparator
			' 
			Me.panelSeparator.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelSeparator.Location = New System.Drawing.Point(0, 139)
			Me.panelSeparator.Name = "panelSeparator"
			Me.panelSeparator.Size = New System.Drawing.Size(601, 8)
			Me.panelSeparator.TabIndex = 1
			Me.panelSeparator.Visible = False
			' 
			' DataSource
			' 
			Me.Controls.Add(Me.mapControl1)
			Me.Controls.Add(Me.panelSeparator)
			Me.Name = "DataSource"
			Me.Size = New System.Drawing.Size(601, 480)
			Me.Controls.SetChildIndex(Me.panelSeparator, 0)
			Me.Controls.SetChildIndex(Me.mapControl1, 0)
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelSeparator, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private mapControl1 As MapControl
		Private panelSeparator As XtraEditors.PanelControl
		Private WithEvents toolTipController1 As Utils.ToolTipController
		Private imageCollection1 As Utils.ImageCollection
		Private TilesLayer As ImageLayer
		Private ItemsLayer As VectorItemsLayer
		Private ListSourceDataAdapter As ListSourceDataAdapter
		Private MiniMapDataAdapter As ListSourceDataAdapter
		Private BingMapDataProvider As BingMapDataProvider
		Private MiniMapImageTilesLayer As MiniMapImageTilesLayer
		Private MiniMapVectorItemsLayer As MiniMapVectorItemsLayer
		Private MiniMapDataProvider As BingMapDataProvider
	End Class
End Namespace
