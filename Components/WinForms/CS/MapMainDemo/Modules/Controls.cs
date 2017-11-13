using DevExpress.DXperience.Demos;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DevExpress.XtraMap.Demos {
    public class MapTutorialControl : TutorialControlBase, IDXMenuManager {
        #region static
        
        public static string GetSaveFileName(string defaulName) {
            return GetSaveFileName("Xlsx files(*.xlsx)|*.xlsx|All files (*.*)|*.*", defaulName);
        }
        public static string GetSaveFileName(string filter, string defaulName) {
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = filter;
            sfDialog.FileName = defaulName;
            if(sfDialog.ShowDialog() != DialogResult.OK)
                return null;
            return sfDialog.FileName;
        }
        public static void ShowFile(string fileName, TutorialControlBase control) {
            if(!File.Exists(fileName))
                return;
            DialogResult dResult = XtraMessageBox.Show(control.LookAndFeel, control, String.Format("Do you want to open the resulting file: {0} ?", fileName), control.TutorialName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dResult == DialogResult.Yes)
                Process.Start(fileName);
        }
        #endregion
        #region fields
        private LookAndFeelMenu menu = null;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private BarCheckItem chkShowNavPanel;
        private BarCheckItem chkNavigation;
        private BarCheckItem chkMiniMap;
        private BarButtonItem bbiZoomIn;
        private BarButtonItem bbiZoomOut;
        private BarButtonItem bbiInitialView;
        private XtraBars.Ribbon.RibbonPage rpOptions;
        private XtraBars.Ribbon.RibbonPageGroup rpgView;
        IDXMenuManager fMenuManager;
        #endregion

        public MapTutorialControl() {
            InitializeComponent();
            AutoMergeRibbon = true;
        }
        
        #region properties
        protected virtual MapOverlay[] Overlays { get { return new MapOverlay[0]; } }
        protected BarCheckItem ChkShowNavigationPanel { get { return chkShowNavPanel; } }
        protected BarCheckItem ChkShowMinimap { get { return chkMiniMap; } }
        protected BarCheckItem ChkLockNavigation { get { return chkNavigation; } }
        protected RibbonPage OptionsPage { get { return rpOptions; } }
        protected virtual BingMapKind MiniMapBingKind { get { return BingMapKind.Area; } }
        protected virtual MiniMapAlignment MiniMapAlignment { get { return MiniMapAlignment.BottomLeft; } }
        public virtual MapControl MapControl { get { return null; } }

        public LookAndFeelMenu DemoMainMenu {
            get { return menu; }
            set {
                if (menu == value) return;
                this.menu = value;
            }
        }
        public IDXMenuManager MenuManager {
            get { return fMenuManager; }
            set { fMenuManager = value; }
        }
        public virtual bool ShowOptions { get { return false; } }
        #endregion
        #region initialize
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapTutorialControl));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.chkMiniMap = new DevExpress.XtraBars.BarCheckItem();
            this.chkShowNavPanel = new DevExpress.XtraBars.BarCheckItem();
            this.chkNavigation = new DevExpress.XtraBars.BarCheckItem();
            this.bbiZoomIn = new DevExpress.XtraBars.BarButtonItem();
            this.bbiZoomOut = new DevExpress.XtraBars.BarButtonItem();
            this.bbiInitialView = new DevExpress.XtraBars.BarButtonItem();
            this.rpOptions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgView = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.chkMiniMap,
            this.chkShowNavPanel,
            this.chkNavigation,
            this.bbiZoomIn,
            this.bbiZoomOut,
            this.bbiInitialView});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpOptions});
            this.ribbonControl1.Size = new System.Drawing.Size(500, 141);
            // 
            // chkShowMiniMap
            // 
            this.chkMiniMap.Caption = "Show Minimap";
            this.chkMiniMap.Glyph = ((System.Drawing.Image)(resources.GetObject("chkShowMiniMap.Glyph")));
            this.chkMiniMap.Id = 1;
            this.chkMiniMap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkShowMiniMap.LargeGlyph")));
            this.chkMiniMap.Name = "chkShowMiniMap";
            this.chkMiniMap.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkShowMiniMap_CheckedChanged);
            // 
            // chkShowNavPanel
            // 
            this.chkShowNavPanel.BindableChecked = true;
            this.chkShowNavPanel.Caption = "Show Navigation Panel";
            this.chkShowNavPanel.Checked = true;
            this.chkShowNavPanel.Glyph = ((System.Drawing.Image)(resources.GetObject("chkShowNavPanel.Glyph")));
            this.chkShowNavPanel.Id = 2;
            this.chkShowNavPanel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkShowNavPanel.LargeGlyph")));
            this.chkShowNavPanel.Name = "chkShowNavPanel";
            this.chkShowNavPanel.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkShowNavPanel_CheckedChanged);
            // 
            // chkLockNavigation
            // 
            this.chkNavigation.Caption = "Lock Navigation";
            this.chkNavigation.Glyph = ((System.Drawing.Image)(resources.GetObject("chkLockNavigation.Glyph")));
            this.chkNavigation.Id = 3;
            this.chkNavigation.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkLockNavigation.LargeGlyph")));
            this.chkNavigation.Name = "chkLockNavigation";
            this.chkNavigation.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkLockNavigation_CheckedChanged);
            //this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
            // 
            // bbiZoomIn
            // 
            this.bbiZoomIn.Caption = "Zoom In";
            this.bbiZoomIn.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiZoomIn.Glyph")));
            this.bbiZoomIn.Id = 4;
            this.bbiZoomIn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiZoomIn.LargeGlyph")));
            this.bbiZoomIn.Name = "bbiZoomIn";
            this.bbiZoomIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiZoomIn_ItemClick);
            // 
            // bbiZoomOut
            // 
            this.bbiZoomOut.Caption = "Zoom Out";
            this.bbiZoomOut.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiZoomOut.Glyph")));
            this.bbiZoomOut.Id = 5;
            this.bbiZoomOut.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiZoomOut.LargeGlyph")));
            this.bbiZoomOut.Name = "bbiZoomOut";
            this.bbiZoomOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiZoomOut_ItemClick);
            // 
            // bbiInitialView
            // 
            this.bbiInitialView.Caption = "Initial View";
            this.bbiInitialView.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiInitialView.Glyph")));
            this.bbiInitialView.Id = 6;
            this.bbiInitialView.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiInitialView.LargeGlyph")));
            this.bbiInitialView.Name = "bbiInitialView";
            this.bbiInitialView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiInitialView_ItemClick);
            // 
            // ribbonPage1
            // 
            this.rpOptions.Name = "ribbonPage1";
            this.rpOptions.Text = "Options";
            // 
            // ribbonPageGroup1
            // 
            this.rpgView.ItemLinks.Add(this.chkShowNavPanel);
            this.rpgView.ItemLinks.Add(this.chkNavigation);
            this.rpgView.ItemLinks.Add(this.chkMiniMap);
            this.rpgView.ItemLinks.Add(this.bbiZoomIn);
            this.rpgView.ItemLinks.Add(this.bbiZoomOut);
            this.rpgView.ItemLinks.Add(this.bbiInitialView);
            this.rpgView.Name = "ribbonPageGroup1";
            this.rpgView.Text = "View";
            // 
            // MapTutorialControl
            // 
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MapTutorialControl";
            this.Size = new System.Drawing.Size(500, 500);
            this.Load += new System.EventHandler(this.MapTutorialControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        void IDXMenuManager.ShowPopupMenu(DXPopupMenu menu, Control control, Point pos) {
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, fMenuManager, control, pos);
        }
        
        IDXMenuManager IDXMenuManager.Clone(Form newForm) { return this; }

        void IDXMenuManager.DisposeManager() { }

        void InitializeMiniMap() {
            MiniMap miniMap = new MiniMap();
            miniMap.Behavior = new DynamicMiniMapBehavior() { ZoomOffset = -5 };
            miniMap.Layers.Add(CreateMiniMapLayer());
            miniMap.Alignment = MiniMapAlignment;
            MapControl.MiniMap = miniMap;
        }

        protected override void SetControlManager(Control ctrl, BarManager manager) {
            BaseEdit be = ctrl as BaseEdit;
            if (be != null) be.MenuManager = manager;
        }
        protected override void AllowExport() {
            EnabledPrintExportActions(true, true, 
                ExportFormats.PDF | ExportFormats.MHT | ExportFormats.RTF | ExportFormats.XLS | ExportFormats.XLSX | ExportFormats.Image, 
                false);
        }
        protected override void PrintPreview() {
            if(MapControl != null)
                MapControl.ShowRibbonPrintPreview();
        }
        protected override void Print() {
            if(MapControl != null)
                MapControl.Print();
        }
        protected override void ExportToCore(string filename, string ext) {
            MapControl map = MapControl;
            if(map != null) {
                Cursor currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                if(ext == "rtf")
                    map.ExportToRtf(filename);
                else if(ext == "pdf")
                    map.ExportToPdf(filename);
                else if(ext == "mht")
                    map.ExportToMht(filename);
                else if(ext == "xls")
                    map.ExportToXls(filename);
                else if(ext == "xlsx")
                    map.ExportToXlsx(filename);
                Cursor.Current = currentCursor;
            }
        }
        public override bool Equals(object obj) {
            if(obj == null)
                return false;
            return this.GetType().Equals(obj.GetType());
        }
        public override int GetHashCode() {
            return this.GetType().GetHashCode();
        }
        protected override void ExportToImage() {
            if(MapControl == null)
                return;
            string fileName = MainFormHelper.GetFileName("", GetImageFormatsFilter());
            if(!string.IsNullOrEmpty(fileName))
                MapControl.ExportToImage(fileName, GetImageFormat(Path.GetExtension(fileName).TrimStart('.').ToLower()));
        }
        protected virtual MiniMapLayerBase CreateMiniMapLayer() {
            MiniMapImageTilesLayer miniMapImageTilesLayer = new MiniMapImageTilesLayer();
            BingMapDataProvider miniMapDataProvider = new BingMapDataProvider();
            miniMapDataProvider.Kind = MiniMapBingKind;
            DemoUtils.SetBingMapDataProviderKey(miniMapDataProvider);
            miniMapImageTilesLayer.DataProvider = miniMapDataProvider;
            return miniMapImageTilesLayer;
        }

        string GetImageFormatsFilter() {
            string result = string.Empty;
            ImageCodecInfo[] codecInfos = ImageCodecInfo.GetImageEncoders();
            for(int i = 0; i < codecInfos.Length; i++) {
                string extension = codecInfos[i].FormatDescription;
                result += string.Format("{0} Image (*.{1})|*.{1}|", extension.ToUpper(), extension.ToLower());
            }
            return result.TrimEnd('|');
        }
        ImageFormat GetImageFormat(string extension) {
            ImageCodecInfo codecInfo = ImageCodecInfo.GetImageEncoders().First(info => info.FormatDescription.ToLower() == extension);
            foreach(PropertyInfo imageFormatInfo in typeof(ImageFormat).GetProperties().Where(info => info.PropertyType.Equals(typeof(ImageFormat)))) {
                ImageFormat format = (ImageFormat)imageFormatInfo.GetValue(null, null);
                if(format.Guid.Equals(codecInfo.FormatID))
                    return format;
            }
            return null;
        }
        void chkShowMiniMap_CheckedChanged(object sender, ItemClickEventArgs e) {
            if(MapControl.MiniMap == null)
                InitializeMiniMap();
            MapControl.MiniMap.Visible = ((BarCheckItem)e.Item).Checked;
        }
        void chkShowNavPanel_CheckedChanged(object sender, ItemClickEventArgs e) {
            if(MapControl!=null)
                MapControl.NavigationPanelOptions.Visible = ((BarCheckItem)e.Item).Checked;
        }
        void chkLockNavigation_CheckedChanged(object sender, ItemClickEventArgs e) {
            ChangeEnableNavigation(!((BarCheckItem)e.Item).Checked);
        }
        void bbiZoomIn_ItemClick(object sender, ItemClickEventArgs e) {
            MapControl.ZoomIn();
        }
        void bbiZoomOut_ItemClick(object sender, ItemClickEventArgs e) {
            MapControl.ZoomOut();
        }
        void bbiInitialView_ItemClick(object sender, ItemClickEventArgs e) {
            RestoreInitialView();
        }
        protected virtual void RestoreInitialView() {
        }
        protected virtual void ChangeEnableNavigation(bool enable) {
            MapControl.EnableScrolling = enable;
            MapControl.EnableZooming = enable;
            bbiZoomIn.Enabled = enable;
            bbiZoomOut.Enabled = enable;
        }
        protected virtual void InitRibbon() {
            rpOptions.Groups.Add(rpgView);
            chkMiniMap.Checked = MapControl != null && 
                                        MapControl.MiniMap != null && 
                                        MapControl.MiniMap.Visible;
            chkShowNavPanel.Checked = MapControl != null &&
                                        MapControl.NavigationPanelOptions != null && 
                                        MapControl.NavigationPanelOptions.Visible;
        }
        protected void DisableZoomOptions() {
            bbiZoomIn.Enabled = false;
            bbiZoomOut.Enabled = false;
        }
        protected override void ExportToPDF() {
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf");
        }
        protected override void ExportToHTML() {
            ExportTo("html", "HTML document (*.html)|*.html");
        }
        protected override void ExportToMHT() {
            ExportTo("mht", "MHT document (*.mht)|*.mht");
        }
        protected override void ExportToXLS() {
            ExportTo("xls", "XLS document (*.xls)|*.xls");
        }
        protected override void ExportToXLSX() {
            ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx");
        }
        protected override void ExportToRTF() {
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf");
        }
        protected override void ExportToText() {
            ExportTo("txt", "Text document (*.txt)|*.txt");
        }
        public void AppendOverlays() {
            if(MapControl == null)
                return;
            MapControl.Overlays.Clear();
            MapControl.Overlays.AddRange(Overlays);
        }

        void MapTutorialControl_Load(object sender, EventArgs e) {
            InitRibbon();
        }
    }

    public static class MapModulesPool {
        const int MaxModulesCount = 5;

        static List<MapTutorialControl> modules = new List<MapTutorialControl>(MaxModulesCount);

        static void UnregisterModule(MapTutorialControl module) {
            if(!modules.Contains(module))
                return;
            ModuleInfo moduleInfo = ModulesInfo.GetItem(module.TutorialName);
            moduleInfo.ResetModule();
            if(!module.IsDisposed)
                module.Dispose();
            modules.Remove(module);
        }
        public static void RegisterModule(MapTutorialControl module) {
            if(modules.Contains(module)) {
                modules.Remove(module);
                modules.Add(module);
                return;
            }
            if(modules.Count == MaxModulesCount)
                UnregisterModule(modules[0]);
            modules.Add(module);
        }
        public static MapTutorialControl GetPreviousModule() {
            return modules.Count > 0 ? modules[modules.Count - 1] : null;
        }
    }
}
