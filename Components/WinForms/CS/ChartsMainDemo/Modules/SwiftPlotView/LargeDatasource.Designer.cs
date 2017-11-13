namespace DevExpress.XtraCharts.Demos.SwiftPlotView {
    partial class LargeDataSourceDemo {
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
            DevExpress.XtraCharts.SwiftPlotDiagram swiftPlotDiagram1 = new DevExpress.XtraCharts.SwiftPlotDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView1 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            this.cmbPointCount = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblPointCount = new DevExpress.XtraEditors.LabelControl();
            this.btnApply = new DevExpress.XtraEditors.SimpleButton();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPointCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblPointCount);
            this.panel.Controls.Add(this.cmbPointCount);
            this.panel.Controls.Add(this.btnApply);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.btnApply, 0);
            this.panel.Controls.SetChildIndex(this.cmbPointCount, 0);
            this.panel.Controls.SetChildIndex(this.lblPointCount, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(597, 37);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.Visible = false;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // cmbPointCount
            // 
            this.cmbPointCount.Location = new System.Drawing.Point(76, 9);
            this.cmbPointCount.Name = "cmbPointCount";
            this.cmbPointCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPointCount.Properties.DisplayFormat.FormatString = "N0";
            this.cmbPointCount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cmbPointCount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbPointCount.Properties.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.cmbPointCount_Properties_DrawItem);
            this.cmbPointCount.Size = new System.Drawing.Size(79, 20);
            this.cmbPointCount.TabIndex = 2;
            this.cmbPointCount.SelectedIndexChanged += new System.EventHandler(this.cmbPointCount_SelectedIndexChanged);
            // 
            // lblPointCount
            // 
            this.lblPointCount.Location = new System.Drawing.Point(12, 12);
            this.lblPointCount.Name = "lblPointCount";
            this.lblPointCount.Size = new System.Drawing.Size(58, 13);
            this.lblPointCount.TabIndex = 3;
            this.lblPointCount.Text = "Point count:";
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(170, 8);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 22);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            swiftPlotDiagram1.AxisX.Label.TextPattern = "{A:N0}";
            swiftPlotDiagram1.AxisX.Title.Text = "Arguments";
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.AxisX.VisualRange.Auto = false;
            swiftPlotDiagram1.AxisX.VisualRange.AutoSideMargins = false;
            swiftPlotDiagram1.AxisX.VisualRange.MaxValueSerializable = "9";
            swiftPlotDiagram1.AxisX.VisualRange.MinValueSerializable = "0";
            swiftPlotDiagram1.AxisX.VisualRange.SideMarginsValue = 0D;
            swiftPlotDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            swiftPlotDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            swiftPlotDiagram1.AxisY.Interlaced = true;
            swiftPlotDiagram1.AxisY.Title.Text = "Values";
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.EnableAxisXScrolling = true;
            swiftPlotDiagram1.EnableAxisYScrolling = true;
            this.chart.Diagram = swiftPlotDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series1.Name = "Series 1";
            series1.View = swiftPlotSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 3;
            // 
            // LargeDataSourceDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "LargeDataSourceDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPointCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbPointCount;
        private DevExpress.XtraEditors.SimpleButton btnApply;
        private DevExpress.XtraEditors.LabelControl lblPointCount;
        private ChartControl chart;
    }
}
