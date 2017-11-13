using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PhotoViewer {
    public partial class FolderGroupCaptionControl : PhotoGroupCaptionControlBase {
        public FolderGroupCaptionControl() {
            InitializeComponent();
        }
        PathData folderData;
        public PathData Folder {
            get { return folderData; }
            set {
                if(Folder == value)
                    return;
                folderData = value;
                OnFolderChanged();
            }
        }

        protected virtual void OnFolderChanged() {
            nameLabel.Text = Folder.Name;
            dataLabel.Text = Directory.GetCreationTime(Folder.Path).ToShortDateString();
        }

        private void OnFolderIconClick(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(Folder.Path, "");
        }
        protected override void OnRemoveButtonClick(object sender, EventArgs e) {
            if(MainForm != null)
                MainForm.RemoveFolder(Folder);
        }
    }
}
