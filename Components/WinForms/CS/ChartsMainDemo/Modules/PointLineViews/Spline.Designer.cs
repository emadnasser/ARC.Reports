namespace DevExpress.XtraCharts.Demos.PointLineViews {
    partial class SplineDemo {
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.labelLineTension = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxLineTension = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowMarkers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelAngle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxLineTension.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkEditShowMarkers
            // 
            this.checkEditShowMarkers.TabIndex = 4;
            // 
            // comboBoxEditMarkerKind
            // 
            this.comboBoxEditMarkerKind.TabIndex = 0;
            // 
            // comboBoxEditLabelAngle
            // 
            this.comboBoxEditLabelAngle.TabIndex = 2;
            // 
            // comboBoxEditMarkerSize
            // 
            this.comboBoxEditMarkerSize.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelLineTension);
            this.panel.Controls.Add(this.comboBoxLineTension);
            this.panel.Controls.SetChildIndex(this.comboBoxLineTension, 0);
            this.panel.Controls.SetChildIndex(this.labelLineTension, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditLabelAngle, 0);
            this.panel.Controls.SetChildIndex(this.labelAngle, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowMarkers, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.TabIndex = 5;
            // 
            // chart
            // 
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Continuous;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Title.Text = "Time of Day";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.Label.TextPattern = "{V:G}";
            xyDiagram1.AxisY.Title.Text = "Power, kW";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "Branch";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "Time";
            this.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            this.chart.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}kWt";
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Power";
            this.chart.SeriesTemplate.View = splineSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Text = "Power Consumption per Working Day";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chart_BoundDataChanged);
            // 
            // labelLineTension
            // 
            this.labelLineTension.Enabled = false;
            this.labelLineTension.Location = new System.Drawing.Point(148, 40);
            this.labelLineTension.Name = "labelLineTension";
            this.labelLineTension.Size = new System.Drawing.Size(103, 13);
            this.labelLineTension.TabIndex = 60;
            this.labelLineTension.Text = "Line Tension Percent:";
            // 
            // comboBoxLineTension
            // 
            this.comboBoxLineTension.Location = new System.Drawing.Point(257, 37);
            this.comboBoxLineTension.Name = "comboBoxLineTension";
            this.comboBoxLineTension.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxLineTension.Properties.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.comboBoxLineTension.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxLineTension.Size = new System.Drawing.Size(60, 20);
            this.comboBoxLineTension.TabIndex = 3;
            this.comboBoxLineTension.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // SplineDemo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "SplineDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowMarkers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelAngle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxLineTension.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl labelLineTension;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxLineTension;
    }
}
