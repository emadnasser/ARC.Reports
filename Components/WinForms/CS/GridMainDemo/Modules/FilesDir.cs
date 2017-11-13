using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for FilesDir.
    /// </summary>
    public partial class FilesDir : TutorialControl {
        public FilesDir() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\FilesDir.cs;CS\\GridMainDemo\\Modules\\Directories.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.FilesDir.xml";
            SetWaitDialogCaption(Properties.Resources.ReadingFolders);
            InitData();
            CreateFormatConditions();
            InitAppearance();
            this.gridControl1.LevelTree.Nodes[1].RelationName = Properties.Resources.Files;
            this.gridControl1.LevelTree.Nodes[0].RelationName = Properties.Resources.Directories;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        protected override PaintView[] PaintViews {
            get {
                return new PaintView[] {
										   new PaintView(gridView1, "Pastel#3"), 
										   new PaintView(gridView2, "Pastel#3"),
										   new PaintView(cardView1, "Orange"),
				};
            }
        }
        #region Init
        private void InitData() {
            AddDirectoriesColumns(gridView1);
            AddDirectoriesColumns(gridView2);
            AddFilesColumns(cardView1);

            //<gridControl1>
            Directories directories = new Directories(new System.IO.DirectoryInfo(Application.StartupPath).Root.Name);
            gridControl1.DataSource = directories;
            //</gridControl1>
            if (gridView1.Columns.Count == 0) gridControl1.MainView.PopulateColumns();
        }
        private void InitAppearance() {
            gridControl1.ForceInitialize();
            gridView1.BestFitColumns();
        }
        protected override void OnSetCaption(string caption) {
            base.OnSetCaption("");
            GridRibbonMenuManager.RefreshOptionsMenu(gridControl1.DefaultView);
        }
        #endregion
        #region Create
        private void AddDirectoriesColumns(DevExpress.XtraGrid.Views.Base.ColumnView cv) {
            CreateGridColumn(cv, Properties.Resources.Name, "Name", 0);
            CreateGridColumn(cv, Properties.Resources.FullName, "FullName", 1);
            CreateGridColumn(cv, Properties.Resources.CreationTime, "CreationTime", 2);
            CreateGridColumn(cv, Properties.Resources.Attributes, "Attributes", 3);
            CreateGridColumn(cv, Properties.Resources.ChildDirCount, "ChildDirCount", 4);
            CreateGridColumn(cv, Properties.Resources.FilesCount, "FilesCount", 5);
        }

        private void AddFilesColumns(DevExpress.XtraGrid.Views.Base.ColumnView cv) {
            CreateGridColumn(cv, Properties.Resources.FileName, "Name", 0);
            CreateGridColumn(cv, Properties.Resources.Length, "Length", 1);
            CreateGridColumn(cv, Properties.Resources.CreationTime, "CreationTime", 2);
            CreateGridColumn(cv, Properties.Resources.LastWriteTime, "LastWriteTime", 3);
            CreateGridColumn(cv, Properties.Resources.LastAccessTime, "LastAccessTime", 4);
            CreateGridColumn(cv, Properties.Resources.FileAttributes, "Attributes", 5);
        }

        private DevExpress.XtraGrid.Columns.GridColumn CreateGridColumn(DevExpress.XtraGrid.Views.Base.ColumnView cv, string caption, string field, int visibleindex) {
            DevExpress.XtraGrid.Columns.GridColumn gc = cv.Columns.Add();
            gc.Caption = caption;
            gc.FieldName = field;
            gc.VisibleIndex = visibleindex;
            gc.OptionsColumn.AllowEdit = false;
            if (gc.VisibleIndex == 0)
                gc.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            if (field.IndexOf("Time") > 0) {
                gc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gc.DisplayFormat.FormatString = "g";
            }
            return gc;
        }
        private void CreateFormatConditions() {
            AppearanceDefault appDef1 = new AppearanceDefault(Color.OrangeRed, Color.Empty, new Font(AppearanceObject.DefaultFont, FontStyle.Bold | FontStyle.Italic));
            AppearanceDefault appDef2 = new AppearanceDefault(Color.White, Color.CornflowerBlue, Color.Empty, Color.SteelBlue, new Font(AppearanceObject.DefaultFont, FontStyle.Bold));
            StyleFormatCondition sfcFilesCount1 = new StyleFormatCondition(
                FormatConditionEnum.NotEqual, null, appDef1, 0, 0, gridView1.Columns["FilesCount"], false);
            StyleFormatCondition sfcFilesCount2 = new StyleFormatCondition(
                FormatConditionEnum.NotEqual, null, appDef1, 0, 0, gridView2.Columns["FilesCount"], false);
            StyleFormatCondition sfcDirCount1 = new StyleFormatCondition(
                FormatConditionEnum.NotEqual, null, appDef2, 0, 0, gridView1.Columns["ChildDirCount"], false);
            StyleFormatCondition sfcDirCount2 = new StyleFormatCondition(
                FormatConditionEnum.NotEqual, null, appDef2, 0, 0, gridView2.Columns["ChildDirCount"], false);
            gridView1.FormatConditions.AddRange(new StyleFormatCondition[] { sfcFilesCount1, sfcDirCount1 });
            gridView2.FormatConditions.AddRange(new StyleFormatCondition[] { sfcFilesCount2, sfcDirCount2 });
        }
        #endregion
        #region Grid events
        private void gridControl1_DefaultViewChanged(object sender, System.EventArgs e) {
            if (gridControl1.DefaultView is DevExpress.XtraGrid.Views.Grid.GridView)
                ((DevExpress.XtraGrid.Views.Grid.GridView)gridControl1.DefaultView).BestFitColumns();
            gridControl1.FocusedView = gridControl1.DefaultView;
            if (GridRibbonMenuManager != null)
                GridRibbonMenuManager.RefreshOptionsMenu(gridControl1.DefaultView);
        }
        private void gridControl1_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e) {
            gridControl1.FocusedView = e.View;
        }

        //<gridControl1>
        /*
         ~Use either CardView or GridView to display child records:
         */
        private void gridView2_MasterRowGetLevelDefaultView(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs e) {
            if (e.RelationIndex > 0)
                e.DefaultView = cardView1;
            else
                e.DefaultView = gridView2;
        }
        //</gridControl1>

        #endregion
    }
}
