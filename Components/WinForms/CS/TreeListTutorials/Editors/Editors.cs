using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraTab;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for Editors.
    /// </summary>
    public partial class Editors : TutorialControl {
        public Editors() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitData();
            InitProperties();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\BioLife.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                treeList1.DataSource = dataSet.Tables[0].DefaultView;
                treeList1.ExpandAll();
            }
        }

        private void InitProperties() {
            foreach(DevExpress.XtraTreeList.Columns.TreeListColumn col in treeList1.Columns) {
                XtraTabPage tp = new XtraTabPage();
                XtraPropertyGrid pg = new XtraPropertyGrid();
                pg.PropertyGrid.SelectedObject = col.ColumnEdit;
                pg.Dock = DockStyle.Fill;
                tp.Text = col.FieldName;
                tp.Controls.Add(pg);
                tabControl1.TabPages.Add(tp);
            }
            tabControl1.SelectedTabPageIndex = 2;
        }

        private void tabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            string s = tabControl1.SelectedTabPage.Text;
            treeList1.FocusedColumn = treeList1.Columns[s];
        }
    }
}
