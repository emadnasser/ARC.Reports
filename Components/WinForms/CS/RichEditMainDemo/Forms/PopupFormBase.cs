using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Utils;
using DevExpress.Utils.KeyboardHandler;

namespace DevExpress.XtraRichEdit.Demos.Forms {
    public class PopupFormBase : DevExpress.XtraEditors.XtraForm {
        object editValue;
        DocumentRange range;
        public PopupFormBase() {
            InitializeComponent();
        }

        public virtual object EditValue { get { return editValue; } }
        public DocumentRange Range { get { return range; } set { range = value; } }

        EventHandler onCommit;
        public event EventHandler Commit { add { onCommit += value; } remove { onCommit -= value; } }
        protected void RaiseCommitEvent() {
            if (onCommit != null)
                onCommit(this, EventArgs.Empty);
        }

        void InitializeComponent() {
            this.SuspendLayout();
            // 
            // PopupFormBase
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(268, 248);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PopupFormBase";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Deactivate += new System.EventHandler(this.PopupFormBase_Deactivate);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PopupFormBase_KeyDown);
            this.ResumeLayout(false);

        }
        protected virtual void SetEditValueCore(object value) {
            this.editValue = value;
        }
        protected virtual void SetEditValue() {
        }
        private void PopupFormBase_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Escape)
                Close();
            else if (e.KeyData == Keys.Enter)
                OnCommit();
        }
        protected virtual void OnCommit() {
            SetEditValue();
            RaiseCommitEvent();
            Close();
        }
        private void PopupFormBase_Deactivate(object sender, EventArgs e) {
            Close();
        }
    }
}
