using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraNavBar;

namespace DevExpress.XtraNavBar.Demos {
    public partial class ctrlAlphaBlending : DevExpress.XtraEditors.XtraUserControl {
        public ctrlAlphaBlending() {
            InitializeComponent();
        }

        AppearanceObject appObject;
        NavBarControl navBar;
        NavBarGroup group;

        private Image backGround {
            get {
                if(navBar != null) return navBar.BackgroundImage;
                return group.BackgroundImage;
            }
            set {
                if(navBar != null) navBar.BackgroundImage = value;
                else group.BackgroundImage = value;
            }
        }

        public void StyleInit(AppearanceObject app, string s, NavBarControl navBar) {
            StyleInit(app, s, navBar, null);
        }
        public void StyleInit(AppearanceObject app, string s, NavBarGroup group) {
            StyleInit(app, s, null, group);
        }
        private void StyleInit(AppearanceObject app, string s, NavBarControl navBar, NavBarGroup group) {
            appObject = app;
            groupBox1.Text = s;
            StyleColorChange(app.BackColor.A);
            this.navBar = navBar;
            this.group = group;
            pictureBox1.Image = backGround;
        }



        #region Component Designer generated code

        #endregion

        private void StyleColorChange(int v) {
            appObject.BackColor = Color.FromArgb(v, appObject.BackColor);
            numericUpDown1.Value = v;
            trackBar1.Value = v;
        }

        private void trackBar1_ValueChanged(object sender, System.EventArgs e) {
            StyleColorChange(trackBar1.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e) {
            StyleColorChange((int)numericUpDown1.Value);
        }

        private void pictureBox1_Click(object sender, System.EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Bitmap Files (*.bmp)|*.bmp|" +
                "Graphics Interchange Format (*.gif)|*.gif|" +
                "JPEG File Interchange Format (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "Icon Files (*.ico)|*.ico|" +
                "All Picture Files |*.bmp;*.gif;*.jpg;*.jpeg;*.ico;*.png;*.tif|" +
                "All Files |*.*";
            dlg.Title = "Open";
            dlg.FilterIndex = 5;
            if(dlg.ShowDialog() == DialogResult.OK) {
                try {
                    pictureBox1.Image = Image.FromFile(dlg.FileName);
                    backGround = pictureBox1.Image;
                }
                catch { }
            }
        }

        private void label2_DoubleClick(object sender, System.EventArgs e) {
            pictureBox1.Image = null;
            backGround = pictureBox1.Image;
        }
    }
}
