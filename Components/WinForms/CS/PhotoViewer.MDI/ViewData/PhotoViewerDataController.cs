using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PhotoViewer.Data {
    public class PhotoViewerDataController {
        readonly PhotoViewerData Data;
        public event EventHandler DataChanged;
        public PhotoViewerDataController(PhotoViewerData data) {
            this.Data = data;
        }
        public void AddToOthers(string[] items, Form owner) {
            if(items.Length > 0) {
                int addedCount = 0;
                foreach(string item in items) {
                    if(!IsFileAdded(item)) {
                        Data.Others.Files.Add(CreateFilePathData(item));
                        addedCount++;
                    }
                }
                if(addedCount > 0)
                    RaiseDataChanged(Data.Others);
            }
        }
        public void AddToAlbum(string[] items, AlbumData album, Form owner) {
            if(album == null)
                album = AddNewAlbum(owner);
            if(album == null)
                return;
            if(items.Length > 0) {
                int addedCount = 0;
                foreach(string item in items) {
                    if(!album.Files.Contains(item)) {
                        album.Files.Add(CreateFilePathData(item));
                        addedCount++;
                    }
                }
                if(addedCount > 0)
                    RaiseDataChanged(album);
            }
        }
        public void RemoveImagesFromAlbum(string[] items, AlbumData album, Form owner) {
            string messageText = string.Empty;
            messageText = "Are you sure you want to remove checked items from album '" + album.Name + "'?";
            if(XtraMessageBox.Show(owner, messageText, owner.Text,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            if(items.Length > 0) {
                int removeCount = 0;
                foreach(string file in items) {
                    if(album.Files.Remove(file))
                        removeCount++;
                }
                if(removeCount > 0)
                    RaiseDataChanged(album);
            }
        }
        public AlbumData AddAlbum(string albumName, string description, List<string> files) {
            return AddAlbum(albumName, DateTime.Now, description, files);
        }
        public AlbumData AddAlbum(string albumName, DateTime albumDate, string description, List<string> files) {
            AlbumData album = new AlbumData();
            album.Name = albumName;
            album.Date = albumDate;
            album.Description = description;
            if(files != null) {
                foreach(string file in files) {
                    PathData pData = new PathData();
                    pData.Path = file;
                    album.Files.Add(pData);
                }
                RaiseDataChanged(album);
            }
            Data.Albums.Add(album);
            return album;
        }
        public PathData AddFolder(string path) {
            if(!Directory.Exists(path))
                return null;
            PathData pathData = CreateFilePathData(path);
            Data.Folders.Add(pathData);
            RaiseDataChanged(pathData);
            return pathData;
        }
        public bool IsFolderAdded(string folderPath) {
            return Data.Folders.Contains(folderPath);
        }
        public bool IsFileAdded(string fileName) {
            return Data.Others.Files.Contains(fileName);
        }
        PathData CreateFilePathData(string fileName) {
            PathData pdata = new PathData();
            pdata.Path = fileName;
            pdata.Name = Path.GetFileName(fileName);
            return pdata;
        }
        public void GenerateSampleData() {
            Data.Clear();
            PathData f0 = AddFolder(DataPath + "\\SamplePhotos\\Photo1");
            PathData f1 = AddFolder(DataPath + "\\SamplePhotos\\Photo2");
            PathData f2 = AddFolder(DataPath + "\\SamplePhotos\\Photo3");
            PathData f3 = AddFolder(DataPath + "\\SamplePhotos\\Photo4");
            if(Data.Folders.Count > 1) {
                List<string> files = new List<string>();
                files.AddRange(GetImagesInFolder(f0));
                files.AddRange(GetImagesInFolder(f1));
                AddAlbum("Sample Album 1", "This is a sample album 1", files);
            }
            if(Data.Folders.Count > 3) {
                List<string> files = new List<string>();
                files.AddRange(GetImagesInFolder(f2));
                files.AddRange(GetImagesInFolder(f3));
                AddAlbum("Sample Album 2", "This is a sample album 2", files);
            }
            Data.Others.Name = "Other";
            Data.Others.Date = DateTime.Now;
            Data.Others.Description = "Other image files";
        }
        public List<string> GetImagesInFolder(PathData folder) {
            string[] strFilter = new string[] { "*bmp", "*tga", "*.jpg", "*.png", "*.gif" };
            List<string> files = new List<string>();
            foreach(string filter in strFilter) {
                string[] str = Directory.GetFiles(folder.Path, filter);
                files.AddRange(str);
            }
            return files;
        }
        public void SaveData() {
            Data.FirstRun = false;
            string path = ViewDataFile;
            if(File.Exists(path))
                Data.SaveLayoutToXml(path);
        }
        public void LoadData() {
            Data.Clear();
            string path = ViewDataFile;
            if(File.Exists(path))
                Data.RestoreLayoutFromXml(path);
            if(Data.FirstRun)
                GenerateSampleData();
        }
        public bool CanEditAlbum(AlbumData album) {
            return Data.Others != album;
        }
        public string ThumbPath { get { return DataPath + "\\Thumbs\\"; } }
        public string ViewDataFile { get { return DataPath + "\\data.xml"; } }
        protected string GetDataDir() {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            for(int i = 0; i < 10; i++) {
                path += "..\\";
                if(Directory.Exists(path + "Data"))
                    return path + "Data";
            }
            return string.Empty;
        }
        protected string DataPath {
            get {
                string path = GetDataDir() + "\\PhotoViewer";
                if(Directory.Exists(path))
                    return path;
                return string.Empty;
            }
        }
        public IEnumerable GetAlbums() {
            return Data.Albums;
        }
        public IEnumerable GetFolders() {
            return Data.Folders;
        }
        public bool RemoveAlbum(AlbumData album, Form owner) {
            if(XtraMessageBox.Show(owner, "Are you really want to remove album?", owner.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Data.Albums.Remove(album);
                return true;
            }
            return false;
        }
        public bool RemoveFolder(PathData folder, Form owner) {
            if(XtraMessageBox.Show(owner, "Are you really want to remove folder?", owner.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Data.Folders.Remove(folder);
                return true;
            }
            return false;
        }
        public AlbumData AddNewAlbum(Form owner) {
            AlbumPropertiesForm form = new AlbumPropertiesForm(this);
            form.Text = "New album properties";
            form.Owner = owner;
            if(form.ShowDialog() == DialogResult.OK) {
                return AddAlbum(form.AlbumName, form.AlbumDate, form.AlbumDescription, null);
            }
            return null;
        }
        protected internal void RaiseDataChanged(object data) {
            if(DataChanged != null)
                DataChanged(data, EventArgs.Empty);
        }
    }
}
