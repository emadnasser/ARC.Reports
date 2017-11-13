namespace DevExpress.XtraCharts.Demos.Miscellaneous {
    partial class DateTimeScaleDemo {
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
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbAggregateFunction = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbMeasureUnit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbGridAlignment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbScaleMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chbAutoGrid = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAggregateFunction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMeasureUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGridAlignment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbScaleMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAutoGrid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chbAutoGrid);
            this.panel.Controls.Add(this.cbScaleMode);
            this.panel.Controls.Add(this.cbGridAlignment);
            this.panel.Controls.Add(this.labelControl3);
            this.panel.Controls.Add(this.cbMeasureUnit);
            this.panel.Controls.Add(this.labelControl2);
            this.panel.Controls.Add(this.cbAggregateFunction);
            this.panel.Controls.Add(this.labelControl4);
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Size = new System.Drawing.Size(700, 64);
            this.panel.Controls.SetChildIndex(this.labelControl1, 0);
            this.panel.Controls.SetChildIndex(this.labelControl4, 0);
            this.panel.Controls.SetChildIndex(this.cbAggregateFunction, 0);
            this.panel.Controls.SetChildIndex(this.labelControl2, 0);
            this.panel.Controls.SetChildIndex(this.cbMeasureUnit, 0);
            this.panel.Controls.SetChildIndex(this.labelControl3, 0);
            this.panel.Controls.SetChildIndex(this.cbGridAlignment, 0);
            this.panel.Controls.SetChildIndex(this.cbScaleMode, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.chbAutoGrid, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 72);
            // 
            // chart
            // 
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.MinorCount = 3;
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Title.Text = "Thousands of Dollars";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 72);
            this.chart.Name = "chart";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Orders";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(700, 428);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Text = "Orders";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Measure Unit:";
            // 
            // cbAggregateFunction
            // 
            this.cbAggregateFunction.Location = new System.Drawing.Point(326, 37);
            this.cbAggregateFunction.Name = "cbAggregateFunction";
            this.cbAggregateFunction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAggregateFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbAggregateFunction.Size = new System.Drawing.Size(108, 20);
            this.cbAggregateFunction.TabIndex = 4;
            this.cbAggregateFunction.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(221, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Aggregate Function:";
            // 
            // cbMeasureUnit
            // 
            this.cbMeasureUnit.Location = new System.Drawing.Point(85, 37);
            this.cbMeasureUnit.Name = "cbMeasureUnit";
            this.cbMeasureUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMeasureUnit.Properties.DropDownRows = 11;
            this.cbMeasureUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbMeasureUnit.Size = new System.Drawing.Size(108, 20);
            this.cbMeasureUnit.TabIndex = 6;
            this.cbMeasureUnit.SelectedValueChanged += new System.EventHandler(this.ComboBoxSelectedValueChanged);
            // 
            // cbGridAlignment
            // 
            this.cbGridAlignment.Location = new System.Drawing.Point(326, 9);
            this.cbGridAlignment.Name = "cbGridAlignment";
            this.cbGridAlignment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGridAlignment.Properties.DropDownRows = 11;
            this.cbGridAlignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbGridAlignment.Size = new System.Drawing.Size(108, 20);
            this.cbGridAlignment.TabIndex = 8;
            this.cbGridAlignment.SelectedValueChanged += new System.EventHandler(this.ComboBoxSelectedValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(221, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Grid Alignment:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Scale Mode:";
            // 
            // cbScaleMode
            // 
            this.cbScaleMode.Location = new System.Drawing.Point(85, 9);
            this.cbScaleMode.Name = "cbScaleMode";
            this.cbScaleMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbScaleMode.Properties.DropDownRows = 11;
            this.cbScaleMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbScaleMode.Size = new System.Drawing.Size(108, 20);
            this.cbScaleMode.TabIndex = 10;
            this.cbScaleMode.SelectedValueChanged += new System.EventHandler(this.ComboBoxSelectedValueChanged);
            // 
            // chbAutoGrid
            // 
            this.chbAutoGrid.Location = new System.Drawing.Point(457, 9);
            this.chbAutoGrid.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chbAutoGrid.Name = "chbAutoGrid";
            this.chbAutoGrid.Properties.Caption = "Auto Grid";
            this.chbAutoGrid.Size = new System.Drawing.Size(99, 19);
            this.chbAutoGrid.TabIndex = 11;
            this.chbAutoGrid.CheckedChanged += new System.EventHandler(this.chbAutoGrid_CheckedChanged);
            // 
            // DateTimeScaleDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "DateTimeScaleDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAggregateFunction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMeasureUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGridAlignment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbScaleMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAutoGrid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private XtraEditors.LabelControl labelControl2;
        private XtraEditors.ComboBoxEdit cbAggregateFunction;
        private XtraEditors.ComboBoxEdit cbMeasureUnit;
        private XtraEditors.ComboBoxEdit cbGridAlignment;
        private XtraEditors.LabelControl labelControl3;
        private XtraEditors.ComboBoxEdit cbScaleMode;
        private XtraEditors.LabelControl labelControl4;
        private XtraEditors.CheckEdit chbAutoGrid;
    }
}
