using System;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Menu;
using DevExpress.XtraCharts.Printing;
using DevExpress.XtraPrinting;

namespace DevExpress.XtraCharts.Demos {

    public class TutorialControl : TutorialControlBase {
        class ImageFormatInfo {
            ImageCodecInfo imageCodecInfo;
            ImageFormat imageFormat;

            public ImageCodecInfo ImageCodecInfo { get { return imageCodecInfo; } }
            public ImageFormat ImageFormat { get { return imageFormat; } }

            public ImageFormatInfo(ImageCodecInfo imageCodecInfo, ImageFormat imageFormat) {
                this.imageCodecInfo = imageCodecInfo;
                this.imageFormat = imageFormat;
            }
        }

        IDXMenuManager menuManager;
        public IDXMenuManager MenuManager { get { return menuManager; } set { menuManager = value; } }
        public ChartRibbonMenuManager ChartRibbonMenuManager { get { return RibbonMenuManager as ChartRibbonMenuManager; } }
        public virtual ChartControl ChartControl { get { return null; } }
        public virtual object ExportedObject { get { return ChartControl; } }
        public override bool AllowPrintOptions { get { return ChartControl != null; } }

        List<ImageFormatInfo> GetSupportedImageFormats() {
            List<ImageFormat> formats = new List<ImageFormat>() { ImageFormat.Bmp, ImageFormat.Emf, ImageFormat.Exif, ImageFormat.Gif, ImageFormat.Icon, ImageFormat.Jpeg, ImageFormat.Png, ImageFormat.Tiff, ImageFormat.Wmf };
            List<ImageFormatInfo> result = new List<ImageFormatInfo>();
            ImageCodecInfo[] infos = ImageCodecInfo.GetImageEncoders();
            foreach (ImageFormat imageFormat in formats)
                foreach (ImageCodecInfo imageCodecInfo in infos)
                    if (imageCodecInfo.FormatID.Equals(imageFormat.Guid))
                        result.Add(new ImageFormatInfo(imageCodecInfo, imageFormat));
            return result;
        }

        protected override void AllowExport() {
            EnabledPrintExportActions(true,
                ExportFormats.Image | ExportFormats.PDF | ExportFormats.HTML | ExportFormats.MHT | ExportFormats.XLS | ExportFormats.RTF | ExportFormats.XLSX, false);
        }
        protected override void ExportToCore(string filename, string ext) {
            ChartControl chart = ChartControl;
            if (chart != null) {
                Cursor currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                chart.OptionsPrint.SizeMode = PrintSizeMode.None;
                if (ext == "rtf")
                    chart.ExportToRtf(filename);
                else if (ext == "pdf") {
                    chart.OptionsPrint.SizeMode = PrintSizeMode.Zoom;
                    chart.OptionsPrint.ImageFormat = PrintImageFormat.Metafile;
                    PdfExportOptions options = new PdfExportOptions();
                    options.ConvertImagesToJpeg = false;
                    chart.ExportToPdf(filename, options);
                }
                else if (ext == "mht")
                    chart.ExportToMht(filename);
                else if (ext == "html")
                    chart.ExportToHtml(filename);
                else if (ext == "xls")
                    chart.ExportToXls(filename);
                else if (ext == "xlsx")
                    chart.ExportToXlsx(filename);
                Cursor.Current = currentCursor;
            }
        }
        protected override void ExportToImage() {
            ChartControl chart = ChartControl;
            if (chart != null) {
                chart.OptionsPrint.SizeMode = PrintSizeMode.None;
                List<ImageFormatInfo> formats = GetSupportedImageFormats();
                if (formats.Count > 0) {
                    string fileFormat = string.Empty;
                    foreach (ImageFormatInfo format in formats)
                        fileFormat += String.Format("{0} ({1})|{1}", String.Format("{0} image", format.ImageCodecInfo.FormatDescription), format.ImageCodecInfo.FilenameExtension) + "|";
                    fileFormat = fileFormat.TrimEnd('|');
                    string filePath = MainFormHelper.GetFileName("", fileFormat);
                    if (!string.IsNullOrEmpty(filePath)) {
                        string extension = System.IO.Path.GetExtension(filePath);
                        if (!string.IsNullOrEmpty(extension)) {
                            extension = extension.ToUpper();
                            foreach (ImageFormatInfo format in formats) {
                                if (format.ImageCodecInfo.FilenameExtension.Contains(extension)) {
                                    chart.ExportToImage(filePath, format.ImageFormat);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
        protected override void ExportToPDF() {
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf");
        }
        protected override void ExportToHTML() {
            ExportTo("html", "HTML document (*.html)|*.html");
        }
        protected override void ExportToMHT() {
            ExportTo("mht", "MHT document (*.mht)|*.mht");
        }
        protected override void ExportToXLS() {
            ExportTo("xls", "XLS document (*.xls)|*.xls");
        }
        protected override void ExportToXLSX() {
            ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx");
        }
        protected override void ExportToRTF() {
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf");
        }
        protected override void ExportToText() {
            ExportTo("txt", "Text document (*.txt)|*.txt");
        }
        protected override void PrintPreview() {
            ChartControl chart = ChartControl;
            if (chart != null) {
                chart.OptionsPrint.SizeMode = PrintSizeMode.Zoom;
                chart.OptionsPrint.ImageFormat = PrintImageFormat.Metafile;
                if (RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                    chart.ShowRibbonPrintPreview();
                else
                    chart.ShowPrintPreview();
            }
        }
    }
}
