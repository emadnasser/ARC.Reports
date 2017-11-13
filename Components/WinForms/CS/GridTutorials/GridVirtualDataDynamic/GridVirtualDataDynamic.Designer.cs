namespace DevExpress.XtraGrid.Demos.Tutorials {
    partial class GridVirtualDataDynamic {
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
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.checkEditAddColumns = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditAddRows = new DevExpress.XtraEditors.CheckEdit();
            this.lbListDimension = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAddColumns.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAddRows.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkEditAddColumns);
            this.panel1.Controls.Add(this.checkEditAddRows);
            this.panel1.Controls.Add(this.lbListDimension);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 40);
            this.panel1.TabIndex = 3;
            // 
            // checkEditAddColumns
            // 
            this.checkEditAddColumns.EditValue = true;
            this.checkEditAddColumns.Location = new System.Drawing.Point(174, 12);
            this.checkEditAddColumns.Name = "checkEditAddColumns";
            this.checkEditAddColumns.Properties.Caption = "Dynamic column adding";
            this.checkEditAddColumns.Size = new System.Drawing.Size(156, 18);
            this.checkEditAddColumns.TabIndex = 5;
            // 
            // checkEditAddRows
            // 
            this.checkEditAddRows.EditValue = true;
            this.checkEditAddRows.Location = new System.Drawing.Point(12, 12);
            this.checkEditAddRows.Name = "checkEditAddRows";
            this.checkEditAddRows.Properties.Caption = "Dynamic row adding";
            this.checkEditAddRows.Size = new System.Drawing.Size(156, 18);
            this.checkEditAddRows.TabIndex = 4;
            this.checkEditAddRows.CheckedChanged += new System.EventHandler(this.checkEditAddRows_CheckedChanged);
            // 
            // lbListDimension
            // 
            this.lbListDimension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbListDimension.Appearance.Options.UseTextOptions = true;
            this.lbListDimension.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbListDimension.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbListDimension.Location = new System.Drawing.Point(360, 10);
            this.lbListDimension.Name = "lbListDimension";
            this.lbListDimension.Size = new System.Drawing.Size(209, 20);
            this.lbListDimension.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(590, 318);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gridView1_FocusedColumnChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(590, 8);
            this.panelControl1.TabIndex = 9;
            // 
            // GridVirtualDataDynamic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.Name = "GridVirtualDataDynamic";
            this.Size = new System.Drawing.Size(590, 366);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.GridVirtualDataDynamic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAddColumns.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAddRows.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lbListDimension;
        private DevExpress.XtraEditors.CheckEdit checkEditAddRows;
        private DevExpress.XtraEditors.CheckEdit checkEditAddColumns;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
