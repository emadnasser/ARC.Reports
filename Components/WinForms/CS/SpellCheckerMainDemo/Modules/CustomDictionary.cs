using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using DevExpress.XtraSpellChecker;

namespace DevExpress.XtraSpellChecker.Demos {
	/// <summary>
	/// Summary description for Employees.
	/// </summary>
	public partial class CustomDictionary : BaseTutorialControl {
		public CustomDictionary() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			
			// TODO: Add any initialization after the InitForm call
		}

		protected SpellCheckerCustomDictionary Dictionary {
			get { return (SpellCheckerCustomDictionary)spellChecker1.Dictionaries[0]; } 
		}

		private void FormDictionary_Load(object sender, System.EventArgs e) {
            InitSpellChecker();
		}
        protected void OnEditControlKeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            OnEditorKeyDown(sender, e);
        }
        protected virtual void InitSpellChecker() {
			spellChecker1.Dictionaries.Add(new SpellCheckerCustomDictionary(string.Empty, new CultureInfo("En-us")));
        }
		protected override Control GetActiveControl() {
			return memText;
		}
		private void spellChecker1_AfterCheck(object sender, System.EventArgs e) {
			ArrayList words = new ArrayList();
			int wordCount = Dictionary.WordCount;
			for(int i = 0; i < wordCount; i++)
				words.Add(Dictionary[i]);
            mmDictionary.Lines = (string[])words.ToArray(typeof(String));
		}
        private void spellChecker1_BeforeCheck(object sender, System.EventArgs e) {
            Dictionary.Clear();
            Dictionary.AddWords(mmDictionary.Lines);
        }
    }
}
