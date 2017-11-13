using System;
using System.Windows.Forms;
using DevExpress.Utils.Menu;

namespace DevExpress.XtraCharts.Demos.AdvancedViews {
	public partial class GanttDemo : ChartDemoBase2D {
        static readonly DateTime rightAxisLimit = new DateTime(2006, 11, 13);

		ChartControl chart;
        bool dragging = false;
        Cursor currentCursor;

        GanttDiagram Diagram { get { return chart.Diagram as GanttDiagram; } }
        Series PlannedSeries { get { return chart.GetSeriesByName("Planned"); } }
        Series CompletedSeries { get { return chart.GetSeriesByName("Completed"); } }
        ConstantLine ProgressLine { get { return Diagram.AxisY.ConstantLines[0]; } }
        bool HasConstantLine { get { return Diagram != null && Diagram.AxisY.ConstantLines.Count > 0; } }
		public override ChartControl ChartControl { get { return chart; } }

		public GanttDemo() {
			InitializeComponent();
		}

        void SetCursor() {
            if (currentCursor == null)
                currentCursor = chart.Cursor;
            chart.Cursor = Cursors.VSplit;
        }
        void RestoreCursor() {
            if (currentCursor != null) {
                chart.Cursor = currentCursor;
                currentCursor = null;
            }
        }
        void SetProgressState(DateTime dateTimeValue) {
            if (dateTimeValue > rightAxisLimit)
                dateTimeValue = rightAxisLimit;
            if (CompletedSeries != null && PlannedSeries != null) {
                CompletedSeries.Points.BeginUpdate();
                CompletedSeries.Points.Clear();
                foreach (SeriesPoint point in PlannedSeries.Points) {
                    DateTime plannedStartDate = point.DateTimeValues[0];
                    if (DateTime.Compare(plannedStartDate, dateTimeValue) >= 0)
                        continue;
                    DateTime plannedFinishDate = point.DateTimeValues[1];
                    DateTime completedFinishDate;
                    if (DateTime.Compare(dateTimeValue, plannedFinishDate) > 0)
                        completedFinishDate = plannedFinishDate;
                    else
                        completedFinishDate = dateTimeValue;
                    CompletedSeries.Points.Add(new SeriesPoint(point.Argument, new DateTime[] { plannedStartDate, completedFinishDate }));
                }
                CompletedSeries.Points.EndUpdate();
            }
            if (HasConstantLine)
                ProgressLine.AxisValue = dateTimeValue;
        }
        void chart_MouseDown(object sender, MouseEventArgs e) {
            if (Diagram == null)
                return;
            DiagramCoordinates coords = Diagram.PointToDiagram(e.Location);
            if (!coords.IsEmpty && HasConstantLine) {
                TimeSpan dif = coords.DateTimeValue > (DateTime)ProgressLine.AxisValue ?
                    coords.DateTimeValue - (DateTime)ProgressLine.AxisValue : (DateTime)ProgressLine.AxisValue - coords.DateTimeValue;
                if (dif < TimeSpan.FromDays(1)) {
                    dragging = true;
                    chart.Capture = true;
                    SetCursor();
                }
            }
        }
        void chart_MouseUp(object sender, MouseEventArgs e) {
            dragging = false;
            chart.Capture = false;
        }
        void chart_MouseMove(object sender, MouseEventArgs e) {
            if (Diagram == null)
                return;
            if (dragging && (e.Button & MouseButtons.Left) == 0) {
                dragging = false;
                chart.Capture = false;
            }
            DiagramCoordinates coords = Diagram.PointToDiagram(e.Location);
            if (coords.IsEmpty) 
                RestoreCursor();
            else {
                if (dragging)
                    SetProgressState(coords.DateTimeValue);
                TimeSpan dif = coords.DateTimeValue > (DateTime)ProgressLine.AxisValue ?
                    coords.DateTimeValue - (DateTime)ProgressLine.AxisValue : (DateTime)ProgressLine.AxisValue - coords.DateTimeValue;
                if (HasConstantLine && dif < TimeSpan.FromDays(1))
                    SetCursor();
                else
                    RestoreCursor();
            }
        }

        protected override void InitControls() {
            base.InitControls();
            ShowLabels = false;
        }
        protected override DXPopupMenu ConstructPopupMenu(object obj, ChartControl chartControl) {
            return DXMenuHelper.ConstructGanttMenu(obj, chartControl);
        }
        protected override void DoShow() {
            base.DoShow();
            var diagram = (XYDiagram)ChartControl.Diagram;
            diagram.AxisY.ConstantLines[0].Visible = false;
        }

        void chart_AnimationEnded(object sender, EventArgs e) {
            var diagram = (XYDiagram)ChartControl.Diagram;
            diagram.AxisY.ConstantLines[0].Visible = true;
        }
    }
}
