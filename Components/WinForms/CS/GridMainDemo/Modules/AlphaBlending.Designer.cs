namespace DevExpress.XtraGrid.Demos {
    partial class AlphaBlending {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlphaBlending));
            this.btnEditAlphaBlending = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chAlphaBlending = new DevExpress.XtraEditors.CheckEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPhoto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colEmployeeID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLastName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHireDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTitleOfCourtesy = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.colNotes = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colBirthDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTitle = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colRegion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCountry = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colExtension = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHomePhone = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPostalCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAddress = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.xtraGridBlending1 = new DevExpress.XtraGrid.Blending.XtraGridBlending();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbeStyles = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cbeImages = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chAlphaBlending.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeStyles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeImages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditAlphaBlending
            // 
            this.btnEditAlphaBlending.ImageIndex = 3;
            this.btnEditAlphaBlending.ImageList = this.imageList1;
            this.btnEditAlphaBlending.Location = new System.Drawing.Point(14, 37);
            this.btnEditAlphaBlending.Name = "btnEditAlphaBlending";
            this.btnEditAlphaBlending.Size = new System.Drawing.Size(116, 24);
            this.btnEditAlphaBlending.TabIndex = 18;
            this.btnEditAlphaBlending.Text = "A&djust...";
            this.btnEditAlphaBlending.Click += new System.EventHandler(this.btnEditAlphaBlending_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            // 
            // chAlphaBlending
            // 
            this.chAlphaBlending.EditValue = true;
            this.chAlphaBlending.Location = new System.Drawing.Point(12, 12);
            this.chAlphaBlending.Name = "chAlphaBlending";
            this.chAlphaBlending.Properties.Caption = "Alpha &Blending";
            this.chAlphaBlending.Size = new System.Drawing.Size(116, 19);
            this.chAlphaBlending.TabIndex = 15;
            this.chAlphaBlending.CheckedChanged += new System.EventHandler(this.chAlphaBlending_CheckedChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 78);
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemImageComboBox1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(832, 387);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand3,
            this.gridBand2,
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colAddress,
            this.colBirthDate,
            this.colCity,
            this.colCountry,
            this.colEmployeeID,
            this.colExtension,
            this.colFirstName,
            this.colHireDate,
            this.colHomePhone,
            this.colLastName,
            this.colNotes,
            this.colPhoto,
            this.colPostalCode,
            this.colRegion,
            this.colTitle,
            this.colTitleOfCourtesy});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.GroupCount = 1;
            this.advBandedGridView1.Images = this.imageList1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsView.ColumnAutoWidth = true;
            this.advBandedGridView1.PaintStyleName = "MixedXP";
            this.advBandedGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCountry, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.advBandedGridView1.EndGrouping += new System.EventHandler(this.advBandedGridView1_EndGrouping);
            this.advBandedGridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Photo";
            this.gridBand3.Columns.Add(this.colPhoto);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 75;
            // 
            // colPhoto
            // 
            this.colPhoto.Caption = "Photo";
            this.colPhoto.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.ImageIndex = 2;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPhoto.OptionsFilter.AllowFilter = false;
            this.colPhoto.RowCount = 3;
            this.colPhoto.Visible = true;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Employee";
            this.gridBand2.Columns.Add(this.colEmployeeID);
            this.gridBand2.Columns.Add(this.colFirstName);
            this.gridBand2.Columns.Add(this.colLastName);
            this.gridBand2.Columns.Add(this.colHireDate);
            this.gridBand2.Columns.Add(this.colTitleOfCourtesy);
            this.gridBand2.Columns.Add(this.colNotes);
            this.gridBand2.Columns.Add(this.colBirthDate);
            this.gridBand2.Columns.Add(this.colTitle);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 267;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "EmployeeID";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Width = 20;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.Width = 70;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.Width = 71;
            // 
            // colHireDate
            // 
            this.colHireDate.Caption = "Hire Date";
            this.colHireDate.FieldName = "HireDate";
            this.colHireDate.Name = "colHireDate";
            this.colHireDate.Width = 24;
            // 
            // colTitleOfCourtesy
            // 
            this.colTitleOfCourtesy.Caption = "Title Of Courtesy";
            this.colTitleOfCourtesy.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colTitleOfCourtesy.FieldName = "TitleOfCourtesy";
            this.colTitleOfCourtesy.Name = "colTitleOfCourtesy";
            this.colTitleOfCourtesy.Visible = true;
            this.colTitleOfCourtesy.Width = 126;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Dr.", "Dr.", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Miss", "Miss", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mr.", "Mr.", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mrs.", "Mrs.", 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Ms.", "Ms.", 4)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageList2;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "");
            // 
            // colNotes
            // 
            this.colNotes.Caption = "Notes";
            this.colNotes.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colNotes.FieldName = "Notes";
            this.colNotes.ImageIndex = 1;
            this.colNotes.Name = "colNotes";
            this.colNotes.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsFilter.AllowFilter = false;
            this.colNotes.RowIndex = 1;
            this.colNotes.Visible = true;
            this.colNotes.Width = 141;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            this.repositoryItemMemoExEdit1.PopupFormSize = new System.Drawing.Size(300, 150);
            // 
            // colBirthDate
            // 
            this.colBirthDate.Caption = "Birth Date";
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.RowIndex = 1;
            this.colBirthDate.Visible = true;
            this.colBirthDate.Width = 126;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Title";
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.RowIndex = 2;
            this.colTitle.Visible = true;
            this.colTitle.Width = 267;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Address";
            this.gridBand1.Columns.Add(this.colRegion);
            this.gridBand1.Columns.Add(this.colCountry);
            this.gridBand1.Columns.Add(this.colCity);
            this.gridBand1.Columns.Add(this.colExtension);
            this.gridBand1.Columns.Add(this.colHomePhone);
            this.gridBand1.Columns.Add(this.colPostalCode);
            this.gridBand1.Columns.Add(this.colAddress);
            this.gridBand1.ImageIndex = 0;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 304;
            // 
            // colRegion
            // 
            this.colRegion.Caption = "Region";
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            this.colRegion.Visible = true;
            this.colRegion.Width = 80;
            // 
            // colCountry
            // 
            this.colCountry.Caption = "Country";
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.Width = 88;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.Width = 136;
            // 
            // colExtension
            // 
            this.colExtension.Caption = "Extension";
            this.colExtension.FieldName = "Extension";
            this.colExtension.Name = "colExtension";
            this.colExtension.RowIndex = 1;
            this.colExtension.Visible = true;
            this.colExtension.Width = 80;
            // 
            // colHomePhone
            // 
            this.colHomePhone.Caption = "Home Phone";
            this.colHomePhone.FieldName = "HomePhone";
            this.colHomePhone.Name = "colHomePhone";
            this.colHomePhone.RowIndex = 1;
            this.colHomePhone.Visible = true;
            this.colHomePhone.Width = 224;
            // 
            // colPostalCode
            // 
            this.colPostalCode.Caption = "Postal Code";
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.RowIndex = 2;
            this.colPostalCode.Visible = true;
            this.colPostalCode.Width = 80;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.RowIndex = 2;
            this.colAddress.Visible = true;
            this.colAddress.Width = 224;
            // 
            // xtraGridBlending1
            // 
            this.xtraGridBlending1.GridControl = this.gridControl1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbeStyles);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.cbeImages);
            this.panelControl1.Controls.Add(this.btnEditAlphaBlending);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.chAlphaBlending);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(832, 70);
            this.panelControl1.TabIndex = 4;
            // 
            // cbeStyles
            // 
            this.cbeStyles.EditValue = "";
            this.cbeStyles.Location = new System.Drawing.Point(404, 34);
            this.cbeStyles.Name = "cbeStyles";
            this.cbeStyles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeStyles.Properties.DropDownRows = 20;
            this.cbeStyles.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeStyles.Size = new System.Drawing.Size(196, 20);
            this.cbeStyles.TabIndex = 21;
            this.cbeStyles.SelectedIndexChanged += new System.EventHandler(this.cbeStyles_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Style Scheme:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbeImages
            // 
            this.cbeImages.EditValue = "";
            this.cbeImages.Location = new System.Drawing.Point(172, 34);
            this.cbeImages.Name = "cbeImages";
            this.cbeImages.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeImages.Properties.Items.AddRange(new object[] {
            "(None)",
            "Blue",
            "Green",
            "Pink",
            "Yellow",
            "World"});
            this.cbeImages.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeImages.Size = new System.Drawing.Size(196, 20);
            this.cbeImages.TabIndex = 19;
            this.cbeImages.SelectedIndexChanged += new System.EventHandler(this.cbeImages_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background Image:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 70);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(832, 8);
            this.panelControl2.TabIndex = 5;
            // 
            // AlphaBlending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "AlphaBlending";
            this.Size = new System.Drawing.Size(832, 465);
            this.Load += new System.EventHandler(this.AlphaBlending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chAlphaBlending.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeStyles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeImages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Blending.XtraGridBlending xtraGridBlending1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAddress;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBirthDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCountry;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEmployeeID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colExtension;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFirstName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHireDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHomePhone;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLastName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNotes;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPhoto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPostalCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRegion;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTitle;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTitleOfCourtesy;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.CheckEdit chAlphaBlending;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbeImages;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cbeStyles;
        private DevExpress.XtraEditors.SimpleButton btnEditAlphaBlending;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}
