using DevExpress.XtraEditors;
namespace DevExpress.XtraTreeList.Demos.Tutorials {
    partial class MultiSelect {
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.lbSelectedRowsCount = new DevExpress.XtraEditors.LabelControl();
            this.cbMultiSelect = new DevExpress.XtraEditors.CheckEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new DevExpress.XtraEditors.PanelControl();
            this.lbSelectedRows = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMultiSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 50);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(553, 206);
            this.treeList1.TabIndex = 6;
            this.treeList1.SelectionChanged += new System.EventHandler(this.treeList1_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbSelectedRowsCount);
            this.panel2.Controls.Add(this.cbMultiSelect);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 42);
            this.panel2.TabIndex = 7;
            // 
            // lbSelectedRowsCount
            // 
            this.lbSelectedRowsCount.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbSelectedRowsCount.Appearance.Options.UseBackColor = true;
            this.lbSelectedRowsCount.Appearance.Options.UseTextOptions = true;
            this.lbSelectedRowsCount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbSelectedRowsCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbSelectedRowsCount.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbSelectedRowsCount.Location = new System.Drawing.Point(242, 11);
            this.lbSelectedRowsCount.Name = "lbSelectedRowsCount";
            this.lbSelectedRowsCount.Padding = new System.Windows.Forms.Padding(2);
            this.lbSelectedRowsCount.Size = new System.Drawing.Size(48, 18);
            this.lbSelectedRowsCount.TabIndex = 4;
            // 
            // cbMultiSelect
            // 
            this.cbMultiSelect.Location = new System.Drawing.Point(10, 12);
            this.cbMultiSelect.Name = "cbMultiSelect";
            this.cbMultiSelect.Properties.Caption = "Multi Select";
            this.cbMultiSelect.Size = new System.Drawing.Size(100, 18);
            this.cbMultiSelect.TabIndex = 3;
            this.cbMultiSelect.CheckedChanged += new System.EventHandler(this.cbMultiSelect_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(126, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selected Nodes Count:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbSelectedRows);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 36);
            this.panel3.TabIndex = 8;
            // 
            // lbSelectedRows
            // 
            this.lbSelectedRows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSelectedRows.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbSelectedRows.Appearance.Options.UseBackColor = true;
            this.lbSelectedRows.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbSelectedRows.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbSelectedRows.Location = new System.Drawing.Point(96, 9);
            this.lbSelectedRows.Name = "lbSelectedRows";
            this.lbSelectedRows.Padding = new System.Windows.Forms.Padding(2);
            this.lbSelectedRows.Size = new System.Drawing.Size(451, 18);
            this.lbSelectedRows.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selected Nodes:";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 42);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(553, 8);
            this.panelControl1.TabIndex = 9;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 256);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(553, 8);
            this.panelControl2.TabIndex = 10;
            // 
            // MultiSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "MultiSelect";
            this.Size = new System.Drawing.Size(553, 300);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMultiSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList treeList1;
        private PanelControl panel2;
        private DevExpress.XtraEditors.LabelControl lbSelectedRowsCount;
        private DevExpress.XtraEditors.CheckEdit cbMultiSelect;
        private DevExpress.XtraEditors.LabelControl label3;
        private PanelControl panel3;
        private DevExpress.XtraEditors.LabelControl lbSelectedRows;
        private DevExpress.XtraEditors.LabelControl label4;
        private System.ComponentModel.Container components = null;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;

    }
}
