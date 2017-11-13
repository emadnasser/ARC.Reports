using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for HitInfo.
    /// </summary>
    public partial class HitInfo : TutorialControl {
        public HitInfo() {
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
        }

        //<treeList1>
        private void ShowHitInfo(DevExpress.XtraTreeList.TreeListHitInfo hi) {
            lbHitTest.Text = hi.HitInfoType.ToString();
            lbColumn.Text = hi.Column == null ? "No column" : hi.Column.GetCaption();
            lbNode.Text = hi.Node == null ? "-1" : hi.Node.Id.ToString();
            if(hi.Column == null || hi.Node == null)
                lbCellValue.Text = " ";
            else
                lbCellValue.Text = hi.Node.GetDisplayText(hi.Column.AbsoluteIndex);
        }

        private void treeList1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            ShowHitInfo(treeList1.CalcHitInfo(new Point(e.X, e.Y)));
        }
        //</treeList1>
    }
}
