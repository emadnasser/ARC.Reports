using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using DevExpress.BarCodes;
using System.Net;
using DevExpress.Docs.Demos;
using System.Drawing.Imaging;

public partial class BarCode_BarCodeVisualization : System.Web.UI.Page {
    string[] FontFamilyNames = new string[] {
            "Arial",
            "Arial Black",
            "Comic Sans MS",
            "Courier New",
            "Georgia",
            "Lucida Sans Unicode",
            "Times New Roman",
            "Trebuchet MS",
            "Verdana",
            "MS Mincho",
            "MS PMincho",
            "SimSun",
            "SimSun-ExtB",
            "Calibri",
        };

    BarCode barCode;

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack && Request.QueryString.Count == 0)
            GenerateContent();

        if(Request.QueryString.Count < 1)
            return;
        if (Request.QueryString[0].StartsWith("description")) {
            GenerateBarCodeDescription();
            return;
        }
        if(!Request.QueryString[0].StartsWith("image"))
            return;

        if (Request.QueryString.Count > 1) {
            BarCodeParams barCodeParams = FillBarCodeParams();
            UpdateBarCodeState(barCodeParams);
        }

        ImageConverter converter = new ImageConverter();
        byte[] image = null;
        if(Session["BarCodeImage"] == null) {
            Bitmap emptyImage = new Bitmap(1, 1);
            image = (byte[])converter.ConvertTo(emptyImage, typeof(byte[]));
        } else
            image = (byte[])converter.ConvertTo(Session["BarCodeImage"], typeof(byte[]));

        Response.StatusCode = (int)HttpStatusCode.OK;
        Response.ContentType = "image/png";
        Response.BinaryWrite(image);
        Response.End();
    }
    void GenerateBarCodeDescription() {
        string cbBarCode = Request.Params["cbBarCode"];
        Symbology symbology = String.IsNullOrEmpty(cbBarCode) ? Symbology.Codabar : StringToSymology(cbBarCode);
        BarCodeGenerator barCodeGenerator = new BarCodeGenerator(symbology, "");
        barCode = barCodeGenerator.Generate();
        string descriptionHTML = @"<span style=""font:13px Tahoma, Geneva, sans-serif;"">" + barCodeGenerator.Description + "</span>";
        Response.StatusCode = (int)HttpStatusCode.OK;
        Response.ContentType = "text/html";
        Response.Write(descriptionHTML);
        Response.End();
    }
    void GenerateContent() {
        GenerateBarCodeList();
        GenerateFontNamesLists();
        clrBarCodeForeColor.Color = Color.Black;
        clrBarCodeBackColor.Color = Color.White;
        clrBottomCaptionForeColor.Color = Color.Black;
        clrTopCaptionForeColor.Color = Color.Black;
        UpdateBarCodeState();
    }
    void GenerateBarCodeList() {
        string[] symbologyList = Enum.GetNames(typeof(Symbology));
        foreach(string barCodeType in symbologyList)
            ComboBoxBarCode.Items.Add(barCodeType);
        ComboBoxBarCode.SelectedIndex = 0;
    }
    void GenerateFontNamesLists() {
        foreach(string fontName in FontFamilyNames) {
            cbFontName.Items.Add(fontName);
            cbTopCaptionFontName.Items.Add(fontName);
            cbBottomCaptionFontName.Items.Add(fontName);
        }
    }
    BarCodeParams FillBarCodeParams() {
        BarCodeParams barCodeParams = new BarCodeParams();
        string cbBarCode = Request.Params["cbBarCode"];
        string chkViewTextValue = Request.Params["chkViewText"];
        string txtBarCodeTextValue = Request.Params["txtBarCodeText"];
        string cbTextVertAlignValue = Request.Params["cbTextVertAlign"];
        string cbTextHorzAlignValue = Request.Params["cbTextHorzAlign"];
        string cbFontNameValue = Request.Params["cbFontName"];
        string spnBarCodeAngleValue = Request.Params["spnBarCodeAngle"];
        string clrBarCodeForeColorValue = Request.Params["clrBarCodeForeColor"];
        string clrBarCodeBackColorValue = Request.Params["clrBarCodeBackColor"];

        string chkTopCaptionValue = Request.Params["chkTopCaption"];
        string txtTopCaptionTextValue = Request.Params["txtTopCaptionText"];
        string cbTopCaptionAlignmentValue = Request.Params["cbTopCaptionAlignment"];
        string clrTopCaptionForeColorValue = Request.Params["clrTopCaptionForeColor"];
        string cbTopCaptionFontNameValue = Request.Params["cbTopCaptionFontName"];

        string chkBottomCaptionValue = Request.Params["chkBottomCaption"];
        string txtBottomCaptionTextValue = Request.Params["txtBottomCaptionText"];
        string cbBottomCaptionAlignmentValue = Request.Params["cbBottomCaptionAlignment"];
        string clrBottomCaptionForeColorValue = Request.Params["clrBottomCaptionForeColor"];
        string cbBottomCaptionFontNameValue = Request.Params["cbBottomCaptionFontName"];

        barCodeParams.Symbology = cbBarCode;
        barCodeParams.Text = (txtBarCodeTextValue == "null") ? "" : txtBarCodeTextValue;
        barCodeParams.ShowText = (String.IsNullOrEmpty(chkViewTextValue)) ? false : Convert.ToBoolean(chkViewTextValue);
        barCodeParams.VertAlign = cbTextVertAlignValue;
        barCodeParams.HorzAlign = cbTextHorzAlignValue;
        barCodeParams.TextFont = cbFontNameValue;
        barCodeParams.BarCodeAngle = Convert.ToInt32(spnBarCodeAngleValue);
        barCodeParams.ForeColor = clrBarCodeForeColorValue;
        barCodeParams.BackColor = clrBarCodeBackColorValue;

        barCodeParams.ShowTopCaption = (String.IsNullOrEmpty(chkTopCaptionValue)) ? false : Convert.ToBoolean(chkTopCaptionValue);
        barCodeParams.TopCaptionText = txtTopCaptionTextValue;
        barCodeParams.TopCaptionAlignment = cbTopCaptionAlignmentValue;
        barCodeParams.TopCaptionForeColor = clrTopCaptionForeColorValue;
        barCodeParams.TopCaptionFont = cbTopCaptionFontNameValue;

        barCodeParams.ShowBottomCaption = (String.IsNullOrEmpty(chkBottomCaptionValue)) ? false : Convert.ToBoolean(chkBottomCaptionValue);
        barCodeParams.BottomCaptionText = txtBottomCaptionTextValue;
        barCodeParams.BottomCaptionAlignment = cbBottomCaptionAlignmentValue;
        barCodeParams.BottomCaptionForeColor = clrBottomCaptionForeColorValue;
        barCodeParams.BottomCaptionFont = cbBottomCaptionFontNameValue;

        return barCodeParams;
    }
    Symbology StringToSymology(string symbologyName) {
        return (Symbology)Enum.Parse(typeof(Symbology), symbologyName);
    }
    void UpdateBarCodeState(BarCodeParams barCodeParams) {
        Symbology symbology = StringToSymology(barCodeParams.Symbology);
        BarCodeGenerator barCodeGenerator = new BarCodeGenerator(symbology, barCodeParams.Text);
        barCodeGenerator.ViewText = barCodeParams.ShowText;
        barCode = barCodeGenerator.Generate();

        if (barCodeParams.ShowText)
            UpdateBarCodeText(barCodeParams);
        UpdateBarCode(barCodeParams);
        if (barCodeParams.ShowTopCaption)
            UpdateTopCaption(barCodeParams);
        if (barCodeParams.ShowBottomCaption)
            UpdateBottomCaption(barCodeParams);

        try {
            Bitmap img = barCode.BarCodeImage;
            Session["BarCodeImage"] = CreateThumbnailImage(img);
        }
        catch (Exception ex) {
            ShowErrorMessage(ex.Message);
        }
    }
    void UpdateBarCodeState() {
        Symbology symbology = StringToSymology(ComboBoxBarCode.Value as String);
        BarCodeGenerator barCodeGenerator = new BarCodeGenerator(symbology, "");
        barCode = barCodeGenerator.Generate();

        using (Bitmap img = barCode.BarCodeImage) {
            Session["BarCodeImage"] = CreateThumbnailImage(img);
        }
    }
    object CreateThumbnailImage(Bitmap img) {
        const int maxWidth = 600;
        if(img.Width < maxWidth)
            return img;
        System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
        int height = (int)(img.Height * ((1.0 * maxWidth) / img.Width));
        return img.GetThumbnailImage(maxWidth, height, myCallback, IntPtr.Zero);
    }
    public bool ThumbnailCallback() {
        return false;
    }
    void ShowErrorMessage(string message) {
        System.Drawing.Image img = new Bitmap(100, 100);
        Graphics drawing = Graphics.FromImage(img);
        Font font = new Font("Tahoma", 10);
        Size textSize = drawing.MeasureString(message, font).ToSize();
        Rectangle textRect = new Rectangle(new Point(), textSize);
        img.Dispose();
        drawing.Dispose();
        img = new Bitmap(textSize.Width, textSize.Height);
        drawing = Graphics.FromImage(img);
        drawing.Clear(Color.White);
        drawing.DrawString(message, font, Brushes.Red, 0, 0);
        Session["BarCodeImage"] = img;
    }
    void UpdateBarCodeText(BarCodeParams barCodeParams) {
        barCode.CodeTextHorizontalAlignment = (StringAlignment)Enum.Parse(typeof(StringAlignment), barCodeParams.HorzAlign);
        barCode.CodeTextVerticalAlignment = (StringAlignment)Enum.Parse(typeof(StringAlignment), barCodeParams.VertAlign);
        barCode.CodeTextFont = new Font(barCodeParams.TextFont, 12);
    }
    void UpdateBarCode(BarCodeParams barCodeParams) {
        barCode.RotationAngle = barCodeParams.BarCodeAngle;
        barCode.ForeColor = ColorTranslator.FromHtml(barCodeParams.ForeColor);
        barCode.BackColor = ColorTranslator.FromHtml(barCodeParams.BackColor);
    }
    void UpdateTopCaption(BarCodeParams barCodeParams) {
        barCode.TopCaption.Text = barCodeParams.TopCaptionText;
        barCode.TopCaption.HorizontalAlignment = (StringAlignment)Enum.Parse(typeof(StringAlignment), barCodeParams.TopCaptionAlignment);
        barCode.TopCaption.ForeColor = ColorTranslator.FromHtml(barCodeParams.TopCaptionForeColor);
        barCode.TopCaption.Font = new Font(barCodeParams.TopCaptionFont, 12);
    }
    void UpdateBottomCaption(BarCodeParams barCodeParams) {
        barCode.BottomCaption.Text = barCodeParams.BottomCaptionText;
        barCode.BottomCaption.HorizontalAlignment = (StringAlignment)Enum.Parse(typeof(StringAlignment), barCodeParams.BottomCaptionAlignment);
        barCode.BottomCaption.ForeColor = ColorTranslator.FromHtml(barCodeParams.BottomCaptionForeColor);
        barCode.BottomCaption.Font = new Font(barCodeParams.BottomCaptionFont, 12);
    }
}
public class BarCodeParams {
    public string Symbology { get; set; }
    public bool ShowText { get; set; }
    public string Text { get; set; }
    public string VertAlign { get; set; }
    public string HorzAlign { get; set; }
    public string TextFont { get; set; }
    public int BarCodeAngle { get; set; }
    public string ForeColor { get; set; }
    public string BackColor { get; set; }

    public bool ShowTopCaption { get; set; }
    public string TopCaptionText { get; set; }
    public string TopCaptionAlignment { get; set; }
    public string TopCaptionFont { get; set; }
    public string TopCaptionForeColor { get; set; }

    public bool ShowBottomCaption { get; set; }
    public string BottomCaptionText { get; set; }
    public string BottomCaptionAlignment { get; set; }
    public string BottomCaptionFont { get; set; }
    public string BottomCaptionForeColor { get; set; }}
