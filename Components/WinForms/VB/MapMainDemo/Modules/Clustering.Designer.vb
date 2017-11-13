Imports Microsoft.VisualBasic
Imports System.Drawing
Namespace DevExpress.XtraMap.Demos
	Partial Public Class Clustering
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
			Dim splashScreenManager1 As New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, True, GetType(System.Windows.Forms.UserControl))
			Dim mapItemAttributeMapping1 As New DevExpress.XtraMap.MapItemAttributeMapping()
			Dim mapItemAttributeMapping2 As New DevExpress.XtraMap.MapItemAttributeMapping()
			Dim mapDotSizeMapping1 As New DevExpress.XtraMap.MapDotSizeMapping()
			Dim colorListLegend1 As New DevExpress.XtraMap.ColorListLegend()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Clustering))
			Me.ItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.ListSourceDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
			Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
			Me.BingMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.panelSeparator = New DevExpress.XtraEditors.PanelControl()
			Me.barStepInPixels = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar()
			Me.chkClusteringByAttr = New DevExpress.XtraBars.BarCheckItem()
			Me.chkMarkerClustering = New DevExpress.XtraBars.BarCheckItem()
			Me.chkDistanceBasedClustering = New DevExpress.XtraBars.BarCheckItem()
			Me.chkWithoutClustering = New DevExpress.XtraBars.BarCheckItem()
			Me.chkCustomFactory = New DevExpress.XtraBars.BarCheckItem()
			Me.chkWitoutFactory = New DevExpress.XtraBars.BarCheckItem()
			Me.chkClusteringWitoutAttribute = New DevExpress.XtraBars.BarCheckItem()
			Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.rpgClusteringMethod = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgCustomClusterRepresentative = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgGroupByAttributeValues = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgAdditionalOptions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Dim trackBarLabel1 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			Dim trackBarLabel2 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			Dim trackBarLabel3 As New DevExpress.XtraEditors.Repository.TrackBarLabel()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelSeparator, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splashScreenManager1
			' 
			splashScreenManager1.ClosingDelay = 500
			' 
			' ItemsLayer
			' 
			Me.ItemsLayer.Data = Me.ListSourceDataAdapter
			Me.ItemsLayer.HighlightedItemStyle.TextColor = System.Drawing.Color.White
			Me.ItemsLayer.HighlightedItemStyle.TextGlowColor = System.Drawing.Color.Black
			Me.ItemsLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb((CInt(Fix((CByte(84))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(18))))))
			Me.ItemsLayer.ItemStyle.Stroke = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(117))))), (CInt(Fix((CByte(11))))))
			Me.ItemsLayer.ItemStyle.TextColor = System.Drawing.Color.White
			Me.ItemsLayer.ItemStyle.TextGlowColor = System.Drawing.Color.Black
			Me.ItemsLayer.Name = "ItemsLayer"
			Me.ItemsLayer.SelectedItemStyle.TextColor = System.Drawing.Color.White
			Me.ItemsLayer.SelectedItemStyle.TextGlowColor = System.Drawing.Color.Black
			' 
			' ListSourceDataAdapter
			' 
			mapItemAttributeMapping1.Member = "Location"
			mapItemAttributeMapping1.Name = "Location"
			mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.String
			mapItemAttributeMapping2.Member = "Genus"
			mapItemAttributeMapping2.Name = "Genus"
			mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.String
			Me.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1)
			Me.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2)
			Me.ListSourceDataAdapter.Mappings.Latitude = "Latitude"
			Me.ListSourceDataAdapter.Mappings.Longitude = "Longitude"
			Me.ListSourceDataAdapter.Mappings.Type = "Type"
			mapDotSizeMapping1.DefaultValue = 7R
			Me.ListSourceDataAdapter.PropertyMappings.Add(mapDotSizeMapping1)
			' 
			' TilesLayer
			' 
			Me.TilesLayer.DataProvider = Me.BingMapDataProvider
			Me.TilesLayer.Name = "TilesLayer"
			' 
			' BingMapDataProvider
			' 
			Me.BingMapDataProvider.Kind = DevExpress.XtraMap.BingMapKind.Road
			' 
			' mapControl1
			' 
			Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(-37.58R, 143.8R)
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapControl1.Layers.Add(Me.TilesLayer)
			Me.mapControl1.Layers.Add(Me.ItemsLayer)
			colorListLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight
			colorListLegend1.Header = "Trees density"
			colorListLegend1.Layer = Me.ItemsLayer
			Me.mapControl1.Legends.Add(colorListLegend1)
			Me.mapControl1.Location = New System.Drawing.Point(0, 8)
			Me.mapControl1.MinZoomLevel = 10R
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.Size = New System.Drawing.Size(604, 472)
			Me.mapControl1.TabIndex = 0
			Me.mapControl1.ZoomLevel = 12R
