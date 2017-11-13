using System.Drawing.Imaging;
using DevExpress.XtraBars;

namespace DevExpress.XtraCharts.Demos {

    public class BarExportToImageItem : BarButtonItem {
        readonly ImageFormat imageFormat;
        readonly ImageCodecInfo imageCodecInfo;

        public ImageFormat ImageFormat { get { return imageFormat; } }
        public ImageCodecInfo ImageCodecInfo { get { return imageCodecInfo; } }

        public BarExportToImageItem(BarManager barManager, ImageFormat imageFormat, ImageCodecInfo imageCodecInfo)
            : base(barManager, string.Empty) {
            this.imageFormat = imageFormat;
            this.imageCodecInfo = imageCodecInfo;
            Caption = string.Format("{0}", imageCodecInfo.FormatDescription);
        }
    }

}
