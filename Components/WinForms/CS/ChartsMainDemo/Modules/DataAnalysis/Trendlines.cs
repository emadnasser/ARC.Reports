using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraCharts.Demos.DataAnalysis {
    public partial class TrendlinesDemo : ChartDemoBase2D {        
        ConstantLine trendlineBorder = null;
        TrendLine draggingTrendline = null;
        TrendLine selectedTrendline = null;
        ValueLevel startValueLevelForNext = ValueLevel.Close;
        ValueLevel endValueLevelForNext = ValueLevel.Close;
        Color colorForNext = Color.Empty;
        bool extrapolateForNext = true;
        ValueLevel[] valueLevels = new ValueLevel[] { ValueLevel.Low, ValueLevel.High, ValueLevel.Open, ValueLevel.Close };

        ValueLevel StartValueLevel { get { return valueLevels[cbeStarValueLevel.SelectedIndex]; } }
        ValueLevel EndValueLevel { get { return valueLevels[cbeEndValueLevel.SelectedIndex]; } }
        Series CurrentSeries { get { return chart.Series.Count > 0 ? chart.Series[0] : null; } }
        XYDiagram Diagram { get { return chart.Diagram as XYDiagram; } }
        FinancialSeriesViewBase View { get { return CurrentSeries != null ? CurrentSeries.View as FinancialSeriesViewBase : null; } }
        
        public override ChartControl ChartControl { get { return this.chart; } }

        public TrendlinesDemo() {
            InitializeComponent();
        }

        DateTime CalculateArgument(DateTime hitArgument) {            
            for (int i = 0; i < CurrentSeries.Points.Count; i++) {
                if (CurrentSeries.Points[i].DateTimeArgument < hitArgument)
                    return i > 0 ? CurrentSeries.Points[i - 1].DateTimeArgument : CurrentSeries.Points[i].DateTimeArgument;
            }
            return CurrentSeries.Points.Count > 0 ? CurrentSeries.Points[CurrentSeries.Points.Count - 1].DateTimeArgument : hitArgument;
        }
        void DeleteSelectedTrendline() {
            if (View != null && selectedTrendline != null) {
                View.Indicators.Remove(selectedTrendline);
                selectedTrendline = null;
            }
            UpdateControls();
        }
        void FillDefaultTrendlines() {
            TrendLine trendline1 = new TrendLine("Trendline 2");
            trendline1.Point1.Argument = new DateTime(2016, 4, 15);
            trendline1.Point1.ValueLevel = ValueLevel.High;
            trendline1.Point2.Argument = new DateTime(2016, 6, 12);
            trendline1.Point2.ValueLevel = ValueLevel.High;
            trendline1.ExtrapolateToInfinity = false;
            View.Indicators.Add(trendline1);

            TrendLine trendline2 = new TrendLine("Trendline 1");
            trendline2.Point1.Argument = new DateTime(2016, 6, 23);
            trendline2.Point1.ValueLevel = ValueLevel.High;
            trendline2.Point2.Argument = new DateTime(2016, 10, 11);
            trendline2.Point2.ValueLevel = ValueLevel.High;
            View.Indicators.Add(trendline2);

            TrendLine trendline3 = new TrendLine("Trendline 3");
            trendline3.Point1.Argument = new DateTime(2016, 3, 20);
            trendline3.Point1.ValueLevel = ValueLevel.Low;
            trendline3.Point2.Argument = new DateTime(2016, 5, 13);
            trendline3.Point2.ValueLevel = ValueLevel.Low;
            trendline3.ExtrapolateToInfinity = false;
            View.Indicators.Add(trendline3);

            TrendLine trendline4 = new TrendLine("Trendline 4");
            trendline4.Point1.Argument = new DateTime(2016, 6, 27);
            trendline4.Point1.ValueLevel = ValueLevel.Low;
            trendline4.Point2.Argument = new DateTime(2016, 10, 31);
            trendline4.Point2.ValueLevel = ValueLevel.Low;
            View.Indicators.Add(trendline4);
        }
        void FillComboBoxEditByValueLevels(ComboBoxEdit comboboxEdit, ValueLevel selectedValueLevel) {
            comboboxEdit.Properties.Items.AddRange(valueLevels);
            comboboxEdit.SelectedItem = selectedValueLevel;
        }
        void chart_MouseDown(object sender, MouseEventArgs e) {
            if (View == null)
                return;
            ChartHitInfo hitInfo = chart.CalcHitInfo(e.Location);
            if (hitInfo.Indicator is TrendLine || !hitInfo.InDiagram || e.Button != MouseButtons.Left)
                return;
            chart.SelectionMode = ElementSelectionMode.Single;
            selectedTrendline = null;
            draggingTrendline = new TrendLine(View.Indicators.GenerateName("Trendline "));            
            View.Indicators.Add(draggingTrendline);
            DiagramCoordinates coords = Diagram.PointToDiagram(e.Location);
            draggingTrendline.Point1.Argument = CalculateArgument(coords.DateTimeArgument);
            draggingTrendline.Point1.ValueLevel = startValueLevelForNext;
            draggingTrendline.Point2.Argument = draggingTrendline.Point1.Argument;
            draggingTrendline.Point2.ValueLevel = endValueLevelForNext;
            draggingTrendline.ExtrapolateToInfinity = false;
            draggingTrendline.Color = colorForNext;
            trendlineBorder = new ConstantLine();
            trendlineBorder.AxisValue = draggingTrendline.Point1.Argument;
            trendlineBorder.LineStyle.DashStyle = DashStyle.Dash;
            trendlineBorder.LineStyle.Thickness = 1;
            trendlineBorder.ShowInLegend = false;
            View.AxisX.ConstantLines.Add(trendlineBorder);
            chart.Capture = true;
            Cursor.Current = Cursors.SizeWE;
            UpdateControls();            
        }
        void chart_MouseUp(object sender, MouseEventArgs e) {
            if (View == null)
                return;
            if (draggingTrendline != null) {
                draggingTrendline.ExtrapolateToInfinity = extrapolateForNext;
                if (draggingTrendline.Point1.Argument.Equals(draggingTrendline.Point2.Argument))
                    View.Indicators.Remove(draggingTrendline);                
                else
                    chart.SetObjectSelection(draggingTrendline);
                View.AxisX.ConstantLines.Remove(trendlineBorder);
                draggingTrendline = null;                
            }
            chart.Capture = false;            
            Cursor.Current = Cursors.Default;
            UpdateControls();
        }
        void chart_MouseMove(object sender, MouseEventArgs e) {
            if (View == null)
                return;
            ChartHitInfo hitInfo = chart.CalcHitInfo(e.Location);
            if (draggingTrendline != null && e.Button == MouseButtons.Left) {
                if (hitInfo.InDiagram) {
                    DiagramCoordinates coords = Diagram.PointToDiagram(e.Location);
                    if (!coords.IsEmpty) {
                        draggingTrendline.Point2.Argument = CalculateArgument(coords.DateTimeArgument);
                        if ((DateTime)draggingTrendline.Point1.Argument > (DateTime)draggingTrendline.Point2.Argument) {
                            draggingTrendline.Point1.ValueLevel = EndValueLevel;
                            draggingTrendline.Point2.ValueLevel = StartValueLevel;
                        }
                        else {
                            draggingTrendline.Point1.ValueLevel = StartValueLevel;
                            draggingTrendline.Point2.ValueLevel = EndValueLevel;
                        }
                        trendlineBorder.AxisValue = draggingTrendline.Point2.Argument;
                    }
                }
            }
            else if (chart.SelectionMode == ElementSelectionMode.None)
                chart.SelectionMode = ElementSelectionMode.Single;
        }
        void chart_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete)
                DeleteSelectedTrendline();
        }        
        void btnDelete_Click(object sender, EventArgs e) {
           DeleteSelectedTrendline();           
        }
        void btnDeleteAll_Click(object sender, EventArgs e) {
            if (View != null)
                View.Indicators.Clear();
            selectedTrendline = null;
            UpdateControls();
        }
        void cbeStarValueLevel_SelectedIndexChanged(object sender, EventArgs e) {
            if (View != null)
                if (selectedTrendline == null)
                    startValueLevelForNext = StartValueLevel;
                else
                    selectedTrendline.Point1.ValueLevel = StartValueLevel;
        }
        void cbeEndValueLevel_SelectedIndexChanged(object sender, EventArgs e) {
            if (View != null)
                if (selectedTrendline == null)
                    endValueLevelForNext = EndValueLevel;
                else
                    selectedTrendline.Point2.ValueLevel = EndValueLevel;
        }
        void cheExtrapolateToInfinity_CheckedChanged(object sender, EventArgs e) {
            if (selectedTrendline == null)
                extrapolateForNext = cheExtrapolateToInfinity.Checked;
            else
                selectedTrendline.ExtrapolateToInfinity = cheExtrapolateToInfinity.Checked;
        }
        void ceColor_CustomDisplayText(object sender, CustomDisplayTextEventArgs e) {
            if ((Color)e.Value == Color.Empty)
                e.DisplayText = "Default";
        }
        void ceColor_EditValueChanged(object sender, EventArgs e) {
            if (selectedTrendline == null)
                colorForNext = ceColor.Color;
            else
                selectedTrendline.Color = ceColor.Color;
        }
        void ceColor_Properties_ButtonClick(object sender, ButtonPressedEventArgs e) {
            if (e.Button.Kind == ButtonPredefines.Delete)
                ceColor.Color = Color.Empty;
        }
        void chart_BoundDataChanged(object sender, EventArgs e) {
            ChartControl.Animate();
        }

        protected override void InitControls() {
            base.InitControls();
            FillDefaultTrendlines();
            FillComboBoxEditByValueLevels(cbeStarValueLevel, startValueLevelForNext);
            FillComboBoxEditByValueLevels(cbeEndValueLevel, endValueLevelForNext);
            ShowLabels = false;
            CurrentSeries.DataSource = MarketPrices.GetAppleStockPrices();
        }
        protected override void OnChartControlObjectHotTracked(object sender, HotTrackEventArgs e) {
            if (!(e.Object is TrendLine)) {
                if (!chart.Capture)
                    Cursor = Cursors.Default;
                e.Cancel = true;
            }
            else if (draggingTrendline == null)
                Cursor = Cursors.Hand;
            else
                e.Cancel = true;
        }
        protected override void OnChartControlObjectSelected(object sender, HotTrackEventArgs e) {
            if (e.HitInfo.InIndicator)
                selectedTrendline = e.HitInfo.Indicator as TrendLine;
            else
                selectedTrendline = null;
            if (selectedTrendline == null)
                e.Cancel = true;
            UpdateControls();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            btnDelete.Enabled = selectedTrendline != null;
            if (View != null)
                btnDeleteAll.Enabled = View.Indicators.Count != 0;
            if (selectedTrendline == null) {
                cheExtrapolateToInfinity.Checked = extrapolateForNext;
                cbeStarValueLevel.SelectedItem = startValueLevelForNext;
                cbeEndValueLevel.SelectedItem = endValueLevelForNext;
                ceColor.Color = colorForNext;
            }
            else {
                cheExtrapolateToInfinity.Checked = selectedTrendline.ExtrapolateToInfinity;
                cbeStarValueLevel.SelectedItem = selectedTrendline.Point1.ValueLevel;
                cbeEndValueLevel.SelectedItem = selectedTrendline.Point2.ValueLevel;
                ceColor.Color = selectedTrendline.Color;
            }
        }
    }
}
