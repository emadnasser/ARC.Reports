using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraSplashScreen;

namespace DevExpress.XtraBars.Demos.DockingDemo {
    public partial class frmMain : DevExpress.XtraEditors.XtraForm {
        List<Stream> fileStreams;
        public frmMain() {
            InitializeComponent();
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DockingDemo.Resources.AppIcon.ico", typeof(frmMain).Assembly);
        }
        void frmMain_Load(object sender, System.EventArgs e) {
            this.fileStreams = Program.CreateResourceStreams();
            ucSolutionExplorer.InitTreeView(treeView1);
            SkinHelper.InitSkinPopupMenu(iPaintStyle);
            BeginInvoke(new MethodInvoker(InitDemo));
        }
        void barManager1_Merge(object sender, BarManagerMergeEventArgs e) {
            barManager.Bars["Edit"].Merge(e.ChildManager.Bars["Edit"]);
        }
        void barManager1_UnMerge(object sender, BarManagerMergeEventArgs e) {
            barManager.Bars["Edit"].UnMerge();
        }
        void InitDemo() {
            AddNewDocument("File.cs");
            DevExpress.Demos.ClassViewer.AddClassInfo(treeView1, this.GetType(), new object[] { this, new ucSolutionExplorer() });
            SplashScreenManager.HideImage(1000, this);
        }
        int fileIndex = 0;
        void AddNewDocument(string fileName) {
            fileStreams[fileIndex].Seek(0, SeekOrigin.Begin);
            AddNewDocument(fileName, fileStreams[fileIndex]);
            fileIndex = (fileIndex++) % 3;
        }
        void AddNewDocument(string fileName, Stream content) {
            tabbedView.BeginUpdate();
            ucCodeEditor control = new ucCodeEditor();
            control.Name = fileName;
            control.Text = fileName;
            BaseDocument document = tabbedView.AddDocument(control);
            document.Image = fileTypeImages.Images[10];
            document.Footer = Directory.GetCurrentDirectory();
            control.LoadCode(content);
            tabbedView.EndUpdate();
            tabbedView.Controller.Activate(document);
        }
        void repositoryItemComboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter && eFind.EditValue != null)
                repositoryItemComboBox1.Items.Add(eFind.EditValue.ToString());
        }
        int projectIndex = 0;
        void iNewItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AddNewDocument(string.Format("File{0}.cs", ++projectIndex));
        }
        void iAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            BarManager.About();
        }
        void iSolutionExplorer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            dockPanel1.Show();
        }
        void iProperties_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            dockPanel2.Show();
        }
        void iTaskList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            dockPanel3.Show();
        }
        void iFindResults_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            dockPanel4.Show();
        }
        void iOutput_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            dockPanel5.Show();
        }
        void iToolbox_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            dockPanel6.Show();
        }
        void solutionExplorer_PropertiesItemClick(object sender, System.EventArgs e) {
            dockPanel2.Show();
        }
        void solutionExplorer_TreeViewItemClick(object sender, System.EventArgs e) {
            DevExpress.XtraTreeList.TreeList treeView = sender as DevExpress.XtraTreeList.TreeList;
            string fileName = treeView.FocusedNode.GetDisplayText(0).Replace(".cs", string.Empty);
            foreach(BaseDocument document in tabbedView.Documents) {
                if(document.Caption == (fileName + ".cs")) {
                    tabbedView.Controller.Activate(document);
                    return;
                }
            }
            using(Stream stream = Program.GetDocumentStream(fileName)) {
                if(stream != null)
                    AddNewDocument(fileName + ".cs", stream);
            }
        }
        void iSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            using(SaveFileDialog dlg = new SaveFileDialog()) {
                dlg.Filter = "XML files (*.xml)|*.xml";
                dlg.Title = "Save Layout";
                if(dlg.ShowDialog() == DialogResult.OK) {
                    Refresh(true);
                    barManager.SaveToXml(dlg.FileName);
                    Refresh(false);
                }
            }
        }
        void iLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            using(OpenFileDialog dlg = new OpenFileDialog()) {
                dlg.Filter = "XML files (*.xml)|*.xml|All files|*.*";
                dlg.Title = "Restore Layout";
                if(dlg.ShowDialog() == DialogResult.OK) {
                    Refresh(true);
                    try {
                        barManager.RestoreFromXml(dlg.FileName);
                        SkinHelper.InitSkinPopupMenu(iPaintStyle);
                    }
                    catch { }
                    Refresh(false);
                }
            }
        }
        Cursor currentCursor;
        void Refresh(bool isWait) {
            if(isWait) {
                currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
            }
            else Cursor.Current = currentCursor;
            this.Refresh();
        }
        void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.Close();
        }
    }
}
