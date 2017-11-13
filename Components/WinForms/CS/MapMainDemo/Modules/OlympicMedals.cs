using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace DevExpress.XtraMap.Demos {
    public partial class OlympicMedals : MapTutorialControl {
        readonly FlagsRepository flagsRepository = new FlagsRepository();
        bool gridInitialized;
        OlympicCountry focusedCountry;
            
        ColorListLegend PieColorLegend { get { return (ColorListLegend)(mapControl1.Legends[0]); } }
        SizeLegend PieSizeLegend { get { return (SizeLegend)(mapControl1.Legends[1]); } }
        protected MapCallout Callout { get { return (MapCallout)mapItemStorage1.Items[0]; } }
        protected override MapOverlay[] Overlays { get { return OverlayUtils.GetMedalsOverlay(); } }
        public override MapControl MapControl { get { return mapControl1; } }
        
        public OlympicMedals() {
            AutoMergeRibbon = true;
            InitializeComponent();           
            ShapefileDataAdapter.FileUri = new Uri("file:\\\\" + DemoUtils.GetRelativePath("Countries.shp"), UriKind.RelativeOrAbsolute);
            PrepareDataSource();
        }
        void PrepareDataSource() {
            this.gridInitialized = false;
            OlympicMedalsDataGenerator countryMedals = new OlympicMedalsDataGenerator();
            PieChartDataAdapter.DataSource = countryMedals.Medals;
            this.gridControl1.DataSource = countryMedals.Countries;
            this.gridView1.BestFitColumns();
            this.gridInitialized = true;
        }
        void SetFocusedCountry(OlympicCountry value, bool shouldUpdateMapCenter) {
            if(focusedCountry == value)
                return;
            focusedCountry = value;
            OnFocusedCountryChanged(shouldUpdateMapCenter);
        }
        void OnFocusedCountryChanged(bool shouldUpdateMapCenter) {
            if(focusedCountry != null) {
                int rowIndex = gridView1.FindRow(focusedCountry);
                gridView1.FocusedRowHandle = rowIndex;
                PieLayer.SelectedItem = focusedCountry.GetMedal();
                if(shouldUpdateMapCenter)
                    mapControl1.CenterPoint = focusedCountry.Location;
                ShowCallout();
            } else {
                gridView1.FocusInvalidRow();
                PieLayer.SelectedItem = null;
                HideCallout();
            }
        }
        void ShowCallout() {
            string country = focusedCountry.Country;
            if(!flagsRepository.Contains(country))
                return;
            Callout.Visible = true;
            Callout.Location = focusedCountry.Location;
            Callout.Image = flagsRepository.GetFlag(country, true);
            Callout.Text = string.Format("<b>{0}</b><br><br>Gold = {1}<br>Silver = {2}<br>Bronze = {3}<br>Total = {4}", 
                focusedCountry.Name, focusedCountry.Gold, focusedCountry.Silver, focusedCountry.Bronze, focusedCountry.Total);
        }
        void HideCallout() {
            Callout.Visible = false;
        }
        void OnLegendsButtonCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            UpdateLegendsVisibility();
        }
        void UpdateLegendsVisibility() {
            MapControl.SuspendRender();
            PieColorLegend.Visibility = chkPieColorLegend.Checked ? VisibilityMode.Visible : VisibilityMode.Hidden;
            PieSizeLegend.Visibility = (chkPieInlineLegend.Checked || chkPieNestedLegend.Checked) ? VisibilityMode.Visible : VisibilityMode.Hidden;
            PieSizeLegend.Type = chkPieInlineLegend.Checked ? SizeLegendType.Inline : SizeLegendType.Nested;
            MapControl.ResumeRender();
        }
        void gridView1_FocusedRowChanged(object sender, XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            OlympicCountry focusedCountry = e.FocusedRowHandle != GridControl.InvalidRowHandle ? (OlympicCountry)gridView1.GetFocusedRow() : null;
            SetFocusedCountry(focusedCountry, this.gridInitialized);
        }
        void mapControl1_SelectionChanged(object sender, MapSelectionChangedEventArgs e) {
            Medal selectedMedal = e.Selection.Count > 0 ? (Medal)e.Selection[0] : null;
            SetFocusedCountry(selectedMedal != null ? selectedMedal.Country : null, false);
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            OptionsPage.Groups.Add(rpgLegendType);
            OptionsPage.Ribbon.Items.AddRange(new BarItem[] { chkPieInlineLegend, chkPieNestedLegend });
            ChkLockNavigation.Enabled = false;
        }
        protected override void RestoreInitialView() {
            MapControl.CenterPoint = new GeoPoint(40, 0);
            MapControl.ZoomLevel = 1.7;
        }
        protected override MiniMapLayerBase CreateMiniMapLayer() {
            ShapefileDataAdapter adapter = new XtraMap.ShapefileDataAdapter();
            adapter.FileUri = new Uri("file:\\\\" + DemoUtils.GetRelativePath("Countries.shp"), UriKind.RelativeOrAbsolute);
            MiniMapVectorItemsLayer layer = new MiniMapVectorItemsLayer();
            layer.Data = adapter;
            layer.ItemStyle.Fill = Color.White;
            layer.ItemStyle.Stroke = Color.FromArgb(95, 139, 149);
            return layer;
        }
        #region Grid preparation events
        void gridView1_CustomUnboundColumnData(object sender, XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if(e.Column.Name != "PositionGridColumn")
                return;
            if(gridView1.SortInfo[0].SortOrder == Data.ColumnSortOrder.Descending)
                e.Value = gridView1.GetRowHandle(e.ListSourceRowIndex) + 1;
            else
                e.Value = gridView1.RowCount - gridView1.GetRowHandle(e.ListSourceRowIndex);
        }
        void gridView1_StartSorting(object sender, EventArgs e) {
            string column = gridView1.SortInfo[0].Column.FieldName;
            Data.ColumnSortOrder sortOrder = gridView1.SortInfo[0].SortOrder;
            gridView1.SortInfo.AddRange(new GridColumnSortInfo[] {
                new GridColumnSortInfo(gridView1.Columns["Silver"], sortOrder),
                new GridColumnSortInfo(gridView1.Columns["Bronze"], sortOrder),
                new GridColumnSortInfo(gridView1.Columns["Name"], Data.ColumnSortOrder.Ascending)
            });
        }
        void gridView1_CustomRowCellEdit(object sender, XtraGrid.Views.Grid.CustomRowCellEditEventArgs e) {
            if(e.Column.FieldName == "Name") {
                string info = e.CellValue != null ? e.CellValue.ToString() : string.Empty;
                if(!String.IsNullOrEmpty(info)) {
                    String key = gridView1.GetRowCellValue(e.RowHandle, "Country").ToString().ToLower();
                    if(!flagsRepository.Contains(key))
                        return;
                    InvariantImageRepositoryItem imageView = new InvariantImageRepositoryItem();
                    imageView.PictureGrayed = flagsRepository.GetFlag(key, false);
                    imageView.CheckStyle = CheckStyles.UserDefined;
                    imageView.Caption = "  " + info;
                    imageView.GlyphAlignment = HorzAlignment.Near;
                    gridControl1.RepositoryItems.Add(imageView);
                    e.RepositoryItem = imageView;
                }
            }
        }
        #endregion
    }

    public class Medal {
        OlympicCountry owner;
        public int MedalClass { get; set; }
        public int Quantity { get; set; }
        public OlympicCountry Country { get { return owner; } }
        public string Name { get { return owner.Name; } }
        public GeoPoint Location { get { return owner.Location; } }

        public Medal(OlympicCountry owner) {
            this.owner = owner;
            owner.AddMedal(this);
        }

    }
    public class OlympicCountry {
        readonly List<Medal> medals = new List<Medal>();

        public string Country { get; set; }
        public string Name { get; set; }
        public GeoPoint Location { get; set; }
        public int Gold { get; set; }
        public int Silver { get; set; }
        public int Bronze { get; set; }
        public int Total { get { return Gold + Silver + Bronze; } }

        internal void AddMedal(Medal medal) {
            this.medals.Add(medal);
        }
        public Medal GetMedal() {
            return medals.Count > 0 ? medals[0] : null;
        }
    }
    public class OlympicMedalsDataGenerator {
        readonly List<Medal> medals = new List<Medal>();
        readonly List<OlympicCountry> countries = new List<OlympicCountry>();

        public List<Medal> Medals { get { return medals; } }
        public List<OlympicCountry> Countries { get { return countries; } }

        public OlympicMedalsDataGenerator() {
            medals.Clear();
            countries.Clear();

            DataSet dataSet = new DataSet();
            string path = DemoUtils.GetRelativePath("rio2016.xml");
            dataSet.ReadXml(path);

            CreateObjects(dataSet.Tables[0]);
        }
        void CreateObjects(DataTable source) {
            var data = source.AsEnumerable().GroupBy(row => new {
                Country = row.Field<string>("Country"),
                Name = row.Field<string>("Name"),
                Location = new GeoPoint(row.Field<double>("CapitalLat"), row.Field<double>("CapitalLon"))
            });
            foreach(var group in data) {
                OlympicCountry country = new OlympicCountry() {
                    Location = group.Key.Location,
                    Country = group.Key.Country.ToLower(), Name = group.Key.Name
                };
                var medals = group.Select(row => new {
                    Class = Convert.ToInt32(row["MedalClass"]),
                    Quantity = Convert.ToInt32(row["Quantity"])
                }).ToList();

                foreach(var item in medals) {
                    Medal medal = new Medal(country) { MedalClass = item.Class, Quantity = item.Quantity };
                    Medals.Add(medal);
                    SetCountryMedals(country, medal.MedalClass, medal.Quantity);
                }
                Countries.Add(country);
            }
        }
        void SetCountryMedals(OlympicCountry country, int medalClass, int quantity) {
            switch(medalClass) {
                case 1: country.Gold = quantity;
                    break;
                case 2: country.Silver = quantity;
                    break;
                case 3: country.Bronze = quantity;
                    break;
                default: throw new ArgumentException("Undefined medal class");
            }
        }
    }
}
