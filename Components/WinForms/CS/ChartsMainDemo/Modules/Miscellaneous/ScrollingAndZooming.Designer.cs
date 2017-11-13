namespace DevExpress.XtraCharts.Demos.Miscellaneous {
	partial class ScrollingAndZoomingDemo {
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.StepLineSeriesView stepLineSeriesView1 = new DevExpress.XtraCharts.StepLineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.btnRestoreView = new DevExpress.XtraEditors.SimpleButton();
            this.lblHorizontal = new DevExpress.XtraEditors.LabelControl();
            this.lblVertical = new DevExpress.XtraEditors.LabelControl();
            this.cbVertAlign = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbHorAlign = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbEnableAxisYScrolling = new DevExpress.XtraEditors.CheckEdit();
            this.cbEnableAxisYZooming = new DevExpress.XtraEditors.CheckEdit();
            this.cbEnableAxisXScrolling = new DevExpress.XtraEditors.CheckEdit();
            this.cbEnableAxisXZooming = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stepLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVertAlign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHorAlign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEnableAxisYScrolling.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEnableAxisYZooming.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEnableAxisXScrolling.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEnableAxisXZooming.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblHorizontal);
            this.panel.Controls.Add(this.lblVertical);
            this.panel.Controls.Add(this.cbEnableAxisYZooming);
            this.panel.Controls.Add(this.cbEnableAxisXZooming);
            this.panel.Controls.Add(this.cbVertAlign);
            this.panel.Controls.Add(this.cbEnableAxisYScrolling);
            this.panel.Controls.Add(this.cbHorAlign);
            this.panel.Controls.Add(this.cbEnableAxisXScrolling);
            this.panel.Controls.Add(this.btnRestoreView);
            this.panel.Controls.SetChildIndex(this.btnRestoreView, 0);
            this.panel.Controls.SetChildIndex(this.cbEnableAxisXScrolling, 0);
            this.panel.Controls.SetChildIndex(this.cbHorAlign, 0);
            this.panel.Controls.SetChildIndex(this.cbEnableAxisYScrolling, 0);
            this.panel.Controls.SetChildIndex(this.cbVertAlign, 0);
            this.panel.Controls.SetChildIndex(this.cbEnableAxisXZooming, 0);
            this.panel.Controls.SetChildIndex(this.cbEnableAxisYZooming, 0);
            this.panel.Controls.SetChildIndex(this.lblVertical, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.lblHorizontal, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 6;
            this.checkEditShowLabels.Visible = false;
            // 
            // chart
            // 
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Title.Text = "Year";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.Title.Text = "$ per Thousand Cubic Feet";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisualRange.Auto = false;
            xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "6";
            xyDiagram1.AxisY.VisualRange.MinValueSerializable = "2.25";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            xyDiagram1.EnableAxisYScrolling = true;
            xyDiagram1.EnableAxisYZooming = true;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "Date";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.Name = "Natural Gas Price";
            series1.ValueDataMembersSerializable = "Price";
            series1.View = lineSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pointSeriesLabel1.TextPattern = "{V:G2}";
            this.chart.SeriesTemplate.Label = pointSeriesLabel1;
            this.chart.SeriesTemplate.View = stepLineSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            chartTitle1.Text = "Price of Liquefied U.S. Natural Gas Exports";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.quandl.com";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // btnRestoreView
            // 
            this.btnRestoreView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreView.Location = new System.Drawing.Point(552, 24);
            this.btnRestoreView.Margin = new System.Windows.Forms.Padding(10);
            this.btnRestoreView.Name = "btnRestoreView";
            this.btnRestoreView.Size = new System.Drawing.Size(138, 22);
            this.btnRestoreView.TabIndex = 4;
            this.btnRestoreView.Text = "Restore Default Position";
            this.btnRestoreView.Click += new System.EventHandler(this.btnRestoreView_Click);
            // 
            // lblHorizontal
            // 
            this.lblHorizontal.Location = new System.Drawing.Point(229, 12);
            this.lblHorizontal.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblHorizontal.Name = "lblHorizontal";
            this.lblHorizontal.Size = new System.Drawing.Size(99, 13);
            this.lblHorizontal.TabIndex = 16;
            this.lblHorizontal.Text = "Horizontal Scroll Bar:";
            // 
            // lblVertical
            // 
            this.lblVertical.Location = new System.Drawing.Point(229, 40);
            this.lblVertical.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblVertical.Name = "lblVertical";
            this.lblVertical.Size = new System.Drawing.Size(86, 13);
            this.lblVertical.TabIndex = 15;
            this.lblVertical.Text = "Vertical Scroll Bar:";
            // 
            // cbVertAlign
            // 
            this.cbVertAlign.EditValue = "";
            this.cbVertAlign.Location = new System.Drawing.Point(335, 37);
            this.cbVertAlign.Margin = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.cbVertAlign.Name = "cbVertAlign";
            this.cbVertAlign.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVertAlign.Properties.Items.AddRange(new object[] {
            "Near",
            "Far"});
            this.cbVertAlign.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbVertAlign.Size = new System.Drawing.Size(56, 20);
            this.cbVertAlign.TabIndex = 14;
            this.cbVertAlign.SelectedIndexChanged += new System.EventHandler(this.cbVertAlign_SelectedIndexChanged);
            // 
            // cbHorAlign
            // 
            this.cbHorAlign.EditValue = "";
            this.cbHorAlign.Location = new System.Drawing.Point(335, 9);
            this.cbHorAlign.Margin = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.cbHorAlign.Name = "cbHorAlign";
            this.cbHorAlign.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbHorAlign.Properties.Items.AddRange(new object[] {
            "Near",
            "Far"});
            this.cbHorAlign.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbHorAlign.Size = new System.Drawing.Size(56, 20);
            this.cbHorAlign.TabIndex = 13;
            this.cbHorAlign.SelectedIndexChanged += new System.EventHandler(this.cbHorAlign_SelectedIndexChanged);
            // 
            // cbEnableAxisYScrolling
            // 
            this.cbEnableAxisYScrolling.Location = new System.Drawing.Point(12, 37);
            this.cbEnableAxisYScrolling.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.cbEnableAxisYScrolling.Name = "cbEnableAxisYScrolling";
            this.cbEnableAxisYScrolling.Properties.AutoWidth = true;
            this.cbEnableAxisYScrolling.Properties.Caption = "Y-axis Scrolling";
            this.cbEnableAxisYScrolling.Size = new System.Drawing.Size(93, 19);
            this.cbEnableAxisYScrolling.TabIndex = 2;
            this.cbEnableAxisYScrolling.CheckedChanged += new System.EventHandler(this.cbEnableAxisYScrolling_CheckedChanged);
            // 
            // cbEnableAxisYZooming
            // 
            this.cbEnableAxisYZooming.Location = new System.Drawing.Point(118, 37);
            this.cbEnableAxisYZooming.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.cbEnableAxisYZooming.Name = "cbEnableAxisYZooming";
            this.cbEnableAxisYZooming.Properties.AutoWidth = true;
            this.cbEnableAxisYZooming.Properties.Caption = "Y-axis Zooming";
            this.cbEnableAxisYZooming.Size = new System.Drawing.Size(94, 19);
            this.cbEnableAxisYZooming.TabIndex = 3;
            this.cbEnableAxisYZooming.CheckedChanged += new System.EventHandler(this.cbEnableAxisYZooming_CheckedChanged);
            // 
            // cbEnableAxisXScrolling
            // 
            this.cbEnableAxisXScrolling.Location = new System.Drawing.Point(12, 9);
            this.cbEnableAxisXScrolling.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.cbEnableAxisXScrolling.Name = "cbEnableAxisXScrolling";
            this.cbEnableAxisXScrolling.Properties.AutoWidth = true;
            this.cbEnableAxisXScrolling.Properties.Caption = "X-axis Scrolling";
            this.cbEnableAxisXScrolling.Size = new System.Drawing.Size(93, 19);
            this.cbEnableAxisXScrolling.TabIndex = 2;
            this.cbEnableAxisXScrolling.CheckedChanged += new System.EventHandler(this.cbEnableAxisXScrolling_CheckedChanged);
            // 
            // cbEnableAxisXZooming
            // 
            this.cbEnableAxisXZooming.Location = new System.Drawing.Point(118, 9);
            this.cbEnableAxisXZooming.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.cbEnableAxisXZooming.Name = "cbEnableAxisXZooming";
            this.cbEnableAxisXZooming.Properties.AutoWidth = true;
            this.cbEnableAxisXZooming.Properties.Caption = "X-axis Zooming";
            this.cbEnableAxisXZooming.Size = new System.Drawing.Size(94, 19);
            this.cbEnableAxisXZooming.TabIndex = 3;
            this.cbEnableAxisXZooming.CheckedChanged += new System.EventHandler(this.cbEnableAxisXZooming_CheckedChanged);
            // 
            // ScrollingAndZoomingDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "ScrollingAndZoomingDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stepLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVertAlign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHorAlign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEnableAxisYScrolling.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEnableAxisYZooming.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEnableAxisXScrolling.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEnableAxisXZooming.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.SimpleButton btnRestoreView;
        private DevExpress.XtraEditors.LabelControl lblHorizontal;
        private DevExpress.XtraEditors.LabelControl lblVertical;
        private DevExpress.XtraEditors.ComboBoxEdit cbVertAlign;
        private DevExpress.XtraEditors.ComboBoxEdit cbHorAlign;
        private DevExpress.XtraEditors.CheckEdit cbEnableAxisYZooming;
        private DevExpress.XtraEditors.CheckEdit cbEnableAxisXZooming;
        private DevExpress.XtraEditors.CheckEdit cbEnableAxisYScrolling;
        private DevExpress.XtraEditors.CheckEdit cbEnableAxisXScrolling;
	}
}
