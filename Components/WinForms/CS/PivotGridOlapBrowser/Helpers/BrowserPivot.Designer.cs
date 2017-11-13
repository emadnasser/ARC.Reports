namespace PivotGridOlapBrowser {
    partial class BrowserPivot {
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.fieldListContainer = new DevExpress.XtraEditors.PanelControl();
            this.pivotGrid = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.lcgRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgPivotGrid = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPivotGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.lciFieldListContainer = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldListContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFieldListContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.fieldListContainer);
            this.layoutControl1.Controls.Add(this.pivotGrid);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.lcgRoot;
            this.layoutControl1.Size = new System.Drawing.Size(743, 415);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // fieldListContainer
            // 
            this.fieldListContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fieldListContainer.Location = new System.Drawing.Point(479, 2);
            this.fieldListContainer.Name = "fieldListContainer";
            this.fieldListContainer.Size = new System.Drawing.Size(262, 411);
            this.fieldListContainer.TabIndex = 12;
            // 
            // pivotGrid
            // 
            this.pivotGrid.Location = new System.Drawing.Point(2, 2);
            this.pivotGrid.Name = "pivotGrid";
            this.pivotGrid.OptionsCustomization.AllowFilterInCustomizationForm = true;
            this.pivotGrid.OptionsCustomization.AllowPrefilter = false;
            this.pivotGrid.OptionsCustomization.AllowSortInCustomizationForm = true;
            this.pivotGrid.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            this.pivotGrid.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.pivotGrid.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree;
            this.pivotGrid.OptionsView.ShowColumnHeaders = false;
            this.pivotGrid.OptionsView.ShowDataHeaders = false;
            this.pivotGrid.OptionsView.ShowFilterHeaders = false;
            this.pivotGrid.OptionsView.ShowRowHeaders = false;
            this.pivotGrid.OptionsView.ShowTotalsForSingleValues = true;
            this.pivotGrid.Size = new System.Drawing.Size(468, 411);
            this.pivotGrid.TabIndex = 11;
            this.pivotGrid.FieldValueNotExpanded += new DevExpress.XtraPivotGrid.PivotFieldValueEventHandler(this.pivotGrid_FieldValueNotExpanded);
            this.pivotGrid.FieldValueCollapsed += new DevExpress.XtraPivotGrid.PivotFieldValueEventHandler(this.pivotGrid_FieldValueCollapsed);
            this.pivotGrid.FieldValueExpanding += new DevExpress.XtraPivotGrid.PivotFieldValueCancelEventHandler(this.pivotGrid_FieldValueExpanding);
            this.pivotGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pivotGrid_MouseMove);
            this.pivotGrid.FieldValueExpanded += new DevExpress.XtraPivotGrid.PivotFieldValueEventHandler(this.pivotGrid_FieldValueExpanded);
            this.pivotGrid.FieldValueCollapsing += new DevExpress.XtraPivotGrid.PivotFieldValueCancelEventHandler(this.pivotGrid_FieldValueCollapsing);
            this.pivotGrid.BeginRefresh += new System.EventHandler(this.pivotGrid_BeginRefresh);
            this.pivotGrid.PopupMenuShowing += new DevExpress.XtraPivotGrid.PopupMenuShowingEventHandler(this.pivotGrid_ShowMenu);
            this.pivotGrid.EndRefresh += new System.EventHandler(this.pivotGrid_EndRefresh);
            // 
            // lcgRoot
            // 
            this.lcgRoot.CustomizationFormText = "Root";
            this.lcgRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgRoot.GroupBordersVisible = false;
            this.lcgRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgPivotGrid});
            this.lcgRoot.Location = new System.Drawing.Point(0, 0);
            this.lcgRoot.Name = "lcgRoot";
            this.lcgRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgRoot.Size = new System.Drawing.Size(743, 415);
            this.lcgRoot.Text = "lcgRoot";
            this.lcgRoot.TextVisible = false;
            // 
            // lcgPivotGrid
            // 
            this.lcgPivotGrid.CustomizationFormText = "Pivot Grid";
            this.lcgPivotGrid.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Horizontal;
            this.lcgPivotGrid.GroupBordersVisible = false;
            this.lcgPivotGrid.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPivotGrid,
            this.splitterItem1,
            this.lciFieldListContainer});
            this.lcgPivotGrid.Location = new System.Drawing.Point(0, 0);
            this.lcgPivotGrid.Name = "lcgPivotGrid";
            this.lcgPivotGrid.Size = new System.Drawing.Size(743, 415);
            this.lcgPivotGrid.Text = "Pivot Grid";
            // 
            // lciPivotGrid
            // 
            this.lciPivotGrid.Control = this.pivotGrid;
            this.lciPivotGrid.CustomizationFormText = "lciPivotGrid";
            this.lciPivotGrid.Location = new System.Drawing.Point(0, 0);
            this.lciPivotGrid.Name = "lciPivotGrid";
            this.lciPivotGrid.Size = new System.Drawing.Size(472, 415);
            this.lciPivotGrid.Text = "lciPivotGrid";
            this.lciPivotGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciPivotGrid.TextToControlDistance = 0;
            this.lciPivotGrid.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(472, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 415);
            // 
            // lciFieldListContainer
            // 
            this.lciFieldListContainer.Control = this.fieldListContainer;
            this.lciFieldListContainer.CustomizationFormText = "lciFieldListContainer";
            this.lciFieldListContainer.Location = new System.Drawing.Point(477, 0);
            this.lciFieldListContainer.Name = "lciFieldListContainer";
            this.lciFieldListContainer.Size = new System.Drawing.Size(266, 415);
            this.lciFieldListContainer.Text = "lciFieldListContainer";
            this.lciFieldListContainer.TextSize = new System.Drawing.Size(0, 0);
            this.lciFieldListContainer.TextToControlDistance = 0;
            this.lciFieldListContainer.TextVisible = false;
            // 
            // BrowserPivot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "BrowserPivot";
            this.Size = new System.Drawing.Size(743, 415);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fieldListContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPivotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPivotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFieldListContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgRoot;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGrid;
        private DevExpress.XtraEditors.PanelControl fieldListContainer;
        private DevExpress.XtraLayout.LayoutControlGroup lcgPivotGrid;
        private DevExpress.XtraLayout.LayoutControlItem lciPivotGrid;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciFieldListContainer;
    }
}
