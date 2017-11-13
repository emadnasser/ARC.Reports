using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using DevExpress.XtraReports;

namespace XtraReportsDemos.IListDatasource
{
	public class PreviewControl : XtraReportsDemos.PreviewControl
	{
		protected override XtraReport CreateReport() {
            return new Report();
		}
	}
}

