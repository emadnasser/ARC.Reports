using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Globalization;
using DevExpress.Utils;
using DevExpress.XtraMap.Native;
using DevExpress.XtraCharts;
using DevExpress.XtraGauges.Win.Gauges.Circular;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraLayout;

namespace DevExpress.XtraMap.Demos {

    public partial class SalesDashboard : MapTutorialControl {
        SalesDataGenerator dataGenerator;
        SuperToolTip superToolTip;
        ToolTipTitleItem titleItem;
        ToolTipItem contentItem;

        protected override MapOverlay[] Overlays { get { return OverlayUtils.GetBingOverlays(); } }
        protected SuperToolTip SuperToolTip {
            get {
                if(superToolTip == null)
                    CreateSuperToolTip();
                return superToolTip;
            }
        }
        protected ToolTipTitleItem TitleItem {
            get {
                if(titleItem == null)
                    CreateSuperToolTip();
                return titleItem;
            }
        }
        protected ToolTipItem ContentItem {
            get {
                if(contentItem == null)
                    CreateSuperToolTip();
                return contentItem;
            }
        }
        protected override BingMapKind MiniMapBingKind { get { return BingMapKind.Road; } }
        protected override MiniMapAlignment MiniMapAlignment { get { return MiniMapAlignment.TopLeft; } }
        public override MapControl MapControl { get { return mapControl1; } }

        public SalesDashboard() {
            InitializeComponent();
            InitializeData();
        }
        void InitializeData() {
            DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider);
            this.dataGenerator = new SalesDataGenerator(chartControl1, layoutControlItem3, arcScaleNeedleComponent1);

            ListSourceDataAdapter.DataSource = dataGenerator.Shops;

            chartControl1.DataSource = dataGenerator.ActualStatistics;
            circularGauge1.Scales[0].MinValue = dataGenerator.MinSalesLevel - 10000;
            circularGauge1.Scales[0].MaxValue = dataGenerator.MaxSalesLevel + 10000;
            arcScaleMarkerComponent1.Value = dataGenerator.MinSalesLevel;
            arcScaleMarkerComponent2.Value = dataGenerator.MaxSalesLevel;
        }

