using System;
using DevExpress.XtraBars;
using DevExpress.ReportServer.Printing;
using System.Collections.Generic;
using System.Linq;
using DevExpress.ReportServer.ServiceModel.DataContracts;
using DevExpress.DocumentServices.ServiceModel;
using DevExpress.XtraPrinting.Native;
using XtraPrintingDemos.Properties;
using DevExpress.XtraPrinting;
using DevExpress.XtraEditors.Controls;

namespace XtraPrintingDemos.ReportService {
    /// <summary>
    /// Summary description for PreviewControl.
    /// </summary>
    public class PreviewControl : XtraPrintingDemos.PreviewControl {
        class ReportInfo {
            public int Id { get; set; }
            public Pair<string, object> Parameter { get; set; }
        }

        static readonly Dictionary<string, ReportInfo> availableReports = new Dictionary<string, ReportInfo>();

        private System.ComponentModel.IContainer components;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraEditors.CheckedListBoxControl reportListBox;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem;

        string SelectedReport {
            get {
                var checkedItem = reportListBox.Items.FirstOrDefault<CheckedListBoxItem>(item => item.CheckState == System.Windows.Forms.CheckState.Checked);
                return checkedItem != null ? checkedItem.Value.ToString() : availableReports.Keys.ElementAt<string>(0);
            }
        }

        public PreviewControl() {
            availableReports.Add("Invoice", new ReportInfo { Id = 5, Parameter = new Pair<string, object>("maxOrderId", 10260) } );
            availableReports.Add("Suppliers", new ReportInfo { Id = 6 } );
            availableReports.Add("Product List", new ReportInfo { Id = 4 } );
            availableReports.Add("Customer Order History", new ReportInfo { Id = 1113 });

            InitializeComponent();
            foreach(string key in availableReports.Keys)
                reportListBox.Items.Add(key);
            reportListBox.Items[0].CheckState = System.Windows.Forms.CheckState.Checked;
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                DisposeDocumentSource();
            }
            base.Dispose(disposing);
        }
        void LoadReport(int reportId, Pair<string, object> parameter) {
            DisposeDocumentSource();
            var documentSource = new RemoteDocumentSource {
                ServiceUri = Settings.Default.ReportServer,
                ReportIdentity = new ReportIdentity(reportId),
                AuthenticationType = AuthenticationType.Guest
            };
            pControl.DocumentSource = documentSource;
            var parameters = new DefaultValueParameterContainer();
            if(parameter != null) {
                parameters[parameter.First].Value = parameter.Second;
            }
            documentSource.CreateDocument(parameters);
            Viewer.ExecCommand(PrintingSystemCommand.ZoomToPageWidth);
        }
        void DisposeDocumentSource() {
            RemoteDocumentSource documentSource = pControl.DocumentSource as RemoteDocumentSource;
            if(documentSource != null) {
                pControl.DocumentSource = null;
                documentSource.Dispose();
            }
        }
        protected override void CreateDocumentCore() {
            ReportInfo reportInfo = availableReports[SelectedReport];
            LoadReport(reportInfo.Id, reportInfo.Parameter);
        }
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.printingSystem = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.reportListBox = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportListBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pControl
            // 
            this.pControl.DocumentSource = this.printingSystem;
            this.pControl.Size = new System.Drawing.Size(997, 497);
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Location = new System.Drawing.Point(1001, 0);
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(210, 501);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(210, 501);
            this.navigationPane1.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Default;
            this.navigationPane1.Visible = true;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Reports";
            this.navigationPage1.Controls.Add(this.reportListBox);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(167, 441);
            // 
            // reportListBox
            // 
            this.reportListBox.CheckOnClick = true;
            this.reportListBox.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.reportListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportListBox.Location = new System.Drawing.Point(0, 0);
            this.reportListBox.Name = "reportListBox";
            this.reportListBox.Size = new System.Drawing.Size(167, 441);
            this.reportListBox.TabIndex = 0;
            this.reportListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.reportListBox_ItemCheck);
            // 
            // PreviewControl
            // 
            this.Name = "PreviewControl";
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportListBox)).EndInit();
            this.ResumeLayout(false);

        }
        private void reportListBox_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e) {
            this.reportListBox.ItemCheck -= new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.reportListBox_ItemCheck);

            for(int i = 0; i < reportListBox.Items.Count; i++)
                if(i != e.Index)
                    reportListBox.Items[i].CheckState = System.Windows.Forms.CheckState.Unchecked;

            this.reportListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.reportListBox_ItemCheck);
            CreateDocument();
        }
    }
}
