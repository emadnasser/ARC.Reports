using System;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraRichEdit.Demos.Forms {
    public partial class CustomizeMergeFieldsForm : DevExpress.XtraEditors.XtraForm {
        public CustomizeMergeFieldsForm(MergeFieldNameInfo[] mergeFieldsNames) {
            InitializeComponent();

            gridControl1.DataSource = mergeFieldsNames;

            RepositoryItemCheckEdit item = new RepositoryItemCheckEdit();
            gridControl1.RepositoryItems.Add(item);
            gridView1.Columns[0].ColumnEdit = item;
        }

        private void btnOk_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}


