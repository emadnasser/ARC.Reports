using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
// <comboGlyphAlign>
using DevExpress.Utils;
// </comboGlyphAlign>
// <btnPopulateItems>
using DevExpress.XtraEditors.Controls;
using DevExpress.Skins;
// </btnPopulateItems>

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleRadioGroup : TutorialControl {
        public ModuleRadioGroup() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\ModuleRadioGroup.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.radioGroup.xml";
            this.radioGroupSample.AutoSizeInLayoutControl = true;
        }
        bool updateValues = false;

        // <btnSelectNext>
        private void btnSelectNext_Click(object sender, System.EventArgs e) {
            int currentSelectedIndex = radioGroupSample.SelectedIndex;
            currentSelectedIndex++;
            if(currentSelectedIndex == radioGroupSample.Properties.Items.Count)
                currentSelectedIndex = 0;
            radioGroupSample.SelectedIndex = currentSelectedIndex;
        }
        // </btnSelectNext>

        // <comboGlyphAlign>
        private void comboGlyphAlign_SelectedIndexChanged(object sender, System.EventArgs e) {
            HorzAlignment[] alignments = new HorzAlignment[] { 
				HorzAlignment.Near,
				HorzAlignment.Center, 
				HorzAlignment.Far };
            int selectedIndex = comboGlyphAlign.SelectedIndex;
            radioGroupSample.Properties.GlyphAlignment = alignments[selectedIndex];
            radioGroupSample.Properties.Appearance.TextOptions.HAlignment = alignments[selectedIndex];
        }
        // </comboGlyphAlign>

        // <spinColumns>
        private void spinColumns_EditValueChanged(object sender, System.EventArgs e) {
            radioGroupSample.Properties.Columns = (int)spinColumns.Value;
            CalcLayoutControlBounds(layoutControl1);
        }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        // </spinColumns>

        // <comboSetEditValue>
        private void comboSetEditValue_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            string[] editValues = new string[] { 
				"Circle", "Rectangle", "Ellipse", 
				"Triangle", "Square", "Nothing" };
            int selectedIndex = comboSetEditValue.SelectedIndex;
            radioGroupSample.EditValue = editValues[selectedIndex];
        }
        // </comboSetEditValue>

        private void ModuleRadioGroup_Load(object sender, System.EventArgs e) {
            btnPopulateItems_Click(btnPopulateItems, new EventArgs());
            CalcLayoutControlBounds(layoutControl1);
        }

        // <btnPopulateItems>
        private void btnPopulateItems_Click(object sender, System.EventArgs e) {
            string[] strings = new string[] { 
				"Circle", "Rectangle", "Ellipse", 
				"Triangle", "Square" };
            string[] values = new string[] { 
				"Circle", "Rectangle", "Ellipse", 
				"Triangle", "Square", "Nothing" };
            for(int i = 0; i < strings.Length; i++)
                radioGroupSample.Properties.Items.Add(new RadioGroupItem(values[i], strings[i]));
            comboSetEditValue.Properties.Items.Clear();
            for(int i = 0; i < values.Length; i++)
                comboSetEditValue.Properties.Items.Add(values[i]);
            radioGroupSample.SelectedIndex = 0;
            SetControlsEnabled(true);
        }
        // </btnPopulateItems>

        // <btnClearItems>
        private void btnClearItems_Click(object sender, System.EventArgs e) {
            radioGroupSample.Properties.Items.Clear();
            comboSetEditValue.Properties.Items.Clear();
            checkEditAllowMnemonics.Checked = false;
            SetControlsEnabled(false);
        }
        // <btnPopulateItems>
        private void SetControlsEnabled(bool listPopulated) {
            btnPopulateItems.Enabled = !listPopulated;
            ArrayList controls = new ArrayList();
            controls.AddRange(new Control[] { 
				btnClearItems, spinColumns, 
				comboGlyphAlign, checkEditAllowMnemonics, 
				spinSelectedIndex, comboSetEditValue,
				txtSelectedIndexValue });
            foreach(Control ctrl in controls)
                ctrl.Enabled = listPopulated;
        }
        // </btnClearItems> </btnPopulateItems>

        // <spinSelectedIndex>
        private void spinSelectedIndex_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            radioGroupSample.SelectedIndex = (int)spinSelectedIndex.Value;
        }
        // </spinSelectedIndex>


        // <txtSelectedIndexValue>
        private void radioGroupSample_SelectedIndexChanged(object sender, System.EventArgs e) {
            txtSelectedIndexValue.Text = radioGroupSample.SelectedIndex.ToString() + " / " +
                radioGroupSample.EditValue.ToString();
            updateValues = true;
            spinSelectedIndex.Value = radioGroupSample.SelectedIndex;
            comboSetEditValue.EditValue = radioGroupSample.EditValue;
            updateValues = false;

        }
        // </txtSelectedIndexValue>

        // <checkEditAllowMnemonics>
        private void checkEditAllowMnemonics_CheckedChanged(object sender, System.EventArgs e) {
            foreach(RadioGroupItem item in radioGroupSample.Properties.Items) {
                if(checkEditAllowMnemonics.Checked)
                    item.Description = "&" + item.Description;
                else
                    item.Description = item.Description.Substring(1);
            }
        }
        // </checkEditAllowMnemonics>

    }
}

