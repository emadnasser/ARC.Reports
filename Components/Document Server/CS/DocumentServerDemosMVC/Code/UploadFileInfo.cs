namespace DevExpress.Web.Demos {
    public class UploadFileInfo {
        public UploadFileInfo(string name, string path, string url) {
            Name = name;
            Path = path;
            Url = url;
        }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Url { get; set; }
    }
}
