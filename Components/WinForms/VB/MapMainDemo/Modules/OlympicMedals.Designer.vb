Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraMap.Demos
	Partial Public Class OlympicMedals
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OlympicMedals))
			Dim keyColorColorizer1 As New DevExpress.XtraMap.KeyColorColorizer()
			Dim argumentItemKeyProvider1 As New DevExpress.XtraMap.ArgumentItemKeyProvider()
			Dim colorizerKeyItem1 As New DevExpress.XtraMap.ColorizerKeyItem()
			Dim colorizerKeyItem2 As New DevExpress.XtraMap.ColorizerKeyItem()
			Dim colorizerKeyItem3 As New DevExpress.XtraMap.ColorizerKeyItem()
			Dim mapItemAttributeMapping1 As New DevExpress.XtraMap.MapItemAttributeMapping()
			Dim measureRules1 As New DevExpress.XtraMap.MeasureRules()
			Dim linearRangeDistribution1 As New DevExpress.XtraMap.LinearRangeDistribution()
			Dim chartItemValueProvider1 As New DevExpress.XtraMap.ChartItemValueProvider()
			Dim colorListLegend1 As New DevExpress.XtraMap.ColorListLegend()
			Dim colorLegendItem1 As New DevExpress.XtraMap.ColorLegendItem()
			Dim colorLegendItem2 As New DevExpress.XtraMap.ColorLegendItem()
			Dim colorLegendItem3 As New DevExpress.XtraMap.ColorLegendItem()
			Dim sizeLegend1 As New DevExpress.XtraMap.SizeLegend()
			Dim mapCallout1 As New DevExpress.XtraMap.MapCallout()
			Dim styleFormatCondition1 As New DevExpress.XtraGrid.StyleFormatCondition()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.PieLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.PieChartDataAdapter = New DevExpress.XtraMap.PieChartDataAdapter()
			Me.FileLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.ShapefileDataAdapter = New DevExpress.XtraMap.ShapefileDataAdapter()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
			Me.mapItemStorage1 = New DevExpress.XtraMap.MapItemStorage()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.PositionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.NameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.TotalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.GoldGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.SilverGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.BronzeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.LatGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.LonGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.CountryGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.rpgLegendType = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.chkPieColorLegend = New DevExpress.XtraBars.BarCheckItem()
			Me.chkPieInlineLegend = New DevExpress.XtraBars.BarCheckItem()
			Me.chkPieNestedLegend = New DevExpress.XtraBars.BarCheckItem()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "Bronze2_32x32.png")
			Me.imageCollection1.Images.SetKeyName(1, "Silver2.png")
			Me.imageCollection1.Images.SetKeyName(2, "Gold2_32x32.png")
			' 
			' PieLayer
			' 
			keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(207))))), (CInt(Fix((CByte(98)))))))
			keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt(Fix((CByte(169))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(188)))))))
			keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(152))))), (CInt(Fix((CByte(118)))))))
			keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1
			colorizerKeyItem1.Key = 1
			colorizerKeyItem1.Name = "Gold"
			colorizerKeyItem2.Key = 2
			colorizerKeyItem2.Name = "Silver"
			colorizerKeyItem3.Key = 3
			colorizerKeyItem3.Name = "Bronze"
			keyColorColorizer1.Keys.Add(colorizerKeyItem1)
			keyColorColorizer1.Keys.Add(colorizerKeyItem2)
			keyColorColorizer1.Keys.Add(colorizerKeyItem3)
			Me.PieLayer.Colorizer = keyColorColorizer1
			Me.PieLayer.Data = Me.PieChartDataAdapter
			Me.PieLayer.ItemStyle.Stroke = System.Drawing.Color.Black
			Me.PieLayer.ItemStyle.StrokeWidth = 1
			Me.PieLayer.Name = "PieLayer"
			' 
			' PieChartDataAdapter
			' 
			mapItemAttributeMapping1.Member = "Country"
			mapItemAttributeMapping1.Name = "Country"
			Me.PieChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1)
			Me.PieChartDataAdapter.ItemMaxSize = 60
			Me.PieChartDataAdapter.ItemMinSize = 20
			Me.PieChartDataAdapter.Mappings.Latitude = "Location.Latitude"
			Me.PieChartDataAdapter.Mappings.Longitude = "Location.Longitude"
			Me.PieChartDataAdapter.Mappings.PieSegment = "MedalClass"
			Me.PieChartDataAdapter.Mappings.Value = "Quantity"
			measureRules1.RangeDistribution = linearRangeDistribution1
			measureRules1.RangeStops.Add(1R)
			measureRules1.RangeStops.Add(10R)
			measureRules1.RangeStops.Add(20R)
			measureRules1.RangeStops.Add(30R)
			measureRules1.RangeStops.Add(40R)
			measureRules1.ValueProvider = chartItemValueProvider1
			Me.PieChartDataAdapter.MeasureRules = measureRules1
			Me.PieChartDataAdapter.PieItemDataMember = "Name"
			' 
			' FileLayer
			' 
			Me.FileLayer.Data = Me.ShapefileDataAdapter
			Me.FileLayer.EnableHighlighting = False
			Me.FileLayer.EnableSelection = False
			Me.FileLayer.ItemStyle.Fill = System.Drawing.Color.White
			Me.FileLayer.ItemStyle.Stroke = System.Drawing.Color.FromArgb((CInt(Fix((CByte(95))))), (CInt(Fix((CByte(139))))), (CInt(Fix((CByte(149))))))
			Me.FileLayer.Name = "FileLayer"
			' 
			' mapControl1
			' 
			Me.mapControl1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(95))))), (CInt(Fix((CByte(139))))), (CInt(Fix((CByte(150))))))
			Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(40R, 0R)
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapControl1.Layers.Add(Me.FileLayer)
			Me.mapControl1.Layers.Add(Me.PieLayer)
			Me.mapControl1.Layers.Add(Me.vectorItemsLayer1)
			colorLegendItem1.ImageIndex = 0
			colorLegendItem1.Text = "Bronze"
			colorLegendItem2.ImageIndex = 1
			colorLegendItem2.Text = "Silver"
			colorLegendItem3.ImageIndex = 2
			colorLegendItem3.Text = "Gold"
			colorListLegend1.CustomItems.Add(colorLegendItem1)
			colorListLegend1.CustomItems.Add(colorLegendItem2)
			colorListLegend1.CustomItems.Add(colorLegendItem3)
			colorListLegend1.Header = "Medals"
			colorListLegend1.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 14F)
			colorListLegend1.ImageList = Me.imageCollection1
			colorListLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Visible
			sizeLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight
			sizeLegend1.Header = "Medal Count"
			sizeLegend1.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 14F)
			sizeLegend1.Layer = Me.PieLayer
			sizeLegend1.Type = DevExpress.XtraMap.SizeLegendType.Nested
			sizeLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Visible
			Me.mapControl1.Legends.Add(colorListLegend1)
			Me.mapControl1.Legends.Add(sizeLegend1)
			Me.mapControl1.Location = New System.Drawing.Point(0, 141)
			Me.mapControl1.MaxZoomLevel = 6R
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.NavigationPanelOptions.Visible = False
			Me.mapControl1.RenderMode = DevExpress.XtraMap.RenderMode.Direct2D
			Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single
			Me.mapControl1.Size = New System.Drawing.Size(729, 424)
			Me.mapControl1.TabIndex = 0
			Me.mapControl1.ZoomLevel = 1.7R
