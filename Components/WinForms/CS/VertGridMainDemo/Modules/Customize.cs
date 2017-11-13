using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace DevExpress.XtraVerticalGrid.Demos {
    public partial class Customize : DevExpress.XtraVerticalGrid.Demos.PropertiesBase {
        public Customize() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\VertGridMainDemo\\Modules\\Customize.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraVerticalGrid.Demos.CodeInfo.Customize.xml";
            HideRows();
            timer = new Timer();
            timer.Interval = 200;
            timer.Tick += new EventHandler(Timer_Tick);
            // TODO: Add any initialization after the InitializeComponent call
        }

        Timer timer = null;
        bool fShowCustomization = false;

        void Timer_Tick(object sender, EventArgs e) {
            timer.Stop();
            ShowCustomization = true;
        }
        //<chCustomize>
        void ShowCustomizationForm() {
            CurrentGrid.RowsCustomization(chCustomize.PointToScreen(new Point(-chCustomize.Left, chCustomize.Bottom - chCustomize.Top)));
        }

        private void chCustomize_Click(object sender, System.EventArgs e) {
            ShowCustomization = !fShowCustomization;
        }

        protected override bool ShowCustomization {
            get { return fShowCustomization; }
            set {
                fShowCustomization = value;
                if(fShowCustomization) {
                    ShowCustomizationForm();
                    chCustomize.Text = "Hide\r\nCustomization\r\nForm";
                }
                else {
                    CurrentGrid.DestroyCustomization();
                    chCustomize.Text = "Show\r\nCustomization\r\nForm";
                }
            }
        }
        //</chCustomize>
        protected override void AdjustmentGrid() {
            base.AdjustmentGrid();
            timer.Start();
        }
    }
}