'			Me.mapControl1.MapItemClick += New DevExpress.XtraMap.MapItemClickEventHandler(Me.mapControl1_MapItemClick);
			' 
			' panelSeparator
			' 
			Me.panelSeparator.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelSeparator.Location = New System.Drawing.Point(0, 0)
			Me.panelSeparator.Name = "panelSeparator"
			Me.panelSeparator.Size = New System.Drawing.Size(604, 8)
			Me.panelSeparator.TabIndex = 1
			Me.panelSeparator.Visible = False
			' 
			' barStepInPixels
			' 
			Me.barStepInPixels.Edit = Me.repositoryItemTrackBar1
			Me.barStepInPixels.EditValue = 50
			Me.barStepInPixels.EditWidth = 150
			Me.barStepInPixels.EditHeight = 40
			Me.barStepInPixels.Id = 5
			Me.barStepInPixels.Name = "barStepInPixels"
			' 
			' repositoryItemTrackBar1
			' 
			Me.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = True
			Me.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.repositoryItemTrackBar1.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = Utils.HorzAlignment.Center
			trackBarLabel1.Label = "10"
			trackBarLabel1.Value = 10
			trackBarLabel2.Label = "80"
			trackBarLabel2.Value = 80
			trackBarLabel3.Label = "150"
			trackBarLabel3.Value = 150
			Me.repositoryItemTrackBar1.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() { trackBarLabel1, trackBarLabel2, trackBarLabel3})
			Me.repositoryItemTrackBar1.ShowLabels = True
			Me.repositoryItemTrackBar1.TickFrequency = 70
			Me.repositoryItemTrackBar1.LargeChange = 10
			Me.repositoryItemTrackBar1.Maximum = 150
			Me.repositoryItemTrackBar1.Minimum = 10
			Me.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1"
			Me.repositoryItemTrackBar1.ShowValueToolTip = True
			Me.repositoryItemTrackBar1.SmallChange = 10
'			Me.repositoryItemTrackBar1.BeforeShowValueToolTip += New DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(Me.repositoryItemTrackBar1_BeforeShowValueToolTip);
'			Me.repositoryItemTrackBar1.EditValueChanging += New DevExpress.XtraEditors.Controls.ChangingEventHandler(Me.OnEditValueChanging);
			' 
			' chkClusteringByAttr
			' 
			Me.chkClusteringByAttr.Caption = "Attribute"
			Me.chkClusteringByAttr.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.chkClusteringByAttr.Glyph = (CType(resources.GetObject("chkClusteringByAttr.Glyph"), System.Drawing.Image))
			Me.chkClusteringByAttr.GroupIndex = 4
			Me.chkClusteringByAttr.Id = 7
			Me.chkClusteringByAttr.LargeGlyph = (CType(resources.GetObject("chkClusteringByAttr.LargeGlyph"), System.Drawing.Image))
			Me.chkClusteringByAttr.Name = "chkClusteringByAttr"
			Me.chkClusteringByAttr.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
'			Me.chkClusteringByAttr.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnRibbonItemClick);
			' 
			' chkMarkerClustering
			' 
			Me.chkMarkerClustering.BindableChecked = True
			Me.chkMarkerClustering.Caption = "Marker"
			Me.chkMarkerClustering.Checked = True
			Me.chkMarkerClustering.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.chkMarkerClustering.Glyph = (CType(resources.GetObject("chkMarkerClustering.Glyph"), System.Drawing.Image))
			Me.chkMarkerClustering.GroupIndex = 2
			Me.chkMarkerClustering.Id = 8
			Me.chkMarkerClustering.LargeGlyph = (CType(resources.GetObject("chkMarkerClustering.LargeGlyph"), System.Drawing.Image))
			Me.chkMarkerClustering.Name = "chkMarkerClustering"
			Me.chkMarkerClustering.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
