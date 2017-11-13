using System.Drawing;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class Colorizer : TreeMapTutorialControl {
        TreeMapPaletteColorizer paletteColorizer;
        TreeMapRangeColorizer rangeColorizer;
        TreeMapGradientColorizer gradientColorizer;
        TreeMapGroupGradientColorizer groupGradientColorizer;

        TreeMapFlatDataAdapter DataAdapter { get { return (TreeMapFlatDataAdapter)treeMapControl1.DataAdapter; } }
        TreeMapPaletteColorizer PaletteColorizer {
            get {
                if (paletteColorizer == null)
                    paletteColorizer = new TreeMapPaletteColorizer() { Palette = Palette.GreenYellowPalette };
                return paletteColorizer;
            }
        }
        TreeMapRangeColorizer RangeColorizer {
            get {
                if (rangeColorizer == null) {
                    rangeColorizer = new TreeMapRangeColorizer() {
                        Palette = Palette.CreatePalette(
                            Color.FromArgb(0xD8, 0x61, 0x0D), Color.FromArgb(0xEF, 0x80, 0x2B),
                            Color.FromArgb(0xFF, 0x9C, 0x11), Color.FromArgb(0xFF, 0xBB, 0x32),
                            Color.FromArgb(0xFF, 0xCD, 0x7C))
                    };
                    rangeColorizer.RangeStops.AddRange(new double[] { 0, 59, 95, 300, 1300, 2500 });
                }
                return rangeColorizer;
            }
        }
        TreeMapGradientColorizer GradientColorizer {
            get {
                if (gradientColorizer == null)
                    gradientColorizer = new TreeMapGradientColorizer() { StartColor = Color.FromArgb(0x33, 0x33, 0x33), EndColor = Color.FromArgb(0xEE, 0xEE, 0xEE) };
                return gradientColorizer;
            }
        }
        TreeMapGroupGradientColorizer GroupGradientColorizer {
            get {
                if (groupGradientColorizer == null)
                    groupGradientColorizer = new TreeMapGroupGradientColorizer() { Palette = Palette.InAFogPalette };
                return groupGradientColorizer;
            }
        }

        public Colorizer() {
            InitializeComponent();
            DataAdapter.DataSource = Utils.CreateDataSet("USLargestCompanies2011.xml");
            UpdateGroups();
            UpdateColorizer();
        }
        void UpdateGroups() {
            if (btnEnableGrouping.Checked)
                DataAdapter.GroupDataMembers.Add("FieldOfActivity");
            else
                DataAdapter.GroupDataMembers.Clear();
        }
        void UpdateColorizer() {
            treeMapControl1.Colorizer = GetColorizer();
        }
        TreeMapColorizerBase GetColorizer() {
            if (btnPalette.Checked)
                return PaletteColorizer;
            if (btnRange.Checked)
                return RangeColorizer;
            if (btnGradient.Checked)
                return GradientColorizer;
            if (btnGroupGradient.Checked)
                return GroupGradientColorizer;
            return null;
        }
        void OnColorizerChanged(object sender, XtraBars.ItemClickEventArgs e) {
            UpdateColorizer();
        }
        void OnEnableGroupingCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            UpdateGroups();
        }
    }
}
