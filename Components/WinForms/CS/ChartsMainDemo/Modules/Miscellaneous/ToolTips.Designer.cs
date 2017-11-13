namespace DevExpress.XtraCharts.Demos.Miscellaneous {
	partial class ToolTipsDemo {
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.BarWidenAnimation barWidenAnimation1 = new DevExpress.XtraCharts.BarWidenAnimation();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.lblToolTipPosition = new DevExpress.XtraEditors.LabelControl();
            this.cbToolTipPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.defaultToolTipController = new DevExpress.Utils.DefaultToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbToolTipPosition.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.defaultToolTipController.SetAllowHtmlText(this.panel, DevExpress.Utils.DefaultBoolean.Default);
            this.panel.Controls.Add(this.lblToolTipPosition);
            this.panel.Controls.Add(this.cbToolTipPosition);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.cbToolTipPosition, 0);
            this.panel.Controls.SetChildIndex(this.lblToolTipPosition, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 4;
            this.checkEditShowLabels.Visible = false;
            // 
            // panelRoot
            // 
            this.defaultToolTipController.SetAllowHtmlText(this.panelRoot, DevExpress.Utils.DefaultBoolean.Default);
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Interlaced = true;
            xyDiagram1.AxisX.MinorCount = 7;
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "2015";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "2000";
            xyDiagram1.AxisX.WholeRange.Auto = false;
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "2015";
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "2000";
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Label.TextPattern = "{V:N0}";
            xyDiagram1.AxisY.Title.Text = "";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "CountryName";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "G7 GDP in 2015";
            series1.ValueDataMembersSerializable = "GDPin2015";
            barWidenAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000");
            sideBySideBarSeriesView1.Animation = barWidenAnimation1;
            sideBySideBarSeriesView1.ColorEach = true;
            series1.View = sideBySideBarSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Text = "G7 GDP in 2015, in Billions of US$";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "The World Bank: GDP (current US$)";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            this.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            // 
            // lblToolTipPosition
            // 
            this.lblToolTipPosition.Location = new System.Drawing.Point(12, 12);
            this.lblToolTipPosition.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.lblToolTipPosition.Name = "lblToolTipPosition";
            this.lblToolTipPosition.Size = new System.Drawing.Size(81, 13);
            this.lblToolTipPosition.TabIndex = 60;
            this.lblToolTipPosition.Text = "Tool Tip Position:";
            // 
            // cbToolTipPosition
            // 
            this.cbToolTipPosition.EditValue = "Mouse Pointer";
            this.cbToolTipPosition.Location = new System.Drawing.Point(96, 9);
            this.cbToolTipPosition.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.cbToolTipPosition.Name = "cbToolTipPosition";
            this.cbToolTipPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbToolTipPosition.Properties.Items.AddRange(new object[] {
            "Mouse Pointer",
            "Relative",
            "Free"});
            this.cbToolTipPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbToolTipPosition.Size = new System.Drawing.Size(141, 20);
            this.cbToolTipPosition.TabIndex = 0;
            this.cbToolTipPosition.SelectedIndexChanged += new System.EventHandler(this.cbToolTipPosition_SelectedIndexChanged);
            // 
            // defaultToolTipController
            // 
            // 
            // 
            // 
            this.defaultToolTipController.DefaultController.AppearanceTitle.Options.UseTextOptions = true;
            this.defaultToolTipController.DefaultController.AppearanceTitle.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.defaultToolTipController.DefaultController.AppearanceTitle.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.defaultToolTipController.DefaultController.AutoPopDelay = 90000;
            this.defaultToolTipController.DefaultController.Rounded = true;
            this.defaultToolTipController.DefaultController.ShowBeak = true;
            this.defaultToolTipController.DefaultController.ShowShadow = false;
            this.defaultToolTipController.DefaultController.ToolTipLocation = DevExpress.Utils.ToolTipLocation.TopRight;
            this.defaultToolTipController.DefaultController.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.defaultToolTipController_DefaultController_BeforeShow);
            // 
            // ToolTipsDemo
            // 
            this.defaultToolTipController.SetAllowHtmlText(this, DevExpress.Utils.DefaultBoolean.Default);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "ToolTipsDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbToolTipPosition.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl lblToolTipPosition;
        private DevExpress.XtraEditors.ComboBoxEdit cbToolTipPosition;
        private DevExpress.Utils.DefaultToolTipController defaultToolTipController;

	}
}
