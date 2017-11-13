using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTab;
using DevExpress.XtraEditors;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridEditorsExternalRepository.
    /// </summary>
    public partial class GridEditorsExternalRepository : TutorialControl {
        public GridEditorsExternalRepository() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        private string fieldName = "ModelTrademark";


        #region Init
        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Cars.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                gridControl1.DataSource = dataSet.Tables[0].DefaultView;
            }
        }

        private void InitViewLayout() {
            string LayoutFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Layouts\\cars_AdvBandedView.xml");
            if(LayoutFileName != "") {
                advBandedGridView1.RestoreLayoutFromXml(LayoutFileName, null);
                InitEditors();
            }
        }
        #endregion
        private void GridEditorsExternalRepository_Load(object sender, System.EventArgs e) {
            InitData();
            InitViewLayout();
            InitTabEditors();
        }
        //<gridControl1>
        private void InitEditors() {
            RepositoryItemPictureEdit itemPictureEdit = new RepositoryItemPictureEdit();
            RepositoryItemRadioGroup itemRadioGroup = new RepositoryItemRadioGroup();
            RepositoryItemSpinEdit itemSpinEdit = new RepositoryItemSpinEdit();
            RepositoryItemCalcEdit itemCalcEdit = new RepositoryItemCalcEdit();
            //</gridControl1>
            RepositoryItemImageComboBox itemImageComboBox = new RepositoryItemImageComboBox();
            RepositoryItemTextEdit itemTextEdit = new RepositoryItemTextEdit();
            RepositoryItemCheckEdit itemCheckEdit = new RepositoryItemCheckEdit();
            RepositoryItemDateEdit itemDateEdit = new RepositoryItemDateEdit();
            itemSpinEdit.IsFloatValue = false;
            itemPictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            itemImageComboBox.Items.AddRange(new object[] {
															  new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sports", "SPORTS", 0),
															  new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Saloon", "SALOON", 1),
															  new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Truck", "TRUCK", 2)});
            itemImageComboBox.SmallImages = imageList1;
            itemRadioGroup.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
																								   new DevExpress.XtraEditors.Controls.RadioGroupItem("Yes", "Yes"),
																								   new DevExpress.XtraEditors.Controls.RadioGroupItem("No", "No")});
            //<gridControl1>
            //Assign an external editor repository to the grid. 
            this.gridControl1.ExternalRepository = persistentRepository1;
            this.persistentRepository1.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
																												 itemPictureEdit, itemRadioGroup, itemSpinEdit, itemCalcEdit, itemImageComboBox, itemTextEdit, itemCheckEdit, itemDateEdit});
            advBandedGridView1.Columns["Trademark"].ColumnEdit = itemTextEdit;
            advBandedGridView1.Columns["Model"].ColumnEdit = itemTextEdit;
            advBandedGridView1.Columns["Category"].ColumnEdit = itemImageComboBox;
            //</gridControl1>
            advBandedGridView1.Columns["Price"].ColumnEdit = itemCalcEdit;
            advBandedGridView1.Columns["Delivery Date"].ColumnEdit = itemDateEdit;
            advBandedGridView1.Columns["Is In Stock"].ColumnEdit = itemCheckEdit;
            advBandedGridView1.Columns["Picture"].ColumnEdit = itemPictureEdit;
            advBandedGridView1.Columns["HP"].ColumnEdit = itemTextEdit;
            advBandedGridView1.Columns["Cyl"].ColumnEdit = itemSpinEdit;
            advBandedGridView1.Columns["Liter"].ColumnEdit = itemTextEdit;
            advBandedGridView1.Columns["Transmiss Speed Count"].ColumnEdit = itemSpinEdit;
            advBandedGridView1.Columns["Transmiss Automatic"].ColumnEdit = itemRadioGroup;
            //<gridControl1>
        }
        //</gridControl1>
        #region Create Tabs
        private void CreateTabPage(DevExpress.XtraGrid.Columns.GridColumn col) {
            CreateTabPage(col.GetTextCaption(), col.ColumnEdit, null);
        }
        private void CreateTabPage(string caption, object obj, object[] objs) {
            XtraTabPage page = new XtraTabPage();
            page.Text = caption;
            XtraPropertyGrid pg = new XtraPropertyGrid();
            if(obj != null)
                pg.PropertyGrid.SelectedObject = obj;
            else pg.PropertyGrid.SelectedObjects = objs;
            pg.Dock = DockStyle.Fill;
            page.Controls.Add(pg);
            xtraTabControl1.TabPages.Add(page);
        }
        private void InitTabEditors() {
            ArrayList objs = new ArrayList();
            foreach(DevExpress.XtraGrid.Columns.GridColumn col in advBandedGridView1.Columns)
                if(col.VisibleIndex != -1) {
                    CreateTabPage(col);
                    objs.Add(col.ColumnEdit);
                }
            CreateTabPage("All editors", null, objs.ToArray());
        }
        #endregion
        #region FocusedColumnChanged
        private void advBandedGridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e) {
            foreach(XtraTabPage page in xtraTabControl1.TabPages)
                if(e.FocusedColumn != null)
                    if(page.Text == e.FocusedColumn.GetTextCaption()) {
                        xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.IndexOf(page);
                        gridControl1.Focus();
                        break;
                    }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            foreach(DevExpress.XtraGrid.Columns.GridColumn col in advBandedGridView1.Columns)
                if(col.VisibleIndex != -1)
                    if(col.GetTextCaption() == xtraTabControl1.SelectedTabPage.Text) {
                        advBandedGridView1.FocusedColumn = col;
                        break;
                    }
        }
        #endregion

        private void advBandedGridView1_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e) {
            if(fieldName.IndexOf(advBandedGridView1.FocusedColumn.FieldName) >= 0) e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void advBandedGridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e) {
            if(fieldName.IndexOf(advBandedGridView1.FocusedColumn.FieldName) >= 0)
                if(XtraMessageBox.Show("Do you really want to modify the '" + advBandedGridView1.FocusedColumn.FieldName + "' value?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Valid = false;
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
