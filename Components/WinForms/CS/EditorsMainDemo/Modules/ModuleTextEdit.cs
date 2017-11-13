using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Tutorials;
using System.Windows.Forms;
// <comboNumericFormat>
// <comboDateFormat>
using DevExpress.Utils;
// </comboDateFormat>
// </comboNumericFormat>

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleTextEdit : TutorialControl {
        public ModuleTextEdit() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\ModuleTextEdit.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.textEdit.xml";
            if(this.tabctrlTextEdit != null)
                this.tabctrlTextEdit.SelectedPageChanged += OnSelectedPageChanged;
        }

        void OnSelectedPageChanged(object sender, XtraTab.TabPageChangedEventArgs e) {
            CalcContentCore();
        }
        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            if(this.tabctrlTextEdit != null)
                this.tabctrlTextEdit.SelectedPageChanged -= OnSelectedPageChanged;
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl2);
            CalcLayoutControlBounds(layoutControl1);
        }
        private Random rnd;
        bool updateValues = false;

        // <checkEditHideSelection>
        private void checkEditHideSelection_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            textEditSample.Properties.HideSelection = checkEditHideSelection.Checked;
        }
        // </checkEditHideSelection>

        // <comboBoxSelectCase>
        private void comboBoxSelectCase_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            CharacterCasing[] caseStyles = new CharacterCasing[] { 
				CharacterCasing.Normal, 
				CharacterCasing.Upper,
				CharacterCasing.Lower };
            int selectedIndex = comboBoxSelectCase.SelectedIndex;
            textEditSample.Properties.CharacterCasing = caseStyles[selectedIndex];
        }
        // </comboBoxSelectCase>

        // <comboBoxPasswordChar>
        private void comboBoxPasswordChar_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            char[] passwordChars = new Char[] { char.MinValue, '*', '#' };
            int selectedIndex = comboBoxPasswordChar.SelectedIndex;
            textEditSample.Properties.PasswordChar = passwordChars[selectedIndex];
        }
        // </comboBoxPasswordChar>

        // <comboNumericFormat>
        private void comboNumericFormat_SelectedIndexChanged(object sender, System.EventArgs e) {
            UpdateNumericTextEditFormat();
        }
        // </comboNumericFormat>
        // <spinEditDecimalPlaces>
        private void spinEditDecimalPlaces_EditValueChanged(object sender, System.EventArgs e) {
            UpdateNumericTextEditFormat();
        }
        // <comboNumericFormat>
        private void UpdateNumericTextEditFormat() {
            string[] formatSpecifiers = new string[] { string.Empty, "c", "f", "e", "p", "X" };
            int selectedFormat = comboNumericFormat.SelectedIndex;
            if(selectedFormat == 0) {
                textEditNumeric.Properties.DisplayFormat.FormatType = FormatType.None;
                textEditNumeric.Properties.DisplayFormat.FormatString = string.Empty;
                return;
            }
            string formatString = formatSpecifiers[selectedFormat] + spinEditDecimalPlaces.EditValue.ToString();
            textEditNumeric.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            textEditNumeric.Properties.DisplayFormat.FormatString = formatString;
        }
        // </spinEditDecimalPlaces>
        // </comboNumericFormat>

        // <comboNumericEditValue>
        private void comboNumericEditValue_SelectedIndexChanged(object sender, System.EventArgs e) {
            double[] values = new double[] { 0.5, 1, 123.45, -12.34, 100 };
            int valueIndex = comboNumericEditValue.SelectedIndex;
            if(Math.Floor(values[valueIndex]) - values[valueIndex] == 0)
                textEditNumeric.EditValue = Convert.ToInt32(values[valueIndex]);
            else
                textEditNumeric.EditValue = values[valueIndex];
        }
        // </comboNumericEditValue>

        // <dateEdit>
        private void dateEdit_EditValueChanged(object sender, System.EventArgs e) {
            textEditDate.EditValue = dateEdit.EditValue;
        }
        // </dateEdit>

        // <comboDateFormat>
        private void comboDateFormat_SelectedIndexChanged(object sender, System.EventArgs e) {
            string[] formatStrings = new string[] { "", "d", "D", "t", "T", "f", "g", "s" };
            int stringIndex = comboDateFormat.SelectedIndex;
            if(formatStrings[stringIndex] == "") {
                textEditDate.Properties.DisplayFormat.FormatType = FormatType.None;
                textEditDate.Properties.DisplayFormat.FormatString = string.Empty;
                return;
            }
            textEditDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            textEditDate.Properties.DisplayFormat.FormatString = formatStrings[stringIndex];
        }
        // </comboDateFormat>

        private void ModuleTextEdit_Load(object sender, System.EventArgs e) {
            textEditDate.EditValue = new DateTime(2005, 3, 30, 14, 54, 32);
            dateEdit.EditValue = textEditDate.EditValue;
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(textEditNumeric);
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(textEditDate);
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(textEditSample);
            InitValues();
        }


        void InitValues() {
            updateValues = true;
            checkEditHideSelection.Checked = textEditSample.Properties.HideSelection;
            comboBoxSelectCase.EditValue = textEditSample.Properties.CharacterCasing.ToString();
            comboBoxPasswordChar.EditValue = textEditSample.Properties.PasswordChar;
            updateValues = false;
        }

        // <buttonsSelection>
        private void buttonsSelection_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if(e.Button.Caption == "All")
                textEditSample.SelectAll();
            if(e.Button.Caption == "Random")
                SetRandomSelection();
            if(e.Button.Caption == "Clear")
                textEditSample.SelectionLength = 0;
        }
        private void SetRandomSelection() {
            if(rnd == null)
                rnd = new Random();
            int pos1 = rnd.Next(textEditSample.Text.Length);
            int pos2 = rnd.Next(textEditSample.Text.Length);
            textEditSample.Select(Math.Min(pos1, pos2), Math.Abs(pos1 - pos2));
        }
        // </buttonsSelection>
    }
}

