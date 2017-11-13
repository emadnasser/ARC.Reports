using System.Linq;
using System.Data.Linq;
using System.Data.Entity;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Drawing;
using DevExpress.DemoData.Models;
using System.Configuration;

namespace XtraReportsDemos.CustomDraw {
    /// <summary>
    /// Summary description for XtraReport1.
    /// </summary>
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {

        public Report() {
            InitializeComponent();
            Name = ReportNames.CustomDraw;
            DisplayName = ReportNames.CustomDraw;
            UpdateControls();
        }
        public int RegionID { get { return (int)Parameters["RegionIdParameter"].Value; } }

        protected override void OnBeforePrint(System.Drawing.Printing.PrintEventArgs e) {
            UpdateControls();
            base.OnBeforePrint(e);
        }
        void UpdateControls() {
            using(var entities = new CountriesEntities()) {
                var regions = (from region in entities.AboutRegions
                               where region.Id == RegionID
                               select region).ToList();
                xrLabel1.Text = regions.FirstOrDefault().Region;
                customControl1.UpdateData(regions);
            }
        }
    }
}