        void CreateSuperToolTip() {
            this.superToolTip = new SuperToolTip() { MaxWidth = 350 };
            this.titleItem = new ToolTipTitleItem();
            this.contentItem = new ToolTipItem();
            superToolTip.Items.Add(titleItem);
            superToolTip.Items.Add(contentItem);
        }
        void UpdateSuperToolTip(string content, MapItem item) {
            ContentItem.Text = content;
            if (item != null) {
                string shopName = item.Attributes["ShopName"].Value.ToString();
                ContentItem.Image = (Image)(item.Attributes["ShopImage"].Value);
                TitleItem.Text = shopName;
            }
        }
        void toolTipController1_BeforeShow(object sender, ToolTipControllerShowEventArgs e) {
            MapItem item = e.SelectedObject as MapItem;
            if(item != null) {
                UpdateSuperToolTip(e.ToolTip, item);
                e.AutoHide = false;
                e.SuperTip = SuperToolTip;
            }
        }
        void mapControl1_SelectionChanged(object sender, MapSelectionChangedEventArgs e) {
            ShopInfo selectedShop  = e.Selection.Count > 0 ? e.Selection[0] as ShopInfo : null;
            dataGenerator.SelectedShop = selectedShop;
        }
        protected override void RestoreInitialView() {
            MapControl.CenterPoint = new GeoPoint(37.68D, -122.419D);
            MapControl.ZoomLevel = 11;
        }
    }

    public class ProductGroupInfo {
        readonly string name;

        public String Name { get { return name; } }
        public float Value { get; set; }

        public ProductGroupInfo(float value, string name) {
            this.Value = value;
            this.name = name;
        }
    }

    public class ShopInfo {
        string ConvertShopNameToFilePath(string shopName) {
            string result = shopName.Replace(" ", "");
            result = "Images\\Shops\\" + result.Replace("-", "") + ".png";
            return DemoUtils.GetRelativePath(result);
        }

        readonly string name;
        readonly string phone;
        readonly string fax;
        readonly string address;
        readonly Image image;
        float sales;
        Dictionary<string, float> statistics = new Dictionary<string, float>();
        
        public string Name { get { return name; } }
        public string Phone { get { return phone; } }
        public string Fax { get { return fax; } }
        public string Address { get { return address; } }
        public float Sales { get { return sales; } }
        public double LocationLatitude { get; set; }
        public double LocationLongitude { get; set; }
        public Image Image { get { return image; } }

        public ShopInfo(string name, string address, string phone, string fax) {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.fax = fax;
            this.image = new Bitmap(ConvertShopNameToFilePath(name));
        }
        public void AddProductGroup(string groupName, float sales) {
            if (statistics.ContainsKey(groupName))
                statistics[groupName] = sales;
            else
                statistics.Add(groupName, sales);
            this.sales += sales;
        }
        public float GetSalesByProductGroup(string groupName) {
            return statistics.ContainsKey(groupName) ? statistics[groupName] : 0.0f;
        }
    }

    public class SalesDataGenerator {
        readonly ChartControl chart;
        readonly LayoutControlItem gaugeContainer;
        readonly ArcScaleNeedleComponent needle;
        List<ShopInfo> shops = new List<ShopInfo>();
        List<ProductGroupInfo> actualStatistics = new List<ProductGroupInfo>();
        string salesDescription = string.Empty;
        ShopInfo selectedShop;

        public List<ProductGroupInfo> ActualStatistics { get { return actualStatistics; } }
        public List<ShopInfo> Shops { get { return shops; } }
        public float MaxSalesLevel { get; private set; }
        public float MinSalesLevel { get; private set; }
        public ShopInfo SelectedShop {
            get { return selectedShop; }
            set {
                if (selectedShop == value)
                    return;
                selectedShop = value;
                SelectedShopChanged();
            }
        }

        public SalesDataGenerator(ChartControl chart, LayoutControlItem gaugeContainer, ArcScaleNeedleComponent needle) {
            this.chart = chart;
            this.gaugeContainer = gaugeContainer;
            this.needle = needle;
            LoadDataFromXML();
            UpdateMinMaxSales();
            UpdateTotalStatistics();
        }
        void SelectedShopChanged() {
            if (selectedShop != null)
                UpdateStatistics(selectedShop);
            else
                UpdateTotalStatistics();
        }
        void LoadDataFromXML() {
            List<string> productGroupNames = new List<string>();
            XDocument document = DemoUtils.LoadXml("Sales.xml");
            if (document != null) {
                foreach (XElement element in document.Element("Sales").Elements()) {
                    string shopName = element.Element("ShopName").Value;
                    string shopAddress = element.Element("ShopAddr").Value;
                    string shopPhone = element.Element("ShopPhone").Value;
                    string shopFax = element.Element("ShopFax").Value;
                    ShopInfo info = new ShopInfo(shopName, shopAddress, shopPhone, shopFax);
                    foreach (XElement statElement in element.Element("ShopStatistics").Elements()) {
                        string groupName = statElement.Element("ProductsGroupName").Value;
                        if (!productGroupNames.Contains(groupName))
                            productGroupNames.Add(groupName);
                        float sales = Convert.ToSingle(statElement.Element("ProductGroupSales").Value, CultureInfo.InvariantCulture);
                        info.AddProductGroup(groupName, sales);
                    }
                    info.LocationLatitude = Convert.ToDouble(element.Element("Latitude").Value, CultureInfo.InvariantCulture);
                    info.LocationLongitude = Convert.ToDouble(element.Element("Longitude").Value, CultureInfo.InvariantCulture);
                    Shops.Add(info);
                }
            }
            foreach (string groupName in productGroupNames)
                ActualStatistics.Add(new ProductGroupInfo(0.0f, groupName));
            UpdateTotalStatistics();
        }
        void UpdateStatistics(ShopInfo info) {
            foreach (ProductGroupInfo productGroupInfo in ActualStatistics)
                productGroupInfo.Value = info.GetSalesByProductGroup(productGroupInfo.Name);
            chart.Titles[0].Text = "Sales: " + info.Name;
            chart.RefreshData();
            needle.Value = selectedShop.Sales;
            gaugeContainer.ContentVisible = true;
        }
        void UpdateMinMaxSales() {
            float minSales = Shops[0].Sales;
            float maxSales = Shops[0].Sales;
            foreach (ShopInfo info in Shops) {
                if (info.Sales > maxSales)
                    maxSales = info.Sales;
                if (info.Sales < minSales)
                    minSales = info.Sales;
            }
            MaxSalesLevel = maxSales;
            MinSalesLevel = minSales;
        }

        public void UpdateTotalStatistics() {
            foreach (ProductGroupInfo info in ActualStatistics) {
                info.Value = 0.0f;
                foreach (ShopInfo shopInfo in Shops)
                    info.Value += shopInfo.GetSalesByProductGroup(info.Name);
            }
            gaugeContainer.ContentVisible = false;
            chart.Titles[0].Text = "Sales: All Shops";
            chart.RefreshData();
        }
    }
}
