namespace DevExpress.XtraGrid.Demos.Tutorials {
    partial class GridRowFilterEvent {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.ceRegion = new DevExpress.XtraEditors.CheckEdit();
            this.ceHideEvenRows = new DevExpress.XtraEditors.CheckEdit();
            this.ceHideOddRows = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHideEvenRows.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHideOddRows.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 92);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(683, 274);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gridView1_CustomRowFilter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ceRegion);
            this.panel1.Controls.Add(this.ceHideEvenRows);
            this.panel1.Controls.Add(this.ceHideOddRows);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 84);
            this.panel1.TabIndex = 5;
            // 
            // ceRegion
            // 
            this.ceRegion.Location = new System.Drawing.Point(12, 54);
            this.ceRegion.Name = "ceRegion";
            this.ceRegion.Properties.Caption = "Hide Rows if the Region Value is NULL";
            this.ceRegion.Size = new System.Drawing.Size(456, 19);
            this.ceRegion.TabIndex = 3;
            this.ceRegion.CheckedChanged += new System.EventHandler(this.ceEditors__CheckedChanged);
            // 
            // ceHideEvenRows
            // 
            this.ceHideEvenRows.Location = new System.Drawing.Point(12, 34);
            this.ceHideEvenRows.Name = "ceHideEvenRows";
            this.ceHideEvenRows.Properties.Caption = "Hide Even Rows";
            this.ceHideEvenRows.Size = new System.Drawing.Size(184, 19);
            this.ceHideEvenRows.TabIndex = 2;
            this.ceHideEvenRows.CheckedChanged += new System.EventHandler(this.ceEditors__CheckedChanged);
            // 
            // ceHideOddRows
            // 
            this.ceHideOddRows.EditValue = true;
            this.ceHideOddRows.Location = new System.Drawing.Point(12, 12);
            this.ceHideOddRows.Name = "ceHideOddRows";
            this.ceHideOddRows.Properties.Caption = "Hide Odd Rows";
            this.ceHideOddRows.Size = new System.Drawing.Size(184, 19);
            this.ceHideOddRows.TabIndex = 1;
            this.ceHideOddRows.CheckedChanged += new System.EventHandler(this.ceEditors__CheckedChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 84);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(683, 8);
            this.panelControl1.TabIndex = 9;
            // 
            // GridRowFilterEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.Name = "GridRowFilterEvent";
            this.Size = new System.Drawing.Size(683, 366);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.GridRowFilterEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHideEvenRows.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHideOddRows.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.CheckEdit ceHideOddRows;
        private DevExpress.XtraEditors.CheckEdit ceHideEvenRows;
        private DevExpress.XtraEditors.CheckEdit ceRegion;
        private System.ComponentModel.Container components = null;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
