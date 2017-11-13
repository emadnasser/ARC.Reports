using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for MultiSelect.
    /// </summary>
    public partial class MultiSelect : TutorialControl {
        public MultiSelect() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitData();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
        private void InitData() {
            DevExpress.XtraTreeList.Design.XViews xv = new DevExpress.XtraTreeList.Design.XViews(treeList1);
            cbMultiSelect.Checked = true;
            treeList1.Selection.Add(treeList1.Nodes[0]);
            treeList1.Selection.Add(treeList1.Nodes[0].Nodes[0]);
            treeList1.Selection.Add(treeList1.Nodes[0].Nodes[1]);
        }

        //<cbMultiSelect>
        private void cbMultiSelect_CheckedChanged(object sender, System.EventArgs e) {
            treeList1.OptionsSelection.MultiSelect = cbMultiSelect.Checked;
            if(cbMultiSelect.Checked) {
                SelectionChanged();
            }
            else {
                lbSelectedRowsCount.Text = "-1";
                lbSelectedRows.Text = "MultiSelect is Disabled.";
            }
        }
        //</cbMultiSelect>

        private string ArrayToString(DevExpress.XtraTreeList.TreeListMultiSelection arr) {
            string s = "";
            if(arr.Count == 0)
                s = "Empty...";
            else {
                foreach(DevExpress.XtraTreeList.Nodes.TreeListNode node in arr)
                    s += (s == "" ? "" : ";") + node.Id.ToString();
                s += ".";
            }
            return s;
        }

        //<treeList1>
        //<cbMultiSelect>
        private void SelectionChanged() {
            lbSelectedRowsCount.Text = treeList1.Selection.Count.ToString();
            lbSelectedRows.Text = ArrayToString(treeList1.Selection);
        }
        //</treeList1>
        //</cbMultiSelect>

        //<treeList1>
        private void treeList1_SelectionChanged(object sender, System.EventArgs e) {
            SelectionChanged();
        }
        //</treeList1>
    }
}
