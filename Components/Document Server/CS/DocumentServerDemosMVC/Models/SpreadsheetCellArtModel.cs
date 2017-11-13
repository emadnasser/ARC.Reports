using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetCellArtModel : SpreadsheetModelBase {
        const string DefaultImageUrl = "/Content/DevExpress.png";
        public SpreadsheetCellArtModel() {
            ImageUrl = DefaultImageUrl;

            PreviewModel.CanShowOnlyFirstWorksheet = true;
            PreviewModel.PreviewDocumentAction = "PreviewCellArt";
        }

        public string ImageUrl { get; set; }

        public string GetImageUrl() {
            if (ImageUrl == DefaultImageUrl)
                return ".." + ImageUrl;
            return ImageUrl;
        }
    }
}
