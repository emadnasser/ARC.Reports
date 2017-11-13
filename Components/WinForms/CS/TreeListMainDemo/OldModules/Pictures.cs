using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;

namespace DevExpress.XtraTreeList.Demos {
    public partial class TreeListPictures : TutorialControl {
        public override TreeList ViewOptionsControl { get { return treeList1; } }
        public override TreeList ExportControl { get { return treeList1; } }
        protected override string BarName { get { return "Pictures"; } }
        protected override BarManager Manager { get { return barManager1; } }
        protected override void InitBarInfo() {
            this.BarInfos.Add(new BarInfo("Print Preview", new ItemClickEventHandler(PrintPreviewClick), imageCollection1.Images[0], false, false, false));
            this.BarInfos.Add(new BarInfo("Print Designer", new ItemClickEventHandler(PrintDesignerClick), imageCollection1.Images[1], false, false, false));
        }

        public TreeListPictures() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\TreeListMainDemo\\Modules\\Pictures.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraTreeList.Demos.CodeInfo.Pictures.xml";
            InitData();
            InitHeaderPanelColor();
        }

        protected override void OnSwitchStyle() {
            InitHeaderPanelColor();
        }

        //<treeList1>
        void PrintPreviewClick(object sender, ItemClickEventArgs e) {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            treeList1.ShowPrintPreview();
            Cursor.Current = currentCursor;
        }

        void PrintDesignerClick(object sender, ItemClickEventArgs e) {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            DevExpress.XtraEditors.XtraForm frm = new DevExpress.XtraEditors.XtraForm();
            frm.Text = "Print Designer";
            DevExpress.XtraTreeList.Frames.TreeListPrinting print = new DevExpress.XtraTreeList.Frames.TreeListPrinting();
            print.InitFrame(treeList1, "PrintingReport management", (Bitmap)imageCollection1.Images[0]);
            print.Dock = DockStyle.Fill;
            frm.Controls.Add(print);
            frm.Size = print.UserControlSize;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            Cursor.Current = currentCursor;
        }
        //</treeList1>

        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\BioLife.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                treeList1.DataSource = dataSet.Tables[0].DefaultView;
            }
        }

        void InitHeaderPanelColor() {
            bool isDefault = UserLookAndFeel.Default.UseWindowsXPTheme || UserLookAndFeel.Default.Style == LookAndFeelStyle.Skin || UserLookAndFeel.Default.Style == LookAndFeelStyle.Office2003;
            treeList1.Appearance.HeaderPanel.ForeColor = isDefault ? /*SystemColors.WindowText*/Color.Empty : Color.White;
        }
    }
}
