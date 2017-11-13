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
    public partial class MDLayout : BaseLayoutModule {
        OleDbConnection connection;
        OleDbDataAdapter AdapterSuppliers;
        OleDbDataAdapter AdapterCategories;

        public MDLayout() {
            CreateWaitDialog();
            InitializeComponent();
        }
        protected override void InitMDBData(string connectionString, DataSet ds) {
            connection = new OleDbConnection(connectionString);
            AdapterSuppliers = new OleDbDataAdapter("SELECT  SupplierID, CompanyName, Country, Address, Phone FROM Suppliers", connection);
            AdapterCategories = new OleDbDataAdapter(
                "SELECT     Products.SupplierID, Products.ProductName, Categories.CategoryName, Categories.Description, Categories.Picture, "+
                "Products.UnitsInStock, Products.UnitPrice "+
                "FROM         (Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID) "+
                "ORDER BY Products.SupplierID", connection);
            AdapterSuppliers.Fill(ds, "Suppliers");
            AdapterCategories.Fill(ds, "ProductCategories");

            //custom relation
            ds.Relations.Add("SupplierProducts",
                ds.Tables["Suppliers"].Columns["SupplierID"],
                ds.Tables["ProductCategories"].Columns["SupplierID"], false);
        }
    }
}
