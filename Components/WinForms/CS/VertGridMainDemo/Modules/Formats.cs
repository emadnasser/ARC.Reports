using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;

namespace DevExpress.XtraVerticalGrid.Demos {
    public partial class Formats : DevExpress.XtraVerticalGrid.Demos.PropertiesBase {
        public Formats() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\VertGridMainDemo\\Modules\\Formats.cs;CS\\VertGridMainDemo\\Modules\\Properties.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraVerticalGrid.Demos.CodeInfo.Formats.xml";
            tcProperties.BringToFront();
            // TODO: Add any initialization after the InitializeComponent call
        }

        string[] styleNames = new string[] { "Pastel#1", "Spring", "Vagabond", "Blue Office" };
        //<lsStyles>
        DevExpress.XtraVerticalGrid.Design.XAppearances xapp;
        //</lsStyles>
        bool fLockStylesUpdate = false;

        private void ceNewStyles_CheckedChanged(object sender, System.EventArgs e) {
            if(xapp != null) xapp.ShowNewStylesOnly = ceNewStyles.Checked;
            lsStyles.Items.Clear();
            lsStyles.Items.AddRange(xapp.FormatNames);
            SetSelectedStyleItem();
        }

        void SetSelectedStyleItem() {
            lsStyles.SelectedItem = styleNames[SelectedPageIndex];
        }
        //<lsStyles>
        private void ChangeStyle() {
            if(fLockStylesUpdate) return;
            if(lsStyles.SelectedItem != null) {
                xapp.LoadScheme(lsStyles.SelectedItem.ToString(), CurrentGrid);
                styleNames[SelectedPageIndex] = lsStyles.SelectedItem.ToString();
            }
        }

        private void lsStyles_SelectedIndexChanged(object sender, System.EventArgs e) {
            ChangeStyle();
        }
        //</lsStyles>
        //<tabPage10>
        private void lbcAppearances_SelectedIndexChanged(object sender, System.EventArgs e) {
            propertyGrid1.SelectedObjects = SelectedObjects;
        }

        object SelectedObject {
            get {
                if(lbcAppearances.SelectedItem == null) return null;
                return GetAppearanceObjectByName(CurrentGrid, lbcAppearances.GetItem(lbcAppearances.SelectedIndex).ToString());
            }
        }
        object[] SelectedObjects {
            get {
                if(lbcAppearances.SelectedItem == null) return null;
                ArrayList ret = new ArrayList();
                for(int i = 0; i < lbcAppearances.SelectedIndices.Count; i++) {
                    object obj = GetAppearanceObjectByName(CurrentGrid, lbcAppearances.GetItem(lbcAppearances.SelectedIndices[i]).ToString());
                    ret.Add(obj);
                }
                return ret.ToArray();
            }
        }
        //</tabPage10>
        protected override void AdjustmentGrid() {
            base.AdjustmentGrid();
            fLockStylesUpdate = true;
            SetSelectedStyleItem();
            fLockStylesUpdate = false;
        }

        protected override void InitStyles() {
            base.InitStyles();
            xapp = new DevExpress.XtraVerticalGrid.Design.XAppearances(System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) + "\\DevExpress.XtraVerticalGrid.Appearances.xml");
            lsStyles.Items.AddRange(xapp.FormatNames);
            for(int i = 0; i < 4; i++)
                xapp.LoadScheme(styleNames[i], GridByIndex(i));
            InitAppearanceList(CurrentGrid);
        }

        protected override void InitAppearanceList(VGridControl vg) {
            base.InitAppearanceList(vg);
            lbcAppearances.Items.Clear();
            PropertyDescriptorCollection collection = TypeDescriptor.GetProperties(vg.Appearance);
            for(int i = 0; i < collection.Count; i++)
                if(collection[i].PropertyType == typeof(AppearanceObject))
                    lbcAppearances.Items.Add(collection[i].Name);
            lbcAppearances.SelectedIndex = 0;
        }
    }
}
