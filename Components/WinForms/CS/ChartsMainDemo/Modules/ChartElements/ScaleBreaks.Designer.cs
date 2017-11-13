namespace DevExpress.XtraCharts.Demos.ChartElements {
    partial class ScaleBreaksDemo {
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint9 = new DevExpress.XtraCharts.SeriesPoint("Mercury", new object[] {
            ((object)(0.06D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint10 = new DevExpress.XtraCharts.SeriesPoint("Venus", new object[] {
            ((object)(0.82D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint11 = new DevExpress.XtraCharts.SeriesPoint("Earth", new object[] {
            ((object)(1D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint12 = new DevExpress.XtraCharts.SeriesPoint("Mars", new object[] {
            ((object)(0.11D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint13 = new DevExpress.XtraCharts.SeriesPoint("Jupiter", new object[] {
            ((object)(318D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint14 = new DevExpress.XtraCharts.SeriesPoint("Saturn", new object[] {
            ((object)(95D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint15 = new DevExpress.XtraCharts.SeriesPoint("Uranus", new object[] {
            ((object)(14.6D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint16 = new DevExpress.XtraCharts.SeriesPoint("Neptune", new object[] {
            ((object)(17.2D))});
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.BarSlideAnimation barSlideAnimation2 = new DevExpress.XtraCharts.BarSlideAnimation();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.chEnableScaleBreaks = new DevExpress.XtraEditors.CheckEdit();
            this.lblStyle = new DevExpress.XtraEditors.LabelControl();
            this.cbStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSize = new DevExpress.XtraEditors.LabelControl();
            this.spnSize = new DevExpress.XtraEditors.SpinEdit();
            this.lblColor = new DevExpress.XtraEditors.LabelControl();
            this.ceColor = new DevExpress.XtraEditors.ColorEdit();
            this.btnResetColor = new DevExpress.XtraEditors.SimpleButton();
            this.spnMaxCount = new DevExpress.XtraEditors.SpinEdit();
            this.lblMaxCount = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEnableScaleBreaks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxCount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chEnableScaleBreaks);
            this.panel.Controls.Add(this.lblStyle);
            this.panel.Controls.Add(this.lblSize);
            this.panel.Controls.Add(this.lblMaxCount);
            this.panel.Controls.Add(this.spnMaxCount);
            this.panel.Controls.Add(this.spnSize);
            this.panel.Controls.Add(this.ceColor);
            this.panel.Controls.Add(this.lblColor);
            this.panel.Controls.Add(this.btnResetColor);
            this.panel.Controls.Add(this.cbStyle);
            this.panel.Controls.SetChildIndex(this.cbStyle, 0);
            this.panel.Controls.SetChildIndex(this.btnResetColor, 0);
            this.panel.Controls.SetChildIndex(this.lblColor, 0);
            this.panel.Controls.SetChildIndex(this.ceColor, 0);
            this.panel.Controls.SetChildIndex(this.spnSize, 0);
            this.panel.Controls.SetChildIndex(this.spnMaxCount, 0);
            this.panel.Controls.SetChildIndex(this.lblMaxCount, 0);
            this.panel.Controls.SetChildIndex(this.lblSize, 0);
            this.panel.Controls.SetChildIndex(this.lblStyle, 0);
            this.panel.Controls.SetChildIndex(this.chEnableScaleBreaks, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 6;
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            xyDiagram2.AxisX.Title.Text = "Planets";
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.AutoScaleBreaks.Enabled = true;
            xyDiagram2.AxisY.AutoScaleBreaks.MaxCount = 4;
            xyDiagram2.AxisY.Interlaced = true;
            xyDiagram2.AxisY.Title.Text = "Mass (Earth\'s)";
            xyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram2;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            series2.LegendTextPattern = "{A}: {V}";
            series2.Name = "Series 1";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint9,
            seriesPoint10,
            seriesPoint11,
            seriesPoint12,
            seriesPoint13,
            seriesPoint14,
            seriesPoint15,
            seriesPoint16});
            barSlideAnimation2.PointDelay = System.TimeSpan.Parse("00:00:00.1000000");
            barSlideAnimation2.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Inverted;
            sideBySideBarSeriesView2.Animation = barSlideAnimation2;
            sideBySideBarSeriesView2.ColorEach = true;
            series2.View = sideBySideBarSeriesView2;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 2;
            chartTitle2.Text = "Mass of Planets in the Solar System";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // chEnableScaleBreaks
            // 
            this.chEnableScaleBreaks.EditValue = true;
            this.chEnableScaleBreaks.Location = new System.Drawing.Point(12, 9);
            this.chEnableScaleBreaks.Name = "chEnableScaleBreaks";
            this.chEnableScaleBreaks.Properties.Caption = "Show Scale Breaks";
            this.chEnableScaleBreaks.Size = new System.Drawing.Size(112, 19);
            this.chEnableScaleBreaks.TabIndex = 0;
            this.chEnableScaleBreaks.CheckedChanged += new System.EventHandler(this.chEnableScaleBreaks_CheckedChanged);
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStyle.Location = new System.Drawing.Point(151, 8);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(28, 20);
            this.lblStyle.TabIndex = 3;
            this.lblStyle.Text = "Style:";
            // 
            // cbStyle
            // 
            this.cbStyle.Location = new System.Drawing.Point(185, 9);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStyle.Properties.Items.AddRange(new object[] {
            "Straight",
            "Ragged",
            "Waved"});
            this.cbStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbStyle.Size = new System.Drawing.Size(78, 20);
            this.cbStyle.TabIndex = 2;
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSize.Location = new System.Drawing.Point(151, 36);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(23, 20);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size:";
            // 
            // spnSize
            // 
            this.spnSize.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSize.Location = new System.Drawing.Point(185, 37);
            this.spnSize.Name = "spnSize";
            this.spnSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnSize.Properties.IsFloatValue = false;
            this.spnSize.Properties.Mask.EditMask = "N00";
            this.spnSize.Properties.MaxValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spnSize.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.spnSize.Properties.ValidateOnEnterKey = true;
            this.spnSize.Size = new System.Drawing.Size(78, 20);
            this.spnSize.TabIndex = 3;
            this.spnSize.EditValueChanged += new System.EventHandler(this.spnSize_EditValueChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblColor.Location = new System.Drawing.Point(287, 8);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(29, 20);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color:";
            // 
            // ceColor
            // 
            this.ceColor.EditValue = System.Drawing.Color.Empty;
            this.ceColor.Location = new System.Drawing.Point(322, 9);
            this.ceColor.Name = "ceColor";
            this.ceColor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ceColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceColor.Size = new System.Drawing.Size(115, 20);
            this.ceColor.TabIndex = 4;
            this.ceColor.EditValueChanged += new System.EventHandler(this.ceColor_EditValueChanged);
            // 
            // btnResetColor
            // 
            this.btnResetColor.Location = new System.Drawing.Point(287, 37);
            this.btnResetColor.Name = "btnResetColor";
            this.btnResetColor.Size = new System.Drawing.Size(150, 20);
            this.btnResetColor.TabIndex = 5;
            this.btnResetColor.Text = "Restore Default Color";
            this.btnResetColor.Click += new System.EventHandler(this.btnResetColor_Click);
            // 
            // spnMaxCount
            // 
            this.spnMaxCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnMaxCount.Location = new System.Drawing.Point(77, 37);
            this.spnMaxCount.Name = "spnMaxCount";
            this.spnMaxCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnMaxCount.Properties.IsFloatValue = false;
            this.spnMaxCount.Properties.Mask.EditMask = "N00";
            this.spnMaxCount.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spnMaxCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnMaxCount.Properties.ValidateOnEnterKey = true;
            this.spnMaxCount.Size = new System.Drawing.Size(47, 20);
            this.spnMaxCount.TabIndex = 1;
            this.spnMaxCount.EditValueChanged += new System.EventHandler(this.spnMaxCount_EditValueChanged);
            // 
            // lblMaxCount
            // 
            this.lblMaxCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMaxCount.Location = new System.Drawing.Point(15, 39);
            this.lblMaxCount.Name = "lblMaxCount";
            this.lblMaxCount.Size = new System.Drawing.Size(56, 14);
            this.lblMaxCount.TabIndex = 3;
            this.lblMaxCount.Text = "Max Count:";
            // 
            // ScaleBreaksDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "ScaleBreaksDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEnableScaleBreaks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxCount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.XtraEditors.CheckEdit chEnableScaleBreaks;
        private DevExpress.XtraEditors.LabelControl lblStyle;
        private DevExpress.XtraEditors.ComboBoxEdit cbStyle;
        private DevExpress.XtraEditors.LabelControl lblSize;
        private DevExpress.XtraEditors.SpinEdit spnSize;
        private DevExpress.XtraEditors.ColorEdit ceColor;
        private DevExpress.XtraEditors.LabelControl lblColor;
        private DevExpress.XtraEditors.SimpleButton btnResetColor;
        private DevExpress.XtraEditors.LabelControl lblMaxCount;
        private DevExpress.XtraEditors.SpinEdit spnMaxCount;
    }
}
