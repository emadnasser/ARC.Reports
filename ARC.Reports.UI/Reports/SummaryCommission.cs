using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using System.Collections.Generic;
using ARC.Reports.DAL;

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
            //if (Parameters[0].Value.ToString() == "1/1/0001 12:00:00 AM")
            //{
            //    lblDateFrom.Text = "...";
            //}
            //if (Parameters[1].Value.ToString() == "1/1/0001 12:00:00 AM")
            //{
            //    Parameters[1].Value = DateTime.Now;
            //    lblDateTo.Text = "...";
            //}
        }

        private void SummaryCommission_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //if (Parameters[0].Value.ToString() == "1/1/2007 12:00:00 AM")
            //{
            //    lblDateFrom.Text = "....";
            //}
            //if (lblDateTo.Text == DateTime.Now.ToString("dd/M/yyyy"))
            //{
            //    lblDateTo.Text = "....";
            //}
            //if (Parameters[2].Value.ToString() != "")
            //{
            //    //lblMonthH.Text = "CIC:";
            //    //lblMonthH.WidthF = 27;
            //    //lblMonthD.Visible = true;
            //    //lblMonthD.Text = Parameters[2].Value.ToString();
            //}
            //if (Parameters[0].Value.ToString() != "")
            //{
            //    //lblMonthH.Text = "Month:";
            //    //lblMonthH.WidthF = 35;
            //    //lblMonthD.Visible = true;
            //    //lblMonthD.Text = Parameters[0].Value.ToString();
            //}
            //if (Parameters[1].Value.ToString() != "")
            //{
            //    //lblMonthH.Text = "Year:";
            //    //lblMonthH.WidthF = 35;
            //    //lblMonthD.Visible = true;
            //    //lblMonthD.Text = Parameters[1].Value.ToString();
            //}
            //if (Parameters[2].Value.ToString() != "")
            //{
            //    //lblMonthH.Text = "Equator:";
            //    //lblMonthH.WidthF = 35;
            //    //lblMonthD.Visible = true;
            //    //lblMonthD.Text = Parameters[2].Value.ToString();
            //}
            //if (Parameters[3].Value.ToString() != "")
            //{
            //    //lblMonthH.Text = "Agent:";
            //    //lblMonthH.WidthF = 35;
            //    //lblMonthD.Visible = true;
            //    //lblMonthD.Text = Parameters[3].Value.ToString();
            //}
            //if (Parameters[4].Value.ToString() == "")
            //{
            //    lblCIC.Text = "....";
            //}
            //else
            //{
            //    //lblMonthH.Text = "The Last 150 Records:";
            //    //lblMonthH.WidthF = 200;
            //    //lblMonthD.Visible = false;
            //}
        }

        private void SummaryCommission_ParametersRequestValueChanged(object sender, ParametersRequestValueChangedEventArgs e)
        {
            
        }
    }
}
