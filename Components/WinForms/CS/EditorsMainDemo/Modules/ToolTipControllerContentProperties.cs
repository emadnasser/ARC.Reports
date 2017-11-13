using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;

namespace EditorsTutorials.Modules {
    public partial class ToolTipControllerContentProperties : UserControl {
        public ToolTipControllerContentProperties() {
            InitializeComponent();
        }

        ToolTipController controller = null;
        Control control = null;
        bool isManual = false;

        public void Init(ToolTipController controller, Control control, string toolTipText, string titleText, bool isManual) {
            this.isManual = isManual;
            this.controller = controller;
            this.control = control;
            InitComboBoxes();
            meToolTipText.Text = toolTipText;
            teTitleText.Text = titleText;
            if(isManual)
                icbIconSize.EditValue = ToolTipIconSize.Large;
            else icbIconSize.EditValue = controller.IconSize;
            controller.ImageList = imcSmall;
        }

        void InitComboBoxes() {
            icbIconType.Properties.Items.AddEnum(typeof(ToolTipIconType));
            icbIconType.SelectedIndex = isManual ? icbIconType.Properties.Items.Count - 1 : 3;
            icbIconSize.Properties.Items.AddEnum(typeof(ToolTipIconSize));
        }

        private void meToolTipText_TextChanged(object sender, System.EventArgs e) {
            if(isManual) return;
            controller.SetToolTip(control, meToolTipText.Text);
        }

        private void teTitleText_TextChanged(object sender, System.EventArgs e) {
            if(isManual) return;
            controller.SetTitle(control, teTitleText.Text);
        }

        private void icbIconType_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(isManual) return;
            controller.SetToolTipIconType(control, (ToolTipIconType)icbIconType.EditValue);
        }

        private void icbIconSize_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(isManual) return;
            controller.IconSize = (ToolTipIconSize)icbIconSize.EditValue;
        }

        private void icbCustomImage_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(isManual) return;
            controller.ImageIndex = icbCustomImage.SelectedIndex - 1;
        }

        public ToolTipControllerShowEventArgs CreateShowArgs() {
            ToolTipControllerShowEventArgs args = controller.CreateShowArgs();
            args.ToolTip = meToolTipText.Text;
            args.Title = teTitleText.Text;
            args.IconType = (ToolTipIconType)icbIconType.EditValue;
            args.IconSize = (ToolTipIconSize)icbIconSize.EditValue;
            args.ImageIndex = icbCustomImage.SelectedIndex - 1;
            return args;
        }
    }
}
