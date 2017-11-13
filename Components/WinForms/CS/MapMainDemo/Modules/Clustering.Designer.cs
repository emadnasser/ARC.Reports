using System.Drawing;
namespace DevExpress.XtraMap.Demos {
    partial class Clustering {
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true, typeof(System.Windows.Forms.UserControl));
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping1 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping2 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapDotSizeMapping mapDotSizeMapping1 = new DevExpress.XtraMap.MapDotSizeMapping();
            DevExpress.XtraMap.ColorListLegend colorListLegend1 = new DevExpress.XtraMap.ColorListLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clustering));
            this.ItemsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.ListSourceDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.TilesLayer = new DevExpress.XtraMap.ImageLayer();
            this.BingMapDataProvider = new DevExpress.XtraMap.BingMapDataProvider();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.panelSeparator = new DevExpress.XtraEditors.PanelControl();
            this.barStepInPixels = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.chkClusteringByAttr = new DevExpress.XtraBars.BarCheckItem();
            this.chkMarkerClustering = new DevExpress.XtraBars.BarCheckItem();
            this.chkDistanceBasedClustering = new DevExpress.XtraBars.BarCheckItem();
            this.chkWithoutClustering = new DevExpress.XtraBars.BarCheckItem();
            this.chkCustomFactory = new DevExpress.XtraBars.BarCheckItem();
            this.chkWitoutFactory = new DevExpress.XtraBars.BarCheckItem();
            this.chkClusteringWitoutAttribute = new DevExpress.XtraBars.BarCheckItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.rpgClusteringMethod = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgCustomClusterRepresentative = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgGroupByAttributeValues = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgAdditionalOptions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // ItemsLayer
            // 
            this.ItemsLayer.Data = this.ListSourceDataAdapter;
            this.ItemsLayer.HighlightedItemStyle.TextColor = System.Drawing.Color.White;
            this.ItemsLayer.HighlightedItemStyle.TextGlowColor = System.Drawing.Color.Black;
            this.ItemsLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(194)))), ((int)(((byte)(18)))));
            this.ItemsLayer.ItemStyle.Stroke = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(117)))), ((int)(((byte)(11)))));
            this.ItemsLayer.ItemStyle.TextColor = System.Drawing.Color.White;
            this.ItemsLayer.ItemStyle.TextGlowColor = System.Drawing.Color.Black;
            this.ItemsLayer.Name = "ItemsLayer";
            this.ItemsLayer.SelectedItemStyle.TextColor = System.Drawing.Color.White;
            this.ItemsLayer.SelectedItemStyle.TextGlowColor = System.Drawing.Color.Black;
            // 
            // ListSourceDataAdapter
            // 
            mapItemAttributeMapping1.Member = "Location";
            mapItemAttributeMapping1.Name = "Location";
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.String;
            mapItemAttributeMapping2.Member = "Genus";
            mapItemAttributeMapping2.Name = "Genus";
            mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.String;
            this.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1);
            this.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2);
            this.ListSourceDataAdapter.Mappings.Latitude = "Latitude";
            this.ListSourceDataAdapter.Mappings.Longitude = "Longitude";
            this.ListSourceDataAdapter.Mappings.Type = "Type";
            mapDotSizeMapping1.DefaultValue = 7D;
            this.ListSourceDataAdapter.PropertyMappings.Add(mapDotSizeMapping1);
            // 
            // TilesLayer
            // 
            this.TilesLayer.DataProvider = this.BingMapDataProvider;
            this.TilesLayer.Name = "TilesLayer";
            // 
            // BingMapDataProvider
            // 
            this.BingMapDataProvider.Kind = DevExpress.XtraMap.BingMapKind.Road;
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(-37.58D, 143.8D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.TilesLayer);
            this.mapControl1.Layers.Add(this.ItemsLayer);
            colorListLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight;
            colorListLegend1.Header = "Trees density";
            colorListLegend1.Layer = this.ItemsLayer;
            this.mapControl1.Legends.Add(colorListLegend1);
            this.mapControl1.Location = new System.Drawing.Point(0, 8);
            this.mapControl1.MinZoomLevel = 10D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(604, 472);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 12D;
            this.mapControl1.MapItemClick += new DevExpress.XtraMap.MapItemClickEventHandler(this.mapControl1_MapItemClick);
            // 
            // panelSeparator
            // 
            this.panelSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeparator.Location = new System.Drawing.Point(0, 0);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(604, 8);
            this.panelSeparator.TabIndex = 1;
            this.panelSeparator.Visible = false;
            // 
            // barStepInPixels
            // 
            this.barStepInPixels.Edit = this.repositoryItemTrackBar1;
            this.barStepInPixels.EditValue = 50;
            this.barStepInPixels.EditWidth = 150;
            this.barStepInPixels.EditHeight = 40;
            this.barStepInPixels.Id = 5;
            this.barStepInPixels.Name = "barStepInPixels";
            // 
            // repositoryItemTrackBar1
            // 
            this.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = true;
            this.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTrackBar1.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "10";
            trackBarLabel1.Value = 10;
            trackBarLabel2.Label = "80";
            trackBarLabel2.Value = 80;
            trackBarLabel3.Label = "150";
            trackBarLabel3.Value = 150;
            this.repositoryItemTrackBar1.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3});
            this.repositoryItemTrackBar1.ShowLabels = true;
            this.repositoryItemTrackBar1.TickFrequency = 70;
            this.repositoryItemTrackBar1.LargeChange = 10;
            this.repositoryItemTrackBar1.Maximum = 150;
            this.repositoryItemTrackBar1.Minimum = 10;
            this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
            this.repositoryItemTrackBar1.ShowValueToolTip = true;
            this.repositoryItemTrackBar1.SmallChange = 10;
            this.repositoryItemTrackBar1.BeforeShowValueToolTip += new DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(this.repositoryItemTrackBar1_BeforeShowValueToolTip);
            this.repositoryItemTrackBar1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.OnEditValueChanging);
            // 
            // chkClusteringByAttr
            // 
            this.chkClusteringByAttr.Caption = "Attribute";
            this.chkClusteringByAttr.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkClusteringByAttr.Glyph = ((System.Drawing.Image)(resources.GetObject("chkClusteringByAttr.Glyph")));
            this.chkClusteringByAttr.GroupIndex = 4;
            this.chkClusteringByAttr.Id = 7;
            this.chkClusteringByAttr.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkClusteringByAttr.LargeGlyph")));
            this.chkClusteringByAttr.Name = "chkClusteringByAttr";
            this.chkClusteringByAttr.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkClusteringByAttr.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // chkMarkerClustering
            // 
            this.chkMarkerClustering.BindableChecked = true;
            this.chkMarkerClustering.Caption = "Marker";
            this.chkMarkerClustering.Checked = true;
            this.chkMarkerClustering.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkMarkerClustering.Glyph = ((System.Drawing.Image)(resources.GetObject("chkMarkerClustering.Glyph")));
            this.chkMarkerClustering.GroupIndex = 2;
            this.chkMarkerClustering.Id = 8;
            this.chkMarkerClustering.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkMarkerClustering.LargeGlyph")));
            this.chkMarkerClustering.Name = "chkMarkerClustering";
            this.chkMarkerClustering.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkMarkerClustering.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // chkDistanceBasedClustering
            // 
            this.chkDistanceBasedClustering.Caption = "Distance-based";
            this.chkDistanceBasedClustering.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkDistanceBasedClustering.Glyph = ((System.Drawing.Image)(resources.GetObject("chkDistanceBasedClustering.Glyph")));
            this.chkDistanceBasedClustering.GroupIndex = 2;
            this.chkDistanceBasedClustering.Id = 9;
            this.chkDistanceBasedClustering.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkDistanceBasedClustering.LargeGlyph")));
            this.chkDistanceBasedClustering.Name = "chkDistanceBasedClustering";
            this.chkDistanceBasedClustering.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkDistanceBasedClustering.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // chkWithoutClustering
            // 
            this.chkWithoutClustering.Caption = "None";
            this.chkWithoutClustering.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkWithoutClustering.Glyph = ((System.Drawing.Image)(resources.GetObject("chkWithoutClustering.Glyph")));
            this.chkWithoutClustering.GroupIndex = 2;
            this.chkWithoutClustering.Id = 10;
            this.chkWithoutClustering.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkWithoutClustering.LargeGlyph")));
            this.chkWithoutClustering.Name = "chkWithoutClustering";
            this.chkWithoutClustering.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkWithoutClustering.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // chkCustomFactory
            // 
            this.chkCustomFactory.BindableChecked = true;
            this.chkCustomFactory.Caption = "Custom callout";
            this.chkCustomFactory.Checked = true;
            this.chkCustomFactory.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkCustomFactory.Glyph = ((System.Drawing.Image)(resources.GetObject("chkCustomFactory.Glyph")));
            this.chkCustomFactory.GroupIndex = 3;
            this.chkCustomFactory.Id = 12;
            this.chkCustomFactory.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkCustomFactory.LargeGlyph")));
            this.chkCustomFactory.Name = "chkCustomFactory";
            this.chkCustomFactory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkCustomFactory.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // chkWitoutFactory
            // 
            this.chkWitoutFactory.Caption = "Default";
            this.chkWitoutFactory.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkWitoutFactory.Glyph = ((System.Drawing.Image)(resources.GetObject("chkWitoutFactory.Glyph")));
            this.chkWitoutFactory.GroupIndex = 3;
            this.chkWitoutFactory.Id = 19;
            this.chkWitoutFactory.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkWitoutFactory.LargeGlyph")));
            this.chkWitoutFactory.Name = "chkWitoutFactory";
            this.chkWitoutFactory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkWitoutFactory.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // chkClusteringWitoutAttribute
            // 
            this.chkClusteringWitoutAttribute.BindableChecked = true;
            this.chkClusteringWitoutAttribute.Caption = "None";
            this.chkClusteringWitoutAttribute.Checked = true;
            this.chkClusteringWitoutAttribute.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkClusteringWitoutAttribute.Glyph = ((System.Drawing.Image)(resources.GetObject("chkClusteringWitoutAttribute.Glyph")));
            this.chkClusteringWitoutAttribute.GroupIndex = 4;
            this.chkClusteringWitoutAttribute.Id = 20;
            this.chkClusteringWitoutAttribute.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkClusteringWitoutAttribute.LargeGlyph")));
            this.chkClusteringWitoutAttribute.Name = "chkClusteringWitoutAttribute";
            this.chkClusteringWitoutAttribute.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkClusteringWitoutAttribute.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // barStaticItem1
            // 
            //this.barStaticItem1.Caption = "Step In Pixels";
            this.barStaticItem1.Id = 23;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // rpgClusteringMethod
            // 
            this.rpgClusteringMethod.ItemLinks.Add(this.chkMarkerClustering);
            this.rpgClusteringMethod.ItemLinks.Add(this.chkDistanceBasedClustering);
            this.rpgClusteringMethod.ItemLinks.Add(this.chkWithoutClustering);
            this.rpgClusteringMethod.Name = "rpgClusteringMethod";
            this.rpgClusteringMethod.Text = "Clustering Method";
            // 
            // rpgCustomClusterRepresentative
            // 
            this.rpgCustomClusterRepresentative.AllowTextClipping = false;
            this.rpgCustomClusterRepresentative.ItemLinks.Add(this.chkCustomFactory);
            this.rpgCustomClusterRepresentative.ItemLinks.Add(this.chkWitoutFactory);
            this.rpgCustomClusterRepresentative.Name = "rpgCustomClusterRepresentative";
            this.rpgCustomClusterRepresentative.Text = "Custom Cluster Representative";
            // 
            // rpgGroupByAttributeValues
            // 
            this.rpgGroupByAttributeValues.AllowTextClipping = false;
            this.rpgGroupByAttributeValues.ItemLinks.Add(this.chkClusteringByAttr);
            this.rpgGroupByAttributeValues.ItemLinks.Add(this.chkClusteringWitoutAttribute);
            this.rpgGroupByAttributeValues.Name = "rpgGroupByAttributeValues";
            this.rpgGroupByAttributeValues.Text = "Group By Attribute Values";
            // 
            // rpgAdditionalOptions
            // 
            this.rpgAdditionalOptions.ItemLinks.Add(this.barStaticItem1);
            this.rpgAdditionalOptions.ItemLinks.Add(this.barStepInPixels);
            this.rpgAdditionalOptions.Name = "rpgAdditionalOptions";
            this.rpgAdditionalOptions.Text = "Step In Pixels";
            // 
            // Clustering
            // 
            this.AllowDrop = true;
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.panelSeparator);
            this.Name = "Clustering";
            this.Size = new System.Drawing.Size(604, 480);
            this.Controls.SetChildIndex(this.panelSeparator, 0);
            this.Controls.SetChildIndex(this.mapControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion

        private MapControl mapControl1;
        private XtraEditors.PanelControl panelSeparator;
        private XtraBars.Ribbon.RibbonPageGroup rpgClusteringMethod;
        private XtraBars.Ribbon.RibbonPageGroup rpgGroupByAttributeValues;
        private XtraBars.Ribbon.RibbonPageGroup rpgAdditionalOptions;
        private XtraBars.Ribbon.RibbonPageGroup rpgCustomClusterRepresentative;
        private XtraBars.BarEditItem barStepInPixels;
        private XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
        private XtraBars.BarCheckItem chkClusteringByAttr;
        private XtraBars.BarCheckItem chkMarkerClustering;
        private XtraBars.BarCheckItem chkDistanceBasedClustering;
        private XtraBars.BarCheckItem chkWithoutClustering;
        private XtraBars.BarCheckItem chkCustomFactory;
        private XtraBars.BarCheckItem chkWitoutFactory;
        private XtraBars.BarCheckItem chkClusteringWitoutAttribute;
        private XtraBars.BarStaticItem barStaticItem1;
        private ImageLayer TilesLayer;
        private VectorItemsLayer ItemsLayer;
        private ListSourceDataAdapter ListSourceDataAdapter;
        private BingMapDataProvider BingMapDataProvider;
    }
}
