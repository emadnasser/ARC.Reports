using System.Collections.Generic;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class CaptchaDemoOptions {
        public string CharacterSet { get; set; }
        public int CodeLength { get; set; }
        public static CaptchaDemoOptions Default {
            get {
                return new CaptchaDemoOptions() {
                    CharacterSet = "abcdefhjklmnpqrstuvxyz23456789",
                    CodeLength = 5
                };
            }
        }

        public static IEnumerable<SelectListItem> GetCodeLengthRange(int codeLength) {
            var codeLengthRange = new List<SelectListItem>();
            for(int index = 3; index < 8; index++) {
                var item = new SelectListItem() {
                    Value = index.ToString(),
                    Text = index.ToString(),
                    Selected = codeLength == index
                };
                codeLengthRange.Add(item);
            }
            return codeLengthRange;
        }
    }
}
