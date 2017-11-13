using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;

namespace DevExpress.ApplicationUI.Demos {
    /// <summary>
    /// Summary description for BaseControl.
    /// </summary>
    public partial class BaseControl : DevExpress.XtraEditors.XtraUserControl {
        public BaseControl() {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitForm call

        }

        Random rnd = new Random();
        private void dockManager1_RegisterDockPanel(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e) {
            e.Panel.ImageIndex = rnd.Next(imageList1.Images.Count);
        }

        public DockManager Manager { get { return dockManager1; } }
    }
}
