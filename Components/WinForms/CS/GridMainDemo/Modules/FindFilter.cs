using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.XtraGrid.Columns;
using System.Collections;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraGrid.Demos {
    public partial class FindFilter : TutorialControl {
        public FindFilter() {
            CreateWaitDialog();
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\FindFilter.cs;CS\\GridMainDemo\\Modules\\ucFindOptions.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.FindFilter.xml";
            InitNWindData();
            ucFindOptions1.InitData(gridView1, GetColumn(gridView1.VisibleColumns));
        }

        List<ImageComboBoxItem> GetColumn(DevExpress.XtraGrid.Columns.GridColumnReadOnlyCollection gridColumnReadOnlyCollection) {
            List<ImageComboBoxItem> ret = new List<ImageComboBoxItem>();
            ret.Add(new ImageComboBoxItem("*", "*"));
            for(int i = 0; i < gridColumnReadOnlyCollection.Count; i++) {
                string columns = gridColumnReadOnlyCollection[i].GetCaption();
                string fields = gridColumnReadOnlyCollection[i].FieldName;
                for(int j = i; j < gridColumnReadOnlyCollection.Count; j++) {
                    if(j != i) {
                        columns += string.Format(";{0}", gridColumnReadOnlyCollection[j].GetCaption());
                        fields += string.Format(";{0}", gridColumnReadOnlyCollection[j].FieldName);
                    }
                    ret.Add(new ImageComboBoxItem(columns, fields, -1));
                }
            }
            return ret;
        }
        protected override void InitMDBData(string connectionString) {
            DataSet dataSet = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDBAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Customers", connectionString);

            SetWaitDialogCaption(Properties.Resources.LoadingCustomers);
            oleDBAdapter.Fill(dataSet, "Customers");
            gridControl1.DataSource = dataSet.Tables["Customers"];
        }

        private void gridView1_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e) {
            e.FilterControl.MaxOperandsCount = 5;
        }
    }
}
