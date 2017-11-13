using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Web;
using DevExpress.Web.Demos;
using DevExpress.Utils;

public class UploadedFilesStorage {
    public string Path { get; set; }
    public string Key { get; set; }
    public DateTime LastUsageTime { get; set; }

    public IList<UploadedFileInfo> Files { get; set; }
}

public class UploadedFileInfo {
    public string UniqueFileName { get; set; }
    public string OriginalFileName { get; set; }
    public string FilePath { get; set; }
    public string FileSize { get; set; }
}

public partial class UploadControl_UploadAndSubmit : System.Web.UI.Page {
    protected string SubmissionID {
        get {
            return HiddenField.Get("SubmissionID").ToString();
        }
        set {
            HiddenField.Set("SubmissionID", value);
        }
    }
    UploadedFilesStorage UploadedFilesStorage {
        get { return UploadControlHelper.GetUploadedFilesStorageByKey(SubmissionID); }
    }

    protected void ProcessSubmit(string description, List<UploadedFileInfo> fileInfos) {
        DescriptionLabel.Value = Server.HtmlEncode(description);

        foreach(UploadedFileInfo fileInfo in fileInfos) {
            // process uploaded files here
            //byte[] fileContent = File.ReadAllBytes(fileInfo.FilePath);
        }

        SubmittedFilesListBox.DataSource = fileInfos;
        SubmittedFilesListBox.DataBind();

        FormLayout.FindItemOrGroupByName("ResultGroup").Visible = true;
    }

    protected void Page_PreLoad(object sender, EventArgs e) {
        UploadControlHelper.RemoveOldStorages();
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            SubmissionID = UploadControlHelper.GenerateUploadedFilesStorageKey();
            UploadControlHelper.AddUploadedFilesStorage(SubmissionID);
        }

        FormLayout.FindItemOrGroupByName("ResultGroup").Visible = false;
    }

    protected void DocumentsUploadControl_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e) {
        bool isSubmissionExpired = false;
        if(UploadedFilesStorage == null) {
            isSubmissionExpired = true;
            UploadControlHelper.AddUploadedFilesStorage(SubmissionID);
        }
        UploadedFileInfo tempFileInfo = UploadControlHelper.AddUploadedFileInfo(SubmissionID, e.UploadedFile.FileName);

        e.UploadedFile.SaveAs(tempFileInfo.FilePath);
                
        if(e.IsValid)
            e.CallbackData = tempFileInfo.UniqueFileName + "|" + isSubmissionExpired;
    }

    protected void SubmitButton_Click(object sender, EventArgs e) {
        ValidateInputData();

        List<UploadedFileInfo> resultFileInfos = new List<UploadedFileInfo>();
        string description = DescriptionTextBox.Text;
        bool allFilesExist = true;

        if(UploadedFilesStorage == null)
            UploadedFilesTokenBox.Tokens = new TokenCollection();

        foreach(string fileName in UploadedFilesTokenBox.Tokens) {
            UploadedFileInfo demoFileInfo = UploadControlHelper.GetDemoFileInfo(SubmissionID, fileName);
            FileInfo fileInfo = new FileInfo(demoFileInfo.FilePath);

            if(fileInfo.Exists) {
                demoFileInfo.FileSize = Utils.FormatSize(fileInfo.Length);
                resultFileInfos.Add(demoFileInfo);
            }
            else
                allFilesExist = false;
        }

        if(allFilesExist && resultFileInfos.Count > 0) {
            ProcessSubmit(description, resultFileInfos);

            UploadControlHelper.RemoveUploadedFilesStorage(SubmissionID);

            ASPxEdit.ClearEditorsInContainer(FormLayout, true);
        }
        else {
            UploadedFilesTokenBox.ErrorText = "Submit failed because files have been removed from the server due to the 5 minute timeout.";
            UploadedFilesTokenBox.IsValid = false;
        }
    }
    void ValidateInputData() {
        bool isInvalid = string.IsNullOrEmpty(DescriptionTextBox.Text) || UploadedFilesTokenBox.Tokens.Count == 0;
        if(isInvalid)
            throw new Exception("Invalid input data");
    }
}

