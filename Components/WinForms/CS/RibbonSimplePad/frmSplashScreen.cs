using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace DevExpress.XtraBars.Demos.RibbonSimplePad {
    public partial class frmSplashScreen : SplashScreen {
        public frmSplashScreen() {
            InitializeComponent();
            pictureEdit2.Image = DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.XtraEditors.SplashScreen.DemoSplashScreen.png", typeof(DemoSplashScreen).Assembly);
            this.labelControl1.Text = AssemblyInfo.AssemblyCopyright;
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg) {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand {
        }
    }
}
