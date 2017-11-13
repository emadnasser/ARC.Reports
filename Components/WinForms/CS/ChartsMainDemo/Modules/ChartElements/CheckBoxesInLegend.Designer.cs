namespace DevExpress.XtraCharts.Demos.ChartElements {
    partial class CheckBoxesInLegendDemo {
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.checkEditUseCheckBoxes = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditUseCheckBoxes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.checkEdit2);
            this.panel.Controls.Add(this.checkEditUseCheckBoxes);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.checkEditUseCheckBoxes, 0);
            this.panel.Controls.SetChildIndex(this.checkEdit2, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.Visible = false;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chart.AutoLayout = false;
            this.chart.CrosshairOptions.GroupHeaderPattern = "<b>Year: {A:yyyy}</b>";
            this.chart.CrosshairOptions.ShowArgumentLine = false;
            this.chart.DataBindings = null;
            xyDiagram2.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Label.TextPattern = "{V:C0}";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chart.Diagram = xyDiagram2;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.UseCheckBoxes = true;
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "Series";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "Year";
            this.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            this.chart.SeriesTemplate.CrosshairLabelPattern = "{S}: {V:c0}";
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Value";
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 2;
            chartTitle2.Text = "Goods Sales by Years";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chart_BoundDataChanged);
            // 
            // checkEditUseCheckBoxes
            // 
            this.checkEditUseCheckBoxes.EditValue = true;
            this.checkEditUseCheckBoxes.Location = new System.Drawing.Point(12, 9);
            this.checkEditUseCheckBoxes.Name = "checkEditUseCheckBoxes";
            this.checkEditUseCheckBoxes.Properties.Caption = "Use Check Boxes in Legend";
            this.checkEditUseCheckBoxes.Size = new System.Drawing.Size(161, 19);
            this.checkEditUseCheckBoxes.TabIndex = 2;
            this.checkEditUseCheckBoxes.CheckedChanged += new System.EventHandler(this.checkEditUseCheckBoxes_CheckedChanged);
            // 
            // checkEdit2
            // 
            this.checkEdit2.EditValue = true;
            this.checkEdit2.Location = new System.Drawing.Point(191, 9);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Checkable Indicators";
            this.checkEdit2.Size = new System.Drawing.Size(161, 19);
            this.checkEdit2.TabIndex = 3;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // CheckBoxesInLegendDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "CheckBoxesInLegendDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditUseCheckBoxes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private XtraEditors.CheckEdit checkEdit2;
        private XtraEditors.CheckEdit checkEditUseCheckBoxes;
    }
}
