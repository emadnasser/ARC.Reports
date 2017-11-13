namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class AsynchronousMode {
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
			this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.btnGenerateDataSource = new DevExpress.XtraEditors.SimpleButton();
			this.rgDataSources = new DevExpress.XtraEditors.RadioGroup();
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.panelError = new DevExpress.XtraEditors.PanelControl();
			this.labelError = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
			this.paddingPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rgDataSources.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelError)).BeginInit();
			this.panelError.SuspendLayout();
			this.SuspendLayout();
			// 
			// paddingPanel
			// 
			this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.paddingPanel.Controls.Add(this.labelControl1);
			this.paddingPanel.Controls.Add(this.btnGenerateDataSource);
			this.paddingPanel.Controls.Add(this.rgDataSources);
			this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.paddingPanel.Location = new System.Drawing.Point(0, 43);
			this.paddingPanel.Name = "paddingPanel";
			this.paddingPanel.Size = new System.Drawing.Size(739, 29);
			this.paddingPanel.TabIndex = 12;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(6, 8);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(63, 13);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Data Source:";
			// 
			// btnGenerateDataSource
			// 
			this.btnGenerateDataSource.Location = new System.Drawing.Point(377, 3);
			this.btnGenerateDataSource.Name = "btnGenerateDataSource";
			this.btnGenerateDataSource.Size = new System.Drawing.Size(105, 23);
			this.btnGenerateDataSource.TabIndex = 0;
			this.btnGenerateDataSource.Text = "Generate Database";
			this.btnGenerateDataSource.Click += new System.EventHandler(this.btnGenerateDataSource_Click);
			// 
			// rgDataSources
			// 
			this.rgDataSources.Location = new System.Drawing.Point(72, 3);
			this.rgDataSources.Name = "rgDataSources";
			this.rgDataSources.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.rgDataSources.Properties.Appearance.Options.UseBackColor = true;
			this.rgDataSources.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.rgDataSources.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "OLAP Cube"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Table Data Source")});
			this.rgDataSources.Size = new System.Drawing.Size(221, 23);
			this.rgDataSources.TabIndex = 2;
			this.rgDataSources.SelectedIndexChanged += new System.EventHandler(this.rgDataSources_SelectedIndexChanged);
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
			this.splitContainerControl1.Location = new System.Drawing.Point(0, 72);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Controls.Add(this.pivotGridControl);
			this.splitContainerControl1.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(739, 415);
			this.splitContainerControl1.SplitterPosition = 240;
			this.splitContainerControl1.TabIndex = 15;
			this.splitContainerControl1.Text = "splitContainerControl1";
			this.splitContainerControl1.SplitterMoved += new System.EventHandler(this.splitContainerControl1_SplitterMoved);
			// 
			// pivotGridControl
			// 
			this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pivotGridControl.Location = new System.Drawing.Point(0, 0);
			this.pivotGridControl.Name = "pivotGridControl";
			this.pivotGridControl.OptionsBehavior.UseAsyncMode = true;
			this.pivotGridControl.OptionsCustomization.AllowCustomizationForm = false;
			this.pivotGridControl.OptionsCustomization.AllowFilterInCustomizationForm = true;
			this.pivotGridControl.OptionsCustomization.AllowSortInCustomizationForm = true;
			this.pivotGridControl.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
			this.pivotGridControl.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near;
			this.pivotGridControl.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree;
			this.pivotGridControl.OptionsView.ShowColumnHeaders = false;
			this.pivotGridControl.OptionsView.ShowDataHeaders = false;
			this.pivotGridControl.OptionsView.ShowFilterHeaders = false;
			this.pivotGridControl.OptionsView.ShowRowHeaders = false;
			this.pivotGridControl.Size = new System.Drawing.Size(490, 415);
			this.pivotGridControl.TabIndex = 16;
			this.pivotGridControl.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pivotGridControl1_CellDoubleClick);
			this.pivotGridControl.QueryException += new DevExpress.XtraPivotGrid.PivotQueryExceptionEventHandler(this.pivotGridControl_QueryException);
			this.pivotGridControl.AsyncOperationStarting += new System.EventHandler(this.pivotGridControl_AsyncOperationStarting);
			this.pivotGridControl.AsyncOperationCompleted += new System.EventHandler(this.pivotGridControl_AsyncOperationCompleted);
			// 
			// panelError
			// 
			this.panelError.Controls.Add(this.labelError);
			this.panelError.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelError.Location = new System.Drawing.Point(0, 0);
			this.panelError.Name = "panelError";
			this.panelError.Size = new System.Drawing.Size(739, 43);
			this.panelError.TabIndex = 18;
			this.panelError.Visible = false;
			// 
			// labelError
			// 
			this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelError.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.labelError.Appearance.ForeColor = System.Drawing.Color.Red;
			this.labelError.Appearance.Options.UseFont = true;
			this.labelError.Appearance.Options.UseForeColor = true;
			this.labelError.AutoEllipsis = true;
			this.labelError.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelError.Location = new System.Drawing.Point(12, 6);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(712, 28);
			this.labelError.TabIndex = 0;
			// 
			// AsynchronousMode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainerControl1);
			this.Controls.Add(this.paddingPanel);
			this.Controls.Add(this.panelError);
			this.Name = "AsynchronousMode";
			this.Size = new System.Drawing.Size(739, 487);
			this.Load += new System.EventHandler(this.AsynchronousMode_Load);
			this.Resize += new System.EventHandler(this.AsynchronousMode_Resize);
			((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
			this.paddingPanel.ResumeLayout(false);
			this.paddingPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rgDataSources.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelError)).EndInit();
			this.panelError.ResumeLayout(false);
			this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.XtraEditors.PanelControl paddingPanel;
        private DevExpress.XtraEditors.RadioGroup rgDataSources;
        private DevExpress.XtraEditors.SimpleButton btnGenerateDataSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private PivotGridControl pivotGridControl;
        private DevExpress.XtraEditors.PanelControl panelError;
        private DevExpress.XtraEditors.LabelControl labelError;
    }
}
