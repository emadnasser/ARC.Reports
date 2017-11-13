using System;
using System.Collections;
using DevExpress.Data;

namespace DevExpress.XtraGrid.Demos {
    #region FilesDir
    //<gridControl1>
    /*
     ~The Directories class implements the IRelationList interface to provide master-detail relationships on the data source level:
     */
    public class Directories : ArrayList, DevExpress.Data.IRelationList {
        public Directories(string root) {
            string[] s = System.IO.Directory.GetDirectories(root);
            for (int i = 0; i < s.Length; i++)
                Add(new Directory(i, s[i]));
        }

        //IRelationList
        string IRelationList.GetRelationName(int index, int relationIndex) {
            return (relationIndex == 0 ? Properties.Resources.Directories : Properties.Resources.Files);
        }

        int IRelationList.RelationCount {
            get { return 2; }
        }

        bool IRelationList.IsMasterRowEmpty(int index, int relationIndex) {
            return this[index].MasterDetail(relationIndex);
        }

        IList IRelationList.GetDetailList(int index, int relationIndex) {
            IList list;
            string rootDir = ((Directory)this[index]).FullName;
            if (relationIndex == 0)
                list = new Directories(rootDir);
            else
                list = new Files(rootDir);
            return (list.Count > 0 ? list : null);
        }
        //IRelationList end

        public virtual new Directory this[int index] {
            get { return (Directory)(base[index]); }
        }
    }

    public class Files : ArrayList {
        public Files(string dir) {
            string[] s = System.IO.Directory.GetFiles(dir);
            for (int i = 0; i < s.Length; i++)
                Add(new File(s[i]));
        }
    }
    //</gridControl1>


    public class Directory {
        private int fid;
        private string fname;
        private int ffilesCount = -1;
        private int fchildDirCount = -1;
        internal System.IO.DirectoryInfo dInfo;

        internal Directory(int fid, string fname) {
            this.fid = fid;
            this.fname = fname;
            dInfo = new System.IO.DirectoryInfo(this.fname);
        }

        public bool MasterDetail(int relationIndex) {
            bool ret = true;
            try {
                if (relationIndex == 0)
                    ret = !(System.IO.Directory.GetDirectories(fname).Length > 0);
                else
                    ret = !(System.IO.Directory.GetFiles(fname).Length > 0);
            }
            catch { }
            return ret;
        }

        private int ID {
            get { return fid; }
        }

        public string FullName {
            get { return fname; }
        }
        public string Name {
            get { return dInfo.Name; }
        }
        public DateTime CreationTime {
            get { return dInfo.CreationTime; }
        }
        public int FilesCount {
            get {
                if (ffilesCount == -1) {
                    ffilesCount = 0;
                    try {
                        ffilesCount = System.IO.Directory.GetFiles(fname).Length;
                    }
                    catch { }
                }
                return ffilesCount;
            }
        }
        public int ChildDirCount {
            get {
                if (fchildDirCount == -1) {
                    fchildDirCount = 0;
                    try {
                        fchildDirCount = System.IO.Directory.GetDirectories(fname).Length;
                    }
                    catch { }
                }
                return fchildDirCount;
            }
        }
        public string Attributes {
            get { return MyFileAttributes.StringFileAttributes(dInfo.Attributes); }
        }
    }

    public class File {
        internal System.IO.FileInfo fInfo;
        internal File(string fname) {
            fInfo = new System.IO.FileInfo(fname);
        }
        public string Name {
            get { return fInfo.Name; }
        }
        public long Length {
            get { return fInfo.Length; }
        }
        public DateTime CreationTime {
            get { return fInfo.CreationTime; }
        }
        public DateTime LastWriteTime {
            get { return fInfo.LastWriteTime; }
        }
        public DateTime LastAccessTime {
            get { return fInfo.LastAccessTime; }
        }
        public string Attributes {
            get { return MyFileAttributes.StringFileAttributes(fInfo.Attributes); }
        }
    }

