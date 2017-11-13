using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraSpellChecker.Demos {
	/// <summary>
	/// Summary description for Employees.
	/// </summary>
	public partial class CheckMemoEdit : BaseTutorialControl {
		public CheckMemoEdit() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			// TODO: Add any initialization after the InitForm call

		}

		protected override Control GetActiveControl() {
			return memoEdit1;
		}
        protected void OnEditControlKeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            OnEditorKeyDown(sender, e);
        }

        private void CheckMemoEdit_Load(object sender, EventArgs e) {
            spellChecker1.SpellingFormType = SpellingFormType.Word;
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            spellChecker1.SpellCheckMode = (sender as CheckEdit).Checked ? SpellCheckMode.AsYouType : SpellCheckMode.OnDemand;
            if(spellChecker1.SpellCheckMode == SpellCheckMode.AsYouType)
                DoCheck();
        }
	}
}
