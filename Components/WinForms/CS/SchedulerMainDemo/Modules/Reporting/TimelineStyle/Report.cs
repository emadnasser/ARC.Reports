using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.TimelineStyle
{
	/// <summary>
	/// Summary description for Report.
	/// </summary>
	public partial class Report : XtraSchedulerReport {
        string firstTimeScale ="Year";
        string secondTimeScale = "Month";

		public Report() {

			InitializeComponent();
		}
		public int VisibleIntervalCount {
			get { return reportTimelineView1.VisibleIntervalCount; }
            set { reportTimelineView1.VisibleIntervalCount = value; }
		}
        public int VisibleResourceCount {
            get { return reportTimelineView1.VisibleResourceCount; }
            set { reportTimelineView1.VisibleResourceCount = value; }
        }
        public TimeScaleCollection Scales {
            get { return reportTimelineView1.Scales; } 
        }
        public string FirstLevelTimeScale {
            get {
                return firstTimeScale; 
            }
            set {
                if (firstTimeScale == value)
                    return;
                firstTimeScale = value;
                UpdateTimeScales();
            } 
        }
        public string SecondLevelTimeScale {
            get {
                return secondTimeScale; 
            }
            set {
                if (secondTimeScale == value)
                    return;
                secondTimeScale = value;
                UpdateTimeScales();
            } 
        }

        private void UpdateTimeScales() {
            TimeScaleCollection scales = reportTimelineView1.Scales;
            scales.BeginUpdate();
            try {
            foreach (TimeScale item in scales)
                item.Enabled = (item.DisplayName == firstTimeScale) || (item.DisplayName == secondTimeScale);
            } finally {
            scales.EndUpdate();
            }
        }
	}
}
