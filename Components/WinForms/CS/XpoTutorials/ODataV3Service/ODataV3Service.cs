using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo.DB;
using DevExpress.Data.Filtering;
using System.Globalization;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.Xpo.Demos;
using System.ServiceModel;
using System.Threading;
using DevExpress.Xpo.Metadata;
using DevExpress.DemoData.Core;
using System.Diagnostics;
using DevExpress.Data.WcfLinq;
using System.IO;
using DevExpress.Xpo.Demos.OData;

namespace DevExpress.Xpo.Demos {
    public partial class ODataV3Service : TutorialControl {
        Uri serviceUri;
        public ODataV3Service() {
            InitializeComponent();
        }
        private void sbEmployees_Click(object sender, EventArgs e) {
            NorthwindEntities context = new NorthwindEntities(serviceUri);
            WcfInstantFeedbackSource dataSource = new WcfInstantFeedbackSource((args) => {
                args.KeyExpression = "CustomerID";
                args.Query = context.Customers;
                args.AreSourceRowsThreadSafe = true;
            });
            gclODataV3ServiceMain.DataSource = dataSource;
        }
        private void sbStartService_Click(object sender, EventArgs e) {
            string serviceFile = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "CS\\XpoODataService\\XpoDemoService.svc");
            if(string.IsNullOrEmpty(serviceFile)) return;
            string servicePath = Path.GetDirectoryName(serviceFile);
            string path = WebDevServerHelper.PrepareDemoPathForProcessing(servicePath, servicePath + ".ur1", false);
            serviceUri = new Uri(path + "XpoDemoService.svc");
            sbEmployees.Enabled = true;
            sbViewMetadata.Enabled = true;
            sbStartService.Enabled = false;
        }

        private void sbViewMetadata_Click(object sender, EventArgs e) {
            Process.Start(serviceUri.OriginalString + "/$metadata");
        }
    }
    
}

