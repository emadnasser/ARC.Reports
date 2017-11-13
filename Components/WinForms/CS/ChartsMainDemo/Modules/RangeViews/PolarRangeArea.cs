using System;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
    public partial class PolarRangeAreaDemo : ChartDemoBase2D {
        Series Series { get { return chart.Series.Count > 0 ? chart.Series[0] : null; } }
        PolarRangeAreaSeriesView View { get { return Series != null ? Series.View as PolarRangeAreaSeriesView : null; } }
        
        public override ChartControl ChartControl { get { return this.chart; } }

        public PolarRangeAreaDemo() {
            InitializeComponent();
            foreach (Series series in chart.Series)
                series.ToolTipPointPattern = "{A}: {V1:F2} - {V2:F2}";
        }

        void InitializeMarkerKindControls(ComboBoxEdit comboBoxEditMarkerKind, Marker marker) {
            MarkerKindItemCollection itemCollection = MarkerKindItemCollection.CreateCollection();
            MarkerKindItem[] items = new MarkerKindItem[itemCollection.Count];
            itemCollection.CopyTo(items);
            comboBoxEditMarkerKind.Properties.Items.AddRange(items);
            if (marker.Kind != MarkerKind.Star)
                comboBoxEditMarkerKind.SelectedItem = itemCollection.GetItemByKind(marker.Kind);
            else
                comboBoxEditMarkerKind.SelectedItem = itemCollection.GetItemByStarPointCount(marker.StarPointCount);
        }
        void InitializeMarkerSizeControls(ComboBoxEdit comboBoxEditMarkerSize, Marker marker) {
            comboBoxEditMarkerSize.Properties.Items.AddRange(MarkerKindItemCollection.GetSizeArray());
            comboBoxEditMarkerSize.Text = marker.Size.ToString();
        }
        void checkEditShowMinMarkers_CheckedChanged(object sender, EventArgs e) {
            if (View != null)
                View.Marker1Visibility = checkEditShowMinMarkers.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            UpdateControls();
        }
        void checkEditShowMaxMarkers_CheckedChanged(object sender, EventArgs e) {
            if (View != null)
                View.Marker2Visibility = checkEditShowMaxMarkers.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            UpdateControls();
        }
        void comboBoxEditMinMarkerKind_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxEditMinMarkerKind.SelectedIndex == -1)
                return;
            MarkerKindItem item = comboBoxEditMinMarkerKind.SelectedItem as MarkerKindItem;
            if (View != null && item != null) {
                View.Marker1.Kind = item.MarkerKind;
                if (item.MarkerKind.Equals(MarkerKind.Star))
                    View.Marker1.StarPointCount = ((StarMarkerKindItem)item).PointCount;
            }
        }
        void comboBoxEditMaxMarkerKind_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxEditMaxMarkerKind.SelectedIndex == -1)
                return;
            MarkerKindItem item = comboBoxEditMaxMarkerKind.SelectedItem as MarkerKindItem;
            if (View != null && item != null) {
                View.Marker2.Kind = item.MarkerKind;
                if (item.MarkerKind.Equals(MarkerKind.Star))
                    View.Marker2.StarPointCount = ((StarMarkerKindItem)item).PointCount;
            }
        }
        void comboBoxEditMinMarkerSize_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxEditMinMarkerSize.SelectedIndex == -1)
                return;
            if (View != null)
                View.Marker1.Size = Int32.Parse(comboBoxEditMinMarkerSize.Text);
        }
        void comboBoxEditMaxMarkerSize_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxEditMaxMarkerSize.SelectedIndex == -1)
                return;
            if (View != null)
                View.Marker2.Size = Int32.Parse(comboBoxEditMaxMarkerSize.Text);
        }
        void comboBoxLabelKind_SelectedIndexChanged(object sender, EventArgs e) {
            if (Series == null)
                return;
            RadarRangeAreaSeriesLabel label = Series.Label as RadarRangeAreaSeriesLabel;
            if (label == null)
                return;
            switch ((string)comboBoxLabelKind.SelectedItem) {
                case "One Label":
                    label.Kind = RangeAreaLabelKind.OneLabel;
                    break;
                case "Two Labels":
                    label.Kind = RangeAreaLabelKind.TwoLabels;
                    break;
                case "Min Value Label":
                    label.Kind = RangeAreaLabelKind.MinValueLabel;
                    break;
                case "Max Value Label":
                    label.Kind = RangeAreaLabelKind.MaxValueLabel;
                    break;
                case "Value 1 Label":
                    label.Kind = RangeAreaLabelKind.Value1Label;
                    break;
                case "Value 2 Label":
                    label.Kind = RangeAreaLabelKind.Value2Label;
                    break;
                default:
                    label.Kind = RangeAreaLabelKind.TwoLabels;
                    break;
            }
            if (label.Kind == RangeAreaLabelKind.OneLabel)
                label.TextPattern = "{VD:G2}";
            else
                label.TextPattern = "{V:G2}";
        }
        void comboBoxEditFunctionType_SelectedIndexChanged(object sender, EventArgs e) {
            if (ChartControl.Series.Count > 0 && ChartControl.Diagram is PolarDiagram) {
                SeriesPoint[] points = PolarDiagramPointsGenerator.GenerateFunctionPoints((PolarDiagramFunctions)comboBoxEditFunctionType.SelectedIndex, 2);
                ChartControl.Series[0].Points.Clear();
                ChartControl.Series[0].Points.AddRange(points);
                ChartControl.Animate();
            }
        }
        void comboBoxEditDiagramStyle_SelectedIndexChanged(object sender, EventArgs e) {
            PolarDiagram diagram = ChartControl.Diagram as PolarDiagram;
            if (diagram != null)
                diagram.DrawingStyle = (RadarDiagramDrawingStyle)comboBoxEditDiagramStyle.SelectedIndex;
        }

        protected override void InitControls() {
            base.InitControls();
            InitializeMarkerSizeControls(comboBoxEditMinMarkerSize, View.Marker1);
            InitializeMarkerSizeControls(comboBoxEditMaxMarkerSize, View.Marker2);
            InitializeMarkerKindControls(comboBoxEditMinMarkerKind, View.Marker1);
            InitializeMarkerKindControls(comboBoxEditMaxMarkerKind, View.Marker2);
            PolarDiagram diagram = ChartControl.Diagram as PolarDiagram;
            if (diagram != null)
                comboBoxEditDiagramStyle.SelectedIndex = (int)diagram.DrawingStyle;
            foreach (PolarDiagramFunctions function in Enum.GetValues(typeof(PolarDiagramFunctions)))
                comboBoxEditFunctionType.Properties.Items.Add(function.ToString());
            comboBoxEditFunctionType.SelectedIndex = 2;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            comboBoxLabelKind.Enabled = ShowLabels;
            labelLabelKind.Enabled = ShowLabels;
            comboBoxEditMinMarkerSize.Enabled = checkEditShowMinMarkers.Checked;
            labelMinMarkerSize.Enabled = checkEditShowMinMarkers.Checked;
            comboBoxEditMinMarkerKind.Enabled = checkEditShowMinMarkers.Checked;
            labelMinMarkerKind.Enabled = checkEditShowMinMarkers.Checked;
            comboBoxEditMaxMarkerSize.Enabled = checkEditShowMaxMarkers.Checked;
            labelMaxMarkerSize.Enabled = checkEditShowMaxMarkers.Checked;
            comboBoxEditMaxMarkerKind.Enabled = checkEditShowMaxMarkers.Checked;
            labelMaxMarkerKind.Enabled = checkEditShowMaxMarkers.Checked;
        }
    }
}
