using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraNavBar.Demos {
	/// <summary>
	/// Summary description for CustomizableDistances.
	/// </summary>
	public partial class CustomizableDistances : TutorialControl {
		public CustomizableDistances() {
			InitializeComponent();
            SubscribeEvents();
		}
        void SubscribeEvents() {
            distanceChanger1.ValueChanged += distanceChanger1_ValueChanged;
            distanceChanger2.ValueChanged += distanceChanger2_ValueChanged;
            distanceChanger3.ValueChanged += distanceChanger3_ValueChanged;
        }

		private void CustomizableDistances_Load(object sender, System.EventArgs e) {
			pnlHint.Caption = "Customizable Distances Between Groups and Links.\r\n  If standard intervals between groups and links don't suit your application's needs, you can use one of the following settings that are offered by the XtraNavBar:\r\n  ExplorerBarGroupInterval - sets the distance between individual groups when the explorer bar view is used;\r\n  LinkInterval - specifies the distance between links;\r\n  ExplorerBarGroupOuterIndent - sets the distance between the control's edges and groups provided that an explorer bar view is applied.";
			distanceChanger1.Value = navBarControl1.ExplorerBarGroupInterval;
			distanceChanger2.Value = navBarControl1.ExplorerBarGroupOuterIndent;
			distanceChanger3.Value = navBarControl1.LinkInterval;
		}

        //<distanceChanger1>
		private void distanceChanger1_ValueChanged(object sender, System.EventArgs e) {
			navBarControl1.ExplorerBarGroupInterval = distanceChanger1.StatusEnabled ? distanceChanger1.Value : -1;
		}
        //</distanceChanger1>

        //<distanceChanger2>
		private void distanceChanger2_ValueChanged(object sender, System.EventArgs e) {
			navBarControl1.ExplorerBarGroupOuterIndent = distanceChanger2.StatusEnabled ? distanceChanger2.Value : -1;
		}
        //</distanceChanger2>

        //<distanceChanger3>
		private void distanceChanger3_ValueChanged(object sender, System.EventArgs e) {
			navBarControl1.LinkInterval = distanceChanger3.StatusEnabled ? distanceChanger3.Value : -1;		
		}
        //</distanceChanger3>
	}
}
