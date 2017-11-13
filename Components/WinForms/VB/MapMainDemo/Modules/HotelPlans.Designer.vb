Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraMap.Demos
	Partial Public Class HotelPlans
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
			Dim keyColorColorizer1 As New DevExpress.XtraMap.KeyColorColorizer()
			Dim attributeItemKeyProvider1 As New DevExpress.XtraMap.AttributeItemKeyProvider()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(HotelPlans))
			Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
			Me.BingMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
			Me.HotelPlanLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.HotelsLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.HotelsItemStorage = New DevExpress.XtraMap.MapItemStorage()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' TilesLayer
			' 
			Me.TilesLayer.DataProvider = Me.BingMapDataProvider
			Me.TilesLayer.Name = "TilesLayer"
			' 
			' HotelPlanLayer
			' 
			attributeItemKeyProvider1.AttributeName = "CATEGORY"
			keyColorColorizer1.ItemKeyProvider = attributeItemKeyProvider1
			keyColorColorizer1.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Palette
			Me.HotelPlanLayer.Colorizer = keyColorColorizer1
			Me.HotelPlanLayer.EnableSelection = False
			Me.HotelPlanLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))))
			Me.HotelPlanLayer.ItemStyle.Stroke = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.HotelPlanLayer.Name = "HotelPlanLayer"
			Me.HotelPlanLayer.ToolTipPattern = "{NAME}"
			Me.HotelPlanLayer.Visible = False
'			Me.HotelPlanLayer.DataLoaded += New DevExpress.XtraMap.DataLoadedEventHandler(Me.HotelPlanLayer_DataLoaded);
			' 
			' HotelsLayer
			' 
			Me.HotelsLayer.Data = Me.HotelsItemStorage
			Me.HotelsLayer.HighlightedItemStyle.TextColor = System.Drawing.Color.White
			Me.HotelsLayer.HighlightedItemStyle.TextGlowColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(117))))), (CInt(Fix((CByte(0))))))
			Me.HotelsLayer.Name = "HotelsOnMapLayer"
			Me.HotelsLayer.SelectedItemStyle.TextColor = System.Drawing.Color.White
			Me.HotelsLayer.SelectedItemStyle.TextGlowColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(117))))), (CInt(Fix((CByte(0))))))
			' 
			' mapControl1
			' 
			Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(-21.1685R, -175.1343R)
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapControl1.ImageList = Me.imageCollection1
			Me.mapControl1.Layers.Add(Me.TilesLayer)
			Me.mapControl1.Layers.Add(Me.HotelPlanLayer)
			Me.mapControl1.Layers.Add(Me.HotelsLayer)
			Me.mapControl1.Location = New System.Drawing.Point(0, 0)
			Me.mapControl1.MaxZoomLevel = 15R
			Me.mapControl1.MinZoomLevel = 13R
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.Size = New System.Drawing.Size(500, 500)
			Me.mapControl1.TabIndex = 0
			Me.mapControl1.ToolTipController = Me.toolTipController1
			Me.mapControl1.ZoomLevel = 13R
'			Me.mapControl1.DrawMapItem += New DevExpress.XtraMap.DrawMapItemEventHandler(Me.mapControl1_DrawMapItem);
'			Me.mapControl1.MapItemClick += New DevExpress.XtraMap.MapItemClickEventHandler(Me.mapControl1_MapItemClick);
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageSize = New System.Drawing.Size(83, 93)
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "Hotel_1.png")
			Me.imageCollection1.Images.SetKeyName(1, "Hotel_2.png")
			Me.imageCollection1.Images.SetKeyName(2, "Hotel_3.png")
			Me.imageCollection1.Images.SetKeyName(3, "Hotel_1_h.png")
			Me.imageCollection1.Images.SetKeyName(4, "Hotel_2_h.png")
			Me.imageCollection1.Images.SetKeyName(5, "Hotel_3_h.png")
			' 
			' toolTipController1
			' 
'			Me.toolTipController1.BeforeShow += New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(Me.toolTipController1_BeforeShow);
			' 
			' imageCollection2
			' 
			Me.imageCollection2.ImageSize = New System.Drawing.Size(31, 31)
			Me.imageCollection2.ImageStream = (CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection2.Images.SetKeyName(0, "back_btn_2.png")
			' 
			' HotelPlans
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.mapControl1)
			Me.Name = "HotelPlans"
			Me.Controls.SetChildIndex(Me.mapControl1, 0)
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents mapControl1 As MapControl
		Private WithEvents toolTipController1 As Utils.ToolTipController
		Private imageCollection1 As Utils.ImageCollection
		Private imageCollection2 As Utils.ImageCollection
		Private TilesLayer As ImageLayer
		Private WithEvents HotelPlanLayer As VectorItemsLayer
		Private HotelsLayer As VectorItemsLayer
		Private BingMapDataProvider As BingMapDataProvider
		Private HotelsItemStorage As MapItemStorage
	End Class
End Namespace
