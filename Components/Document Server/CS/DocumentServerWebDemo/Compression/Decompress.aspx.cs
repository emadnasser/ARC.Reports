using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Compression;
using System.IO;
using System.Net;
using System.Text;

public partial class Compression_Decompress : System.Web.UI.Page {
    const string UploadDirectory = "~/UploadData/";
    protected void Page_Load(object sender, EventArgs e) {
        if(Request.QueryString.Count == 0)
            return;
        string itemName = Request.QueryString["itemName"];
        string fileName = Request.QueryString["decompress"];
        if(String.IsNullOrEmpty(itemName) || String.IsNullOrEmpty(fileName))
            return;
        string fullZipFilePath = Path.Combine(MapPath(UploadDirectory), fileName);
        ZipArchive zipArchive = ZipArchive.Read(fullZipFilePath);
        UnzipItem unzipItem = zipArchive[itemName] as UnzipItem;
        if(unzipItem == null)
            return;
        if(unzipItem.UncompressedSize > 10 * 1024 * 1024)
            Response.BinaryWrite(Encoding.ASCII.GetBytes("Uncompressed file size exceeds the limit (10 MB)"));
        else {
            try {
                unzipItem.Extract(Response.OutputStream);
            } catch(Exception ex) {
                string error = String.Format("Can't decompress file.\n{0}", ex.Message);
                Response.BinaryWrite(Encoding.ASCII.GetBytes(error));
            }
        }
        Response.StatusCode = (int)HttpStatusCode.OK;
        Response.ContentType = "application/octet-stream";
        Response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}", GetFileName(itemName)));
        Response.End();
    }
    protected void UploadControl_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
        ZipArchive zipArchive = new ZipArchive();
        zipArchive = ZipArchive.Read(e.UploadedFile.FileContent);
        string fileName = Path.Combine(MapPath(UploadDirectory), e.UploadedFile.FileName);
        e.UploadedFile.SaveAs(fileName);
        string urlPath = ResolveClientUrl(UploadDirectory);
        foreach(ZipItem item in zipArchive) {
            if((item.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                continue;
            if(item.EncryptionType != EncryptionType.None) {
                e.ErrorText = "Encrypted archives are not processed.";
                e.IsValid = false;
                return;
            }
            string file = string.Format("{0} ({1}KB)", item.Name, item.UncompressedSize / 1024);
            string fileUri = String.Format("Decompress.aspx?decompress={0}&itemName={1}", Uri.EscapeDataString(e.UploadedFile.FileName), Uri.EscapeDataString(item.Name));
            e.CallbackData += "#" + file + "|" + fileUri;
        }
    }
    string GetFileName(string itemName) {
        int indx = itemName.LastIndexOf('/');
        if(indx < 0)
            return itemName;
        return itemName.Substring(indx + 1);
    }
}
