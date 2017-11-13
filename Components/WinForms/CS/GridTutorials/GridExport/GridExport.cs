using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraExport;
using DevExpress.XtraGrid.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridExport.
    /// </summary>
    public partial class GridExport : TutorialControl {
        public GridExport() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            gridView1.PrintExportProgress += new ProgressChangedEventHandler(gridView1_PrintExportProgress);
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void GridExport_Load(object sender, System.EventArgs e) {
            InitNWindData();
            InitExportData();
        }

        void InitExportData() {
            for(int i = 0; i < exportData.GetLength(0); i++)  
                cbExport.Properties.Items.Add(exportData.GetValue(i, 0));
            cbExport.SelectedIndex = 0;
        }

        string tblGrid = "[Order Details]";
        string tblLookUp = "Products";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblGrid, connectionString);
            oleDbDataAdapter.Fill(ds, tblGrid);
            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblLookUp, connectionString);
            oleDbDataAdapter.Fill(ds, tblLookUp);
            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.ShowOnlyPredefinedDetails = true;
            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }

        private void OpenFile(string fileName) {
            if(XtraMessageBox.Show("Do you want to open this file?", "Export To...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                try {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = fileName;
                    process.StartInfo.Verb = "Open";
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    process.Start();
                }
                catch {
                    DevExpress.XtraEditors.XtraMessageBox.Show(this, "Cannot find an application on your system suitable for openning the file with exported data.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            progressBarControl1.Position = 0;
        }
        
        private void ExportToEx(String filename, string ext, BaseView exportView) {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if(ext == "rtf") exportView.ExportToRtf(filename);
            if(ext == "pdf") exportView.ExportToPdf(filename);
            if(ext == "mht") exportView.ExportToMht(filename);
            if(ext == "htm") exportView.ExportToHtml(filename);
            if(ext == "txt") exportView.ExportToText(filename);
            if(ext == "xls") exportView.ExportToXls(filename);
            if(ext == "xlsx") exportView.ExportToXlsx(filename);
            Cursor.Current = currentCursor;
        }
        private string ShowSaveFileDialog(string title, string filter) {
            SaveFileDialog dlg = new SaveFileDialog();
            string name = Application.ProductName;
            int n = name.LastIndexOf(".") + 1;
            if(n > 0) name = name.Substring(n, name.Length - n);
            dlg.Title = "Export To " + title;
            dlg.FileName = name;
            dlg.Filter = filter;
            if(dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;
            return "";
        }
        void gridView1_PrintExportProgress(object sender, ProgressChangedEventArgs e) {
            SetPosition(e.ProgressPercentage);
        }
        void SetPosition(int pos) {
            progressBarControl1.Position = pos;
            this.Update();
        }
        string[,] exportData = new string[,] {{"HTML Document", "HTML Documents|*.html", "htm"}, 
            {"Microsoft Excel 2007 Document", "Microsoft Excel|*.xlsx", "xlsx"}, 
            {"Microsoft Excel Document", "Microsoft Excel|*.xls", "xls"}, 
            {"RTF Document", "RTF Files|*.rtf", "rtf"},
            {"PDF Document", "PDF Files|*.pdf", "pdf"},
            {"MHT Document", "MHT Files|*.mht", "mht"},
            {"Text Document", "Text Files|*.txt", "txt"}};
        private void sbExport_Click(object sender, EventArgs e) {
            int index = cbExport.SelectedIndex;
            if(index < 0) return;
            string fileName = ShowSaveFileDialog(exportData.GetValue(index, 0).ToString(), exportData.GetValue(index, 1).ToString());
            if(fileName == string.Empty) return;
            ExportToEx(fileName, exportData.GetValue(index, 2).ToString(), gridView1);
            OpenFile(fileName);
        }
    }
}