'			Me.mapControl1.SelectionChanged += New DevExpress.XtraMap.MapSelectionChangedEventHandler(Me.mapControl1_SelectionChanged);
			' 
			' vectorItemsLayer1
			' 
			Me.vectorItemsLayer1.Data = Me.mapItemStorage1
			Me.vectorItemsLayer1.EnableHighlighting = False
			Me.vectorItemsLayer1.EnableSelection = False
			' 
			' mapItemStorage1
			' 
			mapCallout1.AllowHtmlText = True
			mapCallout1.UseAnimation = False
			Me.mapItemStorage1.Items.Add(mapCallout1)
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.gridControl1.Location = New System.Drawing.Point(729, 141)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.MenuManager = Me
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(209, 424)
			Me.gridControl1.TabIndex = 8
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.PositionGridColumn, Me.NameGridColumn, Me.TotalGridColumn, Me.GoldGridColumn, Me.SilverGridColumn, Me.BronzeGridColumn, Me.LatGridColumn, Me.LonGridColumn, Me.CountryGridColumn})
			Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() { styleFormatCondition1})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Default
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GoldGridColumn, DevExpress.Data.ColumnSortOrder.Descending)})
'			Me.gridView1.CustomRowCellEdit += New DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(Me.gridView1_CustomRowCellEdit);
'			Me.gridView1.StartSorting += New System.EventHandler(Me.gridView1_StartSorting);
'			Me.gridView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.gridView1_FocusedRowChanged);
'			Me.gridView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.gridView1_CustomUnboundColumnData);
			' 
			' PositionGridColumn
			' 
			Me.PositionGridColumn.Caption = "Rank"
			Me.PositionGridColumn.FieldName = "Position"
			Me.PositionGridColumn.Name = "PositionGridColumn"
			Me.PositionGridColumn.OptionsColumn.AllowEdit = False
			Me.PositionGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.PositionGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer
			Me.PositionGridColumn.Visible = True
			Me.PositionGridColumn.VisibleIndex = 0
			Me.PositionGridColumn.Width = 20
			' 
			' NameGridColumn
			' 
			Me.NameGridColumn.Caption = "Name"
			Me.NameGridColumn.FieldName = "Name"
			Me.NameGridColumn.Name = "NameGridColumn"
			Me.NameGridColumn.OptionsColumn.AllowEdit = False
			Me.NameGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.NameGridColumn.Visible = True
			Me.NameGridColumn.VisibleIndex = 1
			Me.NameGridColumn.Width = 88
			' 
			' TotalGridColumn
			' 
			Me.TotalGridColumn.Caption = "Total"
			Me.TotalGridColumn.FieldName = "Total"
			Me.TotalGridColumn.Name = "TotalGridColumn"
			Me.TotalGridColumn.OptionsColumn.AllowEdit = False
			Me.TotalGridColumn.UnboundExpression = "[Gold] + [Silver] + [Bronze]"
			Me.TotalGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer
			Me.TotalGridColumn.Width = 70
			' 
			' GoldGridColumn
			' 
			Me.GoldGridColumn.Caption = "Gold"
			Me.GoldGridColumn.FieldName = "Gold"
			Me.GoldGridColumn.Name = "GoldGridColumn"
			Me.GoldGridColumn.OptionsColumn.AllowEdit = False
			Me.GoldGridColumn.Width = 66
			' 
			' SilverGridColumn
			' 
			Me.SilverGridColumn.Caption = "Silver"
			Me.SilverGridColumn.FieldName = "Silver"
			Me.SilverGridColumn.Name = "SilverGridColumn"
			Me.SilverGridColumn.OptionsColumn.AllowEdit = False
			Me.SilverGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.SilverGridColumn.Width = 66
			' 
			' BronzeGridColumn
			' 
			Me.BronzeGridColumn.Caption = "Bronze"
			Me.BronzeGridColumn.FieldName = "Bronze"
			Me.BronzeGridColumn.Name = "BronzeGridColumn"
			Me.BronzeGridColumn.OptionsColumn.AllowEdit = False
			Me.BronzeGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.BronzeGridColumn.Width = 72
			' 
			' LatGridColumn
			' 
			Me.LatGridColumn.Caption = "Lat"
			Me.LatGridColumn.FieldName = "Location.Latitude"
			Me.LatGridColumn.Name = "LatGridColumn"
			Me.LatGridColumn.OptionsColumn.AllowEdit = False
			Me.LatGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			' 
			' LonGridColumn
			' 
			Me.LonGridColumn.Caption = "Lon"
			Me.LonGridColumn.FieldName = "Location.Longitude"
			Me.LonGridColumn.Name = "LonGridColumn"
			Me.LonGridColumn.OptionsColumn.AllowEdit = False
			Me.LonGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			' 
			' CountryGridColumn
			' 
			Me.CountryGridColumn.Caption = "Country"
			Me.CountryGridColumn.FieldName = "Country"
			Me.CountryGridColumn.Name = "CountryGridColumn"
			Me.CountryGridColumn.OptionsColumn.AllowEdit = False
			Me.CountryGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			' 
			' rpgLegendType
			' 
			Me.rpgLegendType.ItemLinks.Add(Me.chkPieColorLegend)
			Me.rpgLegendType.ItemLinks.Add(Me.chkPieInlineLegend, True)
			Me.rpgLegendType.ItemLinks.Add(Me.chkPieNestedLegend)
			Me.rpgLegendType.Name = "rpgLegendType"
			Me.rpgLegendType.Text = "Legend type"
			' 
			' chkPieColorLegend
			' 
			Me.chkPieColorLegend.BindableChecked = True
			Me.chkPieColorLegend.Caption = "Color Legend"
			Me.chkPieColorLegend.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.chkPieColorLegend.Checked = True
			Me.chkPieColorLegend.Glyph = (CType(resources.GetObject("chkPieColorLegend.Glyph"), System.Drawing.Image))
			Me.chkPieColorLegend.Id = 14
			Me.chkPieColorLegend.LargeGlyph = (CType(resources.GetObject("chkPieColorLegend.LargeGlyph"), System.Drawing.Image))
			Me.chkPieColorLegend.Name = "chkPieColorLegend"
