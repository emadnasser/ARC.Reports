using System;
using System.IO;
using System.Windows.Forms;
using DashboardDemos.Core;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using DevExpress.DashboardCommon;

namespace FinanceDashboardDemo {
    public partial class ViewerForm : XtraForm {                
        const int dashboardId = 1;
        MemoryStream currentDashboardStream;
        string dashboardStorageConnectionString, financialDemoConnectionString, corporateDemoConnectionString;
        
        public ViewerForm() {
            InitializeComponent();         
            barItemRefresh.Enabled = false;
            barItemExport.Enabled = false;
            barItemParameters.Enabled = false;
            gallerySkins.Manager = barManager;
            SkinHelper.InitSkinGalleryDropDown(gallerySkins);
            standaloneBarDockControl1.AllowTransparency = true;
            dashboardViewer.ConfigureDataConnection += dashboardViewer_ConfigureDataConnection;
        }

        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components!=null)
                    components.Dispose();
                if(currentDashboardStream!=null)
                    currentDashboardStream.Dispose();
            }   
            base.Dispose(disposing);
        }        

        void RefreshDashboard() {
            try {
                MemoryStream ms = DashboardDemosUtils.GetDashboardStream(dashboardStorageConnectionString, dashboardId);
                if(ms != null ) {
                    if (currentDashboardStream != null)
                        currentDashboardStream.Dispose();
                    currentDashboardStream = ms;
                }
                if(currentDashboardStream != null) {
                    dashboardViewer.LoadDashboard (currentDashboardStream);
                    dashboardViewer.Dashboard.Title.Visible = false;
                }                
            }
            catch (Exception e) {
                XtraMessageBox.Show(e.InnerException != null ? e.InnerException.Message : e.Message, "Finance Dashboard Demo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void dashboardViewer_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e) {
            if(e.ConnectionName == "FinanceDemoConnection") {
                CustomStringConnectionParameters connectionParameters = new CustomStringConnectionParameters(financialDemoConnectionString);
                e.ConnectionParameters = connectionParameters;
            }
        }
        void FinanceDashboardDemo_Load(object sender, EventArgs e) {
            dashboardStorageConnectionString = DashboardDemosUtils.DashboardStorageConnectionString;
            financialDemoConnectionString = DashboardDemosUtils.FinancialDemoConnectionString;
            corporateDemoConnectionString =DashboardDemosUtils.CorporateDemoConnectionString;
            if(!string.IsNullOrEmpty(dashboardStorageConnectionString)) {
                if(DashboardDemosUtils.CreateDatabasesWin(dashboardStorageConnectionString, financialDemoConnectionString, corporateDemoConnectionString)) {
                    RefreshDashboard();
                    barItemRefresh.Enabled = true;
                    barItemExport.Enabled = true;
                    barItemParameters.Enabled = true;
                }
            }
            else {
                XtraMessageBox.Show("This demo requires SQL Server Express installed to automatically create a sample database. Alternatively, you can manually specify a connection string to the server where the database should be created. You can do this in the connections.config file.");
            }
        }               
        void barItemPrint_ItemClick(object sender, ItemClickEventArgs e) {
            dashboardViewer.ShowPrintPreview();
        }
        void barItemExportToPdf_ItemClick(object sender, ItemClickEventArgs e) {
            using (SaveFileDialog sd = new SaveFileDialog())
            {
                sd.Filter = "Pdf files|*.pdf";                
                if(sd.ShowDialog(this) == DialogResult.OK)
                    dashboardViewer.ExportToPdf(sd.FileName);            	
            }            
        }
        void barItemExportToImage_ItemClick(object sender, ItemClickEventArgs e) {
            using(SaveFileDialog sd = new SaveFileDialog()) {
                sd.Filter = "PNG files|*.png";
                if(sd.ShowDialog(this) == DialogResult.OK)
                    dashboardViewer.ExportToImage(sd.FileName);
            }
        }
        void barItemRefresh_ItemClick(object sender, ItemClickEventArgs e) {
            RefreshDashboard();
        }
        private void barItemParameters_ItemClick(object sender, ItemClickEventArgs e) {
            dashboardViewer.ShowDashboardParametersForm();
        }
    }
}
    
