using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Xml.Linq;

namespace DevExpress.XtraMap.Demos {

    public partial class Clustering : MapTutorialControl {
        static string AttributeName = "Location";
        static string DensityLegendHeader = "Tree density";
        static string LocationLegendHeader = "Tree location";

        MapClustererBase clusterer;
        ColorListLegend Legend { get { return (ColorListLegend)(mapControl1.Legends[0]); } }
        MapClustererBase Clusterer {
            get { return clusterer; }
            set {
                if(clusterer == value)
                    return;
                if(clusterer != null)
                    UnsubscribeEvents();
                clusterer = value;
                if(clusterer != null)
                    SubscribeEvents();
            }
        }

        protected override MapOverlay[] Overlays { get { return OverlayUtils.GetBingOverlays(); } }
        protected override BingMapKind MiniMapBingKind { get { return BingMapKind.Road; } }
        protected override MiniMapAlignment MiniMapAlignment { get { return MiniMapAlignment.TopLeft; } }
        public override MapControl MapControl { get { return mapControl1; } }

        public Clustering() {
            AutoMergeRibbon = true;
            InitializeComponent();
            DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider);
            ListSourceDataAdapter.DataSource = LoadFromXML();
            UpdateClusterer();
        }
        MapColorizer CreateChoroplethColorizer() {
            ChoroplethColorizer colorizer = new ChoroplethColorizer();
            colorizer.RangeStops.AddRange(new List<double> { 1, 10, 50, 100, 500, 1000, 2000, 3000, 4000, 5000 });
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(0x2f, 0x3d, 0x13)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(0x3d, 0x4f, 0x19)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(0x4c, 0x64, 0x1e)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(0x68, 0x8a, 0x2a)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(0x77, 0x9e, 0x30)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(0x8b, 0xb8, 0x38)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(0x9b, 0xcd, 0x3e)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(0xa7, 0xdd, 0x43)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(0xb7, 0xf2, 0x49)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(0xca, 0xff, 0x68)));
            colorizer.ValueProvider = new MapClusterValueProvider();
            Legend.Header = DensityLegendHeader;
            return colorizer;
        }
        MapColorizer CreateKeyColorColorizer() {
            KeyColorColorizer colorizer = new KeyColorColorizer();
            colorizer.ItemKeyProvider = new AttributeItemKeyProvider() { AttributeName = AttributeName };
            colorizer.PredefinedColorSchema = PredefinedColorSchema.Palette;
            Legend.Header = LocationLegendHeader;
            return colorizer;
        }
        List<TreeInfo> LoadFromXML() {
            List<TreeInfo> trees = new List<TreeInfo>();
            XDocument document = DemoUtils.LoadXml("TreesCl.xml");
            if(document != null) {
                foreach(XElement element in document.Element("RowSet").Elements()) {
                    string location = element.Element("location").Value;
                    string genus = element.Element("genus").Value;
                    double latitude = Convert.ToDouble(element.Element("lat").Value, CultureInfo.InvariantCulture);
                    double longitude = Convert.ToDouble(element.Element("lon").Value, CultureInfo.InvariantCulture);
                    trees.Add(new TreeInfo() { Latitude = latitude, Longitude = longitude, Genus = genus, Location = location });
                }
            }
            return trees;
        }
        MapClustererBase CreateClusterer() {
            if(chkDistanceBasedClustering.Checked)
                return new DistanceBasedClusterer();
            if(chkMarkerClustering.Checked)
                return new MarkerClusterer();
            return null;
        }
        void UpdateClusterer() {
            Clusterer = CreateClusterer();
            ItemsLayer.Colorizer = chkClusteringByAttr.Checked ? CreateKeyColorColorizer() : CreateChoroplethColorizer();
            if(Clusterer != null) {
                Clusterer.GroupProvider = chkClusteringByAttr.Checked ? CreateGroupProvider() : null;
                if(chkCustomFactory.Checked)
                    Clusterer.SetClusterItemFactory(new CustomClusterFactory());
            }
            ListSourceDataAdapter.Clusterer = Clusterer;
        }
        AttributeGroupProvider CreateGroupProvider() {
            return new AttributeGroupProvider() { AttributeName = AttributeName };
        }
        void SubscribeEvents() {
            Clusterer.Clustering += Clusterer_OnClustering;
            Clusterer.Clustered += Clusterer_OnClustered;
        }
        void UnsubscribeEvents() {
            Clusterer.Clustering -= Clusterer_OnClustering;
            Clusterer.Clustered -= Clusterer_OnClustered;
        }
        void Clusterer_OnClustered(object sender, ClusteredEventArgs e) {
            if(SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.CloseDefaultWaitForm();
        }
        void Clusterer_OnClustering(object sender, EventArgs e) {
            SplashScreenManager.ShowDefaultWaitForm(ParentForm, true, true, "", "Clustering...");
        }
        void OnRibbonItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            UpdateClusterer();
        }
        void OnEditValueChanging(object sender, XtraEditors.Controls.ChangingEventArgs e) {
            if(Clusterer != null)
                Clusterer.StepInPixels = (int)e.NewValue;
        }
        void mapControl1_MapItemClick(object sender, MapItemClickEventArgs e) {
            IList<MapItem> groupItems = e.Item.ClusteredItems;
            if(groupItems != null)
                mapControl1.ZoomToFit(groupItems);
        }
        void repositoryItemTrackBar1_BeforeShowValueToolTip(object sender, XtraEditors.TrackBarValueToolTipEventArgs e) {
            TrackBarControl trackBar = sender as TrackBarControl;
            if(trackBar != null)
                e.ShowArgs.ToolTip = string.Format("Step: {0} pixels", trackBar.EditValue);
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            OptionsPage.Groups.AddRange(new RibbonPageGroup[] { rpgClusteringMethod, rpgCustomClusterRepresentative, rpgGroupByAttributeValues, rpgAdditionalOptions });
            OptionsPage.Ribbon.Items.AddRange(new BarItem[] { chkMarkerClustering, chkDistanceBasedClustering, chkWithoutClustering, chkCustomFactory, chkWitoutFactory, 
                                                                chkClusteringByAttr, chkClusteringWitoutAttribute });
        }                                                     
        protected override void RestoreInitialView() {
            MapControl.CenterPoint = new GeoPoint(-37.58, 143.8);
            MapControl.ZoomLevel = 12;
        }
    }
    public class TreeInfo {
        public string Genus { get; set; }
        public string Location { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Type { get { return (int)MapItemType.Dot; } }
    }
    public class CustomClusterFactory : DefaultClusterItemFactory {
        protected override MapItem CreateItemInstance(IList<MapItem> obj) {
            return new MapCallout();
        }
    }
}
