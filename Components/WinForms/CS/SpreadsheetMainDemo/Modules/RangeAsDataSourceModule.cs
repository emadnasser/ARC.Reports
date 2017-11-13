using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Demos;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;


namespace DevExpress.XtraSpreadsheet.Demos {
    public class RangeAsDataSourceModule : SpreadSheetTutorialControlBase {
        private SplitContainerControl verticalSplitContainerControl1;
        private SpreadsheetControl spreadsheet;
        private PanelControl panelControl1;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private ZoomTrackBarControl trbStdDev;
        private ZoomTrackBarControl trbMean;
        private ChartControl chartControl1;
        private Timer timer1;
        private IContainer components;
        double mean;
        double standardDeviation;

        public RangeAsDataSourceModule() {
            InitializeComponent();
            this.spreadsheet.LoadDocument(DemoUtils.GetRelativePath("RangeAsDataSource_template.xlsx"), DocumentFormat.Xlsx);
        }

        protected override void DoShow() {
            base.DoShow();
            this.spreadsheet.Focus();
            timer1.Enabled = true;
        }

        protected override void DoHide() {
            timer1.Enabled = false;
            base.DoHide();
        }

        private void spreadsheet_DocumentLoaded(object sender, EventArgs e) {
            IWorkbook workbook = this.spreadsheet.Document;
            Worksheet sheet = workbook.Worksheets[0];

            this.chartControl1.DataSource = sheet["B3:D103"].GetDataSource();
            Series series = this.chartControl1.Series[0];
            series.ArgumentDataMember = "Column 0";
            series.ValueDataMembers.AddRange(new string[] { "Column 1" });
            series = this.chartControl1.Series[1];
            series.ArgumentDataMember = "Column 0";
            series.ValueDataMembers.AddRange(new string[] { "Column 2" });

            mean = trbMean.Value / 10.0;
            standardDeviation = trbStdDev.Value / 100.0;
        }

        private void trbMean_EditValueChanged(object sender, EventArgs e) {
            mean = trbMean.Value / 10.0;
        }

        private void trbStdDev_EditValueChanged(object sender, EventArgs e) {
            standardDeviation = trbStdDev.Value / 100.0;
        }

        private void spreadsheet_CellValueChanged(object sender, SpreadsheetCellEventArgs e) {
            if (e.Cell.GetReferenceA1() == "F3")
                trbMean.Value = (int)(e.Cell.Value.NumericValue * 10);
            else if (e.Cell.GetReferenceA1() == "F6")
                trbStdDev.Value = (int)(e.Cell.Value.NumericValue * 100);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            this.spreadsheet.BeginUpdate();
            try {
                Worksheet sheet = this.spreadsheet.Document.Worksheets[0];
                if (sheet["F3"].Value.NumericValue != mean)
                    sheet["F3"].Value = mean;
                if (sheet["F6"].Value.NumericValue != standardDeviation)
                    sheet["F6"].Value = standardDeviation;
            }
            finally {
                this.spreadsheet.EndUpdate();
            }
        }

