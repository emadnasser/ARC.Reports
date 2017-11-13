using System.Data;
using DevExpress.Utils;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class Grouping : TreeMapTutorialControl {
        TreeMapFlatDataAdapter DataAdapter { get { return (TreeMapFlatDataAdapter)treeMapControl1.DataAdapter; } }
        TreeMapPaletteColorizer Colorizer { get { return (TreeMapPaletteColorizer)treeMapControl1.Colorizer; } }

        public Grouping() {
            InitializeComponent();
            DataAdapter.DataSource = Utils.CreateDataSet("Billionares.xml");
            Colorizer.Palette = Palette.Office2016Palette;
            UpdateGrouping();
        }

        void UpdateGrouping() {
            DataAdapter.GroupDataMembers.Clear();
            Colorizer.ColorizeGroups = !btnWithoutGrouping.Checked;
            if (btnGroupByAge.Checked)
                DataAdapter.GroupDataMembers.Add("AgeCategory");
            if (btnGroupByResidence.Checked)
                DataAdapter.GroupDataMembers.Add("Residence");
            if (btnGroupByResidenceAndAge.Checked)
                DataAdapter.GroupDataMembers.AddRange(new string[] { "Residence", "AgeCategory" });
        }
        void OnGroupingItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            UpdateGrouping();
        }

        void toolTipController1_BeforeShow(object sender, ToolTipControllerShowEventArgs e) {
            TreeMapItem item = (TreeMapItem)e.SelectedObject;
            if (!item.IsGroup) {
                SuperToolTip superToolTip = new SuperToolTip();
                superToolTip.Items.Add(new ToolTipTitleItem() { Text = item.Label });
                superToolTip.Items.Add(new ToolTipSeparatorItem());
                DataRowView dataRowView = (DataRowView)item.Tag;
                superToolTip.Items.Add(new ToolTipItem() { Text = dataRowView["Residence"].ToString() + ", " + dataRowView["NetWorth"].ToString() + "B$" });
                e.SuperTip = superToolTip;
            }
        }
    }
}
