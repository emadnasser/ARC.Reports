using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Layout;

namespace DevExpress.XtraGrid.Demos {
    public class BaseLayoutModule : TutorialControl {
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
    }
}
