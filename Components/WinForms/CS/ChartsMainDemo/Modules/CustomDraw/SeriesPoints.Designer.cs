namespace DevExpress.XtraCharts.Demos.CustomDraw {
    partial class SeriesPointsDemo {
        protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

        #region Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Strip strip1 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.RectangleGradientFillOptions rectangleGradientFillOptions1 = new DevExpress.XtraCharts.RectangleGradientFillOptions();
            DevExpress.XtraCharts.Strip strip2 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.RectangleGradientFillOptions rectangleGradientFillOptions2 = new DevExpress.XtraCharts.RectangleGradientFillOptions();
            DevExpress.XtraCharts.Strip strip3 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.RectangleGradientFillOptions rectangleGradientFillOptions3 = new DevExpress.XtraCharts.RectangleGradientFillOptions();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.BarSlideAnimation barSlideAnimation1 = new DevExpress.XtraCharts.BarSlideAnimation();
            DevExpress.XtraCharts.BounceEasingFunction bounceEasingFunction1 = new DevExpress.XtraCharts.BounceEasingFunction();
            DevExpress.XtraCharts.RectangleGradientFillOptions rectangleGradientFillOptions4 = new DevExpress.XtraCharts.RectangleGradientFillOptions();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.simpleButtonRandom = new DevExpress.XtraEditors.SimpleButton();
            this.checkEditCustomDraw = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditCustomDraw.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.checkEditCustomDraw);
            this.panel.Controls.Add(this.simpleButtonRandom);
            this.panel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.simpleButtonRandom, 0);
            this.panel.Controls.SetChildIndex(this.checkEditCustomDraw, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 3;
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
            strip1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            strip1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient;
            rectangleGradientFillOptions1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            rectangleGradientFillOptions1.GradientMode = DevExpress.XtraCharts.RectangleGradientMode.BottomToTop;
            strip1.FillStyle.Options = rectangleGradientFillOptions1;
            strip1.MaxLimit.AxisValueSerializable = "3";
            strip1.MinLimit.AxisValueSerializable = "2";
            strip1.Name = "High";
            strip1.ShowAxisLabel = true;
            strip2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(113)))));
            strip2.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient;
            rectangleGradientFillOptions2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(190)))));
            rectangleGradientFillOptions2.GradientMode = DevExpress.XtraCharts.RectangleGradientMode.BottomToTop;
            strip2.FillStyle.Options = rectangleGradientFillOptions2;
            strip2.MaxLimit.AxisValueSerializable = "2";
            strip2.MinLimit.AxisValueSerializable = "1";
            strip2.Name = "Middle";
            strip2.ShowAxisLabel = true;
            strip3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(227)))), ((int)(((byte)(125)))));
            strip3.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient;
            rectangleGradientFillOptions3.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(243)))), ((int)(((byte)(159)))));
            rectangleGradientFillOptions3.GradientMode = DevExpress.XtraCharts.RectangleGradientMode.BottomToTop;
            strip3.FillStyle.Options = rectangleGradientFillOptions3;
            strip3.MaxLimit.AxisValueSerializable = "1";
            strip3.MinLimit.AxisValueSerializable = "0";
            strip3.Name = "Low";
            strip3.ShowAxisLabel = true;
            xyDiagram1.AxisY.Strips.AddRange(new DevExpress.XtraCharts.Strip[] {
            strip1,
            strip2,
            strip3});
            xyDiagram1.AxisY.Title.Text = "Values";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisualRange.Auto = false;
            xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "3";
            xyDiagram1.AxisY.VisualRange.MinValueSerializable = "0";
            xyDiagram1.AxisY.WholeRange.Auto = false;
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "3";
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0";
            xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0D;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            sideBySideBarSeriesLabel1.TextPattern = "{V:F1}";
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "Series 1";
            barSlideAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromTop;
            bounceEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out;
            barSlideAnimation1.EasingFunction = bounceEasingFunction1;
            barSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.0500000");
            barSlideAnimation1.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random;
            sideBySideBarSeriesView1.Animation = barSlideAnimation1;
            sideBySideBarSeriesView1.Color = System.Drawing.Color.DodgerBlue;
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient;
            rectangleGradientFillOptions4.GradientMode = DevExpress.XtraCharts.RectangleGradientMode.RightToLeft;
            sideBySideBarSeriesView1.FillStyle.Options = rectangleGradientFillOptions4;
            series1.View = sideBySideBarSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            this.chart.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.chart_CustomDrawSeriesPoint);
            // 
            // simpleButtonRandom
            // 
            this.simpleButtonRandom.Location = new System.Drawing.Point(12, 8);
            this.simpleButtonRandom.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.simpleButtonRandom.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.simpleButtonRandom.Name = "simpleButtonRandom";
            this.simpleButtonRandom.Size = new System.Drawing.Size(85, 22);
            this.simpleButtonRandom.TabIndex = 0;
            this.simpleButtonRandom.Text = "Create Bars";
            this.simpleButtonRandom.Click += new System.EventHandler(this.simpleButtonRandom_Click);
            // 
            // checkEditCustomDraw
            // 
            this.checkEditCustomDraw.Location = new System.Drawing.Point(120, 9);
            this.checkEditCustomDraw.Margin = new System.Windows.Forms.Padding(10);
            this.checkEditCustomDraw.Name = "checkEditCustomDraw";
            this.checkEditCustomDraw.Properties.Caption = "Custom Draw";
            this.checkEditCustomDraw.Size = new System.Drawing.Size(98, 19);
            this.checkEditCustomDraw.TabIndex = 1;
            this.checkEditCustomDraw.CheckedChanged += new System.EventHandler(this.checkEditCustomDraw_CheckedChanged);
            // 
            // SeriesPointsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "SeriesPointsDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(strip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(strip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(strip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditCustomDraw.Properties)).EndInit();
            this.ResumeLayout(false);

		}
        #endregion

        private DevExpress.XtraCharts.ChartControl chart;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRandom;
        private DevExpress.XtraEditors.CheckEdit checkEditCustomDraw;
        private System.ComponentModel.IContainer components = null;

    }
}
