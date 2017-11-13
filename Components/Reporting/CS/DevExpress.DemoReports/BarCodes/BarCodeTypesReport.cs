using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.BarCodes {
	public partial class BarCodeTypesReport : DevExpress.XtraReports.UI.XtraReport {
		public BarCodeTypesReport() {
			InitializeComponent();
			Name = ReportNames.BarCodes_BarcodeTypes;
            DisplayName = ReportNames.BarCodes_BarcodeTypes;
            BeforePrint += BarCodeTypesReport_BeforePrint;
		}

        void BarCodeTypesReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            SetAutoModule((bool)Parameters["AutoModuleParameter"].Value);
        }
        public void SetAutoModule(bool autoModule) {
            foreach(XRBarCode barCode in AllControls<XRBarCode>())
                barCode.AutoModule = autoModule;
        }
    }
}
