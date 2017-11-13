namespace DevExpress.XtraCharts.Demos.BarViews {
    partial class StackedBarSideBySide3dDemo {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram3D xyDiagram3D1 = new DevExpress.XtraCharts.XYDiagram3D();
            DevExpress.XtraCharts.StackedBar3DSeriesLabel stackedBar3DSeriesLabel1 = new DevExpress.XtraCharts.StackedBar3DSeriesLabel();
            DevExpress.XtraCharts.SideBySideStackedBar3DSeriesView sideBySideStackedBar3DSeriesView1 = new DevExpress.XtraCharts.SideBySideStackedBar3DSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.labelPerspective = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditPerspective = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblGroup = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBar3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBar3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPerspective.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDefaultAngles
            // 
            this.btnDefaultAngles.Location = new System.Drawing.Point(224, 8);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblGroup);
            this.panel.Controls.Add(this.radioGroup);
            this.panel.Controls.Add(this.labelPerspective);
            this.panel.Controls.Add(this.comboBoxEditPerspective);
            this.panel.Controls.SetChildIndex(this.btnDefaultAngles, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditPerspective, 0);
            this.panel.Controls.SetChildIndex(this.labelPerspective, 0);
            this.panel.Controls.SetChildIndex(this.radioGroup, 0);
            this.panel.Controls.SetChildIndex(this.lblGroup, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            xyDiagram3D1.AxisX.Label.MaxWidth = 60;
            xyDiagram3D1.AxisY.Label.TextPattern = "{V:0,,}M";
            xyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" +
    "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" +
    "1";
            xyDiagram3D1.RuntimeRotation = true;
            xyDiagram3D1.RuntimeScrolling = true;
            xyDiagram3D1.RuntimeZooming = true;
            xyDiagram3D1.VerticalScrollPercent = 4D;
            xyDiagram3D1.ZoomPercent = 130;
            this.chart.Diagram = xyDiagram3D1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.MaxHorizontalPercentage = 75D;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "GenderAge";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "Country";
            stackedBar3DSeriesLabel1.TextPattern = "{V:0,,.000}";
            this.chart.SeriesTemplate.Label = stackedBar3DSeriesLabel1;
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Population";
            this.chart.SeriesTemplate.View = sideBySideStackedBar3DSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 2;
            chartTitle1.Text = "Population: Age Structure";
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 12F);
            chartTitle2.Text = "Data estimate for end-2016";
            chartTitle3.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle3.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle3.Text = "From www.cia.gov";
            chartTitle3.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2,
            chartTitle3});
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chart_BoundDataChanged);
            // 
            // labelPerspective
            // 
            this.labelPerspective.Location = new System.Drawing.Point(12, 40);
            this.labelPerspective.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelPerspective.Name = "labelPerspective";
            this.labelPerspective.Size = new System.Drawing.Size(90, 13);
            this.labelPerspective.TabIndex = 60;
            this.labelPerspective.Text = "Perspective Angle:";
            // 
            // comboBoxEditPerspective
            // 
            this.comboBoxEditPerspective.EditValue = "";
            this.comboBoxEditPerspective.Location = new System.Drawing.Point(105, 37);
            this.comboBoxEditPerspective.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.comboBoxEditPerspective.Name = "comboBoxEditPerspective";
            this.comboBoxEditPerspective.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPerspective.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditPerspective.Size = new System.Drawing.Size(78, 20);
            this.comboBoxEditPerspective.TabIndex = 59;
            this.comboBoxEditPerspective.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditPerspective_SelectedIndexChanged);
            // 
            // lblGroup
            // 
            this.lblGroup.Location = new System.Drawing.Point(12, 12);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(80, 13);
            this.lblGroup.TabIndex = 64;
            this.lblGroup.Text = "Group Series by:";
            // 
            // radioGroup
            // 
            this.radioGroup.Location = new System.Drawing.Point(98, 8);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Gender"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Age")});
            this.radioGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioGroup.Size = new System.Drawing.Size(123, 22);
            this.radioGroup.TabIndex = 65;
            this.radioGroup.SelectedIndexChanged += new System.EventHandler(this.radioGroup_SelectedIndexChanged);
            // 
            // StackedBarSideBySide3dDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "StackedBarSideBySide3dDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBar3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBar3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPerspective.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.XtraEditors.LabelControl labelPerspective;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditPerspective;
        private DevExpress.XtraEditors.LabelControl lblGroup;
        private DevExpress.XtraEditors.RadioGroup radioGroup;
    }
}
