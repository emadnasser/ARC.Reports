using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for RowHeight.
    /// </summary>
    public partial class RowHeight : TutorialControl {
        public RowHeight() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\RowHeight.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.RowHeight.xml";
            InitNWindData();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #region Init
        private void RowHeight_Load(object sender, System.EventArgs e) {
            InitAutoHeight();
        }
        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return gridView1; } }
        private GridControl CurrentGrid { get { return gridControl1; } }
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Employees", connectionString);

            SetWaitDialogCaption(Properties.Resources.LoadingEmployees);
            oleDbDataAdapter.Fill(ds, "Employees");

            CurrentGrid.DataSource = ds.Tables["Employees"];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            SetWaitDialogCaption(Properties.Resources.LoadingTables);
            ds.ReadXml(dataFileName);

            CurrentGrid.DataSource = ds.Tables["Employees"];
        }
        private void InitAutoHeight() {
            if(CurrentGrid.MainView is GridView)
                cheAutoHeight.Checked = gridView1.OptionsView.RowAutoHeight;
            else
                cheAutoHeight.Checked = cardView1.OptionsBehavior.FieldAutoHeight;
            cheMemo.Checked = repositoryItemMemoEdit1.LinesCount == 0;
            chePicture.Checked = repositoryItemPictureEdit1.CustomHeight == 0;
            InitEnabledAutoHeight();
        }
        private void InitEnabledAutoHeight() {
            cheMemo.Enabled = chePicture.Enabled = cheAutoHeight.Checked;
        }
        #endregion
        #region Editing
        //<cheAutoHeight>
        private void chbAutoHeight_CheckedChanged(object sender, System.EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            if(CurrentGrid.MainView is GridView)
                gridView1.OptionsView.RowAutoHeight = ce.Checked;
            else
                cardView1.OptionsBehavior.FieldAutoHeight = ce.Checked;
            //<skip>
            InitEnabledAutoHeight();
            //</skip>
        }
        //</cheAutoHeight>
        //<cheMemo>
        private void chbMemo_CheckedChanged(object sender, System.EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            repositoryItemMemoEdit1.LinesCount = ce.Checked ? 0 : 1;
        }
        //</cheMemo>
        //<chePicture>
        private void chbPicture_CheckedChanged(object sender, System.EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            repositoryItemPictureEdit1.CustomHeight = ce.Checked ? 0 : 40;
            gridView1.TopRowIndex = 0;
        }
        //</chePicture>
        string ActiveViewCaption { get { return CurrentGrid.MainView == gridView1 ? Properties.Resources.GridView : Properties.Resources.CardView; } }
        string SwitchButtonCaption { get { return CurrentGrid.MainView == gridView1 ? Properties.Resources.ShowCardView : Properties.Resources.ShowGridView; } }

        //<sbSwitching>
        private void sbSwitching_Click(object sender, System.EventArgs e) {
            //<skip>
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            //</skip>
            if(CurrentGrid.MainView == cardView1)
                CurrentGrid.MainView = gridView1;
            else CurrentGrid.MainView = cardView1;
            //<skip>
            InitAutoHeight();
            CurrentGrid.Focus();
            CurrentGrid.MainView.LayoutChanged();
            Cursor.Current = currentCursor;
            RibbonMenuManager.AllowExport(CurrentGrid.MainView);
            OnSetCaption("");
            //</skip>
        }
        //</sbSwitching>
        protected override void OnSetCaption(string fCaption) {
            fCaption = ActiveViewCaption;
            sbSwitching.Text = SwitchButtonCaption;
            Caption.Text = string.Format("{0} ({1})", TutorialName, fCaption);
        }
        #endregion
    }
}
