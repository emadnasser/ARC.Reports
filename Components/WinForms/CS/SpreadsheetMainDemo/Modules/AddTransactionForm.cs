using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Menu;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class AddTransactionForm : Form {
        AddTransactionResult result;
        bool IsLeap(int year) { return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0); }

        int DaysInMonth(int month, int year) {
            int[,] days = { { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }, { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 } };
            return days[Convert.ToInt32(IsLeap(year)), month];
        }

        public AddTransactionForm(bool income, string[] categorys, AddTransactionResult result) {
            InitializeComponent();
            this.Text = income ? "Add income" : "Add expense";
            categoryComboBox.Properties.Items.AddRange(categorys);
            categoryComboBox.Text = "Uncategorised";
            DateTime today = DateTime.Now;
            monthComboBox.Properties.BeginUpdate();
            for (int i = 1; i <= 12; i++) {
                monthComboBox.Properties.Items.Add(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
            }
            monthComboBox.Properties.EndUpdate();
            monthComboBox.SelectedIndex = today.Month - 1;
            dayTextEdit.Value = today.Day;
            dayTextEdit.Properties.MinValue = 1;
            this.result = result;
        }

        public void SetMenuManager(IDXMenuManager menuManager) {
            DemoMenuManager.SetMenuManager(Controls, menuManager);
        }

        void FillResult() {
            result.Category = categoryComboBox.Text == "" ? "Uncategorised" : categoryComboBox.Text;
            result.TransactionDate = new DateTime(2013, monthComboBox.SelectedIndex + 1, (int)dayTextEdit.Value);
            result.Sum = (float)sumEdit.Value;
        }

        private void OkButtonClick(object sender, EventArgs e) {
            FillResult();
        }

        private void MonthComboBoxEditValueChanged(object sender, EventArgs e) {
            dayTextEdit.Properties.MaxValue = DaysInMonth(monthComboBox.SelectedIndex, 2013);
        }
    }
}
