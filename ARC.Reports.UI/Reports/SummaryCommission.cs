using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using System.Collections.Generic;

namespace ARC.Reports.Reports
{
    public partial class SummaryCommission : DevExpress.XtraReports.UI.XtraReport
    {
        public SummaryCommission()
        {
            InitializeComponent();

            //if (lblEquatorD.NullValueText=="")
            //{
            //    lblEquatorH.Visible = false;
            //    lblEquatorD.Visible = false;
            //}
            //else
            //{
            //    lblEquatorH.Visible = true;
            //    lblEquatorD.Visible = true;
            //}
        }

        private void SummaryCommission_ParametersRequestBeforeShow(object sender, ParametersRequestEventArgs e)
        {
            //e.ParametersInformation[0].Parameter.Value = DateTime.Now.Month.ToString("D2");
            //e.ParametersInformation[1].Parameter.Value = DateTime.Now.Year.ToString("D4");
        }

        private void SummaryCommission_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //if (Parameters[0].Value.ToString() == "" && Parameters[1].Value.ToString() == "" &&
            //    Parameters[2].Value.ToString() == "" && Parameters[3].Value.ToString() == "" &&
            //    Parameters[4].Value.ToString() == "" && Parameters[5].Value.ToString() == ""
            //    )
            //{
            //    StopPageBuilding();
            //}
        }
    }
}
