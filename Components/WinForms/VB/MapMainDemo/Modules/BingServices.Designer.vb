Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraMap.Demos
	Partial Public Class BingServices
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(BingServices))
			Me.TileLayer = New DevExpress.XtraMap.ImageLayer()
			Me.BingMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
			Me.RouteLayer = New DevExpress.XtraMap.InformationLayer()
			Me.RouteProvider = New DevExpress.XtraMap.BingRouteDataProvider()
			Me.GeocodeLayer = New DevExpress.XtraMap.InformationLayer()
			Me.GeoCodeProvider = New DevExpress.XtraMap.BingGeocodeDataProvider()
			Me.SearchLayer = New DevExpress.XtraMap.InformationLayer()
			Me.SearchProvider = New DevExpress.XtraMap.BingSearchDataProvider()
			Me.ItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.DataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			Me.driveButton = New DevExpress.XtraBars.BarButtonItem()
			Me.clearButton = New DevExpress.XtraBars.BarButtonItem()
			Me.stopButton = New DevExpress.XtraBars.BarButtonItem()
			Me.actionPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.barDeleteButton = New DevExpress.XtraBars.BarButtonItem()
			Me.barCloseButton = New DevExpress.XtraBars.BarButtonItem()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' TileLayer
			' 
			Me.TileLayer.DataProvider = Me.BingMapDataProvider
			Me.TileLayer.Name = "TilesLayer"
			' 
			' RouteLayer
			' 
			Me.RouteLayer.DataProvider = Me.RouteProvider
			Me.RouteLayer.EnableHighlighting = False
			Me.RouteLayer.Name = "RouteLayer"
			' 
			' RouteProvider
			' 
'			Me.RouteProvider.RouteCalculated += New DevExpress.XtraMap.BingRouteCalculatedEventHandler(Me.OnRouteCalculated);
'			Me.RouteProvider.LayerItemsGenerating += New DevExpress.XtraMap.LayerItemsGeneratingEventHandler(Me.OnRouteLayerItemsGenerating);
			' 
			' GeocodeLayer
			' 
			Me.GeocodeLayer.DataProvider = Me.GeoCodeProvider
			Me.GeocodeLayer.Name = "GeocodeLayer"
			' 
			' GeoCodeProvider
			' 
			Me.GeoCodeProvider.MaxVisibleResultCount = 1
			Me.GeoCodeProvider.ProcessMouseEvents = True
'			Me.GeoCodeProvider.LayerItemsGenerating += New DevExpress.XtraMap.LayerItemsGeneratingEventHandler(Me.OnGeoCodeAndSearchLayerItemsGenerating);
			' 
			' SearchLayer
			' 
			Me.SearchLayer.DataProvider = Me.SearchProvider
			Me.SearchLayer.Name = "SearchLayer"
			' 
			' SearchProvider
			' 
'			Me.SearchProvider.LayerItemsGenerating += New DevExpress.XtraMap.LayerItemsGeneratingEventHandler(Me.OnGeoCodeAndSearchLayerItemsGenerating);
			' 
			' ItemsLayer
			' 
			Me.ItemsLayer.Data = Me.DataAdapter
			Me.ItemsLayer.Name = "ItemsLayer"
			' 
			' DataAdapter
			' 
			Me.DataAdapter.Mappings.Latitude = "Latitude"
			Me.DataAdapter.Mappings.Longitude = "Longitude"
			Me.DataAdapter.Mappings.Text = "Text"
			Me.DataAdapter.Mappings.Type = "Type"
			' 
			' mapControl1
			' 
			Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(34.158506R, -118.255629R)
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapControl1.Layers.Add(Me.TileLayer)
			Me.mapControl1.Layers.Add(Me.RouteLayer)
			Me.mapControl1.Layers.Add(Me.GeocodeLayer)
			Me.mapControl1.Layers.Add(Me.SearchLayer)
			Me.mapControl1.Layers.Add(Me.ItemsLayer)
			Me.mapControl1.Location = New System.Drawing.Point(0, 141)
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.NavigationPanelOptions.Visible = False
			Me.mapControl1.Size = New System.Drawing.Size(601, 339)
			Me.mapControl1.TabIndex = 0
			Me.mapControl1.ToolTipController = Me.toolTipController1
			Me.mapControl1.ZoomLevel = 14R
'			Me.mapControl1.MapItemClick += New DevExpress.XtraMap.MapItemClickEventHandler(Me.mapControl1_MapItemClick);
			' 
			' driveButton
			' 
			Me.driveButton.Caption = "Drive"
			Me.driveButton.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.driveButton.Enabled = False
			Me.driveButton.Glyph = (CType(resources.GetObject("driveButton.Glyph"), System.Drawing.Image))
			Me.driveButton.Id = 1
			Me.driveButton.LargeGlyph = (CType(resources.GetObject("driveButton.LargeGlyph"), System.Drawing.Image))
			Me.driveButton.Name = "driveButton"
