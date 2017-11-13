using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridVerticalHeaders.
    /// </summary>
    public partial class GridVerticalHeaders : TutorialControl {
        public GridVerticalHeaders() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void GridVerticalHeaders_Load(object sender, System.EventArgs e) {
            InitData();
            radioGroup1.SelectedIndex = 1;
        }

        private void InitData() {
            DevExpress.XtraGrid.Design.XViewsPrinting xv = new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1);
        }

        //<radioGroup1>
        bool vertical = false;
        bool diagonal = false;
        private void SetParameters(bool vertical, bool diagonal, int h) {
            this.vertical = vertical;
            this.diagonal = diagonal;
            gridView1.ColumnPanelRowHeight = h;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
            int i = (int)radioGroup1.EditValue;
            if(i == 0) SetParameters(false, false, -1);
            if(i == 1) SetParameters(true, false, 85);
            if(i == 2) SetParameters(false, true, 60);
        }
        //</radioGroup1>

        private Rectangle Transform(Graphics g, int degree, Rectangle r) {
            g.RotateTransform(degree);
            float cos = (float)Math.Round(Math.Cos(degree * (Math.PI / 180)), 2);
            float sin = (float)Math.Round(Math.Sin(degree * (Math.PI / 180)), 2);
            Rectangle r1 = r;
            r1.X = (int)(r.X * cos + r.Y * sin);
            r1.Y = (int)(r.X * (-sin) + r.Y * cos);
            r1.Offset(7, 0);
            return r1;
        }

        //<gridControl1>
        private void gridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e) {
            Rectangle r = e.Info.CaptionRect;
            e.Info.Caption = "";
            e.Painter.DrawObject(e.Info);
            if(e.Column != null) {
                System.Drawing.Drawing2D.GraphicsState state = e.Graphics.Save();
                StringFormat sf = new StringFormat();
                sf.Trimming = StringTrimming.EllipsisCharacter;
                sf.FormatFlags |= StringFormatFlags.NoWrap;
                if(vertical)
                    sf.FormatFlags |= StringFormatFlags.DirectionVertical;
                if(diagonal) r = Transform(e.Graphics, 30, r);
                e.Graphics.DrawString(e.Column.GetTextCaption(), e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), r, sf);
                e.Graphics.Restore(state);
            }
            e.Handled = true;
        }
        //</gridControl1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
