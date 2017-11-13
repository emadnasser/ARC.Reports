using System;
using System.Collections.Generic;
using System.Data;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.Miscellaneous {
	public partial class SelectionDemo : ChartDemoBase2D {
        ChartControl chartBars;
        Dictionary<string, int> colorIndices;
        List<int> paletteIndices = new List<int>();
        Series pieSeries;

        public override ChartControl ChartControl { get { return this.chartBars; } }
        public override object ExportedObject { get { return null; } }

		public SelectionDemo() {
			InitializeComponent();
            this.comboBoxEditSelectionMode.Properties.Items.AddRange(Enum.GetValues(typeof(ElementSelectionMode)));
            this.comboBoxEditSelectionMode.SelectedIndex = 2;
		}		
        
        void InitPieChart() {
            pieSeries = new Series("Total", ViewType.Pie);
            pieSeries.ArgumentDataMember = "Region";
            pieSeries.ValueDataMembers.AddRange("Sales");
            pieSeries.SummaryFunction = "SUM([Sales])";
            pieSeries.LegendTextPattern = "{A} {VP:P}";
            pieSeries.LabelsVisibility = DefaultBoolean.False;
            pieSeries.ToolTipEnabled = DefaultBoolean.True;
            pieSeries.DataSource = DevAV.GetSales();
            chartTotal.Series.Clear();
            chartTotal.Series.Add(pieSeries);
            chartTotal.SeriesSelectionMode = SeriesSelectionMode.Point;
            chartTotal.SelectedItemsChanged += ChartTotal_SelectedItemsChanged;

            chartTotal.BoundDataChanged += ChartTotal_BoundDataChanged;
        }
        void InitBarChart() {
            chartBars.SelectionMode = ElementSelectionMode.None;
            chartBars.DataSource = DevAV.GetSales();
            chartBars.SeriesDataMember = "Region";
            chartBars.Legend.Visibility = DefaultBoolean.False;
            chartBars.SeriesTemplate.ArgumentDataMember = "Year";
            chartBars.SeriesTemplate.DataFilters.ConjunctionMode = ConjunctionTypes.Or;
            chartBars.BoundDataChanged += ChartBars_BoundDataChanged;
            chartBars.SeriesTemplate.CrosshairLabelPattern = "{S} : {V}";
            XYDiagram diagram = this.chartBars.Diagram as XYDiagram;
            if (diagram != null) {
                diagram.AxisX.Title.Text = "Years";
                diagram.AxisX.Label.Staggered = false;
                diagram.AxisY.GridLines.MinorVisible = true;
                diagram.AxisY.Title.Text = "Millions of Dollars";
                diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                diagram.AxisY.Alignment = AxisAlignment.Far;
            }
        }
        void InitColorIndices() {
            colorIndices = new Dictionary<string, int>();
            for (int i = 0; i < pieSeries.Points.Count; i++)
                colorIndices.Add(pieSeries.Points[i].Argument, i);
        }
        void FilterSeries() {
            paletteIndices = new List<int>();
            List<DataFilter> filters = new List<DataFilter>();
            chartBars.SeriesTemplate.DataFilters.Clear();
            foreach (List<object> dataList in chartTotal.SelectedItems) {
                if (dataList.Count > 0) {
                    DataRowView dataRowView = dataList[0] as DataRowView;
                    string region = dataRowView.Row.Field<string>("Region");
                    DataFilter selectedSeriesFilter = new DataFilter("Region", typeof(string).FullName, DataFilterCondition.Equal, region);
                    filters.Add(selectedSeriesFilter);
                    paletteIndices.Add(colorIndices[region]);
                }
            }
            chartBars.SeriesTemplate.DataFilters.AddRange(filters.ToArray());
        }
        void UpdateSeriesColors(List<int> paletteIndices) {
            PaletteEntry[] paletteEntries = chartTotal.GetPaletteEntries(chartTotal.Series[0].Points.Count);
            for (int i = 0; i < paletteIndices.Count; i++)
                chartBars.Series[i].View.Color = paletteEntries[paletteIndices[i]].Color;
        }
        void ChartTotal_BoundDataChanged(object sender, EventArgs e) {
            InitColorIndices();
        }
        void ChartBars_BoundDataChanged(object sender, EventArgs e) {
            UpdateSeriesColors(paletteIndices);
        }
        void ChartTotal_SelectedItemsChanged(object sender, SelectedItemsChangedEventArgs e) {
            FilterSeries();
        }
        void comboBoxEditSelectionMode_SelectedIndexChanged(object sender, EventArgs e) {
            chartTotal.SelectionMode = (ElementSelectionMode)this.comboBoxEditSelectionMode.SelectedItem;
        }
        void ChartBars_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            if (!(e.Object is Series))
                e.Cancel = true;
        }
        void ChartTotal_ObjectSelected(object sender, HotTrackEventArgs e) {
            if (!(e.Object is Series)) {
                e.Cancel = true;
                chartTotal.SelectedItems.Clear();
            }
        }
        protected override void checkEditShowLabels_CheckedChanged(object sender, EventArgs e) {
            chartBars.SeriesTemplate.LabelsVisibility = ShowLabels ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
            chartBars.CrosshairEnabled = checkEditShowLabels.Checked ? DefaultBoolean.False : CrosshairEnabled;
            chartTotal.Series[0].LabelsVisibility = chartBars.SeriesTemplate.LabelsVisibility;
            chartTotal.ToolTipEnabled = ShowLabels ? DefaultBoolean.False : DefaultBoolean.True;
            FilterSeries();
        }
        protected override void InitControls() {
            base.InitControls();
            ShowLabels = false;
            InitPieChart();
            InitBarChart();
        }
        protected override void SetAppearanceName(string appearanceName) {
            chartTotal.AppearanceName = appearanceName;
            chartBars.AppearanceName = appearanceName;
            UpdateSeriesColors(paletteIndices);
        }
        protected override void SetPaletteName(string paletteName) {
            chartTotal.PaletteName = paletteName;
            chartBars.PaletteName = paletteName;
            UpdateSeriesColors(paletteIndices);
        }
    }
}
