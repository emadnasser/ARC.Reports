using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class RichEditFindAndReplaceModel : RichEditModelBase {
        public RichEditFindAndReplaceModel() {
            PreviewModel.PreviewDocumentAction = "PreviewFindAndReplace";
        }
        public string Find { get; set; }
        public string Replace { get; set; }
        public string ActionToExec { get; set; }
    }
}
