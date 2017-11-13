namespace DevExpress.XtraMap.Demos {
    partial class BingMapDataProviders {
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
            DevExpress.XtraMap.MiniMap miniMap1 = new DevExpress.XtraMap.MiniMap();
            DevExpress.XtraMap.DynamicMiniMapBehavior dynamicMiniMapBehavior1 = new DevExpress.XtraMap.DynamicMiniMapBehavior();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BingMapDataProviders));
            this.MiniMapImageTilesLayer = new DevExpress.XtraMap.MiniMapImageTilesLayer();
            this.MiniMapDataProvider = new DevExpress.XtraMap.BingMapDataProvider();
            this.TilesLayer = new DevExpress.XtraMap.ImageLayer();
            this.BingMapDataProvider = new DevExpress.XtraMap.BingMapDataProvider();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.chkBingArea = new DevExpress.XtraBars.BarCheckItem();
            this.chkBingRoad = new DevExpress.XtraBars.BarCheckItem();
            this.chkBingHybrid = new DevExpress.XtraBars.BarCheckItem();
            this.rpgDataProviders = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // MiniMapImageTilesLayer
            // 
            this.MiniMapImageTilesLayer.DataProvider = this.MiniMapDataProvider;
            this.MiniMapImageTilesLayer.Name = "ImageTilesLayer";
            // 
            // TilesLayer
            // 
            this.TilesLayer.DataProvider = this.BingMapDataProvider;
            this.TilesLayer.Name = "TilesLayer";
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.TilesLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 139);
            miniMap1.Alignment = DevExpress.XtraMap.MiniMapAlignment.TopRight;
            dynamicMiniMapBehavior1.ZoomOffset = -5D;
            miniMap1.Behavior = dynamicMiniMapBehavior1;
            miniMap1.Layers.Add(this.MiniMapImageTilesLayer);
            this.mapControl1.MiniMap = miniMap1;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.Size = new System.Drawing.Size(601, 341);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 2D;
            // 
            // chkBingArea
            // 
            this.chkBingArea.Caption = "Bing Area";
            this.chkBingArea.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.chkBingArea.Glyph = ((System.Drawing.Image)(resources.GetObject("chkBingArea.Glyph")));
            this.chkBingArea.GroupIndex = 1;
            this.chkBingArea.Id = 23;
            this.chkBingArea.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkBingArea.LargeGlyph")));
            this.chkBingArea.Name = "chkBingArea";
            this.chkBingArea.Tag = 0;
            this.chkBingArea.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkBingArea_CheckedChanged);
            // 
            // chkBingRoad
            // 
            this.chkBingRoad.Caption = "Bing Road";
            this.chkBingRoad.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.chkBingRoad.Glyph = ((System.Drawing.Image)(resources.GetObject("chkBingRoad.Glyph")));
            this.chkBingRoad.GroupIndex = 1;
            this.chkBingRoad.Id = 24;
            this.chkBingRoad.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkBingRoad.LargeGlyph")));
            this.chkBingRoad.Name = "chkBingRoad";
            this.chkBingRoad.Tag = 1;
            this.chkBingRoad.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkBingArea_CheckedChanged);
            // 
            // chkBingHybrid
            // 
            this.chkBingHybrid.Caption = "Bing Hybrid";
            this.chkBingHybrid.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.chkBingHybrid.Glyph = ((System.Drawing.Image)(resources.GetObject("chkBingHybrid.Glyph")));
            this.chkBingHybrid.GroupIndex = 1;
            this.chkBingHybrid.Id = 25;
            this.chkBingHybrid.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkBingHybrid.LargeGlyph")));
            this.chkBingHybrid.Name = "chkBingHybrid";
            this.chkBingHybrid.Tag = 2;
            this.chkBingHybrid.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkBingArea_CheckedChanged);
            // 
            // rpgDataProviders
            // 
            this.rpgDataProviders.AllowTextClipping = false;
            this.rpgDataProviders.ItemLinks.Add(this.chkBingArea);
            this.rpgDataProviders.ItemLinks.Add(this.chkBingRoad);
            this.rpgDataProviders.ItemLinks.Add(this.chkBingHybrid);
            this.rpgDataProviders.Name = "rpgDataProviders";
            this.rpgDataProviders.Text = "Data Providers";
            // 
            // BingMapDataProviders
            // 
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.mapControl1);
            this.Name = "BingMapDataProviders";
            this.Size = new System.Drawing.Size(601, 480);
            this.Controls.SetChildIndex(this.mapControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl1;
        private XtraBars.BarCheckItem chkBingArea;
        private XtraBars.BarCheckItem chkBingRoad;
        private XtraBars.BarCheckItem chkBingHybrid;
        private XtraBars.Ribbon.RibbonPageGroup rpgDataProviders;
        private ImageLayer TilesLayer;
        private BingMapDataProvider BingMapDataProvider;
        private MiniMapImageTilesLayer MiniMapImageTilesLayer;
        private BingMapDataProvider MiniMapDataProvider;
    }
}
