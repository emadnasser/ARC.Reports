namespace DevExpress.XtraMap.Demos {
    partial class BingServices {
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
            OnDispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BingServices));
            this.TileLayer = new DevExpress.XtraMap.ImageLayer();
            this.BingMapDataProvider = new DevExpress.XtraMap.BingMapDataProvider();
            this.RouteLayer = new DevExpress.XtraMap.InformationLayer();
            this.RouteProvider = new DevExpress.XtraMap.BingRouteDataProvider();
            this.GeocodeLayer = new DevExpress.XtraMap.InformationLayer();
            this.GeoCodeProvider = new DevExpress.XtraMap.BingGeocodeDataProvider();
            this.SearchLayer = new DevExpress.XtraMap.InformationLayer();
            this.SearchProvider = new DevExpress.XtraMap.BingSearchDataProvider();
            this.ItemsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.DataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.driveButton = new DevExpress.XtraBars.BarButtonItem();
            this.clearButton = new DevExpress.XtraBars.BarButtonItem();
            this.stopButton = new DevExpress.XtraBars.BarButtonItem();
            this.actionPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barDeleteButton = new DevExpress.XtraBars.BarButtonItem();
            this.barCloseButton = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // TileLayer
            // 
            this.TileLayer.DataProvider = this.BingMapDataProvider;
            this.TileLayer.Name = "TilesLayer";
            // 
            // RouteLayer
            // 
            this.RouteLayer.DataProvider = this.RouteProvider;
            this.RouteLayer.EnableHighlighting = false;
            this.RouteLayer.Name = "RouteLayer";
            // 
            // RouteProvider
            // 
            this.RouteProvider.RouteCalculated += new DevExpress.XtraMap.BingRouteCalculatedEventHandler(this.OnRouteCalculated);
            this.RouteProvider.LayerItemsGenerating += new DevExpress.XtraMap.LayerItemsGeneratingEventHandler(this.OnRouteLayerItemsGenerating);
            // 
            // GeocodeLayer
            // 
            this.GeocodeLayer.DataProvider = this.GeoCodeProvider;
            this.GeocodeLayer.Name = "GeocodeLayer";
            // 
            // GeoCodeProvider
            // 
            this.GeoCodeProvider.MaxVisibleResultCount = 1;
            this.GeoCodeProvider.ProcessMouseEvents = true;
            this.GeoCodeProvider.LayerItemsGenerating += new DevExpress.XtraMap.LayerItemsGeneratingEventHandler(this.OnGeoCodeAndSearchLayerItemsGenerating);
            // 
            // SearchLayer
            // 
            this.SearchLayer.DataProvider = this.SearchProvider;
            this.SearchLayer.Name = "SearchLayer";
            // 
            // SearchProvider
            // 
            this.SearchProvider.LayerItemsGenerating += new DevExpress.XtraMap.LayerItemsGeneratingEventHandler(this.OnGeoCodeAndSearchLayerItemsGenerating);
            // 
            // ItemsLayer
            // 
            this.ItemsLayer.Data = this.DataAdapter;
            this.ItemsLayer.Name = "ItemsLayer";
            // 
            // DataAdapter
            // 
            this.DataAdapter.Mappings.Latitude = "Latitude";
            this.DataAdapter.Mappings.Longitude = "Longitude";
            this.DataAdapter.Mappings.Text = "Text";
            this.DataAdapter.Mappings.Type = "Type";
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(34.158506D, -118.255629D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.TileLayer);
            this.mapControl1.Layers.Add(this.RouteLayer);
            this.mapControl1.Layers.Add(this.GeocodeLayer);
            this.mapControl1.Layers.Add(this.SearchLayer);
            this.mapControl1.Layers.Add(this.ItemsLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 141);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.Size = new System.Drawing.Size(601, 339);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ToolTipController = this.toolTipController1;
            this.mapControl1.ZoomLevel = 14D;
            this.mapControl1.MapItemClick += new DevExpress.XtraMap.MapItemClickEventHandler(this.mapControl1_MapItemClick);
            // 
            // driveButton
            // 
            this.driveButton.Caption = "Drive";
            this.driveButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.driveButton.Enabled = false;
            this.driveButton.Glyph = ((System.Drawing.Image)(resources.GetObject("driveButton.Glyph")));
            this.driveButton.Id = 1;
            this.driveButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("driveButton.LargeGlyph")));
            this.driveButton.Name = "driveButton";
            this.driveButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.driveButton_ItemClick);
            // 
            // clearButton
            // 
            this.clearButton.Caption = "Clear";
            this.clearButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.clearButton.Glyph = ((System.Drawing.Image)(resources.GetObject("clearButton.Glyph")));
            this.clearButton.Id = 2;
            this.clearButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("clearButton.LargeGlyph")));
            this.clearButton.Name = "clearButton";
            this.clearButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearButton_ItemClick);
            // 
            // stopButton
            // 
            this.stopButton.Caption = "Stop";
            this.stopButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.stopButton.Enabled = false;
            this.stopButton.Glyph = ((System.Drawing.Image)(resources.GetObject("stopButton.Glyph")));
            this.stopButton.Id = 3;
            this.stopButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("stopButton.LargeGlyph")));
            this.stopButton.Name = "stopButton";
            this.stopButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.stopButton_ItemClick);
            // 
            // actionPageGroup
            // 
            this.actionPageGroup.ItemLinks.Add(this.clearButton);
            this.actionPageGroup.ItemLinks.Add(this.driveButton);
            this.actionPageGroup.ItemLinks.Add(this.stopButton);
            this.actionPageGroup.Name = "actionPageGroup";
            this.actionPageGroup.Text = "Actions";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barDeleteButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCloseButton)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barDeleteButton
            // 
            this.barDeleteButton.Caption = "Delete";
            this.barDeleteButton.Description = "Delete way point from route";
            this.barDeleteButton.Id = 0;
            this.barDeleteButton.Name = "barDeleteButton";
            this.barDeleteButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDeleteButton_ItemClick);
            // 
            // barCloseButton
            // 
            this.barCloseButton.Caption = "Close";
            this.barCloseButton.Description = "Cancel operation";
            this.barCloseButton.Id = 1;
            this.barCloseButton.Name = "barCloseButton";
            this.barCloseButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCloseButton_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barDeleteButton,
            this.barCloseButton});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(601, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 480);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(601, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 480);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(601, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 480);
            // 
            // BingServices
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BingServices";
            this.Size = new System.Drawing.Size(601, 480);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.mapControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private MapControl mapControl1;
        private Utils.ToolTipController toolTipController1;
        private XtraBars.Ribbon.RibbonPageGroup actionPageGroup;
        private XtraBars.BarButtonItem driveButton;
        private XtraBars.BarButtonItem clearButton;
        private XtraBars.PopupMenu popupMenu1;
        private XtraBars.BarButtonItem barDeleteButton;
        private XtraBars.BarButtonItem barCloseButton;
        private XtraBars.BarManager barManager1;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraBars.BarButtonItem stopButton;
        private ImageLayer TileLayer;
        private InformationLayer RouteLayer;
        private InformationLayer GeocodeLayer;
        private InformationLayer SearchLayer;
        private VectorItemsLayer ItemsLayer;
        private ListSourceDataAdapter DataAdapter;
        private BingRouteDataProvider RouteProvider;
        private BingGeocodeDataProvider GeoCodeProvider;
        private BingSearchDataProvider SearchProvider;
        private BingMapDataProvider BingMapDataProvider;
    }
}
