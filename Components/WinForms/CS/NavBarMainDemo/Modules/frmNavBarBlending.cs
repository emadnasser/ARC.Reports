using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;

namespace DevExpress.XtraNavBar.Demos {
	public partial class frmNavBarBlending : TutorialControl {
		public frmNavBarBlending() {
			InitializeComponent();
			ctrlAlphaBlending1.StyleInit(navBarControl1.Appearance.Background, "NavBar Background", navBarControl1);
			ctrlAlphaBlending2.StyleInit(navBarGroup1.AppearanceBackground, "'My Documents' Group Background", navBarGroup1);
			ctrlAlphaBlending3.StyleInit(navBarGroup2.AppearanceBackground, "'Other Places' Group Background", navBarGroup2);
			ctrlAlphaBlending4.StyleInit(navBarControl1.Appearance.GroupBackground, "'Details' Group Background", navBarGroup3);
		}

        Font fontHeader = new Font("Verdana", 8, FontStyle.Bold);
        Font fontRow = new Font("Verdana", 8);
		private void navBarGroup3_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e) {
			e.Height = fontHeader.Height * 4;
		}

		private void navBarControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
			NavBarHitInfo hi = navBarControl1.CalcHitInfo(new Point(e.X, e.Y));
			if(hi.InGroupCaption && hi.Group.Caption == "Details")
				navBarGroup3.LargeImageIndex = 3;
			else navBarGroup3.LargeImageIndex = 2;
		}

		private void navBarControl1_MouseLeave(object sender, System.EventArgs e) {
			navBarGroup3.LargeImageIndex = 2;
		}

		
		
		private void navBarControl1_CustomDrawGroupClientForeground(object sender, DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventArgs e) {
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
	}
}
