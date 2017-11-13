namespace DevExpress.XtraPivotGrid.Demos.Modules {
	partial class OLAPKPI {
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
			this.panelConnection = new DevExpress.XtraEditors.PanelControl();
			this.ddlTrendGraphics = new DevExpress.XtraEditors.ComboBoxEdit();
			this.label1 = new DevExpress.XtraEditors.LabelControl();
			this.ddlStatusGraphics = new DevExpress.XtraEditors.ComboBoxEdit();
			this.label2 = new DevExpress.XtraEditors.LabelControl();
			this.fieldTrend = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldStatus = new DevExpress.XtraPivotGrid.PivotGridField();
			this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.separator1 = new DevExpress.XtraEditors.PanelControl();
			this.panelError = new DevExpress.XtraEditors.PanelControl();
			this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.panelConnection)).BeginInit();
			this.panelConnection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ddlTrendGraphics.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ddlStatusGraphics.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.separator1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelError)).BeginInit();
			this.panelError.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelConnection
			// 
			this.panelConnection.Controls.Add(this.ddlTrendGraphics);
			this.panelConnection.Controls.Add(this.label1);
			this.panelConnection.Controls.Add(this.ddlStatusGraphics);
			this.panelConnection.Controls.Add(this.label2);
			this.panelConnection.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelConnection.Location = new System.Drawing.Point(0, 51);
			this.panelConnection.Margin = new System.Windows.Forms.Padding(0);
			this.panelConnection.Name = "panelConnection";
			this.panelConnection.Size = new System.Drawing.Size(690, 68);
			this.panelConnection.TabIndex = 4;
			// 
			// ddlTrendGraphics
			// 
			this.ddlTrendGraphics.EditValue = "";
			this.ddlTrendGraphics.Location = new System.Drawing.Point(109, 37);
			this.ddlTrendGraphics.Name = "ddlTrendGraphics";
			this.ddlTrendGraphics.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ddlTrendGraphics.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.ddlTrendGraphics.Size = new System.Drawing.Size(173, 20);
			this.ddlTrendGraphics.TabIndex = 6;
			this.ddlTrendGraphics.SelectedIndexChanged += new System.EventHandler(this.cbTrendGraphic_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(18, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Trend Graphics:";
			// 
			// ddlStatusGraphics
			// 
			this.ddlStatusGraphics.EditValue = "";
			this.ddlStatusGraphics.Location = new System.Drawing.Point(109, 11);
			this.ddlStatusGraphics.Name = "ddlStatusGraphics";
			this.ddlStatusGraphics.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ddlStatusGraphics.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.ddlStatusGraphics.Size = new System.Drawing.Size(173, 20);
			this.ddlStatusGraphics.TabIndex = 4;
			this.ddlStatusGraphics.SelectedIndexChanged += new System.EventHandler(this.cbStatusGraphic_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(18, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Status Graphics:";
			// 
			// fieldTrend
			// 
			this.fieldTrend.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldTrend.AreaIndex = 3;
			this.fieldTrend.Caption = "Trend";
			this.fieldTrend.FieldName = "[Measures].[Internet Revenue Trend]";
			this.fieldTrend.Name = "fieldTrend";
			this.fieldTrend.ToolTips.HeaderText = "[Measures].[Internet Revenue Trend]";
			this.fieldTrend.ToolTips.ValueText = "[Measures].[Internet Revenue Trend]";
			// 
			// fieldStatus
			// 
			this.fieldStatus.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldStatus.AreaIndex = 2;
			this.fieldStatus.Caption = "Status";
			this.fieldStatus.FieldName = "[Measures].[Internet Revenue Status]";
			this.fieldStatus.Name = "fieldStatus";
			this.fieldStatus.ToolTips.HeaderText = "[Measures].[Internet Revenue Status]";
			this.fieldStatus.ToolTips.ValueText = "[Measures].[Internet Revenue Status]";
			// 
			// pivotGridField5
			// 
			this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.pivotGridField5.AreaIndex = 2;
			this.pivotGridField5.Caption = "Fiscal Quarter";
			this.pivotGridField5.FieldName = "[Date].[Fiscal].[Fiscal Quarter]";
			this.pivotGridField5.Name = "pivotGridField5";
			// 
			// pivotGridField4
			// 
			this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.pivotGridField4.AreaIndex = 1;
			this.pivotGridField4.Caption = "Fiscal Semester";
			this.pivotGridField4.FieldName = "[Date].[Fiscal].[Fiscal Semester]";
			this.pivotGridField4.Name = "pivotGridField4";
			// 
			// pivotGridField3
			// 
			this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.pivotGridField3.AreaIndex = 0;
			this.pivotGridField3.Caption = "Fiscal Year";
			this.pivotGridField3.FieldName = "[Date].[Fiscal].[Fiscal Year]";
			this.pivotGridField3.Name = "pivotGridField3";
			// 
			// pivotGridField2
			// 
			this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.pivotGridField2.AreaIndex = 1;
			this.pivotGridField2.Caption = "Goal";
			this.pivotGridField2.CellFormat.FormatString = "c2";
			this.pivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.pivotGridField2.FieldName = "[Measures].[Internet Revenue Goal]";
			this.pivotGridField2.Name = "pivotGridField2";
			this.pivotGridField2.ToolTips.HeaderText = "[Measures].[Internet Revenue Goal]";
			this.pivotGridField2.ToolTips.ValueText = "[Measures].[Internet Revenue Goal]";
			// 
			// pivotGridField1
			// 
			this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.pivotGridField1.AreaIndex = 0;
			this.pivotGridField1.Caption = "Internet Revenue";
			this.pivotGridField1.CellFormat.FormatString = "c2";
			this.pivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.pivotGridField1.FieldName = "[Measures].[Internet Sales Amount]";
			this.pivotGridField1.Name = "pivotGridField1";
			this.pivotGridField1.ToolTips.HeaderText = "[Measures].[Internet Sales Amount]";
			this.pivotGridField1.ToolTips.ValueText = "[Measures].[Internet Sales Amount]";
			// 
			// pivotGridControl
			// 
			this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
			this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField4,
            this.pivotGridField5,
            this.fieldStatus,
            this.fieldTrend});
			this.pivotGridControl.Location = new System.Drawing.Point(0, 127);
			this.pivotGridControl.Name = "pivotGridControl";
			this.pivotGridControl.Size = new System.Drawing.Size(690, 343);
			this.pivotGridControl.TabIndex = 3;
			// 
			// panelControl2
			// 
			this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl2.Location = new System.Drawing.Point(0, 119);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(690, 8);
			this.panelControl2.TabIndex = 14;
			// 
			// separator1
			// 
			this.separator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.separator1.Dock = System.Windows.Forms.DockStyle.Top;
			this.separator1.Location = new System.Drawing.Point(0, 43);
			this.separator1.Name = "separator1";
			this.separator1.Size = new System.Drawing.Size(690, 8);
			this.separator1.TabIndex = 16;
			// 
			// panelError
			// 
			this.panelError.Controls.Add(this.hyperLinkEdit1);
			this.panelError.Controls.Add(this.labelControl1);
			this.panelError.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelError.Location = new System.Drawing.Point(0, 0);
			this.panelError.Name = "panelError";
			this.panelError.Size = new System.Drawing.Size(690, 43);
			this.panelError.TabIndex = 17;
			// 
			// hyperLinkEdit1
			// 
			this.hyperLinkEdit1.EditValue = "http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB";
			this.hyperLinkEdit1.Location = new System.Drawing.Point(456, 18);
			this.hyperLinkEdit1.Name = "hyperLinkEdit1";
			this.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.hyperLinkEdit1.Properties.Caption = "www.microsoft.com";
            this.hyperLinkEdit1.Properties.UseParentBackground = true;
			this.hyperLinkEdit1.Size = new System.Drawing.Size(100, 18);
			this.hyperLinkEdit1.TabIndex = 1;
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
			this.labelControl1.AutoEllipsis = true;
			this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl1.Location = new System.Drawing.Point(12, 6);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(663, 28);
			this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "To run this demo, you should have Microsoft SQL Server Analysis Services" + 
                " OLE DB 8.0 (or later) \r\ninstalled on your system. You can get the latest version of this provider here:";
			// 
			// OLAPKPI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pivotGridControl);
			this.Controls.Add(this.panelControl2);
			this.Controls.Add(this.panelConnection);
			this.Controls.Add(this.separator1);
			this.Controls.Add(this.panelError);
			this.Name = "OLAPKPI";
			this.Size = new System.Drawing.Size(690, 470);
			((System.ComponentModel.ISupportInitialize)(this.panelConnection)).EndInit();
			this.panelConnection.ResumeLayout(false);
			this.panelConnection.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ddlTrendGraphics.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ddlStatusGraphics.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.separator1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelError)).EndInit();
			this.panelError.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelConnection;
		private DevExpress.XtraEditors.LabelControl label2;
		private DevExpress.XtraEditors.ComboBoxEdit ddlTrendGraphics;
		private DevExpress.XtraEditors.LabelControl label1;
		private DevExpress.XtraEditors.ComboBoxEdit ddlStatusGraphics;
		private PivotGridField fieldTrend;
		private PivotGridField fieldStatus;
		private PivotGridField pivotGridField5;
		private PivotGridField pivotGridField4;
		private PivotGridField pivotGridField3;
		private PivotGridField pivotGridField2;
		private PivotGridField pivotGridField1;
		private PivotGridControl pivotGridControl;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl separator1;
        private DevExpress.XtraEditors.PanelControl panelError;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}
