namespace DevExpress.XtraGrid.Demos.Tutorials {
    partial class GridColumnCustomization {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridColumnCustomization));
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLastName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCompany = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAddress = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colState = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colZipCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTime = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.colCustomer = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHomePhone = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFaxPhone = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPurchaseDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.colPaymentAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colCopies = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkEdit3);
            this.panel1.Controls.Add(this.checkEdit2);
            this.panel1.Controls.Add(this.checkEdit1);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 78);
            this.panel1.TabIndex = 3;
            // 
            // checkEdit3
            // 
            this.checkEdit3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEdit3.Location = new System.Drawing.Point(376, 51);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "Show Bands In Customization Form";
            this.checkEdit3.Size = new System.Drawing.Size(208, 19);
            this.checkEdit3.TabIndex = 3;
            this.checkEdit3.CheckedChanged += new System.EventHandler(this.checkEdit3_CheckedChanged);
            // 
            // checkEdit2
            // 
            this.checkEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEdit2.Location = new System.Drawing.Point(376, 31);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Allow Change Band Parent";
            this.checkEdit2.Size = new System.Drawing.Size(208, 19);
            this.checkEdit2.TabIndex = 2;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEdit1.Location = new System.Drawing.Point(376, 11);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Allow Change Column Parent";
            this.checkEdit1.Size = new System.Drawing.Size(208, 19);
            this.checkEdit1.TabIndex = 1;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(8, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(211, 24);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 86);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemImageComboBox1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTimeEdit1,
            this.repositoryItemSpinEdit2});
            this.gridControl1.Size = new System.Drawing.Size(594, 330);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Appearance.RowSeparator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.advBandedGridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand6,
            this.gridBand2});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colID,
            this.colFirstName,
            this.colLastName,
            this.colCompany,
            this.colAddress,
            this.colCity,
            this.colState,
            this.colZipCode,
            this.colCustomer,
            this.colPurchaseDate,
            this.colHomePhone,
            this.colFaxPhone,
            this.colPaymentType,
            this.colPaymentAmount,
            this.colCopies,
            this.colTime});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Images = this.imageList1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsCustomization.AllowChangeColumnParent = true;
            this.advBandedGridView1.RowSeparatorHeight = 1;
            this.advBandedGridView1.ShowCustomizationForm += new System.EventHandler(this.advBandedGridView1_ShowCustomizationForm);
            this.advBandedGridView1.HideCustomizationForm += new System.EventHandler(this.advBandedGridView1_HideCustomizationForm);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Customer";
            this.gridBand1.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand3,
            this.gridBand4,
            this.gridBand5});
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 430;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Name";
            this.gridBand3.Columns.Add(this.colID);
            this.gridBand3.Columns.Add(this.colFirstName);
            this.gridBand3.Columns.Add(this.colLastName);
            this.gridBand3.ImageIndex = 2;
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 178;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 47;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.Width = 178;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.RowIndex = 1;
            this.colLastName.Visible = true;
            this.colLastName.Width = 178;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Company";
            this.gridBand4.Columns.Add(this.colCompany);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Visible = false;
            this.gridBand4.Width = 108;
            // 
            // colCompany
            // 
            this.colCompany.AutoFillDown = true;
            this.colCompany.Caption = "Company";
            this.colCompany.FieldName = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.Width = 108;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Address";
            this.gridBand5.Columns.Add(this.colAddress);
            this.gridBand5.Columns.Add(this.colCity);
            this.gridBand5.Columns.Add(this.colState);
            this.gridBand5.Columns.Add(this.colZipCode);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Width = 252;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.ImageIndex = 1;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.Width = 252;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.RowIndex = 1;
            this.colCity.Visible = true;
            this.colCity.Width = 109;
            // 
            // colState
            // 
            this.colState.Caption = "State";
            this.colState.ColumnEdit = this.repositoryItemComboBox1;
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.RowIndex = 1;
            this.colState.Visible = true;
            this.colState.Width = 143;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "AK",
            "BC",
            "CA",
            "Co. Cork",
            "CT",
            "DF",
            "GA",
            "ID",
            "IL",
            "Isle of Wight",
            "Lara",
            "MI",
            "MT",
            "NJ",
            "NM",
            "Nueva Esparta",
            "NY",
            "OH",
            "OK",
            "OR",
            "Quebec",
            "RJ",
            "SP",
            "Tachira",
            "WA",
            "WY"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colZipCode
            // 
            this.colZipCode.Caption = "Zip Code";
            this.colZipCode.FieldName = "ZipCode";
            this.colZipCode.ImageIndex = 5;
            this.colZipCode.Name = "colZipCode";
            this.colZipCode.RowIndex = 1;
            this.colZipCode.Width = 46;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Other";
            this.gridBand6.Columns.Add(this.colTime);
            this.gridBand6.Columns.Add(this.colCustomer);
            this.gridBand6.Columns.Add(this.colHomePhone);
            this.gridBand6.Columns.Add(this.colFaxPhone);
            this.gridBand6.ImageIndex = 4;
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Visible = false;
            this.gridBand6.Width = 187;
            // 
            // colTime
            // 
            this.colTime.Caption = "Time";
            this.colTime.ColumnEdit = this.repositoryItemTimeEdit1;
            this.colTime.FieldName = "Time";
            this.colTime.ImageIndex = 6;
            this.colTime.Name = "colTime";
            this.colTime.Width = 109;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Customer";
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.Width = 78;
            // 
            // colHomePhone
            // 
            this.colHomePhone.Caption = "Home Phone";
            this.colHomePhone.FieldName = "HomePhone";
            this.colHomePhone.ImageIndex = 0;
            this.colHomePhone.Name = "colHomePhone";
            this.colHomePhone.RowIndex = 1;
            this.colHomePhone.Visible = true;
            this.colHomePhone.Width = 187;
            // 
            // colFaxPhone
            // 
            this.colFaxPhone.Caption = "Fax Phone";
            this.colFaxPhone.FieldName = "FaxPhone";
            this.colFaxPhone.Name = "colFaxPhone";
            this.colFaxPhone.RowIndex = 2;
            this.colFaxPhone.Width = 187;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Payment";
            this.gridBand2.Columns.Add(this.colPurchaseDate);
            this.gridBand2.Columns.Add(this.colPaymentType);
            this.gridBand2.Columns.Add(this.colPaymentAmount);
            this.gridBand2.Columns.Add(this.colCopies);
            this.gridBand2.ImageIndex = 3;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 314;
            // 
            // colPurchaseDate
            // 
            this.colPurchaseDate.Caption = "Purchase Date";
            this.colPurchaseDate.FieldName = "PurchaseDate";
            this.colPurchaseDate.Name = "colPurchaseDate";
            this.colPurchaseDate.Visible = true;
            this.colPurchaseDate.Width = 314;
            // 
            // colPaymentType
            // 
            this.colPaymentType.Caption = "Payment Type";
            this.colPaymentType.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colPaymentType.FieldName = "PaymentType";
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.RowIndex = 1;
            this.colPaymentType.Visible = true;
            this.colPaymentType.Width = 163;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("American Express", "AMEX", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cash", "CASH", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Master", "MASTER", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Visa", "VISA", 3)});
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
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.Caption = "Payment Amount";
            this.colPaymentAmount.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colPaymentAmount.DisplayFormat.FormatString = "c";
            this.colPaymentAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPaymentAmount.FieldName = "PaymentAmount";
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.RowIndex = 1;
            this.colPaymentAmount.Visible = true;
            this.colPaymentAmount.Width = 151;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colCopies
            // 
            this.colCopies.Caption = "Copies";
            this.colCopies.ColumnEdit = this.repositoryItemSpinEdit2;
            this.colCopies.FieldName = "Copies";
            this.colCopies.Name = "colCopies";
            this.colCopies.RowIndex = 2;
            this.colCopies.Width = 235;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit2.IsFloatValue = false;
            this.repositoryItemSpinEdit2.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 78);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(594, 8);
            this.panelControl1.TabIndex = 9;
            // 
            // GridColumnCustomization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.Name = "GridColumnCustomization";
            this.Size = new System.Drawing.Size(594, 416);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.GridColumnCustomization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFirstName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLastName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCompany;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAddress;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colState;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colZipCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustomer;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPurchaseDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHomePhone;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFaxPhone;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPaymentType;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPaymentAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCopies;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTime;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
