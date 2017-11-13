using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for StyleConditionsForm.
    /// </summary>
    public partial class StyleConditionsForm : DevExpress.XtraEditors.XtraForm {
        DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatConditionCollection collection = null;
        public StyleConditionsForm(DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatConditionCollection collection) {
            this.collection = collection;
            InitializeComponent();
            for(int i = 0; i < collection.Count; i++)
                listBoxControl1.Items.Add(string.Format("Condition Item {0}", i));
            listBoxControl1.SelectedIndex = 0;
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, System.EventArgs e) {
            propertyGrid1.PropertyGrid.SelectedObject = collection[listBoxControl1.SelectedIndex];
        }
    }
}
