using System;
using System.IO;
using System.Security;
using System.Windows.Forms;
using DevExpress.Pdf;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraEditors;
using System.Security.Cryptography;

namespace DevExpress.Docs.Demos {
    public class PdfFileHelper : IDisposable {
        public const string SaveErrorMessage = "Unable to save the PDF document.\r\n{0}";
        public const string DemoOpeningErrorMessage = "The demo data has been corrupted.";

        static string ShowFileDialog<T>() where T : FileDialog, new() {
            using (T fileDialog = new T()) {
                fileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                fileDialog.RestoreDirectory = true;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                    return fileDialog.FileName;
                return null;
            }
        }
        public static bool LoadDocument(PdfViewer viewer, string path) {
            try {
                viewer.LoadDocument(path);
            }
            catch {
                XtraMessageBox.Show(DemoOpeningErrorMessage, "Error");
                return false;
            }
            return true;
        }
        public static bool LoadDocument(PdfViewer viewer, Stream stream) {
            try {
                viewer.LoadDocument(stream);
            }
            catch {
                XtraMessageBox.Show(DemoOpeningErrorMessage, "Error");
                return false;
            }
            return true;
        }
        public static string SaveFileDialog() {
            return ShowFileDialog<SaveFileDialog>();
        }
        public static string OpenFileDialog() {
            return ShowFileDialog<OpenFileDialog>();
        }
        public static void Save(PdfDocumentProcessor documentProcessor) {
            Save(documentProcessor, new PdfSaveOptions());
        }
        public static void Save(PdfDocumentProcessor documentProcessor, PdfSaveOptions saveOptions) {
            string fileName = SaveFileDialog();
            if (!String.IsNullOrEmpty(fileName))
                try {
                    PdfDocument document = documentProcessor.Document;
                    document.Creator = "PDF Document Processor Demo";
                    document.Producer = "Developer Express Inc., " + AssemblyInfo.Version;
                    documentProcessor.SaveDocument(fileName, saveOptions);
                }
                catch (CryptographicException exception) {
                    XtraMessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch {
                    XtraMessageBox.Show(String.Format(SaveErrorMessage, fileName), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        readonly PdfDocumentProcessor documentProcessor;
        readonly PdfViewer viewer;
        SecureString password;

        public PdfFileHelper(PdfDocumentProcessor documentProcessor, PdfViewer viewer) {
            this.documentProcessor = documentProcessor;
            this.viewer = viewer;
            documentProcessor.PasswordRequested += OnDocumentServerPasswordRequested;
            viewer.PasswordRequested += OnViewerPasswordRequested;
        }
        void OpenFile(Action<string> fileAction) {
            string fileName = ShowFileDialog<OpenFileDialog>();
            if (!String.IsNullOrEmpty(fileName)) {
                for (; ; )
                    try {
                        fileAction(fileName);
                        return;
                    }
                    catch (PdfIncorrectPasswordException) {
                        if (password == null)
                            return;
                        XtraMessageBox.Show("The password is incorrect. Please make sure that Caps Lock is not enabled.", fileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                    catch(OutOfMemoryException) {
                        XtraMessageBox.Show(String.Format("Not enough memory to load the file.\r\n{0}", fileName), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    catch {
                        string message = "Unable to load the PDF document because the following file is not available or it is not a valid PDF document.\r\n{0}\r\nPlease ensure that the application can access this file and that it is valid, or specify a different file.";
                        XtraMessageBox.Show(String.Format(message, fileName), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
            }
        }
        void MergeFileAction(string fileName) {
            documentProcessor.AppendDocument(fileName);
        }
        void OpenFileAction(string fileName) {
            documentProcessor.LoadDocument(fileName);
            viewer.LoadDocument(fileName);
        }

        public void MergeFile() {
            OpenFile(MergeFileAction);
        }
        public void OpenFile() {
            OpenFile(OpenFileAction);
        }
        public bool LoadDocument(string path) {
            return LoadDocument(path, false);
        }
        public bool LoadDocument(string path, bool detach) {
            viewer.DetachStreamAfterLoadComplete = detach;
            if (LoadDocument(viewer, path)) {
                documentProcessor.LoadDocument(path, detach);
                return true;
            }
            return false;
        }
        void OnDocumentServerPasswordRequested(object sender, PdfPasswordRequestedEventArgs e) {
            using (PasswordForm form = new PasswordForm(Path.GetFileName(e.FileName))) {
                form.StartPosition = FormStartPosition.CenterParent;
                if (form.ShowDialog() == DialogResult.OK) {
                    password = new SecureString();
                    foreach (char c in form.Password)
                        password.AppendChar(c);
                    e.Password = password;
                }
                else
                    password = null;
            }
        }
        void OnViewerPasswordRequested(object sender, PdfPasswordRequestedEventArgs e) {
            e.Password = password;
        }
        public void Dispose() {
            documentProcessor.PasswordRequested -= OnDocumentServerPasswordRequested;
            viewer.PasswordRequested -= OnViewerPasswordRequested;
            if (password != null)
                password.Dispose();
        }
    }
}
