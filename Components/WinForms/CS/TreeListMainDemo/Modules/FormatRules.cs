using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.XtraTreeList.Demos {
    public partial class FormatRules : DevExpress.XtraTreeList.Demos.TutorialControl {
        public override TreeList ExportControl { get { return treeList1; } }
        public FormatRules() {
            InitializeComponent();
            treeList1.DataSource = SalesDataGenerator.CreateData();
            treeList1.ExpandAll();
        }
        private void treeList1_Load(object sender, EventArgs e) {
            treeList1.BestFitColumns();
        }
    }
}