'			Me.chkPieColorLegend.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnLegendsButtonCheckedChanged);
			' 
			' chkPieInlineLegend
			' 
			Me.chkPieInlineLegend.AllowAllUp = True
			Me.chkPieInlineLegend.Caption = "Inline Size Legend"
			Me.chkPieInlineLegend.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.chkPieInlineLegend.Glyph = (CType(resources.GetObject("chkPieInlineLegend.Glyph"), System.Drawing.Image))
			Me.chkPieInlineLegend.GroupIndex = 2
			Me.chkPieInlineLegend.Id = 17
			Me.chkPieInlineLegend.LargeGlyph = (CType(resources.GetObject("chkPieInlineLegend.LargeGlyph"), System.Drawing.Image))
			Me.chkPieInlineLegend.Name = "chkPieInlineLegend"
'			Me.chkPieInlineLegend.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnLegendsButtonCheckedChanged);
			' 
			' chkPieNestedLegend
			' 
			Me.chkPieNestedLegend.AllowAllUp = True
			Me.chkPieNestedLegend.BindableChecked = True
			Me.chkPieNestedLegend.Caption = "Nested Size Legend"
			Me.chkPieNestedLegend.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.chkPieNestedLegend.Checked = True
			Me.chkPieNestedLegend.Glyph = (CType(resources.GetObject("chkPieNestedLegend.Glyph"), System.Drawing.Image))
			Me.chkPieNestedLegend.GroupIndex = 2
			Me.chkPieNestedLegend.Id = 18
			Me.chkPieNestedLegend.LargeGlyph = (CType(resources.GetObject("chkPieNestedLegend.LargeGlyph"), System.Drawing.Image))
			Me.chkPieNestedLegend.Name = "chkPieNestedLegend"
