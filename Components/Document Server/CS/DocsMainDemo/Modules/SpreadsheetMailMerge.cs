using System;
using DevExpress.Spreadsheet;
using System.Globalization;


namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetMailMergeModule : SpreadsheetTutorialControl {
        public SpreadsheetMailMergeModule() {
            InitializeComponent();
            RefreshPreview();
        }

        protected override string DefaultFileName { get { return "Mail_Merge"; } }

        public override IWorkbook CreateBook() {
            string statementNumber = statementNumberTE.Text;
            string customerId = customerIDTE.Text;
            string customerName = nameTE.Text;
            bool fitToPage = FitToPageCheckEdit.Checked;
            string relativePath = DemoUtils.GetRelativePath("Billing_statement.xlsx");
            string email = emailTE.Text;
            string phone = phoneTE.Text;
            string zipCode = zipCodeTE.Text;
            string stateAddress = stateAddressTE.Text;
            string cityAddress = cityAddressTE.Text;
            string streetAddress = streetAddressTE.Text;
            MailMergeDocumentGenerator generator = new MailMergeDocumentGenerator(DefaultCulture);
            generator.StatementNumber = statementNumber;
            generator.CustomerId =customerId;
            generator.CustomerName = customerName;
            generator.Street = streetAddress;
            generator.City = cityAddress;
            generator.State = stateAddress;
            generator.ZIP = zipCode;
            generator.Phone = phone;
            generator.Email = email;
            generator.Path = relativePath;
            generator.FitToPage = fitToPage;
            return generator.Generate();
        }

        void textEdit_EditValueChanged(object sender, EventArgs e) {
            RefreshPreview();
        }
    }
}
