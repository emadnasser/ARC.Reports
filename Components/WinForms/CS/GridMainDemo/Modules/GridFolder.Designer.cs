using DevExpress.Export;

namespace DevExpress.XtraGrid.Demos {
    partial class GridFolder {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridFolder));
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelDrives = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxDrives = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelSelectDrive = new System.Windows.Forms.Label();
            this.labelCurrentPath = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDrives)).BeginInit();
            this.panelDrives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDrives.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            resources.ApplyResources(this.gridControl2, "gridControl2");
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = ((System.Drawing.Color)(resources.GetObject("gridView1.Appearance.EvenRow.BackColor")));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.FooterPanel.Font")));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.HeaderPanel.Font")));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnImage,
            this.gridColumnName,
            this.gridColumnSize,
            this.gridColumnModified,
            this.gridColumnType});
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsView.AutoCalcPreviewLineCount = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumnName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.CustomColumnSort += new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(this.gridView1_CustomColumnSort);
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            this.gridView1.CalcPreviewText += new DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventHandler(this.gridView1_CalcPreviewText);
            this.gridView1.OptionsClipboard.ClipboardMode = ClipboardMode.Formatted;
            // 
            // gridColumnImage
            // 
            this.gridColumnImage.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumnImage.FieldName = "ImageIndex";
            this.gridColumnImage.Name = "gridColumnImage";
            this.gridColumnImage.OptionsColumn.AllowFocus = false;
            this.gridColumnImage.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnImage.OptionsColumn.AllowMove = false;
            this.gridColumnImage.OptionsColumn.AllowSize = false;
            this.gridColumnImage.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnImage.OptionsColumn.FixedWidth = true;
            this.gridColumnImage.OptionsColumn.ShowInCustomizationForm = false;
            this.gridColumnImage.OptionsFilter.AllowFilter = false;
            resources.ApplyResources(this.gridColumnImage, "gridColumnImage");
            // 
            // repositoryItemImageComboBox1
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox1, "repositoryItemImageComboBox1");
            this.repositoryItemImageComboBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox1.Buttons"))))});
            this.repositoryItemImageComboBox1.CaseSensitiveSearch = true;
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items5"))))});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            // 
            // gridColumnName
            // 
            resources.ApplyResources(this.gridColumnName, "gridColumnName");
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnName.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.gridColumnName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridColumnName.Summary"))), resources.GetString("gridColumnName.Summary1"), resources.GetString("gridColumnName.Summary2"))});
            // 
            // gridColumnSize
            // 
            resources.ApplyResources(this.gridColumnSize, "gridColumnSize");
            this.gridColumnSize.FieldName = "Size";
            this.gridColumnSize.Name = "gridColumnSize";
            this.gridColumnSize.OptionsColumn.AllowFocus = false;
            this.gridColumnSize.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnSize.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            // 
            // gridColumnModified
            // 
            resources.ApplyResources(this.gridColumnModified, "gridColumnModified");
            this.gridColumnModified.FieldName = "Modified";
            this.gridColumnModified.Name = "gridColumnModified";
            this.gridColumnModified.OptionsColumn.AllowFocus = false;
            this.gridColumnModified.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnModified.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            // 
            // gridColumnType
            // 
            resources.ApplyResources(this.gridColumnType, "gridColumnType");
            this.gridColumnType.FieldName = "ItemType";
            this.gridColumnType.Name = "gridColumnType";
            this.gridColumnType.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // panelDrives
            // 
            this.panelDrives.Controls.Add(this.comboBoxDrives);
            this.panelDrives.Controls.Add(this.labelSelectDrive);
            this.panelDrives.Controls.Add(this.labelCurrentPath);
            resources.ApplyResources(this.panelDrives, "panelDrives");
            this.panelDrives.Name = "panelDrives";
            // 
            // comboBoxDrives
            // 
            resources.ApplyResources(this.comboBoxDrives, "comboBoxDrives");
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("comboBoxDrives.Properties.Appearance.Font")));
            this.comboBoxDrives.Properties.Appearance.Options.UseFont = true;
            this.comboBoxDrives.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("comboBoxDrives.Properties.Buttons"))))});
            this.comboBoxDrives.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // labelSelectDrive
            // 
            resources.ApplyResources(this.labelSelectDrive, "labelSelectDrive");
            this.labelSelectDrive.Name = "labelSelectDrive";
            // 
            // labelCurrentPath
            // 
            resources.ApplyResources(this.labelCurrentPath, "labelCurrentPath");
            this.labelCurrentPath.Name = "labelCurrentPath";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // GridFolder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelDrives);
            this.Name = "GridFolder";
            this.Load += new System.EventHandler(this.GridFolder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDrives)).EndInit();
            this.panelDrives.ResumeLayout(false);
            this.panelDrives.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDrives.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnImage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSize;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnModified;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxDrives;
        private System.Windows.Forms.Label labelSelectDrive;
        private DevExpress.XtraEditors.PanelControl panelDrives;
        private System.Windows.Forms.Label labelCurrentPath;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnType;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
