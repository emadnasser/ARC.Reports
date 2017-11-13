using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Utils;

namespace DevExpress.XtraRichEdit.Demos.Forms {
    public partial class SelectProductForm : PopupFormBase {
        public SelectProductForm(List<string> list)
            : this() {
            PopulateListBox(list);
        }
        public SelectProductForm() {
            InitializeComponent();
        }

        private void PopulateListBox(List<string> list) {
            this.listBoxControl.Items.AddRange(list.ToArray());
            if (list.Count > 0)
                this.listBoxControl.SelectedIndex = 0;
        }
        private void listBoxControl_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left || this.listBoxControl.SelectedIndex < 0)
                return;
            Rectangle rect = this.listBoxControl.GetItemRectangle(this.listBoxControl.SelectedIndex);
            if (!rect.Contains(e.X, e.Y))
                return;
            OnCommit();
        }
        protected override void SetEditValue() {
            SetEditValueCore((string)this.listBoxControl.SelectedItem);
        }
        private void listBoxControl_MouseMove(object sender, MouseEventArgs e) {
            for (int i = 0; i < this.listBoxControl.ItemCount; i++) {
                Rectangle rect = this.listBoxControl.GetItemRectangle(i);
                if (rect.Contains(e.X, e.Y)) {
                    this.listBoxControl.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
