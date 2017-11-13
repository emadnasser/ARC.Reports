using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraNavBar.Demos {
    /// <summary>
    /// Summary description for CustomDraw.
    /// </summary>
    public partial class CustomDraw : TutorialControl {
        public CustomDraw() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        Font fontHeader = new Font("Verdana", 8, FontStyle.Bold);
        Font fontRow = new Font("Verdana", 8);

        //<checkBox6>
        private void navBarGroup3_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e) {
            if(!checkBox6.Checked) return;
            e.Height = fontHeader.Height * 4;
        }
        //</checkBox6>

        //<checkBox4>
        private void navBarControl1_CustomDrawGroupClientForeground(object sender, DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventArgs e) {
            if(!checkBox4.Checked) return;
            DevExpress.XtraNavBar.ViewInfo.NavGroupClientInfoArgs info = e.ObjectInfo as DevExpress.XtraNavBar.ViewInfo.NavGroupClientInfoArgs;
            if(info.Group.Equals(navBarGroup3)) {
                Rectangle r = e.RealBounds;
                r.Inflate(-10, -10);
                e.ObjectInfo.Graphics.DrawString("My Documents", fontHeader, SystemBrushes.WindowText, r);
                r.Y += fontHeader.Height;
                r.Height -= fontHeader.Height;
                e.ObjectInfo.Graphics.DrawString("System Folder", fontRow, SystemBrushes.WindowText, r);
                e.Handled = true;
            }
        }
        //</checkBox4>
        //<checkBox2>
        private void navBarControl1_CustomDrawGroupCaption(object sender, DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs e) {
            if(!checkBox2.Checked) return;
            if(e.ObjectInfo.State != DevExpress.Utils.Drawing.ObjectState.Normal) {
                e.Image = imageList1.Images[5];
                e.Caption = "<" + e.Caption + ">";
            }
            if(e.ObjectInfo.State == DevExpress.Utils.Drawing.ObjectState.Pressed) {
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
            }
        }
        //</checkBox2>

        //<checkBox5>
        private void navBarControl1_CustomDrawLink(object sender, DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs e) {
            if(!checkBox5.Checked) return;
            if(e.ObjectInfo.State != DevExpress.Utils.Drawing.ObjectState.Normal) {
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                Rectangle r = ((DevExpress.XtraNavBar.ViewInfo.NavLinkInfoArgs)(((DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventArgs)(e)).ObjectInfo)).CaptionRectangle;
                r.Width += 20;
                ((DevExpress.XtraNavBar.ViewInfo.NavLinkInfoArgs)(((DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventArgs)(e)).ObjectInfo)).CaptionRectangle = r;
            }
        }
        //</checkBox5>
        //<checkBox3>
        private void navBarControl1_CustomDrawGroupClientBackground(object sender, DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventArgs e) {
            if(!checkBox3.Checked) return;
            DevExpress.XtraNavBar.ViewInfo.NavGroupClientInfoArgs info = e.ObjectInfo as DevExpress.XtraNavBar.ViewInfo.NavGroupClientInfoArgs;
            if(info.Group.Equals(navBarGroup3)) {
                e.Appearance.ForeColor = Color.Black;
                e.Appearance.BackColor = Color.FromArgb(192, 255, 192);
                e.Appearance.BackColor2 = Color.FromArgb(0, 192, 0);
            }
        }
        //</checkBox3>
        //<checkBox1>
        private void navBarControl1_CustomDrawBackground(object sender, DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventArgs e) {
            if(checkBox1.Checked) {
                e.Appearance.ForeColor = Color.Black;
                e.Appearance.BackColor = Color.Navy;
                e.Appearance.BackColor2 = Color.FromArgb(192, 192, 255);
            }
            else
                e.Appearance.Reset();
        }
        //</checkBox1>

        private void checkBox_CheckedChanged(object sender, System.EventArgs e) {
            navBarControl1.LayoutChanged();
        }
    }
}
