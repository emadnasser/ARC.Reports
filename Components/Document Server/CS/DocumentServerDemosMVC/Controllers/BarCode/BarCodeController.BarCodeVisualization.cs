using DevExpress.Web;
using DevExpress.Web.Internal;
using System.Web.Mvc;
using System.Web.UI;
using System.IO;
using System;
using DevExpress.XtraRichEdit;
using System.Collections.Generic;
using DevExpress.BarCodes;
using DevExpress.Docs.Demos;
using System.Drawing;

namespace DevExpress.Web.Demos {
    public partial class BarCodeController : DemoController {
        public ActionResult BarCodeVisualization() {
            BarCodeVisualizationModel model = CreateModel();
            model.SetDescription(BarCodeGenerator.GetBarCodeDescription(model.BarCode));
            return DemoView("BarCodeVisualization", model);
        }
        public ActionResult PreviewBarCode(BarCodeVisualizationModel model) {
            Image thumbnail = null;
            try {
                BarCode barCode = GenerateBarCode(model);
                thumbnail = CreateThumbnailImage(barCode.BarCodeImage);
            }
            catch (Exception ex) {
                thumbnail = ShowErrorMessage(ex.Message);
            }
            if (thumbnail == null)
                return new EmptyResult();
            ImageConverter converter = new ImageConverter();
            byte[] content = (byte[])converter.ConvertTo(thumbnail, typeof(byte[]));
            return new FileContentResult(content, "image/png");
        }
        Image ShowErrorMessage(string message) {
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
            return img;
        }
        public string UpdateDesctiptionBarCode(BarCodeVisualizationModel model) {
            return BarCodeGenerator.GetBarCodeDescription(model.BarCode);
        }
        BarCode GenerateBarCode(BarCodeVisualizationModel model) {
            BarCodeGenerator barCodeGenerator = new BarCodeGenerator(model.BarCode, model.BarCodeText);
            barCodeGenerator.ViewText = model.ShowViewText;
            BarCode barCode = barCodeGenerator.Generate();
            if (model.ShowViewText) {
                barCode.CodeTextHorizontalAlignment = model.HorzAlign;
                barCode.CodeTextVerticalAlignment = model.VertAlign;
                barCode.CodeTextFont = new Font(model.FontName, 12);
            }
            barCode.RotationAngle = model.BarCodeAngle;
            barCode.ForeColor = model.BarCodeForeColor;
            barCode.BackColor = model.BarCodeBackColor;
            if (model.ShowTopCaption) {
                barCode.TopCaption.Text = model.TopCaptionText;
                barCode.TopCaption.HorizontalAlignment = model.TopCaptionAlignment;
                barCode.TopCaption.ForeColor = model.TopCaptionForeColor;
                barCode.TopCaption.Font = new Font(model.TopCaptionFontName, 12);
            }
            if (model.ShowBottomCaption) {
                barCode.BottomCaption.Text = model.BottomCaptionText;
                barCode.BottomCaption.HorizontalAlignment = model.BottomCaptionAlignment;
                barCode.BottomCaption.ForeColor = model.BottomCaptionForeColor;
                barCode.BottomCaption.Font = new Font(model.BottomCaptionFontName, 12);
            }
            return barCode;
        }
        Image CreateThumbnailImage(Bitmap img) {
            const int maxWidth = 600;
            if (img.Width < maxWidth)
                return img;
            System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(() => { return false; });
            int height = (int)(img.Height * ((1.0 * maxWidth) / img.Width));
            return img.GetThumbnailImage(maxWidth, height, myCallback, IntPtr.Zero);
        }
        public ActionResult ExportBarCodeVisualizationTo(BarCodeVisualizationModel model) {
            return new EmptyResult();
        }
        BarCodeVisualizationModel CreateModel() {
            BarCodeVisualizationModel model = new BarCodeVisualizationModel();
            return model;
        }
    }
}
