using System;
using System.Drawing;

namespace DevExpress.XtraCharts.Demos.PointLineViews {
    public partial class PointDemoBase : ChartDemoBase2D {
		MarkerKindItemCollection itemCollection;
        bool markerControlsEnabled = true;

        protected virtual Series[] ProcessedSeries { get { return new Series[] { seriesSelected }; } }

        public PointDemoBase() {
            InitializeComponent();
        }

        void comboBoxEditMarkerKind_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxEditMarkerKind.SelectedIndex == -1) 
                return;
            foreach (Series series in ProcessedSeries) {
                if (series != null) {
                    PointSeriesView view = series.View as PointSeriesView;
                    MarkerKindItem item = comboBoxEditMarkerKind.SelectedItem as MarkerKindItem;
                    if (view != null && item != null) {
                        view.PointMarkerOptions.Kind = item.MarkerKind;
                        if (item.MarkerKind.Equals(MarkerKind.Star))
                            view.PointMarkerOptions.StarPointCount = ((StarMarkerKindItem)item).PointCount;
                    }
                }
            }
		}
		void comboBoxEditLabelAngle_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.comboBoxEditMarkerKind.SelectedIndex == -1 || this.seriesSelected == null || seriesSelected.View == null)
                return;
			((PointSeriesLabel)seriesSelected.Label).Angle = Int32.Parse(this.comboBoxEditLabelAngle.Text);
		}
		void comboBoxEditMarkerSize_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxEditMarkerKind.SelectedIndex == -1)
                return;
            foreach(Series series in ProcessedSeries) {
                if (series != null) {
                    PointSeriesView view = series.View as PointSeriesView;
                    if (view != null)
                        view.PointMarkerOptions.Size = Int32.Parse(comboBoxEditMarkerSize.Text);
                }
            }
		}
        void DisableControls() {
            comboBoxEditMarkerKind.SelectedIndex = -1;
            comboBoxEditMarkerKind.Enabled = false;
            labelMarkerKind.Enabled = false;
            comboBoxEditLabelAngle.SelectedIndex = -1;
            comboBoxEditLabelAngle.Enabled = false;
            labelAngle.Enabled = false;
            comboBoxEditMarkerSize.SelectedIndex = -1;
            comboBoxEditMarkerSize.Enabled = false;
            labelMarkerSize.Enabled = false;
        }

        protected override void InitControls() {
            base.InitControls();

            this.itemCollection = MarkerKindItemCollection.CreateCollection();
            MarkerKindItem[] items = new MarkerKindItem[itemCollection.Count];
            this.itemCollection.CopyTo(items);
            this.comboBoxEditMarkerKind.Properties.Items.AddRange(items);

            this.comboBoxEditLabelAngle.Properties.Items.AddRange(new string[] { "0", "45", "90", "135", "180", "225", "270", "315" });
            this.comboBoxEditMarkerSize.Properties.Items.AddRange(MarkerKindItemCollection.GetSizeArray());
        }
        protected void EnableMarkerControls(bool enable) {
            this.markerControlsEnabled = enable;
            this.labelMarkerKind.Enabled = enable;
            this.comboBoxEditMarkerKind.Enabled = enable;
            this.labelMarkerSize.Enabled = enable;
            this.comboBoxEditMarkerSize.Enabled = enable;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (seriesSelected == null)
                DisableControls();
            else {
                PointSeriesView view = seriesSelected.View as PointSeriesView;
                if (view == null) {
                    DisableControls();
                    return;
                }
                if (view.PointMarkerOptions.Kind != MarkerKind.Star)
                    comboBoxEditMarkerKind.SelectedItem = itemCollection.GetItemByKind(view.PointMarkerOptions.Kind);
                else
                    comboBoxEditMarkerKind.SelectedItem = itemCollection.GetItemByStarPointCount(view.PointMarkerOptions.StarPointCount);
                PointSeriesLabel pointLabel = seriesSelected.Label as PointSeriesLabel;
                if(pointLabel != null) {
                    comboBoxEditLabelAngle.Enabled = ShowLabels;
                    comboBoxEditLabelAngle.Text = pointLabel.Angle.ToString();
                }
                labelAngle.Enabled = ShowLabels;
                comboBoxEditMarkerSize.Text = view.PointMarkerOptions.Size.ToString();
                EnableMarkerControls(markerControlsEnabled);
            }
        }
    }


	static class RandomPointCalculator {
		static Point[] CalcRandomPoints(Random random, int count, int xMin, int xMax, int yMin, int yMax) {
			if (count > Math.Abs(xMax - xMin) * Math.Abs(yMax - yMin))
				throw new ArgumentException("Parameter \"count\" very large. Can't calculate unique random points.");
			Point[] points = new Point[count];
			for (int i = 0; i < points.Length; i++) {
				bool repeat;
				do {
					repeat = false;
					points[i].X = random.Next(xMin, xMax);
					points[i].Y = random.Next(yMin, yMax);
					for (int k = 0; k < i; k++)
						if (points[k] == points[i]) {
							repeat = true;
							break;
						}
				} while (repeat);
			}
			return points;
		}
        
        public static SeriesPoint[] Calculate(Random random, int count, int xMin, int xMax, int yMin, int yMax) {
            Point[] points = CalcRandomPoints(random, count, xMin, xMax, yMin, yMax);
            SeriesPoint[] seriesPoints = new SeriesPoint[points.Length];
            for (int i = 0; i < points.Length; i++)
                seriesPoints[i] = new SeriesPoint(points[i].X.ToString(), new double[] { points[i].Y });
            return seriesPoints;
        }
    }
}
