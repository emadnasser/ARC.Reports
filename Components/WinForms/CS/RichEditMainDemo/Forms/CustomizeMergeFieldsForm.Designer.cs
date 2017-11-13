namespace DevExpress.XtraRichEdit.Demos.Forms {
    partial class CustomizeMergeFieldsForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.pcMain = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.horzSplitter1 = new DevExpress.XtraEditors.PanelControl();
            this.gcDescription = new DevExpress.XtraEditors.GroupControl();
            this.pnlHint = new DevExpress.Utils.Frames.NotePanel8_1();
            this.horzSplitter2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.pcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horzSplitter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDescription)).BeginInit();
            this.gcDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horzSplitter2)).BeginInit();
            this.horzSplitter2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(312, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pcMain
            // 
            this.pcMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcMain.Controls.Add(this.gridControl1);
            this.pcMain.Controls.Add(this.horzSplitter1);
            this.pcMain.Controls.Add(this.gcDescription);
            this.pcMain.Controls.Add(this.horzSplitter2);
            this.pcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcMain.Location = new System.Drawing.Point(0, 0);
            this.pcMain.Name = "pcMain";
            this.pcMain.Padding = new System.Windows.Forms.Padding(8);
            this.pcMain.Size = new System.Drawing.Size(403, 376);
            this.pcMain.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(8, 8);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(387, 284);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Can show";
            this.gridColumn1.FieldName = "CanShow";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 65;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Data field name (readonly)";
            this.gridColumn2.FieldName = "FieldName.Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 154;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Display name";
            this.gridColumn3.FieldName = "FieldName.DisplayName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowMove = false;
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 166;
            // 
            // horzSplitter1
            // 
            this.horzSplitter1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.horzSplitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horzSplitter1.Location = new System.Drawing.Point(8, 292);
            this.horzSplitter1.Name = "horzSplitter1";
            this.horzSplitter1.Size = new System.Drawing.Size(387, 6);
            this.horzSplitter1.TabIndex = 0;
            // 
            // gcDescription
            // 
            this.gcDescription.Controls.Add(this.pnlHint);
            this.gcDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcDescription.Location = new System.Drawing.Point(8, 298);
            this.gcDescription.Name = "gcDescription";
            this.gcDescription.ShowCaption = false;
            this.gcDescription.Size = new System.Drawing.Size(387, 37);
            this.gcDescription.TabIndex = 3;
            this.gcDescription.Text = "Description:";
            // 
            // pnlHint
            // 
            this.pnlHint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHint.Location = new System.Drawing.Point(2, 0);
            this.pnlHint.MaxRows = 5;
            this.pnlHint.Name = "pnlHint";
            this.pnlHint.ParentAutoHeight = true;
            this.pnlHint.Size = new System.Drawing.Size(383, 35);
            this.pnlHint.TabIndex = 0;
            this.pnlHint.TabStop = false;
            this.pnlHint.Text = "Change display names to make them more descriptive.\nUncheck the boxes next to the" +
                " unneeded fields to hide them.";
            // 
            // horzSplitter2
            // 
            this.horzSplitter2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.horzSplitter2.Controls.Add(this.btnOk);
            this.horzSplitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horzSplitter2.Location = new System.Drawing.Point(8, 335);
            this.horzSplitter2.Name = "horzSplitter2";
            this.horzSplitter2.Size = new System.Drawing.Size(387, 33);
            this.horzSplitter2.TabIndex = 0;
            // 
            // CustomizeMergeFieldsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 376);
            this.Controls.Add(this.pcMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "CustomizeMergeFieldsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customize merge fields";
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.pcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horzSplitter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDescription)).EndInit();
            this.gcDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.horzSplitter2)).EndInit();
            this.horzSplitter2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOk;
        protected DevExpress.XtraEditors.PanelControl pcMain;
        public DevExpress.XtraEditors.GroupControl gcDescription;
        public DevExpress.Utils.Frames.NotePanel8_1 pnlHint;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        public DevExpress.XtraEditors.PanelControl horzSplitter1;
        public DevExpress.XtraEditors.PanelControl horzSplitter2;
    }
}
