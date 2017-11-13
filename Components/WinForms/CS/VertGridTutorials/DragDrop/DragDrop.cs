using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for DragDrop.
    /// </summary>
    public partial class DragDrop : TutorialControl {
        public DragDrop() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
        private void DragDrop_Load(object sender, System.EventArgs e) {
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
            checkBox1.Checked = vGridControl1.OptionsBehavior.DragRowHeaders;
        }

        //<vGridControl1>
        private void vGridControl1_ProcessDragRow(object sender, DevExpress.XtraVerticalGrid.Events.DragRowEventArgs e) {
            DevExpress.XtraEditors.ListBoxControl lb = listBox1;
            Point p = lb.PointToClient(e.ScreenLocation);
            if(lb.ClientRectangle.Contains(p)) {
                int ind = lb.IndexFromPoint(p);
                if(ind == -1)
                    e.Effect = RowDragEffect.MoveToEnd;
                else
                    e.Effect = RowDragEffect.InsertBefore;
            }
        }
        private string GetCellValue(DevExpress.XtraVerticalGrid.Rows.RowProperties p) {
            return vGridControl1.GetCellValue(p, vGridControl1.FocusedRecord).ToString();
        }
        private void vGridControl1_EndDragRow(object sender, DevExpress.XtraVerticalGrid.Events.EndDragRowEventArgs e) {
            DevExpress.XtraEditors.ListBoxControl lb = listBox1;
            Point p = lb.PointToClient(e.ScreenLocation);
            if(lb.ClientRectangle.Contains(p)) {
                string dragString = "";
                if(e.Row is DevExpress.XtraVerticalGrid.Rows.CategoryRow)
                    dragString = "Category: " + e.Row.Properties.Caption;
                else {
                    dragString = e.Row.Properties.Caption + " : " + GetCellValue(e.Row.Properties);
                    if(e.Row is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow)
                        dragString = e.Row.GetRowProperties(0).Caption + " / " + e.Row.GetRowProperties(1).Caption + " : " +
                            GetCellValue(e.Row.GetRowProperties(0)) + " / " + GetCellValue(e.Row.GetRowProperties(1));
                }
                int ind = lb.IndexFromPoint(p);
                if(ind == -1)
                    lb.Items.Add(dragString);
                else
                    lb.Items.Insert(ind, dragString);
            }
        }
        //</vGridControl1>

        //<checkBox1>
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.CheckEdit cb = sender as DevExpress.XtraEditors.CheckEdit;
            vGridControl1.OptionsBehavior.DragRowHeaders = cb.Checked;
        }
        //</checkBox1>
    }
}
