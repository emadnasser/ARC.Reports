using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos {
    public class ViewOptionsChangedEventArgs : EventArgs {
        public ViewOptionsChangedEventArgs(string name, bool value) {
            this.Name = name;
            this.Value = value;
        }
        public string Name { get; set; }
        public bool Value { get; set; }
    } 
    public class PivotGridRibbonMenuManager : RibbonMenuManager {
        PivotGridControl currentPivotGrid = null;
        BarSubItem bsiViewOptions;

		public PivotGridControl CurrentPivotGrid { get { return currentPivotGrid; } }

        public event EventHandler<ViewOptionsChangedEventArgs> ViewOptionsChanged;
        public PivotGridRibbonMenuManager(RibbonMainForm form)
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
        public void RefreshOptionsMenu(PivotGridControl pivotGrid) {
            currentPivotGrid = pivotGrid;
            ShowReservGroup1(pivotGrid != null); 
            LookAndFeelMenu.ClearOptionItems(Manager);
            LookAndFeelMenu.AddOptionsMenu(bsiViewOptions, ViewOptions, new ItemClickEventHandler(miViewOptions_Click), Manager);
        }
        private object ViewOptions {
            get {
                if(currentPivotGrid == null) return null;
                return currentPivotGrid.OptionsView;
            }
        }
        void miViewOptions_Click(object sender, ItemClickEventArgs e) {
            OptionBarItem item = e.Item as OptionBarItem;
            if(currentPivotGrid != null && item != null) {
                if(currentPivotGrid.OptionsView.RowTotalsLocation == PivotRowTotalsLocation.Tree && item.Caption.Equals("ShowRowTotals"))
                    XtraMessageBox.Show("The ShowRowTotals option must be enabled when the 'Tree' row area mode is used.");
                else {
                    DevExpress.Utils.SetOptions.SetOptionValueByString(item.Caption, ViewOptions, item.Checked);
                    RaiseViewOptionsChanged(item.Caption, item.Checked);
                }
                LookAndFeelMenu.InitOptionsMenu(bsiViewOptions, ViewOptions);
            }
        }
        void RaiseViewOptionsChanged(string name, bool value) {
            if(ViewOptionsChanged != null)
                ViewOptionsChanged(this, new ViewOptionsChangedEventArgs(name, value));
        }
	}
	public class TutorialControl : TutorialControlBase {
		private Control fDescription = null;
        Color red, green, blue;
        Color DefaultBlue = Color.FromArgb(39, 63, 133),
            DefaultRed = Color.FromArgb(169, 7, 7),
            DefaultGreen = Color.FromArgb(42, 93, 1);
		static object imlCategory = null;
		static object imlHeaders = null;

		static string[] CategoryNames = new string[] {"Beverages", "Condiments", "Confections", "Dairy Products", "Grains/Cereals", "Meat/Poultry", "Produce", "Seafood"};
		public static int GetCategoryIndexByName(object name) {
			if(name != null)
				for(int i = 0; i < CategoryNames.Length; i++)
					if(CategoryNames[i] == name.ToString()) return i;
			return -1;
		}
        public static object CategoryImageList {
            get {
                if(imlCategory == null)
                    imlCategory = ImageHelper.CreateImageCollectionFromResourcesEx("DevExpress.XtraPivotGrid.Demos.Images.categories.bmp", typeof(TutorialControl).Assembly, new Size(16, 16), Color.Magenta);
                return imlCategory;
            }
        }
        public static object HeadersImageList {
            get {
                if(imlHeaders == null)
                    imlHeaders = ImageHelper.CreateImageCollectionFromResourcesEx("DevExpress.XtraPivotGrid.Demos.Images.headers.bmp", typeof(TutorialControl).Assembly, new Size(16, 16), Color.Magenta);
                return imlHeaders;
            }
        }

		public TutorialControl() {}

		protected override void SetControlManager(Control ctrl, BarManager manager) {
			DevExpress.XtraPivotGrid.PivotGridControl grid = ctrl as DevExpress.XtraPivotGrid.PivotGridControl;
			if(grid != null) grid.MenuManager = manager;
		}

		public Control Description {
			get { return fDescription; }
			set { fDescription = value; 
				OnSetDescription("");	
			}
		}

		protected virtual void OnSetDescription(string fDescription) {
			if(fDescription == string.Empty) return;
			Description.Text = string.Format(fDescription);
		}
        protected override void AllowExport() {
            EnabledPrintExportActions(true, ExportFormats.PDF | ExportFormats.HTML | ExportFormats.MHT | ExportFormats.XLS |
                        ExportFormats.RTF | ExportFormats.Text | ExportFormats.XLSX, false);
        }
        public override bool AllowPrintOptions { get { return ExportControl != null; } }
		public virtual PivotGridControl ExportControl { get { return null; }}
		public virtual PivotGridControl ViewOptionsControl { get { return null; }}
		public virtual bool ShowLookAndFeelMenu { get { return true; }}

        public Color Red {
            get {
                if(red.IsEmpty) {
                    if(LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin)
                        red = EditorsSkins.GetSkin(LookAndFeel).Colors.GetColor(EditorsSkins.SkinFilterControlGroupOperatorTextColor);
                    if(red.IsEmpty || red == Color.Black)
                        red = DefaultRed;
                }
                return red;
            }
        }

        public Color Blue {
            get {
                if(blue.IsEmpty) {
                    if(LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin)
                        blue = EditorsSkins.GetSkin(LookAndFeel).Colors.GetColor(EditorsSkins.SkinFilterControlFieldNameTextColor);
                    if(blue.IsEmpty || blue == Color.Black)
                        blue = DefaultBlue;
                }
                return blue;
            }
        }

        public Color Green {
            get {
                if(green.IsEmpty) {
                    if(LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin)
                        green = EditorsSkins.GetSkin(LookAndFeel).Colors.GetColor(EditorsSkins.SkinFilterControlOperatorTextColor);
                    if(green.IsEmpty || green == Color.Black)
                        green = DefaultGreen;
                }
                return green;
            }
        }

        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            red = Color.Empty;
            blue = Color.Empty;
            green = Color.Empty;
        }

        protected virtual bool HideCustFormWhenSwitchDemo {
            get { return true; }
        }
		protected override void DoHide() {
            if(HideCustFormWhenSwitchDemo)
                FindPivotGridAndHideCustForm(this);
		}
        void FindPivotGridAndHideCustForm(Control control) {
            if(control.Controls == null)
                return;
            foreach(Control ctrl in control.Controls) {
                FindPivotGridAndHideCustForm(ctrl);
                PivotGridControl pivot = ctrl as PivotGridControl;
                if(pivot == null)
                    continue;
                pivot.DestroyCustomization();
            }
		}

		DataView dvTutorial = null;
		protected DataView GetNWindData(string tableName) {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\nwind.mdb");
			if(DBFileName != "") {
				DataSet ds = new DataSet();
				string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
				System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tableName, con);
				SetWaitDialogCaption(string.Format("Loading {0}...", tableName));
				oleDbDataAdapter.Fill(ds, tableName);
				
				dvTutorial = ds.Tables[tableName].DefaultView;
				return dvTutorial;
			}
			return null;
		}

		public DataRowView GetDataRowByIndex(int index) {
			if(dvTutorial != null)
				return dvTutorial[index];
			return null;
		}

        protected void UpdateListBoxColor(BaseListBoxControl listBox) {
            if(listBox.Parent.BackColor != Color.Transparent)
                listBox.BackColor = listBox.Parent.BackColor;
            else
                listBox.Appearance.Options.UseBackColor = false;
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
			try {
            if(ext == "rtf") ExportControl.ExportToRtf(filename);
            if(ext == "pdf") ExportControl.ExportToPdf(filename);
            if(ext == "mht") ExportControl.ExportToMht(filename);
            if(ext == "html") ExportControl.ExportToHtml(filename);
            if(ext == "txt") ExportControl.ExportToText(filename);
            if(ext == "xls") ExportControl.ExportToXls(filename);
            if(ext == "xlsx") ExportControl.ExportToXlsx(filename);
			} finally {
            EndExport();
            Cursor.Current = currentCursor;
			}
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
            if(ExportControl != null) {
                if(RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                    ExportControl.ShowRibbonPrintPreview();
                else
                    ExportControl.ShowPrintPreview();
            }
        }
        void StartExport() {
            Thread.Sleep(400);
            if(stop)
                return;
            ExportForm progressForm = new ExportForm(this.FindForm());
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

	public class DemoFormatCondition {
		PivotGridStyleFormatCondition fCondition = null;
		public DemoFormatCondition(PivotGridStyleFormatCondition fCondition) {
			this.fCondition = fCondition;
		}
		public PivotGridStyleFormatCondition StyleCondition {
			get { return fCondition; }
		}
        public override string ToString() {
            if(StyleCondition == null) return "Empty condition";
            if(!Comparer.Equals(StyleCondition.Condition, FormatConditionEnum.None))
                if(StyleCondition.Condition == FormatConditionEnum.Between || StyleCondition.Condition == FormatConditionEnum.NotBetween) {
                    return string.Format("{0} {1:c}, {2:c}", StyleCondition.Condition, StyleCondition.Value1, StyleCondition.Value2);
                } else
                    return string.Format("{0} {1:c}", StyleCondition.Condition, StyleCondition.Value1);
            return string.Format("Condition Item - Index {0}", Index);
        }
		public int Index { get { return StyleCondition.PivotGrid.FormatConditions.IndexOf(StyleCondition); }}
	}
}
