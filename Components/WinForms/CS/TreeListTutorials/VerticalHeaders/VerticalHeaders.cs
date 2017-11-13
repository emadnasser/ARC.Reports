using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for VerticalHeaders.
    /// </summary>
    public partial class VerticalHeaders : TutorialControl {
        public VerticalHeaders() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitData();
            radioButton2.Checked = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
        bool vertical = false;
        bool diagonal = false;

        private void InitData() {
            DevExpress.XtraTreeList.Design.XViews xv = new DevExpress.XtraTreeList.Design.XViews(treeList1);
        }

        //<treeList1>
        private void treeList1_CustomDrawColumnHeader(object sender, DevExpress.XtraTreeList.CustomDrawColumnHeaderEventArgs e) {
            Rectangle r = e.CaptionRect;
            e.Caption = "";
            e.Painter.DrawObject(e.ObjectArgs);
            if(e.Column != null) {
                System.Drawing.Drawing2D.GraphicsState state = e.Graphics.Save();
                StringFormat sf = new StringFormat();
                sf.Trimming = StringTrimming.EllipsisCharacter;
                sf.FormatFlags |= StringFormatFlags.NoWrap;
                if(vertical)
                    sf.FormatFlags |= StringFormatFlags.DirectionVertical;
                if(diagonal) r = Transform(e.Graphics, 30, r);
                e.Graphics.DrawString(e.Column.GetCaption(), e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), r, sf);
                e.Graphics.Restore(state);
            }
            e.Handled = true;
        }
        //</treeList1>

        private Rectangle Transform(Graphics g, int degree, Rectangle r) {
            g.RotateTransform(degree);
            float cos = (float)Math.Round(Math.Cos(degree * (Math.PI / 180)), 2);
            float sin = (float)Math.Round(Math.Sin(degree * (Math.PI / 180)), 2);
            Rectangle r1 = r;
            r1.X = (int)(r.X * cos + r.Y * sin);
            r1.Y = (int)(r.X * (-sin) + r.Y * cos);
            return r1;
        }


        private void SetParameters(object sender, bool vertical, bool diagonal, int h) {
            RadioButton rb = sender as RadioButton;
            if(rb.Checked) {
                this.vertical = vertical;
                this.diagonal = diagonal;
                treeList1.ColumnPanelRowHeight = h;
            }
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e) {
            SetParameters(sender, false, false, -1);
        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e) {
            SetParameters(sender, true, false, 70);
        }

        private void radioButton3_CheckedChanged(object sender, System.EventArgs e) {
            SetParameters(sender, false, true, 50);
        }
    }
}
