using System;
using System.Linq;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using DevExpress.XtraReports.UI;
using System.IO;
using DevExpress.XtraPrinting;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.DataAccess.Excel;

namespace XtraReportsDemos.PollingReport {
    public partial class PollingReport : DevExpress.XtraReports.UI.XtraReport {

        public PollingReport() {
            InitializeComponent();

            Name = ReportNames.PollingReport;
            DisplayName = ReportNames.PollingReport;
        }
        public void UpdateData(IList<ResultingData> data) {
            ResultingDataAdapter adapter = new ResultingDataAdapter(this.DataSource as ExcelDataSource);
            if(data.Count == 0) adapter.InitializeData(data);
            IList<ResultingData> newData = adapter.GetData(PrintingSystem.EditingFields);
            foreach(ResultingData item in newData) {
                ResultingData item2 = data.FirstOrDefault<ResultingData>(item3 => item3.Question == item.Question && item3.Answer == item.Answer);
                if(item2 != null)
                    item2.AnswerCount += item.AnswerCount;
                else
                    data.Add(item); 
            }
        }
        private void detailBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            string id = Report.GetCurrentColumnValue("AnswerID").ToString();
            xrCheckBox1.EditOptions.ID = xrLabel2.EditOptions.ID = xrLabel3.EditOptions.ID = id;

            if(Report.GetCurrentColumnValue("AnswerType").ToString().Contains("Radio")) {
                string id2 = Report.GetCurrentColumnValue("QuestionID").ToString();
                xrCheckBox1.EditOptions.GroupID = id2;
            }
            if(Report.GetCurrentColumnValue("AnswerType").ToString() == "Number")
                xrLabel3.EditOptions.EditorName = EditingFieldEditorNames.IntegerPositive;
        }
        private void detailBand1_AfterPrint(object sender, EventArgs e) {
            xrCheckBox1.EditOptions.ID = xrLabel2.EditOptions.ID = xrLabel3.EditOptions.ID = string.Empty;
            xrCheckBox1.EditOptions.GroupID = string.Empty;
            xrLabel3.EditOptions.EditorName = string.Empty;
        }
        private void PollingReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            PrintingSystem.EditingFieldChanged -= PrintingSystem_EditingFieldChanged;
            PrintingSystem.EditingFieldChanged += PrintingSystem_EditingFieldChanged;
        }

        private void PrintingSystem_EditingFieldChanged(object sender, DevExpress.XtraPrinting.EditingFieldEventArgs e) {
            if(Equals("RadioText", e.EditingField.Brick.Value)) {
                IEnumerable<EditingField> EditingFields = PrintingSystem.EditingFields.Where<EditingField>(item => item.ID == e.EditingField.ID);
                foreach(EditingField item in EditingFields)
                    if(!ReferenceEquals(item, e.EditingField)) {
                        item.ReadOnly = e.EditingField.EditValue.Equals(CheckState.Unchecked);
                        ((TextBrick)item.Brick).ForeColor = item.ReadOnly ? System.Drawing.Color.LightGray : System.Drawing.Color.Black;
                    }
            }
        }
    }
}
