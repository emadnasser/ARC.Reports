namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    partial class Editors {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editors));
            this.splitter1 = new DevExpress.XtraEditors.SplitterControl();
            this.tabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.rowPrice = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.categoryRow1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowHP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.rowLiter = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCyl = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.rowTransmiss_Speed_Count = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.rowTransmiss_Automatic = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rowDescription = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.rowIs_In_Stock = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rowHyperlink = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.rowID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow3 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowDelivery_Date = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.categoryRow4 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowTrademark = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowModel = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCategory = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.rowPicture = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowIcon = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow2 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(294, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 514);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(302, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(308, 514);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tabControl1_SelectedPageChanged);
            // 
            // rowPrice
            // 
            this.rowPrice.Name = "rowPrice";
            this.rowPrice.Properties.Caption = "Price";
            this.rowPrice.Properties.FieldName = "Price";
            this.rowPrice.Properties.Format.FormatString = "c";
            this.rowPrice.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rowPrice.Properties.RowEdit = this.repositoryItemCalcEdit1;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AllowFocused = false;
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // categoryRow1
            // 
            this.categoryRow1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowHP,
            this.rowLiter,
            this.rowCyl,
            this.rowTransmiss_Speed_Count,
            this.rowTransmiss_Automatic});
            this.categoryRow1.Name = "categoryRow1";
            this.categoryRow1.Properties.Caption = "Performance Attributes";
            // 
            // rowHP
            // 
            this.rowHP.Name = "rowHP";
            this.rowHP.Properties.Caption = "HP";
            this.rowHP.Properties.FieldName = "HP";
            this.rowHP.Properties.RowEdit = this.repositoryItemTextEdit1;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AllowFocused = false;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // rowLiter
            // 
            this.rowLiter.Name = "rowLiter";
            this.rowLiter.Properties.Caption = "Capacity";
            this.rowLiter.Properties.FieldName = "Liter";
            this.rowLiter.Properties.Format.FormatString = "#.### Liters";
            this.rowLiter.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rowLiter.Properties.RowEdit = this.repositoryItemTextEdit1;
            // 
            // rowCyl
            // 
            this.rowCyl.Name = "rowCyl";
            this.rowCyl.Properties.Caption = "Cyl";
            this.rowCyl.Properties.FieldName = "Cyl";
            this.rowCyl.Properties.RowEdit = this.repositoryItemSpinEdit1;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AllowFocused = false;
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.IsFloatValue = false;
            this.repositoryItemSpinEdit1.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // rowTransmiss_Speed_Count
            // 
            this.rowTransmiss_Speed_Count.Name = "rowTransmiss_Speed_Count";
            this.rowTransmiss_Speed_Count.Properties.Caption = "# of Gears";
            this.rowTransmiss_Speed_Count.Properties.FieldName = "Transmiss Speed Count";
            this.rowTransmiss_Speed_Count.Properties.RowEdit = this.repositoryItemSpinEdit2;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AllowFocused = false;
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit2.IsFloatValue = false;
            this.repositoryItemSpinEdit2.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // rowTransmiss_Automatic
            // 
            this.rowTransmiss_Automatic.Name = "rowTransmiss_Automatic";
            this.rowTransmiss_Automatic.Properties.Caption = "Automatic Transmission";
            this.rowTransmiss_Automatic.Properties.FieldName = "Transmiss Automatic";
            this.rowTransmiss_Automatic.Properties.ImageIndex = 2;
            this.rowTransmiss_Automatic.Properties.RowEdit = this.repositoryItemImageComboBox1;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AllowFocused = false;
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yes", "Yes", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("No", "No", 1)});
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
            // rowDescription
            // 
            this.rowDescription.Name = "rowDescription";
            this.rowDescription.Properties.Caption = "Description";
            this.rowDescription.Properties.FieldName = "Description";
            this.rowDescription.Properties.RowEdit = this.repositoryItemMemoExEdit1;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AllowFocused = false;
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // rowIs_In_Stock
            // 
            this.rowIs_In_Stock.Name = "rowIs_In_Stock";
            this.rowIs_In_Stock.Properties.Caption = "In Stock?";
            this.rowIs_In_Stock.Properties.FieldName = "Is In Stock";
            this.rowIs_In_Stock.Properties.RowEdit = this.repositoryItemCheckEdit1;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowFocused = false;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // rowHyperlink
            // 
            this.rowHyperlink.Name = "rowHyperlink";
            this.rowHyperlink.Properties.Caption = "Hyperlink";
            this.rowHyperlink.Properties.FieldName = "Hyperlink";
            this.rowHyperlink.Properties.ImageIndex = 1;
            this.rowHyperlink.Properties.RowEdit = this.repositoryItemHyperLinkEdit1;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // rowID
            // 
            this.rowID.Name = "rowID";
            this.rowID.Properties.Caption = "Record ID";
            this.rowID.Properties.FieldName = "ID";
            this.rowID.Properties.ImageIndex = 0;
            this.rowID.Properties.RowEdit = this.repositoryItemTextEdit1;
            // 
            // categoryRow3
            // 
            this.categoryRow3.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowPrice,
            this.rowDelivery_Date,
            this.rowIs_In_Stock});
            this.categoryRow3.Name = "categoryRow3";
            this.categoryRow3.Properties.Caption = "Others";
            // 
            // rowDelivery_Date
            // 
            this.rowDelivery_Date.Name = "rowDelivery_Date";
            this.rowDelivery_Date.Properties.Caption = "Delivery Date";
            this.rowDelivery_Date.Properties.FieldName = "Delivery Date";
            this.rowDelivery_Date.Properties.RowEdit = this.repositoryItemDateEdit1;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AllowFocused = false;
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // categoryRow4
            // 
            this.categoryRow4.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowID,
            this.rowTrademark,
            this.rowModel,
            this.rowCategory});
            this.categoryRow4.Name = "categoryRow4";
            this.categoryRow4.Properties.Caption = "Main Info";
            // 
            // rowTrademark
            // 
            this.rowTrademark.Name = "rowTrademark";
            this.rowTrademark.Properties.Caption = "Trademark";
            this.rowTrademark.Properties.FieldName = "Trademark";
            this.rowTrademark.Properties.RowEdit = this.repositoryItemTextEdit1;
            // 
            // rowModel
            // 
            this.rowModel.Name = "rowModel";
            this.rowModel.Properties.Caption = "Model";
            this.rowModel.Properties.FieldName = "Model";
            this.rowModel.Properties.RowEdit = this.repositoryItemTextEdit1;
            // 
            // rowCategory
            // 
            this.rowCategory.Name = "rowCategory";
            this.rowCategory.Properties.Caption = "Category";
            this.rowCategory.Properties.FieldName = "Category";
            this.rowCategory.Properties.RowEdit = this.repositoryItemComboBox1;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AllowFocused = false;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "SALOON",
            "SPORTS",
            "TRUCK"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AllowFocused = false;
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // rowPicture
            // 
            this.rowPicture.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowIcon});
            this.rowPicture.Name = "rowPicture";
            this.rowPicture.Properties.Caption = "Picture";
            this.rowPicture.Properties.FieldName = "Picture";
            this.rowPicture.Properties.RowEdit = this.repositoryItemImageEdit1;
            // 
            // rowIcon
            // 
            this.rowIcon.Height = 52;
            this.rowIcon.Name = "rowIcon";
            this.rowIcon.Properties.Caption = "Icon";
            this.rowIcon.Properties.FieldName = "Icon";
            this.rowIcon.Properties.ImageIndex = 4;
            this.rowIcon.Properties.RowEdit = this.repositoryItemPictureEdit1;
            // 
            // categoryRow2
            // 
            this.categoryRow2.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowPicture,
            this.rowDescription,
            this.rowHyperlink});
            this.categoryRow2.Name = "categoryRow2";
            this.categoryRow2.Properties.Caption = "Notes";
            this.categoryRow2.Properties.ImageIndex = 3;
            // 
            // vGridControl1
            // 
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.Location = new System.Drawing.Point(4, 4);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemImageComboBox1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemHyperLinkEdit1});
            this.vGridControl1.RowHeaderWidth = 188;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.categoryRow4,
            this.categoryRow1,
            this.categoryRow2,
            this.categoryRow3});
            this.vGridControl1.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowForFocusedRecord;
            this.vGridControl1.Size = new System.Drawing.Size(290, 514);
            this.vGridControl1.TabIndex = 13;
            // 
            // Editors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Editors";
            this.Size = new System.Drawing.Size(614, 522);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.Editors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SplitterControl splitter1;
        private DevExpress.XtraTab.XtraTabControl tabControl1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowHP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowLiter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCyl;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTransmiss_Speed_Count;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTransmiss_Automatic;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDescription;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowIs_In_Stock;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowHyperlink;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowID;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDelivery_Date;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTrademark;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowModel;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPicture;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowIcon;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow2;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private System.ComponentModel.IContainer components;

    }
}
