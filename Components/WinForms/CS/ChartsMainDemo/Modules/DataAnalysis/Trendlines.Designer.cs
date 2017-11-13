namespace DevExpress.XtraCharts.Demos.DataAnalysis {
    partial class TrendlinesDemo {
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
            DevExpress.XtraCharts.StockSeriesLabel stockSeriesLabel1 = new DevExpress.XtraCharts.StockSeriesLabel();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView1 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView2 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.lblStartValueLevel = new DevExpress.XtraEditors.LabelControl();
            this.lblEndValueLevel = new DevExpress.XtraEditors.LabelControl();
            this.cbeEndValueLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbeStarValueLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cheExtrapolateToInfinity = new DevExpress.XtraEditors.CheckEdit();
            this.ceColor = new DevExpress.XtraEditors.ColorEdit();
            this.lblColor = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEndValueLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeStarValueLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheExtrapolateToInfinity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceColor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblColor);
            this.panel.Controls.Add(this.ceColor);
            this.panel.Controls.Add(this.cheExtrapolateToInfinity);
            this.panel.Controls.Add(this.lblEndValueLevel);
            this.panel.Controls.Add(this.cbeStarValueLevel);
            this.panel.Controls.Add(this.cbeEndValueLevel);
            this.panel.Controls.Add(this.btnDeleteAll);
            this.panel.Controls.Add(this.lblStartValueLevel);
            this.panel.Controls.Add(this.btnDelete);
            this.panel.Controls.SetChildIndex(this.btnDelete, 0);
            this.panel.Controls.SetChildIndex(this.lblStartValueLevel, 0);
            this.panel.Controls.SetChildIndex(this.btnDeleteAll, 0);
            this.panel.Controls.SetChildIndex(this.cbeEndValueLevel, 0);
            this.panel.Controls.SetChildIndex(this.cbeStarValueLevel, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.lblEndValueLevel, 0);
            this.panel.Controls.SetChildIndex(this.cheExtrapolateToInfinity, 0);
            this.panel.Controls.SetChildIndex(this.ceColor, 0);
            this.panel.Controls.SetChildIndex(this.lblColor, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(507, 37);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.Visible = false;
            // 
            // chart
            // 
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month;
            xyDiagram1.AxisX.DateTimeScaleOptions.GridSpacing = 0.5D;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Interlaced = true;
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Title.Text = "US Dollars";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "Date";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            stockSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            series1.Label = stockSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Apple Inc.";
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
            series1.ValueDataMembersSerializable = "Low;High;Open;Close";
            stockSeriesView1.LevelLineLength = 0.3D;
            series1.View = stockSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.View = stockSeriesView2;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 2;
            chartTitle1.Text = "Stock Prices";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.quandl.com";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chart_BoundDataChanged);
            this.chart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chart_KeyDown);
            this.chart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart_MouseDown);
            this.chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            this.chart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart_MouseUp);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(610, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAll.Location = new System.Drawing.Point(610, 35);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAll.TabIndex = 5;
            this.btnDeleteAll.Text = "Clear";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // lblStartValueLevel
            // 
            this.lblStartValueLevel.Location = new System.Drawing.Point(12, 12);
            this.lblStartValueLevel.Name = "lblStartValueLevel";
            this.lblStartValueLevel.Size = new System.Drawing.Size(85, 13);
            this.lblStartValueLevel.TabIndex = 4;
            this.lblStartValueLevel.Text = "Start Value Level:";
            // 
            // lblEndValueLevel
            // 
            this.lblEndValueLevel.Location = new System.Drawing.Point(12, 40);
            this.lblEndValueLevel.Name = "lblEndValueLevel";
            this.lblEndValueLevel.Size = new System.Drawing.Size(79, 13);
            this.lblEndValueLevel.TabIndex = 5;
            this.lblEndValueLevel.Text = "End Value Level:";
            // 
            // cbeEndValueLevel
            // 
            this.cbeEndValueLevel.Location = new System.Drawing.Point(103, 37);
            this.cbeEndValueLevel.Name = "cbeEndValueLevel";
            this.cbeEndValueLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeEndValueLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeEndValueLevel.Size = new System.Drawing.Size(70, 20);
            this.cbeEndValueLevel.TabIndex = 1;
            this.cbeEndValueLevel.SelectedIndexChanged += new System.EventHandler(this.cbeEndValueLevel_SelectedIndexChanged);
            // 
            // cbeStarValueLevel
            // 
            this.cbeStarValueLevel.Location = new System.Drawing.Point(103, 9);
            this.cbeStarValueLevel.Name = "cbeStarValueLevel";
            this.cbeStarValueLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeStarValueLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeStarValueLevel.Size = new System.Drawing.Size(70, 20);
            this.cbeStarValueLevel.TabIndex = 0;
            this.cbeStarValueLevel.SelectedIndexChanged += new System.EventHandler(this.cbeStarValueLevel_SelectedIndexChanged);
            // 
            // cheExtrapolateToInfinity
            // 
            this.cheExtrapolateToInfinity.EditValue = true;
            this.cheExtrapolateToInfinity.Location = new System.Drawing.Point(190, 37);
            this.cheExtrapolateToInfinity.Name = "cheExtrapolateToInfinity";
            this.cheExtrapolateToInfinity.Properties.Caption = "Extrapolate to Infinity";
            this.cheExtrapolateToInfinity.Size = new System.Drawing.Size(144, 19);
            this.cheExtrapolateToInfinity.TabIndex = 3;
            this.cheExtrapolateToInfinity.CheckedChanged += new System.EventHandler(this.cheExtrapolateToInfinity_CheckedChanged);
            // 
            // ceColor
            // 
            this.ceColor.EditValue = System.Drawing.Color.Empty;
            this.ceColor.Location = new System.Drawing.Point(225, 9);
            this.ceColor.Name = "ceColor";
            this.ceColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.ceColor.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ceColor_Properties_ButtonClick);
            this.ceColor.Size = new System.Drawing.Size(154, 20);
            this.ceColor.TabIndex = 2;
            this.ceColor.EditValueChanged += new System.EventHandler(this.ceColor_EditValueChanged);
            this.ceColor.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.ceColor_CustomDisplayText);
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(190, 12);
            this.lblColor.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(29, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color:";
            // 
            // TrendlinesDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "TrendlinesDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEndValueLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeStarValueLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheExtrapolateToInfinity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceColor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
        private DevExpress.XtraEditors.LabelControl lblEndValueLevel;
        private DevExpress.XtraEditors.ComboBoxEdit cbeStarValueLevel;
        private DevExpress.XtraEditors.ComboBoxEdit cbeEndValueLevel;
        private DevExpress.XtraEditors.LabelControl lblStartValueLevel;
        private DevExpress.XtraEditors.CheckEdit cheExtrapolateToInfinity;
        private DevExpress.XtraEditors.LabelControl lblColor;
        private DevExpress.XtraEditors.ColorEdit ceColor;
    }
}
