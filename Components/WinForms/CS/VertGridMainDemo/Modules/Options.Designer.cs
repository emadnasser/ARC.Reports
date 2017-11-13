namespace DevExpress.XtraVerticalGrid.Demos {
    partial class Options {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.panel1 = new System.Windows.Forms.Panel();
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.categoryAppearance = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowAppearance = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowBandsInterval = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowLookAndFeel = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowRecordsInterval = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowRecordWidth = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowRowHeaderWidth = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowShowButtonMode = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowTreeButtonStyle = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.categoryBehavior = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowEnabled = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowRowHeaderWidthChangeStep = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowTabIndex = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowTabStop = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowVisible = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.categoryLayout = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowAnchor = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowDock = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowLayoutStyle = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowLocation = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowMaximumSize = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowMinimumSize = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowScrollVisibility = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowSize = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.categoryOptions = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowOptionsBehavior = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowOptionsHint = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowOptionsMenu = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowOptionsView = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowOptionsFind = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Size = new System.Drawing.Size(300, 488);
            this.pnlLeft.Controls.SetChildIndex(this.panel1, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.propertyGridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 4, 8, 8);
            this.panel1.Size = new System.Drawing.Size(296, 396);
            this.panel1.TabIndex = 3;
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.DefaultEditors.AddRange(new DevExpress.XtraVerticalGrid.Rows.DefaultEditor[] {
            new DevExpress.XtraVerticalGrid.Rows.DefaultEditor(typeof(bool), this.repositoryItemCheckEdit1)});
            this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl1.Location = new System.Drawing.Point(8, 4);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.OptionsMenu.EnableContextMenu = true;
            this.propertyGridControl1.RecordWidth = 72;
            this.propertyGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.propertyGridControl1.RowHeaderWidth = 128;
            this.propertyGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.categoryAppearance,
            this.categoryBehavior,
            this.categoryLayout,
            this.categoryOptions});
            this.propertyGridControl1.Size = new System.Drawing.Size(280, 384);
            this.propertyGridControl1.TabIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // categoryAppearance
            // 
            this.categoryAppearance.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowAppearance,
            this.rowBandsInterval,
            this.rowLookAndFeel,
            this.rowRecordsInterval,
            this.rowRecordWidth,
            this.rowRowHeaderWidth,
            this.rowShowButtonMode,
            this.rowTreeButtonStyle});
            this.categoryAppearance.Expanded = false;
            this.categoryAppearance.Name = "categoryAppearance";
            this.categoryAppearance.Properties.Caption = "Appearance";
            // 
            // rowAppearance
            // 
            this.rowAppearance.Expanded = false;
            this.rowAppearance.Name = "rowAppearance";
            this.rowAppearance.Properties.Caption = "Appearance";
            this.rowAppearance.Properties.FieldName = "Appearance";
            // 
            // rowBandsInterval
            // 
            this.rowBandsInterval.Name = "rowBandsInterval";
            this.rowBandsInterval.Properties.Caption = "BandsInterval";
            this.rowBandsInterval.Properties.FieldName = "BandsInterval";
            // 
            // rowLookAndFeel
            // 
            this.rowLookAndFeel.Expanded = false;
            this.rowLookAndFeel.Name = "rowLookAndFeel";
            this.rowLookAndFeel.Properties.Caption = "LookAndFeel";
            this.rowLookAndFeel.Properties.FieldName = "LookAndFeel";
            // 
            // rowRecordsInterval
            // 
            this.rowRecordsInterval.Name = "rowRecordsInterval";
            this.rowRecordsInterval.Properties.Caption = "RecordsInterval";
            this.rowRecordsInterval.Properties.FieldName = "RecordsInterval";
            // 
            // rowRecordWidth
            // 
            this.rowRecordWidth.Name = "rowRecordWidth";
            this.rowRecordWidth.Properties.Caption = "RecordWidth";
            this.rowRecordWidth.Properties.FieldName = "RecordWidth";
            // 
            // rowRowHeaderWidth
            // 
            this.rowRowHeaderWidth.Name = "rowRowHeaderWidth";
            this.rowRowHeaderWidth.Properties.Caption = "RowHeaderWidth";
            this.rowRowHeaderWidth.Properties.FieldName = "RowHeaderWidth";
            // 
            // rowShowButtonMode
            // 
            this.rowShowButtonMode.Name = "rowShowButtonMode";
            this.rowShowButtonMode.Properties.Caption = "ShowButtonMode";
            this.rowShowButtonMode.Properties.FieldName = "ShowButtonMode";
            // 
            // rowTreeButtonStyle
            // 
            this.rowTreeButtonStyle.Name = "rowTreeButtonStyle";
            this.rowTreeButtonStyle.Properties.Caption = "TreeButtonStyle";
            this.rowTreeButtonStyle.Properties.FieldName = "TreeButtonStyle";
            // 
            // categoryBehavior
            // 
            this.categoryBehavior.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowEnabled,
            this.rowRowHeaderWidthChangeStep,
            this.rowTabIndex,
            this.rowTabStop,
            this.rowVisible});
            this.categoryBehavior.Expanded = false;
            this.categoryBehavior.Name = "categoryBehavior";
            this.categoryBehavior.Properties.Caption = "Behavior";
            // 
            // rowEnabled
            // 
            this.rowEnabled.Name = "rowEnabled";
            this.rowEnabled.Properties.Caption = "Enabled";
            this.rowEnabled.Properties.FieldName = "Enabled";
            // 
            // rowRowHeaderWidthChangeStep
            // 
            this.rowRowHeaderWidthChangeStep.Name = "rowRowHeaderWidthChangeStep";
            this.rowRowHeaderWidthChangeStep.Properties.Caption = "RowHeaderWidthChangeStep";
            this.rowRowHeaderWidthChangeStep.Properties.FieldName = "RowHeaderWidthChangeStep";
            // 
            // rowTabIndex
            // 
            this.rowTabIndex.Name = "rowTabIndex";
            this.rowTabIndex.Properties.Caption = "TabIndex";
            this.rowTabIndex.Properties.FieldName = "TabIndex";
            // 
            // rowTabStop
            // 
            this.rowTabStop.Name = "rowTabStop";
            this.rowTabStop.Properties.Caption = "TabStop";
            this.rowTabStop.Properties.FieldName = "TabStop";
            // 
            // rowVisible
            // 
            this.rowVisible.Name = "rowVisible";
            this.rowVisible.Properties.Caption = "Visible";
            this.rowVisible.Properties.FieldName = "Visible";
            // 
            // categoryLayout
            // 
            this.categoryLayout.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowAnchor,
            this.rowDock,
            this.rowLayoutStyle,
            this.rowLocation,
            this.rowMaximumSize,
            this.rowMinimumSize,
            this.rowScrollVisibility,
            this.rowSize});
            this.categoryLayout.Expanded = false;
            this.categoryLayout.Name = "categoryLayout";
            this.categoryLayout.Properties.Caption = "Layout";
            // 
            // rowAnchor
            // 
            this.rowAnchor.Name = "rowAnchor";
            this.rowAnchor.Properties.Caption = "Anchor";
            this.rowAnchor.Properties.FieldName = "Anchor";
            // 
            // rowDock
            // 
            this.rowDock.Name = "rowDock";
            this.rowDock.Properties.Caption = "Dock";
            this.rowDock.Properties.FieldName = "Dock";
            // 
            // rowLayoutStyle
            // 
            this.rowLayoutStyle.Name = "rowLayoutStyle";
            this.rowLayoutStyle.Properties.Caption = "LayoutStyle";
            this.rowLayoutStyle.Properties.FieldName = "LayoutStyle";
            // 
            // rowLocation
            // 
            this.rowLocation.Expanded = false;
            this.rowLocation.Name = "rowLocation";
            this.rowLocation.Properties.Caption = "Location";
            this.rowLocation.Properties.FieldName = "Location";
            // 
            // rowMaximumSize
            // 
            this.rowMaximumSize.Expanded = false;
            this.rowMaximumSize.Name = "rowMaximumSize";
            this.rowMaximumSize.Properties.Caption = "MaximumSize";
            this.rowMaximumSize.Properties.FieldName = "MaximumSize";
            // 
            // rowMinimumSize
            // 
            this.rowMinimumSize.Expanded = false;
            this.rowMinimumSize.Name = "rowMinimumSize";
            this.rowMinimumSize.Properties.Caption = "MinimumSize";
            this.rowMinimumSize.Properties.FieldName = "MinimumSize";
            // 
            // rowScrollVisibility
            // 
            this.rowScrollVisibility.Name = "rowScrollVisibility";
            this.rowScrollVisibility.Properties.Caption = "ScrollVisibility";
            this.rowScrollVisibility.Properties.FieldName = "ScrollVisibility";
            // 
            // rowSize
            // 
            this.rowSize.Expanded = false;
            this.rowSize.Name = "rowSize";
            this.rowSize.Properties.Caption = "Size";
            this.rowSize.Properties.FieldName = "Size";
            // 
            // categoryOptions
            // 
            this.categoryOptions.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowOptionsBehavior,
            this.rowOptionsHint,
            this.rowOptionsMenu,
            this.rowOptionsView,
            this.rowOptionsFind});
            this.categoryOptions.Name = "categoryOptions";
            this.categoryOptions.Properties.Caption = "Options";
            // 
            // rowOptionsBehavior
            // 
            this.rowOptionsBehavior.Expanded = false;
            this.rowOptionsBehavior.Name = "rowOptionsBehavior";
            this.rowOptionsBehavior.Properties.Caption = "Options Behavior";
            this.rowOptionsBehavior.Properties.FieldName = "OptionsBehavior";
            // 
            // rowOptionsHint
            // 
            this.rowOptionsHint.Expanded = false;
            this.rowOptionsHint.Name = "rowOptionsHint";
            this.rowOptionsHint.Properties.Caption = "Options Hint";
            this.rowOptionsHint.Properties.FieldName = "OptionsHint";
            // 
            // rowOptionsMenu
            // 
            this.rowOptionsMenu.Expanded = false;
            this.rowOptionsMenu.Name = "rowOptionsMenu";
            this.rowOptionsMenu.Properties.Caption = "Options Menu";
            this.rowOptionsMenu.Properties.FieldName = "OptionsMenu";
            // 
            // rowOptionsView
            // 
            this.rowOptionsView.Expanded = false;
            this.rowOptionsView.Name = "rowOptionsView";
            this.rowOptionsView.Properties.Caption = "Options View";
            this.rowOptionsView.Properties.FieldName = "OptionsView";
            // 
            // rowOptionsFind
            // 
            this.rowOptionsFind.Expanded = false;
            this.rowOptionsFind.Name = "rowOptionsFind";
            this.rowOptionsFind.Properties.Caption = "Options Find";
            this.rowOptionsFind.Properties.FieldName = "OptionsFind";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Options";
            this.Size = new System.Drawing.Size(812, 488);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.IContainer components = null;
        private PropertyGridControl propertyGridControl1;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryAppearance;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowAppearance;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowBandsInterval;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowLookAndFeel;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowRecordsInterval;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowRecordWidth;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowRowHeaderWidth;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowShowButtonMode;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowTreeButtonStyle;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryBehavior;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowEnabled;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowRowHeaderWidthChangeStep;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowTabIndex;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowTabStop;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowVisible;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryLayout;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowAnchor;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowDock;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowLayoutStyle;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowLocation;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowMaximumSize;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowMinimumSize;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowScrollVisibility;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowSize;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryOptions;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowOptionsBehavior;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowOptionsHint;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowOptionsMenu;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowOptionsView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private Rows.PGridEditorRow rowOptionsFind;

    }
}
