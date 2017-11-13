using DevExpress.DataAccess;
namespace FinanceDashboardDemo {
    public partial class ViewerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
            this.dashboardViewer = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barTools = new DevExpress.XtraBars.Bar();
            this.barItemExport = new DevExpress.XtraBars.BarLargeButtonItem();
            this.popupMenuExport = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barItemPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barItemExportToPdf = new DevExpress.XtraBars.BarButtonItem();
            this.barItemExportToImage = new DevExpress.XtraBars.BarButtonItem();
            this.barItemRefresh = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barItemParameters = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barItemSkin = new DevExpress.XtraBars.BarLargeButtonItem();
            this.gallerySkins = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallerySkins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardViewer
            // 
            this.dashboardViewer.AllowPrintDashboardItems = true;
            this.dashboardViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer.Location = new System.Drawing.Point(0, 42);
            this.dashboardViewer.Margin = new System.Windows.Forms.Padding(10);
            this.dashboardViewer.Name = "dashboardViewer";
            this.dashboardViewer.Padding = new System.Windows.Forms.Padding(5);
            this.dashboardViewer.Size = new System.Drawing.Size(1173, 744);
            this.dashboardViewer.TabIndex = 3;            
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barTools});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barItemExport,
            this.barItemRefresh,
            this.barItemExportToPdf,
            this.barItemExportToImage,
            this.barItemPrint,
            this.barItemSkin,
            this.barItemParameters});
            this.barManager.MaxItemId = 13;
            // 
            // barTools
            // 
            this.barTools.BarName = "Tools";
            this.barTools.DockCol = 0;
            this.barTools.DockRow = 0;
            this.barTools.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barItemExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.barItemRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barItemSkin),
            new DevExpress.XtraBars.LinkPersistInfo(this.barItemParameters)});
            this.barTools.OptionsBar.DrawBorder = false;
            this.barTools.OptionsBar.DrawDragBorder = false;
            this.barTools.OptionsBar.UseWholeRow = true;
            this.barTools.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.barTools.Text = "Tools";
            // 
            // barItemExport
            // 
            this.barItemExport.ActAsDropDown = true;
            this.barItemExport.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barItemExport.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barItemExport.Caption = "Export";
            this.barItemExport.DropDownControl = this.popupMenuExport;
            this.barItemExport.Glyph = ((System.Drawing.Image)(resources.GetObject("barItemExport.Glyph")));
            this.barItemExport.Id = 7;
            this.barItemExport.Name = "barItemExport";
            // 
            // popupMenuExport
            // 
            this.popupMenuExport.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barItemPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.barItemExportToPdf),
            new DevExpress.XtraBars.LinkPersistInfo(this.barItemExportToImage)});
            this.popupMenuExport.Manager = this.barManager;
            this.popupMenuExport.Name = "popupMenuExport";
            // 
            // barItemPrint
            // 
            this.barItemPrint.Caption = "Print Preview...";
            this.barItemPrint.Id = 11;
            this.barItemPrint.Name = "barItemPrint";
            this.barItemPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barItemPrint_ItemClick);
            // 
            // barItemExportToPdf
            // 
            this.barItemExportToPdf.Caption = "Export to PDF";
            this.barItemExportToPdf.Id = 9;
            this.barItemExportToPdf.Name = "barItemExportToPdf";
            this.barItemExportToPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barItemExportToPdf_ItemClick);
            // 
            // barItemExportToImage
            // 
            this.barItemExportToImage.Caption = "Export to Image";
            this.barItemExportToImage.Id = 10;
            this.barItemExportToImage.Name = "barItemExportToImage";
            this.barItemExportToImage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barItemExportToImage_ItemClick);
            // 
            // barItemRefresh
            // 
            this.barItemRefresh.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barItemRefresh.Caption = "Refresh Dashboard";
            this.barItemRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("barItemRefresh.Glyph")));
            this.barItemRefresh.Id = 8;
            this.barItemRefresh.Name = "barItemRefresh";
            this.barItemRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barItemRefresh_ItemClick);
            // 
            // barItemParameters
            // 
            this.barItemParameters.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barItemParameters.Caption = "Parameters ...";
            this.barItemParameters.CausesValidation = true;
            this.barItemParameters.Glyph = global::FinanceDashboardDemo.Properties.Resources.Parameters_32x32;
            this.barItemParameters.Id = 13;
            this.barItemParameters.Name = "barItemParameters";
            this.barItemParameters.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barItemParameters_ItemClick);
            // 
            // barItemSkin
            // 
            this.barItemSkin.ActAsDropDown = true;
            this.barItemSkin.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barItemSkin.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barItemSkin.Caption = "Change Skin";
            this.barItemSkin.CausesValidation = true;
            this.barItemSkin.DropDownControl = this.gallerySkins;
            this.barItemSkin.Glyph = global::FinanceDashboardDemo.Properties.Resources.Appearance_32x32;
            this.barItemSkin.Id = 12;
            this.barItemSkin.Name = "barItemSkin";
            // 
            // gallerySkins
            // 
            this.gallerySkins.Manager = null;
            this.gallerySkins.Name = "gallerySkins";
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.standaloneBarDockControl1.Appearance.Options.UseBackColor = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(1173, 42);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1173, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 786);
            this.barDockControlBottom.Size = new System.Drawing.Size(1173, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 786);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1173, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 786);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.standaloneBarDockControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1173, 42);
            this.panelControl1.TabIndex = 8;
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 786);
            this.Controls.Add(this.dashboardViewer);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 680);
            this.Name = "ViewerForm";
            this.Text = "Financial Dashboard Demo";
            this.Load += new System.EventHandler(this.FinanceDashboardDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallerySkins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.DashboardViewer dashboardViewer;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar barTools;
        private DevExpress.XtraBars.BarLargeButtonItem barItemExport;
        private DevExpress.XtraBars.BarLargeButtonItem barItemRefresh;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.PopupMenu popupMenuExport;
        private DevExpress.XtraBars.BarButtonItem barItemExportToPdf;
        private DevExpress.XtraBars.BarButtonItem barItemExportToImage;
        private DevExpress.XtraBars.BarButtonItem barItemPrint;
        private DevExpress.XtraBars.BarLargeButtonItem barItemSkin;
        private DevExpress.XtraBars.BarLargeButtonItem barItemParameters;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown gallerySkins;        
    }
}

