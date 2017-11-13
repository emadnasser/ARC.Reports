using System;
using System.Web.UI;
using DevExpress.Web;

public partial class FileManager_CustomThumbnails : Page {
    protected void Page_Load(object sender, EventArgs e) {
    }

    public void fileManager_CustomThumbnail(object sender, FileManagerThumbnailCreateEventArgs e) {
        switch(((FileManagerFile)e.Item).Extension) {
            case ".avi":
                e.ThumbnailImage.Url = "Images/movie.png";
                break;
            case ".txt":
                e.ThumbnailImage.Url = "Images/txt.png";
                break;
            case ".mp3":
                e.ThumbnailImage.Url = "Images/music.png";
                break;
            case ".xml":
                e.ThumbnailImage.Url = "Images/code.png";
                break;
        }
    }
}
