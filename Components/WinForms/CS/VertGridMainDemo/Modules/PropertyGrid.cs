using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraVerticalGrid.Rows;

namespace DevExpress.XtraVerticalGrid.Demos {
    public partial class PropertyGrid : DevExpress.XtraVerticalGrid.Demos.TutorialControl {
        public PropertyGrid() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\VertGridMainDemo\\Modules\\PropertyGrid.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraVerticalGrid.Demos.CodeInfo.PropertyGrid.xml";


            //<chDefaultEditors>
            /*
            ~Note: the DefaultEditors property is customized at design time and listed here only for demonstration purposes.
            ~Add items to the DefaultEditors collection, and so define which editors must be used to edit values of specific data types.
            ~Values of the Color, Boolean and Image types will be edited using the ColorEdit, CheckEdit and PictureEdit control, respectively:
            
            propertyGridControl1.DefaultEditors.AddRange(new DefaultEditor[] {
                new DefaultEditor(typeof(System.Drawing.Color), this.repositoryItemColorEdit1),
                new DefaultEditor(typeof(bool), this.repositoryItemCheckEdit1),
                new DefaultEditor(typeof(System.Drawing.Image), this.repositoryItemPictureEdit1)});
            */
            //</chDefaultEditors>
        }
        bool optionsUpdate = false;
        public override VGridControlBase ExportControl { get { return propertyGridControl1; } }
        public override VGridControlBase ViewOptionsControl { get { return propertyGridControl1; } }

        private void PropertyGrid_Load(object sender, System.EventArgs e) {
            InitControls();
            InitOptions();
        }

        void InitControls() {
            propertyDescriptionControl1.PropertyGrid = this.propertyGridControl1;
            foreach (Control ctrl in pcControls.Controls) {
                icbControls.Properties.Items.Add(new ImageComboBoxItem(ctrl.Name, ctrl, -1));
                ctrl.GotFocus += new EventHandler(Control_GotFocus);
            }
            icbControls.SelectedIndex = 0;
        }


        void InitOptions() {
            optionsUpdate = true;
            chRootCategories.Checked = propertyGridControl1.OptionsView.ShowRootCategories;
            chDefaultEditors.Checked = propertyGridControl1.OptionsBehavior.UseDefaultEditorsCollection;
            chPropertyDescription.Checked = propertyDescriptionControl1.Visible;
            optionsUpdate = false;
        }

        protected override void OnOptionsChanged(object sender, EventArgs e) {
            InitOptions();
        }

        void Control_GotFocus(object sender, EventArgs e) {
            icbControls.EditValue = sender;
        }

        //<icbControls>
        private void icbControls_SelectedIndexChanged(object sender, System.EventArgs e) {
            propertyGridControl1.SelectedObject = icbControls.EditValue;
            propertyGridControl1.RetrieveFields();
        }
        //</icbControls>

        //<chRootCategories>
        private void chRootCategories_CheckedChanged(object sender, System.EventArgs e) {
            if (optionsUpdate) return;
            propertyGridControl1.OptionsView.ShowRootCategories = chRootCategories.Checked;
        }
        //</chRootCategories>

        //<chDefaultEditors>
        private void chDefaultEditors_CheckedChanged(object sender, System.EventArgs e) {
            if (optionsUpdate) return;
            propertyGridControl1.OptionsBehavior.UseDefaultEditorsCollection = chDefaultEditors.Checked;
            propertyGridControl1.LayoutChanged();
        }
        //</chDefaultEditors>

        //<chPropertyDescription>
        private void chPropertyDescription_CheckedChanged(object sender, EventArgs e) {
            if (optionsUpdate)
                return;
            propertyDescriptionControl1.Visible = chPropertyDescription.Checked;
            splitterControl2.Visible = chPropertyDescription.Checked;
        }
        //</chPropertyDescription>

    }
}

