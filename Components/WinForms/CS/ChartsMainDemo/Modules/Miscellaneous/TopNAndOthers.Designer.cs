namespace DevExpress.XtraCharts.Demos.Miscellaneous {
	partial class TopNAndOthersDemo {
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Doughnut3DSeriesLabel doughnut3DSeriesLabel1 = new DevExpress.XtraCharts.Doughnut3DSeriesLabel();
            DevExpress.XtraCharts.Doughnut3DSeriesView doughnut3DSeriesView1 = new DevExpress.XtraCharts.Doughnut3DSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.dS21 = new DevExpress.XtraCharts.Demos.DS2();
            this.labelMode = new DevExpress.XtraEditors.LabelControl();
            this.labelValue = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtValue = new DevExpress.XtraEditors.SpinEdit();
            this.checkEditShowOthers = new DevExpress.XtraEditors.CheckEdit();
            this.txtOthersArgument = new DevExpress.XtraEditors.TextEdit();
            this.labelOthersArgument = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowOthers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOthersArgument.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtOthersArgument);
            this.panel.Controls.Add(this.labelOthersArgument);
            this.panel.Controls.Add(this.checkEditShowOthers);
            this.panel.Controls.Add(this.txtValue);
            this.panel.Controls.Add(this.labelMode);
            this.panel.Controls.Add(this.labelValue);
            this.panel.Controls.Add(this.comboBoxMode);
            this.panel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxMode, 0);
            this.panel.Controls.SetChildIndex(this.labelValue, 0);
            this.panel.Controls.SetChildIndex(this.labelMode, 0);
            this.panel.Controls.SetChildIndex(this.txtValue, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowOthers, 0);
            this.panel.Controls.SetChildIndex(this.labelOthersArgument, 0);
            this.panel.Controls.SetChildIndex(this.txtOthersArgument, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 4;
            // 
            // chart
            // 
            this.chart.DataAdapter = this.oleDbDataAdapter1;
            this.chart.DataBindings = null;
            this.chart.DataSource = this.dS21.Countries;
            simpleDiagram3D1.RotationMatrixSerializable = "0.990157351881877;-0.0243454369756547;0.13782495497091;0;0.10562840212504;0.77604" +
    "3051453063;-0.621771519897728;0;-0.0918207992710787;0.630209871384037;0.77097630" +
    "237987;0;0;0;0;1";
            simpleDiagram3D1.RuntimeRotation = true;
            simpleDiagram3D1.RuntimeScrolling = true;
            simpleDiagram3D1.RuntimeZooming = true;
            this.chart.Diagram = simpleDiagram3D1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            this.chart.RefreshDataOnRepaint = true;
            series1.ArgumentDataMember = "Country";
            doughnut3DSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Tangent;
            doughnut3DSeriesLabel1.TextPattern = "{VP:P2}";
            series1.Label = doughnut3DSeriesLabel1;
            series1.LegendTextPattern = "{A:P2}";
            series1.Name = "Series 1";
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series1.TopNOptions.Enabled = true;
            series1.TopNOptions.ThresholdPercent = 2.3D;
            series1.TopNOptions.ThresholdValue = 7000D;
            series1.ValueDataMembersSerializable = "Area";
            series1.View = doughnut3DSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel1.TextPattern = "{V:F2}";
            this.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            chartTitle1.Text = "Area of Countries";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.nationmaster.com";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Countries", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("OfficialName", "OfficialName"),
                        new System.Data.Common.DataColumnMapping("Area", "Area")})});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT Country, OfficialName, Area FROM Countries";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // dS21
            // 
            this.dS21.DataSetName = "DS2";
            this.dS21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelMode
            // 
            this.labelMode.Location = new System.Drawing.Point(12, 12);
            this.labelMode.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(30, 13);
            this.labelMode.TabIndex = 54;
            this.labelMode.Text = "Mode:";
            // 
            // labelValue
            // 
            this.labelValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelValue.Location = new System.Drawing.Point(12, 40);
            this.labelValue.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(89, 13);
            this.labelValue.TabIndex = 56;
            this.labelValue.Text = "Value:";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.Location = new System.Drawing.Point(104, 9);
            this.comboBoxMode.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxMode.Properties.Items.AddRange(new object[] {
            "Count",
            "Threshold Value",
            "Threshold Percent"});
            this.comboBoxMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxMode.Size = new System.Drawing.Size(120, 20);
            this.comboBoxMode.TabIndex = 0;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // txtValue
            // 
            this.txtValue.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtValue.Location = new System.Drawing.Point(104, 36);
            this.txtValue.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.txtValue.Name = "txtValue";
            this.txtValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtValue.Properties.IsFloatValue = false;
            this.txtValue.Properties.Mask.EditMask = "N00";
            this.txtValue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValue.Properties.ValidateOnEnterKey = true;
            this.txtValue.Size = new System.Drawing.Size(120, 20);
            this.txtValue.TabIndex = 1;
            this.txtValue.EditValueChanged += new System.EventHandler(this.txtValue_EditValueChanged);
            // 
            // checkEditShowOthers
            // 
            this.checkEditShowOthers.Location = new System.Drawing.Point(249, 9);
            this.checkEditShowOthers.Margin = new System.Windows.Forms.Padding(0);
            this.checkEditShowOthers.Name = "checkEditShowOthers";
            this.checkEditShowOthers.Properties.Caption = "Show \"Others\"";
            this.checkEditShowOthers.Size = new System.Drawing.Size(92, 19);
            this.checkEditShowOthers.TabIndex = 2;
            this.checkEditShowOthers.CheckedChanged += new System.EventHandler(this.checkEditShowOthers_CheckedChanged);
            // 
            // txtOthersArgument
            // 
            this.txtOthersArgument.Location = new System.Drawing.Point(350, 36);
            this.txtOthersArgument.Name = "txtOthersArgument";
            this.txtOthersArgument.Size = new System.Drawing.Size(115, 20);
            this.txtOthersArgument.TabIndex = 3;
            this.txtOthersArgument.EditValueChanged += new System.EventHandler(this.txtOthersArgument_EditValueChanged);
            // 
            // labelOthersArgument
            // 
            this.labelOthersArgument.Location = new System.Drawing.Point(249, 40);
            this.labelOthersArgument.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelOthersArgument.Name = "labelOthersArgument";
            this.labelOthersArgument.Size = new System.Drawing.Size(95, 13);
            this.labelOthersArgument.TabIndex = 65;
            this.labelOthersArgument.Text = "\"Others\" Argument:";
            // 
            // TopNAndOthersDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "TopNAndOthersDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowOthers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOthersArgument.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private DS2 dS21;
        private DevExpress.XtraEditors.LabelControl labelMode;
        private DevExpress.XtraEditors.LabelControl labelValue;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxMode;
        private DevExpress.XtraEditors.SpinEdit txtValue;
        private DevExpress.XtraEditors.CheckEdit checkEditShowOthers;
        private DevExpress.XtraEditors.TextEdit txtOthersArgument;
        private DevExpress.XtraEditors.LabelControl labelOthersArgument;

	}
}
