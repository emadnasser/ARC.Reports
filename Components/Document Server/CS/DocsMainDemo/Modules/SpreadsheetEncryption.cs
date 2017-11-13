using System.Drawing;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;
using DevExpress.DXperience.Demos;
using System;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetEncryption : SpreadsheetTutorialControl {

        public SpreadsheetEncryption() {
            InitializeComponent();
            FitToPageCheckEdit.Visible = false;
            FitToPageCheckEdit.Enabled = false;
            SpreadsheetTutorialPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            InitializeEncryptionOptions();

            FitToPageCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked; // RefreshPreview
        }

        protected override string DefaultFileName { get { return "Document"; } }
        protected override string DefaultSaveFileFilter { get { return "Excel Workbook files(*.xlsx)|*.xlsx|Excel 97 - 2003 Workbook files(*.xls) | *.xls"; } }

        public override IWorkbook CreateBook() {
            IWorkbook book = new Workbook();
            book.LoadDocument(DemoUtils.GetRelativePath("ProfitAndLoss.xlsx"));
            book.DocumentSettings.Encryption.Password = passwordEdit.Text;
            book.DocumentSettings.Encryption.Type = (EncryptionType)Enum.Parse(typeof(EncryptionType), typeEdit.Text);
            return book;
        }

        void InitializeEncryptionOptions() {
            passwordEdit.Text = "test";

            foreach (EncryptionType currentValue in EnumHelper.GetValues<EncryptionType>())
                typeEdit.Properties.Items.Add(currentValue.ToString());
            typeEdit.SelectedItem = EncryptionType.Strong.ToString();
        }
    }
}
