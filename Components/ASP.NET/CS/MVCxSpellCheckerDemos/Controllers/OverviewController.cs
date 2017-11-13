using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class OverviewController : DemoController {
        public override string Name { get { return string.Empty; } }

        public ActionResult Index() {
            return DemoView("Overview", "Overview", SampleText);
        }
        public ActionResult OverviewPartial() {
            return PartialView("OverviewPartial");
        }

        public const string SampleText = "To enable spell checking you need a dictiopnary file, an affix grammar file and an alphabet file. A dictionary fuile is generally a variation of correctly spelled words and the grammar rules that  are written asx a form of regular expressions. Affix means to attach or append. Affix rules are appended to words in the dicionary to recognize different word forms. A dictionary can be created with a text editor.\r\nThe LevenshteinDistance is a value used to measure the proximity of words. This value is used to indicate the maximum number od steps requirecd to convert a messpelled word into a a suggested word.";
    }
}
