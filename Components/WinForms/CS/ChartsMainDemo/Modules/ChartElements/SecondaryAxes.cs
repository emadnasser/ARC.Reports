using System;
using DevExpress.Utils;
using DevExpress.Utils.Menu;

namespace DevExpress.XtraCharts.Demos.ChartElements {
    public partial class SecondaryAxesDemo : ChartDemoBase2D {
        struct AxisItem {
            readonly Axis axis;

            public Axis Axis { get { return axis; } }

            public AxisItem(Axis axis) {
                this.axis = axis;
            }

            public override string ToString() {
                return axis.Name;
            }
            public override bool Equals(object obj) {
                if (!(obj is AxisItem))
                    return false;
                AxisItem item = (AxisItem)obj;
                return axis.Equals(item.axis);
            }
            public override int GetHashCode() {
                return axis.GetHashCode();
            }
        }
        
        const string SecondaryPostfixX = " (Secondary Axis X)";
        const string SecondaryPostfixY = " (Secondary Axis Y)";
        const string PrimaryPostfixX = " (Primary Axis X)";
        const string PrimaryPostfixY = " (Primary Axis Y)";
        const int LineChart = 0;
        const int BarChart = 1;

        bool loading;
        ChartControl chart;

        XYDiagram Diagram { get { return ChartControl.Diagram as XYDiagram; } }
        SecondaryAxisX SecondaryAxisX { get { return (Diagram != null && Diagram.SecondaryAxesX.Count > 0) ? Diagram.SecondaryAxesX[0] : null; } }
        SecondaryAxisY SecondaryAxisY { get { return (Diagram != null && Diagram.SecondaryAxesY.Count > 0) ? Diagram.SecondaryAxesY[0] : null; } }
        Series FirstSeries { get { return ChartControl.Series.Count > 0 ? ChartControl.Series[0] : null; } }
        Series SecondSeries { get { return ChartControl.Series.Count > 1 ? ChartControl.Series[1] : null; } }
        XYDiagramSeriesViewBase SecondSeriesView { get { return SecondSeries != null ? SecondSeries.View as XYDiagramSeriesViewBase : null; } }
        
        public override ChartControl ChartControl { get { return chart; } }
        
        public SecondaryAxesDemo() {            
            InitializeComponent();
            if (Diagram == null)
                return;
            ((Axis)Diagram.AxisX).Name = "Primary Axis X";
            ((Axis)Diagram.AxisY).Name = "Primary Axis Y";
            Diagram.SecondaryAxesX.Add(new SecondaryAxisX("Secondary Axis X"));
            Diagram.SecondaryAxesY.Add(new SecondaryAxisY("Secondary Axis Y"));
            this.cbChartType.Properties.Items.AddRange(new string[] { "Line", "Bar" });
            loading = true;
            try {
                UpdateChartType();
                if (SecondSeries != null) {
                    UpdateCBSeriesAxisX(Diagram.AxisX);
                    UpdateCBSeriesAxisY(SecondaryAxisY);
                }
            }
            finally {
                loading = false;
            }
        }

