using System;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
    public partial class RadarPolarDemoBase : ChartDemoBase2D {
        LabelControl labelMarkerKind;
        LabelControl labelMarkerSize;
        MarkerKindItemCollection itemCollection;

        protected virtual bool ShowMarkers { get { return true; } set { } }
        protected virtual bool ShowDiagramStyle { get { return true; } }
        protected override bool SeriesSelection { get { return true; } }
        
        public RadarPolarDemoBase() {
            InitializeComponent();
            labelDiagramStyle.Visible = ShowDiagramStyle;
            comboBoxEditDiagramStyle.Visible = ShowDiagramStyle;
        }
        
        void comboBoxEditMarkerKind_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.comboBoxEditMarkerKind.SelectedIndex == -1 || seriesSelected == null)
                return;
            RadarPointSeriesView view = seriesSelected.View as RadarPointSeriesView;
            if (view != null) {
                MarkerKindItem item = (MarkerKindItem)this.comboBoxEditMarkerKind.SelectedItem;
                view.PointMarkerOptions.Kind = item.MarkerKind;
                if (item.MarkerKind.Equals(MarkerKind.Star))
                    view.PointMarkerOptions.StarPointCount = ((StarMarkerKindItem)item).PointCount;
            }
        }
        void comboBoxEditMarkerSize_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.comboBoxEditMarkerKind.SelectedIndex == -1 || this.seriesSelected == null)
                return;
            RadarPointSeriesView view = seriesSelected.View as RadarPointSeriesView;
            if (view != null)
                view.PointMarkerOptions.Size = Int32.Parse(this.comboBoxEditMarkerSize.Text);
        }
        void comboBoxEditDiagramStyle_SelectedIndexChanged(object sender, EventArgs e) {
            RadarDiagram diagram = ChartControl.Diagram as RadarDiagram;
            if (diagram != null)
                diagram.DrawingStyle = (RadarDiagramDrawingStyle)comboBoxEditDiagramStyle.SelectedIndex;
        }
        
        protected override void InitControls() {
            base.InitControls();
            this.itemCollection = MarkerKindItemCollection.CreateCollection();
            MarkerKindItem[] items = new MarkerKindItem[this.itemCollection.Count];
            this.itemCollection.CopyTo(items);
            this.comboBoxEditMarkerKind.Properties.Items.AddRange(items);
            if (ChartControl.Series.Count > 0)
                ShowLabels = ChartControl.Series[0].LabelsVisibility == DevExpress.Utils.DefaultBoolean.True;
            RadarDiagram diagram = ChartControl.Diagram as RadarDiagram;
            if (diagram != null)
                comboBoxEditDiagramStyle.SelectedIndex = (int)diagram.DrawingStyle;
            this.comboBoxEditMarkerSize.Properties.Items.AddRange(MarkerKindItemCollection.GetSizeArray());
        }
        protected void EnableMarkerControls(bool enable) {
            this.labelMarkerKind.Enabled = enable;
            this.comboBoxEditMarkerKind.Enabled = enable;
            this.labelMarkerSize.Enabled = enable;
            this.comboBoxEditMarkerSize.Enabled = enable;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (this.seriesSelected == null) {
                this.comboBoxEditMarkerKind.SelectedIndex = -1;
                this.comboBoxEditMarkerKind.Enabled = false;
                this.labelMarkerKind.Enabled = false;
                this.comboBoxEditMarkerSize.SelectedIndex = -1;
                this.comboBoxEditMarkerSize.Enabled = false;
                this.labelMarkerSize.Enabled = false;
            }
            else {
                RadarPointSeriesView view = seriesSelected.View as RadarPointSeriesView;
                if (view != null) {
                    if (view.PointMarkerOptions.Kind != MarkerKind.Star)
                        this.comboBoxEditMarkerKind.SelectedItem = this.itemCollection.GetItemByKind(view.PointMarkerOptions.Kind);
                    else
                        this.comboBoxEditMarkerKind.SelectedItem = this.itemCollection.GetItemByStarPointCount(view.PointMarkerOptions.StarPointCount);
                    this.comboBoxEditMarkerKind.Enabled = ShowMarkers;
                    this.labelMarkerKind.Enabled = ShowMarkers;
                    this.comboBoxEditMarkerSize.Enabled = ShowMarkers;
                    this.labelMarkerSize.Enabled = ShowMarkers;
                    this.comboBoxEditMarkerSize.Text = view.PointMarkerOptions.Size.ToString();
                }
            }
        }
    }
}
