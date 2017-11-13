using System;
using System.Drawing;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.SwiftPlotView {
    public partial class LargeDataSourceDemo : ChartDemoBase {
        int pointCount;
        int newPointCount;

        Series Series { get { return chart.Series.Count > 0 ? chart.Series[0] : null; } }
        SwiftPlotDiagram Diagram { get { return chart.Diagram as SwiftPlotDiagram; } }
        AxisBase AxisX { get { return Diagram != null ? Diagram.AxisX : null; } }
        AxisBase AxisY { get { return Diagram != null ? Diagram.AxisY : null; } }

        public override ChartControl ChartControl { get { return chart; } }

        public LargeDataSourceDemo() {
            InitializeComponent();
        }

        void LoadPoints() {
            if (Series == null || AxisX == null)
                return;
            double value = 0;
            Random random = new Random();
            ChartControl.BeginInit();
            Series.Points.Clear();
            for (int i = 0; i < pointCount; i++) {
                Series.Points.Add(new SeriesPoint((double)i, value));
                value += (random.NextDouble() * 10.0 - 5.0);
                if (value > 1200)
                    value -= 500;
                if (value < -1200)
                    value += 500;
            }
            AxisX.VisualRange.SetMinMaxValues(pointCount / 4, 3 * pointCount / 4);
            AxisX.WholeRange.SetMinMaxValues(0, pointCount);
            AxisY.WholeRange.SetMinMaxValues(-1000, 1000);
            ChartControl.EndInit();
        }
        void Apply() {
            btnApply.Enabled = false;
            cmbPointCount.Enabled = false;
            lblPointCount.Enabled = false;
            pointCount = newPointCount;
            using (WaitDialogForm dlg = new WaitDialogForm("Please Wait", "Loading Data...", new Size(200, 50), ParentForm)) {
                LoadPoints();
            }
            cmbPointCount.Enabled = true;
            lblPointCount.Enabled = true;
        }
        void btnApply_Click(object sender, EventArgs e) {
            Apply();
        }
        void cmbPointCount_SelectedIndexChanged(object sender, EventArgs e) {
            newPointCount = Convert.ToInt32(cmbPointCount.EditValue);
            btnApply.Enabled = newPointCount != pointCount;
        }
        void cmbPointCount_Properties_DrawItem(object sender, DevExpress.XtraEditors.ListBoxDrawItemEventArgs e) {
            if (e.State == System.Windows.Forms.DrawItemState.Selected)
                e.Appearance.FillRectangle(e.Cache, e.Bounds);
            e.Appearance.DrawString(e.Cache, ((int)e.Item).ToString("N0"), e.Bounds);
            e.Handled = true;
        }

        protected override void InitControls() {
            base.InitControls();
            cmbPointCount.Properties.Items.AddRange(new object[] { 10000, 20000, 50000, 100000, 500000, 1000000 });
            cmbPointCount.SelectedIndex = 2;
            Apply();
            CrosshairFreePosition crosshairPosition = new CrosshairFreePosition();
            crosshairPosition.DockTarget = ((XYDiagram2D)ChartControl.Diagram).DefaultPane;
            crosshairPosition.DockCorner = DockCorner.LeftTop;
            ChartControl.CrosshairOptions.CommonLabelPosition = crosshairPosition;
            foreach (Series series in chart.Series)
                series.CrosshairLabelPattern = "{A} : {V:F2}";
        }
    }
}
