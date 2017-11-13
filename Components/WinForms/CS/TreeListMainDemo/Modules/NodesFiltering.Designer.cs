namespace DevExpress.XtraTreeList.Demos {
    partial class NodesFiltering {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodesFiltering));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnFindPanelOptions = new DevExpress.XtraEditors.SimpleButton();
            this.ceAllowFindPanel = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.ceAllowFilter = new DevExpress.XtraEditors.CheckEdit();
            this.ceAutoFilterRow = new DevExpress.XtraEditors.CheckEdit();
            this.ceColumnFilterList = new DevExpress.XtraEditors.CheckEdit();
            this.ceFilterList = new DevExpress.XtraEditors.CheckEdit();
            this.ceFilterEditor = new DevExpress.XtraEditors.CheckEdit();
            this.cbFilterMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowFindPanel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoFilterRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceColumnFilterList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFilterList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFilterEditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilterMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnFindPanelOptions);
            this.panelControl1.Controls.Add(this.ceAllowFindPanel);
            this.panelControl1.Controls.Add(this.labelControl);
            this.panelControl1.Controls.Add(this.ceAllowFilter);
            this.panelControl1.Controls.Add(this.ceAutoFilterRow);
            this.panelControl1.Controls.Add(this.ceColumnFilterList);
            this.panelControl1.Controls.Add(this.ceFilterList);
            this.panelControl1.Controls.Add(this.ceFilterEditor);
            this.panelControl1.Controls.Add(this.cbFilterMode);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(798, 79);
            this.panelControl1.TabIndex = 1;
            // 
            // btnFindPanelOptions
            // 
            this.btnFindPanelOptions.ImageIndex = 3;
            this.btnFindPanelOptions.Location = new System.Drawing.Point(624, 39);
            this.btnFindPanelOptions.Name = "btnFindPanelOptions";
            this.btnFindPanelOptions.Size = new System.Drawing.Size(142, 24);
            this.btnFindPanelOptions.TabIndex = 8;
            this.btnFindPanelOptions.Text = "Find Panel Options...";
            this.btnFindPanelOptions.Click += new System.EventHandler(this.btnFindPanelOptions_Click);
            // 
            // ceAllowFindPanel
            // 
            this.ceAllowFindPanel.Location = new System.Drawing.Point(622, 17);
            this.ceAllowFindPanel.Name = "ceAllowFindPanel";
            this.ceAllowFindPanel.Properties.Caption = "Allow Find Panel";
            this.ceAllowFindPanel.Size = new System.Drawing.Size(112, 19);
            this.ceAllowFindPanel.TabIndex = 7;
            this.ceAllowFindPanel.CheckedChanged += new System.EventHandler(this.ceFindPanel_CheckedChanged);
            // 
            // labelControl
            // 
            this.labelControl.Location = new System.Drawing.Point(112, 23);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(57, 13);
            this.labelControl.TabIndex = 12;
            this.labelControl.Text = "Filter Mode:";
            // 
            // ceAllowFilter
            // 
            this.ceAllowFilter.Location = new System.Drawing.Point(16, 20);
            this.ceAllowFilter.Name = "ceAllowFilter";
            this.ceAllowFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ceAllowFilter.Properties.Appearance.Options.UseFont = true;
            this.ceAllowFilter.Properties.Caption = "Allow Filter";
            this.ceAllowFilter.Size = new System.Drawing.Size(88, 19);
            this.ceAllowFilter.TabIndex = 0;
            this.ceAllowFilter.CheckedChanged += new System.EventHandler(this.ceAllowFilter_CheckedChanged);
            // 
            // ceAutoFilterRow
            // 
            this.ceAutoFilterRow.Location = new System.Drawing.Point(312, 37);
            this.ceAutoFilterRow.Name = "ceAutoFilterRow";
            this.ceAutoFilterRow.Properties.Caption = "Show Auto Filter Row";
            this.ceAutoFilterRow.Size = new System.Drawing.Size(133, 19);
            this.ceAutoFilterRow.TabIndex = 4;
            this.ceAutoFilterRow.CheckedChanged += new System.EventHandler(this.ceAutoFilterRow_CheckedChanged);
            // 
            // ceColumnFilterList
            // 
            this.ceColumnFilterList.Location = new System.Drawing.Point(455, 37);
            this.ceColumnFilterList.Name = "ceColumnFilterList";
            this.ceColumnFilterList.Properties.Caption = "Allow column MRU filter list";
            this.ceColumnFilterList.Size = new System.Drawing.Size(155, 19);
            this.ceColumnFilterList.TabIndex = 6;
            this.ceColumnFilterList.CheckedChanged += new System.EventHandler(this.ceColumnFilterList_CheckedChanged);
            // 
            // ceFilterList
            // 
            this.ceFilterList.Location = new System.Drawing.Point(455, 17);
            this.ceFilterList.Name = "ceFilterList";
            this.ceFilterList.Properties.Caption = "Allow MRU filter list";
            this.ceFilterList.Size = new System.Drawing.Size(147, 19);
            this.ceFilterList.TabIndex = 5;
            this.ceFilterList.CheckedChanged += new System.EventHandler(this.ceFilterList_CheckedChanged);
            // 
            // ceFilterEditor
            // 
            this.ceFilterEditor.Location = new System.Drawing.Point(312, 17);
            this.ceFilterEditor.Name = "ceFilterEditor";
            this.ceFilterEditor.Properties.Caption = "Allow Filter Editor";
            this.ceFilterEditor.Size = new System.Drawing.Size(133, 19);
            this.ceFilterEditor.TabIndex = 3;
            this.ceFilterEditor.CheckedChanged += new System.EventHandler(this.ceFilterEditor_CheckedChanged);
            // 
            // cbFilterMode
            // 
            this.cbFilterMode.Location = new System.Drawing.Point(175, 20);
            this.cbFilterMode.Name = "cbFilterMode";
            this.cbFilterMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFilterMode.Properties.DropDownRows = 25;
            this.cbFilterMode.Size = new System.Drawing.Size(124, 20);
            this.cbFilterMode.TabIndex = 2;
            this.cbFilterMode.SelectedIndexChanged += new System.EventHandler(this.cbFilterMode_SelectedIndexChanged);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 87);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsBehavior.EnableFiltering = true;
            this.treeList1.OptionsBehavior.ExpandNodesOnFiltering = true;
            this.treeList1.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treeList1.OptionsFind.AllowFindPanel = true;
            this.treeList1.OptionsView.ShowAutoFilterRow = true;
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.treeList1.Size = new System.Drawing.Size(798, 369);
            this.treeList1.StateImageList = this.imageCollection1;
            this.treeList1.TabIndex = 10;
            this.treeList1.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeList1_GetStateImage);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Job Title";
            this.treeListColumn1.FieldName = "JobTitle";
            this.treeListColumn1.MinWidth = 33;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 105;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "First Name";
            this.treeListColumn2.FieldName = "FirstName";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 106;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Last Name";
            this.treeListColumn3.FieldName = "LastName";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 106;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Birth Date";
            this.treeListColumn4.ColumnEdit = this.repositoryItemDateEdit1;
            this.treeListColumn4.FieldName = "BirthDate";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            this.treeListColumn4.Width = 105;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Origin State";
            this.treeListColumn5.FieldName = "StateProvinceName";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 5;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "Origin City";
            this.treeListColumn6.FieldName = "City";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 4;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "Phone";
            this.treeListColumn7.FieldName = "Phone";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 6;
            this.treeListColumn7.Width = 105;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Administration.png");
            this.imageCollection1.Images.SetKeyName(1, "Inventory.png");
            this.imageCollection1.Images.SetKeyName(2, "Manufacturing.png");
            this.imageCollection1.Images.SetKeyName(3, "Quality.png");
            this.imageCollection1.Images.SetKeyName(4, "Research.png");
            this.imageCollection1.Images.SetKeyName(5, "Sales.png");
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 79);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(798, 8);
            this.panelControl2.TabIndex = 3;
            // 
            // NodesFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "NodesFiltering";
            this.Size = new System.Drawing.Size(798, 456);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowFindPanel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoFilterRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceColumnFilterList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFilterList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFilterEditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilterMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit ceAutoFilterRow;
        private DevExpress.XtraEditors.CheckEdit ceColumnFilterList;
        private DevExpress.XtraEditors.CheckEdit ceFilterList;
        private DevExpress.XtraEditors.CheckEdit ceFilterEditor;
        private DevExpress.XtraEditors.CheckEdit ceAllowFilter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbFilterMode;
        private DevExpress.XtraEditors.CheckEdit ceAllowFindPanel;
        private DevExpress.XtraEditors.SimpleButton btnFindPanelOptions;

    }
}
