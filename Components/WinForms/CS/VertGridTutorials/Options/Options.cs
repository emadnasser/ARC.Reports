using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraVerticalGrid;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for Options.
    /// </summary>
    public partial class Options : TutorialControl {
        public Options() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void Options_Load(object sender, System.EventArgs e) {
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
            InitOptions(vGridControl1.OptionsView, checkedListBox1);
            InitOptions(vGridControl1.OptionsBehavior, checkedListBox2);
        }

        private void InitOptions(object options, DevExpress.XtraEditors.CheckedListBoxControl checkedListBox) {
            ArrayList arr = DevExpress.Utils.SetOptions.GetOptionNames(options);
            for(int i = 0; i < arr.Count; i++)
                checkedListBox.Items.Add(new DevExpress.XtraEditors.Controls.CheckedListBoxItem
                    (arr[i], DevExpress.Utils.SetOptions.OptionValueByString(arr[i].ToString(), options)));
        }

        //<checkedListBox1>
        private void checkedListBox1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e) {
            bool optionSet = e.State == CheckState.Checked ? true : false;
            string option = checkedListBox1.GetDisplayItemValue(e.Index).ToString();
            DevExpress.Utils.SetOptions.SetOptionValueByString(option, vGridControl1.OptionsView, optionSet);
        }
        //</checkedListBox1>

        //<checkedListBox2>
        private void checkedListBox2_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e) {
            bool optionSet = e.State == CheckState.Checked ? true : false;
            string option = checkedListBox2.GetDisplayItemValue(e.Index).ToString();
            DevExpress.Utils.SetOptions.SetOptionValueByString(option, vGridControl1.OptionsBehavior, optionSet);
        }
        //</checkedListBox2>
    }
}
