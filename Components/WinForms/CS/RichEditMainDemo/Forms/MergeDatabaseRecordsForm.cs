using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

namespace DevExpress.XtraRichEdit.Demos.Forms {
    public partial class MergeDatabaseRecordsForm : MergeFieldsFormBase {
        public MergeDatabaseRecordsForm() {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e) {
            MergeRecords = GetMergeRecords();
            MergeDestination = (MergeDestination)this.rgMergeTo.SelectedIndex;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private MergeRecords GetMergeRecords() {
            return this.rgMergeRecords.SelectedIndex == 0 ? MergeRecords.Selected : MergeRecords.All;
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
