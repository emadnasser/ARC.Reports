using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraLayout.Demos.Modules.TechnoLayout {
    public partial class FacesUserControl : UserControl {
        public FacesUserControl() {
            InitializeComponent();
            SetPicture();
            layoutControl1.BeginUpdate();
            try {
                foreach(LayoutControlItem item in lcgFaces.Items)
                    item.Size = new Size((int)Math.Round(item.Width * Skins.DpiProvider.Default.DpiScaleFactor), (int)Math.Round(item.Height * Skins.DpiProvider.Default.DpiScaleFactor));
            }
            finally {
                layoutControl1.EndUpdate();
            }
        }
        void SetPicture() {
            int i = 0;
            foreach(LayoutControlItem lci in lcgFaces.Items) {
                ((PictureEdit)lci.Control).Image = imageCollection1.Images[i];
                i++;
            }
        }
    }
}
