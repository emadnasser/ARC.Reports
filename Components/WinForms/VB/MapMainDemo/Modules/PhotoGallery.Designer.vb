Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraMap.Demos
	Partial Public Class PhotoGallery
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim mapPushpin1 As New DevExpress.XtraMap.MapPushpin()
			Dim miniMap1 As New DevExpress.XtraMap.MiniMap()
			Dim fixedMiniMapBehavior1 As New DevExpress.XtraMap.FixedMiniMapBehavior()
			Me.MiniMapImageTilesLayer = New DevExpress.XtraMap.MiniMapImageTilesLayer()
			Me.MiniMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
			Me.MiniMapVectorItemsLayer = New DevExpress.XtraMap.MiniMapVectorItemsLayer()
			Me.MiniMapData = New DevExpress.XtraMap.MapItemStorage()
			Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
			Me.BingMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
			Me.ItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.ListSourceDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
			Me.PushpinLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.MapItemStorage = New DevExpress.XtraMap.MapItemStorage()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.galleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
			Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.galleryControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' MiniMapImageTilesLayer
			' 
			Me.MiniMapImageTilesLayer.DataProvider = Me.MiniMapDataProvider
			Me.MiniMapImageTilesLayer.Name = "ImageTilesLayer"
			' 
			' MiniMapVectorItemsLayer
			' 
			Me.MiniMapVectorItemsLayer.Data = Me.MiniMapData
			Me.MiniMapVectorItemsLayer.ItemStyle.Fill = System.Drawing.Color.Red
			Me.MiniMapVectorItemsLayer.ItemStyle.Stroke = System.Drawing.Color.White
			Me.MiniMapVectorItemsLayer.ItemStyle.StrokeWidth = 2
			Me.MiniMapVectorItemsLayer.Name = "DataLayer"
			' 
			' TilesLayer
			' 
			Me.TilesLayer.DataProvider = Me.BingMapDataProvider
			Me.TilesLayer.Name = "TilesLayer"
'			Me.TilesLayer.DataLoaded += New DevExpress.XtraMap.DataLoadedEventHandler(Me.TilesLayer_DataLoaded);
			' 
			' ItemsLayer
			' 
			Me.ItemsLayer.Data = Me.ListSourceDataAdapter
			Me.ItemsLayer.ItemStyle.Font = New System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ItemsLayer.Name = "ItemsLayer"
'			Me.ItemsLayer.DataLoaded += New DevExpress.XtraMap.DataLoadedEventHandler(Me.ItemsLayer_DataLoaded);
			' 
			' ListSourceDataAdapter
			' 
			Me.ListSourceDataAdapter.Mappings.Latitude = "Latitude"
			Me.ListSourceDataAdapter.Mappings.Longitude = "Longitude"
			Me.ListSourceDataAdapter.Mappings.Text = "CityName"
			' 
			' PushpinLayer
			' 
			Me.PushpinLayer.Data = Me.MapItemStorage
			Me.PushpinLayer.Name = "PushpinLayer"
			Me.PushpinLayer.Visible = False
			' 
			' MapItemStorage
			' 
			Me.MapItemStorage.Items.Add(mapPushpin1)
			' 
			' mapControl1
			' 
			Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(47.5R, 2R)
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapControl1.Layers.Add(Me.TilesLayer)
			Me.mapControl1.Layers.Add(Me.ItemsLayer)
			Me.mapControl1.Layers.Add(Me.PushpinLayer)
			Me.mapControl1.Location = New System.Drawing.Point(0, 139)
			miniMap1.Alignment = DevExpress.XtraMap.MiniMapAlignment.TopLeft
			fixedMiniMapBehavior1.ZoomLevel = 0.5R
			miniMap1.Behavior = fixedMiniMapBehavior1
			miniMap1.Height = 256
			miniMap1.Layers.Add(Me.MiniMapImageTilesLayer)
			miniMap1.Layers.Add(Me.MiniMapVectorItemsLayer)
			miniMap1.Width = 256
			Me.mapControl1.MiniMap = miniMap1
			Me.mapControl1.MinZoomLevel = 0.1R
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.NavigationPanelOptions.Visible = False
			Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single
			Me.mapControl1.Size = New System.Drawing.Size(1032, 471)
			Me.mapControl1.TabIndex = 0
'			Me.mapControl1.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.mapControl1_MouseUp);
			' 
			' timer1
			' 
			Me.timer1.Interval = 2000
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' galleryControl1
			' 
			Me.galleryControl1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.galleryControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.galleryControl1.Controls.Add(Me.galleryControlClient1)
			Me.galleryControl1.DesignGalleryGroupIndex = 0
			Me.galleryControl1.DesignGalleryItemIndex = 0
			' 
			' 
			' 
			Me.galleryControl1.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.galleryControl1.Gallery.ColumnCount = 3
			Me.galleryControl1.Gallery.DistanceBetweenItems = 5
			Me.galleryControl1.Gallery.DistanceItemImageToText = 2
			Me.galleryControl1.Gallery.DrawImageBackground = False
			Me.galleryControl1.Gallery.ImageSize = New System.Drawing.Size(280, 180)
			Me.galleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch
			Me.galleryControl1.Gallery.RowCount = 2
			Me.galleryControl1.Gallery.ShowItemText = True
			Me.galleryControl1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
'			Me.galleryControl1.Gallery.ItemClick += New DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(Me.galleryControlGallery1_ItemClick);
			Me.galleryControl1.Location = New System.Drawing.Point(74, 26)
			Me.galleryControl1.Name = "galleryControl1"
			Me.galleryControl1.Size = New System.Drawing.Size(12, 12)
			Me.galleryControl1.TabIndex = 1
			Me.galleryControl1.Text = "galleryControl1"
			' 
			' galleryControlClient1
			' 
			Me.galleryControlClient1.GalleryControl = Me.galleryControl1
			Me.galleryControlClient1.Location = New System.Drawing.Point(1, 1)
			Me.galleryControlClient1.Size = New System.Drawing.Size(10, 10)
			' 
			' PhotoGallery
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.galleryControl1)
			Me.Controls.Add(Me.mapControl1)
			Me.Name = "PhotoGallery"
			Me.Size = New System.Drawing.Size(1032, 610)
'			Me.Load += New System.EventHandler(Me.PhotoGallery_Load);
			Me.Controls.SetChildIndex(Me.mapControl1, 0)
			Me.Controls.SetChildIndex(Me.galleryControl1, 0)
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.galleryControl1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents mapControl1 As DevExpress.XtraMap.MapControl
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private WithEvents galleryControl1 As DevExpress.XtraBars.Ribbon.GalleryControl
		Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
		Private WithEvents TilesLayer As ImageLayer
		Private WithEvents ItemsLayer As VectorItemsLayer
		Private ListSourceDataAdapter As ListSourceDataAdapter
		Private PushpinLayer As VectorItemsLayer
		Private MapItemStorage As MapItemStorage
		Private MiniMapDataProvider As BingMapDataProvider
		Private MiniMapData As MapItemStorage
		Private BingMapDataProvider As BingMapDataProvider
		Private MiniMapImageTilesLayer As MiniMapImageTilesLayer
		Private MiniMapVectorItemsLayer As MiniMapVectorItemsLayer
	End Class
End Namespace
