using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using DevExpress.Web;

namespace DevExpress.Web.Demos {
    public static class RichEditDemoUtils {
        public static void HideFileTab(ASPxRichEdit.ASPxRichEdit richedit) {
            richedit.CreateDefaultRibbonTabs(true);
            RibbonTab fileTab = richedit.RibbonTabs[0];
            richedit.RibbonTabs.Remove(fileTab);
        }
    }
}
