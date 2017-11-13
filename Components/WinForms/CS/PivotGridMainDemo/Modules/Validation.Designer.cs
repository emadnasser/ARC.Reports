namespace DevExpress.XtraPivotGrid.Demos.Modules {
	partial class Validation {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
            this.controlPanel = new DevExpress.XtraEditors.PanelControl();
            this.totalValidation = new DevExpress.XtraPivotGrid.Demos.Modules.ValidationControl();
            this.commonValidation = new DevExpress.XtraPivotGrid.Demos.Modules.ValidationControl();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mainPanel.Controls.Add(this.pivotGridControl);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 82);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(700, 318);
            this.mainPanel.TabIndex = 5;
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldQuantity,
            this.fieldCategoryName,
            this.fieldProductName,
            this.fieldSalesPerson});
            this.pivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1});
            this.pivotGridControl.Size = new System.Drawing.Size(700, 318);
            this.pivotGridControl.TabIndex = 0;
            this.pivotGridControl.FieldValueImageIndex += new DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(this.pivotGridControl_FieldValueImageIndex);
            this.pivotGridControl.CustomAppearance += new DevExpress.XtraPivotGrid.PivotCustomAppearanceEventHandler(this.pivotGridControl_CustomAppearance);
            this.pivotGridControl.EditValueChanged += new DevExpress.XtraPivotGrid.EditValueChangedEventHandler(this.pivotGridControl_EditorValueChanged);
            this.pivotGridControl.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.pivotGridControl_ValidatingEditor);
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 0;
            this.fieldQuantity.FieldEdit = this.repositoryItemCalcEdit1;
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSalesPerson.AreaIndex = 0;
            this.fieldSalesPerson.FieldName = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            // 
            // paddingPanel
            // 
            this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 74);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(700, 8);
            this.paddingPanel.TabIndex = 4;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.totalValidation);
            this.controlPanel.Controls.Add(this.commonValidation);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(700, 74);
            this.controlPanel.TabIndex = 3;
            // 
            // totalValidation
            // 
            this.totalValidation.Caption = "Quantitiy (Total or GrandTotal):";
            this.totalValidation.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalValidation.Location = new System.Drawing.Point(2, 32);
            this.totalValidation.Name = "totalValidation";
            this.totalValidation.Size = new System.Drawing.Size(696, 30);
            this.totalValidation.TabIndex = 1;
            this.totalValidation.ValidateCondition += new System.EventHandler(this.validationControl_ValidateCondition);
            // 
            // commonValidation
            // 
            this.commonValidation.Caption = "Quantity (Common Cells):";
            this.commonValidation.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonValidation.Location = new System.Drawing.Point(2, 2);
            this.commonValidation.Name = "commonValidation";
            this.commonValidation.Size = new System.Drawing.Size(696, 30);
            this.commonValidation.TabIndex = 0;
            this.commonValidation.ValidateCondition += new System.EventHandler(this.validationControl_ValidateCondition);
            // 
            // Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "Validation";
            this.Size = new System.Drawing.Size(700, 400);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private DevExpress.XtraEditors.PanelControl mainPanel;
		private DevExpress.XtraEditors.PanelControl paddingPanel;
		private DevExpress.XtraEditors.PanelControl controlPanel;

		#endregion
		private PivotGridControl pivotGridControl;
		private PivotGridField fieldQuantity;
		private PivotGridField fieldCategoryName;
		private PivotGridField fieldProductName;
		private PivotGridField fieldSalesPerson;
		private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
		private ValidationControl totalValidation;
		private ValidationControl commonValidation;
	}
}
