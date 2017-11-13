using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraLayout.Demos {
	public class TutorialControl : TutorialControlBase {
		private DevExpress.Utils.Frames.NotePanel fDescription = null;
        public virtual LayoutControl ExportControl { get { return null; } }
        protected override void AllowExport() {
            EnabledPrintExportActions(true, ExportFormats.PDF | ExportFormats.HTML | ExportFormats.MHT | ExportFormats.XLS |
                ExportFormats.RTF | ExportFormats.Text | ExportFormats.XLSX, false);
        }
        public override bool AllowPrintOptions { get { return ExportControl != null; } }
        protected override void SetControlManager(Control ctrl, BarManager manager) {
			DevExpress.XtraLayout.LayoutControl layout = ctrl as DevExpress.XtraLayout.LayoutControl;
			if(layout != null) 
                layout.MenuManager = manager;
            BaseEdit be = ctrl as BaseEdit;
            if(be != null) be.MenuManager = manager;
		}

		public DevExpress.Utils.Frames.NotePanel Description {
			get { return fDescription; }
			set { fDescription = value; 
				OnSetDescription("");	
			}
		}
		protected virtual void OnSetDescription(string fDescription) {
			if(fDescription == string.Empty) return;
			Description.Text = string.Format(fDescription);
		}
		public DataView TutorialDataView { get { return dvTutorial; } }
		DataView dvTutorial = null;
		protected DataView GetNWindData(DataSet ds, string tableName) {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\nwind.mdb");
			if(DBFileName != "") {
				if(ds == null) ds = new DataSet();
				string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
				System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tableName, con);
				SetWaitDialogCaption(string.Format("Loading {0}...", tableName));
				oleDbDataAdapter.Fill(ds, tableName);
				
				dvTutorial = ds.Tables[tableName].DefaultView;
				return dvTutorial;
			}
			return null;
		}
		protected DataView GetCarsData(DataSet ds) {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\cars.xml");
			if(DBFileName != "") {
				if(ds == null) ds = new DataSet();
				SetWaitDialogCaption(string.Format("Loading {0}...", "cars.xml"));
				ds.ReadXml(DBFileName);
				dvTutorial = ds.Tables[0].DefaultView;
				return dvTutorial;
			}
			return null;
		}
		public DataRowView GetDataRowByIndex(int index) {
			if(dvTutorial != null)
				return dvTutorial[index];
			return null;
		}
        #region Print and Export
        protected override void ExportToCore(String filename, string ext) {
            if(ExportControl == null) return;
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if(ext == "rtf") ExportControl.ExportToRtf(filename);
            if(ext == "pdf") ExportControl.ExportToPdf(filename);
            if(ext == "mht") ExportControl.ExportToMht(filename);
            if(ext == "html") ExportControl.ExportToHtml(filename);
            if(ext == "txt") ExportControl.ExportToText(filename);
            if(ext == "xls") ExportControl.ExportToXls(filename);
            if(ext == "xlsx") ExportControl.ExportToXlsx(filename);
            Cursor.Current = currentCursor;
        }
        protected override void ExportToPDF() {
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf");
        }
        protected override void ExportToHTML() {
            ExportTo("html", "HTML document (*.html)|*.html");
        }
        protected override void ExportToMHT() {
            ExportTo("mht", "MHT document (*.mht)|*.mht");
        }
        protected override void ExportToXLS() {
            ExportTo("xls", "XLS document (*.xls)|*.xls");
        }
        protected override void ExportToXLSX() {
            ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx");
        }
        protected override void ExportToRTF() {
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf");
        }
        protected override void ExportToText() {
            ExportTo("txt", "Text document (*.txt)|*.txt");
        }
        protected override void PrintPreview() {
            if(this.ExportControl != null) {
                if(RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                    this.ExportControl.ShowRibbonPrintPreview();
                else this.ExportControl.ShowPrintPreview();
            }
        }
        #endregion
	}
}
