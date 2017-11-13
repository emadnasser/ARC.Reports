using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System.Collections;
using System.Linq;
using DevExpress.XtraMap.Native;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Globalization;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraMap.Demos {
    public partial class BubbleCharts : MapTutorialControl {
        DataTable table;

        SizeLegend SizeLegend { get { return (SizeLegend)(mapControl1.Legends[0]); } }
        ColorScaleLegend ColorLegend { get { return (ColorScaleLegend)(mapControl1.Legends[1]); } }
        KeyColorColorizer Colorizer { get { return (KeyColorColorizer)ItemsLayer.Colorizer; } }
        protected override MapOverlay[] Overlays { get { return OverlayUtils.GetBingOverlays(); } }
        protected override MiniMapAlignment MiniMapAlignment { get { return MiniMapAlignment.TopRight; } }
        protected override BingMapKind MiniMapBingKind { get { return BingMapKind.Hybrid; } }
        public override MapControl MapControl { get { return mapControl1; } }

        public BubbleCharts() {
            InitializeComponent();
            Colorizer.ItemKeyProvider = new BubbleGroupKeyProvider();
            DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider);
            SetData();
            this.barEditItem2.EditValue = new TrackBarRange(65, 96);
            AutoMergeRibbon = true;
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
        }

        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            SetDecadeFiltersStyle(Colorizer);
        }
        void SetData() {
            table = CreateDataSet();
            double min = 6.5;
            double max = 9.6;
            UpdateFilter(min, max);
            UpdateColorLegend();
            BubbleChartDataAdapter.DataSource = table;
        }
        DataTable CreateDataSet() {
            DataSet ds = new DataSet();
            string path = DemoUtils.GetRelativePath("Earthquakes.xml");
            ds.ReadXml(path);
            DataTable table = ds.Tables[0];
            table.Locale = CultureInfo.InvariantCulture;
            table.Columns.Add("Type", typeof(int));
            table.Columns["Type"].Expression = "(yr - 1960) / 10 - 0.49";
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns["Date"].Expression = DemoUtils.ComplexDateExpression;
            return table;
        }
        void barEditItem1_EditValueChanged(object sender, EventArgs e) {
            string value = ((BarEditItem)sender).EditValue.ToString();
            UpdateMarkerType(BubbleChartDataAdapter, value);
        }
        void UpdateMarkerType(BubbleChartDataAdapter data, string value) {
            switch (value) {
                case "Circle": data.MarkerType = MarkerType.Circle; break;
                case "Cross": data.MarkerType = MarkerType.Cross; break;
                case "Diamond": data.MarkerType = MarkerType.Diamond; break;
                case "Hexagon": data.MarkerType = MarkerType.Hexagon; break;
                case "InvertedTriangle": data.MarkerType = MarkerType.InvertedTriangle; break;
                case "Pentagon": data.MarkerType = MarkerType.Pentagon; break;
                case "Plus": data.MarkerType = MarkerType.Plus; break;
                case "Square": data.MarkerType = MarkerType.Square; break;
                case "Star5": data.MarkerType = MarkerType.Star5; break;
                case "Star6": data.MarkerType = MarkerType.Star6; break;
                case "Star8": data.MarkerType = MarkerType.Star8; break;
                case "Triangle": data.MarkerType = MarkerType.Triangle; break;
            }
        }
        void repositoryItemRangeTrackBar1_EditValueChanged(object sender, EventArgs e) {
            MapControl.SuspendRender();
            TrackBarRange range = ((RangeTrackBarControl)sender).Value;
            UpdateFilter(0.1 * range.Minimum, 0.1 * range.Maximum);
            MapControl.ResumeRender();
        }
        void barCheckItem_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            if(barEditItem2.EditValue == null) return;
            MapControl.SuspendRender();
            TrackBarRange range = (TrackBarRange)barEditItem2.EditValue;
            UpdateFilter(0.1 * range.Minimum, 0.1 * range.Maximum);
            UpdateColorLegend();
            MapControl.ResumeRender();
        }
        void UpdateColorLegend() {
            ColorLegend.CustomItems.Clear();
            SetDecadeFiltersStyle(Colorizer);
            GetCheckedColorItems(Colorizer);
        }
        void SetDecadeFiltersStyle(KeyColorColorizer colorizer) {
            Color color1 = barCheckItem1.Checked ? colorizer.Colors[0] : DefaultAppearance.BackColor;
            barCheckItem1.ItemAppearance.Normal.BackColor = color1;
            barCheckItem1.ItemAppearance.Hovered.BackColor = color1;
            barCheckItem1.ItemAppearance.Pressed.BackColor = color1;
            Color color2 = barCheckItem2.Checked ? colorizer.Colors[1] : DefaultAppearance.BackColor;
            barCheckItem2.ItemAppearance.Normal.BackColor = color2;
            barCheckItem2.ItemAppearance.Hovered.BackColor = color2;
            barCheckItem2.ItemAppearance.Pressed.BackColor = color2;
            Color color3 = barCheckItem3.Checked ? colorizer.Colors[2] : DefaultAppearance.BackColor;
            barCheckItem3.ItemAppearance.Normal.BackColor = color3;
            barCheckItem3.ItemAppearance.Hovered.BackColor = color3;
            barCheckItem3.ItemAppearance.Pressed.BackColor = color3;
            Color color4 = barCheckItem4.Checked ? colorizer.Colors[3] : DefaultAppearance.BackColor;
            barCheckItem4.ItemAppearance.Normal.BackColor = color4;
            barCheckItem4.ItemAppearance.Hovered.BackColor = color4;
            barCheckItem4.ItemAppearance.Pressed.BackColor = color4;
        }
        void GetCheckedColorItems(KeyColorColorizer colorizer) {
            if(barCheckItem1.Checked) {
                ColorizerKeyItem keyItem = colorizer.Keys[0];
                ColorLegend.CustomItems.Add(new ColorLegendItem() { Color = colorizer.Colors[0], Text = keyItem.Name });
            }
            if(barCheckItem2.Checked) {
                ColorizerKeyItem keyItem = colorizer.Keys[1];
                ColorLegend.CustomItems.Add(new ColorLegendItem() { Color = colorizer.Colors[1], Text = keyItem.Name });
            }
            if(barCheckItem3.Checked) {
                ColorizerKeyItem keyItem = colorizer.Keys[2];
                ColorLegend.CustomItems.Add(new ColorLegendItem() { Color = colorizer.Colors[2], Text = keyItem.Name });
            }
            if(barCheckItem4.Checked) {
                ColorizerKeyItem keyItem = colorizer.Keys[3];
                ColorLegend.CustomItems.Add(new ColorLegendItem() { Color = colorizer.Colors[3], Text = keyItem.Name });
            }
        }
        void UpdateFilter(double minMagnitude, double maxMagnitude) {
            if(table == null) return;
            string magnitudeFilter = GetMagnitudeFilter(minMagnitude, maxMagnitude);
            string yearFilter = GetYearFilterString();
            string filter = string.Format(CultureInfo.InvariantCulture, "({0}) AND ({1})", magnitudeFilter, yearFilter);
            table.DefaultView.RowFilter = filter;
        }
        string GetMagnitudeFilter(double min, double max) {
            return string.Format(CultureInfo.InvariantCulture, "mag >= {0} AND mag <= {1}", min, max);
        }
        string GetYearFilterString() {
            string filter = "";
            string baseStr = "(yr >= {0} AND yr < {1}) OR ";

            if(barCheckItem1.Checked)
                filter = string.Concat(filter, string.Format(baseStr, 1960, 1970));
            if(barCheckItem2.Checked)
                filter = string.Concat(filter, string.Format(baseStr, 1970, 1980));
            if(barCheckItem3.Checked)
                filter = string.Concat(filter, string.Format(baseStr, 1980, 1990));
            if(barCheckItem4.Checked)
                filter = string.Concat(filter, string.Format(baseStr, 1990, 2000));
            if(filter.Length > 0)
                filter = filter.Remove(filter.Length - 4, 4);
            return (filter.Length > 0) ? filter : "FALSE";
        }
        void OnDispose(bool disposing) {
            if(this.table != null) {
                this.table.Dispose();
                this.table = null;
            }
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            OptionsPage.Groups.AddRange(new RibbonPageGroup[] { rpgDecadeFilter, rpgMagniduteFilter, rpgMarkerKind });
        }
        protected override void RestoreInitialView() {
            MapControl.CenterPoint = new GeoPoint();
            MapControl.ZoomLevel = 2;
        }
    }
    public class BubbleGroupKeyProvider : IColorizerItemKeyProvider {
        object IColorizerItemKeyProvider.GetItemKey(object item) {
            MapBubble bubble = item as MapBubble;
            return bubble != null ?  bubble.Group.ToString() : null;
        }
    }
}
