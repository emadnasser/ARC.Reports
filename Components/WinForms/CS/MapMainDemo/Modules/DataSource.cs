using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using DevExpress.Utils;
using System.Xml.Linq;
using System.Globalization;
using DevExpress.XtraBars;

namespace DevExpress.XtraMap.Demos {

    public partial class DataSource : MapTutorialControl {
        List<ShipInfo> ships;
        Font toolTipFont;

        Font ToolTipFont { 
            get {
                if(toolTipFont == null)
                    toolTipFont = new Font(AppearanceObject.DefaultFont.FontFamily, 12, FontStyle.Bold);
                return toolTipFont; 
            } 
        }

        protected override MapOverlay[] Overlays { get { return OverlayUtils.GetBingOverlays(); } }
        public override MapControl MapControl { get { return mapControl1; } }

        public DataSource() {
            InitializeComponent();
            this.ships = LoadShipsFromXML();
            DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider);
            DemoUtils.SetBingMapDataProviderKey(MiniMapDataProvider);
            ListSourceDataAdapter.DataSource = ships; 
            MiniMapDataAdapter.DataSource = ships;
            AutoMergeRibbon = true;
        }

        List<ShipInfo> LoadShipsFromXML() {
            List<ShipInfo> ships = new List<ShipInfo>();
            XDocument document = DemoUtils.LoadXml("Ships.xml");
            if(document != null) {
                foreach(XElement element in document.Element("Ships").Elements()) {
                    double latitude = Convert.ToDouble(element.Element("Latitude").Value, CultureInfo.InvariantCulture);
                    double longitude = Convert.ToDouble(element.Element("Longitude").Value, CultureInfo.InvariantCulture);
                    string name = element.Element("Name").Value;
                    string description = element.Element("Description").Value;
                    string year = element.Element("Year").Value;
                    ships.Add(new ShipInfo() { Latitude = latitude, Longitude = longitude, Description = description, Name = name, Year = year });
                }
            }
            return ships;
        }
        void toolTipController1_BeforeShow(object sender, ToolTipControllerShowEventArgs e) {
            MapCustomElement customElement = (MapCustomElement)(e.SelectedObject);
            ShipInfo shipInfo = (ShipInfo)ItemsLayer.GetItemSourceObject(customElement);

            ToolTipTitleItem titleItem1 = new ToolTipTitleItem() { Text = shipInfo.Header };
            titleItem1.Appearance.ForeColor = SystemColors.GrayText;
            titleItem1.Appearance.Font = ToolTipFont;

            SuperToolTip superToolTip = new SuperToolTip();
            superToolTip.Items.Add(titleItem1);

            ToolTipSeparatorItem sepItem = new ToolTipSeparatorItem();
            superToolTip.Items.Add(sepItem);

            ToolTipItem textItem = new ToolTipItem() { Text = e.ToolTip };
            superToolTip.Items.Add(textItem);
            e.SuperTip = superToolTip;
        }
        void OnDispose(bool disposing) {
            if(this.toolTipFont != null) {
                this.toolTipFont.Dispose();
                this.toolTipFont = null;
            }
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            ChkLockNavigation.Checked = true;
            DisableZoomOptions();
        }
        protected override void ChangeEnableNavigation(bool enable) {
            MapControl.EnableScrolling = enable;
        }
        protected override void RestoreInitialView() {
            MapControl.CenterPoint = new GeoPoint(-36, 145);
            MapControl.ZoomLevel = 6;
        }
    }

    public class ShipInfo {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public string Header { get { return Name + " (" + Year + ")"; } }
    }
}
