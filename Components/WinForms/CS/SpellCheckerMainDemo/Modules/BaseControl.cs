using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraSpellChecker;
using System.Globalization;
using DevExpress.XtraEditors;
using DevExpress.Utils.Zip;
using System.IO;

namespace DevExpress.XtraSpellChecker.Demos {
    public partial class BaseTutorialControl : DevExpress.XtraSpellChecker.Demos.TutorialControl {
        public BaseTutorialControl() {
            InitializeComponent();
        }

        protected virtual void OnTutorialControlLoaded(object sender, System.EventArgs e) {
            if (DesignMode)
                return;
            DictionaryCollection dictionaries = spellChecker1.UseSharedDictionaries ? sharedDictionaryStorage1.Dictionaries : spellChecker1.Dictionaries;
            if (dictionaries.Count == 0)
                PopulateDictionaries(dictionaries);
            spellChecker1.Culture = dictionaries.Count > 0 ? dictionaries[0].Culture : CultureInfo.CurrentCulture;
        }
        protected virtual void PopulateDictionaries(DictionaryCollection dictionaries) {
            dictionaries.Add(GetDefaultDictionary());
            SpellCheckerCustomDictionary customDictionary = new SpellCheckerCustomDictionary(DemoUtils.GetRelativePath("Dictionaries\\CustomEnglish.dic"), new CultureInfo("en-US"));
            dictionaries.Add(customDictionary);
        }
        private ISpellCheckerDictionary GetDefaultDictionary() {
            SpellCheckerISpellDictionary dic = new SpellCheckerISpellDictionary();
            Stream zipFileStream = GetFileStream("Dictionaries\\default.zip");
            InternalZipFileCollection files = InternalZipArchive.Open(zipFileStream);
            Stream alphabetStream = GetFileStream("Dictionaries\\EnglishAlphabet.txt");
            Stream dictionaryStream = GetFileStream(files, "american.xlg");
            Stream grammarStream = GetFileStream(files, "english.aff");
            try {
                dic.LoadFromStream(dictionaryStream, grammarStream, alphabetStream);
            }
            catch {
            }
            finally {
                dictionaryStream.Dispose();
                grammarStream.Dispose();
                zipFileStream.Dispose();
                alphabetStream.Dispose();
                DisposeZipFileStreams(files);
            }
            dic.Culture = new CultureInfo("en-US");
            return dic;
        }
        protected Stream GetFileStream(string relativeUri) {
            return new FileStream(DemoUtils.GetRelativePath(relativeUri), FileMode.Open, FileAccess.Read, FileShare.Read);
        }
        protected Stream GetFileStream(InternalZipFileCollection files, string name) {
            Stream stream = files.Find(delegate(InternalZipFile file) {
                return file.FileName.IndexOf(name) >= 0;
            }).FileDataStream;
            try {
                return CreateMemoryStream(stream);
            }
            finally {
                stream.Close();
            }
        }
        protected Stream CreateMemoryStream(Stream stream) {
            MemoryStream result = new MemoryStream();
            for (; ; ) {
                int readedByte = stream.ReadByte();
                if (readedByte < 0)
                    break;
                result.WriteByte((byte)readedByte);
            }
            result.Flush();
            result.Seek(0, SeekOrigin.Begin);
            return result;
        }
        protected void DisposeZipFileStreams(InternalZipFileCollection files) {
            foreach(InternalZipFile file in files)
                file.FileDataStream.Dispose();
        }
        protected virtual Control GetActiveControl() {
            Control result = ActiveControl;
            if(result is DevExpress.XtraEditors.TextBoxMaskBox)
                result = result.Parent;
            return result;
        }
        protected virtual void OnEditorKeyDown(object sender, System.Windows.Forms.KeyEventArgs e) { 
            if(e.KeyCode == Keys.F7 && e.Modifiers == Keys.None)
                DoCheck();
        }
		private void btnCheckSpelling_Click(object sender, System.EventArgs e) {
			DoCheck();
		}
		protected virtual void DoCheck() {
			spellChecker1.Check(GetActiveControl());
		}

        protected virtual void OnCheckedChanged(object sender, EventArgs e) {
            spellChecker1.SpellCheckMode = (sender as CheckEdit).Checked ? SpellCheckMode.AsYouType : SpellCheckMode.OnDemand;
            if(spellChecker1.SpellCheckMode == SpellCheckMode.AsYouType)
                DoCheck();
        }
    }
}

