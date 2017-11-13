using System;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Storage;

namespace MapDemo {
    public class DemoValuesProvider {
        const string key = "AkF9kodvrCOg7Ke-UFIcGcTcpKoj6vURAbLTgeBJxrgCeu_TLGMVWtl9tdJPeNvG";
        public string DevexpressBingKey { get { return key; } }
    }
    public static class DataLoader {
        public static XDocument LoadFromXmlResource(string path) {
            path = path.Replace('\\', '/');
            path = path.TrimStart('/');
            string uriPath = "ms-appx:///" + path;
            Task<StorageFile> operation = StorageFile.GetFileFromApplicationUriAsync(new Uri(uriPath)).AsTask<StorageFile>();
            StorageFile file = operation.Result;
            Task<string> fileReadingTask = FileIO.ReadTextAsync(file).AsTask<string>();
            string fileContent = fileReadingTask.Result;
            XDocument result = XDocument.Parse(fileContent, LoadOptions.None);
            return result;
        }
    }
}
