using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridValidatingControl.
    /// </summary>
    public partial class GridValidatingControl : TutorialControl {
        public GridValidatingControl() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        #region InitData
        string tblGrid = "Products";
        string tblLookUp = "Categories";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblGrid, connectionString);
            oleDbDataAdapter.Fill(ds, tblGrid);
            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblLookUp, connectionString);
            oleDbDataAdapter.Fill(ds, tblLookUp);

            DataViewManager dvManager = new DataViewManager(ds);
            DataView dv = dvManager.CreateDataView(ds.Tables[tblGrid]);

            gridControl1.DataSource = dv;
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
            textEdit1.DataBindings.Add("EditValue", dv, "ProductName");
            spinEdit1.DataBindings.Add("EditValue", dv, "UnitPrice");
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.ShowOnlyPredefinedDetails = true;
            
            DataViewManager dvManager = new DataViewManager(ds);
            DataView dv = dvManager.CreateDataView(ds.Tables[tblGrid]);

            gridControl1.DataSource = dv;
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
            textEdit1.DataBindings.Add("EditValue", dv, "ProductName");
            spinEdit1.DataBindings.Add("EditValue", dv, "UnitPrice");
        }
        #endregion
        private void GridValidatingControl_Load(object sender, System.EventArgs e) {
            InitNWindData();
        }

        private void editors_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            gridView1.UpdateCurrentRow();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            ColumnView view = sender as ColumnView;
            object o = view.GetRowCellValue(e.FocusedRowHandle, view.Columns["Discontinued"]);
            if(o != null && o != DBNull.Value) {
                bool val = Convert.ToBoolean(o);
                textEdit1.Properties.ReadOnly = val;
                spinEdit1.Properties.ReadOnly = val;
            }
        }

        //<gridControl1>
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
            ColumnView view = sender as ColumnView;
            bool val = Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, view.Columns["Discontinued"]));
            if(val) {
                e.Valid = false;
                e.ErrorText = "Item should not be discontinued. ";
            }
            view.SetColumnError(null, !val ? null : "Item should not be discontinued.");
        }
        //</gridControl1>

        private void gridControl1_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            ColumnView view = gridControl1.MainView as ColumnView;
            view.UpdateCurrentRow();
            if(view.GetColumnError(null) != string.Empty)
                e.Cancel = true;
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
