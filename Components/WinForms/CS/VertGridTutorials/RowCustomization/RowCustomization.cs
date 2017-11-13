using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for RowCustomization.
    /// </summary>
    public partial class RowCustomization : TutorialControl {
        public RowCustomization() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void RowCustomization_Load(object sender, System.EventArgs e) {
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
            InitCustomize();
            Timer timer = new Timer();
            timer.Tick += new EventHandler(OnTick);
            timer.Interval = 200;
            timer.Start();
        }

        void OnTick(object sender, EventArgs e) {
            Timer timer = sender as Timer;
            timer.Stop();
			if(IsHandleCreated)
				DoCustomize(true);
        }

        private void InitCustomize() {
            for(int i = 0; i < 2; i++)
                vGridControl1.Rows[i].ChildRows[4].Visible = false;
        }

        private void vGridControl1_HideCustomizationForm(object sender, System.EventArgs e) {
            DoCustomize(false);
        }


        //<sbCustomize>
        bool showCustomization = false;
        private void sbCustomize_Click(object sender, System.EventArgs e) {
            DoCustomize(!showCustomization);
        }

        void DoCustomize(bool show) {
            showCustomization = show;
            if(showCustomization) {
                vGridControl1.RowsCustomization(sbCustomize.PointToScreen(new Point(0, sbCustomize.Bottom - sbCustomize.Top)));
                sbCustomize.Text = "Hide\r\nCustomization\r\nForm";
            }
            else {
                vGridControl1.DestroyCustomization();
                sbCustomize.Text = "Customize...";
            }
        }
        //</sbCustomize>
    }
}
