namespace DevExpress.XtraMap.Demos {
    partial class MapElements {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
            OnDispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping1 = new DevExpress.XtraMap.MapItemAttributeMapping();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapElements));
            this.TilesLayer = new DevExpress.XtraMap.ImageLayer();
            this.MapBingDataProvider = new DevExpress.XtraMap.BingMapDataProvider();
            this.PathsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.PathsDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.PlanesLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.PlanesDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.mapContainerPanel = new DevExpress.XtraEditors.PanelControl();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            ((System.ComponentModel.ISupportInitialize)(this.mapContainerPanel)).BeginInit();
            this.mapContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // TilesLayer
            // 
            this.TilesLayer.DataProvider = this.MapBingDataProvider;
            this.TilesLayer.Name = "TilesLayer";
            // 
            // MapBingDataProvider
            // 
            this.MapBingDataProvider.BingKey = "YOUR BING MAPS KEY";
            this.MapBingDataProvider.Kind = DevExpress.XtraMap.BingMapKind.Road;
            // 
            // PathsLayer
            // 
            this.PathsLayer.Data = this.PathsDataAdapter;
            this.PathsLayer.EnableHighlighting = false;
            this.PathsLayer.HighlightedItemStyle.Fill = System.Drawing.Color.Transparent;
            this.PathsLayer.HighlightedItemStyle.Stroke = System.Drawing.Color.Transparent;
            this.PathsLayer.ItemStyle.Fill = System.Drawing.Color.Transparent;
            this.PathsLayer.ItemStyle.Stroke = System.Drawing.Color.Transparent;
            this.PathsLayer.Name = "PathsLayer";
            this.PathsLayer.SelectedItemStyle.Fill = System.Drawing.Color.Transparent;
            this.PathsLayer.SelectedItemStyle.Stroke = System.Drawing.Color.Transparent;
            this.PathsLayer.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.MapElements_DataLoaded);
            // 
            // PathsDataAdapter
            // 
            this.PathsDataAdapter.Mappings.Latitude = "Latitude";
            this.PathsDataAdapter.Mappings.Longitude = "Longitude";
            this.PathsDataAdapter.Mappings.Type = "ItemType";
            // 
            // PlanesLayer
            // 
            this.PlanesLayer.Data = this.PlanesDataAdapter;
            this.PlanesLayer.EnableHighlighting = false;
            this.PlanesLayer.HighlightedItemStyle.Fill = System.Drawing.Color.Transparent;
            this.PlanesLayer.HighlightedItemStyle.Stroke = System.Drawing.Color.Transparent;
            this.PlanesLayer.HighlightedItemStyle.StrokeWidth = 0;
            this.PlanesLayer.ItemStyle.Fill = System.Drawing.Color.Transparent;
            this.PlanesLayer.ItemStyle.Stroke = System.Drawing.Color.Transparent;
            this.PlanesLayer.Name = "PlanesLayer";
            this.PlanesLayer.SelectedItemStyle.Fill = System.Drawing.Color.Transparent;
            this.PlanesLayer.SelectedItemStyle.Stroke = System.Drawing.Color.Transparent;
            this.PlanesLayer.SelectedItemStyle.StrokeWidth = 0;
            // 
            // PlanesDataAdapter
            // 
            mapItemAttributeMapping1.Member = "Icon";
            mapItemAttributeMapping1.Name = "Icon";
            this.PlanesDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1);
            this.PlanesDataAdapter.Mappings.Latitude = "Latitude";
            this.PlanesDataAdapter.Mappings.Longitude = "Longitude";
            // 
            // mapContainerPanel
            // 
            this.mapContainerPanel.Controls.Add(this.mapControl1);
            this.mapContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.mapContainerPanel.Name = "mapContainerPanel";
            this.mapContainerPanel.Size = new System.Drawing.Size(601, 480);
            this.mapContainerPanel.TabIndex = 2;
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(26D, -26D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.TilesLayer);
            this.mapControl1.Layers.Add(this.PathsLayer);
            this.mapControl1.Layers.Add(this.PlanesLayer);
            this.mapControl1.Location = new System.Drawing.Point(2, 2);
            this.mapControl1.MaxZoomLevel = 9D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single;
            this.mapControl1.Size = new System.Drawing.Size(597, 476);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 2D;
            this.mapControl1.DrawMapItem += new DevExpress.XtraMap.DrawMapItemEventHandler(this.mapControl1_DrawMapItem);
            this.mapControl1.SelectionChanging += new DevExpress.XtraMap.MapSelectionChangingEventHandler(this.mapControl1_SelectionChanging);
            this.mapControl1.SelectionChanged += new DevExpress.XtraMap.MapSelectionChangedEventHandler(this.mapControl1_SelectionChanged);
            // 
            // MapElements
            // 
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.mapContainerPanel);
            this.Name = "MapElements";
            this.Size = new System.Drawing.Size(601, 480);
            this.Controls.SetChildIndex(this.mapContainerPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mapContainerPanel)).EndInit();
            this.mapContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }        

        #endregion

        private MapControl mapControl1;
        private XtraEditors.PanelControl mapContainerPanel;
        private ImageLayer TilesLayer;
        private VectorItemsLayer PathsLayer;
        private ListSourceDataAdapter PathsDataAdapter;
        private VectorItemsLayer PlanesLayer;
        private ListSourceDataAdapter PlanesDataAdapter;
        private BingMapDataProvider MapBingDataProvider;
    }
}
