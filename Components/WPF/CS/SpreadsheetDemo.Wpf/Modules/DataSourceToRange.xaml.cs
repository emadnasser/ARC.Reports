using System;
using System.Globalization;
using System.Data;
using System.Text;
using System.Windows.Data;
using DevExpress.Spreadsheet;
using DevExpress.Xpf.DemoBase;
using DevExpress.XtraSpreadsheet.Demos;
using Modules.DataBinding;
using Modules.DataBinding.nwindOrdersTableAdapters;

namespace SpreadsheetDemo {
    public partial class DataSourceToRange : SpreadsheetDemoModule {
        DataView dataView;
        Range previousRange;
        bool locked = false;

        public DataSourceToRange() {
            InitializeComponent();
            this.spreadsheetControl1.Options.Culture = DefaultCulture;
            this.spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataSourceToRange_template.xlsx"));
            ribbonControl1.SelectedPage = pageHome;

            DemoUtils.SetDatabasePath();
            nwindOrders dataSet = new nwindOrders();
            BindEditors(dataSet);
            BindDataSourceToWorksheet(dataSet);
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
            OrdersTableAdapter ordersAdapter = new OrdersTableAdapter();
            ordersAdapter.Fill(dataSet.Orders);

            edOrderId.ItemsSource = dataSet.Orders;
            edOrderId.DisplayMemberPath = "OrderID";
            edOrderId.SelectedValuePath = "OrderID";
            ProductsTableAdapter productsAdapter = new ProductsTableAdapter();
            productsAdapter.Fill(dataSet.Products);
            edProductName.ItemsSource = dataSet.Products;
            edProductName.DisplayMemberPath = "ProductName";
            edProductName.SelectedValuePath = "ProductName";
        }

        void SetupDataView() {
            if (dataView == null)
                return;
            StringBuilder sb = new StringBuilder();
            string order = edOrderId.SelectedValue != null ? edOrderId.SelectedValue.ToString() : string.Empty;
            string productName = edProductName.SelectedValue != null ? edProductName.SelectedValue.ToString() : string.Empty;
            if (!string.IsNullOrEmpty(order))
                sb.AppendFormat("OrderID = {0}", order);
            if (!string.IsNullOrEmpty(productName)) {
                if (sb.Length > 0)
                    sb.Append(" AND ");
                sb.AppendFormat("ProductName = '{0}'", productName.Replace("'", "''"));
            }
            if (chbDiscount.IsChecked ?? false) {
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

        private void edOrderId_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
            if (!locked)
                SetupDataView();
        }

        private void edProductName_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
            if (!locked)
                SetupDataView();
        }

        private void chbDiscount_Checked(object sender, System.Windows.RoutedEventArgs e) {
            if (!locked)
                SetupDataView();
        }

        private void chbDiscount_Unchecked(object sender, System.Windows.RoutedEventArgs e) {
            if (!locked)
                SetupDataView();
        }

        private void btnResetFilter_Click(object sender, System.Windows.RoutedEventArgs e) {
            locked = true;
            try {
                edOrderId.SelectedValue = null;
                edProductName.SelectedValue = null;
                chbDiscount.IsChecked = false;
                SetupDataView();
            }
            finally {
                locked = false;
            }
        }
    }
}
