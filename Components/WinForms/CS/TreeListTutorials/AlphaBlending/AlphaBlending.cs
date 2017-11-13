using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for AlphaBlending.
    /// </summary>
    public partial class AlphaBlending : TutorialControl {
        public AlphaBlending() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitData();
            InitView();
            checkBox1.Checked = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void InitData() {
            DevExpress.XtraTreeList.Design.XViews xv = new DevExpress.XtraTreeList.Design.XViews(treeList1);
        }

        private void InitView() {
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

        //<checkBox1>
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
            xtraTreeListBlending1.Enabled = checkBox1.Checked;
            button1.Enabled = checkBox1.Checked;
        }
        //</checkBox1>

        //<button1>
        private void button1_Click(object sender, System.EventArgs e) {
            xtraTreeListBlending1.ShowDialog();
        }
        //</button1>
    }
}
