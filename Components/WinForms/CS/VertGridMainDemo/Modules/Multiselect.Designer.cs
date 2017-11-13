namespace DevExpress.XtraVerticalGrid.Demos {
    partial class Multiselect {
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbSelectSomeElements = new DevExpress.XtraEditors.SimpleButton();
            this.cheMultiselect = new DevExpress.XtraEditors.CheckEdit();
            this.lblMultiselectMode = new DevExpress.XtraEditors.LabelControl();
            this.cbMultiselectMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheMultiselect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMultiselectMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbSelectSomeElements);
            this.panelControl1.Controls.Add(this.cheMultiselect);
            this.panelControl1.Controls.Add(this.lblMultiselectMode);
            this.panelControl1.Controls.Add(this.cbMultiselectMode);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 75);
            this.panelControl1.TabIndex = 9;
            // 
            // sbSelectSomeElements
            // 
            this.sbSelectSomeElements.Location = new System.Drawing.Point(116, 12);
            this.sbSelectSomeElements.Name = "sbSelectSomeElements";
            this.sbSelectSomeElements.Size = new System.Drawing.Size(160, 23);
            this.sbSelectSomeElements.TabIndex = 13;
            this.sbSelectSomeElements.Text = "Select";
            this.sbSelectSomeElements.Click += new System.EventHandler(this.sbSelectSomeElementsClick);
            // 
            // cheMultiselect
            // 
            this.cheMultiselect.Location = new System.Drawing.Point(19, 14);
            this.cheMultiselect.Name = "cheMultiselect";
            this.cheMultiselect.Properties.AutoWidth = true;
            this.cheMultiselect.Properties.Caption = "Multi-Select";
            this.cheMultiselect.Size = new System.Drawing.Size(77, 19);
            this.cheMultiselect.TabIndex = 12;
            this.cheMultiselect.CheckedChanged += new System.EventHandler(this.cheMultiselectCheckedChanged);
            // 
            // lblMultiselectMode
            // 
            this.lblMultiselectMode.Location = new System.Drawing.Point(19, 47);
            this.lblMultiselectMode.Name = "lblMultiselectMode";
            this.lblMultiselectMode.Size = new System.Drawing.Size(88, 13);
            this.lblMultiselectMode.TabIndex = 5;
            this.lblMultiselectMode.Text = "Multi-Select Mode:";
            // 
            // cbMultiselectMode
            // 
            this.cbMultiselectMode.Location = new System.Drawing.Point(116, 44);
            this.cbMultiselectMode.Name = "cbMultiselectMode";
            this.cbMultiselectMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMultiselectMode.Size = new System.Drawing.Size(160, 20);
            this.cbMultiselectMode.TabIndex = 4;
            this.cbMultiselectMode.SelectedIndexChanged += new System.EventHandler(this.cbMultiselectModeSelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 75);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(784, 8);
            this.panelControl2.TabIndex = 10;
            // 
            // vGridControl1
            // 
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.Location = new System.Drawing.Point(0, 83);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.OptionsMenu.EnableContextMenu = true;
            this.vGridControl1.OptionsView.MinRowAutoHeight = 20;
            this.vGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.vGridControl1.Size = new System.Drawing.Size(784, 349);
            this.vGridControl1.TabIndex = 11;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")});
            this.repositoryItemLookUpEdit1.DisplayMember = "ProductName";
            this.repositoryItemLookUpEdit1.DropDownRows = 10;
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.PopupWidth = 220;
            this.repositoryItemLookUpEdit1.ValueMember = "ProductID";
            // 
            // Multiselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Multiselect";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheMultiselect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMultiselectMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.PanelControl panelControl1;
        private XtraEditors.PanelControl panelControl2;
        private VGridControl vGridControl1;
        private XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private XtraEditors.LabelControl lblMultiselectMode;
        private XtraEditors.CheckEdit cheMultiselect;
        private XtraEditors.ImageComboBoxEdit cbMultiselectMode;
        private XtraEditors.SimpleButton sbSelectSomeElements;
    }
}