'			Me.chkMarkerClustering.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnRibbonItemClick);
			' 
			' chkDistanceBasedClustering
			' 
			Me.chkDistanceBasedClustering.Caption = "Distance-based"
			Me.chkDistanceBasedClustering.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.chkDistanceBasedClustering.Glyph = (CType(resources.GetObject("chkDistanceBasedClustering.Glyph"), System.Drawing.Image))
			Me.chkDistanceBasedClustering.GroupIndex = 2
			Me.chkDistanceBasedClustering.Id = 9
			Me.chkDistanceBasedClustering.LargeGlyph = (CType(resources.GetObject("chkDistanceBasedClustering.LargeGlyph"), System.Drawing.Image))
			Me.chkDistanceBasedClustering.Name = "chkDistanceBasedClustering"
			Me.chkDistanceBasedClustering.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
'			Me.chkDistanceBasedClustering.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnRibbonItemClick);
			' 
			' chkWithoutClustering
			' 
			Me.chkWithoutClustering.Caption = "None"
			Me.chkWithoutClustering.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.chkWithoutClustering.Glyph = (CType(resources.GetObject("chkWithoutClustering.Glyph"), System.Drawing.Image))
			Me.chkWithoutClustering.GroupIndex = 2
			Me.chkWithoutClustering.Id = 10
			Me.chkWithoutClustering.LargeGlyph = (CType(resources.GetObject("chkWithoutClustering.LargeGlyph"), System.Drawing.Image))
			Me.chkWithoutClustering.Name = "chkWithoutClustering"
			Me.chkWithoutClustering.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
'			Me.chkWithoutClustering.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnRibbonItemClick);
			' 
			' chkCustomFactory
			' 
			Me.chkCustomFactory.BindableChecked = True
			Me.chkCustomFactory.Caption = "Custom callout"
			Me.chkCustomFactory.Checked = True
			Me.chkCustomFactory.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.chkCustomFactory.Glyph = (CType(resources.GetObject("chkCustomFactory.Glyph"), System.Drawing.Image))
			Me.chkCustomFactory.GroupIndex = 3
			Me.chkCustomFactory.Id = 12
			Me.chkCustomFactory.LargeGlyph = (CType(resources.GetObject("chkCustomFactory.LargeGlyph"), System.Drawing.Image))
			Me.chkCustomFactory.Name = "chkCustomFactory"
			Me.chkCustomFactory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
'			Me.chkCustomFactory.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnRibbonItemClick);
			' 
			' chkWitoutFactory
			' 
			Me.chkWitoutFactory.Caption = "Default"
			Me.chkWitoutFactory.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.chkWitoutFactory.Glyph = (CType(resources.GetObject("chkWitoutFactory.Glyph"), System.Drawing.Image))
			Me.chkWitoutFactory.GroupIndex = 3
			Me.chkWitoutFactory.Id = 19
			Me.chkWitoutFactory.LargeGlyph = (CType(resources.GetObject("chkWitoutFactory.LargeGlyph"), System.Drawing.Image))
			Me.chkWitoutFactory.Name = "chkWitoutFactory"
			Me.chkWitoutFactory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
'			Me.chkWitoutFactory.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnRibbonItemClick);
			' 
			' chkClusteringWitoutAttribute
			' 
			Me.chkClusteringWitoutAttribute.BindableChecked = True
			Me.chkClusteringWitoutAttribute.Caption = "None"
			Me.chkClusteringWitoutAttribute.Checked = True
			Me.chkClusteringWitoutAttribute.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.chkClusteringWitoutAttribute.Glyph = (CType(resources.GetObject("chkClusteringWitoutAttribute.Glyph"), System.Drawing.Image))
			Me.chkClusteringWitoutAttribute.GroupIndex = 4
			Me.chkClusteringWitoutAttribute.Id = 20
			Me.chkClusteringWitoutAttribute.LargeGlyph = (CType(resources.GetObject("chkClusteringWitoutAttribute.LargeGlyph"), System.Drawing.Image))
			Me.chkClusteringWitoutAttribute.Name = "chkClusteringWitoutAttribute"
			Me.chkClusteringWitoutAttribute.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
