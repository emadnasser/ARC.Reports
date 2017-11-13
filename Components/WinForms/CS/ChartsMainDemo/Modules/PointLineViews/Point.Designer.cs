namespace DevExpress.XtraCharts.Demos.PointLineViews {
	partial class PointDemo {
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
            DevExpress.XtraCharts.XYDiagram xyDiagram4 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series10 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel10 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView10 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.XYMarkerWidenAnimation xyMarkerWidenAnimation10 = new DevExpress.XtraCharts.XYMarkerWidenAnimation();
            DevExpress.XtraCharts.Series series11 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel11 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView11 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.XYMarkerWidenAnimation xyMarkerWidenAnimation11 = new DevExpress.XtraCharts.XYMarkerWidenAnimation();
            DevExpress.XtraCharts.Series series12 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel12 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView12 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.XYMarkerWidenAnimation xyMarkerWidenAnimation12 = new DevExpress.XtraCharts.XYMarkerWidenAnimation();
            DevExpress.XtraCharts.ChartTitle chartTitle4 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.simpleButtonRandom = new DevExpress.XtraEditors.SimpleButton();
            this.cbeLabelPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblLabelPosition = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelAngle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLabelPosition.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEditMarkerKind
            // 
            this.comboBoxEditMarkerKind.TabIndex = 1;
            // 
            // comboBoxEditLabelAngle
            // 
            this.comboBoxEditLabelAngle.Size = new System.Drawing.Size(72, 20);
            this.comboBoxEditLabelAngle.TabIndex = 3;
            // 
            // comboBoxEditMarkerSize
            // 
            this.comboBoxEditMarkerSize.TabIndex = 2;
            // 
            // labelMarkerKind
            // 
            this.labelMarkerKind.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            // 
            // labelMarkerSize
            // 
            this.labelMarkerSize.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cbeLabelPosition);
            this.panel.Controls.Add(this.lblLabelPosition);
            this.panel.Controls.Add(this.simpleButtonRandom);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditLabelAngle, 0);
            this.panel.Controls.SetChildIndex(this.labelAngle, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.simpleButtonRandom, 0);
            this.panel.Controls.SetChildIndex(this.lblLabelPosition, 0);
            this.panel.Controls.SetChildIndex(this.cbeLabelPosition, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.checkEditShowLabels.Location = new System.Drawing.Point(351, 37);
            this.checkEditShowLabels.TabIndex = 5;
            // 
            // chart
            // 
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            xyDiagram4.AxisX.GridLines.MinorVisible = true;
            xyDiagram4.AxisX.GridLines.Visible = true;
            xyDiagram4.AxisX.Title.Text = "Arguments";
            xyDiagram4.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram4.AxisY.GridLines.MinorVisible = true;
            xyDiagram4.AxisY.MinorCount = 4;
            xyDiagram4.AxisY.Title.Text = "Values";
            xyDiagram4.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram4;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            series10.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            pointSeriesLabel10.Font = new System.Drawing.Font("Tahoma", 6F);
            series10.Label = pointSeriesLabel10;
            series10.Name = "Population 1";
            xyMarkerWidenAnimation10.PointDelay = System.TimeSpan.Parse("00:00:00.0500000");
            xyMarkerWidenAnimation10.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random;
            pointSeriesView10.SeriesPointAnimation = xyMarkerWidenAnimation10;
            series10.View = pointSeriesView10;
            series11.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            pointSeriesLabel11.Font = new System.Drawing.Font("Tahoma", 6F);
            series11.Label = pointSeriesLabel11;
            series11.Name = "Population 2";
            xyMarkerWidenAnimation11.PointDelay = System.TimeSpan.Parse("00:00:00.0500000");
            xyMarkerWidenAnimation11.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random;
            pointSeriesView11.SeriesPointAnimation = xyMarkerWidenAnimation11;
            series11.View = pointSeriesView11;
            series12.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            pointSeriesLabel12.Font = new System.Drawing.Font("Tahoma", 6F);
            series12.Label = pointSeriesLabel12;
            series12.Name = "Population 3";
            xyMarkerWidenAnimation12.PointDelay = System.TimeSpan.Parse("00:00:00.0500000");
            xyMarkerWidenAnimation12.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random;
            pointSeriesView12.SeriesPointAnimation = xyMarkerWidenAnimation12;
            series12.View = pointSeriesView12;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series10,
        series11,
        series12};
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle4.Text = "Random Points Generator";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle4});
            this.chart.VisibleChanged += new System.EventHandler(this.chart_VisibleChanged);
            // 
            // simpleButtonRandom
            // 
            this.simpleButtonRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonRandom.Location = new System.Drawing.Point(575, 14);
            this.simpleButtonRandom.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.simpleButtonRandom.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.simpleButtonRandom.Name = "simpleButtonRandom";
            this.simpleButtonRandom.Size = new System.Drawing.Size(110, 38);
            this.simpleButtonRandom.TabIndex = 0;
            this.simpleButtonRandom.Text = "Create Points";
            this.simpleButtonRandom.Click += new System.EventHandler(this.simpleButtonRandom_Click);
            // 
            // cbeLabelPosition
            // 
            this.cbeLabelPosition.Location = new System.Drawing.Point(257, 37);
            this.cbeLabelPosition.Name = "cbeLabelPosition";
            this.cbeLabelPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeLabelPosition.Properties.Items.AddRange(new object[] {
            "Center",
            "Outside"});
            this.cbeLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeLabelPosition.Size = new System.Drawing.Size(72, 20);
            this.cbeLabelPosition.TabIndex = 56;
            this.cbeLabelPosition.SelectedIndexChanged += new System.EventHandler(this.cbeLabelPosition_SelectedIndexChanged);
            // 
            // lblLabelPosition
            // 
            this.lblLabelPosition.Location = new System.Drawing.Point(182, 40);
            this.lblLabelPosition.Name = "lblLabelPosition";
            this.lblLabelPosition.Size = new System.Drawing.Size(69, 13);
            this.lblLabelPosition.TabIndex = 55;
            this.lblLabelPosition.Text = "Label Position:";
            // 
            // PointDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "PointDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelAngle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLabelPosition.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        private XtraEditors.ComboBoxEdit cbeLabelPosition;
        private XtraEditors.LabelControl lblLabelPosition;

	}
}
