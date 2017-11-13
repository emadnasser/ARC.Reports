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
    /// Summary description for GridCustomTooltips.
    /// </summary>
    public partial class GridCustomTooltips : TutorialControl {
        public GridCustomTooltips() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        //<gridControl1>    
		string[] ColumnHints = new string[] {"Number automatically assigned to new product.", "", 
			"Quantity per unit (e.g., 24-count case, 1-liter bottle).", "", "", "", 
			"Minimum units to maintain in stock.", 
			"Yes - means item is no longer available."};
        //</gridControl1>
        private void GridCustomTooltips_Load(object sender, System.EventArgs e) {
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

        private string GetCellHintText(GridView view, int rowHandle, DevExpress.XtraGrid.Columns.GridColumn column) {
            string ret = view.GetRowCellDisplayText(rowHandle, column);
            foreach(DevExpress.XtraGrid.Columns.GridColumn col in view.Columns)
                if(col.VisibleIndex < 0)
                    ret += string.Format("\r\n {0}: {1}", col.GetTextCaption(), view.GetRowCellDisplayText(rowHandle, col));
            return ret;
        }

        private string GetColumnHintText(DevExpress.XtraGrid.Columns.GridColumn column) {
            string ret = ColumnHints[gridView1.Columns.IndexOf(column)];
            if(ret == "") ret = column.GetTextCaption();
            return ret;
        }

        //<gridControl1>
        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e) {
            if(e.SelectedControl != gridControl1) return;
            ToolTipControlInfo info = null;
            try {
                GridView view = gridControl1.GetViewAt(e.ControlMousePosition) as GridView;
                if(view == null) return;
                GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);
                if(hi.InRowCell) {
                    info = new ToolTipControlInfo(new CellToolTipInfo(hi.RowHandle, hi.Column, "cell"), GetCellHintText(view, hi.RowHandle, hi.Column));
                    return;
                }
                if(hi.Column != null) {
                    info = new ToolTipControlInfo(hi.Column, GetColumnHintText(hi.Column));
                    return;
                }
                if(hi.HitTest == GridHitTest.GroupPanel) {
                    info = new ToolTipControlInfo(hi.HitTest, "Group panel");
                    return;
                }

                if(hi.HitTest == GridHitTest.RowIndicator) {
                    info = new ToolTipControlInfo(GridHitTest.RowIndicator.ToString() + hi.RowHandle.ToString(), "Row Handle: " + hi.RowHandle.ToString());
                    return;
                }
            }
            finally {
                e.Info = info;
            }
        }
        //</gridControl1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
