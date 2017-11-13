using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridDragDropExternal.
    /// </summary>
    public partial class GridDragDropExternal : TutorialControl {
        public GridDragDropExternal() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void GridDragDropExternal_Load(object sender, System.EventArgs e) {
            InitNWindData();
            gridView1.BestFitColumns();
        }

        string tblName = "Customers";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblName, connectionString);
            oleDbDataAdapter.Fill(ds, tblName);
            gridControl1.DataSource = ds.Tables[tblName];
            gridControl1.MainView.PopulateColumns();
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.ShowOnlyPredefinedDetails = true;
            gridControl1.DataSource = ds.Tables[tblName];
            gridControl1.MainView.PopulateColumns();
        }

        private string DataRow(DataRow dr) {
            string s = "";
            if(dr != null)
                foreach(object o in dr.ItemArray)
                    s = (s == "" ? "" : s + "; ") + o.ToString();
            return s;
        }

        //<gridControl1>
        GridHitInfo hitInfo = null;
        private void gridControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            hitInfo = gridView1.CalcHitInfo(new Point(e.X, e.Y));
        }

        private void gridControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            if(hitInfo == null) return;
            if(e.Button != MouseButtons.Left) return;
            Rectangle dragRect = new Rectangle(new Point(
                hitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2,
                hitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize);
            if(!dragRect.Contains(new Point(e.X, e.Y))) {
                if(hitInfo.InRowCell)
                    gridControl1.DoDragDrop((gridView1.GetRowCellDisplayText(hitInfo.RowHandle, hitInfo.Column)), DragDropEffects.Copy);
                if(hitInfo.HitTest == GridHitTest.RowIndicator) {
                    string data = DataRow(gridView1.GetDataRow(hitInfo.RowHandle));
                    gridControl1.DoDragDrop(data, DragDropEffects.Copy);
                }
            }
        }
        //</gridControl1>

        private void listBoxControl1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }

        private void listBoxControl1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            ListBoxControl lb = sender as ListBoxControl;
            string dragString = (string)e.Data.GetData(typeof(string));
            int ind = lb.IndexFromPoint(lb.PointToClient(new Point(e.X, e.Y)));
            if(ind == -1)
                lb.Items.Add(dragString);
            else
                lb.Items.Insert(ind, dragString);
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
