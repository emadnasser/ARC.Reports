using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Compression;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.Docs.Demos {
    public partial class Compression : TutorialControlBase {
        volatile bool isOperationCanceled = false;
        Thread archiveMakerThread;
        string activeArchivePath = String.Empty;

        public Compression() {
            InitializeComponent();
            PrepareContent();
        }
        void MakeArchive(object parameters) {
            ArchiveParametersInfo info = parameters as ArchiveParametersInfo;
            if(info == null)
                return;
            string zipFileName = info.ZipFileName;
            List<FileCollectionItem> sourceFiles = info.SourceFiles;
            string password = info.Password;
            EncryptionType encryptionType = info.EncryptionType;
            bool isSaved = false;
            using(ZipArchive archive = new ZipArchive()) {
                archive.Error += OnArchiveError;
                archive.Progress += OnArchiveProgress;
                archive.ItemAdding += archive_ItemAdding;
                if(!String.IsNullOrEmpty(password)) {
                    archive.Password = password;
                    archive.EncryptionType = encryptionType;
                }
                foreach(FileCollectionItem file in sourceFiles) {
                    if(file.ItemType == FileCollectionItemType.File)
                        archive.AddFile(file.FullName, "/");
                    else if(file.ItemType == FileCollectionItemType.Directory)
                        archive.AddDirectory(file.FullName, file.Name);
                }
                if(!this.isOperationCanceled) {
                    archive.Save(zipFileName);
                    isSaved = true;
                }
            }
            NotifyEndArchivingOperation(isSaved);
        }

        void archive_ItemAdding(object sender, ZipItemAddingEventArgs args) {
            if(this.isOperationCanceled)
                args.Action = ZipItemAddingAction.Stop;
            lblTotalFilesCount.BeginInvoke((Action)(delegate() {
                ZipArchive archive = (ZipArchive)sender;
                this.lblTotalFilesCount.Text = String.Format("Total files found: {0}", archive.Count + 1);

            }));
        }
        void OnArchiveProgress(object sender, ProgressEventArgs args) {
            if(!progressBarControl1.IsHandleCreated)
                return;
            progressBarControl1.BeginInvoke(
                (Action)(delegate() {
                progressBarControl1.EditValue = 1000 * args.Progress;
            })
            );
            args.CanContinue = !this.isOperationCanceled;
        }

        void OnArchiveError(object sender, ErrorEventArgs args) {
            if(args.GetException() is ThreadAbortException) {
                args.CanContinue = false;
                return;
            }
            this.Invoke(new ErrorEventHandler(OnArchiveErrorCore), this, args);
        }
        void OnArchiveErrorCore(object sender, ErrorEventArgs args) {
            Exception e = args.GetException();
            string errorMessage = String.IsNullOrEmpty(args.ItemName) ? e.Message : String.Format("Item: {0}\n\nDescription:\n{1}", args.ItemName, e.Message);
            string descriptionMessage = "Click Cancel to abort operation. Click OK to skip the item and continue.";
            string message = String.Format("{0}\n{1}", errorMessage, descriptionMessage);
            if(XtraMessageBox.Show(message, "Error", MessageBoxButtons.OKCancel) == DialogResult.Cancel) {
                args.CanContinue = false;
                this.isOperationCanceled = true;
            }
        }
        void PrepareContent() {
            this.progressBarControl1.Properties.Minimum = 0;
            this.progressBarControl1.Properties.Maximum = 1000;
            this.cbEncryption.Properties.Items.Add(new ImageComboBoxItem(EncryptionType.PkZip.ToString(), EncryptionType.PkZip));
            this.cbEncryption.Properties.Items.Add(new ImageComboBoxItem(EncryptionType.Aes128.ToString(), EncryptionType.Aes128));
            this.cbEncryption.Properties.Items.Add(new ImageComboBoxItem(EncryptionType.Aes256.ToString(), EncryptionType.Aes256));
            this.cbEncryption.SelectedIndex = 0;
            this.pnlProgress.Visible = false;
            this.HandleDestroyed += Compression_HandleDestroyed;
        }
        void Compression_HandleDestroyed(object sender, EventArgs e) {
            this.isOperationCanceled = true;
            if(this.archiveMakerThread != null)
                archiveMakerThread.Abort();
            this.archiveMakerThread = null;
        }
        void simpleButton1_Click(object sender, EventArgs e) {
            this.activeArchivePath = AskFileName();
            if(String.IsNullOrEmpty(this.activeArchivePath))
                return;
            List<FileCollectionItem> fileNames = this.fileSystemViewer1.GetSelectedFiles();
            ArchiveParametersInfo info = new ArchiveParametersInfo(this.activeArchivePath, fileNames, this.edtPassword.Text, (EncryptionType)this.cbEncryption.EditValue);
            this.archiveMakerThread = new Thread(MakeArchive);
            NotifyBeginArchivingOperation();
            archiveMakerThread.Start(info);
        }
        void NotifyBeginArchivingOperation() {
            this.Invoke((Action)(delegate() {
                this.pnlProgress.Visible = true;
                DisableUserInteraction();
            }));
        }
        void NotifyEndArchivingOperation(bool isSaved) {
            this.Invoke((Action)(delegate() {
                this.pnlProgress.Visible = false;
                this.progressBarControl1.EditValue = 0;
                EnableUserInteraction();
                this.isOperationCanceled = false;
                this.archiveMakerThread = null;
                if(isSaved)
                    System.Diagnostics.Process.Start("explorer.exe", String.Format("/select, {0}", this.activeArchivePath));
            }));
        }
        void DisableUserInteraction() {
            this.fileSystemViewer1.Enabled = false;
            this.simpleButton1.Enabled = false;
            this.groupControl2.Enabled = false;
        }
        void EnableUserInteraction() {
            this.fileSystemViewer1.Enabled = true;
            this.simpleButton1.Enabled = true;
            this.groupControl2.Enabled = true;
        }
        string AskFileName() {
            string result = String.Empty;
            using(SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.Filter = "Zip files (*.zip)|*.zip";
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                    result = saveFileDialog.FileName;
            }
            return result;
        }
        void OnCancelArchivingOperation(object sender, EventArgs e) {
            this.isOperationCanceled = true;
        }

    }
    public class ArchiveParametersInfo {
        public ArchiveParametersInfo(string zipFileName, List<FileCollectionItem> toZipFileNames, string password, EncryptionType encryptionType) {
            ZipFileName = zipFileName;
            SourceFiles = toZipFileNames;
            Password = password;
            EncryptionType = encryptionType;
        }
        public string ZipFileName { get; private set; }
        public List<FileCollectionItem> SourceFiles { get; private set; }
        public string Password { get; private set; }
        public EncryptionType EncryptionType { get; private set; }
    }
}
