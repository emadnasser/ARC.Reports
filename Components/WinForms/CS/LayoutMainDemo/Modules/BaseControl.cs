using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraLayout.Demos {
    public partial class BaseTutorialControl : DevExpress.XtraLayout.Demos.TutorialControl {
        string layoutName = "Default.xml";
        bool fCustomization = false;
        public BaseTutorialControl() {
            InitializeComponent();
            DisableLoadButton();
            if(Skins.DpiProvider.Default.DpiScaleFactor > 1.4)
                this.navigationPage1.ImageUri.Uri = "Properties;Size32x32;Office2013";
            Customization = false;
            cbFiles.Properties.ButtonClick += OnButtonClick;
        }
        public override LayoutControl ExportControl { get { return BaseLayout; } }
        void OnButtonClick(object sender, ButtonPressedEventArgs e) {
            if(e.Button.Index == 1) Restore();
        }
        void sbSave_Click(object sender, System.EventArgs e) {
            Store();
        }
        public virtual LayoutControl BaseLayout { get { return null; } }
        protected virtual string FileMask { get { return "xtra"; } }
        void cbFiles_EditValueChanged(object sender, System.EventArgs e) {
            DisableLoadButton();
        }
        void DisableLoadButton() {
            EditorButton btn = cbFiles.Properties.Buttons[1];
            btn.Enabled = !string.IsNullOrEmpty(cbFiles.Text) && !cbFiles.Text.Equals(layoutName);
        }
        protected void InitPanels() {
            navigationPage1.Visible = BaseLayout != null;
            if(BaseLayout != null) {
                ArrayList XmlFileNames = FindingXmlFiles(Application.StartupPath, "Data\\FormLayouts\\", FileMask);
                if(XmlFileNames.Count == 0) navigationPage1.Visible = false;
                cbFiles.Properties.Items.Clear();
                foreach(XMLFileName name in XmlFileNames)
                    cbFiles.Properties.Items.Add(name);
                BaseLayout.ShowCustomization += new EventHandler(ShowCustomization);
                BaseLayout.HideCustomization += new EventHandler(HideCustomization);
                BaseLayout.OptionsView.AllowExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
                BaseLayout.OptionsCustomizationForm.ShowPropertyGrid = true;
                BaseLayout.OptionsCustomizationForm.SnapMode = DevExpress.Utils.Controls.SnapMode.All;
            }
        }
        public bool Customization {
            get { return fCustomization; }
            set {
                fCustomization = value;
                sbCustomize.Text = (fCustomization) ? "Hide Customization Form" : "Show Customization Form";
            }
        }
        void ShowCustomization(object sender, EventArgs e) {
            Customization = true;
        }
        void HideCustomization(object sender, EventArgs e) {
            Customization = false;
        }
        string CurrentXMLFileName {
            get {
                XMLFileName file = cbFiles.SelectedItem as XMLFileName;
                if(file == null) return "";
                return file.FullName;
            }
        }
        void Restore() {
            if(BaseLayout == null || string.IsNullOrEmpty(CurrentXMLFileName)) 
                return;
            BaseLayout.RestoreLayoutFromXml(CurrentXMLFileName);
            tabTransitionAnimation_CheckedChanged(null, null);
            layoutName = "";
        }
        void Store() {
            if(BaseLayout == null) return;
            BaseLayout.SaveLayoutToXml("Temp.xml");
        }
        #region Finding Xml Files
        public static ArrayList FindingXmlFiles(string path, string path1, string mask) {
            string s = "\\";
            ArrayList xmlFiles = new ArrayList();
            for(int i = 0; i <= 10; i++) {
                if(System.IO.Directory.Exists(path + s + path1)) {
                    string[] names = System.IO.Directory.GetFiles(path + s + path1, mask + "*.xml");
                    foreach(string name in names) {
                        System.IO.FileInfo fInfo = new System.IO.FileInfo(name);
                        string fName = fInfo.Name;
                        fName = fName.Replace(mask, "");
                        xmlFiles.Add(new XMLFileName(fName, fInfo.FullName));
                    }
                    return xmlFiles;
                }
                else
                    s += "..\\";
            }
            return xmlFiles;
        }

        private class XMLFileName {
            string fName, fFullName;
            public XMLFileName(string name, string fullName) {
                this.fName = name;
                this.fFullName = fullName;
            }
            public string Name { get { return fName; } }
            public string FullName { get { return fFullName; } }
            public override string ToString() {
                return Name;
            }
        }
        #endregion

        protected override void DoHide() {
            if(BaseLayout != null) BaseLayout.HideCustomizationForm();
            lcTitle.HideCustomizationForm();
        }

        private void sbCustomize_Click(object sender, System.EventArgs e) {
            if(BaseLayout == null) return;
            if(Customization)
                BaseLayout.HideCustomizationForm();
            else
                BaseLayout.ShowCustomizationForm();
        }


        private void allowItemSkinningCheckEdit_CheckedChanged(object sender, System.EventArgs e) {
            if(BaseLayout == null) return;
            BaseLayout.OptionsView.AllowItemSkinning = allowItemSkinningCheckEdit.Checked;
            highlightFocusedItemCheckEdit.Enabled = allowItemSkinningCheckEdit.Checked;
        }

        private void highlightFocusedItemCheckEdit_CheckedChanged(object sender, System.EventArgs e) {
            if(BaseLayout == null) return;
            BaseLayout.OptionsView.HighlightFocusedItem = highlightFocusedItemCheckEdit.Checked;
        }

        private void checkEdit5_CheckedChanged(object sender, EventArgs e) {
            if(BaseLayout == null) return;
            if(quickCustomizationCheckEdit.Checked == true) {
                BaseLayout.CustomizationMode = CustomizationModes.Quick;
            }
            else BaseLayout.CustomizationMode = CustomizationModes.Default;
        }

        private void checkEdit6_CheckedChanged(object sender, EventArgs e) {
            BaseLayout.OptionsView.DrawAdornerLayer = showAdornerLayerCheckEdit.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        }

        private void allowExpandAnimationCheckEdit_CheckedChanged(object sender, EventArgs e) {
            BaseLayout.OptionsView.AllowExpandAnimation = allowExpandAnimationCheckEdit.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        }

        private void showPropertyGridCheckEdit_CheckedChanged(object sender, EventArgs e) {
            BaseLayout.OptionsCustomizationForm.ShowPropertyGrid = showPropertyGridCheckEdit.Checked;
        }

        private void snapModeCheckEdit_CheckedChanged(object sender, EventArgs e) {
            if(snapModeCheckEdit.Checked)
                BaseLayout.OptionsCustomizationForm.SnapMode = DevExpress.Utils.Controls.SnapMode.All;
            else
                BaseLayout.OptionsCustomizationForm.SnapMode = DevExpress.Utils.Controls.SnapMode.None;
        }

        private void tabTransitionAnimation_CheckedChanged(object sender, EventArgs e) {
            SetTransition(tabTransitionAnimationCheckEdit.Checked);
        }

        void SetTransition(bool value) {
            foreach(var item in BaseLayout.Items) {
                TabbedControlGroup tcg = item as TabbedControlGroup;
                if(tcg == null) continue;
                tcg.Transition.AllowTransition = value ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
            }
        }

        private void snapModeLCI_CustomDraw(object sender, ItemCustomDrawEventArgs e) {
            e.DefaultDraw();
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(55, 127, 221, 134)), e.Bounds);
            e.Handled = true;
        }
    }
}

