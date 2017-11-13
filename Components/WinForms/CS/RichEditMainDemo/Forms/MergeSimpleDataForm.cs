using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

namespace DevExpress.XtraRichEdit.Demos.Forms {
    public partial class MergeSimpleDataForm : MergeFieldsFormBase {
        int startIndex = 0;
        int endIndex = -1;

        public MergeSimpleDataForm() {
            InitializeComponent();
        }

        public int StartIndex { get { return Math.Min(startIndex, endIndex); } }
        public int EndIndex { get { return Math.Max(startIndex, endIndex); } }

        MergeRecords GetMergeRecords() {
            switch(this.rgMergeRecords.SelectedIndex){
                case 0:
                    return MergeRecords.All;                    
                case 1:
                    return MergeRecords.Current;                    
                case 2:
                    return MergeRecords.FromInterval;
                default:
                    return MergeRecords.All;
                    
            }
        }        
        private void btnOk_Click(object sender, EventArgs e) {
            MergeDestination = (MergeDestination)this.rgMergeTo.SelectedIndex;
            MergeRecords = GetMergeRecords();
            if (!Int32.TryParse(this.txtFrom.Text, out this.startIndex))
                this.startIndex = 0;
            if (!Int32.TryParse(this.txtTo.Text, out this.endIndex))
                this.endIndex = -1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void rgMergeRecords_SelectedIndexChanged(object sender, EventArgs e) {
            bool isIntervalSelected = rgMergeRecords.SelectedIndex == 2;
            txtFrom.Enabled = isIntervalSelected;
            txtTo.Enabled = isIntervalSelected;
        }        
    }
}
