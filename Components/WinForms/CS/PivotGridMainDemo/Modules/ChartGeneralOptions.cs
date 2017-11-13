using System;
using DevExpress.XtraCharts;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class ChartGeneralOptions : DevExpress.XtraPivotGrid.Demos.TutorialControl {
        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl; } }

        public ChartGeneralOptions() {
            CreateWaitDialog();
            InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\ChartGeneralOptions.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.ChartGeneralOptions.xml";

            pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = ceChartDataVertical.Checked;
            pivotGridControl.OptionsChartDataSource.SelectionOnly = ceSelectionOnly.Checked;
            pivotGridControl.OptionsChartDataSource.ProvideColumnGrandTotals = ceShowColumnGrandTotals.Checked;
            pivotGridControl.OptionsChartDataSource.ProvideRowGrandTotals = ceShowRowGrandTotals.Checked;
            chartControl.CrosshairOptions.ShowArgumentLine = false;

            ViewType[] restrictedTypes = new ViewType[] { ViewType.PolarArea, ViewType.PolarLine, ViewType.ScatterPolarLine, ViewType.SideBySideGantt, ViewType.Bubble,
				ViewType.SideBySideRangeBar, ViewType.RangeBar, ViewType.Gantt, ViewType.PolarPoint, ViewType.PolarRangeArea, ViewType.Stock, ViewType.CandleStick,
                ViewType.SideBySideFullStackedBar, ViewType.SideBySideFullStackedBar3D, ViewType.SideBySideStackedBar, ViewType.SideBySideStackedBar3D };
            foreach(ViewType type in Enum.GetValues(typeof(ViewType))) {
                if(Array.IndexOf<ViewType>(restrictedTypes, type) >= 0) continue;
                comboChartType.Properties.Items.Add(type);
            }
            comboChartType.SelectedItem = ViewType.Bar;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            pivotGridControl.DataSource = GetNWindData("SalesPerson");
            SetFilter();
            SetSelection();
            chartControl.DataSource = pivotGridControl;
        }
        void SetFilter() {
            fieldProductName.FilterValues.SetValues(new object[] {
                "Chai",
                "Chang",
                "Chocolade",
                "Filo Mix",
                "Geitost",
                "Ikura",
                "Konbu",
                "Maxilaku",
                "Pavlova",
                "Spegesild",
                "Tourtiere"
            }, PivotFilterType.Included, true);
            fieldOrderYear.FilterValues.SetValues(new object[] { 2015 }, PivotFilterType.Included, true);
        }
        void SetSelection() {
            pivotGridControl.Cells.SetSelectionByFieldValues(false, new object[] { "Chocolade" });
            pivotGridControl.Cells.SetSelectionByFieldValues(false, new object[] { "Chai" });
        }

        //<comboChartType>
        void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e) {
            chartControl.SeriesTemplate.ChangeView((ViewType)comboChartType.SelectedItem);
            if(chartControl.SeriesTemplate.Label != null) {
                chartControl.SeriesTemplate.LabelsVisibility = checkShowPointLabels.Checked ?
                    DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
                chartControl.CrosshairEnabled = checkShowPointLabels.Checked ?
                    DevExpress.Utils.DefaultBoolean.False : DevExpress.Utils.DefaultBoolean.True;
                checkShowPointLabels.Enabled = true;
            } else {
                checkShowPointLabels.Enabled = false;
            }
            if((chartControl.SeriesTemplate.View as SimpleDiagramSeriesViewBase) == null)
                chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            if(chartControl.Diagram is Diagram3D) {
                Diagram3D diagram = (Diagram3D)chartControl.Diagram;
                diagram.RuntimeRotation = true;
                diagram.RuntimeZooming = true;
                diagram.RuntimeScrolling = true;
            }
            foreach(Series series in chartControl.Series) 
                UpdateSeriesTransparency(series.View);
            UpdateSeriesTransparency(chartControl.SeriesTemplate.View);
        }
        void UpdateSeriesTransparency(SeriesViewBase seriesView) {
            ISupportTransparency supportTransparency = seriesView as ISupportTransparency;
            if (supportTransparency != null) {
                if ((seriesView is AreaSeriesView) || (seriesView is Area3DSeriesView)
                    || (seriesView is RadarAreaSeriesView) || (seriesView is Bar3DSeriesView))
                    supportTransparency.Transparency = 135;
                else
                    supportTransparency.Transparency = 0;
            }
        }
        //</comboChartType>

        //<checkShowPointLabels>
        void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            chartControl.SeriesTemplate.LabelsVisibility = checkShowPointLabels.Checked ?
                DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
            chartControl.CrosshairEnabled = checkShowPointLabels.Checked ?
                DevExpress.Utils.DefaultBoolean.False : DevExpress.Utils.DefaultBoolean.True;
        }
        //</checkShowPointLabels>

        //<ceChartDataVertical>
        void ceChartDataVertical_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = ceChartDataVertical.Checked;
        }
        //</ceChartDataVertical>
        //<ceSelectionOnly>
        void ceSelectionOnly_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl.OptionsChartDataSource.SelectionOnly = ceSelectionOnly.Checked;
            lblUpdateDelay.Enabled = seUpdateDelay.Enabled = ceSelectionOnly.Checked;
        }
        //</ceSelectionOnly>
        //<ceShowColumnGrandTotals>
        void ceShowColumnGrandTotals_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl.OptionsChartDataSource.ProvideColumnGrandTotals = ceShowColumnGrandTotals.Checked;
        }
        //</ceShowColumnGrandTotals>

        //<ceShowRowGrandTotals>
        void ceShowRowGrandTotals_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl.OptionsChartDataSource.ProvideRowGrandTotals = ceShowRowGrandTotals.Checked;
        }
        //</ceShowRowGrandTotals>

        //<seUpdateDelay>
        void seUpdateDelay_EditValueChanged(object sender, EventArgs e) {
            pivotGridControl.OptionsChartDataSource.UpdateDelay = (int)seUpdateDelay.Value;
        }
        //</seUpdateDelay>
    }
}
