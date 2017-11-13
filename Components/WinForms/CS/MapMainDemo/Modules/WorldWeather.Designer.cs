namespace DevExpress.XtraMap.Demos {
    partial class WorldWeather {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            OnDispose(disposing);
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldWeather));
            this.TilesLayer = new DevExpress.XtraMap.ImageLayer();
            this.BingDataProvider = new DevExpress.XtraMap.BingMapDataProvider();
            this.ItemsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.ListSourceDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.mapContainerPanel = new DevExpress.XtraEditors.PanelControl();
            this.chartPanel = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lbTemperature = new DevExpress.XtraEditors.LabelControl();
            this.peWeatherIcon = new DevExpress.XtraEditors.PictureEdit();
            this.lbCity = new DevExpress.XtraEditors.LabelControl();
            this.chkFahrenheit = new DevExpress.XtraBars.BarCheckItem();
            this.chkCelsius = new DevExpress.XtraBars.BarCheckItem();
            this.chkShowChart = new DevExpress.XtraBars.BarCheckItem();
            this.rpgTemperatureUnits = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapContainerPanel)).BeginInit();
            this.mapContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPanel)).BeginInit();
            this.chartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peWeatherIcon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TilesLayer
            // 
            this.TilesLayer.DataProvider = this.BingDataProvider;
            // 
            // BingDataProvider
            // 
            this.BingDataProvider.Kind = DevExpress.XtraMap.BingMapKind.Area;
            // 
            // ItemsLayer
            // 
            this.ItemsLayer.Data = this.ListSourceDataAdapter;
            // 
            // ListSourceDataAdapter
            // 
            this.ListSourceDataAdapter.Mappings.Latitude = "Latitude";
            this.ListSourceDataAdapter.Mappings.Longitude = "Longitude";
            this.ListSourceDataAdapter.Mappings.Text = "CelsiusDisplayText";
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.TilesLayer);
            this.mapControl1.Layers.Add(this.ItemsLayer);
            this.mapControl1.Location = new System.Drawing.Point(2, 2);
            this.mapControl1.MaxZoomLevel = 5D;
            this.mapControl1.MinZoomLevel = 3D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single;
            this.mapControl1.Size = new System.Drawing.Size(597, 335);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 3D;
            this.mapControl1.SelectionChanging += new DevExpress.XtraMap.MapSelectionChangingEventHandler(this.mapControl1_SelectionChanging);
            this.mapControl1.SelectionChanged += new DevExpress.XtraMap.MapSelectionChangedEventHandler(this.mapControl1_SelectionChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.BackColor = System.Drawing.Color.Black;
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.DataBindings = null;
            xyDiagram1.AxisX.Color = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour;
            xyDiagram1.AxisX.GridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            xyDiagram1.AxisX.GridLines.MinorColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            xyDiagram1.AxisX.GridLines.MinorVisible = true;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Interlaced = true;
            xyDiagram1.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = false;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = false;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = false;
            xyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            xyDiagram1.AxisX.Label.TextPattern = "{A:d}";
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.Tickmarks.Visible = false;
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            xyDiagram1.AxisY.GridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            xyDiagram1.AxisY.GridLines.MinorColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            xyDiagram1.AxisY.InterlacedColor = System.Drawing.Color.Transparent;
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowRotate = false;
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowStagger = false;
            xyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            xyDiagram1.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisY.Tickmarks.Visible = false;
            xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Transparent;
            xyDiagram1.Margins.Bottom = 2;
            xyDiagram1.Margins.Left = 0;
            xyDiagram1.Margins.Right = 0;
            xyDiagram1.Margins.Top = 2;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(15, 72);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(0);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "CurrentDateTime";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.CrosshairLabelPattern = "{A:g}: {V}";
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "Weather.CelsiusTemperature";
            series1.View = lineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.View = lineSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(280, 179);
            this.chartControl1.TabIndex = 14;
            // 
            // mapContainerPanel
            // 
            this.mapContainerPanel.Controls.Add(this.chartPanel);
            this.mapContainerPanel.Controls.Add(this.mapControl1);
            this.mapContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapContainerPanel.Location = new System.Drawing.Point(0, 141);
            this.mapContainerPanel.Name = "mapContainerPanel";
            this.mapContainerPanel.Size = new System.Drawing.Size(601, 339);
            this.mapContainerPanel.TabIndex = 15;
            // 
            // chartPanel
            // 
            this.chartPanel.Appearance.BackColor = System.Drawing.Color.Black;
            this.chartPanel.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.chartPanel.Appearance.Options.UseBackColor = true;
            this.chartPanel.Appearance.Options.UseBorderColor = true;
            this.chartPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.chartPanel.Controls.Add(this.panelControl2);
            this.chartPanel.Controls.Add(this.chartControl1);
            this.chartPanel.Location = new System.Drawing.Point(21, 21);
            this.chartPanel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.chartPanel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Padding = new System.Windows.Forms.Padding(13, 13, 23, 14);
            this.chartPanel.Size = new System.Drawing.Size(320, 267);
            this.chartPanel.TabIndex = 15;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Black;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.lbTemperature);
            this.panelControl2.Controls.Add(this.peWeatherIcon);
            this.panelControl2.Controls.Add(this.lbCity);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(15, 15);
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(280, 57);
            this.panelControl2.TabIndex = 15;
            // 
            // lbTemperature
            // 
            this.lbTemperature.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTemperature.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbTemperature.Appearance.Options.UseFont = true;
            this.lbTemperature.Appearance.Options.UseForeColor = true;
            this.lbTemperature.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbTemperature.Location = new System.Drawing.Point(53, 26);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(182, 34);
            this.lbTemperature.TabIndex = 2;
            // 
            // peWeatherIcon
            // 
            this.peWeatherIcon.Location = new System.Drawing.Point(0, 19);
            this.peWeatherIcon.MenuManager = this;
            this.peWeatherIcon.Name = "peWeatherIcon";
            this.peWeatherIcon.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peWeatherIcon.Properties.Appearance.Options.UseBackColor = true;
            this.peWeatherIcon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peWeatherIcon.Properties.NullText = " ";
            this.peWeatherIcon.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.peWeatherIcon.Properties.ShowMenu = false;
            this.peWeatherIcon.Properties.ZoomAccelerationFactor = 1D;
            this.peWeatherIcon.Size = new System.Drawing.Size(49, 41);
            this.peWeatherIcon.TabIndex = 1;
            // 
            // lbCity
            // 
            this.lbCity.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbCity.Appearance.Options.UseFont = true;
            this.lbCity.Appearance.Options.UseForeColor = true;
            this.lbCity.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbCity.Location = new System.Drawing.Point(14, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(249, 21);
            this.lbCity.TabIndex = 0;
            // 
            // chkFahrenheit
            // 
            this.chkFahrenheit.Caption = "Fahrenheit";
            this.chkFahrenheit.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.chkFahrenheit.Glyph = ((System.Drawing.Image)(resources.GetObject("chkFahrenheit.Glyph")));
            this.chkFahrenheit.GroupIndex = 1;
            this.chkFahrenheit.Id = 1;
            this.chkFahrenheit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkFahrenheit.LargeGlyph")));
            this.chkFahrenheit.Name = "chkFahrenheit";
            this.chkFahrenheit.Tag = 0;
            this.chkFahrenheit.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkFahrenheit_CheckedChanged);
            // 
            // chkCelsius
            // 
            this.chkCelsius.BindableChecked = true;
            this.chkCelsius.Caption = "Celsius";
            this.chkCelsius.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.chkCelsius.Checked = true;
            this.chkCelsius.Glyph = ((System.Drawing.Image)(resources.GetObject("chkCelsius.Glyph")));
            this.chkCelsius.GroupIndex = 1;
            this.chkCelsius.Id = 2;
            this.chkCelsius.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkCelsius.LargeGlyph")));
            this.chkCelsius.Name = "chkCelsius";
            this.chkCelsius.Tag = 0;
            this.chkCelsius.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkFahrenheit_CheckedChanged);
            // 
            // chkShowChart
            // 
            this.chkShowChart.BindableChecked = true;
            this.chkShowChart.Caption = "Details";
            this.chkShowChart.Checked = true;
            this.chkShowChart.Glyph = ((System.Drawing.Image)(resources.GetObject("chkShowChart.Glyph")));
            this.chkShowChart.Id = 5;
            this.chkShowChart.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkShowChart.LargeGlyph")));
            this.chkShowChart.Name = "chkShowChart";
            this.chkShowChart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.chkShowChart_ItemClick);
            // 
            // rpgTemperatureUnits
            // 
            this.rpgTemperatureUnits.AllowTextClipping = false;
            this.rpgTemperatureUnits.ItemLinks.Add(this.chkShowChart);
            this.rpgTemperatureUnits.ItemLinks.Add(this.chkFahrenheit);
            this.rpgTemperatureUnits.ItemLinks.Add(this.chkCelsius);
            this.rpgTemperatureUnits.Name = "rpgTemperatureUnits";
            this.rpgTemperatureUnits.Text = "Temperature Options";
            // 
            // WorldWeather
            // 
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.mapContainerPanel);
            this.Name = "WorldWeather";
            this.Size = new System.Drawing.Size(601, 480);
            this.Controls.SetChildIndex(this.mapContainerPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapContainerPanel)).EndInit();
            this.mapContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPanel)).EndInit();
            this.chartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peWeatherIcon.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl1;
        private XtraCharts.ChartControl chartControl1;
        private XtraEditors.PanelControl mapContainerPanel;
        private XtraEditors.PanelControl chartPanel;
        private XtraEditors.PanelControl panelControl2;
        private XtraEditors.LabelControl lbTemperature;
        private XtraEditors.PictureEdit peWeatherIcon;
        private XtraEditors.LabelControl lbCity;
        private XtraBars.Ribbon.RibbonPageGroup rpgTemperatureUnits;
        //private XtraBars.Ribbon.RibbonPageGroup rpgShow;
        private XtraBars.BarCheckItem chkFahrenheit;
        private XtraBars.BarCheckItem chkCelsius;
        private ImageLayer TilesLayer;
        private VectorItemsLayer ItemsLayer;
        private ListSourceDataAdapter ListSourceDataAdapter;
        private BingMapDataProvider BingDataProvider;
        private XtraBars.BarCheckItem chkShowChart;
    }
}
