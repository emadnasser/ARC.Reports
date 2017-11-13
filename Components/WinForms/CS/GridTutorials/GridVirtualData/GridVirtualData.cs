using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridVirtualData.
    /// </summary>
    public partial class GridVirtualData : TutorialControl {
        public GridVirtualData() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void GridVirtualData_Load(object sender, System.EventArgs e) {
            InitData();
        }

        //<checkEdit1>
        private VirtualList vList = new VirtualList();
        //</checkEdit1>
        private void InitData() {
            vList.RecordCount = (int)spinEdit1.Value;
            vList.ColumnCount = (int)spinEdit2.Value;
            vList.UseDataStore = checkEdit1.Checked;

            //<checkEdit1>
            gridControl1.DataSource = vList;
            //</checkEdit1>
            gridControl1.MainView.PopulateColumns();
            simpleButton1.Enabled = false;
        }

        private void spinEdit_EditValueChanged(object sender, System.EventArgs e) {
            simpleButton1.Enabled = true;
        }

        //<checkEdit1>
        private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
            vList.UseDataStore = checkEdit1.Checked;
            gridView1.LayoutChanged();
        }
        //</checkEdit1>

        //<simpleButton1>
        private void simpleButton1_Click(object sender, System.EventArgs e) {
            vList.RecordCount = (int)spinEdit1.Value;
            vList.ColumnCount = (int)spinEdit2.Value;
            gridControl1.DataSource = null;
            gridControl1.DataSource = vList;
            gridControl1.MainView.PopulateColumns();
            simpleButton1.Enabled = false;
        }
        //</simpleButton1>
    }
}
