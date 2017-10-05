using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using System.Collections.Generic;
using ARC.Reports.DAL;
using DevExpress.XtraReports.Web;

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
            if (Parameters[0].Value.ToString() == "1/1/0001 12:00:00 AM")
            {
                //lblDateFrom.Text = "...";
            }
            if (Parameters[1].Value.ToString() == "1/1/0001 12:00:00 AM")
            {
                Parameters[1].Value = DateTime.Now;
                //lblDateTo.Text = "...";
            }
        }

        private void SummaryCommission_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (Parameters[2].Value.ToString() == "" && Parameters[3].Value.ToString() == "" &&
                Parameters[4].Value.ToString() == "" && Parameters[5].Value.ToString() == "" &&
                Parameters[6].Value.ToString() == "" && Parameters[7].Value.ToString() == "")
            {
                StopPageBuilding();
            }

            //if (e.PrintAction == System.Drawing.Printing.PrintAction.PrintToFile) //|| e.PrintAction == System.Drawing.Printing.PrintAction.PrintToFile)
            //    xrPictureBox1.Visible = true;
            //else
            //    xrPictureBox1.Visible = false;
        }

        //private void xrPictureBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    if (e.PrintAction == System.Drawing.Printing.PrintAction.PrintToFile) //|| e.PrintAction == System.Drawing.Printing.PrintAction.PrintToFile)
        //        xrPictureBox1.Visible = false;
        //    else
        //        xrPictureBox1.Visible = true;

        //    //    base.OnBeforePrint(e);
        //}
    }
}