'			Me.chkPieNestedLegend.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnLegendsButtonCheckedChanged);
			' 
			' OlympicMedals
			' 
			Me.Appearance.Options.UseFont = True
			Me.Controls.Add(Me.mapControl1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "OlympicMedals"
			Me.Size = New System.Drawing.Size(938, 565)
			Me.Controls.SetChildIndex(Me.gridControl1, 0)
			Me.Controls.SetChildIndex(Me.mapControl1, 0)
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents mapControl1 As MapControl
		Private gridControl1 As XtraGrid.GridControl
		Private WithEvents gridView1 As XtraGrid.Views.Grid.GridView
		Private NameGridColumn As XtraGrid.Columns.GridColumn
		Private GoldGridColumn As XtraGrid.Columns.GridColumn
		Private SilverGridColumn As XtraGrid.Columns.GridColumn
		Private BronzeGridColumn As XtraGrid.Columns.GridColumn
		Private TotalGridColumn As XtraGrid.Columns.GridColumn
		Private LatGridColumn As XtraGrid.Columns.GridColumn
		Private LonGridColumn As XtraGrid.Columns.GridColumn
		Private CountryGridColumn As XtraGrid.Columns.GridColumn
		Private WithEvents chkPieColorLegend As XtraBars.BarCheckItem
		Private PositionGridColumn As XtraGrid.Columns.GridColumn
		Private WithEvents chkPieInlineLegend As XtraBars.BarCheckItem
		Private WithEvents chkPieNestedLegend As XtraBars.BarCheckItem
		Private rpgLegendType As XtraBars.Ribbon.RibbonPageGroup
		Private imageCollection1 As Utils.ImageCollection
		Private FileLayer As VectorItemsLayer
		Private ShapefileDataAdapter As ShapefileDataAdapter
		Private PieLayer As VectorItemsLayer

		Private PieChartDataAdapter As PieChartDataAdapter
		Private vectorItemsLayer1 As VectorItemsLayer
		Private mapItemStorage1 As MapItemStorage
	End Class
End Namespace
