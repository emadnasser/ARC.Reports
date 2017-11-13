using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using DevExpress.XtraReports.UI;
using System.IO;

namespace XtraReportsDemos.AnchorVertical {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.Anchor;
            DisplayName = ReportNames.Anchor;
            BeforePrint += AnchorReport_BeforePrint;
            PrintingSystem.AfterMarginsChange += PrintingSystem_AfterMarginsChange;
            PrintingSystem.PageSettingsChanged += PrintingSystem_PageSettingsChanged;  
        }

        void PrintingSystem_PageSettingsChanged(object sender, EventArgs e) {
            DevExpress.XtraPrinting.PrintingSystemBase ps = sender as DevExpress.XtraPrinting.PrintingSystemBase;
            DevExpress.XtraPrinting.XtraPageSettingsBase pageSettings = ps.PageSettings;

            this.PaperKind = pageSettings.PaperKind;
            this.Landscape = pageSettings.Landscape;
            Parameters["LandscapeParameter"].Value = pageSettings.Landscape;

            CreateDocument();
        }
        void PrintingSystem_AfterMarginsChange(object sender, DevExpress.XtraPrinting.MarginsChangeEventArgs e) {
            switch(e.Side) { 
                case DevExpress.XtraPrinting.MarginSide.Left :
                    this.Margins = new System.Drawing.Printing.Margins((int)e.Value, Margins.Right, Margins.Top, Margins.Bottom);
                    CreateDocument();
                    break;
                case DevExpress.XtraPrinting.MarginSide.Right :
                    this.Margins = new System.Drawing.Printing.Margins(Margins.Left, (int)e.Value, Margins.Top, Margins.Bottom);
                    CreateDocument();
                    break;
                case DevExpress.XtraPrinting.MarginSide.All:
                    this.Margins = (sender as DevExpress.XtraPrinting.PrintingSystemBase).PageSettings.Margins;
                    CreateDocument();
                    break;
                default: 
                    break;
            }
        }
        void AnchorReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            SetLandscape((bool)Parameters["LandscapeParameter"].Value);
        }
        public void SetLandscape(bool landscape) {
            this.Landscape = landscape;
        }
    }
}
