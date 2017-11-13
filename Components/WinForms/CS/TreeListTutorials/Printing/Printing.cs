using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for Printing.
    /// </summary>
    public partial class Printing : TutorialControl {
        public Printing() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitData();
            InitView();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void InitData() {
            DevExpress.XtraTreeList.Design.XViews xv = new DevExpress.XtraTreeList.Design.XViews(treeList1);
        }

        private void InitView() {
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

        //<button1>
        private void button1_Click(object sender, System.EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            treeList1.ShowPrintPreview();
            Cursor.Current = Cursors.Default;
        }
        //</button1>

        //<button2>
        private void button2_Click(object sender, System.EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            DevExpress.XtraEditors.XtraForm frm = new DevExpress.XtraEditors.XtraForm();
            frm.Text = "Print Designer";
            DevExpress.XtraTreeList.Frames.TreeListPrinting print = new DevExpress.XtraTreeList.Frames.TreeListPrinting();
            print.InitFrame(treeList1, "PrintingReport management", null);
            print.Dock = DockStyle.Fill;
            frm.Controls.Add(print);
            frm.Size = print.UserControlSize;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        //</button2>
    }
}
