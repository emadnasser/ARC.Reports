using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Tutorials;
using System.Windows.Forms;


namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleMaskBox : TutorialControl {
        public ModuleMaskBox() {
            InitializeComponent();
            InitValues();
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\MaskProperties.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.maskbox.xml";
        }
        protected override bool AllowCenterControls { get { return false; } }
        string[] imageDescription = new string[] { "Phone", "Date", "Long Time", "Short Time", "Extension", "Social Security", "Long Zip Code", "Short Zip Code" };
        MaskProperties properties = null;
        DevExpress.XtraEditors.TextEdit activeEditor = null;
        Font font = DevExpress.Utils.AppearanceObject.DefaultFont;
        Font boldFont = new Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Bold);

        private void ModuleMaskBox_Load(object sender, System.EventArgs e) {
            InitEditors();
            SelectObject(null, EventArgs.Empty);
        }


        void InitValues() {
            if(properties == null) {
                properties = new MaskProperties(activeEditor);
                properties.Dock = DockStyle.Fill;
                properties.PropertyValueChanged += new EventHandler(maskProperties_PropertyValueChanged);
                xtraTabPage5.Controls.Add(properties);
            }
            else {
                properties.InitMask(activeEditor);
            }
        }

        DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CurrentProperties {
            get { return properties == null ? null : properties.ActiveProperties; }
        }

        void InitEditors() {
            for(int i = 0; i < xtcMain.TabPages.Count; i++)
                foreach(Control ctrl in xtcMain.TabPages[i].Controls) {
                    DevExpress.XtraEditors.TextEdit te = ctrl as DevExpress.XtraEditors.TextEdit;
                    if(te != null) {
                        te.Enter += new EventHandler(SelectObject);
                        te.EditValueChanged += new EventHandler(maskEditBox_ValueChanged);
                        te.Properties.ValidateOnEnterKey = true;
                        if(te.Properties.Mask.MaskType == DevExpress.XtraEditors.Mask.MaskType.DateTime) {
                            te.EditValue = DateTime.Now;
                        }
                    }
                }
        }

        private void maskEditBox_ValueChanged(object sender, EventArgs e) {
            DevExpress.XtraEditors.TextEdit te = sender as DevExpress.XtraEditors.TextEdit;
            if(te != null && te.EditValue != null)
                editValueBox.Text = te.EditValue.ToString();
            else
                editValueBox.Text = "";
        }

        private void SelectObject(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.TextEdit te = sender as DevExpress.XtraEditors.TextEdit;
            editValueBox.Text = "";
            activeEditor = null;
            if(te != null) {
                if(te.EditValue != null)
                    editValueBox.Text = te.EditValue.ToString();
                activeEditor = te;
            }
            InitValues();
            xtcMain.SelectedTabPage.Invalidate();
        }


        private void maskProperties_PropertyValueChanged(object s, EventArgs e) {
            editValueBox.Text = "";
            if(activeEditor != null)
                activeEditor.EditValue = "";
        }

        Image ImageByString(string s) {
            for(int i = 0; i < imageDescription.Length; i++)
                if(s.IndexOf(imageDescription[i]) == 0) return imageList2.Images[i];
            return null;
        }

        private void xtp_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
            foreach(Control ctrl in ((Control)sender).Controls)
                if(ctrl is DevExpress.XtraEditors.TextEdit) {
                    Font f = ((DevExpress.XtraEditors.TextEdit)ctrl).Properties == CurrentProperties ? boldFont : font;
                    Color controlTextColor = DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(LookAndFeel.ActiveLookAndFeel, SystemColors.ControlText);
                    using(SolidBrush brush = new SolidBrush(controlTextColor)) 
                        e.Graphics.DrawString(ctrl.Tag.ToString(), f, brush, ctrl.Left, (ctrl.Top - f.Height - 2));
                    if(ctrl.Tag != null) {
                        Image image = ImageByString(ctrl.Tag.ToString());
                        if(image != null)
                            e.Graphics.DrawImage(image, ctrl.Left - image.Width - 4, ctrl.Top + (ctrl.Height - image.Height) / 2);
                    }
                }
        }
    }
}

