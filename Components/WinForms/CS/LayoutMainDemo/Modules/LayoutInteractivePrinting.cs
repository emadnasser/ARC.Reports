﻿using System;

namespace DevExpress.XtraLayout.Demos {
    public partial class LayoutInteractivePrinting : TutorialControl {
        public LayoutInteractivePrinting() {
            InitializeComponent();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e) {
            layoutWaybill1.pedLogo.Properties.SizeMode = XtraEditors.Controls.PictureSizeMode.Squeeze;
            layoutWaybill1.layoutControl1.ShowPrintPreview();
            layoutWaybill1.pedLogo.Properties.SizeMode = XtraEditors.Controls.PictureSizeMode.Zoom;
        }
    }
}
