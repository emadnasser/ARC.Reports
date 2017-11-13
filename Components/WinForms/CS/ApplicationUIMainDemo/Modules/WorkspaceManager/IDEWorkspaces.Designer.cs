namespace DevExpress.ApplicationUI.Demos {
    partial class IDEWorkspaces {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDEWorkspaces));
            DevExpress.Utils.Animation.CombTransition combTransition1 = new DevExpress.Utils.Animation.CombTransition();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.toolboxImages = new System.Windows.Forms.ImageList(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ucSolutionExplorer1 = new DevExpress.ApplicationUI.Demos.ucSolutionExplorer();
            this.dockPanel4 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ucOutput1 = new DevExpress.ApplicationUI.Demos.ucOutput();
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.document2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.document3 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.dockPanel3.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            this.dockPanel4.SuspendLayout();
            this.dockPanel4_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.MenuManager = this.barManager1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barWorkspaceMenuItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 15;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem11),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem12, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem13)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "New File";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Open";
            this.barButtonItem6.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.Glyph")));
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.LargeGlyph")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Save";
            this.barButtonItem7.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.LargeGlyph")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Print";
            this.barButtonItem8.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.Glyph")));
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.LargeGlyph")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Cut";
            this.barButtonItem9.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.Glyph")));
            this.barButtonItem9.Id = 8;
            this.barButtonItem9.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.LargeGlyph")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Copy";
            this.barButtonItem10.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.Glyph")));
            this.barButtonItem10.Id = 9;
            this.barButtonItem10.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.LargeGlyph")));
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Paste";
            this.barButtonItem11.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.Glyph")));
            this.barButtonItem11.Id = 10;
            this.barButtonItem11.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.LargeGlyph")));
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Undo";
            this.barButtonItem12.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.Glyph")));
            this.barButtonItem12.Id = 11;
            this.barButtonItem12.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.LargeGlyph")));
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Redo";
            this.barButtonItem13.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.Glyph")));
            this.barButtonItem13.Id = 12;
            this.barButtonItem13.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.LargeGlyph")));
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barWorkspaceMenuItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "File";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Edit";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Toolbars";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Help";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "Workspaces";
            this.barWorkspaceMenuItem1.Id = 14;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.ShowSaveLoadCommands = true;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(914, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 505);
            this.barDockControlBottom.Size = new System.Drawing.Size(914, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 452);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(914, 53);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 452);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1,
            this.panelContainer1,
            this.dockPanel4});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("1c0462cd-5b46-461e-80af-99fd4075d170");
            this.dockPanel1.Location = new System.Drawing.Point(0, 53);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 452);
            this.dockPanel1.Text = "Toolbox";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 425);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = null;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 192;
            this.navBarControl1.Size = new System.Drawing.Size(192, 425);
            this.navBarControl1.SmallImages = this.toolboxImages;
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // toolboxImages
            // 
            this.toolboxImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolboxImages.ImageStream")));
            this.toolboxImages.TransparentColor = System.Drawing.Color.Magenta;
            this.toolboxImages.Images.SetKeyName(0, "Label_684.png");
            this.toolboxImages.Images.SetKeyName(1, "Button_668.png");
            this.toolboxImages.Images.SetKeyName(2, "CheckBox_669.png");
            this.toolboxImages.Images.SetKeyName(3, "RadioButton_701.png");
            this.toolboxImages.Images.SetKeyName(4, "ComboBox_672.png");
            this.toolboxImages.Images.SetKeyName(5, "ListBox_686.png");
            this.toolboxImages.Images.SetKeyName(6, "CheckBoxList_727.png");
            this.toolboxImages.Images.SetKeyName(7, "DataGrid_674.png");
            this.toolboxImages.Images.SetKeyName(8, "ListView_687.png");
            this.toolboxImages.Images.SetKeyName(9, "SplitterControl_705.png");
            this.toolboxImages.Images.SetKeyName(10, "SplitContainerControl_704.png");
            this.toolboxImages.Images.SetKeyName(11, "Panel_694.png");
            this.toolboxImages.Images.SetKeyName(12, "TableLayoutPanel_6241.png");
            this.toolboxImages.Images.SetKeyName(13, "GroupBox_680.png");
            this.toolboxImages.Images.SetKeyName(14, "TabControl_707.png");
            this.toolboxImages.Images.SetKeyName(15, "LabelControl_DX.bmp");
            this.toolboxImages.Images.SetKeyName(16, "SimpleButton_DX.bmp");
            this.toolboxImages.Images.SetKeyName(17, "CheckButton_DX.bmp");
            this.toolboxImages.Images.SetKeyName(18, "ToggleSwitch_DX.bmp");
            this.toolboxImages.Images.SetKeyName(19, "CheckEdit_DX.bmp");
            this.toolboxImages.Images.SetKeyName(20, "RadioGroup_DX.bmp");
            this.toolboxImages.Images.SetKeyName(21, "TextEdit_DX.bmp");
            this.toolboxImages.Images.SetKeyName(22, "MemoEdit_DX.bmp");
            this.toolboxImages.Images.SetKeyName(23, "ButtonEdit_DX.bmp");
            this.toolboxImages.Images.SetKeyName(24, "SpinEdit_DX.bmp");
            this.toolboxImages.Images.SetKeyName(25, "CalcEdit_DX.bmp");
            this.toolboxImages.Images.SetKeyName(26, "ColorEdit_DX.bmp");
            this.toolboxImages.Images.SetKeyName(27, "DateControl_DX.bmp");
            this.toolboxImages.Images.SetKeyName(28, "DateEdit_DX.bmp");
            this.toolboxImages.Images.SetKeyName(29, "TimeEdit_DX.bmp");
            this.toolboxImages.Images.SetKeyName(30, "LookUpEdit_DX.bmp");
            this.toolboxImages.Images.SetKeyName(31, "ListBoxControl_DX.bmp");
            this.toolboxImages.Images.SetKeyName(32, "PictureEdit_DX.bmp");
            this.toolboxImages.Images.SetKeyName(33, "RangeControl_DX.bmp");
            this.toolboxImages.Images.SetKeyName(34, "XtraTabControl_DX.bmp");
            this.toolboxImages.Images.SetKeyName(35, "BarManager_DX.bmp");
            this.toolboxImages.Images.SetKeyName(36, "DocumentManager_DX.bmp");
            this.toolboxImages.Images.SetKeyName(37, "PopupMenu_DX.bmp");
            this.toolboxImages.Images.SetKeyName(38, "RadialMenu_DX.bmp");
            this.toolboxImages.Images.SetKeyName(39, "TileControl_DX.bmp");
            this.toolboxImages.Images.SetKeyName(40, "GridControl_DX.bmp");
            this.toolboxImages.Images.SetKeyName(41, "GridLookUpEdit_DX.bmp");
            this.toolboxImages.Images.SetKeyName(42, "PdfViewer_DX.bmp");
            this.toolboxImages.Images.SetKeyName(43, "ChartControl_DX.bmp");
            this.toolboxImages.Images.SetKeyName(44, "SpreadsheetControl_DX.bmp");
            this.toolboxImages.Images.SetKeyName(45, "SchedulerControl_DX.bmp");
            this.toolboxImages.Images.SetKeyName(46, "PivotGridControl_DX.bmp");
            this.toolboxImages.Images.SetKeyName(47, "MapControl_DX.bmp");
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.dockPanel3;
            this.panelContainer1.Controls.Add(this.dockPanel2);
            this.panelContainer1.Controls.Add(this.dockPanel3);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer1.FloatVertical = true;
            this.panelContainer1.ID = new System.Guid("8ab18f1a-d5df-4d58-9923-6f9814a9b400");
            this.panelContainer1.Location = new System.Drawing.Point(714, 53);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.Size = new System.Drawing.Size(200, 452);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dockPanel3
            // 
            this.dockPanel3.Controls.Add(this.dockPanel3_Container);
            this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel3.FloatVertical = true;
            this.dockPanel3.ID = new System.Guid("04633bdd-57dd-45b5-9dc8-8bf3ff5d3b72");
            this.dockPanel3.Location = new System.Drawing.Point(4, 23);
            this.dockPanel3.Name = "dockPanel3";
            this.dockPanel3.OriginalSize = new System.Drawing.Size(192, 385);
            this.dockPanel3.Size = new System.Drawing.Size(192, 398);
            this.dockPanel3.Text = "Properties";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(192, 398);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel2.ID = new System.Guid("3eee2e6e-9350-48cb-83a6-d2e00e875502");
            this.dockPanel2.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(192, 385);
            this.dockPanel2.Size = new System.Drawing.Size(192, 398);
            this.dockPanel2.Text = "Solution Explorer";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.ucSolutionExplorer1);
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(192, 398);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // ucSolutionExplorer1
            // 
            this.ucSolutionExplorer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSolutionExplorer1.Location = new System.Drawing.Point(0, 0);
            this.ucSolutionExplorer1.Name = "ucSolutionExplorer1";
            this.ucSolutionExplorer1.Size = new System.Drawing.Size(192, 398);
            this.ucSolutionExplorer1.TabIndex = 0;
            // 
            // dockPanel4
            // 
            this.dockPanel4.Controls.Add(this.dockPanel4_Container);
            this.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel4.ID = new System.Guid("9feb35bb-87cd-424f-81bc-9a242d36eb90");
            this.dockPanel4.Location = new System.Drawing.Point(200, 305);
            this.dockPanel4.Name = "dockPanel4";
            this.dockPanel4.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel4.Size = new System.Drawing.Size(514, 200);
            this.dockPanel4.Text = "Output";
            // 
            // dockPanel4_Container
            // 
            this.dockPanel4_Container.Controls.Add(this.ucOutput1);
            this.dockPanel4_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel4_Container.Name = "dockPanel4_Container";
            this.dockPanel4_Container.Size = new System.Drawing.Size(506, 173);
            this.dockPanel4_Container.TabIndex = 0;
            // 
            // ucOutput1
            // 
            this.ucOutput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOutput1.Location = new System.Drawing.Point(0, 0);
            this.ucOutput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucOutput1.Name = "ucOutput1";
            this.ucOutput1.Size = new System.Drawing.Size(506, 173);
            this.ucOutput1.TabIndex = 0;
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1});
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1,
            this.document2,
            this.document3});
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.document1,
            this.document2,
            this.document3});
            // 
            // document1
            // 
            this.document1.Caption = "File.cs";
            this.document1.ControlName = "document1";
            // 
            // document2
            // 
            this.document2.Caption = "ucToolBox.cs";
            this.document2.ControlName = "document2";
            // 
            // document3
            // 
            this.document3.Caption = "ucMain.cs";
            this.document3.ControlName = "document3";
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = combTransition1;
            // 
            // IDEWorkspaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dockPanel4);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "IDEWorkspaces";
            this.Size = new System.Drawing.Size(914, 528);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.dockPanel3.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.dockPanel4.ResumeLayout(false);
            this.dockPanel4_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraBars.Docking2010.DocumentManager documentManager1;
        private XtraBars.Docking.DockPanel panelContainer1;
        private XtraBars.Docking.DockPanel dockPanel2;
        private XtraBars.Docking.ControlContainer dockPanel2_Container;
        private XtraBars.Docking.DockPanel dockPanel3;
        private XtraBars.Docking.ControlContainer dockPanel3_Container;
        private XtraBars.Docking.DockPanel dockPanel1;
        private XtraBars.Docking.ControlContainer dockPanel1_Container;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarManager barManager1;
        private XtraBars.Bar bar1;
        private XtraBars.BarButtonItem barButtonItem5;
        private XtraBars.BarButtonItem barButtonItem6;
        private XtraBars.BarButtonItem barButtonItem7;
        private XtraBars.BarButtonItem barButtonItem8;
        private XtraBars.BarButtonItem barButtonItem9;
        private XtraBars.BarButtonItem barButtonItem10;
        private XtraBars.BarButtonItem barButtonItem11;
        private XtraBars.BarButtonItem barButtonItem12;
        private XtraBars.BarButtonItem barButtonItem13;
        private XtraBars.Bar bar2;
        private XtraBars.BarButtonItem barButtonItem1;
        private XtraBars.BarButtonItem barButtonItem2;
        private XtraBars.BarButtonItem barButtonItem3;
        private XtraBars.BarButtonItem barButtonItem4;
        private XtraBars.Bar bar3;
        private XtraBars.Docking.DockManager dockManager1;
        private XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private Utils.WorkspaceManager workspaceManager1;
        private System.Windows.Forms.ImageList toolboxImages;
        private XtraNavBar.NavBarControl navBarControl1;
        private ucSolutionExplorer ucSolutionExplorer1;
        private XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private XtraBars.Docking2010.Views.Tabbed.Document document1;
        private XtraBars.Docking2010.Views.Tabbed.Document document2;
        private XtraBars.Docking2010.Views.Tabbed.Document document3;
        private XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private XtraBars.Docking.DockPanel dockPanel4;
        private XtraBars.Docking.ControlContainer dockPanel4_Container;
        private ucOutput ucOutput1;
    }
}
