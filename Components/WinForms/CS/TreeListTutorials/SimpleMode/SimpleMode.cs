using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for SimpleMode.
    /// </summary>
    public partial class SimpleMode : TutorialControl {
        public SimpleMode() {
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
        //<treeList1>
        private void InitData() {
            treeList1.DataSource = new SimpleModeRecords();
            treeList1.PopulateColumns();
            treeList1.BestFitColumns();
            treeList1.ExpandAll();
            InitColumnsVisibleOrder();
            treeList1.Columns["Price"].Format.FormatString = "c";
        }
        //</treeList1>

        private void InitColumnsVisibleOrder() {
            treeList1.Columns["Name"].VisibleIndex = 0;
            treeList1.Columns["Status"].VisibleIndex = 1;
            treeList1.Columns["Price"].VisibleIndex = 2;
            treeList1.Columns["Supplier"].VisibleIndex = 3;
        }

        private void SimpleMode_Load(object sender, System.EventArgs e) {
            treeList1.BestFitColumns();
        }
    }
}
