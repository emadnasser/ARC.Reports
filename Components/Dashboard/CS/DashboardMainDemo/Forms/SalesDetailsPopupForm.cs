using System;
using System.Collections.ObjectModel;
using System.Linq;
using DevExpress.DashboardCommon.ViewerData;
using DevExpress.DashboardWin;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;

namespace DashboardMainDemo {
    public partial class SalesDetailsPopupForm : XtraForm {
        MeasureDescriptor measure = null;
        DimensionDescriptor sparklineDimension = null;
        MultiDimensionalData data = null;

        public SalesDetailsPopupForm() {
            InitializeComponent();
        }
        public void SetPieData(object data) {
            pieChart.DataSource = data;
        }
        public void SetChartData(object data) {
            barChart.DataSource = data;
        }
        public void SetUnitsInStock(object count) {
            lblUnitsInStockCount.Text = count.ToString();
        }
        public void SetGridDataSource(object data) {
            drillThroughGrid.DataSource = data;
        }
        public void PrepareChart(DashboardItemMouseActionEventArgs e) {
            SetData(e);
            SetActiveMeasure(e);
            SetSparklineDimension(e);
            SetChartSeriesName(e);
        }
        private void SetData(DashboardItemMouseActionEventArgs e) {
            this.data = e.Data;
        }
        private void SetSparklineDimension(DashboardItemMouseActionEventArgs e) { 
            DataAxis sparklineAxis = e.Data.GetAxis("Sparkline");
            if(sparklineAxis != null) {
                DimensionDescriptorCollection dimensions = sparklineAxis.Dimensions;
                if(dimensions.Count > 0)
                    this.sparklineDimension = dimensions[0];
            }
        }
        private void SetActiveMeasure(DashboardItemMouseActionEventArgs e) {
            AxisPoint value = e.GetAxisPoint();
            MultiDimensionalData data = e.Data;
            DeltaDescriptor delta = e.GetDeltas()[0];
            foreach(MeasureDescriptor measure in data.GetMeasures()) {
                if(measure.ID == delta.ActualMeasureID) {
                    this.measure = measure;
                }
            }
        }
        private void SetChartSeriesName(DashboardItemMouseActionEventArgs e) {
            barChart.Series[1].Name = measure != null ? measure.DataMember : string.Empty;
        }
        private void barChart_CustomDrawAxisLabel(object sender, DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs e) {
            if(e.Item.Axis.Name == "Primary AxisX") {
                ReadOnlyCollection<AxisPoint> points = data.GetAxisPointsByDimension(sparklineDimension);
                AxisPoint currentPoint = points.FirstOrDefault((point) => { return Object.Equals(point.Value, (int)e.Item.AxisValueInternal); });
                if(currentPoint != null)
                    e.Item.Text = currentPoint.DisplayText;
            }
            else {
                if(measure != null)
                    e.Item.Text = measure.Format(e.Item.AxisValue);
            }
        }
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if(e.Column.ColumnType != typeof(decimal))
                return;
            if(measure != null)
                e.DisplayText = measure.Format(e.CellValue);
        }

        private void barChart_CustomDrawCrosshair(object sender, DevExpress.XtraCharts.CustomDrawCrosshairEventArgs e) {
            foreach (CrosshairElementGroup group in e.CrosshairElementGroups) {
                ReadOnlyCollection<AxisPoint> points = data.GetAxisPointsByDimension(sparklineDimension);
                AxisPoint currentPoint = points.FirstOrDefault((point) => { return Object.Equals(point.Value, (int)group.HeaderElement.SeriesPoints.First().NumericalArgument); });
                if (currentPoint != null)
                    group.HeaderElement.Text = currentPoint.DisplayText;
                foreach (CrosshairElement element in group.CrosshairElements) {
                    if (measure != null) {
                        object value = element.AxisLabelElement.AxisValue;
                        element.LabelElement.Text = element.Series.LegendText + ": " + measure.Format((double)value);
                    }
                }
            }
        }

        private void toolTipController1_BeforeShow(object sender, DevExpress.Utils.ToolTipControllerShowEventArgs e) {
            if(measure != null) {
                e.ToolTip = e.ToolTip + ": " + measure.Format(((SeriesPoint)e.SelectedObject).Values[0]);
            }
        }
    }
}
