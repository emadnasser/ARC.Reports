namespace DevExpress.XtraVerticalGrid.Demos {
    partial class Formats {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formats));
            this.tabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.tcProperties = new DevExpress.XtraTab.XtraTabControl();
            this.tabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.lsStyles = new DevExpress.XtraEditors.ListBoxControl();
            this.ceNewStyles = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage10 = new DevExpress.XtraTab.XtraTabPage();
            this.propertyGrid1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.repositoryItemColorEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
            this.splitter4 = new DevExpress.XtraEditors.SplitterControl();
            this.lbcAppearances = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcProperties)).BeginInit();
            this.tcProperties.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsStyles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceNewStyles.Properties)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcAppearances)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlLeft.Controls.Add(this.tcProperties);
            this.pnlLeft.Controls.SetChildIndex(this.tcProperties, 0);
            // 
            // tabPage5
            // 
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(589, 458);
            this.tabPage5.Text = "Simple Mode";
            // 
            // tcProperties
            // 
            this.tcProperties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tcProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProperties.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.tcProperties.Location = new System.Drawing.Point(0, 0);
            this.tcProperties.Name = "tcProperties";
            this.tcProperties.SelectedTabPage = this.tabPage6;
            this.tcProperties.Size = new System.Drawing.Size(204, 400);
            this.tcProperties.TabIndex = 3;
            this.tcProperties.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPage6,
            this.tabPage10});
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lsStyles);
            this.tabPage6.Controls.Add(this.ceNewStyles);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.Size = new System.Drawing.Size(173, 391);
            this.tabPage6.Text = "Formats";
            // 
            // lsStyles
            // 
            this.lsStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsStyles.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lsStyles.ItemHeight = 15;
            this.lsStyles.Location = new System.Drawing.Point(4, 43);
            this.lsStyles.Name = "lsStyles";
            this.lsStyles.Size = new System.Drawing.Size(165, 344);
            this.lsStyles.TabIndex = 10;
            this.lsStyles.SelectedIndexChanged += new System.EventHandler(this.lsStyles_SelectedIndexChanged);
            // 
            // ceNewStyles
            // 
            this.ceNewStyles.Dock = System.Windows.Forms.DockStyle.Top;
            this.ceNewStyles.Location = new System.Drawing.Point(4, 24);
            this.ceNewStyles.Name = "ceNewStyles";
            this.ceNewStyles.Properties.Caption = "Only New Styles";
            this.ceNewStyles.Size = new System.Drawing.Size(165, 19);
            this.ceNewStyles.TabIndex = 26;
            this.ceNewStyles.CheckedChanged += new System.EventHandler(this.ceNewStyles_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Style Formats:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.propertyGrid1);
            this.tabPage10.Controls.Add(this.splitter4);
            this.tabPage10.Controls.Add(this.lbcAppearances);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage10.Size = new System.Drawing.Size(169, 387);
            this.tabPage10.Text = "Appearances";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.DefaultEditors.AddRange(new DevExpress.XtraVerticalGrid.Rows.DefaultEditor[] {
            new DevExpress.XtraVerticalGrid.Rows.DefaultEditor(typeof(System.Drawing.Color), this.repositoryItemColorEdit1)});
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(4, 186);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.OptionsView.ShowRootCategories = false;
            this.propertyGrid1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemColorEdit1});
            this.propertyGrid1.ServiceProvider = null;
            this.propertyGrid1.Size = new System.Drawing.Size(161, 197);
            this.propertyGrid1.TabIndex = 28;
            // 
            // repositoryItemColorEdit1
            // 
            this.repositoryItemColorEdit1.AutoHeight = false;
            this.repositoryItemColorEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1";
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Location = new System.Drawing.Point(4, 180);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(161, 6);
            this.splitter4.TabIndex = 29;
            this.splitter4.TabStop = false;
            // 
            // lbcAppearances
            // 
            this.lbcAppearances.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbcAppearances.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lbcAppearances.ItemHeight = 16;
            this.lbcAppearances.Location = new System.Drawing.Point(4, 4);
            this.lbcAppearances.Name = "lbcAppearances";
            this.lbcAppearances.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbcAppearances.Size = new System.Drawing.Size(161, 176);
            this.lbcAppearances.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.lbcAppearances.TabIndex = 27;
            this.lbcAppearances.SelectedIndexChanged += new System.EventHandler(this.lbcAppearances_SelectedIndexChanged);
            // 
            // Formats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Formats";
            this.Size = new System.Drawing.Size(803, 488);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcProperties)).EndInit();
            this.tcProperties.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lsStyles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceNewStyles.Properties)).EndInit();
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcAppearances)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl tcProperties;
        private DevExpress.XtraTab.XtraTabPage tabPage6;
        private DevExpress.XtraEditors.ListBoxControl lsStyles;
        private DevExpress.XtraEditors.CheckEdit ceNewStyles;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTab.XtraTabPage tabPage10;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGrid1;
        private DevExpress.XtraEditors.SplitterControl splitter4;
        private DevExpress.XtraEditors.ListBoxControl lbcAppearances;
        private DevExpress.XtraTab.XtraTabPage tabPage5;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorEdit repositoryItemColorEdit1;
        private System.ComponentModel.IContainer components = null;
    }
}
