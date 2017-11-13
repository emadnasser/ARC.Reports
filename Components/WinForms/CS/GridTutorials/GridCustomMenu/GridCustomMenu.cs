using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridCustomMenu.
    /// </summary>
    public partial class GridCustomMenu : TutorialControl {
        public GridCustomMenu() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void GridCustomMenu_Load(object sender, System.EventArgs e) {
            InitNWindData();
        }

        string tblGrid = "Products";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblGrid, connectionString);
            oleDbDataAdapter.Fill(ds, tblGrid);
            gridControl1.DataSource = ds.Tables[tblGrid];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.ShowOnlyPredefinedDetails = true;
            gridControl1.DataSource = ds.Tables[tblGrid];
        }
        
        //<gridControl1>
        private void gridControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            if(e.Button == MouseButtons.Right)
                DoShowMenu(gridView1.CalcHitInfo(new Point(e.X, e.Y)));
        }

        void DoShowMenu(DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hi) {
            DevExpress.XtraGrid.Menu.GridViewMenu menu = null;
            if(hi.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.ColumnButton) {
                menu = new GridViewColumnButtonMenu(gridView1);
                menu.Init(hi);
                menu.Show(hi.HitPoint);
            }
        }
        //</gridControl1>

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e) {
            if(e.RowHandle == GridControl.InvalidRowHandle) {
                e.Handled = true;
                e.Painter.DrawObject(e.Info);

                Rectangle r = e.Bounds;
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 0, 0)), r);
                r.Height--; r.Width--;
                e.Graphics.DrawRectangle(Pens.Red, r);
            }
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
