using System;
using DevExpress.Spreadsheet;
using System.Globalization;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class WeatherInCaliforniaModule : SpreadsheetRibbonTutorialControlBase {
        public WeatherInCaliforniaModule() {
            InitializeComponent();
            InitializeWorkbook();
            this.spreadsheetControl1.Options.Culture = DefaultCulture;
            UpdateConditionalFormatting();
        }

        void InitializeWorkbook() {
            IWorkbook workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(DemoUtils.GetRelativePath("WeatherInCalifornia.xlsx"));
        }

        void OnCheckedChanged(object sender, EventArgs e) {
            UpdateConditionalFormatting();
            
        }

        void UpdateConditionalFormatting() {
            spreadsheetControl1.BeginUpdate();
            try {
                Worksheet sheet = spreadsheetControl1.ActiveWorksheet;
                sheet.ConditionalFormattings.Clear();
                if (chkTemperature.Checked)
                    WeatherInCalifornia.ApplyTemperatureConditionalFormatting(sheet);
                if (chkHumidity.Checked)
                    WeatherInCalifornia.ApplyHumidityConditionalFormatting(sheet);
                if (chkPressure.Checked)
                    WeatherInCalifornia.ApplyPressureConditionalFormatting(sheet);
            }
            finally {
                spreadsheetControl1.EndUpdate();
            }
        }
    }
}