    internal class MyFileAttributes {
        internal static string StringFileAttributes(System.IO.FileAttributes fa) {
            string s = "";
            if ((System.IO.FileAttributes.Archive & fa) != 0)
                s += "-A";
            if ((System.IO.FileAttributes.Compressed & fa) != 0)
                s += "-C";
            if ((System.IO.FileAttributes.Normal & fa) != 0)
                s += "-N";
            if ((System.IO.FileAttributes.Hidden & fa) != 0)
                s += "-H";
            if ((System.IO.FileAttributes.ReadOnly & fa) != 0)
                s += "-RO";
            if ((System.IO.FileAttributes.System & fa) != 0)
                s += "-S";
            if ((System.IO.FileAttributes.Temporary & fa) != 0)
                s += "-Tmp";
            s += "-";
            return s;
        }
    }

    #endregion
    #region GridFolder
    //<gridControl2>
    public enum FileCollectionItemType { Up = 0, File, Directory };
    class FileCollection : ArrayList {
        string ffilePath;
        public FileCollection(string ffilePath) {
            FilePath = ffilePath;
        }
        public string FilePath {
            get { return ffilePath; }
            set {
                if (FilePath == value) return;
                Clear();
                this.ffilePath = value;
                if (System.IO.Path.GetFileName(value) != string.Empty)
                    Add(new FileCollectionItem(FileCollectionItemType.Up, value));
                try {
                    string[] dirs = System.IO.Directory.GetDirectories(ffilePath);
                    for (int i = 0; i < dirs.Length; i++)
                        Add(new FileCollectionItem(FileCollectionItemType.Directory, dirs[i]));
                    string[] files = System.IO.Directory.GetFiles(ffilePath);
                    for (int i = 0; i < files.Length; i++)
                        Add(new FileCollectionItem(FileCollectionItemType.File, files[i]));
                }
                catch {
                }
            }
        }
        public new FileCollectionItem this[int index] { get { return base[index] as FileCollectionItem; } }
        public int IndexOf(string path) {
            for (int i = 0; i < Count; i++)
                if (path.Equals(this[i].FullName)) return i;
            return -1;
        }
    }
    public class FileCollectionItem {
        FileCollectionItemType fitemType;
        string fname, fdisplayName;
        long ffileSize;
        DateTime fmodified;

        public FileCollectionItem(FileCollectionItemType fitemType, string fname) {
            this.fitemType = fitemType;
            this.fname = fname;
            this.fdisplayName = ItemType != FileCollectionItemType.Up ? System.IO.Path.GetFileName(fname) : "..";
            this.ffileSize = -1;
        }
        public FileCollectionItemType ItemType { get { return this.fitemType; } }
        public string Name { get { return this.fdisplayName; } }
        public string FullName {
            get {
                return ItemType == FileCollectionItemType.Up ?
                    System.IO.Path.GetDirectoryName(this.fname) : this.fname;
            }
        }
        public string DirectoryName {
            get {
                return ItemType != FileCollectionItemType.Up ?
                    System.IO.Path.GetDirectoryName(this.fname) : this.fname;
            }
        }
        public int ImageIndex { get { return (int)ItemType - 1; } }
        public long Size {
            get {
                if (ItemType == FileCollectionItemType.File) {
                    UpdateFileInfo();
                    return this.ffileSize;
                }
                else return 0;
            }
        }
        public DateTime Modified {
            get {
                if (ItemType == FileCollectionItemType.File) {
                    UpdateFileInfo();
                    return this.fmodified;
                }
                else {
                    UpdateDirInfo();
                    return this.fmodified;
                }
            }
        }
        void UpdateFileInfo() {
            if (this.ffileSize >= 0) return;
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(this.fname);
            this.ffileSize = fileInfo.Length;
            this.fmodified = fileInfo.LastWriteTime;
        }
        void UpdateDirInfo() {
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(this.fname);
            this.fmodified = dirInfo.LastWriteTime;
        }
    }
    //</gridControl2>
    #endregion
}
