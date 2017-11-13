using System;
using System.IO;

namespace PhotoViewer {
    public partial class FolderGroupCaptionControl : PhotoGroupCaptionControlBase {
        public FolderGroupCaptionControl() {
            InitializeComponent();
        }
        PathData folderCore;
        public PathData Folder {
            get { return folderCore; }
            set {
                if(Folder == value)
                    return;
                folderCore = value;
                OnFolderChanged();
            }
        }
        protected virtual void OnFolderChanged() {
            nameLabel.Text = Folder.Name;
            dataLabel.Text = Directory.GetCreationTime(Folder.Path).ToShortDateString();
        }
        protected override void OnRemoveButtonClick(object sender, EventArgs e) {
            FolderGalleryForm gForm = GalleryForm as FolderGalleryForm;
            if(gForm != null) {
                gForm.RemoveFolder();
                gForm.MainForm.UpdateData(false);
                gForm.Close();
            }
        }
        protected override void OnGroupIconClick(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(Folder.Path, "");
        }
    }
}
