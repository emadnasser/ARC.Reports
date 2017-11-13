﻿namespace DevExpress.ApplicationUI.Demos {
    partial class DocumentManagerNoDocumentsMode {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Designer generated code

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.clientContainer = new DevExpress.XtraEditors.XtraUserControl();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.noDocumentsView1 = new DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.clientContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager
            // 
            this.documentManager.BarAndDockingController = this.barAndDockingController1;
            this.documentManager.ClientControl = this.clientContainer;
            this.documentManager.MenuManager = this.barManager1;
            this.documentManager.View = this.noDocumentsView1;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.noDocumentsView1});
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController1.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // clientContainer
            // 
            this.clientContainer.Controls.Add(this.richEditControl1);
            this.clientContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientContainer.Location = new System.Drawing.Point(200, 0);
            this.clientContainer.Name = "clientContainer";
            this.clientContainer.Padding = new System.Windows.Forms.Padding(2);
            this.clientContainer.Size = new System.Drawing.Size(403, 448);
            this.clientContainer.TabIndex = 0;
            // 
            // richEditControl1
            // 
            this.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(2, 2);
            this.richEditControl1.MenuManager = this.barManager1;
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.richEditControl1.Options.MailMerge.KeepLastParagraph = false;
            this.richEditControl1.Size = new System.Drawing.Size(399, 444);
            this.richEditControl1.TabIndex = 7;
            this.richEditControl1.Text = "richEditControl1";
            this.richEditControl1.Views.SimpleView.AllowDisplayLineNumbers = true;
            // 
            // barManager1
            // 
            this.barManager1.Controller = this.barAndDockingController1;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(803, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 448);
            this.barDockControlBottom.Size = new System.Drawing.Size(803, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 448);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(803, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 448);
            // 
            // dockManager1
            // 
            this.dockManager1.Controller = this.barAndDockingController1;
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1,
            this.dockPanel3});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.dockPanel2);
            this.panelContainer1.Controls.Add(this.dockPanel1);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.panelContainer1.FloatSize = new System.Drawing.Size(351, 200);
            this.panelContainer1.Footer = null;
            this.panelContainer1.Header = null;
            this.panelContainer1.ID = new System.Guid("12ee75ca-d68b-4d14-bfcf-76b9f3eebfbd");
            this.panelContainer1.Location = new System.Drawing.Point(0, 0);
            this.panelContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.Size = new System.Drawing.Size(200, 448);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel2.FloatSize = new System.Drawing.Size(351, 200);
            this.dockPanel2.Footer = null;
            this.dockPanel2.Header = null;
            this.dockPanel2.ID = new System.Guid("d1c1aeb8-8e7f-4a11-9a30-751d4bd0c5a6");
            this.dockPanel2.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 213);
            this.dockPanel2.Size = new System.Drawing.Size(200, 213);
            this.dockPanel2.Text = "TopLeft Panel";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(192, 186);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel1.FloatSize = new System.Drawing.Size(527, 492);
            this.dockPanel1.FloatVertical = true;
            this.dockPanel1.Footer = null;
            this.dockPanel1.Header = null;
            this.dockPanel1.ID = new System.Guid("58c0c721-7d02-4c1a-ba0f-7010bc2df956");
            this.dockPanel1.Location = new System.Drawing.Point(0, 213);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 213);
            this.dockPanel1.Size = new System.Drawing.Size(200, 235);
            this.dockPanel1.Text = "BottomLeft Panel";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 208);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dockPanel3
            // 
            this.dockPanel3.Controls.Add(this.dockPanel3_Container);
            this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel3.FloatSize = new System.Drawing.Size(330, 200);
            this.dockPanel3.Footer = null;
            this.dockPanel3.Header = null;
            this.dockPanel3.ID = new System.Guid("1539c64a-1755-446f-b583-b0580e9ba1d7");
            this.dockPanel3.Location = new System.Drawing.Point(603, 0);
            this.dockPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel3.Name = "dockPanel3";
            this.dockPanel3.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel3.Size = new System.Drawing.Size(200, 448);
            this.dockPanel3.Text = "Right Panel";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel3_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(192, 421);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // DocumentManagerNoDocumensMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientContainer);
            this.Controls.Add(this.dockPanel3);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DocumentManagerNoDocumensMode";
            this.Size = new System.Drawing.Size(803, 448);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.clientContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView noDocumentsView1;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel3;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraEditors.XtraUserControl clientContainer;
        private XtraRichEdit.RichEditControl richEditControl1;
    }
}
