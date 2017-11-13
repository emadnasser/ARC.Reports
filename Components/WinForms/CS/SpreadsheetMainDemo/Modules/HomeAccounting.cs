using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Demos;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class HomeAccountingModule : SpreadsheetRibbonTutorialControlBase {
        HomeAccountingDocumentGenerator generator;
        public HomeAccountingModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            IWorkbook book = spreadsheetControl1.Document;
            GenerateDocument(book);
            spreadsheetControl1.ReadOnly = true;
            spreadsheetControl1.Document.History.Clear();
        }

        void GenerateDocument(IWorkbook book) {
            spreadsheetControl1.BeginUpdate();
            try {
                generator = new HomeAccountingDocumentGenerator(book);
                generator.Generate();
            }
            finally {
                spreadsheetControl1.EndUpdate();
            }
        }

        private void AddExpensebuttonClick(object sender, EventArgs e) {
            AddExpense();
        }

        private void AddIncomeButtonClick(object sender, EventArgs e) {
            AddIncome();
        }

        void AddExpense() {
            AddTransactionResult transactionResult = new AddTransactionResult();
            AddTransactionForm addChargeForm = new AddTransactionForm(false, generator.ExpenseCategorys.ToArray(), transactionResult);
            addChargeForm.SetMenuManager(spreadsheetControl1.MenuManager);
            if (addChargeForm.ShowDialog() == DialogResult.OK) {
                spreadsheetControl1.BeginUpdate();
                try {
                    generator.AddTransaction(false, transactionResult.TransactionDate, transactionResult.Sum, transactionResult.Category);
                }
                finally {
                    spreadsheetControl1.EndUpdate();
                }
            }
        }

        void AddIncome() {
            AddTransactionResult transactionResult = new AddTransactionResult();
            AddTransactionForm addGainForm = new AddTransactionForm(true, generator.IncomeCategorys.ToArray(), transactionResult);
            addGainForm.SetMenuManager(spreadsheetControl1.MenuManager);
            if (addGainForm.ShowDialog() == DialogResult.OK) {
                spreadsheetControl1.BeginUpdate();
                try {
                    generator.AddTransaction(true, transactionResult.TransactionDate, transactionResult.Sum, transactionResult.Category);
                }
                finally {
                    spreadsheetControl1.EndUpdate();
                }
            }
        }

        private void ReadOnlyCheckCheckedChanged(object sender, EventArgs e) {
            spreadsheetControl1.ReadOnly = readOnlyCheck.Checked;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            const int WM_KEYDOWN = 0x100;
            const int WM_SYSKEYDOWN = 0x104;

            if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN)) {
                switch (keyData) {
                    case Keys.F7:
                        AddIncome();
                        break;

                    case Keys.F8:
                        AddExpense();
                        break;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
        }

    }

    public class AddTransactionResult {
        public float Sum { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Category { get; set; }
        public AddTransactionResult() {
            Sum = 0;
            TransactionDate = DateTime.Today;
            Category = String.Empty;
        }
    }

    
}
