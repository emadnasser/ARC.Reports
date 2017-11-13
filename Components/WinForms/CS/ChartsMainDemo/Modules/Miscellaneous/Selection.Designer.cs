namespace DevExpress.XtraCharts.Demos.Miscellaneous {
	partial class SelectionDemo {
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
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.chartBars = new DevExpress.XtraCharts.ChartControl();
            this.chartTotal = new DevExpress.XtraCharts.ChartControl();
            this.comboBoxEditSelectionMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelSeriesDataMember = new DevExpress.XtraEditors.LabelControl();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelectionMode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelSeriesDataMember);
            this.panel.Controls.Add(this.comboBoxEditSelectionMode);
            this.panel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.comboBoxEditSelectionMode, 0);
            this.panel.Controls.SetChildIndex(this.labelSeriesDataMember, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
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
            // chartBars
            // 
            this.chartBars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartBars.BackColor = System.Drawing.Color.Transparent;
            this.chartBars.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartBars.CrosshairOptions.GroupHeaderPattern = "<b>{A:yyyy}</b>";
            this.chartBars.CrosshairOptions.HighlightPoints = false;
            this.chartBars.DataBindings = null;
            this.chartBars.Legend.Name = "Default Legend";
            this.chartBars.Location = new System.Drawing.Point(381, 76);
            this.chartBars.Name = "chartBars";
            this.chartBars.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartBars.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            sideBySideBarSeriesLabel1.TextPattern = "{V:F2}";
            this.chartBars.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartBars.SeriesTemplate.ValueDataMembersSerializable = "Sales";
            this.chartBars.Size = new System.Drawing.Size(318, 423);
            this.chartBars.TabIndex = 1;
            this.chartBars.TabStop = false;
            chartTitle1.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle1.Font = new System.Drawing.Font("Tahoma", 10F);
            chartTitle1.Text = "";
            this.chartBars.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // chartTotal
            // 
            this.chartTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chartTotal.BackColor = System.Drawing.Color.Transparent;
            this.chartTotal.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartTotal.DataBindings = null;
            this.chartTotal.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartTotal.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartTotal.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartTotal.Legend.Name = "Default Legend";
            this.chartTotal.Location = new System.Drawing.Point(0, 76);
            this.chartTotal.Name = "chartTotal";
            this.chartTotal.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartTotal.SeriesTemplate.ArgumentDataMember = "Region";
            this.chartTotal.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            this.chartTotal.SeriesTemplate.ValueDataMembersSerializable = "Sales";
            this.chartTotal.SeriesTemplate.View = pieSeriesView1;
            this.chartTotal.Size = new System.Drawing.Size(375, 425);
            this.chartTotal.TabIndex = 2;
            this.chartTotal.ObjectSelected += new DevExpress.XtraCharts.HotTrackEventHandler(this.ChartTotal_ObjectSelected);
            this.chartTotal.ObjectHotTracked += new DevExpress.XtraCharts.HotTrackEventHandler(this.ChartBars_ObjectHotTracked);
            // 
            // comboBoxEditSelectionMode
            // 
            this.comboBoxEditSelectionMode.EditValue = "";
            this.comboBoxEditSelectionMode.Location = new System.Drawing.Point(91, 9);
            this.comboBoxEditSelectionMode.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.comboBoxEditSelectionMode.Name = "comboBoxEditSelectionMode";
            this.comboBoxEditSelectionMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSelectionMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditSelectionMode.Size = new System.Drawing.Size(90, 20);
            this.comboBoxEditSelectionMode.TabIndex = 1;
            this.comboBoxEditSelectionMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditSelectionMode_SelectedIndexChanged);
            // 
            // labelSeriesDataMember
            // 
            this.labelSeriesDataMember.Location = new System.Drawing.Point(12, 12);
            this.labelSeriesDataMember.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.labelSeriesDataMember.Name = "labelSeriesDataMember";
            this.labelSeriesDataMember.Size = new System.Drawing.Size(76, 13);
            this.labelSeriesDataMember.TabIndex = 0;
            this.labelSeriesDataMember.Text = "Selection Mode:";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.labelTitle.Appearance.Options.UseFont = true;
            this.labelTitle.Appearance.Options.UseTextOptions = true;
            this.labelTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelTitle.Location = new System.Drawing.Point(0, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(700, 46);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "The DevAV Company Sales Comparison";
            // 
            // SelectionDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartTotal);
            this.Controls.Add(this.chartBars);
            this.Controls.Add(this.labelTitle);
            this.Name = "SelectionDemo";
            this.Controls.SetChildIndex(this.labelTitle, 0);
            this.Controls.SetChildIndex(this.chartBars, 0);
            this.Controls.SetChildIndex(this.chartTotal, 0);
            this.Controls.SetChildIndex(this.panelRoot, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelectionMode.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;
        private ChartControl chartTotal;
        private XtraEditors.LabelControl labelSeriesDataMember;
        private XtraEditors.ComboBoxEdit comboBoxEditSelectionMode;
        private DevExpress.XtraEditors.LabelControl labelTitle;

	}
}
