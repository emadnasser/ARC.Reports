using System;
using System.Globalization;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraCharts.Demos.PointLineViews {
    public partial class BubbleDemo : ChartDemoBase2D {
        static readonly string[] transparencies = { "0", "45", "90", "135", "180", "225", "255" };

        MarkerKindItemCollection itemCollection;

        protected override DefaultBoolean CrosshairEnabled { get { return DefaultBoolean.False; } }
        protected override DefaultBoolean ToolTipEnabled { get { return DefaultBoolean.True; } }

        public override ChartControl ChartControl { get { return this.chart; } }

        Series BubbleSeries { get { return chart.Series.Count > 0 ? chart.Series[0] : null; } }
        BubbleSeriesView BubbleSeriesView { get { return (BubbleSeries != null ? BubbleSeries.View : null) as BubbleSeriesView; } }

        public BubbleDemo() {
            InitializeComponent();
        }

        void cbeMarkerKind_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbeMarkerKind.SelectedIndex >= 0 && BubbleSeriesView != null) {
                MarkerKindItem item = cbeMarkerKind.SelectedItem as MarkerKindItem;
                if (item != null) {
                    BubbleSeriesView.BubbleMarkerOptions.Kind = item.MarkerKind;
                    if (item.MarkerKind.Equals(MarkerKind.Star))
                        BubbleSeriesView.BubbleMarkerOptions.StarPointCount = ((StarMarkerKindItem)item).PointCount;
                }
                ChartControl.Animate();
            }
        }
        void cbeLabelPosition_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbeLabelPosition.SelectedIndex >= 0 && BubbleSeries != null) {
                BubbleSeriesLabel label = BubbleSeries.Label as BubbleSeriesLabel;
                if (label != null)
                    label.Position = (PointLabelPosition)cbeLabelPosition.SelectedIndex;
            }
        }
        void speMaxSize_EditValueChanging(object sender, ChangingEventArgs e) {
            if (BubbleSeriesView != null)
                if (Convert.ToDouble(e.NewValue, CultureInfo.InvariantCulture) <= BubbleSeriesView.MinSize)
                    e.Cancel = true;
        }
        void speMaxSize_EditValueChanged(object sender, EventArgs e) {
            if (BubbleSeriesView != null)
                BubbleSeriesView.MaxSize = Convert.ToDouble(speMaxSize.EditValue);
        }
        void speMinSize_EditValueChanging(object sender, ChangingEventArgs e) {
            if (BubbleSeriesView != null)
                if (Convert.ToDouble(e.NewValue, CultureInfo.InvariantCulture) >= BubbleSeriesView.MaxSize)
                    e.Cancel = true;
        }
        void speMinSize_EditValueChanged(object sender, EventArgs e) {
            if (BubbleSeriesView != null)
                BubbleSeriesView.MinSize = Convert.ToDouble(speMinSize.EditValue);
        }
        void chart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LegendText = ((BubbleDataItem)e.SeriesPoint.Tag).Title;
        }
        void cbeTransparency_SelectedIndexChanged(object sender, EventArgs e) {
            if (BubbleSeriesView != null)
                BubbleSeriesView.Transparency = Convert.ToByte(cbeTransparency.Text);
        }
        protected override void InitControls() {
            base.InitControls();
            itemCollection = MarkerKindItemCollection.CreateCollection();
            MarkerKindItem[] items = new MarkerKindItem[itemCollection.Count];
            itemCollection.CopyTo(items);
            cbeMarkerKind.Properties.Items.AddRange(items);
            cbeMarkerKind.SelectedIndex = (int)BubbleSeriesView.BubbleMarkerOptions.Kind;
            cbeLabelPosition.SelectedIndex = (int)((BubbleSeriesLabel)BubbleSeries.Label).Position;
            speMaxSize.EditValue = BubbleSeriesView.MaxSize;
            speMinSize.EditValue = BubbleSeriesView.MinSize;
            cbeTransparency.Properties.Items.AddRange(transparencies);
            cbeTransparency.SelectedIndex = 2;
            ShowLabels = BubbleSeries.LabelsVisibility == DefaultBoolean.True;
            ChartControl.CrosshairEnabled = DefaultBoolean.False;
            ChartControl.ToolTipEnabled = DefaultBoolean.True;
            BubbleSeries.ToolTipPointPattern = "Production budget: ${V}M\nWorldwide grosses: ${W}B";
            BubbleSeries.DataSource = BubbleData.GetData();
        }
        public override void UpdateControls() {
            base.UpdateControls();
            if (BubbleSeries != null) {
                cbeLabelPosition.Enabled = lblLabelPosition.Enabled = ShowLabels;
                BubbleSeriesLabel label = BubbleSeries.Label as BubbleSeriesLabel;
                if (label != null)
                    cbeLabelPosition.SelectedIndex = (int)label.Position;
                if (BubbleSeriesView != null) {
                    speMaxSize.EditValue = BubbleSeriesView.MaxSize;
                    speMinSize.EditValue = BubbleSeriesView.MinSize;
                }
            }
        }
    }
}
