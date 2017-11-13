using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraTab;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for Editors.
    /// </summary>
    public partial class Editors : TutorialControl {
        public Editors() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void Editors_Load(object sender, System.EventArgs e) {
            InitData();
            InitProperties();
        }

        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Cars.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                vGridControl1.DataSource = dataSet.Tables[0].DefaultView;
            }
        }

        private void AddTab(DevExpress.XtraVerticalGrid.Rows.BaseRow row) {
            if(row is DevExpress.XtraVerticalGrid.Rows.EditorRow) {
                XtraTabPage tp = new XtraTabPage();
                XtraPropertyGrid pg = new XtraPropertyGrid();
                pg.PropertyGrid.SelectedObject = row.Properties.RowEdit;
                pg.Dock = DockStyle.Fill;
                pg.ShowDescription = false;
                tp.Text = row.Properties.Caption;
                tp.Controls.Add(pg);
                tabControl1.TabPages.Add(tp);
            }
            foreach(DevExpress.XtraVerticalGrid.Rows.BaseRow cRow in row.ChildRows)
                AddTab(cRow);
        }

        private void InitProperties() {
            foreach(DevExpress.XtraVerticalGrid.Rows.BaseRow row in vGridControl1.Rows) {
                AddTab(row);
            }
            tabControl1.SelectedTabPageIndex = 8;
        }

        private bool SelectRow(DevExpress.XtraVerticalGrid.Rows.BaseRow row, string s) {
            if(row.Properties.Caption == s) {
                vGridControl1.FocusedRow = row;
                return false;
            }
            foreach(DevExpress.XtraVerticalGrid.Rows.BaseRow cRow in row.ChildRows)
                SelectRow(cRow, s);
            return true;
        }

        private void tabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e) {
            string caption = tabControl1.TabPages[tabControl1.SelectedTabPageIndex].Text;
            foreach(DevExpress.XtraVerticalGrid.Rows.BaseRow row in vGridControl1.Rows) {
                if(!SelectRow(row, caption)) return;
            }
        }
    }
}
