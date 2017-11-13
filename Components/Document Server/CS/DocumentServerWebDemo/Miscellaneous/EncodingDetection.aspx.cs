using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using DevExpress.Docs.Text;
using System.Text;
using DevExpress.Web;
using DevExpress.Web.Internal;

public partial class Miscellaneous_EncodingDetection : System.Web.UI.Page {
    string[] encodingFiles = {
            "english.txt",
            "german.txt",
            "spanish.txt",
            "russian.txt",
            "greek.txt",
            "chinese.txt",
            "japanese.txt"};

    protected void Page_Load(object sender, EventArgs e) {
        if (IsCallback)
            return;
        cbLanguage.Items.AddRange(encodingFiles);
        LoadFile(cbLanguage.Items[0].Text);
        UpdateFromSession();
    }
    protected void ASPxUploadControl1_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e) {
        UploadedFile file = ASPxUploadControl1.UploadedFiles[0];
        Session["CurrentFile"] = e.UploadedFile.FileName;
        using (Stream stream = file.FileContent)
            ReadText(stream);
        byte[] bytes = file.FileBytes;
        DecodeText(bytes);
    }
    protected void CallbackPanel_Callback(object source, CallbackEventArgsBase e) {
        UpdateFromSession();
    }
    void UpdateFromSession() {
        memoNoEncoding.Text = Session["NoEncodingDetect"] as string;
        memoEncoding.Text = Session["EncodingDetect"] as string;
        lblEncoding.Text = Session["Encoding"] as string;
        lblCurrentFile.Text = Session["CurrentFile"] as string;
    }
    protected void cbLanguage_SelectedIndexChanged(object sender, EventArgs e) {
        if (cbLanguage.SelectedIndex != -1) {
            string fileName = cbLanguage.SelectedItem.Text;
            LoadFile(fileName);
        }
    }

    void LoadFile(string fileName) {
        string path = Server.MapPath("~/App_Data/EncodingFiles/") + fileName;
        Session["CurrentFile"] = fileName;
        LoadFileNoDetection(path);
        LoadFileWithDetection(path);
    }
    void LoadFileNoDetection(string path) {
        Session["NoEncodingDetect"] = File.ReadAllText(path);
    }
    void LoadFileWithDetection(string path) {
        byte[] bytes = File.ReadAllBytes(path);
        DecodeText(bytes);
    }
    void DecodeText(byte[] bytes) {
        EncodingDetector detector = new EncodingDetector();
        Encoding encoding = detector.Detect(bytes);
        if (encoding == null)
            encoding = Encoding.Default;
        Session["Encoding"] = encoding.EncodingName + " [" + encoding.BodyName + "]";
        Session["EncodingDetect"] = encoding.GetString(bytes);
    }
    void ReadText(Stream stream) {
        StreamReader reader = new StreamReader(stream);
        Session["NoEncodingDetect"] = reader.ReadToEnd();
    }
}
