using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSpellChecker.Rules;
using System.Collections.Generic;
using DevExpress.XtraBars;
using System.Globalization;
using System.IO;
using DevExpress.Utils.Zip;

namespace DevExpress.XtraSpellChecker.Demos {
	/// <summary>
	/// Summary description for Employees.
	/// </summary>
	public partial class HunspellDictionaries : BaseTutorialControl {
        public HunspellDictionaries() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

            spellChecker1.UseSharedDictionaries = false;
            LoadDocument();
		}

        private void LoadDocument() {
            string path = DemoUtils.GetRelativePath("HunspellDictionaries.docx");
            if (!String.IsNullOrEmpty(path))
                richEditControl1.LoadDocument(path, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
        }
        protected override void OnTutorialControlLoaded(object sender, EventArgs e) {
            base.OnTutorialControlLoaded(sender, e);
            spellChecker1.Culture = CultureInfo.InvariantCulture;
        }
		protected override Control GetActiveControl() {
			return richEditControl1;
		}
        protected void OnEditControlKeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            OnEditorKeyDown(sender, e);
        }
        protected override void PopulateDictionaries(DictionaryCollection dictionaries) {
            dictionaries.Add(CreateHunspellDictionaries(new CultureInfo("en-US")));
            dictionaries.Add(CreateHunspellDictionaries(new CultureInfo("de-DE")));
            dictionaries.Add(CreateHunspellDictionaries(new CultureInfo("ru-RU")));
        }
        private HunspellDictionary CreateHunspellDictionaries(CultureInfo culture) {
            string[] parts = culture.Name.Split('-');
            HunspellDictionary result = new HunspellDictionary();
            Stream zipFileStream = GetFileStream(String.Format("Dictionaries\\{0}_{1}.zip", parts[0], parts[1]));
            InternalZipFileCollection files = InternalZipArchive.Open(zipFileStream);
            Stream dictionaryStream = GetFileStream(files, ".dic");
            Stream grammarStream = GetFileStream(files, ".aff");
            try {
                result.LoadFromStream(dictionaryStream, grammarStream);
            }
            catch {
            }
            finally {
                dictionaryStream.Dispose();
                grammarStream.Dispose();
                zipFileStream.Dispose();
                DisposeZipFileStreams(files);
            }
            result.Culture = culture;
            return result;
        }
        protected override void OnCheckedChanged(object sender, EventArgs e) {
            this.spellChecker1.SpellCheckMode = (sender as CheckEdit).Checked ? SpellCheckMode.AsYouType : SpellCheckMode.OnDemand;
        }
	}
}
