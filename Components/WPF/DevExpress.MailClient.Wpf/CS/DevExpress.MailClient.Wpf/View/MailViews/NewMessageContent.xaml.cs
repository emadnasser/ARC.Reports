using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using DevExpress.MailClient.Helpers;
using DevExpress.Xpf.RichEdit;
using DevExpress.Xpf.SpellChecker;
using DevExpress.XtraRichEdit.SpellChecker;
using DevExpress.XtraSpellChecker;
using DevExpress.XtraSpellChecker.Native;
using System.ComponentModel;
using DevExpress.Mvvm;

namespace DevExpress.MailClient.View {
    public partial class NewMessageContent : UserControl {
        public SpellChecker SpellChecker { get; set; }

        public NewMessageContent() {
            if(!DesignerProperties.GetIsInDesignMode(this)) {
                SpellChecker = CreateSpellChecker();
            }
            InitializeComponent();
        }

        void OnRichEditLoaded(object sender, RoutedEventArgs e) {
            richEdit.SpellChecker = SpellChecker;
        }
        SpellChecker CreateSpellChecker() {
            SpellChecker spellChecker = new SpellChecker();
            spellChecker.Culture = new CultureInfo("en-US");
            spellChecker.SpellCheckMode = SpellCheckMode.AsYouType;
            RegisterDictionary(spellChecker, GetDefaultDictionary());

            SpellCheckTextControllersManager.Default.RegisterClass(typeof(RichEditControl), typeof(RichEditSpellCheckController));
            return spellChecker;
        }
        SpellCheckerDictionaryBase GetDefaultDictionary() {
            SpellCheckerISpellDictionary dic = new SpellCheckerISpellDictionary();
            dic.LoadFromStream(GetFileStream("american.xlg"),
                               GetFileStream("english.aff"),
                               GetFileStream("EnglishAlphabet.txt"));
            return dic;
        }
        void RegisterDictionary(SpellChecker spellChecker, SpellCheckerDictionaryBase dic) {
            dic.Culture = spellChecker.Culture;
            spellChecker.Dictionaries.Add(dic);
        }
        static Stream GetFileStream(string path) {
            return File.OpenRead(FilePathHelper.GetFullPath(path));
        }
    }
}
