using System;
using System.IO;
using System.Web;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class ServerSideResizing : System.Web.UI.Page {
    const string ImageFileName = @"~\ASPxBinaryImage\Images\people_1200px.jpg";

    protected void Page_Load(object sender, EventArgs e) {
        BinaryImage.ContentBytes = GetByteArrayFromImage();

        string value = (string)ComboBoxSize.Value;
        BinaryImage.Width = Convert.ToInt32(value.Split('x')[0]);
        BinaryImage.Height = Convert.ToInt32(value.Split('x')[1]);

        BinaryImage.ImageSizeMode = (ImageSizeMode)ComboBoxImageSizeMode.Value;
    }

    protected byte[] GetByteArrayFromImage() {
        byte[] byteArray = null;
        using(FileStream stream = new FileStream(Server.MapPath(ImageFileName), FileMode.Open, FileAccess.Read)) {
            byteArray = new byte[stream.Length];
            stream.Read(byteArray, 0, (int)stream.Length);
        }
        return byteArray;
    }
}
