using System;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using DevExpress.DXperience.Demos;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Demos;
using Modules.DataBinding;
using Modules.DataBinding.nwindOrdersTableAdapters;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class DataSourceToRangeModule : SpreadsheetRibbonTutorialControlBase {
        DataView dataView;
        Range previousRange;
        bool locked = false;

        public DataSourceToRangeModule() {
            InitializeComponent();
            
            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataSourceToRange_template.xlsx"), DocumentFormat.Xlsx);

            nwindOrders dataSet = new nwindOrders();
            BindEditors(dataSet);
            BindDataSourceToWorksheet(dataSet);
        }

        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
        }

        void BindDataSourceToWorksheet(nwindOrders dataSet) {
            OrderDetailsTableAdapter orderDetailsAdapter = new OrderDetailsTableAdapter();
            orderDetailsAdapter.Fill(dataSet.OrderDetails);
            dataView = new DataView(dataSet.OrderDetails);
            dataView.Sort = "OrderID";
            IWorkbook workbook = spreadsheetControl1.Document;
            Worksheet sheet = workbook.Worksheets[0];
            sheet.DataBindings.BindToDataSource(dataView, 4, 1);
            UpdateTotalPrice();
        }

        void BindEditors(nwindOrders dataSet) {
            // Order ID
            OrdersTableAdapter ordersAdapter = new OrdersTableAdapter();
            ordersAdapter.Fill(dataSet.Orders);
            edOrderId.Properties.DataSource = dataSet.Orders;
            edOrderId.Properties.Columns.Add(new XtraEditors.Controls.LookUpColumnInfo("OrderID"));
            edOrderId.Properties.DisplayMember = "OrderID";
            edOrderId.Properties.ValueMember = "OrderID";
            // Product
            ProductsTableAdapter productsAdapter = new ProductsTableAdapter();
            productsAdapter.Fill(dataSet.Products);
            edProductName.Properties.DataSource = dataSet.Products;
            edProductName.Properties.Columns.Add(new XtraEditors.Controls.LookUpColumnInfo("ProductName"));
            edProductName.Properties.DisplayMember = "ProductName";
            edProductName.Properties.ValueMember = "ProductName";
        }

        private void edOrderId_EditValueChanged(object sender, EventArgs e) {
            if (!locked)
                SetupDataView();
        }

        private void edProductName_EditValueChanged(object sender, EventArgs e) {
            if (!locked)
                SetupDataView();
        }

        private void chbDiscount_CheckedChanged(object sender, EventArgs e) {
            if (!locked)
                SetupDataView();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            locked = true;
            try {
                edOrderId.EditValue = null;
                edProductName.EditValue = null;
                chbDiscount.Checked = false;
                SetupDataView();
            }
            finally {
                locked = false;
            }
        }

        void SetupDataView() {
            if (dataView == null)
                return;
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(edOrderId.Text))
                sb.AppendFormat("OrderID = {0}", edOrderId.Text);
            if (!string.IsNullOrEmpty(edProductName.Text)) {
                if (sb.Length > 0)
                    sb.Append(" AND ");
                sb.AppendFormat("ProductName = '{0}'", edProductName.Text.Replace("'", "''"));
            }
            if (chbDiscount.Checked) {
                if (sb.Length > 0)
                    sb.Append(" AND ");
                sb.Append("Discount > 0");
            }
            spreadsheetControl1.BeginUpdate();
            try {
                dataView.RowFilter = sb.ToString();
                UpdateTotalPrice();
            }
            finally {
                spreadsheetControl1.EndUpdate();
            }
        }

        void UpdateTotalPrice() {
            IWorkbook workbook = spreadsheetControl1.Document;
            workbook.BeginUpdate();
            try {
                Worksheet sheet = workbook.Worksheets[0];
                Range currentRange = sheet.DataBindings[0].Range;
                Range subtotalRange;
                if (previousRange != null) {
                    subtotalRange = sheet.Range.FromLTRB(previousRange.RightColumnIndex + 1, previousRange.TopRowIndex, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex);
                    subtotalRange.ClearContents();
                    if (currentRange.RowCount < previousRange.RowCount) {
                        subtotalRange = sheet.Range.FromLTRB(previousRange.LeftColumnIndex, previousRange.BottomRowIndex + 1, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex + 1);
                        subtotalRange.ClearContents();
                    }
                    previousRange = null;
                }
                if (dataView.Count > 0) {
                    previousRange = currentRange;
                    subtotalRange = sheet.Range.FromLTRB(previousRange.RightColumnIndex + 1, previousRange.TopRowIndex, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex);
                    subtotalRange.FormulaInvariant = "=E5*F5*(1-G5)";
                    Range range = sheet.Range.FromLTRB(previousRange.LeftColumnIndex, previousRange.BottomRowIndex + 1, previousRange.LeftColumnIndex, previousRange.BottomRowIndex + 1);
                    range.Value = "Total";
                    range = sheet.Range.FromLTRB(previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex + 1, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex + 1);
                    range.FormulaInvariant = string.Format("=SUBTOTAL(9,{0})", subtotalRange.GetReferenceA1());
                }
            }
            finally {
                workbook.EndUpdate();
            }
        }
    }
}
