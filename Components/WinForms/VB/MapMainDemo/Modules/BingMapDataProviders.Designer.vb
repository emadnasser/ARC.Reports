Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraMap.Demos
	Partial Public Class BingMapDataProviders
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
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim miniMap1 As New DevExpress.XtraMap.MiniMap()
			Dim dynamicMiniMapBehavior1 As New DevExpress.XtraMap.DynamicMiniMapBehavior()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(BingMapDataProviders))
			Me.MiniMapImageTilesLayer = New DevExpress.XtraMap.MiniMapImageTilesLayer()
			Me.MiniMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
			Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
			Me.BingMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.chkBingArea = New DevExpress.XtraBars.BarCheckItem()
			Me.chkBingRoad = New DevExpress.XtraBars.BarCheckItem()
			Me.chkBingHybrid = New DevExpress.XtraBars.BarCheckItem()
			Me.rpgDataProviders = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' MiniMapImageTilesLayer
			' 
			Me.MiniMapImageTilesLayer.DataProvider = Me.MiniMapDataProvider
			Me.MiniMapImageTilesLayer.Name = "ImageTilesLayer"
			' 
			' TilesLayer
			' 
			Me.TilesLayer.DataProvider = Me.BingMapDataProvider
			Me.TilesLayer.Name = "TilesLayer"
			' 
			' mapControl1
			' 
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapControl1.Layers.Add(Me.TilesLayer)
			Me.mapControl1.Location = New System.Drawing.Point(0, 139)
			miniMap1.Alignment = DevExpress.XtraMap.MiniMapAlignment.TopRight
			dynamicMiniMapBehavior1.ZoomOffset = -5R
			miniMap1.Behavior = dynamicMiniMapBehavior1
			miniMap1.Layers.Add(Me.MiniMapImageTilesLayer)
			Me.mapControl1.MiniMap = miniMap1
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.NavigationPanelOptions.Visible = False
			Me.mapControl1.Size = New System.Drawing.Size(601, 341)
			Me.mapControl1.TabIndex = 0
			Me.mapControl1.ZoomLevel = 2R
			' 
			' chkBingArea
			' 
			Me.chkBingArea.Caption = "Bing Area"
			Me.chkBingArea.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.chkBingArea.Glyph = (CType(resources.GetObject("chkBingArea.Glyph"), System.Drawing.Image))
			Me.chkBingArea.GroupIndex = 1
			Me.chkBingArea.Id = 23
			Me.chkBingArea.LargeGlyph = (CType(resources.GetObject("chkBingArea.LargeGlyph"), System.Drawing.Image))
			Me.chkBingArea.Name = "chkBingArea"
			Me.chkBingArea.Tag = 0
'			Me.chkBingArea.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.chkBingArea_CheckedChanged);
			' 
			' chkBingRoad
			' 
			Me.chkBingRoad.Caption = "Bing Road"
			Me.chkBingRoad.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.chkBingRoad.Glyph = (CType(resources.GetObject("chkBingRoad.Glyph"), System.Drawing.Image))
			Me.chkBingRoad.GroupIndex = 1
			Me.chkBingRoad.Id = 24
			Me.chkBingRoad.LargeGlyph = (CType(resources.GetObject("chkBingRoad.LargeGlyph"), System.Drawing.Image))
			Me.chkBingRoad.Name = "chkBingRoad"
			Me.chkBingRoad.Tag = 1
'			Me.chkBingRoad.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.chkBingArea_CheckedChanged);
			' 
			' chkBingHybrid
			' 
			Me.chkBingHybrid.Caption = "Bing Hybrid"
			Me.chkBingHybrid.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.chkBingHybrid.Glyph = (CType(resources.GetObject("chkBingHybrid.Glyph"), System.Drawing.Image))
			Me.chkBingHybrid.GroupIndex = 1
			Me.chkBingHybrid.Id = 25
			Me.chkBingHybrid.LargeGlyph = (CType(resources.GetObject("chkBingHybrid.LargeGlyph"), System.Drawing.Image))
			Me.chkBingHybrid.Name = "chkBingHybrid"
			Me.chkBingHybrid.Tag = 2
'			Me.chkBingHybrid.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.chkBingArea_CheckedChanged);
			' 
			' rpgDataProviders
			' 
			Me.rpgDataProviders.AllowTextClipping = False
			Me.rpgDataProviders.ItemLinks.Add(Me.chkBingArea)
			Me.rpgDataProviders.ItemLinks.Add(Me.chkBingRoad)
			Me.rpgDataProviders.ItemLinks.Add(Me.chkBingHybrid)
			Me.rpgDataProviders.Name = "rpgDataProviders"
			Me.rpgDataProviders.Text = "Data Providers"
			' 
			' BingMapDataProviders
			' 
			Me.Appearance.Options.UseFont = True
			Me.Controls.Add(Me.mapControl1)
			Me.Name = "BingMapDataProviders"
			Me.Size = New System.Drawing.Size(601, 480)
			Me.Controls.SetChildIndex(Me.mapControl1, 0)
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private mapControl1 As MapControl
		Private WithEvents chkBingArea As XtraBars.BarCheckItem
		Private WithEvents chkBingRoad As XtraBars.BarCheckItem
		Private WithEvents chkBingHybrid As XtraBars.BarCheckItem
		Private rpgDataProviders As XtraBars.Ribbon.RibbonPageGroup
		Private TilesLayer As ImageLayer
		Private BingMapDataProvider As BingMapDataProvider
		Private MiniMapImageTilesLayer As MiniMapImageTilesLayer
		Private MiniMapDataProvider As BingMapDataProvider
	End Class
End Namespace
