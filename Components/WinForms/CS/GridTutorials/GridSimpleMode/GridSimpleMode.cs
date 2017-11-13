using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Card;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridSimpleMode.
    /// </summary>
    public partial class GridSimpleMode : TutorialControl {
        public GridSimpleMode() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        private ContactList cList;
        private void GridSimpleMode_Load(object sender, System.EventArgs e) {
            InitData();
            radioGroup1.SelectedIndex = 1;
        }

        private DevExpress.XtraGrid.Views.Base.ColumnView ColumnView {
            get { return gridControl1.MainView as DevExpress.XtraGrid.Views.Base.ColumnView; }
        }

        private DevExpress.XtraEditors.Repository.RepositoryItem RepositoryItemMemoEdit {
            get {
                if(ColumnView is DevExpress.XtraGrid.Views.Card.CardView)
                    return repositoryItemMemoEdit1;
                else return repositoryItemMemoExEdit1;
            }
        }

        //<radioGroup1>
        private void AddGridColumns() {
            ColumnView.Columns.Clear();
            AddGridColumn(ColumnView, "FirstName", "First Name");
            AddGridColumn(ColumnView, "LastName", "Last Name");
            AddGridColumn(ColumnView, "Company", "Company");
            //</radioGroup1>
            AddGridColumn(ColumnView, "Address", "Address", RepositoryItemMemoEdit);
            AddGridColumn(ColumnView, "PurchaseDate", "Purchase Date");
            AddGridColumn(ColumnView, "PaymentType", "Payment Type", repositoryItemImageComboBox1);
            AddGridColumn(ColumnView, "PaymentAmount", "Payment Amount", repositoryItemSpinEdit1, "c", DevExpress.Utils.FormatType.Numeric);
            AddGridColumn(ColumnView, "Customer", "Customer");
            //<radioGroup1>
            if(ColumnView is DevExpress.XtraGrid.Views.Grid.GridView)
                ((DevExpress.XtraGrid.Views.Grid.GridView)ColumnView).BestFitColumns();
            //Uncomment this line to create the column by default. In this case, you have to comment the lines above.
            //gridControl1.MainView.PopulateColumns();
        }
        //</radioGroup1>

        private void AddGridColumn(DevExpress.XtraGrid.Views.Base.ColumnView view, string fieldName, string caption) { AddGridColumn(view, fieldName, caption, null); }
        private void AddGridColumn(DevExpress.XtraGrid.Views.Base.ColumnView view, string fieldName, string caption, DevExpress.XtraEditors.Repository.RepositoryItem item) { AddGridColumn(view, fieldName, caption, item, "", DevExpress.Utils.FormatType.None); }
        private void AddGridColumn(DevExpress.XtraGrid.Views.Base.ColumnView view, string fieldName, string caption, DevExpress.XtraEditors.Repository.RepositoryItem item, string format, DevExpress.Utils.FormatType type) {
            DevExpress.XtraGrid.Columns.GridColumn column = view.Columns.AddField(fieldName);
            column.Caption = caption;
            column.ColumnEdit = item;
            column.DisplayFormat.FormatType = type;
            column.DisplayFormat.FormatString = format;
            column.VisibleIndex = view.VisibleColumns.Count;
        }


        private void InitData() {
            cList = ContactList.GetContacts();
            gridControl1.DataSource = cList;
            AddGridColumns();
        }

        //<radioGroup1>
        private void DoUpdateViewStyle(string viewName) {
            DevExpress.XtraGrid.Views.Base.BaseView oldView = gridControl1.MainView;
            gridControl1.MainView = gridControl1.CreateView(viewName);
            if(oldView != null) oldView.Dispose();
            AddGridColumns();
            if(viewName.IndexOf("Card") != -1)
                ((CardView)gridControl1.MainView).OptionsBehavior.FieldAutoHeight = true;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
            DoUpdateViewStyle(radioGroup1.EditValue.ToString());
        }
        //</radioGroup1>
    }
}