        #region InitializeComponent
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Strip strip1 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.Strip strip2 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.Strip strip3 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.Strip strip4 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.Strip strip5 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.XYDiagramPane xyDiagramPane1 = new DevExpress.XtraCharts.XYDiagramPane();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ScatterLineSeriesView scatterLineSeriesView1 = new DevExpress.XtraCharts.ScatterLineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ScatterLineSeriesView scatterLineSeriesView2 = new DevExpress.XtraCharts.ScatterLineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.verticalSplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.spreadsheet = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.trbStdDev = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.trbMean = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitContainerControl1)).BeginInit();
            this.verticalSplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbStdDev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbStdDev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMean.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // verticalSplitContainerControl1
            // 
            this.verticalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.verticalSplitContainerControl1.Location = new System.Drawing.Point(0, 34);
            this.verticalSplitContainerControl1.Name = "verticalSplitContainerControl1";
            this.verticalSplitContainerControl1.Panel1.Controls.Add(this.spreadsheet);
            this.verticalSplitContainerControl1.Panel1.Text = "Panel1";
            this.verticalSplitContainerControl1.Panel2.Controls.Add(this.chartControl1);
            this.verticalSplitContainerControl1.Panel2.Text = "Panel2";
            this.verticalSplitContainerControl1.Size = new System.Drawing.Size(1228, 660);
            this.verticalSplitContainerControl1.SplitterPosition = 615;
            this.verticalSplitContainerControl1.TabIndex = 0;
            this.verticalSplitContainerControl1.Text = "verticalSplitContainerControl1";
            // 
            // spreadsheet
            // 
            this.spreadsheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheet.Location = new System.Drawing.Point(0, 0);
            this.spreadsheet.Name = "spreadsheet";
            this.spreadsheet.Options.Behavior.Column.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheet.Options.Behavior.Column.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheet.Options.Behavior.Row.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheet.Options.Behavior.Row.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheet.Options.Behavior.UseSkinColors = false;
            this.spreadsheet.Options.Export.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheet.Options.Export.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheet.Options.Import.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheet.Options.Import.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheet.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheet.Options.View.ShowPrintArea = false;
            this.spreadsheet.Size = new System.Drawing.Size(615, 660);
            this.spreadsheet.TabIndex = 7;
            this.spreadsheet.DocumentLoaded += new System.EventHandler(this.spreadsheet_DocumentLoaded);
            this.spreadsheet.CellValueChanged += new DevExpress.XtraSpreadsheet.CellValueChangedEventHandler(this.spreadsheet_CellValueChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Light";
            this.chartControl1.DataBindings = null;
            xyDiagram1.AxisX.GridLines.Visible = true;
            strip1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            strip1.MaxLimit.AxisValueSerializable = "1";
            strip1.MinLimit.AxisValueSerializable = "-1";
            strip1.Name = "Strip 1";
            strip1.ShowInLegend = false;
            strip2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            strip2.MaxLimit.AxisValueSerializable = "-2";
            strip2.MinLimit.AxisValueSerializable = "-3";
            strip2.Name = "Strip 2";
            strip2.ShowInLegend = false;
            strip3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            strip3.MaxLimit.AxisValueSerializable = "-4";
            strip3.MinLimit.AxisValueSerializable = "-5";
            strip3.Name = "Strip 3";
            strip3.ShowInLegend = false;
            strip4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            strip4.MaxLimit.AxisValueSerializable = "3";
            strip4.MinLimit.AxisValueSerializable = "2";
            strip4.Name = "Strip 4";
            strip4.ShowInLegend = false;
            strip5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            strip5.MaxLimit.AxisValueSerializable = "5";
            strip5.MinLimit.AxisValueSerializable = "4";
            strip5.Name = "Strip 5";
            strip5.ShowInLegend = false;
            xyDiagram1.AxisX.Strips.AddRange(new DevExpress.XtraCharts.Strip[] {
            strip1,
            strip2,
            strip3,
            strip4,
            strip5});
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1;0";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "5";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "-5";
            xyDiagram1.AxisX.WholeRange.Auto = false;
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "5";
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "-5";
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1;0";
            xyDiagramPane1.Name = "Pane 1";
            xyDiagramPane1.PaneID = 0;
            xyDiagram1.Panes.AddRange(new DevExpress.XtraCharts.XYDiagramPane[] {
            xyDiagramPane1});
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.CrosshairLabelPattern = "X={A:0.0} Y={V:0.00e+00}";
            series1.Name = "PDF";
            series1.View = scatterLineSeriesView1;
            series2.CrosshairLabelPattern = "X={A:0.0} Y={V:0.00e+00}";
            series2.Name = "CDF";
            scatterLineSeriesView2.PaneName = "Pane 1";
            series2.View = scatterLineSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl1.Size = new System.Drawing.Size(608, 660);
            this.chartControl1.TabIndex = 0;
            chartTitle1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            chartTitle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartTitle1.Text = "PROBABILITY DENSITY FUNCTION";
            chartTitle1.TextColor = System.Drawing.Color.DimGray;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            chartTitle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartTitle2.Text = "CUMULATIVE DISTRIBUTION FUNCTION";
            chartTitle2.TextColor = System.Drawing.Color.DimGray;
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.trbStdDev);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.trbMean);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1228, 34);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(245, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Standard deviation:";
            // 
            // trbStdDev
            // 
            this.trbStdDev.EditValue = 55;
            this.trbStdDev.Location = new System.Drawing.Point(359, 3);
            this.trbStdDev.Name = "trbStdDev";
            this.trbStdDev.Properties.Maximum = 100;
            this.trbStdDev.Properties.Minimum = 10;
            this.trbStdDev.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.trbStdDev.Size = new System.Drawing.Size(164, 23);
            this.trbStdDev.TabIndex = 3;
            this.trbStdDev.Value = 55;
            this.trbStdDev.EditValueChanged += new System.EventHandler(this.trbStdDev_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(0, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mean:";
            // 
            // trbMean
            // 
            this.trbMean.Location = new System.Drawing.Point(36, 3);
            this.trbMean.Name = "trbMean";
            this.trbMean.Properties.Maximum = 50;
            this.trbMean.Properties.Minimum = -50;
            this.trbMean.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.trbMean.Size = new System.Drawing.Size(164, 23);
            this.trbMean.TabIndex = 1;
            this.trbMean.Value = 0;
            this.trbMean.EditValueChanged += new System.EventHandler(this.trbMean_EditValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RangeAsDataSourceModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.verticalSplitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "RangeAsDataSourceModule";
            this.Size = new System.Drawing.Size(1228, 694);
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitContainerControl1)).EndInit();
            this.verticalSplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(strip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(strip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(strip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(strip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(strip5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbStdDev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbStdDev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMean.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMean)).EndInit();
            this.ResumeLayout(false);

        } 
        #endregion

        #region Dispose
        bool isModuleDisposed = false;
        protected override void Dispose(bool disposing) {
            if (disposing && !isModuleDisposed) {
                timer1.Enabled = false;
                isModuleDisposed = true;
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}
