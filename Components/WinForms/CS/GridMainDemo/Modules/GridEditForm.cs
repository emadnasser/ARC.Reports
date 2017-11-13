using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraGrid.Demos {
    public partial class GridEditForm : TutorialControl {
        RibbonPageGroup pgOptions = new RibbonPageGroup("Edit Form Options");
        public GridEditForm() {
            CreateWaitDialog();
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\GridEditForm.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.GridEditForm.xml";
            //<gridControl2>
            advBandedGridView1.OptionsEditForm.CustomEditFormLayout = new AdvancedEditForm();
            //</gridControl2>
            InitVehiclesData();
            CreateTimer();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            CreateRibbonItems();
        }
        protected override void SetVisibleCore(bool value) {
            base.SetVisibleCore(value);
            pgOptions.Visible = value;
        }
        void CreateRibbonItems() {
            pgOptions.ShowCaptionButton = false;
            pgOptions.AllowTextClipping = false;
            ParentFormMain.MainPage.Groups.Insert(3, pgOptions);
            BarButtonItem bItem = new BarButtonItem(ParentFormMain.Ribbon.Manager, "Options");
            bItem.Hint = pgOptions.Text;
            bItem.LargeGlyph = Properties.Resources.properties_32x32;
            bItem.ItemClick += new ItemClickEventHandler(OptionsItemClick);
            pgOptions.ItemLinks.Add(bItem);
        }

        GridView CurrentGridView {
            get {
                if(gridControl1.Visible) return gridView1;
                return advBandedGridView1;
            }
        }
        void OptionsItemClick(object sender, ItemClickEventArgs e) {
            using(EditFormOptions frm = new EditFormOptions(CurrentGridView, GridRibbonMenuManager.Manager)) {
                CurrentGridView.CloseEditForm();
                DialogResult res = frm.ShowDialog(this.FindForm());
                if((CurrentGridView.OptionsBehavior.EditingMode == GridEditingMode.EditFormInplace || 
                    CurrentGridView.OptionsBehavior.EditingMode == GridEditingMode.EditFormInplaceHideCurrentRow) && res == DialogResult.OK)
                    CurrentGridView.ShowEditForm();
            }
        }
        protected override void OnTick() {
            if(DemosInfo.CurrentModule == this) {
                //<gridControl1>
                /*
                 ~Show the EditForm at startup:
                 */
                gridView1.ShowEditForm();
                //</gridControl1>

                gridControl2.ForceInitialize();
                advBandedGridView1.FocusedRowHandle = 0;
            }
        }
        protected override void InitMDBData(string connectionString) {
            string tblModel = "Model", tblCategory = "Category", tblTrademark = "Trademark", 
                tblModelFilter = "ModelFilter", tblBodyStyle = "BodyStyle", tblTransmissionType = "TransmissionType";
            DataSet ds = new DataSet();

            FillTable(tblModel, null, connectionString, ds);
            FillTable(tblModelFilter, string.Format("SELECT * FROM {0} WHERE [Photo] Is Not Null", tblModel), connectionString, ds);
            FillTable(tblCategory, null, connectionString, ds);
            FillTable(tblTrademark, null, connectionString, ds);
            FillTable(tblBodyStyle, null, connectionString, ds);
            FillTable(tblTransmissionType, null, connectionString, ds);

            SetGridDataSource(tblModel, ds, gridControl1);
            SetGridDataSource(tblModelFilter, ds, gridControl2);
            
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblCategory];
            repositoryItemLookUpEdit1.DropDownRows = ds.Tables[tblCategory].Rows.Count;
            repositoryItemLookUpEdit2.DataSource = ds.Tables[tblBodyStyle];
            repositoryItemLookUpEdit2.DropDownRows = ds.Tables[tblBodyStyle].Rows.Count;
            repositoryItemGridLookUpEdit1.DataSource = ds.Tables[tblTrademark];
            repositoryItemGridLookUpEdit1.GetImageByValue += new DevExpress.XtraGrid.Demos.ImageByValueEventHandler(repositoryItemGridLookUpEdit1_GetImageByValue);

            ((AdvancedEditForm)advBandedGridView1.OptionsEditForm.CustomEditFormLayout).InitData(ds);
        }

        void FillTable(string table, string query, string connectionString, DataSet ds) {
            if(query == null) query = string.Format("SELECT * FROM {0}", table);
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter(query, connectionString);
            SetWaitDialogCaption(string.Format("Loading {0}...", table));
            oleDbDataAdapter.Fill(ds, table);
        }

        void SetGridDataSource(string table, DataSet ds, GridControl grid) {
            DataViewManager dvManager = new DataViewManager(ds);
            DataView dv = dvManager.CreateDataView(ds.Tables[table]);
            grid.DataMember = null;
            grid.DataSource = dv;
        }

        private void repositoryItemGridLookUpEdit1_GetImageByValue(object sender, ImageByValueEventArgs e) {
            DataHelper.LogoGridLookupGetImageByValue(sender, e);
        }

        //<gridControl1>
        /*
         ~Use the MemoEdit in-place editor for the Description column in the EditForm instead of the MemoExEdit dropdown editor:
         */
        private void gridView1_CustomRowCellEditForEditing(object sender, Views.Grid.CustomRowCellEditEventArgs e) {
            if(e.Column == colDescription) 
                e.RepositoryItem = repositoryItemMemoEdit1;
        }
        //</gridControl1>

    }
}
