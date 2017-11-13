using System;
using System.Drawing;
using DevExpress.XtraEditors;

namespace PhotoViewer {
    public partial class DateFilter : XtraUserControl {
        static readonly object selectionChangedCore = new object();
        public DateFilter() {
            InitializeComponent();
            calendar.SizeChanged += startDate_SizeChanged;
        }

        void startDate_SizeChanged(object sender, EventArgs e) {
            UpdateStartDateLocation();
        }
        protected virtual void UpdateStartDateLocation() {
            Point pt = new Point(DisplayRectangle.X + (DisplayRectangle.Width - calendar.Width) / 2, DisplayRectangle.Y + (panel1.Top - DisplayRectangle.Y - calendar.Height) / 2);
            pt.X = Math.Max(0, pt.X);
            pt.Y = Math.Max(0, pt.Y);
            calendar.Location = pt;
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            UpdateStartDateLocation();
        }
        public DateTime StartDate {
            get {
                if(AllowFilter)
                    return calendar.SelectionStart;
                else return DateTime.MinValue;
            }
        }
        public DateTime EndDate {
            get {
                if(AllowFilter)
                    return calendar.SelectionEnd;
                else return DateTime.MinValue;
            }
        }
        public bool AllowFilter {
            get { return allowFilterCheck.Checked; }
        }
        protected void RaiseSelectionChanged() {
            EventHandler handler = Events[selectionChangedCore] as EventHandler;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        public event EventHandler SelectionChanged {
            add { Events.AddHandler(selectionChangedCore, value); }
            remove { Events.RemoveHandler(selectionChangedCore, value); }
        }
        void allowFilterCheck_CheckedChanged(object sender, EventArgs e) {
            RaiseSelectionChanged();
        }
        void startDate_SelectionChanged(object sender, EventArgs e) {
            RaiseSelectionChanged();
        }
        void endDate_SelectionChanged(object sender, EventArgs e) {
            RaiseSelectionChanged();
        }
    }
}
