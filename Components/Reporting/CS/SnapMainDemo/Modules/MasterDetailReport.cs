using System;
using System.IO;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.Snap.Core.API;
using DevExpress.Utils;

namespace SnapDemos.Modules {
    public partial class MasterDetailReport : BaseTutorial {
        public MasterDetailReport() {
            using (WaitDialogForm dlg = new WaitDialogForm("Please wait", "Loading...")) {
                SubscribeEvents();
                LoadDocument();
            }
        }
        void LoadDocument() {
            string path = FindFilePathByName("MasterDetailReport");
            if (File.Exists(path))
                this.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap);
        }
        void SubscribeEvents() {
            this.snapControl1.Document.ConfigureDataConnection += new ConfigureDataConnectionEventHandler(OnConfigureDataConnection);
        }
        void OnConfigureDataConnection(object sender, ConfigureDataConnectionEventArgs e) {
            Access97ConnectionParameters parameters = e.ConnectionParameters as Access97ConnectionParameters;
            if (parameters == null)
                return;
            string path = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, @"Data\nwind.mdb", false);
            parameters.FileName = path;
        }
    }
}
