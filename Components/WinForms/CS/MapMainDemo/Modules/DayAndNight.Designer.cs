namespace DevExpress.XtraMap.Demos {
    partial class DayAndNight {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            DevExpress.XtraMap.MapCustomElement mapCustomElement1 = new DevExpress.XtraMap.MapCustomElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayAndNight));
            DevExpress.XtraMap.MapPolygon mapPolygon1 = new DevExpress.XtraMap.MapPolygon();
            DevExpress.XtraMap.MapCustomElement mapCustomElement2 = new DevExpress.XtraMap.MapCustomElement();
            this.FileLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.ShapefileDataAdapter = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.ItemsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.Data = new DevExpress.XtraMap.MapItemStorage();
            this.btnCurrent = new DevExpress.XtraBars.BarButtonItem();
            this.barEditCalendar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.chkSteadily = new DevExpress.XtraBars.BarCheckItem();
            this.btnMinus = new DevExpress.XtraBars.BarButtonItem();
            this.btnPlus = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.rpgInteractivity = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgDateTime = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.chkPlay = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileLayer
            // 
            this.FileLayer.Data = this.ShapefileDataAdapter;
            this.FileLayer.EnableHighlighting = false;
            this.FileLayer.EnableSelection = false;
            this.FileLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(211)))), ((int)(((byte)(236)))));
            this.FileLayer.ItemStyle.StrokeWidth = 0;
            this.FileLayer.Name = "FileLayer";
            this.FileLayer.ShapeTitlesPattern = "";
            this.FileLayer.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.DayAndNight_DataLoaded);
            // 
            // ItemsLayer
            // 
            this.ItemsLayer.Data = this.Data;
            this.ItemsLayer.EnableHighlighting = false;
            this.ItemsLayer.EnableSelection = false;
            this.ItemsLayer.Name = "ItemsLayer";
            // 
            // Data
            // 
            mapCustomElement1.Image = ((System.Drawing.Image)(resources.GetObject("mapCustomElement1.Image")));
            mapCustomElement1.UseAnimation = false;
            mapPolygon1.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            mapPolygon1.StrokeWidth = 0;
            mapCustomElement2.Image = ((System.Drawing.Image)(resources.GetObject("mapCustomElement2.Image")));
            mapCustomElement2.UseAnimation = false;
            this.Data.Items.Add(mapCustomElement1);
            this.Data.Items.Add(mapPolygon1);
            this.Data.Items.Add(mapCustomElement2);
            // 
            // btnCurrent
            // 
            this.btnCurrent.Caption = "Current Time";
            this.btnCurrent.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnCurrent.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCurrent.Glyph")));
            this.btnCurrent.Id = 6;
            this.btnCurrent.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCurrent.LargeGlyph")));
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCurrent_ItemClick);
            // 
            // barEditItem2
            // 
            this.barEditCalendar.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barEditCalendar.Edit = this.repositoryItemDateEdit1;
            this.barEditCalendar.EditWidth = 150;
            this.barEditCalendar.Id = 24;
            this.barEditCalendar.Name = "barEditCalendar";
            this.barEditCalendar.EditValueChanged += new System.EventHandler(this.barEditItem2_EditValueChanged);
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.EditMask = "G";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // chkSteadily
            // 
            this.chkSteadily.Caption = "Steadily";
            this.chkSteadily.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.chkSteadily.Glyph = ((System.Drawing.Image)(resources.GetObject("chkSteadily.Glyph")));
            this.chkSteadily.Id = 30;
            this.chkSteadily.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkSteadily.LargeGlyph")));
            this.chkSteadily.Name = "chkSteadily";
            this.chkSteadily.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkSteadily_CheckedChanged);
            // 
            // btnMinus
            // 
            this.btnMinus.Caption = "Backward";
            this.btnMinus.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnMinus.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMinus.Glyph")));
            this.btnMinus.Id = 31;
            this.btnMinus.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMinus.LargeGlyph")));
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMinus_ItemClick);
            // 
            // btnPlus
            // 
            this.btnPlus.Caption = "Forward";
            this.btnPlus.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnPlus.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPlus.Glyph")));
            this.btnPlus.Id = 32;
            this.btnPlus.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPlus.LargeGlyph")));
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPlus_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Custom Time";
            this.barStaticItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barStaticItem1.Id = 46;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPageGroup2
            // 
            this.rpgInteractivity.ItemLinks.Add(this.chkSteadily);
            this.rpgInteractivity.ItemLinks.Add(this.btnMinus);
            this.rpgInteractivity.ItemLinks.Add(this.btnPlus);
            this.rpgInteractivity.Name = "ribbonPageGroup2";
            this.rpgInteractivity.Text = "Interactivity";
            // 
            // ribbonPageGroup1
            // 
            this.rpgDateTime.ItemLinks.Add(this.barEditCalendar);
            this.rpgDateTime.ItemLinks.Add(this.btnCurrent);
            this.rpgDateTime.Name = "ribbonPageGroup1";
            this.rpgDateTime.Text = "Set Date and Time";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.DropDownRows = 10;
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Spherical Mercator",
            "Equal Area",
            "Equirectangular",
            "Elliptical Mercator",
            "Miller",
            "Equidistant",
            "Lambert Cylindrical Equal Area",
            "Braun Stereographic",
            "Kavrayskiy",
            "Sinusoidal"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemTrackBar1
            // 
            this.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = true;
            this.repositoryItemTrackBar1.LargeChange = 24;
            this.repositoryItemTrackBar1.Maximum = 8760;
            this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(25, "25")});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            "1",
            "25"});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Items.AddRange(new object[] {
            "1",
            "25"});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            this.repositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // chkPlay
            // 
            this.chkPlay.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.chkPlay.Id = 9;
            this.chkPlay.Name = "chkPlay";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "-1";
            this.barButtonItem1.Id = -1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "+1";
            this.barButtonItem2.Id = -1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 141);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.mapControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(500, 359);
            this.splitContainerControl1.SplitterPosition = 166;
            this.splitContainerControl1.TabIndex = 6;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // mapControl1
            // 
            this.mapControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.EnableZooming = false;
            this.mapControl1.Layers.Add(this.FileLayer);
            this.mapControl1.Layers.Add(this.ItemsLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.ShowZoomTrackbar = false;
            this.mapControl1.Size = new System.Drawing.Size(329, 359);
            this.mapControl1.TabIndex = 5;
            this.mapControl1.ZoomLevel = 1.8059329233548773D;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.listBoxControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(166, 359);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Projection";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl1.Items.AddRange(new object[] {
            "Spherical Mercator",
            "Equal Area",
            "Equirectangular",
            "Elliptical Mercator",
            "Miller",
            "Equidistant",
            "Lambert Cylindrical Equal Area",
            "Braun Stereographic",
            "Kavrayskiy",
            "Sinusoidal",
            "EPSG:4326"});
            this.listBoxControl1.Location = new System.Drawing.Point(2, 20);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(162, 337);
            this.listBoxControl1.TabIndex = 0;
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // DayAndNight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "DayAndNight";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
        private XtraBars.Ribbon.RibbonPageGroup rpgInteractivity;
        private XtraBars.BarButtonItem btnCurrent;
        private XtraBars.BarCheckItem chkPlay;
        private XtraBars.BarButtonItem barButtonItem1;
        private XtraBars.BarButtonItem barButtonItem2;
        private XtraBars.BarEditItem barEditCalendar;
        private XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private XtraBars.BarCheckItem chkSteadily;
        private XtraBars.BarButtonItem btnMinus;
        private XtraBars.BarButtonItem btnPlus;
        private XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private XtraEditors.SplitContainerControl splitContainerControl1;
        private MapControl mapControl1;
        private XtraEditors.ListBoxControl listBoxControl1;
        private XtraBars.Ribbon.RibbonPageGroup rpgDateTime;
        private XtraBars.BarStaticItem barStaticItem1;
        private XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Timer timer;
        private VectorItemsLayer FileLayer;
        private ShapefileDataAdapter ShapefileDataAdapter;
        private VectorItemsLayer ItemsLayer;
        private MapItemStorage Data;
    }
}
