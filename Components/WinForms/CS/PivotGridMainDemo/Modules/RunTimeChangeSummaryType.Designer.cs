namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class RunTimeChangeSummaryType : DevExpress.XtraPivotGrid.Demos.TutorialControl {
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
			this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
			this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldOrderDate = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.checkEdit2);
			this.panelControl1.Controls.Add(this.checkEdit1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(706, 75);
			this.panelControl1.TabIndex = 1;
			// 
			// checkEdit2
			// 
			this.checkEdit2.Location = new System.Drawing.Point(16, 41);
			this.checkEdit2.Name = "checkEdit2";
			this.checkEdit2.Properties.AutoWidth = true;
			this.checkEdit2.Properties.Caption = "Compact Layout with One Data Field That Supports Changing the Summary Type on Mou" +
    "se Click";
			this.checkEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
			this.checkEdit2.Properties.RadioGroupIndex = 1;
            this.checkEdit2.Size = new System.Drawing.Size(483, 19);
			this.checkEdit2.TabIndex = 1;
			this.checkEdit2.TabStop = false;
			this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
			// 
			// checkEdit1
			// 
			this.checkEdit1.EditValue = true;
			this.checkEdit1.Location = new System.Drawing.Point(16, 16);
			this.checkEdit1.Name = "checkEdit1";
			this.checkEdit1.Properties.AutoWidth = true;
			this.checkEdit1.Properties.Caption = "Extended Layout with Multiple Data Fields";
			this.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
			this.checkEdit1.Properties.RadioGroupIndex = 1;
            this.checkEdit1.Size = new System.Drawing.Size(223, 19);
			this.checkEdit1.TabIndex = 0;
			this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
			// 
			// panelControl2
			// 
			this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl2.Location = new System.Drawing.Point(0, 75);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(706, 8);
			this.panelControl2.TabIndex = 14;
			// 
			// pivotGridControl1
			// 
			this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductName,
            this.fieldOrderDate,
            this.fieldSalesPerson});
			this.pivotGridControl1.Location = new System.Drawing.Point(0, 83);
			this.pivotGridControl1.Name = "pivotGridControl1";
			this.pivotGridControl1.Size = new System.Drawing.Size(706, 333);
			this.pivotGridControl1.TabIndex = 15;
			// 
			// fieldProductName
			// 
			this.fieldProductName.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
			this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldProductName.AreaIndex = 0;
			this.fieldProductName.Caption = "Product Name";
			this.fieldProductName.FieldName = "ProductName";
			this.fieldProductName.Name = "fieldProductName";
			this.fieldProductName.Width = 200;
			// 
			// fieldOrderDate
			// 
			this.fieldOrderDate.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
			this.fieldOrderDate.AreaIndex = 0;
			this.fieldOrderDate.Caption = "Order Year";
			this.fieldOrderDate.FieldName = "OrderDate";
			this.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldOrderDate.Name = "fieldOrderDate";
			this.fieldOrderDate.UnboundFieldName = "fieldOrderDate";
			// 
			// fieldSalesPerson
			// 
			this.fieldSalesPerson.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
			this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldSalesPerson.AreaIndex = 0;
			this.fieldSalesPerson.Caption = "Sales Person";
			this.fieldSalesPerson.FieldName = "Sales Person";
			this.fieldSalesPerson.Name = "fieldSalesPerson";
			// 
			// RunTimeChangeSummaryType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pivotGridControl1);
			this.Controls.Add(this.panelControl2);
			this.Controls.Add(this.panelControl1);
			this.Name = "RunTimeChangeSummaryType";
			this.Size = new System.Drawing.Size(706, 416);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.CheckEdit checkEdit2;
		private DevExpress.XtraEditors.CheckEdit checkEdit1;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private PivotGridControl pivotGridControl1;
		private PivotGridField fieldProductName;
		private PivotGridField fieldOrderDate;
		private PivotGridField fieldSalesPerson;
	}
}
