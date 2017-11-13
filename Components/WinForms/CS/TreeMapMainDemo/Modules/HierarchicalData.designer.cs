namespace DevExpress.XtraTreeMap.Demos {
    partial class HierarchicalData {
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
            DevExpress.XtraTreeMap.TreeMapPaletteColorizer treeMapPaletteColorizer1 = new DevExpress.XtraTreeMap.TreeMapPaletteColorizer();
            DevExpress.XtraTreeMap.TreeMapHierarchicalDataAdapter treeMapHierarchicalDataAdapter1 = new DevExpress.XtraTreeMap.TreeMapHierarchicalDataAdapter();
            DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping treeMapHierarchicalDataMapping1 = new DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping();
            DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping treeMapHierarchicalDataMapping2 = new DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnWithoutGrouping = new DevExpress.XtraBars.BarCheckItem();
            this.btnGroupByResidence = new DevExpress.XtraBars.BarCheckItem();
            this.btnGroupByAge = new DevExpress.XtraBars.BarCheckItem();
            this.btnGroupByResidenceAndAge = new DevExpress.XtraBars.BarCheckItem();
            this.treeMapControl1 = new DevExpress.XtraTreeMap.TreeMapControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnWithoutGrouping,
            this.btnGroupByResidence,
            this.btnGroupByAge,
            this.btnGroupByResidenceAndAge});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(731, 47);
            // 
            // btnWithoutGrouping
            // 
            this.btnWithoutGrouping.Caption = "Without Grouping";
            this.btnWithoutGrouping.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.btnWithoutGrouping.GroupIndex = 1;
            this.btnWithoutGrouping.Id = 3;
            this.btnWithoutGrouping.Name = "btnWithoutGrouping";
            // 
            // btnGroupByResidence
            // 
            this.btnGroupByResidence.BindableChecked = true;
            this.btnGroupByResidence.Caption = "Group By Residence";
            this.btnGroupByResidence.Checked = true;
            this.btnGroupByResidence.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.btnGroupByResidence.GroupIndex = 1;
            this.btnGroupByResidence.Id = 5;
            this.btnGroupByResidence.Name = "btnGroupByResidence";
            // 
            // btnGroupByAge
            // 
            this.btnGroupByAge.Caption = "Group By Age Category";
            this.btnGroupByAge.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.btnGroupByAge.GroupIndex = 1;
            this.btnGroupByAge.Id = 6;
            this.btnGroupByAge.Name = "btnGroupByAge";
            // 
            // btnGroupByResidenceAndAge
            // 
            this.btnGroupByResidenceAndAge.Caption = "Group By Residence And Age Category";
            this.btnGroupByResidenceAndAge.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.btnGroupByResidenceAndAge.GroupIndex = 1;
            this.btnGroupByResidenceAndAge.Id = 7;
            this.btnGroupByResidenceAndAge.Name = "btnGroupByResidenceAndAge";
            // 
            // treeMapControl1
            // 
            this.treeMapControl1.BackColor = System.Drawing.Color.Transparent;
            this.treeMapControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            treeMapPaletteColorizer1.Palette = DevExpress.XtraTreeMap.Palette.Office2016Palette;
            this.treeMapControl1.Colorizer = treeMapPaletteColorizer1;
            treeMapHierarchicalDataMapping1.ChildrenDataMember = "EnergyStatistic";
            treeMapHierarchicalDataMapping1.LabelDataMember = "Country";
            treeMapHierarchicalDataMapping2.LabelDataMember = "TypeName";
            treeMapHierarchicalDataMapping2.ValueDataMember = "Value";
            treeMapHierarchicalDataAdapter1.Mappings.Add(treeMapHierarchicalDataMapping1);
            treeMapHierarchicalDataAdapter1.Mappings.Add(treeMapHierarchicalDataMapping2);
            this.treeMapControl1.DataAdapter = treeMapHierarchicalDataAdapter1;
            this.treeMapControl1.Location = new System.Drawing.Point(12, 35);
            this.treeMapControl1.Name = "treeMapControl1";
            this.treeMapControl1.Size = new System.Drawing.Size(707, 428);
            this.treeMapControl1.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.treeMapControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 47);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(731, 475);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(147, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(437, 19);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Energy Consumption in 2004 (millions of tons, oil equivalent)";
            this.labelControl1.UseMnemonic = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(731, 475);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.treeMapControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(711, 432);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.labelControl1;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(711, 23);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // HierarhicalData
            // 
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.MenuManager = this.ribbonControl1;
            this.Name = "HierarhicalData";
            this.Size = new System.Drawing.Size(731, 522);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private XtraBars.BarCheckItem btnWithoutGrouping;
        private XtraBars.BarCheckItem btnGroupByResidence;
        private XtraBars.BarCheckItem btnGroupByAge;
        private XtraBars.BarCheckItem btnGroupByResidenceAndAge;
        private TreeMapControl treeMapControl1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraEditors.LabelControl labelControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        
    }
}
