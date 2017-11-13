using System;
using System.Data;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class InvoiceWithTotalModule : SpreadSheetTutorialControlBase {
        InvoiceDocumentGenerator generator;

        public InvoiceWithTotalModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            generator = new InvoiceDocumentGenerator(spreadsheetControl1.Document);
            this.productsTableAdapter.Fill(nwindDataSet.Products);
            generator.ClearGoods();
            foreach (DataRow row in nwindDataSet.Products.Rows) {
                InvoiceInMemoryData item = new InvoiceInMemoryData(0);
                item.ProductName = row.Field<string>("ProductName");
                item.Price = (double)row.Field<decimal>("UnitPrice");
                generator.AddGoods(item);
            }
            generator.SelectRandomGoods();
            Process();
        }

        void TransferInvoiceParameters(InvoiceDocumentGenerator generator) {
            generator.ApplyParameter(InvoiceDocumentGenerator.FromAddressId, fromAddressEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.FromCityId, fromCityEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.FromCompanyId, fromCompanyEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.FromCompanySloganId, fromCompanySloganEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.FromContactNameId, fromContactNameEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.FromEMailId, fromEMailEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.FromFaxId, fromFaxEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.FromPhoneId, fromPhoneEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.FromStateId, fromStateEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.FromZipId, fromZipEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.ToCityId, toCityEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.ToCompanyId, toCompanyNameEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.ToNameId, toNameEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.ToPhoneId, toPhoneEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.ToStateId, toStateEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.ToStreetId, toStreetEdit.Text);
            generator.ApplyParameter(InvoiceDocumentGenerator.ToZipId, toZipEdit.Text);
        }

        void Process() {
            TransferInvoiceParameters(generator);
            generator.Generate();
        }

        void xtraTabControl1_SelectedPageChanged(object sender, XtraTab.TabPageChangedEventArgs e) {
            if (e.Page.Name == "invoiceTabPage")
                Process();
        }

        #region Calculated grid columns
        void gridView1_CustomUnboundColumnData(object sender, XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if (e.IsGetData) {
                e.Value = generator.GetGoodsAttribute(e.Column.FieldName, e.ListSourceRowIndex);
            }
            else {
                if (generator.SetGoodsAttribute(e.Column.FieldName, e.ListSourceRowIndex, e.Value)) {
                    int rowIndex = gridView1.GetRowHandle(e.ListSourceRowIndex);
                    gridView1.RefreshRow(rowIndex);
               }
            }
        }
        #endregion

        void includeItemCheckEdit_CheckStateChanged(object sender, EventArgs e) {
            gridView1.PostEditor();
        }

        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
        }

        void On_Load(object sender, EventArgs e) {
            ribbonControl1.SelectedPage = homeRibbonPage1;
        }
    }
}
