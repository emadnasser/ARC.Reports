namespace DevExpress.XtraCharts.Demos.PointLineViews {
    partial class BubbleDemo {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.BubbleSeriesLabel bubbleSeriesLabel1 = new DevExpress.XtraCharts.BubbleSeriesLabel();
            DevExpress.XtraCharts.BubbleSeriesView bubbleSeriesView1 = new DevExpress.XtraCharts.BubbleSeriesView();
            DevExpress.XtraCharts.XYMarkerWidenAnimation xyMarkerWidenAnimation1 = new DevExpress.XtraCharts.XYMarkerWidenAnimation();
            DevExpress.XtraCharts.BubbleSeriesLabel bubbleSeriesLabel2 = new DevExpress.XtraCharts.BubbleSeriesLabel();
            DevExpress.XtraCharts.BubbleSeriesView bubbleSeriesView2 = new DevExpress.XtraCharts.BubbleSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.lblMarkerKind = new DevExpress.XtraEditors.LabelControl();
            this.lblLabelPosition = new DevExpress.XtraEditors.LabelControl();
            this.lblMaxSize = new DevExpress.XtraEditors.LabelControl();
            this.lblMinSize = new DevExpress.XtraEditors.LabelControl();
            this.speMinSize = new DevExpress.XtraEditors.SpinEdit();
            this.speMaxSize = new DevExpress.XtraEditors.SpinEdit();
            this.cbeLabelPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbeMarkerKind = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbeTransparency = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblTransparency = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speMinSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speMaxSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLabelPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeMarkerKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeTransparency.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cbeTransparency);
            this.panel.Controls.Add(this.lblTransparency);
            this.panel.Controls.Add(this.cbeMarkerKind);
            this.panel.Controls.Add(this.lblMarkerKind);
            this.panel.Controls.Add(this.speMaxSize);
            this.panel.Controls.Add(this.cbeLabelPosition);
            this.panel.Controls.Add(this.speMinSize);
            this.panel.Controls.Add(this.lblMinSize);
            this.panel.Controls.Add(this.lblMaxSize);
            this.panel.Controls.Add(this.lblLabelPosition);
            this.panel.Controls.SetChildIndex(this.lblLabelPosition, 0);
            this.panel.Controls.SetChildIndex(this.lblMaxSize, 0);
            this.panel.Controls.SetChildIndex(this.lblMinSize, 0);
            this.panel.Controls.SetChildIndex(this.speMinSize, 0);
            this.panel.Controls.SetChildIndex(this.cbeLabelPosition, 0);
            this.panel.Controls.SetChildIndex(this.speMaxSize, 0);
            this.panel.Controls.SetChildIndex(this.lblMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.cbeMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.lblTransparency, 0);
            this.panel.Controls.SetChildIndex(this.cbeTransparency, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None;
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Interlaced = true;
            xyDiagram1.AxisX.Label.TextPattern = "{A:yyyy}";
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.Title.Text = "Year";
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "01/01/2016 00:00:00.000";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "01/01/2007 00:00:00.000";
            xyDiagram1.AxisX.VisualRange.SideMarginsValue = 0.7D;
            xyDiagram1.AxisX.WholeRange.Auto = false;
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "01/01/2016 00:00:00.000";
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "01/01/2007 00:00:00.000";
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0.8D;
            xyDiagram1.AxisY.Label.TextPattern = "${V}M";
            xyDiagram1.AxisY.Title.Text = "Production Budget";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisualRange.Auto = false;
            xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "310";
            xyDiagram1.AxisY.VisualRange.MinValueSerializable = "130";
            xyDiagram1.AxisY.WholeRange.Auto = false;
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "370";
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "Year";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            bubbleSeriesLabel1.TextPattern = "${W}B";
            series1.Label = bubbleSeriesLabel1;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Top 10 Films by Worldwide Grosses ";
            series1.ValueDataMembersSerializable = "Budget;Grosses";
            bubbleSeriesView1.AutoSize = false;
            bubbleSeriesView1.ColorEach = true;
            bubbleSeriesView1.MaxSize = 2.7D;
            bubbleSeriesView1.MinSize = 0.8D;
            xyMarkerWidenAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000");
            xyMarkerWidenAnimation1.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random;
            bubbleSeriesView1.SeriesPointAnimation = xyMarkerWidenAnimation1;
            series1.View = bubbleSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            bubbleSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.Label = bubbleSeriesLabel2;
            this.chart.SeriesTemplate.View = bubbleSeriesView2;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 2;
            chartTitle1.Text = "Highest-Grossing Films by Year";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.boxofficemojo.com";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            this.chart.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.chart_CustomDrawSeriesPoint);
            // 
            // lblMarkerKind
            // 
            this.lblMarkerKind.Location = new System.Drawing.Point(13, 40);
            this.lblMarkerKind.Name = "lblMarkerKind";
            this.lblMarkerKind.Size = new System.Drawing.Size(60, 13);
            this.lblMarkerKind.TabIndex = 2;
            this.lblMarkerKind.Text = "Marker Kind:";
            // 
            // lblLabelPosition
            // 
            this.lblLabelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabelPosition.Location = new System.Drawing.Point(550, 12);
            this.lblLabelPosition.Name = "lblLabelPosition";
            this.lblLabelPosition.Size = new System.Drawing.Size(69, 13);
            this.lblLabelPosition.TabIndex = 3;
            this.lblLabelPosition.Text = "Label Position:";
            // 
            // lblMaxSize
            // 
            this.lblMaxSize.Location = new System.Drawing.Point(207, 12);
            this.lblMaxSize.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.lblMaxSize.Name = "lblMaxSize";
            this.lblMaxSize.Size = new System.Drawing.Size(81, 13);
            this.lblMaxSize.TabIndex = 4;
            this.lblMaxSize.Text = "Max Bubble Size:";
            // 
            // lblMinSize
            // 
            this.lblMinSize.Location = new System.Drawing.Point(207, 40);
            this.lblMinSize.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.lblMinSize.Name = "lblMinSize";
            this.lblMinSize.Size = new System.Drawing.Size(77, 13);
            this.lblMinSize.TabIndex = 5;
            this.lblMinSize.Text = "Min Bubble Size:";
            // 
            // speMinSize
            // 
            this.speMinSize.EditValue = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.speMinSize.Location = new System.Drawing.Point(294, 37);
            this.speMinSize.Name = "speMinSize";
            this.speMinSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.speMinSize.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.speMinSize.Properties.MaxValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.speMinSize.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.speMinSize.Properties.ValidateOnEnterKey = true;
            this.speMinSize.Size = new System.Drawing.Size(54, 20);
            this.speMinSize.TabIndex = 6;
            this.speMinSize.EditValueChanged += new System.EventHandler(this.speMinSize_EditValueChanged);
            this.speMinSize.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.speMinSize_EditValueChanging);
            // 
            // speMaxSize
            // 
            this.speMaxSize.EditValue = new decimal(new int[] {
            27,
            0,
            0,
            65536});
            this.speMaxSize.Location = new System.Drawing.Point(294, 9);
            this.speMaxSize.Name = "speMaxSize";
            this.speMaxSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.speMaxSize.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.speMaxSize.Properties.MaxValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.speMaxSize.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.speMaxSize.Properties.ValidateOnEnterKey = true;
            this.speMaxSize.Size = new System.Drawing.Size(54, 20);
            this.speMaxSize.TabIndex = 7;
            this.speMaxSize.EditValueChanged += new System.EventHandler(this.speMaxSize_EditValueChanged);
            this.speMaxSize.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.speMaxSize_EditValueChanging);
            // 
            // cbeLabelPosition
            // 
            this.cbeLabelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbeLabelPosition.Location = new System.Drawing.Point(625, 9);
            this.cbeLabelPosition.Name = "cbeLabelPosition";
            this.cbeLabelPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeLabelPosition.Properties.Items.AddRange(new object[] {
            "Center",
            "Outside"});
            this.cbeLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeLabelPosition.Size = new System.Drawing.Size(60, 20);
            this.cbeLabelPosition.TabIndex = 8;
            this.cbeLabelPosition.SelectedIndexChanged += new System.EventHandler(this.cbeLabelPosition_SelectedIndexChanged);
            // 
            // cbeMarkerKind
            // 
            this.cbeMarkerKind.Location = new System.Drawing.Point(88, 37);
            this.cbeMarkerKind.Name = "cbeMarkerKind";
            this.cbeMarkerKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeMarkerKind.Size = new System.Drawing.Size(110, 20);
            this.cbeMarkerKind.TabIndex = 9;
            this.cbeMarkerKind.SelectedIndexChanged += new System.EventHandler(this.cbeMarkerKind_SelectedIndexChanged);
            // 
            // cbeTransparency
            // 
            this.cbeTransparency.Location = new System.Drawing.Point(88, 9);
            this.cbeTransparency.Name = "cbeTransparency";
            this.cbeTransparency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeTransparency.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeTransparency.Size = new System.Drawing.Size(110, 20);
            this.cbeTransparency.TabIndex = 11;
            this.cbeTransparency.SelectedIndexChanged += new System.EventHandler(this.cbeTransparency_SelectedIndexChanged);
            // 
            // lblTransparency
            // 
            this.lblTransparency.Location = new System.Drawing.Point(13, 12);
            this.lblTransparency.Name = "lblTransparency";
            this.lblTransparency.Size = new System.Drawing.Size(70, 13);
            this.lblTransparency.TabIndex = 10;
            this.lblTransparency.Text = "Transparency:";
            // 
            // BubbleDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "BubbleDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speMinSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speMaxSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLabelPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeMarkerKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeTransparency.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.XtraEditors.ComboBoxEdit cbeMarkerKind;
        private DevExpress.XtraEditors.ComboBoxEdit cbeLabelPosition;
        private DevExpress.XtraEditors.SpinEdit speMinSize;
        private DevExpress.XtraEditors.SpinEdit speMaxSize;
        private DevExpress.XtraEditors.LabelControl lblMinSize;
        private DevExpress.XtraEditors.LabelControl lblMaxSize;
        private DevExpress.XtraEditors.LabelControl lblMarkerKind;
        private DevExpress.XtraEditors.LabelControl lblLabelPosition;
        private DevExpress.XtraEditors.ComboBoxEdit cbeTransparency;
        private DevExpress.XtraEditors.LabelControl lblTransparency;
    }
}
