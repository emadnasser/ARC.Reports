using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class RichEditExportModel : RichEditModelBase {
        public RichEditExportModel() {
            DocumentUrl = "/App_Data/MovieRentals.docx";
        }

        public string DocumentUrl { get; set; }
    }
}
