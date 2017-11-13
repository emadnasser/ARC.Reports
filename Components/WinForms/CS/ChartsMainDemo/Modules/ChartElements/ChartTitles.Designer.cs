namespace DevExpress.XtraCharts.Demos.ChartElements {
    partial class ChartTitlesDemo {
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
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView1 = new DevExpress.XtraCharts.AreaSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle4 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.lblAlignment = new DevExpress.XtraEditors.LabelControl();
            this.lblDock = new DevExpress.XtraEditors.LabelControl();
            this.cmbAlignment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbDock = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblText = new DevExpress.XtraEditors.LabelControl();
            this.meeText = new DevExpress.XtraEditors.MemoExEdit();
            this.chbWordWrap = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAlignment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meeText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbWordWrap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chbWordWrap);
            this.panel.Controls.Add(this.cmbAlignment);
            this.panel.Controls.Add(this.meeText);
            this.panel.Controls.Add(this.lblText);
            this.panel.Controls.Add(this.lblAlignment);
            this.panel.Controls.Add(this.lblDock);
            this.panel.Controls.Add(this.cmbDock);
            this.panel.Controls.SetChildIndex(this.cmbDock, 0);
            this.panel.Controls.SetChildIndex(this.lblDock, 0);
            this.panel.Controls.SetChildIndex(this.lblAlignment, 0);
            this.panel.Controls.SetChildIndex(this.lblText, 0);
            this.panel.Controls.SetChildIndex(this.meeText, 0);
            this.panel.Controls.SetChildIndex(this.cmbAlignment, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.chbWordWrap, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.Visible = false;
            // 
            // chart
            // 
            this.chart.AutoLayout = false;
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            this.chart.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Single;
            pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Label = pointSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Series 1";
            areaSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.View = areaSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Text = "With XtraCharts, <b>you</b> can display an <u>unlimited</u> number of <color=blue" +
    ">chart titles</color>";
            chartTitle1.WordWrap = true;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Text = "<size=14>Title</size> <size=+2>with <size=+6>a</size></size> <size=24>variable</s" +
    "ize> <size=14>font <size=+6>size</size></size>";
            chartTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Left;
            chartTitle3.Text = "<i>Italicized</i> title";
            chartTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Right;
            chartTitle4.Text = "<color=red>Multi</color>-<color=green>color</color> <color=blue>title</color>";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2,
            chartTitle3,
            chartTitle4});
            this.chart.ObjectSelected += new DevExpress.XtraCharts.HotTrackEventHandler(this.chart_ObjectSelected);
            this.chart.ObjectHotTracked += new DevExpress.XtraCharts.HotTrackEventHandler(this.chart_ObjectHotTracked);
            // 
            // lblAlignment
            // 
            this.lblAlignment.Enabled = false;
            this.lblAlignment.Location = new System.Drawing.Point(12, 12);
            this.lblAlignment.Name = "lblAlignment";
            this.lblAlignment.Size = new System.Drawing.Size(51, 13);
            this.lblAlignment.TabIndex = 2;
            this.lblAlignment.Text = "Alignment:";
            // 
            // lblDock
            // 
            this.lblDock.Enabled = false;
            this.lblDock.Location = new System.Drawing.Point(156, 12);
            this.lblDock.Name = "lblDock";
            this.lblDock.Size = new System.Drawing.Size(27, 13);
            this.lblDock.TabIndex = 3;
            this.lblDock.Text = "Dock:";
            // 
            // cmbAlignment
            // 
            this.cmbAlignment.AllowDrop = true;
            this.cmbAlignment.Enabled = false;
            this.cmbAlignment.Location = new System.Drawing.Point(69, 9);
            this.cmbAlignment.Name = "cmbAlignment";
            this.cmbAlignment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAlignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbAlignment.Size = new System.Drawing.Size(80, 20);
            this.cmbAlignment.TabIndex = 4;
            this.cmbAlignment.SelectedIndexChanged += new System.EventHandler(this.cmbAlignment_SelectedIndexChanged);
            // 
            // cmbDock
            // 
            this.cmbDock.Enabled = false;
            this.cmbDock.Location = new System.Drawing.Point(189, 9);
            this.cmbDock.Name = "cmbDock";
            this.cmbDock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDock.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbDock.Size = new System.Drawing.Size(80, 20);
            this.cmbDock.TabIndex = 5;
            this.cmbDock.SelectedIndexChanged += new System.EventHandler(this.cmbDock_SelectedIndexChanged);
            // 
            // lblText
            // 
            this.lblText.Enabled = false;
            this.lblText.Location = new System.Drawing.Point(12, 40);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(26, 13);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "Text:";
            // 
            // meeText
            // 
            this.meeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.meeText.EditValue = "";
            this.meeText.Enabled = false;
            this.meeText.Location = new System.Drawing.Point(69, 37);
            this.meeText.Name = "meeText";
            this.meeText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.meeText.Properties.PopupFormSize = new System.Drawing.Size(480, 150);
            this.meeText.Properties.ShowIcon = false;
            this.meeText.Size = new System.Drawing.Size(480, 20);
            this.meeText.TabIndex = 7;
            this.meeText.TextChanged += new System.EventHandler(this.meeText_TextChanged);
            // 
            // chbWordWrap
            // 
            this.chbWordWrap.Location = new System.Drawing.Point(282, 9);
            this.chbWordWrap.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chbWordWrap.Name = "chbWordWrap";
            this.chbWordWrap.Properties.Caption = "Word Wrap";
            this.chbWordWrap.Size = new System.Drawing.Size(99, 19);
            this.chbWordWrap.TabIndex = 8;
            this.chbWordWrap.CheckedChanged += new System.EventHandler(this.chbWordWrap_CheckedChanged);
            // 
            // ChartTitlesDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "ChartTitlesDemo";
            this.Load += new System.EventHandler(this.ChartDemoChartTitles_Load);
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAlignment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meeText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbWordWrap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbAlignment;
        private DevExpress.XtraEditors.MemoExEdit meeText;
        private DevExpress.XtraEditors.LabelControl lblText;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDock;
        private DevExpress.XtraEditors.LabelControl lblDock;
        private DevExpress.XtraEditors.LabelControl lblAlignment;
        private DevExpress.XtraEditors.CheckEdit chbWordWrap;
    }
}