public static class UploadControlHelper {
    const int DisposeTimeout = 5;
    const string FolderKey = "UploadDirectory";
    const string TempDirectory = "~/UploadControl/Temp/";
    static readonly object storageListLocker = new object();

    static HttpContext Context { get { return HttpContext.Current; } }
    static string RootDirectory { get { return Context.Request.MapPath(TempDirectory); } }

    static IList<UploadedFilesStorage> uploadedFilesStorageList;
    static IList<UploadedFilesStorage> UploadedFilesStorageList {
        get {
            return uploadedFilesStorageList;
        }
    }

    static UploadControlHelper() {
        uploadedFilesStorageList = new List<UploadedFilesStorage>();
    }

    static string CreateTempDirectoryCore() {
        string uploadDirectory = Path.Combine(RootDirectory, Path.GetRandomFileName());
        Directory.CreateDirectory(uploadDirectory);

        return uploadDirectory;
    }
    public static UploadedFilesStorage GetUploadedFilesStorageByKey(string key) {
        lock(storageListLocker) {
            return GetUploadedFilesStorageByKeyUnsafe(key);
        }
    }
    static UploadedFilesStorage GetUploadedFilesStorageByKeyUnsafe(string key) {
        UploadedFilesStorage storage = UploadedFilesStorageList.Where(i => i.Key == key).SingleOrDefault();
        if(storage != null)
            storage.LastUsageTime = DateTime.Now;
        return storage;
    }
    public static string GenerateUploadedFilesStorageKey() {
        return Guid.NewGuid().ToString("N");
    }
    public static void AddUploadedFilesStorage(string key) {
        lock(storageListLocker) {
            UploadedFilesStorage storage = new UploadedFilesStorage {
                Key = key,
                Path = CreateTempDirectoryCore(),
                LastUsageTime = DateTime.Now,
                Files = new List<UploadedFileInfo>()
            };
            UploadedFilesStorageList.Add(storage);
        }
    }
    public static void RemoveUploadedFilesStorage(string key) {
        lock(storageListLocker) {
            UploadedFilesStorage storage = GetUploadedFilesStorageByKeyUnsafe(key);
            if(storage != null) {
                Directory.Delete(storage.Path, true);
                UploadedFilesStorageList.Remove(storage);
            }
        }
    }
    public static void RemoveOldStorages() {
        if(!Directory.Exists(RootDirectory))
            Directory.CreateDirectory(RootDirectory);

        lock(storageListLocker) {
            string[] existingDirectories = Directory.GetDirectories(RootDirectory);
            foreach(string directoryPath in existingDirectories) {
                UploadedFilesStorage storage = UploadedFilesStorageList.Where(i => i.Path == directoryPath).SingleOrDefault();
                if(storage == null || (DateTime.Now - storage.LastUsageTime).TotalMinutes > DisposeTimeout) {
                    Directory.Delete(directoryPath, true);
                    if(storage != null)
                        UploadedFilesStorageList.Remove(storage);
                }
            }
        }
    }
    public static UploadedFileInfo AddUploadedFileInfo(string key, string originalFileName) {
        UploadedFilesStorage currentStorage = GetUploadedFilesStorageByKey(key);
        UploadedFileInfo fileInfo = new UploadedFileInfo {
            FilePath = Path.Combine(currentStorage.Path, Path.GetRandomFileName()),
            OriginalFileName = originalFileName,
            UniqueFileName = GetUniqueFileName(currentStorage, originalFileName)
        };
        currentStorage.Files.Add(fileInfo);

        return fileInfo;
    }
    public static UploadedFileInfo GetDemoFileInfo(string key, string fileName) {
        UploadedFilesStorage currentStorage = GetUploadedFilesStorageByKey(key);
        return currentStorage.Files.Where(i => i.UniqueFileName == fileName).SingleOrDefault();
    }
    public static string GetUniqueFileName(UploadedFilesStorage currentStorage, string fileName) {
        string baseName = Path.GetFileNameWithoutExtension(fileName);
        string ext = Path.GetExtension(fileName);
        int index = 1;

        while(currentStorage.Files.Any(i => i.UniqueFileName == fileName))
            fileName = string.Format("{0} ({1}){2}", baseName, index++, ext);

        return fileName;
    }
}
