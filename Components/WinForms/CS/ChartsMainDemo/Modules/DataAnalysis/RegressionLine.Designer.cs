namespace DevExpress.XtraCharts.Demos.DataAnalysis {
    partial class RegressionLineDemo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView1 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.RegressionLine regressionLine1 = new DevExpress.XtraCharts.RegressionLine();
            DevExpress.XtraCharts.XYMarkerWidenAnimation xyMarkerWidenAnimation1 = new DevExpress.XtraCharts.XYMarkerWidenAnimation();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView2 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.btnCreateRandomPoints = new DevExpress.XtraEditors.SimpleButton();
            this.speThickness = new DevExpress.XtraEditors.SpinEdit();
            this.lbThickness = new DevExpress.XtraEditors.LabelControl();
            this.lbColor = new DevExpress.XtraEditors.LabelControl();
            this.clreColor = new DevExpress.XtraEditors.ColorEdit();
            this.cbDashStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbDashStyle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(regressionLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clreColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDashStyle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbDashStyle);
            this.panel.Controls.Add(this.cbDashStyle);
            this.panel.Controls.Add(this.clreColor);
            this.panel.Controls.Add(this.lbColor);
            this.panel.Controls.Add(this.lbThickness);
            this.panel.Controls.Add(this.speThickness);
            this.panel.Controls.Add(this.btnCreateRandomPoints);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.btnCreateRandomPoints, 0);
            this.panel.Controls.SetChildIndex(this.speThickness, 0);
            this.panel.Controls.SetChildIndex(this.lbThickness, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.lbColor, 0);
            this.panel.Controls.SetChildIndex(this.clreColor, 0);
            this.panel.Controls.SetChildIndex(this.cbDashStyle, 0);
            this.panel.Controls.SetChildIndex(this.lbDashStyle, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 4;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.Title.Text = "Arguments";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "100";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "0";
            xyDiagram1.AxisX.WholeRange.Auto = false;
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "100";
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "0";
            xyDiagram1.AxisY.Title.Text = "Values";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.LabelsResolveOverlappingMinIndent = 1;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAllAroundPoint;
            pointSeriesLabel1.TextPattern = "{V:F2}";
            series1.Label = pointSeriesLabel1;
            series1.Name = "Random points";
            regressionLine1.Name = "Regression Line";
            regressionLine1.Visible = false;
            pointSeriesView1.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            regressionLine1});
            xyMarkerWidenAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.0100000");
            pointSeriesView1.SeriesPointAnimation = xyMarkerWidenAnimation1;
            series1.View = pointSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.SeriesTemplate.View = pointSeriesView2;
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 2;
            chartTitle1.Text = "Random Points Generator";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chart.AnimationEnded += new DevExpress.XtraCharts.AnimationEndedEventHandler(this.chart_AnimationEnded);
            // 
            // btnCreateRandomPoints
            // 
            this.btnCreateRandomPoints.Location = new System.Drawing.Point(12, 8);
            this.btnCreateRandomPoints.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnCreateRandomPoints.Name = "btnCreateRandomPoints";
            this.btnCreateRandomPoints.Size = new System.Drawing.Size(85, 22);
            this.btnCreateRandomPoints.TabIndex = 0;
            this.btnCreateRandomPoints.Text = "Create Points";
            this.btnCreateRandomPoints.Click += new System.EventHandler(this.btnCreateRandomPoints_Click);
            // 
            // speThickness
            // 
            this.speThickness.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speThickness.Location = new System.Drawing.Point(328, 9);
            this.speThickness.Name = "speThickness";
            this.speThickness.Properties.Appearance.Options.UseTextOptions = true;
            this.speThickness.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.speThickness.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.speThickness.Properties.IsFloatValue = false;
            this.speThickness.Properties.Mask.EditMask = "N00";
            this.speThickness.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speThickness.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speThickness.Properties.ValidateOnEnterKey = true;
            this.speThickness.Size = new System.Drawing.Size(60, 20);
            this.speThickness.TabIndex = 3;
            this.speThickness.EditValueChanged += new System.EventHandler(this.speThickness_EditValueChanged);
            // 
            // lbThickness
            // 
            this.lbThickness.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbThickness.Location = new System.Drawing.Point(272, 8);
            this.lbThickness.Name = "lbThickness";
            this.lbThickness.Size = new System.Drawing.Size(50, 20);
            this.lbThickness.TabIndex = 15;
            this.lbThickness.Text = "Thickness:";
            // 
            // lbColor
            // 
            this.lbColor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbColor.Location = new System.Drawing.Point(110, 11);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(32, 14);
            this.lbColor.TabIndex = 16;
            this.lbColor.Text = "Color:";
            // 
            // clreColor
            // 
            this.clreColor.EditValue = System.Drawing.Color.Empty;
            this.clreColor.EnterMoveNextControl = true;
            this.clreColor.Location = new System.Drawing.Point(148, 9);
            this.clreColor.Name = "clreColor";
            this.clreColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clreColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.clreColor.Size = new System.Drawing.Size(108, 20);
            this.clreColor.TabIndex = 1;
            this.clreColor.EditValueChanged += new System.EventHandler(this.clreColor_EditValueChanged);
            // 
            // cbDashStyle
            // 
            this.cbDashStyle.Location = new System.Drawing.Point(468, 9);
            this.cbDashStyle.Name = "cbDashStyle";
            this.cbDashStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDashStyle.Properties.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.cbDashStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbDashStyle.Size = new System.Drawing.Size(108, 20);
            this.cbDashStyle.TabIndex = 2;
            this.cbDashStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // lbDashStyle
            // 
            this.lbDashStyle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbDashStyle.Location = new System.Drawing.Point(405, 8);
            this.lbDashStyle.Name = "lbDashStyle";
            this.lbDashStyle.Size = new System.Drawing.Size(57, 20);
            this.lbDashStyle.TabIndex = 19;
            this.lbDashStyle.Text = "Dash Style:";
            // 
            // RegressionLineDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "RegressionLineDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(regressionLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clreColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDashStyle.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.XtraEditors.SimpleButton btnCreateRandomPoints;
        private DevExpress.XtraEditors.SpinEdit speThickness;
        private DevExpress.XtraEditors.LabelControl lbThickness;
        private DevExpress.XtraEditors.LabelControl lbColor;
        private DevExpress.XtraEditors.ColorEdit clreColor;
        private DevExpress.XtraEditors.LabelControl lbDashStyle;
        private DevExpress.XtraEditors.ComboBoxEdit cbDashStyle;
    }
}
