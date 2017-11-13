namespace DevExpress.XtraPivotGrid.Demos.Modules {
	partial class OLAP {
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
			this.panelConnection = new DevExpress.XtraEditors.PanelControl();
			this.buttonNewConnection = new DevExpress.XtraEditors.SimpleButton();
			this.splitPivotContainer = new DevExpress.XtraEditors.SplitContainerControl();
			this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.controlPanel = new DevExpress.XtraEditors.PanelControl();
			this.mainPanel = new DevExpress.XtraEditors.PanelControl();
			this.separator2 = new DevExpress.XtraEditors.PanelControl();
			this.separator1 = new DevExpress.XtraEditors.PanelControl();
			this.panelError = new DevExpress.XtraEditors.PanelControl();
			this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.panelConnection)).BeginInit();
			this.panelConnection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitPivotContainer)).BeginInit();
			this.splitPivotContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.controlPanel)).BeginInit();
			this.controlPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.separator2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.separator1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelError)).BeginInit();
			this.panelError.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelConnection
			// 
			this.panelConnection.Controls.Add(this.buttonNewConnection);
			this.panelConnection.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelConnection.Location = new System.Drawing.Point(0, 0);
			this.panelConnection.Margin = new System.Windows.Forms.Padding(0);
			this.panelConnection.Name = "panelConnection";
			this.panelConnection.Size = new System.Drawing.Size(690, 43);
			this.panelConnection.TabIndex = 0;
			// 
			// buttonNewConnection
			// 
			this.buttonNewConnection.Location = new System.Drawing.Point(14, 10);
			this.buttonNewConnection.Name = "buttonNewConnection";
			this.buttonNewConnection.Size = new System.Drawing.Size(109, 23);
			this.buttonNewConnection.TabIndex = 0;
			this.buttonNewConnection.Text = "New Connection";
			this.buttonNewConnection.Click += new System.EventHandler(this.buttonNewConnection_Click);
			// 
			// splitPivotContainer
			// 
			this.splitPivotContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitPivotContainer.Location = new System.Drawing.Point(0, 0);
			this.splitPivotContainer.Name = "splitPivotContainer";
			this.splitPivotContainer.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.splitPivotContainer.Panel1.Text = "Panel1";
			this.splitPivotContainer.Panel2.Controls.Add(this.pivotGridControl);
			this.splitPivotContainer.Panel2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.splitPivotContainer.Panel2.Text = "Panel2";
			this.splitPivotContainer.Size = new System.Drawing.Size(690, 368);
			this.splitPivotContainer.SplitterPosition = 240;
			this.splitPivotContainer.TabIndex = 3;
			this.splitPivotContainer.Text = "splitContainerControl1";
			// 
			// pivotGridControl
			// 
			this.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
			this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pivotGridControl.Location = new System.Drawing.Point(4, 0);
			this.pivotGridControl.Name = "pivotGridControl";
			this.pivotGridControl.OptionsCustomization.AllowFilterInCustomizationForm = true;
			this.pivotGridControl.OptionsCustomization.AllowSortInCustomizationForm = true;
			this.pivotGridControl.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
			this.pivotGridControl.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
			this.pivotGridControl.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree;
			this.pivotGridControl.OptionsView.ShowColumnHeaders = false;
			this.pivotGridControl.OptionsView.ShowDataHeaders = false;
			this.pivotGridControl.OptionsView.ShowFilterHeaders = false;
			this.pivotGridControl.OptionsView.ShowRowHeaders = false;
			this.pivotGridControl.OptionsView.ShowTotalsForSingleValues = true;
			this.pivotGridControl.Size = new System.Drawing.Size(441, 368);
			this.pivotGridControl.TabIndex = 2;
			this.pivotGridControl.ShowingCustomizationForm += new DevExpress.XtraPivotGrid.CustomizationFormShowingEventHandler(this.pivotGridControl_ShowingCustomizationForm);
			this.pivotGridControl.PopupMenuShowing += new DevExpress.XtraPivotGrid.PopupMenuShowingEventHandler(this.pivotGridControl_PopupMenuShowing);
			this.pivotGridControl.FieldValueNotExpanded += new DevExpress.XtraPivotGrid.PivotFieldValueEventHandler(this.pivotGridControl_FieldValueNotExpanded);
			this.pivotGridControl.QueryException += new DevExpress.XtraPivotGrid.PivotQueryExceptionEventHandler(this.pivotGridControl_QueryException);
			// 
			// controlPanel
			// 
			this.controlPanel.AutoSize = true;
			this.controlPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.controlPanel.Controls.Add(this.panelConnection);
			this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.controlPanel.Location = new System.Drawing.Point(0, 51);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.Size = new System.Drawing.Size(690, 43);
			this.controlPanel.TabIndex = 5;
			// 
			// mainPanel
			// 
			this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.mainPanel.Controls.Add(this.splitPivotContainer);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 102);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(690, 368);
			this.mainPanel.TabIndex = 7;
			// 
			// separator2
			// 
			this.separator2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.separator2.Dock = System.Windows.Forms.DockStyle.Top;
			this.separator2.Location = new System.Drawing.Point(0, 94);
			this.separator2.Name = "separator2";
			this.separator2.Size = new System.Drawing.Size(690, 8);
			this.separator2.TabIndex = 13;
			// 
			// separator1
			// 
			this.separator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.separator1.Dock = System.Windows.Forms.DockStyle.Top;
			this.separator1.Location = new System.Drawing.Point(0, 43);
			this.separator1.Name = "separator1";
			this.separator1.Size = new System.Drawing.Size(690, 8);
			this.separator1.TabIndex = 14;
			// 
			// panelError
			// 
			this.panelError.Controls.Add(this.hyperLinkEdit1);
			this.panelError.Controls.Add(this.labelControl1);
			this.panelError.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelError.Location = new System.Drawing.Point(0, 0);
			this.panelError.Name = "panelError";
			this.panelError.Size = new System.Drawing.Size(690, 43);
			this.panelError.TabIndex = 15;
			// 
			// hyperLinkEdit1
			// 
			this.hyperLinkEdit1.EditValue = "http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB";
			this.hyperLinkEdit1.Location = new System.Drawing.Point(456, 19);
			this.hyperLinkEdit1.Name = "hyperLinkEdit1";
			this.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.hyperLinkEdit1.Properties.Caption = "www.microsoft.com";
			this.hyperLinkEdit1.Size = new System.Drawing.Size(100, 18);
			this.hyperLinkEdit1.TabIndex = 1;
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.AutoEllipsis = true;
			this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl1.Location = new System.Drawing.Point(12, 7);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(663, 28);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "To run this demo, you should have Microsoft SQL Server Analysis Services OLE DB 8" +
    ".0 (or later) \r\ninstalled on your system. You can get the latest version of this" +
    " provider here:";
			// 
			// OLAP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.separator2);
			this.Controls.Add(this.controlPanel);
			this.Controls.Add(this.separator1);
			this.Controls.Add(this.panelError);
			this.Name = "OLAP";
			this.Size = new System.Drawing.Size(690, 470);
			this.Load += new System.EventHandler(this.OLAP_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelConnection)).EndInit();
			this.panelConnection.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitPivotContainer)).EndInit();
			this.splitPivotContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.controlPanel)).EndInit();
			this.controlPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.separator2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.separator1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelError)).EndInit();
			this.panelError.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelConnection;
		private DevExpress.XtraEditors.SimpleButton buttonNewConnection;
		private DevExpress.XtraEditors.SplitContainerControl splitPivotContainer;
        private PivotGridControl pivotGridControl;
		private DevExpress.XtraEditors.PanelControl controlPanel;
		private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraEditors.PanelControl separator2;
        private DevExpress.XtraEditors.PanelControl separator1;
        private DevExpress.XtraEditors.PanelControl panelError;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}
