using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for HitInfo.
    /// </summary>
    public partial class HitInfo : TutorialControl {
        public HitInfo() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
        private void HitInfo_Load(object sender, System.EventArgs e) {
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
        }

        //<vGridControl1>
        private void vGridControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            ShowHitInfo(vGridControl1.CalcHitInfo(new Point(e.X, e.Y)));
        }

        private void ShowHitInfo(DevExpress.XtraVerticalGrid.VGridHitInfo hi) {
            lbHitTest.Text = hi.HitInfoType.ToString();
            if(hi.Row == null)
                lbRow.Text = "No row";
            else {
                if(hi.Row is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow) {
                    if(hi.CellIndex != -1)
                        lbRow.Text = hi.Row.GetRowProperties(hi.CellIndex).Caption;
                }
                else
                    lbRow.Text = hi.Row.Properties.Caption;
            }
            if(hi.HitInfoType == DevExpress.XtraVerticalGrid.HitInfoTypeEnum.ValueCell) {
                if(hi.Row is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow)
                    lbCellValue.Text = vGridControl1.GetCellValue(hi.Row as DevExpress.XtraVerticalGrid.Rows.MultiEditorRow, hi.RecordIndex, hi.CellIndex).ToString();
                else
                    lbCellValue.Text = vGridControl1.GetCellValue(hi.Row, hi.RecordIndex).ToString();
            }
            else
                lbCellValue.Text = " ";
        }
        //</vGridControl1>
    }
}
