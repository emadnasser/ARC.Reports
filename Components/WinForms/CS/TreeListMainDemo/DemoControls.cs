using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraTreeList;
using DevExpress.XtraPrinting;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraTreeList.Demos {
	public class TutorialControl : TutorialControlBase {
		private DevExpress.Utils.Frames.NotePanel fDescription = null;
		public TutorialControl() {}
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
        public TreeListRibbonMenuManager TreeListRibbonMenuManager { get { return RibbonMenuManager as TreeListRibbonMenuManager; } } 
        protected override void AllowExport() {
            EnabledPrintExportActions(true, ExportFormats.PDF | ExportFormats.HTML | ExportFormats.MHT | ExportFormats.XLS |
                ExportFormats.RTF | ExportFormats.Text | ExportFormats.XLSX, false);
        }
        public override bool AllowPrintOptions { get { return ExportControl != null; } }

		public virtual TreeList ExportControl { get { return null; } }
		public virtual TreeList ViewOptionsControl { get { return null; } }

		protected override void DoHide() {
			foreach(Control ctrl in this.Controls)
				if(ctrl is TreeList)
					((TreeList)ctrl).DestroyCustomization();
		}

		protected override void SetControlManager(Control ctrl, BarManager manager) {
			DevExpress.XtraTreeList.TreeList treeList = ctrl as DevExpress.XtraTreeList.TreeList;
			if(treeList != null) treeList.MenuManager = manager;
		}
        #region Print and Export
        Thread thread;
        bool stop;
        protected override void ExportToCore(String filename, string ext) {
            if(ExportControl == null) return;
            stop = false;
            thread = new Thread(new ThreadStart(StartExport));
            thread.Start();
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if(ext == "rtf") ExportControl.ExportToRtf(filename);
            if(ext == "pdf") ExportControl.ExportToPdf(filename);
            if(ext == "mht") ExportControl.ExportToMht(filename, new MhtExportOptions());
            if(ext == "html") ExportControl.ExportToHtml(filename);
            if(ext == "txt") ExportControl.ExportToText(filename);
            if(ext == "xls") ExportControl.ExportToXls(filename);
            if(ext == "xlsx") ExportControl.ExportToXlsx(filename);
            EndExport();
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
        void StartExport() {
            Thread.Sleep(400);
            if(stop)
                return;
            ExportForm progressForm = new ExportForm(this.ParentForm);
            progressForm.Show();
            try {
                while(!stop) {
                    Application.DoEvents();
                    Thread.Sleep(100);
                }
            } catch {
            }
            progressForm.Dispose();
        }
        void EndExport() {
            stop = true;
            thread.Join();
        }
        #endregion
	}
	public class TreeListRibbonMenuManager : RibbonMenuManager {
        TreeList currentTreeList = null;
        BarSubItem bsiViewOptions;
        public TreeListRibbonMenuManager(RibbonMainForm form)
            : base(form) {
            CreateOptionsMenu(form.ReservGroup1, form.Ribbon);
        }
        void CreateOptionsMenu(RibbonPageGroup ribbonPageGroup, RibbonControl ribbonControl) {
            ribbonPageGroup.Text = "Options";
            bsiViewOptions = new BarSubItem();
            bsiViewOptions.Caption = "View\n Options";
            MainFormHelper.SetBarButtonImage(bsiViewOptions, "View");
            ribbonControl.Items.Add(bsiViewOptions);
            ribbonPageGroup.ItemLinks.Add(bsiViewOptions);
        }
        public void RefreshOptionsMenu(TreeList treeList) {
            currentTreeList = treeList;
            ShowReservGroup1(treeList != null);
            LookAndFeelMenu.ClearOptionItems(Manager);
            LookAndFeelMenu.AddOptionsMenu(bsiViewOptions, ViewOptions, new ItemClickEventHandler(miViewOptions_Click), Manager);
        }
        private object ViewOptions {
            get {
                if(currentTreeList == null) return null;
                return currentTreeList.OptionsView;
            }
        }
        void miViewOptions_Click(object sender, ItemClickEventArgs e) {
            OptionBarItem item = e.Item as OptionBarItem;
            if(currentTreeList != null && item != null) {
                DevExpress.Utils.SetOptions.SetOptionValueByString(item.Caption, ViewOptions, item.Checked);
                LookAndFeelMenu.InitOptionsMenu(bsiViewOptions, ViewOptions);
            }
        }
    }
    public class DemosHelper {
        public static void ShowDescriptionForm(System.Drawing.Point location, string description, string caption) {
            XtraForm frm = new XtraForm() { FormBorderStyle = FormBorderStyle.FixedToolWindow, ShowInTaskbar = false, StartPosition = FormStartPosition.Manual, Text = caption };
            TextBox tb = new TextBox() { Multiline = true, Dock = DockStyle.Fill, ScrollBars = ScrollBars.Vertical, ReadOnly = true, Text = description };
            frm.Controls.Add(tb);
            frm.Location = DevExpress.Utils.ControlUtils.CalcLocation(location, location, frm.Size);
            frm.Shown += (sender, e) => { tb.DeselectAll(); };
            frm.ShowDialog();
        }
    }

}
