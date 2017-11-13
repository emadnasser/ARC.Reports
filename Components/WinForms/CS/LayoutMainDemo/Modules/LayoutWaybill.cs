using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data.Filtering;
using DevExpress.XtraLayout.Demos.Modules;

namespace DevExpress.XtraLayout.Demos {
    public partial class LayoutWaybill : UserControl {
        public LayoutWaybill() {
            InitializeComponent();
        }
        void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwind.mdb");
            if(DBFileName != "") {
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
                OleDbDataAdapter oleDBAdapter1 = new OleDbDataAdapter("SELECT * FROM Customers", con);
                OleDbDataAdapter oleDBAdapter2 = new OleDbDataAdapter("SELECT * FROM Employees", con);
                OleDbDataAdapter oleDBAdapter3 = new OleDbDataAdapter("SELECT * FROM Orders", con);
                OleDbDataAdapter oleDBAdapter5 = new OleDbDataAdapter("SELECT * FROM Products", con);
                OleDbDataAdapter oleDBAdapter4 = new OleDbDataAdapter(@"SELECT [Order Details].OrderID, [Order Details].ProductID, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount, Products.ProductName
                         FROM            ([Order Details] INNER JOIN
                         Products ON [Order Details].ProductID = Products.ProductID)", con);
                OleDbDataAdapter oleDBAdapter6 = new OleDbDataAdapter("SELECT * FROM EmployeeCustomers", con);

                oleDBAdapter1.Fill(dsOrder.Customers);
                oleDBAdapter2.Fill(dsOrder.Employees);
                oleDBAdapter5.Fill(dsOrder.Products);
                oleDBAdapter3.Fill(dsOrder.Orders); 
                oleDBAdapter4.Fill(dsOrder.Order_Details);
                oleDBAdapter6.Fill(dsOrder.EmployeeCustomers);
            }
        }

        void ChangeData() {
            dnNavigationCustomer.Position = (int)dsOrder.Orders[dnNavigationOrders.Position][dsOrder.Orders.Columns[2]];
            string str = (string)dsOrder.Orders[dnNavigationOrders.Position][dsOrder.Orders.Columns[1]];
            dnNavigationEmployee.Position = dsOrder.Customers.FindByCustomerID(str).Table.Rows.IndexOf(dsOrder.Customers.FindByCustomerID(str));
            ChangeFilter();
        }
        void ChangeFilter() {
            gridViewOrders.ActiveFilter.Clear();
            gridViewOrders.ActiveFilter.Add(gridViewOrders.Columns["OrderID"], new ColumnFilterInfo(String.Format("OrderID == '{0}'", dsOrder.Orders[dnNavigationOrders.Position].OrderID)));
        }
        void dataNavigator1_PositionChanged(object sender, EventArgs e) {
            ChangeData();
        }

        void LayoutWaybill_Load(object sender, EventArgs e) {
            if(!DesignMode) {
                InitData();
                ChangeData();
            }
        }


    }
}
