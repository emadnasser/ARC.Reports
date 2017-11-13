namespace DevExpress.XtraVerticalGrid.Demos {
    partial class FindPanel {
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cheShowClearButton = new DevExpress.XtraEditors.CheckEdit();
            this.cheShowCloseButton = new DevExpress.XtraEditors.CheckEdit();
            this.cheShowFindButton = new DevExpress.XtraEditors.CheckEdit();
            this.cheClearFindOnClose = new DevExpress.XtraEditors.CheckEdit();
            this.cheHighlightFindResults = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbFindDelay = new DevExpress.XtraEditors.SpinEdit();
            this.cbVisibility = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbFindMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbFindFilterColumns = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheShowClearButton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheShowCloseButton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheShowFindButton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheClearFindOnClose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheHighlightFindResults.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFindDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVisibility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFindMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFindFilterColumns.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cheShowClearButton);
            this.panelControl1.Controls.Add(this.cheShowCloseButton);
            this.panelControl1.Controls.Add(this.cheShowFindButton);
            this.panelControl1.Controls.Add(this.cheClearFindOnClose);
            this.panelControl1.Controls.Add(this.cheHighlightFindResults);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbFindDelay);
            this.panelControl1.Controls.Add(this.cbVisibility);
            this.panelControl1.Controls.Add(this.cbFindMode);
            this.panelControl1.Controls.Add(this.cbFindFilterColumns);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 96);
            this.panelControl1.TabIndex = 9;
            // 
            // cheShowClearButton
            // 
            this.cheShowClearButton.Location = new System.Drawing.Point(342, 39);
            this.cheShowClearButton.Name = "cheShowClearButton";
            this.cheShowClearButton.Properties.AutoWidth = true;
            this.cheShowClearButton.Properties.Caption = "Show Clear Button";
            this.cheShowClearButton.Size = new System.Drawing.Size(111, 19);
            this.cheShowClearButton.TabIndex = 16;
            this.cheShowClearButton.CheckedChanged += new System.EventHandler(this.cheShowClearButton_CheckedChanged);
            // 
            // cheShowCloseButton
            // 
            this.cheShowCloseButton.Location = new System.Drawing.Point(342, 13);
            this.cheShowCloseButton.Name = "cheShowCloseButton";
            this.cheShowCloseButton.Properties.AutoWidth = true;
            this.cheShowCloseButton.Properties.Caption = "Show Close Button";
            this.cheShowCloseButton.Size = new System.Drawing.Size(112, 19);
            this.cheShowCloseButton.TabIndex = 15;
            this.cheShowCloseButton.CheckedChanged += new System.EventHandler(this.cheShowCloseButton_CheckedChanged);
            // 
            // cheShowFindButton
            // 
            this.cheShowFindButton.Location = new System.Drawing.Point(342, 65);
            this.cheShowFindButton.Name = "cheShowFindButton";
            this.cheShowFindButton.Properties.AutoWidth = true;
            this.cheShowFindButton.Properties.Caption = "Show Find Button";
            this.cheShowFindButton.Size = new System.Drawing.Size(106, 19);
            this.cheShowFindButton.TabIndex = 14;
            this.cheShowFindButton.CheckedChanged += new System.EventHandler(this.cheShowFindButton_CheckedChanged);
            // 
            // cheClearFindOnClose
            // 
            this.cheClearFindOnClose.Location = new System.Drawing.Point(15, 65);
            this.cheClearFindOnClose.Name = "cheClearFindOnClose";
            this.cheClearFindOnClose.Properties.AutoWidth = true;
            this.cheClearFindOnClose.Properties.Caption = "Clear Find On Close";
            this.cheClearFindOnClose.Size = new System.Drawing.Size(116, 19);
            this.cheClearFindOnClose.TabIndex = 13;
            this.cheClearFindOnClose.CheckedChanged += new System.EventHandler(this.cheClearFindOnClose_CheckedChanged);
            // 
            // cheHighlightFindResults
            // 
            this.cheHighlightFindResults.Location = new System.Drawing.Point(15, 39);
            this.cheHighlightFindResults.Name = "cheHighlightFindResults";
            this.cheHighlightFindResults.Properties.AutoWidth = true;
            this.cheHighlightFindResults.Properties.Caption = "Highlight Find Results";
            this.cheHighlightFindResults.Size = new System.Drawing.Size(124, 19);
            this.cheHighlightFindResults.TabIndex = 12;
            this.cheHighlightFindResults.CheckedChanged += new System.EventHandler(this.cheHighlightFindResults_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(516, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Find Filter Columns:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(516, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Find Mode:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(516, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Find Delay:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Find Panel Visibility:";
            // 
            // cbFindDelay
            // 
            this.cbFindDelay.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cbFindDelay.Location = new System.Drawing.Point(617, 13);
            this.cbFindDelay.Name = "cbFindDelay";
            this.cbFindDelay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFindDelay.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.cbFindDelay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.cbFindDelay.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cbFindDelay.Properties.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cbFindDelay.Size = new System.Drawing.Size(149, 20);
            this.cbFindDelay.TabIndex = 6;
            this.cbFindDelay.EditValueChanged += new System.EventHandler(this.cbFindDelay_EditValueChanged);
            // 
            // cbVisibility
            // 
            this.cbVisibility.Location = new System.Drawing.Point(148, 13);
            this.cbVisibility.Name = "cbVisibility";
            this.cbVisibility.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVisibility.Size = new System.Drawing.Size(149, 20);
            this.cbVisibility.TabIndex = 4;
            this.cbVisibility.EditValueChanged += new System.EventHandler(this.cbVisibility_EditValueChanged);
            // 
            // cbFindMode
            // 
            this.cbFindMode.Location = new System.Drawing.Point(617, 65);
            this.cbFindMode.Name = "cbFindMode";
            this.cbFindMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFindMode.Size = new System.Drawing.Size(149, 20);
            this.cbFindMode.TabIndex = 8;
            this.cbFindMode.EditValueChanged += new System.EventHandler(this.cbFindMode_EditValueChanged);
            // 
            // cbFindFilterColumns
            // 
            this.cbFindFilterColumns.Location = new System.Drawing.Point(617, 39);
            this.cbFindFilterColumns.Name = "cbFindFilterColumns";
            this.cbFindFilterColumns.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFindFilterColumns.Size = new System.Drawing.Size(149, 20);
            this.cbFindFilterColumns.TabIndex = 10;
            this.cbFindFilterColumns.EditValueChanged += new System.EventHandler(this.cbFindFilterColumns_EditValueChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 96);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(784, 8);
            this.panelControl2.TabIndex = 10;
            // 
            // vGridControl1
            // 
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.FindPanelVisible = true;
            this.vGridControl1.Location = new System.Drawing.Point(0, 104);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.OptionsMenu.EnableContextMenu = true;
            this.vGridControl1.OptionsView.MinRowAutoHeight = 20;
            this.vGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.vGridControl1.Size = new System.Drawing.Size(784, 328);
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
            // FindPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FindPanel";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheShowClearButton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheShowCloseButton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheShowFindButton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheClearFindOnClose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheHighlightFindResults.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFindDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVisibility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFindMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFindFilterColumns.Properties)).EndInit();
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
        private XtraEditors.LabelControl labelControl4;
        private XtraEditors.LabelControl labelControl3;
        private XtraEditors.LabelControl labelControl2;
        private XtraEditors.LabelControl labelControl1;
        private XtraEditors.CheckEdit cheShowClearButton;
        private XtraEditors.CheckEdit cheShowCloseButton;
        private XtraEditors.CheckEdit cheShowFindButton;
        private XtraEditors.CheckEdit cheClearFindOnClose;
        private XtraEditors.CheckEdit cheHighlightFindResults;
        private XtraEditors.SpinEdit cbFindDelay;
        private XtraEditors.ImageComboBoxEdit cbVisibility;
        private XtraEditors.ImageComboBoxEdit cbFindMode;
        private XtraEditors.CheckedComboBoxEdit cbFindFilterColumns;
    }
}
