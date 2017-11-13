using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for Resizing.
    /// </summary>
    public partial class Resizing : TutorialControl {
        public Resizing() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void Resizing_Load(object sender, System.EventArgs e) {
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
            SetValues();
        }

        private void SetValues() {
            checkBox1.Checked = vGridControl1.OptionsBehavior.ResizeRowHeaders;
            checkBox2.Checked = vGridControl1.OptionsBehavior.ResizeRowValues;
            checkBox3.Checked = vGridControl1.OptionsBehavior.ResizeHeaderPanel;
            spinEdit1.Value = vGridControl1.RecordWidth;
            spinEdit2.Value = vGridControl1.RowHeaderWidth;
            spinEdit3.Value = vGridControl1.RecordsInterval;
        }

        //<checkBox1>
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.CheckEdit cb = sender as DevExpress.XtraEditors.CheckEdit;
            vGridControl1.OptionsBehavior.ResizeRowHeaders = cb.Checked;
        }
        //</checkBox1>

        //<checkBox2>
        private void checkBox2_CheckedChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.CheckEdit cb = sender as DevExpress.XtraEditors.CheckEdit;
            vGridControl1.OptionsBehavior.ResizeRowValues = cb.Checked;
        }
        //</checkBox2>

        //<checkBox3>
        private void checkBox3_CheckedChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.CheckEdit cb = sender as DevExpress.XtraEditors.CheckEdit;
            vGridControl1.OptionsBehavior.ResizeHeaderPanel = cb.Checked;
        }
        //</checkBox3>

        //<spinEdit1>
        private void spinEdit1_ValueChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.SpinEdit n = sender as DevExpress.XtraEditors.SpinEdit;
            vGridControl1.RecordWidth = (int)n.Value;
        }
        //</spinEdit1>

        //<spinEdit2>
        private void spinEdit2_ValueChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.SpinEdit n = sender as DevExpress.XtraEditors.SpinEdit;
            vGridControl1.RowHeaderWidth = (int)n.Value;
        }
        //</spinEdit2>

        //<spinEdit3>
        private void spinEdit3_ValueChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.SpinEdit n = sender as DevExpress.XtraEditors.SpinEdit;
            vGridControl1.RecordsInterval = (int)n.Value;
        }
        //</spinEdit3>

        private void vGridControl1_RowHeaderWidthChanged(object sender, System.EventArgs e) {
            SetValues();
        }

        private void vGridControl1_RecordWidthChanged(object sender, System.EventArgs e) {
            SetValues();
        }
    }
}
