namespace DevExpress.XtraMap.Demos {
    partial class OlympicMedals {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlympicMedals));
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.ArgumentItemKeyProvider argumentItemKeyProvider1 = new DevExpress.XtraMap.ArgumentItemKeyProvider();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem1 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem2 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem3 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping1 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MeasureRules measureRules1 = new DevExpress.XtraMap.MeasureRules();
            DevExpress.XtraMap.LinearRangeDistribution linearRangeDistribution1 = new DevExpress.XtraMap.LinearRangeDistribution();
            DevExpress.XtraMap.ChartItemValueProvider chartItemValueProvider1 = new DevExpress.XtraMap.ChartItemValueProvider();
            DevExpress.XtraMap.ColorListLegend colorListLegend1 = new DevExpress.XtraMap.ColorListLegend();
            DevExpress.XtraMap.ColorLegendItem colorLegendItem1 = new DevExpress.XtraMap.ColorLegendItem();
            DevExpress.XtraMap.ColorLegendItem colorLegendItem2 = new DevExpress.XtraMap.ColorLegendItem();
            DevExpress.XtraMap.ColorLegendItem colorLegendItem3 = new DevExpress.XtraMap.ColorLegendItem();
            DevExpress.XtraMap.SizeLegend sizeLegend1 = new DevExpress.XtraMap.SizeLegend();
            DevExpress.XtraMap.MapCallout mapCallout1 = new DevExpress.XtraMap.MapCallout();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.PieLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.PieChartDataAdapter = new DevExpress.XtraMap.PieChartDataAdapter();
            this.FileLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.ShapefileDataAdapter = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PositionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GoldGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SilverGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BronzeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LatGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LonGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CountryGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpgLegendType = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.chkPieColorLegend = new DevExpress.XtraBars.BarCheckItem();
            this.chkPieInlineLegend = new DevExpress.XtraBars.BarCheckItem();
            this.chkPieNestedLegend = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Bronze2_32x32.png");
            this.imageCollection1.Images.SetKeyName(1, "Silver2.png");
            this.imageCollection1.Images.SetKeyName(2, "Gold2_32x32.png");
            // 
            // PieLayer
            // 
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(98))))));
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(188))))));
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(152)))), ((int)(((byte)(118))))));
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1;
            colorizerKeyItem1.Key = 1;
            colorizerKeyItem1.Name = "Gold";
            colorizerKeyItem2.Key = 2;
            colorizerKeyItem2.Name = "Silver";
            colorizerKeyItem3.Key = 3;
            colorizerKeyItem3.Name = "Bronze";
            keyColorColorizer1.Keys.Add(colorizerKeyItem1);
            keyColorColorizer1.Keys.Add(colorizerKeyItem2);
            keyColorColorizer1.Keys.Add(colorizerKeyItem3);
            this.PieLayer.Colorizer = keyColorColorizer1;
            this.PieLayer.Data = this.PieChartDataAdapter;
            this.PieLayer.ItemStyle.Stroke = System.Drawing.Color.Black;
            this.PieLayer.ItemStyle.StrokeWidth = 1;
            this.PieLayer.Name = "PieLayer";
            // 
            // PieChartDataAdapter
            // 
            mapItemAttributeMapping1.Member = "Country";
            mapItemAttributeMapping1.Name = "Country";
            this.PieChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1);
            this.PieChartDataAdapter.ItemMaxSize = 60;
            this.PieChartDataAdapter.ItemMinSize = 20;
            this.PieChartDataAdapter.Mappings.Latitude = "Location.Latitude";
            this.PieChartDataAdapter.Mappings.Longitude = "Location.Longitude";
            this.PieChartDataAdapter.Mappings.PieSegment = "MedalClass";
            this.PieChartDataAdapter.Mappings.Value = "Quantity";
            measureRules1.RangeDistribution = linearRangeDistribution1;
            measureRules1.RangeStops.Add(1D);
            measureRules1.RangeStops.Add(10D);
            measureRules1.RangeStops.Add(20D);
            measureRules1.RangeStops.Add(30D);
            measureRules1.RangeStops.Add(40D);
            measureRules1.ValueProvider = chartItemValueProvider1;
            this.PieChartDataAdapter.MeasureRules = measureRules1;
            this.PieChartDataAdapter.PieItemDataMember = "Name";
            // 
            // FileLayer
            // 
            this.FileLayer.Data = this.ShapefileDataAdapter;
            this.FileLayer.EnableHighlighting = false;
            this.FileLayer.EnableSelection = false;
            this.FileLayer.ItemStyle.Fill = System.Drawing.Color.White;
            this.FileLayer.ItemStyle.Stroke = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(139)))), ((int)(((byte)(149)))));
            this.FileLayer.Name = "FileLayer";
            // 
            // mapControl1
            // 
            this.mapControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(40D, 0D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.FileLayer);
            this.mapControl1.Layers.Add(this.PieLayer);
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            colorLegendItem1.ImageIndex = 0;
            colorLegendItem1.Text = "Bronze";
            colorLegendItem2.ImageIndex = 1;
            colorLegendItem2.Text = "Silver";
            colorLegendItem3.ImageIndex = 2;
            colorLegendItem3.Text = "Gold";
            colorListLegend1.CustomItems.Add(colorLegendItem1);
            colorListLegend1.CustomItems.Add(colorLegendItem2);
            colorListLegend1.CustomItems.Add(colorLegendItem3);
            colorListLegend1.Header = "Medals";
            colorListLegend1.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 14F);
            colorListLegend1.ImageList = this.imageCollection1;
            colorListLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Visible;
            sizeLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight;
            sizeLegend1.Header = "Medal Count";
            sizeLegend1.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 14F);
            sizeLegend1.Layer = this.PieLayer;
            sizeLegend1.Type = DevExpress.XtraMap.SizeLegendType.Nested;
            sizeLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Visible;
            this.mapControl1.Legends.Add(colorListLegend1);
            this.mapControl1.Legends.Add(sizeLegend1);
            this.mapControl1.Location = new System.Drawing.Point(0, 141);
            this.mapControl1.MaxZoomLevel = 6D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.RenderMode = DevExpress.XtraMap.RenderMode.Direct2D;
            this.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single;
            this.mapControl1.Size = new System.Drawing.Size(729, 424);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 1.7D;
            this.mapControl1.SelectionChanged += new DevExpress.XtraMap.MapSelectionChangedEventHandler(this.mapControl1_SelectionChanged);
            // 
            // vectorItemsLayer1
            // 
            this.vectorItemsLayer1.Data = this.mapItemStorage1;
            this.vectorItemsLayer1.EnableHighlighting = false;
            this.vectorItemsLayer1.EnableSelection = false;
            // 
            // mapItemStorage1
            // 
            mapCallout1.AllowHtmlText = true;
            mapCallout1.UseAnimation = false;
            this.mapItemStorage1.Items.Add(mapCallout1);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(729, 141);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(209, 424);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PositionGridColumn,
            this.NameGridColumn,
            this.TotalGridColumn,
            this.GoldGridColumn,
            this.SilverGridColumn,
            this.BronzeGridColumn,
            this.LatGridColumn,
            this.LonGridColumn,
            this.CountryGridColumn});
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.GoldGridColumn, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEdit);
            this.gridView1.StartSorting += new System.EventHandler(this.gridView1_StartSorting);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            // 
            // PositionGridColumn
            // 
            this.PositionGridColumn.Caption = "Rank";
            this.PositionGridColumn.FieldName = "Position";
            this.PositionGridColumn.Name = "PositionGridColumn";
            this.PositionGridColumn.OptionsColumn.AllowEdit = false;
            this.PositionGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.PositionGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.PositionGridColumn.Visible = true;
            this.PositionGridColumn.VisibleIndex = 0;
            this.PositionGridColumn.Width = 20;
            // 
            // NameGridColumn
            // 
            this.NameGridColumn.Caption = "Name";
            this.NameGridColumn.FieldName = "Name";
            this.NameGridColumn.Name = "NameGridColumn";
            this.NameGridColumn.OptionsColumn.AllowEdit = false;
            this.NameGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.NameGridColumn.Visible = true;
            this.NameGridColumn.VisibleIndex = 1;
            this.NameGridColumn.Width = 88;
            // 
            // TotalGridColumn
            // 
            this.TotalGridColumn.Caption = "Total";
            this.TotalGridColumn.FieldName = "Total";
            this.TotalGridColumn.Name = "TotalGridColumn";
            this.TotalGridColumn.OptionsColumn.AllowEdit = false;
            this.TotalGridColumn.UnboundExpression = "[Gold] + [Silver] + [Bronze]";
            this.TotalGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.TotalGridColumn.Width = 70;
            // 
            // GoldGridColumn
            // 
            this.GoldGridColumn.Caption = "Gold";
            this.GoldGridColumn.FieldName = "Gold";
            this.GoldGridColumn.Name = "GoldGridColumn";
            this.GoldGridColumn.OptionsColumn.AllowEdit = false;
            this.GoldGridColumn.Width = 66;
            // 
            // SilverGridColumn
            // 
            this.SilverGridColumn.Caption = "Silver";
            this.SilverGridColumn.FieldName = "Silver";
            this.SilverGridColumn.Name = "SilverGridColumn";
            this.SilverGridColumn.OptionsColumn.AllowEdit = false;
            this.SilverGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.SilverGridColumn.Width = 66;
            // 
            // BronzeGridColumn
            // 
            this.BronzeGridColumn.Caption = "Bronze";
            this.BronzeGridColumn.FieldName = "Bronze";
            this.BronzeGridColumn.Name = "BronzeGridColumn";
            this.BronzeGridColumn.OptionsColumn.AllowEdit = false;
            this.BronzeGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.BronzeGridColumn.Width = 72;
            // 
            // LatGridColumn
            // 
            this.LatGridColumn.Caption = "Lat";
            this.LatGridColumn.FieldName = "Location.Latitude";
            this.LatGridColumn.Name = "LatGridColumn";
            this.LatGridColumn.OptionsColumn.AllowEdit = false;
            this.LatGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // LonGridColumn
            // 
            this.LonGridColumn.Caption = "Lon";
            this.LonGridColumn.FieldName = "Location.Longitude";
            this.LonGridColumn.Name = "LonGridColumn";
            this.LonGridColumn.OptionsColumn.AllowEdit = false;
            this.LonGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // CountryGridColumn
            // 
            this.CountryGridColumn.Caption = "Country";
            this.CountryGridColumn.FieldName = "Country";
            this.CountryGridColumn.Name = "CountryGridColumn";
            this.CountryGridColumn.OptionsColumn.AllowEdit = false;
            this.CountryGridColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // rpgLegendType
            // 
            this.rpgLegendType.ItemLinks.Add(this.chkPieColorLegend);
            this.rpgLegendType.ItemLinks.Add(this.chkPieInlineLegend, true);
            this.rpgLegendType.ItemLinks.Add(this.chkPieNestedLegend);
            this.rpgLegendType.Name = "rpgLegendType";
            this.rpgLegendType.Text = "Legend type";
            // 
            // chkPieColorLegend
            // 
            this.chkPieColorLegend.BindableChecked = true;
            this.chkPieColorLegend.Caption = "Color Legend";
            this.chkPieColorLegend.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.chkPieColorLegend.Checked = true;
            this.chkPieColorLegend.Glyph = ((System.Drawing.Image)(resources.GetObject("chkPieColorLegend.Glyph")));
            this.chkPieColorLegend.Id = 14;
            this.chkPieColorLegend.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkPieColorLegend.LargeGlyph")));
            this.chkPieColorLegend.Name = "chkPieColorLegend";
            this.chkPieColorLegend.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnLegendsButtonCheckedChanged);
            // 
            // chkPieInlineLegend
            // 
            this.chkPieInlineLegend.AllowAllUp = true;
            this.chkPieInlineLegend.Caption = "Inline Size Legend";
            this.chkPieInlineLegend.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.chkPieInlineLegend.Glyph = ((System.Drawing.Image)(resources.GetObject("chkPieInlineLegend.Glyph")));
            this.chkPieInlineLegend.GroupIndex = 2;
            this.chkPieInlineLegend.Id = 17;
            this.chkPieInlineLegend.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkPieInlineLegend.LargeGlyph")));
            this.chkPieInlineLegend.Name = "chkPieInlineLegend";
            this.chkPieInlineLegend.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnLegendsButtonCheckedChanged);
            // 
            // chkPieNestedLegend
            // 
            this.chkPieNestedLegend.AllowAllUp = true;
            this.chkPieNestedLegend.BindableChecked = true;
            this.chkPieNestedLegend.Caption = "Nested Size Legend";
            this.chkPieNestedLegend.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.chkPieNestedLegend.Checked = true;
            this.chkPieNestedLegend.Glyph = ((System.Drawing.Image)(resources.GetObject("chkPieNestedLegend.Glyph")));
            this.chkPieNestedLegend.GroupIndex = 2;
            this.chkPieNestedLegend.Id = 18;
            this.chkPieNestedLegend.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkPieNestedLegend.LargeGlyph")));
            this.chkPieNestedLegend.Name = "chkPieNestedLegend";
            this.chkPieNestedLegend.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnLegendsButtonCheckedChanged);
            // 
            // OlympicMedals
            // 
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "OlympicMedals";
            this.Size = new System.Drawing.Size(938, 565);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.mapControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl1;
        private XtraGrid.GridControl gridControl1;
        private XtraGrid.Views.Grid.GridView gridView1;
        private XtraGrid.Columns.GridColumn NameGridColumn;
        private XtraGrid.Columns.GridColumn GoldGridColumn;
        private XtraGrid.Columns.GridColumn SilverGridColumn;
        private XtraGrid.Columns.GridColumn BronzeGridColumn;
        private XtraGrid.Columns.GridColumn TotalGridColumn;
        private XtraGrid.Columns.GridColumn LatGridColumn;
        private XtraGrid.Columns.GridColumn LonGridColumn;
        private XtraGrid.Columns.GridColumn CountryGridColumn;
        private XtraBars.BarCheckItem chkPieColorLegend;
        private XtraGrid.Columns.GridColumn PositionGridColumn;
        private XtraBars.BarCheckItem chkPieInlineLegend;
        private XtraBars.BarCheckItem chkPieNestedLegend;
        private XtraBars.Ribbon.RibbonPageGroup rpgLegendType;
        private Utils.ImageCollection imageCollection1;
        private VectorItemsLayer FileLayer;
        private ShapefileDataAdapter ShapefileDataAdapter;
        private VectorItemsLayer PieLayer;
        
        private PieChartDataAdapter PieChartDataAdapter;
        private VectorItemsLayer vectorItemsLayer1;
        private MapItemStorage mapItemStorage1;
    }
}