'			Me.driveButton.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.driveButton_ItemClick);
			' 
			' clearButton
			' 
			Me.clearButton.Caption = "Clear"
			Me.clearButton.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.clearButton.Glyph = (CType(resources.GetObject("clearButton.Glyph"), System.Drawing.Image))
			Me.clearButton.Id = 2
			Me.clearButton.LargeGlyph = (CType(resources.GetObject("clearButton.LargeGlyph"), System.Drawing.Image))
			Me.clearButton.Name = "clearButton"
'			Me.clearButton.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.clearButton_ItemClick);
			' 
			' stopButton
			' 
			Me.stopButton.Caption = "Stop"
			Me.stopButton.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.stopButton.Enabled = False
			Me.stopButton.Glyph = (CType(resources.GetObject("stopButton.Glyph"), System.Drawing.Image))
			Me.stopButton.Id = 3
			Me.stopButton.LargeGlyph = (CType(resources.GetObject("stopButton.LargeGlyph"), System.Drawing.Image))
			Me.stopButton.Name = "stopButton"
'			Me.stopButton.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.stopButton_ItemClick);
			' 
			' actionPageGroup
			' 
			Me.actionPageGroup.ItemLinks.Add(Me.clearButton)
			Me.actionPageGroup.ItemLinks.Add(Me.driveButton)
			Me.actionPageGroup.ItemLinks.Add(Me.stopButton)
			Me.actionPageGroup.Name = "actionPageGroup"
			Me.actionPageGroup.Text = "Actions"
			' 
			' popupMenu1
			' 
			Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barDeleteButton), New DevExpress.XtraBars.LinkPersistInfo(Me.barCloseButton)})
			Me.popupMenu1.Manager = Me.barManager1
			Me.popupMenu1.Name = "popupMenu1"
			' 
			' barDeleteButton
			' 
			Me.barDeleteButton.Caption = "Delete"
			Me.barDeleteButton.Description = "Delete way point from route"
			Me.barDeleteButton.Id = 0
			Me.barDeleteButton.Name = "barDeleteButton"
'			Me.barDeleteButton.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barDeleteButton_ItemClick);
			' 
			' barCloseButton
			' 
			Me.barCloseButton.Caption = "Close"
			Me.barCloseButton.Description = "Cancel operation"
			Me.barCloseButton.Id = 1
			Me.barCloseButton.Name = "barCloseButton"
'			Me.barCloseButton.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barCloseButton_ItemClick);
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barDeleteButton, Me.barCloseButton})
			Me.barManager1.MaxItemId = 2
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Manager = Me.barManager1
			Me.barDockControlTop.Size = New System.Drawing.Size(601, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 480)
			Me.barDockControlBottom.Manager = Me.barManager1
			Me.barDockControlBottom.Size = New System.Drawing.Size(601, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Manager = Me.barManager1
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 480)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(601, 0)
			Me.barDockControlRight.Manager = Me.barManager1
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 480)
			' 
			' BingServices
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.mapControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "BingServices"
			Me.Size = New System.Drawing.Size(601, 480)
			Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
			Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
			Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
			Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
			Me.Controls.SetChildIndex(Me.mapControl1, 0)
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private WithEvents mapControl1 As MapControl
		Private toolTipController1 As Utils.ToolTipController
		Private actionPageGroup As XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents driveButton As XtraBars.BarButtonItem
		Private WithEvents clearButton As XtraBars.BarButtonItem
		Private popupMenu1 As XtraBars.PopupMenu
		Private WithEvents barDeleteButton As XtraBars.BarButtonItem
		Private WithEvents barCloseButton As XtraBars.BarButtonItem
		Private barManager1 As XtraBars.BarManager
		Private barDockControlTop As XtraBars.BarDockControl
		Private barDockControlBottom As XtraBars.BarDockControl
		Private barDockControlLeft As XtraBars.BarDockControl
		Private barDockControlRight As XtraBars.BarDockControl
		Private WithEvents stopButton As XtraBars.BarButtonItem
		Private TileLayer As ImageLayer
		Private RouteLayer As InformationLayer
		Private GeocodeLayer As InformationLayer
		Private SearchLayer As InformationLayer
		Private ItemsLayer As VectorItemsLayer
		Private DataAdapter As ListSourceDataAdapter
		Private WithEvents RouteProvider As BingRouteDataProvider
		Private WithEvents GeoCodeProvider As BingGeocodeDataProvider
		Private WithEvents SearchProvider As BingSearchDataProvider
		Private BingMapDataProvider As BingMapDataProvider
	End Class
End Namespace
