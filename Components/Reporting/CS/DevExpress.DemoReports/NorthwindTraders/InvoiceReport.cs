using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.NorthwindTraders
{
	public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
	{
		private double Total = 0.0f;
		public InvoiceReport()
		{
			InitializeComponent();

			Name = ReportNames.NorthwindTraders_Invoice;
            DisplayName = ReportNames.NorthwindTraders_Invoice;
		}

		private void lbShipCityRegionPostalCode_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
			((XRLabel)sender).Text =  GetColumnValue("ShipCity")+ "  " +  
				GetColumnValue("ShipRegion")+ "  " + 
				GetColumnValue("ShipPostalCode");
		}
		private void lbCityRegionPostalCode_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
			((XRLabel)sender).Text = GetColumnValue("City") + "  " + 
				GetColumnValue("Region") + "  " + 
				GetColumnValue("PostalCode");
		}
		private string GetColumnValue(string columnValue) {
            if (GetCurrentColumnValue(columnValue) != null)
                return GetCurrentColumnValue(columnValue).ToString();
            return "  ";
		}
		private void clTotal_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
			XRTableCell cell = sender as XRTableCell;
			Total = Convert.ToDouble(clSubtotal.Summary.GetResult()) + Convert.ToDouble(GetCurrentColumnValue("Freight"));
			string s = string.Format("{0:'Total: '$#,##.00}", Total);
			cell.Text = s;
		}
	}
}
