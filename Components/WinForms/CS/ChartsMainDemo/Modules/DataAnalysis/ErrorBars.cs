using System;
using System.Drawing;

namespace DevExpress.XtraCharts.Demos.DataAnalysis {

    public partial class ErrorBarsDemo : ChartDemoBase {
        readonly Color indicatorColor = Color.Black;
        public override ChartControl ChartControl { get { return chartControl; } }
        public override bool AnimateChartControlOnDemoAppear { get { return false; } }

        public ErrorBarsDemo() {
            InitializeComponent();
            FillDataSet();
            ChartControl.RefreshData();
            cbeSeriesView.SelectedIndex = 0;
            cbeErrorBarsKind.SelectedIndex = 0;
            cbeEndStyle.SelectedIndex = 0;
            cbeDirection.SelectedIndex = 0;
        }

        void FillDataSet() {
            var table = dataSet.Tables[0];
            table.Rows.Add("A", 20, 5, 8);
            table.Rows.Add("B", 50, 3, 5);
            table.Rows.Add("C", 40, 20, 10);
            table.Rows.Add("D", 22, 15, 5);
            table.Rows.Add("E", 30, 5, 8);
            table.Rows.Add("F", 45, 5, 4);
            table.Rows.Add("G", 35, 5, 3);
            table.Rows.Add("H", 28, 4, 2);
            table.Rows.Add("I", 46, 6, 4);
            table.Rows.Add("J", 27, 8, 20);
            table.Rows.Add("K", 20, 5, 8);
            table.Rows.Add("L", 50, 3, 5);
            table.Rows.Add("M", 40, 20, 10);
            table.Rows.Add("N", 22, 15, 5);
            table.Rows.Add("O", 30, 5, 8);
            table.Rows.Add("P", 45, 5, 2);
            table.Rows.Add("Q", 35, 5, 5);
            table.Rows.Add("R", 28, 4, 4);
            table.Rows.Add("S", 46, 6, 5);
            table.Rows.Add("T", 27, 8, 8);
        }
        void cbeSeriesView_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedViewString = (string)cbeSeriesView.SelectedItem;
            switch (selectedViewString) {
                case "":
                    return;
                case "Bar":
                    ChartControl.Series[0].ChangeView(ViewType.Bar);
                    break;
                case "Point":
                    ChartControl.Series[0].ChangeView(ViewType.Point);
                    break;
                default:
                    throw new Exception(string.Format("The {0} series view is unknown.", selectedViewString));
            }
        }
        void cbeErrorBarsKind_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedErrorBarKind = (string)cbeErrorBarsKind.SelectedItem;
            XYDiagram2DSeriesViewBase view = (XYDiagram2DSeriesViewBase)ChartControl.Series[0].View;
            view.Indicators.Clear();         
            switch (selectedErrorBarKind) {
                case "":
                    return;
                case "Fixed Values":
                    view.Indicators.Add(new FixedValueErrorBars() {NegativeError = 1, PositiveError = 3, Color = this.indicatorColor });
                    break;
                case "Percentage":
                    view.Indicators.Add(new PercentageErrorBars() { Percent = 10, Color = this.indicatorColor });
                    break;
                case "Standard Deviation(s)":
                    view.Indicators.Add(new StandardDeviationErrorBars() { Multiplier = 1, Color = this.indicatorColor });
                    break;
                case "Standard Error":
                    view.Indicators.Add(new StandardErrorBars() { Color = this.indicatorColor });
                    break;
                case "Data Source":
                    view.Indicators.Add(new DataSourceBasedErrorBars() { NegativeErrorDataMember = "Table1.NegativeError", PositiveErrorDataMember = "Table1.PositiveError", Color = this.indicatorColor });
                    ChartControl.RefreshData();
                    break;
                default:
                    throw new Exception(string.Format("The {0} error bar kind is unknown.", selectedErrorBarKind));
            }
            SetDirection();
            SetEndStyle();
        }
        void cbeEndStyle_SelectedIndexChanged(object sender, EventArgs e) {
            SetEndStyle();
        }
        void cbeDirection_SelectedIndexChanged(object sender, EventArgs e) {
            SetDirection();
        }
        void SetDirection() {
            string selectedDirection = (string)cbeDirection.SelectedItem;
            XYDiagram2DSeriesViewBase view = (XYDiagram2DSeriesViewBase)ChartControl.Series[0].View;
            ErrorBars indicator = (ErrorBars)view.Indicators[0];
            switch (selectedDirection) {
                case "":
                    return;
                case "Both":
                    indicator.Direction = ErrorBarDirection.Both;
                    break;
                case "Minus":
                    indicator.Direction = ErrorBarDirection.Minus;
                    break;
                case "Plus":
                    indicator.Direction = ErrorBarDirection.Plus;
                    break;
                default:
                    throw new Exception(string.Format("The {0} error bar direction is unknown.", selectedDirection));
            }
        }
        void SetEndStyle() {
            string selectedStyle = (string)cbeEndStyle.SelectedItem;
            XYDiagram2DSeriesViewBase view = (XYDiagram2DSeriesViewBase)ChartControl.Series[0].View;
            ErrorBars indicator = (ErrorBars)view.Indicators[0];
            switch (selectedStyle) {
                case "":
                    return;
                case "Cap":
                    indicator.EndStyle = ErrorBarEndStyle.Cap;
                    break;
                case "No Cap":
                    indicator.EndStyle = ErrorBarEndStyle.NoCap;
                    break;
                default:
                    throw new Exception(string.Format("The {0} error bar end style is unknown.", selectedStyle));
            }
        }
    }

}
