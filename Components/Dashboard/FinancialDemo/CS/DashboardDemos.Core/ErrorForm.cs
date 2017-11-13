using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DashboardDemos.Core {
    public partial class ErrorForm : XtraForm {
        
        public ErrorForm(string serverName, Exception ex) {
            InitializeComponent();            
            if (ex is SqlServerNotFoundException) {
                labelErrorCaption.Text = string.Format("Unable to connect to {0} SQL Server instance:", serverName);
            }            
            if (ex is DatabaseCreatingException) {
                labelErrorCaption.Text = string.Format("An error occurred when creating a demo database on the {0} SQL server instance:", serverName);
            }
           textEditErrorDetails.Text = ex.Message; 
        }

        private void labelControl3_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e) {
            Process process = new Process();
            process.StartInfo.FileName = e.Link;
            process.StartInfo.Verb = "open";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            try {
                process.Start();
            }
            catch { }
        }
    }
}
