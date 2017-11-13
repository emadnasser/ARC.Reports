using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <icbScrollBars>
using DevExpress.XtraEditors.Controls;
// </icbScrollBars>
using System.Windows.Forms;
using DevExpress.Tutorials;


namespace DevExpress.XtraEditors.Demos {
	public partial class ModuleMemoEdit : TutorialControl  {
		public ModuleMemoEdit() {
			InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\ModuleMemoEdit.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.memoedit.xml";
		}

        bool updateValues = false;

		private void ModuleMemoEdit_Load(object sender, System.EventArgs e) {
			ControlUtils.CenterControlInParent(memoEditSample);
			memoEditSample.Text = @"MemoEdit is a multi-line text editor. In addition to the advanced text input features derived from the TextEdit control, it offers numerous options for multi-line text management.

- Optional ENTER and TAB key processing.
- Customizable visibility for vertical and horizontal scrollbars.
- Optional text word-wrapping.
- Specifying height in text lines (if used within a container control such as the XtraGrid, XtraTreeList, and XtraVerticalGrid).";
			InitComboBoxes();
			InitValues();
		}
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
		void InitComboBoxes() {
			// <icbScrollBars>
            icbScrollBars.Properties.Items.AddEnum(typeof(ScrollBars)); 
			// </icbScrollBars>
		}
		
		void InitValues() {
			updateValues = true;
			icbScrollBars.EditValue = memoEditSample.Properties.ScrollBars;
			ceWordWrap.Checked = memoEditSample.Properties.WordWrap;
			ceReturn.Checked = memoEditSample.Properties.AcceptsReturn;
			ceTab.Checked = memoEditSample.Properties.AcceptsTab;
			seMaxLength.Value = memoEditSample.Properties.MaxLength;
			updateValues = false;
		}

		// <icbScrollBars>
		private void icbScrollBars_SelectedIndexChanged(object sender, System.EventArgs e) {
			// <skip>
			if(updateValues) return;
			// </skip>
			memoEditSample.Properties.ScrollBars = (ScrollBars)icbScrollBars.EditValue;
		}
		// </icbScrollBars>

		// <ceWordWrap>
		private void ceWordWrap_CheckedChanged(object sender, System.EventArgs e) {
			// <skip>
			if(updateValues) return;
			// </skip>
			memoEditSample.Properties.WordWrap = ceWordWrap.Checked;
		}
		// </ceWordWrap>

		// <ceReturn>
		private void ceReturn_CheckedChanged(object sender, System.EventArgs e) {
			// <skip>
			if(updateValues) return;
			// </skip>
			memoEditSample.Properties.AcceptsReturn = ceReturn.Checked;
		}
		// </ceReturn>

		// <ceTab>
		private void ceTab_CheckedChanged(object sender, System.EventArgs e) {
			// <skip>
			if(updateValues) return;
			// </skip>
			memoEditSample.Properties.AcceptsTab = ceTab.Checked;
		}
		// </ceTab>

		// <seMaxLength>
		private void seMaxLength_EditValueChanged(object sender, System.EventArgs e) {
			// <skip>
			if(updateValues) return;
			// </skip>
			memoEditSample.Properties.MaxLength = Convert.ToInt32(seMaxLength.Value);
		}
		// </seMaxLength>
	}
}

