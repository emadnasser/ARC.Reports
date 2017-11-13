using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for Summaries.
    /// </summary>
    public partial class Summaries : TutorialControl {
        public Summaries() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitData();
            InitSummaries();
            checkBox1.Checked = treeList1.OptionsMenu.EnableFooterMenu;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void InitData() {
            DevExpress.XtraTreeList.Design.XViews xv = new DevExpress.XtraTreeList.Design.XViews(treeList1);
        }

        //<checkBox1>
        private void InitSummaries() {
            treeList1.OptionsView.ShowSummaryFooter = true;
            treeList1.OptionsView.ShowRowFooterSummary = true;
            DevExpress.XtraTreeList.Columns.TreeListColumn col = treeList1.Columns[1];
            col.SummaryFooter = SummaryItemType.Sum;
            col.SummaryFooterStrFormat = "Sum = {0:c}";
            col.RowFooterSummary = SummaryItemType.Sum;
            col.RowFooterSummaryStrFormat = "{0:c}";
            col.AllNodesSummary = true;
            col = treeList1.Columns[0];
            col.SummaryFooter = SummaryItemType.Count;
            col.RowFooterSummary = SummaryItemType.Count;
            col.AllNodesSummary = true;
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
            treeList1.OptionsMenu.EnableFooterMenu = checkBox1.Checked;
        }
        //</checkBox1>

        private void treeList1_TreeListMenuItemClick(object sender, DevExpress.XtraTreeList.TreeListMenuItemClickEventArgs e) {
            if(e.MenuType == DevExpress.XtraTreeList.Menu.TreeListMenuType.Summary && !e.MenuItem.Tag.Equals(DevExpress.XtraTreeList.Localization.TreeListStringId.MenuFooterCount) && e.Column.FieldName == "Budget") {
                string s = e.SummaryFormat;
                int i = s.IndexOf("0");
                if(i > 0) s = s.Substring(0, i) + "0:c}";
                e.SummaryFormat = s;
            }
        }

    }
}
