using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;
using DevExpress.Utils.Zip;
using DevExpress.XtraSpellChecker;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.XtraRichEdit.Demos {
    /// <summary>
    /// Summary description for DemoUtils.
    /// </summary>
    public class DemoUtils {
        public static string GetRelativePath(string name) {
            name = "Data\\" + name;
            string path = System.Windows.Forms.Application.StartupPath;
            string s = "\\";
            for (int i = 0; i <= 10; i++) {
                if (System.IO.File.Exists(path + s + name))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            return "";
        }
        public static void SetConnectionString(System.Data.OleDb.OleDbConnection oleDbConnection, string path) {
            oleDbConnection.ConnectionString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path);
        }
    }
    public class RtfLoadHelper {
        public static void Load(String fileName, RichEditControl richEditControl) {
            string path = DemoUtils.GetRelativePath(fileName);
            if (!String.IsNullOrEmpty(path))
                richEditControl.LoadDocument(path, DocumentFormat.Rtf);
        }
    }
    public class DocLoadHelper {
        public static void Load(string fileName, RichEditControl richEditControl) {
            string path = DemoUtils.GetRelativePath(fileName);
            if (!string.IsNullOrEmpty(path))
                richEditControl.LoadDocument(path, DocumentFormat.Doc);
        }
    }
    public class HtmlLoadHelper {
        public static void Load(String fileName, RichEditControl richEditControl) {
            string path = DemoUtils.GetRelativePath(fileName);
            if (!String.IsNullOrEmpty(path))
                richEditControl.LoadDocument(path, DocumentFormat.Html);
        }
    }
    public class OpenXmlLoadHelper {
        public static void Load(String fileName, RichEditControl richEditControl) {
            string path = DemoUtils.GetRelativePath(fileName);
            if (!String.IsNullOrEmpty(path))
                richEditControl.LoadDocument(path, DocumentFormat.OpenXml);
        }
    }
    public class PlainTextLoadHelper {
        public static void Load(String fileName, RichEditControl richEditControl) {
            string path = DemoUtils.GetRelativePath(fileName);
            if (!String.IsNullOrEmpty(path))
                richEditControl.LoadDocument(path, DocumentFormat.PlainText);
        }
    }
    public class SpellCheckerHelper {
        public static void AddDictionaries(SharedDictionaryStorage storage) {
            if (storage.Dictionaries.Count > 0)
                return;

            CultureInfo engCulture = new CultureInfo("en-us");
            SpellCheckerISpellDictionary dictionary = new SpellCheckerISpellDictionary(DemoUtils.GetRelativePath(@"american.xlg"), DemoUtils.GetRelativePath("english.aff"), engCulture);
            dictionary.AlphabetPath = DemoUtils.GetRelativePath("EnglishAlphabet.txt");
            storage.Dictionaries.Add(dictionary);
            SpellCheckerCustomDictionary customDictionary = new SpellCheckerCustomDictionary(DemoUtils.GetRelativePath("CustomEnglish.dic"), engCulture);
            storage.Dictionaries.Add(customDictionary);
        }
        public static void AddDictionaries(DevExpress.XtraSpellChecker.SpellChecker spellChecker) {
            spellChecker.Dictionaries.Add(CreateHunspellDictionaries(new CultureInfo("en-US")));
            spellChecker.Dictionaries.Add(CreateHunspellDictionaries(new CultureInfo("de-DE")));
            spellChecker.Dictionaries.Add(CreateHunspellDictionaries(new CultureInfo("ru-RU")));
        }
        static HunspellDictionary CreateHunspellDictionaries(CultureInfo culture) {
            string[] parts = culture.Name.Split('-');
            HunspellDictionary result = new HunspellDictionary();
            Stream zipFileStream = GetFileStream(String.Format("{0}_{1}.zip", parts[0], parts[1]));
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
        static void DisposeZipFileStreams(InternalZipFileCollection files) {
            foreach (InternalZipFile file in files)
                file.FileDataStream.Dispose();
        }
        static Stream GetFileStream(InternalZipFileCollection files, string name) {
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
        static Stream GetFileStream(string relativeUri) {
            return new FileStream(DemoUtils.GetRelativePath(relativeUri), FileMode.Open, FileAccess.Read, FileShare.Read);
        }
        static Stream CreateMemoryStream(Stream stream) {
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
    }
    public class RichEditDemoExceptionsHandler {
        readonly RichEditControl control;
        public RichEditDemoExceptionsHandler(RichEditControl control) {
            this.control = control;
        }
        public void Install() {
            if (control != null)
                control.UnhandledException += OnRichEditControlUnhandledException;
        }

        protected virtual void OnRichEditControlUnhandledException(object sender, RichEditUnhandledExceptionEventArgs e) {
            try {
                if (e.Exception != null)
                    throw e.Exception;
            }
            catch (RichEditUnsupportedFormatException ex) {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            catch (ExternalException ex) {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            catch (System.IO.IOException ex) {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
    public abstract class BufferedDocumentVisitor : DocumentVisitorBase {
        readonly StringBuilder buffer;
        protected BufferedDocumentVisitor() {
            this.buffer = new StringBuilder();
        }
        protected StringBuilder Buffer { get { return buffer; } }
    }
}
