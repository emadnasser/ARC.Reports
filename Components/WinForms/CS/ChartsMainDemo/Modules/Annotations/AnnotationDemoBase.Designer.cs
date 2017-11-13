namespace DevExpress.XtraCharts.Demos.Annotations {
    partial class AnnotationDemoBase {
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
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.lblShape = new DevExpress.XtraEditors.LabelControl();
            this.cbeShape = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblConnector = new DevExpress.XtraEditors.LabelControl();
            this.cbeConnector = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tbcAngle = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.lblAngle = new DevExpress.XtraEditors.LabelControl();
            this.sbGeneratePoints = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeShape.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeConnector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcAngle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.sbGeneratePoints);
            this.panel.Controls.Add(this.tbcAngle);
            this.panel.Controls.Add(this.lblAngle);
            this.panel.Controls.Add(this.lblConnector);
            this.panel.Controls.Add(this.cbeConnector);
            this.panel.Controls.Add(this.lblShape);
            this.panel.Controls.Add(this.cbeShape);
            this.panel.Controls.SetChildIndex(this.cbeShape, 0);
            this.panel.Controls.SetChildIndex(this.lblShape, 0);
            this.panel.Controls.SetChildIndex(this.cbeConnector, 0);
            this.panel.Controls.SetChildIndex(this.lblConnector, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.lblAngle, 0);
            this.panel.Controls.SetChildIndex(this.tbcAngle, 0);
            this.panel.Controls.SetChildIndex(this.sbGeneratePoints, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.Auto = false;
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "13";
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0";
            xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0D;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Center;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "Random Series";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 2;
            // 
            // lblShape
            // 
            this.lblShape.Location = new System.Drawing.Point(12, 12);
            this.lblShape.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(34, 13);
            this.lblShape.TabIndex = 2;
            this.lblShape.Text = "Shape:";
            // 
            // cbeShape
            // 
            this.cbeShape.EditValue = "Rounded Rectangle";
            this.cbeShape.Location = new System.Drawing.Point(72, 9);
            this.cbeShape.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.cbeShape.Name = "cbeShape";
            this.cbeShape.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeShape.Properties.Items.AddRange(new object[] {
            "Rectangle",
            "Rounded Rectangle",
            "Ellipse"});
            this.cbeShape.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeShape.Size = new System.Drawing.Size(122, 20);
            this.cbeShape.TabIndex = 3;
            this.cbeShape.SelectedIndexChanged += new System.EventHandler(this.cbeShape_SelectedIndexChanged);
            // 
            // lblConnector
            // 
            this.lblConnector.Location = new System.Drawing.Point(12, 40);
            this.lblConnector.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.lblConnector.Name = "lblConnector";
            this.lblConnector.Size = new System.Drawing.Size(54, 13);
            this.lblConnector.TabIndex = 4;
            this.lblConnector.Text = "Connector:";
            // 
            // cbeConnector
            // 
            this.cbeConnector.EditValue = "Tail";
            this.cbeConnector.Location = new System.Drawing.Point(72, 37);
            this.cbeConnector.Name = "cbeConnector";
            this.cbeConnector.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeConnector.Properties.Items.AddRange(new object[] {
            "None",
            "Tail",
            "Arrow",
            "Notched Arrow",
            "Line"});
            this.cbeConnector.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeConnector.Size = new System.Drawing.Size(122, 20);
            this.cbeConnector.TabIndex = 5;
            this.cbeConnector.SelectedIndexChanged += new System.EventHandler(this.cbeConnector_SelectedIndexChanged);
            // 
            // tbcAngle
            // 
            this.tbcAngle.EditValue = null;
            this.tbcAngle.Location = new System.Drawing.Point(210, 37);
            this.tbcAngle.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tbcAngle.Name = "tbcAngle";
            this.tbcAngle.Properties.HighlightSelectedRange = false;
            this.tbcAngle.Properties.LargeChange = 10;
            this.tbcAngle.Properties.Maximum = 360;
            this.tbcAngle.Properties.Middle = 180;
            this.tbcAngle.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.tbcAngle.Properties.ShowValueToolTip = true;
            this.tbcAngle.Properties.SmallChange = 5;
            this.tbcAngle.Size = new System.Drawing.Size(120, 16);
            this.tbcAngle.TabIndex = 6;
            this.tbcAngle.EditValueChanged += new System.EventHandler(this.tbcAngle_EditValueChanged);
            // 
            // lblAngle
            // 
            this.lblAngle.Location = new System.Drawing.Point(254, 12);
            this.lblAngle.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(31, 13);
            this.lblAngle.TabIndex = 7;
            this.lblAngle.Text = "Angle:";
            // 
            // sbGeneratePoints
            // 
            this.sbGeneratePoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGeneratePoints.Location = new System.Drawing.Point(589, 7);
            this.sbGeneratePoints.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.sbGeneratePoints.Name = "sbGeneratePoints";
            this.sbGeneratePoints.Size = new System.Drawing.Size(99, 23);
            this.sbGeneratePoints.TabIndex = 8;
            this.sbGeneratePoints.Text = "Generate Points";
            this.sbGeneratePoints.Click += new System.EventHandler(this.sbGeneratePoints_Click);
            // 
            // AnnotationDemoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "AnnotationDemoBase";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeShape.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeConnector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcAngle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.XtraEditors.LabelControl lblConnector;
        private DevExpress.XtraEditors.ComboBoxEdit cbeConnector;
        private DevExpress.XtraEditors.LabelControl lblShape;
        private DevExpress.XtraEditors.ComboBoxEdit cbeShape;
        private DevExpress.XtraEditors.ZoomTrackBarControl tbcAngle;
        private DevExpress.XtraEditors.LabelControl lblAngle;
        private DevExpress.XtraEditors.SimpleButton sbGeneratePoints;

    }
}
