using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for NWindNavigator.
	/// </summary>
	public partial class NWindNavigator : TutorialControl {
		public NWindNavigator() {
            //
			// Required for Windows Form Designer support
			//
			CreateWaitDialog();
			InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\NWindNavigator.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.NWindNavigator.xml";
			InitData();
			gridControl1.ForceInitialize();
			InitAppearance();
            OnStyleChanged();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		#region Init
		private void InitData() {
			gridControl1.DataSource = new NWTables(NWindDataSet());
			gridControl1.MainView.PopulateColumns();
            //<controlNavigator1>
            /*
            ~Note: the following code is set at design-time and listed here for educational purposes.
            controlNavigator1.NavigatableControl = gridControl1;
            */
            //</controlNavigator1>
        }
		private void InitAppearance() {
			gridView1.SetMasterRowExpanded(gridView1.FocusedRowHandle, true);
		}

		#endregion
		#region Create
        protected override void InitMDBData(string connectionString, DataSet ds) {
            string[,] data = new string[,] { {
					"CategoryID", "Products", "CategoryID", "Categories", "CategoriesProducts"}, {
					"CustomerID", "Orders", "CustomerID", "Customers", "CustomersOrders"}, { 
					"EmployeeID", "Orders", "EmployeeID", "Employees", "EmployeesOrders"}, {
					"OrderID", "[Order Details]", "OrderID", "Orders", "OrdersOrderDetails"}, {
					"ProductID", "[Order Details]", "ProductID", "Products", "ProductsOrderDetails"}, {
					"ShipVia", "Orders", "ShipperID", "Shippers", "ShippersOrders"}, {
					"SupplierID", "Products", "SupplierID", "Suppliers", "SuppliersProducts"}};
            string[] tables = new String[] {
					"Categories" , "Customers", "Employees", "Orders", "Products", "Shippers", "Suppliers", "[Order Details]"};

            OleDbDataAdapter oleDbDataAdapter;
            //fill tables
            foreach(string tbl in tables) {
                oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM " + tbl, connectionString);
                SetWaitDialogCaption(string.Format(Properties.Resources.LoadingCaption, tbl));
                oleDbDataAdapter.Fill(ds, tbl);
            }
            //custom views
            oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM Orders WHERE Freight > 500", connectionString);
            SetWaitDialogCaption(Properties.Resources.LoadingCustomOrders);
            oleDbDataAdapter.Fill(ds, "Orders500");
            //add relations
            for(int i = 0; i <= data.GetUpperBound(0); i++) {
                ds.Relations.Add(data[i, 4],
                    ds.Tables[data[i, 3]].Columns[data[i, 2]],
                    ds.Tables[data[i, 1]].Columns[data[i, 0]]);
            }
            //custom relation
            ds.Relations.Add("CustomRelation",
                ds.Tables["Orders500"].Columns["OrderID"],
                ds.Tables["[Order Details]"].Columns["OrderID"], false);
        }
        protected override void InitXMLData(string dataFileName, DataSet ds) {
            ds.ReadXml(dataFileName);
        }
		#endregion
		#region Grid events
		private void gridControl1_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e) {
			GridView gv = e.View as GridView;
			gv.BestFitColumns();
			gv.OptionsView.ColumnAutoWidth = false;
			gv.OptionsView.ShowColumnHeaders = true;
			if(gv.Columns.Count > 0)
				gv.Columns[0].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
		}
		#endregion
		#region Editing
        //<sbCollapse>
		private void sbCollapse_Click(object sender, System.EventArgs e) {
			gridView1.CollapseAllDetails();
		}
        //</sbCollapse>
        //<sbPreview>
		private void sbPreview_Click(object sender, System.EventArgs e) {
			Cursor currentCursor = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
            gridControl1.ShowRibbonPrintPreview();
			Cursor.Current = currentCursor;
		}
        //</sbPreview>
		#endregion
        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            controlNavigator1.Width = 100;
        }
	}
}
