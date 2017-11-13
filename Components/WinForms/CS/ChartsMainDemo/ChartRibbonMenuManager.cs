using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraCharts.Demos {

    public class ChartRibbonMenuManager : RibbonMenuManager {
        BarSubItem bsiAppearances;
        BarSubItem bsiPalettes;

        public TutorialControl CurrentModule { get; set; }

        public ChartRibbonMenuManager(RibbonMainForm form)
            : base(form) {
            CreateChartAppearanceMenu(form.ReservGroup1);
            CreateChartWizardMenu(form.ReservGroup2);
        }
        void CreateChartAppearanceMenu(RibbonPageGroup ribbonPageGroup) {
            ribbonPageGroup.Text = "Chart Appearance";
            ChartControl chart = new ChartControl();
            bsiAppearances = new BarSubItem();
            bsiAppearances.Caption = "Appearance";
            bsiAppearances.Glyph = global::DevExpress.XtraCharts.Demos.Properties.Resources.Appearance_16x16;
            bsiAppearances.LargeGlyph = global::DevExpress.XtraCharts.Demos.Properties.Resources.Appearance_32x32;
            string[] appearanceNames = chart.GetLocalizedAppearanceNames();
            int defaultIndex = 0;
            for (int i = 0; i < appearanceNames.Length; i++) {
                CheckBarItem cbiAppearanceName = new CheckBarItem(Manager, appearanceNames[i], new ItemClickEventHandler(cbiAppearanceName_Click));
                if (appearanceNames[i] == chart.AppearanceName)
                    defaultIndex = i;
                bsiAppearances.AddItem(cbiAppearanceName);
            }
            ribbonPageGroup.ItemLinks.Add(bsiAppearances);
            if (appearanceNames.Length > 0) {
                CheckBarItem item = bsiAppearances.ItemLinks[defaultIndex].Item as CheckBarItem;
                if (bsiAppearances != null) {
                    cbiAppearanceName_Click(Manager, new ItemClickEventArgs(item, null));
                    item.Checked = true;
                }
            }
            bsiPalettes = new BarSubItem();
            bsiPalettes.Caption = "Palette";
            bsiPalettes.Glyph = global::DevExpress.XtraCharts.Demos.Properties.Resources.Palette_16x16;
            bsiPalettes.LargeGlyph = global::DevExpress.XtraCharts.Demos.Properties.Resources.Palette_32x32;
            string[] paletteNames = chart.GetLocalizedPaletteNames();
            defaultIndex = 0;
            for (int i = 0; i < paletteNames.Length; i++) {
                CheckBarItem cbiPaletteName = new CheckBarItem(Manager, paletteNames[i], new ItemClickEventHandler(cbiPaletteName_Click));
                if (paletteNames[i] == chart.PaletteName)
                    defaultIndex = i;
                bsiPalettes.ItemLinks.Add(cbiPaletteName);
            }
            ribbonPageGroup.ItemLinks.Add(bsiPalettes);
            if (paletteNames.Length > 0) {
                CheckBarItem item = bsiPalettes.ItemLinks[defaultIndex].Item as CheckBarItem;
                if (bsiPalettes != null) {
                    cbiPaletteName_Click(Manager, new ItemClickEventArgs(item, null));
                    item.Checked = true;
                }
            }
            chart.Dispose();
        }
        void CreateChartWizardMenu(RibbonPageGroup ribbonPageGroup) {
            ribbonPageGroup.Text = "Designer";
            ButtonBarItem bbiWizard = new ButtonBarItem(Manager, "Run Chart Designer...", new ItemClickEventHandler(bbiWizard_Click));
            bbiWizard.Glyph = global::DevExpress.XtraCharts.Demos.Properties.Resources.Wizard_16x16;
            bbiWizard.LargeGlyph = global::DevExpress.XtraCharts.Demos.Properties.Resources.Wizard_32x32;
            ribbonPageGroup.ItemLinks.Add(bbiWizard);
        }
        internal void UpdateMenu() {
            int count = bsiAppearances.ItemLinks.Count;
            for (int i = 0; i < count; i++) {
                BarCheckItem item = bsiAppearances.ItemLinks[i].Item as BarCheckItem;
                if (item != null && CurrentModule != null && CurrentModule.ChartControl != null)
                    item.Checked = item.Caption == CurrentModule.ChartControl.AppearanceName;
            }
            if (bsiPalettes != null) {
                count = bsiPalettes.ItemLinks.Count;
                for (int i = 0; i < count; i++) {
                    BarCheckItem item = bsiPalettes.ItemLinks[i].Item as BarCheckItem;
                    if (item != null && CurrentModule != null && CurrentModule.ChartControl != null)
                        item.Checked = item.Caption == CurrentModule.ChartControl.PaletteName;
                }
            }
        }
        void SetAppearanceName(string name) {
            if (bsiAppearances != null) {
                string paletteName = DemosInfo.SetAppearanceName(name);
                UpdateMenu();
            }
        }
        void SetPaletteName(string name) {
            if (bsiPalettes != null) {
                string appearanceName = DemosInfo.SetPaletteName(name);
                UpdateMenu();
            }
        }
        void cbiAppearanceName_Click(object sender, ItemClickEventArgs e) {
            CheckBarItem item = e.Item as CheckBarItem;
            if (item != null)
                SetAppearanceName(item.Caption);
        }
        void cbiPaletteName_Click(object sender, ItemClickEventArgs e) {
            CheckBarItem item = e.Item as CheckBarItem;
            if (item != null)
                SetPaletteName(item.Caption);
        }
        void bbiWizard_Click(object sender, ItemClickEventArgs e) {
            DemosInfo.RunChartWizard();
        }
    }

}
