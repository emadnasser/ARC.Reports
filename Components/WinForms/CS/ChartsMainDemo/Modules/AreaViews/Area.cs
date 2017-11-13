using System;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.AreaViews {
    public partial class AreaDemo : ChartDemoBase2D {
        ChartControl chart;
        ComboBoxEdit comboBoxEditLabelAngle;
        ComboBoxEdit comboBoxEditMarkerKind;
        ComboBoxEdit comboBoxEditMarkerSize;
        CheckEdit checkEditShowMarkers;

        protected bool ShowMarkers { get { return checkEditShowMarkers.Checked; } }

        public override ChartControl ChartControl { get { return chart; } }

        public AreaDemo() {
            InitializeComponent();
        }

        void comboTransparencies_SelectedIndexChanged(object sender, EventArgs e) {
            AreaSeriesView view = ChartControl.SeriesTemplate.View as AreaSeriesView;
            if (view != null)
                view.Transparency = Convert.ToByte(comboTransparencies.Text);
        }
        void checkEditShowMarkers_CheckedChanged(object sender, EventArgs e) {
            AreaSeriesView view = ChartControl.SeriesTemplate.View as AreaSeriesView;
            if (view != null)
                view.MarkerVisibility = checkEditShowMarkers.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            UpdateControls();
        }
        void comboBoxEditMarkerKind_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxEditMarkerKind.SelectedIndex == -1)
                return;
            AreaSeriesView view = ChartControl.SeriesTemplate.View as AreaSeriesView;
            if (view != null) {
                MarkerKindItem item = (MarkerKindItem)comboBoxEditMarkerKind.SelectedItem;
                view.PointMarkerOptions.Kind = item.MarkerKind;
                if (item.MarkerKind.Equals(MarkerKind.Star))
                    view.PointMarkerOptions.StarPointCount = ((StarMarkerKindItem)item).PointCount;
            }
            UpdateControls();
        }
        void comboBoxEditMarkerSize_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxEditMarkerKind.SelectedIndex == -1)
                return;
            AreaSeriesView view = ChartControl.SeriesTemplate.View as AreaSeriesView;
            if (view != null)
                view.MarkerOptions.Size = Convert.ToInt32(comboBoxEditMarkerSize.Text);
        }
        void comboBoxEditLabelAngle_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxEditMarkerKind.SelectedIndex == -1)
                return;
            PointSeriesLabel label = ChartControl.SeriesTemplate.Label as PointSeriesLabel;
            if (label != null)
                label.Angle = Convert.ToInt32(comboBoxEditLabelAngle.Text);
        }

        protected override void InitControls() {
            itemCollection = MarkerKindItemCollection.CreateCollection();
            MarkerKindItem[] items = new MarkerKindItem[itemCollection.Count];
            itemCollection.CopyTo(items);
            comboBoxEditMarkerKind.Properties.Items.AddRange(items);
            comboBoxEditLabelAngle.Properties.Items.AddRange(new string[] { "0", "45", "90", "135", "180", "225", "270", "315" });
            comboBoxEditMarkerSize.Properties.Items.AddRange(MarkerKindItemCollection.GetSizeArray());
            base.InitControls();
            comboTransparencies.Properties.Items.AddRange(new string[] { "0", "45", "90", "135", "180", "225", "255" });
            checkEditShowMarkers.Checked = ((AreaSeriesView)ChartControl.SeriesTemplate.View).MarkerVisibility == DefaultBoolean.True;
            ChartControl.DataSource = DevAV.GetOutsideVendorCosts();
        }

        public override void UpdateControls() {
            base.UpdateControls();
            AreaSeriesView view = ChartControl.SeriesTemplate.View as AreaSeriesView;
            comboTransparencies.Text = view.Transparency.ToString();
            comboBoxEditMarkerKind.Enabled = ShowMarkers;
            labelMarkerKind.Enabled = ShowMarkers;
            labelAngle.Enabled = ShowLabels;
            comboBoxEditLabelAngle.Enabled = ShowLabels;
            comboBoxEditLabelAngle.Text = ((PointSeriesLabel)ChartControl.SeriesTemplate.Label).Angle.ToString();
            comboBoxEditMarkerSize.Enabled = ShowMarkers;
            comboBoxEditMarkerSize.Text = view.PointMarkerOptions.Size.ToString();
            labelMarkerSize.Enabled = ShowMarkers;
            if (view.PointMarkerOptions.Kind != MarkerKind.Star)
                comboBoxEditMarkerKind.SelectedItem = itemCollection.GetItemByKind(view.PointMarkerOptions.Kind);
            else
                comboBoxEditMarkerKind.SelectedItem = itemCollection.GetItemByStarPointCount(view.PointMarkerOptions.StarPointCount);
        }
    }
}