'			Me.chkClusteringWitoutAttribute.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnRibbonItemClick);
			' 
			' barStaticItem1
			' 
			'this.barStaticItem1.Caption = "Step In Pixels";
			Me.barStaticItem1.Id = 23
			Me.barStaticItem1.Name = "barStaticItem1"
			Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' rpgClusteringMethod
			' 
			Me.rpgClusteringMethod.ItemLinks.Add(Me.chkMarkerClustering)
			Me.rpgClusteringMethod.ItemLinks.Add(Me.chkDistanceBasedClustering)
			Me.rpgClusteringMethod.ItemLinks.Add(Me.chkWithoutClustering)
			Me.rpgClusteringMethod.Name = "rpgClusteringMethod"
			Me.rpgClusteringMethod.Text = "Clustering Method"
			' 
			' rpgCustomClusterRepresentative
			' 
			Me.rpgCustomClusterRepresentative.AllowTextClipping = False
			Me.rpgCustomClusterRepresentative.ItemLinks.Add(Me.chkCustomFactory)
			Me.rpgCustomClusterRepresentative.ItemLinks.Add(Me.chkWitoutFactory)
			Me.rpgCustomClusterRepresentative.Name = "rpgCustomClusterRepresentative"
			Me.rpgCustomClusterRepresentative.Text = "Custom Cluster Representative"
			' 
			' rpgGroupByAttributeValues
			' 
			Me.rpgGroupByAttributeValues.AllowTextClipping = False
			Me.rpgGroupByAttributeValues.ItemLinks.Add(Me.chkClusteringByAttr)
			Me.rpgGroupByAttributeValues.ItemLinks.Add(Me.chkClusteringWitoutAttribute)
			Me.rpgGroupByAttributeValues.Name = "rpgGroupByAttributeValues"
			Me.rpgGroupByAttributeValues.Text = "Group By Attribute Values"
			' 
			' rpgAdditionalOptions
			' 
			Me.rpgAdditionalOptions.ItemLinks.Add(Me.barStaticItem1)
			Me.rpgAdditionalOptions.ItemLinks.Add(Me.barStepInPixels)
			Me.rpgAdditionalOptions.Name = "rpgAdditionalOptions"
			Me.rpgAdditionalOptions.Text = "Step In Pixels"
			' 
			' Clustering
			' 
			Me.AllowDrop = True
			Me.Controls.Add(Me.mapControl1)
			Me.Controls.Add(Me.panelSeparator)
			Me.Name = "Clustering"
			Me.Size = New System.Drawing.Size(604, 480)
			Me.Controls.SetChildIndex(Me.panelSeparator, 0)
			Me.Controls.SetChildIndex(Me.mapControl1, 0)
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelSeparator, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub



		#End Region

		Private WithEvents mapControl1 As MapControl
		Private panelSeparator As XtraEditors.PanelControl
		Private rpgClusteringMethod As XtraBars.Ribbon.RibbonPageGroup
		Private rpgGroupByAttributeValues As XtraBars.Ribbon.RibbonPageGroup
		Private rpgAdditionalOptions As XtraBars.Ribbon.RibbonPageGroup
		Private rpgCustomClusterRepresentative As XtraBars.Ribbon.RibbonPageGroup
		Private barStepInPixels As XtraBars.BarEditItem
		Private WithEvents repositoryItemTrackBar1 As XtraEditors.Repository.RepositoryItemTrackBar
		Private WithEvents chkClusteringByAttr As XtraBars.BarCheckItem
		Private WithEvents chkMarkerClustering As XtraBars.BarCheckItem
		Private WithEvents chkDistanceBasedClustering As XtraBars.BarCheckItem
		Private WithEvents chkWithoutClustering As XtraBars.BarCheckItem
		Private WithEvents chkCustomFactory As XtraBars.BarCheckItem
		Private WithEvents chkWitoutFactory As XtraBars.BarCheckItem
		Private WithEvents chkClusteringWitoutAttribute As XtraBars.BarCheckItem
		Private barStaticItem1 As XtraBars.BarStaticItem
		Private TilesLayer As ImageLayer
		Private ItemsLayer As VectorItemsLayer
		Private ListSourceDataAdapter As ListSourceDataAdapter
		Private BingMapDataProvider As BingMapDataProvider
	End Class
End Namespace
