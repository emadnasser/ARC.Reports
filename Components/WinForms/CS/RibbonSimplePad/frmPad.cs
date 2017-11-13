using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraBars.Demos.RibbonSimplePad {
    /// <summary>
    /// Summary description for frmPad.
    /// </summary>
    public partial class frmPad : DevExpress.XtraEditors.XtraForm {
        public frmPad() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraBars.Demos.RibbonSimplePad.AppIcon.ico", typeof(frmMain).Assembly);
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        bool modified = false;
        bool newDocument = true;
        string docName = "";

        public RichTextBox RTBMain { get { return richTextBox1; } }

        public string DocName {
            get { return docName; }
            set {
                this.docName = value;
                this.Text = DocName;
            }
        }
        public bool Modified {
            get { return modified; }
            set {
                if(value != modified) {
                    modified = value;
                    this.Text = DocName + (Modified ? "*" : "");
                    if(MdiParent != null) ((frmMain)MdiParent).UpdateText();
                }
            }
        }
        public bool NewDocument { get { return this.newDocument; } }
        public void LoadDocument(string fileName) {
            this.newDocument = false;
            try {
                RTBMain.LoadFile(fileName);
            }
            catch {
                XtraMessageBox.Show("Sorry, this file cannot be opened.", "Ribbon Simple Pad");
            }
            this.DocName = fileName;
        }

        public string SaveAs(string path) {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf";
            dlg.Title = "Save As";
            if(path != string.Empty) dlg.InitialDirectory = path;
            if(dlg.ShowDialog(this) == DialogResult.OK) {
                RTBMain.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText);
                this.DocName = dlg.FileName;
                this.newDocument = false;
                this.Modified = false;
                return this.DocName;
            }
            return string.Empty;
        }

        bool SaveQuestion() {
            if(Modified) {
                switch(DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to save the changes you made to " + DocName + "?", "SimplePad Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                    case DialogResult.Cancel:
                        return false;
                    case DialogResult.Yes:
                        SaveAs(string.Empty);
                        break;
                }
            }
            return true;
        }

        private void frmPad_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            e.Cancel = !SaveQuestion();
        }

        private void richTextBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) {
            if(RTBMain.ClientRectangle.Contains(e.X, e.Y)) {
                if((e.Button & MouseButtons.Right) != 0)
                    RaiseShowPopupMenu();
                else if(e.Button == MouseButtons.Left)
                    RaiseShowMiniToolbar();
            }
        }

        public event EventHandler ShowPopupMenu;
        public event EventHandler ShowMiniToolbar;
        void RaiseShowPopupMenu() {
            if(ShowPopupMenu != null)
                ShowPopupMenu(RTBMain, EventArgs.Empty);
        }
        void RaiseShowMiniToolbar() {
            if(ShowMiniToolbar != null)
                ShowMiniToolbar(RTBMain, EventArgs.Empty);
        }
    }
}
