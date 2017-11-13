using DevExpress.DXperience.Demos;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class EncryptionModule : SpreadsheetRibbonTutorialControlBase {
        IWorkbook workbook;

        public EncryptionModule() {
            InitializeComponent();
            InitializeWorkbook();
            InitializeEncryptionOptions();
            workbook.History.Clear();
        }

        #region Properties
        protected internal override RibbonPage SelectedRibbonPage { get { return fileRibbonPage1; } }
        #endregion

        void InitializeWorkbook() {
            workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(DemoUtils.GetRelativePath("ProfitAndLoss.xlsx"));
        }

        void InitializeEncryptionOptions() {
            passwordEdit.Text = "test";

            foreach (EncryptionType currentValue in EnumHelper.GetValues<EncryptionType>())
                typeEdit.Properties.Items.Add(currentValue.ToString());
            typeEdit.SelectedItem = EncryptionType.Strong.ToString();
        }

        void TypeEdit_TextChanged(object sender, System.EventArgs e) {
            workbook.DocumentSettings.Encryption.Type = (EncryptionType)Enum.Parse(typeof(EncryptionType), typeEdit.Text);
        }

        void PasswordEdit_TextChanged(object sender, System.EventArgs e) {
            workbook.DocumentSettings.Encryption.Password = passwordEdit.Text;
        }

        void BtnExportToXLSX_Click(object sender, EventArgs e) {
            OnBtnClick("Excel Workbook files(*.xlsx)|*.xlsx", "Document.xlsx");
        }

        void BtnExportToXLS_Click(object sender, EventArgs e) {
            OnBtnClick("Excel 97-2003 Workbook files(*.xls)|*.xls", "Document.xls");
        }

        void OnBtnClick(string filter, string defaultName) {
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = filter;
            sfDialog.FileName = defaultName;
            if (sfDialog.ShowDialog() != DialogResult.OK)
                return;

            string fileName = sfDialog.FileName;
            workbook.SaveDocument(fileName);
            
            if (chbOpenResultingFile.Checked)
                Process.Start(fileName);
        }

        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
        }
    }
}