        void AttachSecondaryAxisX(SecondaryAxisX axisX) {
            if(axisX == null || Diagram == null)
                return;
            if(SecondSeriesView != null) {
                SecondSeriesView.AxisX = axisX;
                axisX.Visibility = DefaultBoolean.True;
                if(FirstSeries != null)
                    Diagram.AxisX.Title.Text = FirstSeries.Name + PrimaryPostfixX;
                if(SecondaryAxisX != null) {
                    SecondaryAxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                    SecondaryAxisX.Title.Text = SecondSeries.Name + SecondaryPostfixX;
                }
            }
        }
        void AttachSecondaryAxisY(SecondaryAxisY axisY) {
            if(axisY == null || Diagram == null)
                return;
            if(SecondSeriesView != null) {
                SecondSeriesView.AxisY = axisY;
                axisY.Visibility = DefaultBoolean.True;
                if(FirstSeries != null)
                    Diagram.AxisY.Title.Text = FirstSeries.Name + PrimaryPostfixY;
                if(SecondaryAxisY != null) {
                    SecondaryAxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                    SecondaryAxisY.Title.Text = SecondSeries.Name + SecondaryPostfixY;
                }
            }
        }
        void DetachSecondaryAxisX() {
            if(Diagram == null)
                return;
            if(SecondSeriesView != null) {
                if(SecondaryAxisX != null)
                    SecondaryAxisX.Visibility = DefaultBoolean.False;
                SecondSeriesView.AxisX = Diagram.AxisX;
                if(FirstSeries != null)
                    Diagram.AxisX.Title.Text = FirstSeries.Name + ", " + SecondSeries.Name + PrimaryPostfixX;
            }
        }
        void DetachSecondaryAxisY() {
            if(Diagram == null)
                return;
            if(SecondSeriesView != null) {
                if(SecondaryAxisY != null)
                    SecondaryAxisY.Visibility = DefaultBoolean.False;
                SecondSeriesView.AxisY = Diagram.AxisY;
                if(FirstSeries != null)
                    Diagram.AxisY.Title.Text = FirstSeries.Name + ", " + SecondSeries.Name + PrimaryPostfixX;
            }
        }
        void ChangeSeriesViewType(ViewType viewType) {
            foreach (Series series in ChartControl.Series)
                series.ChangeView(viewType);
        }
        void UpdateChartType() {
            int selectedIndex = -1;
            foreach(Series series in chart.Series) {
                if(series.View is LineSeriesView) {
                    selectedIndex = LineChart;
                    break;
                }
                else if(series.View is SideBySideBarSeriesView)
                    selectedIndex = BarChart;
            }
            cbChartType.SelectedIndex = selectedIndex;
        }
        void UpdateCBSeriesAxisX(Axis selectedAxisX) {
            cbSeriesAxisX.Properties.Items.Clear();
            if(Diagram == null)
                return;
            cbSeriesAxisX.Properties.Items.Add(new AxisItem(Diagram.AxisX));
            foreach(SecondaryAxisX axisX in Diagram.SecondaryAxesX)
                cbSeriesAxisX.Properties.Items.Add(new AxisItem(axisX));
            cbSeriesAxisX.SelectedItem = new AxisItem(selectedAxisX);
        }
        void UpdateCBSeriesAxisY(Axis selectedAxisY) {
            cbSeriesAxisY.Properties.Items.Clear();
            if(Diagram == null)
                return;
            cbSeriesAxisY.Properties.Items.Add(new AxisItem(Diagram.AxisY));
            foreach(SecondaryAxisY axisY in Diagram.SecondaryAxesY)
                cbSeriesAxisY.Properties.Items.Add(new AxisItem(axisY));
            cbSeriesAxisY.SelectedItem = new AxisItem(selectedAxisY);
        }
        void cbChartType_SelectedIndexChanged(object sender, EventArgs e) {
            if (loading)
                return;
            if (cbChartType.SelectedIndex == LineChart)
                ChangeSeriesViewType(ViewType.Line);
            else if (cbChartType.SelectedIndex == BarChart)
                ChangeSeriesViewType(ViewType.Bar);
        }
        void cbSeriesAxisX_SelectedIndexChanged(object sender, EventArgs e) {
            SecondaryAxisX axisX = ((AxisItem)cbSeriesAxisX.SelectedItem).Axis as SecondaryAxisX;
            if(axisX != null)
                AttachSecondaryAxisX(axisX);
            else
                DetachSecondaryAxisX();
        }
        void cbSeriesAxisY_SelectedIndexChanged(object sender, EventArgs e) {
            SecondaryAxisY axisY = ((AxisItem)cbSeriesAxisY.SelectedItem).Axis as SecondaryAxisY;
            if(axisY != null)
                AttachSecondaryAxisY(axisY);
            else
                DetachSecondaryAxisY();
        }

        protected override DXPopupMenu ConstructPopupMenu(object obj, ChartControl chartControl) {
            return DXMenuHelper.ConstructSecondaryAxesMenu(obj, chartControl);
        }

        public override void UpdateControls() {
            base.UpdateControls();
            loading = true;
            try {
                UpdateChartType();
                if (SecondSeriesView != null) {
                    UpdateCBSeriesAxisX(SecondSeriesView.AxisX);
                    UpdateCBSeriesAxisY(SecondSeriesView.AxisY);
                }
            }
            finally {
                loading = false;
            }            
        }
    }
}
