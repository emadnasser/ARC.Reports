using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.XtraLayout.Demos.Modules;

namespace DevExpress.XtraLayout.Demos {
    public partial class LayoutPrinting : DragDropLayoutControl {
        public LayoutPrinting() {
            InitializeComponent();
        }
        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwind.mdb");
            if(DBFileName != "") {
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
                OleDbDataAdapter oleDBAdapter1 = new OleDbDataAdapter("SELECT * FROM Categories", con);
                OleDbDataAdapter oleDBAdapter2 = new OleDbDataAdapter("SELECT * FROM Products", con);
                OleDbDataAdapter oleDBAdapter3 = new OleDbDataAdapter("SELECT * FROM [Order Details]", con);
                OleDbDataAdapter oleDBAdapter4 = new OleDbDataAdapter("SELECT * FROM Suppliers", con);

                oleDBAdapter1.Fill(dsCategories.Categories);
                oleDBAdapter2.Fill(dsCategories.Products);
                oleDBAdapter3.Fill(dsCategories.Order_Details);
                oleDBAdapter4.Fill(dsCategories.Suppliers);
            }
        }
        private void LayoutPrinting_Load(object sender, EventArgs e) {
            if(!DesignMode) InitData();
        }
    }
}
