using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Mask;

namespace XtraReportsDemos.CharacterComb {
    public partial class PreviewControl : XtraReportsDemos.PreviewControl {
        protected override XtraReport CreateReport() {
            return new Report();
        }
        static PreviewControl() {
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("Name", "Name", "Custom", MaskType.RegEx, @"[A-Z -.]+");
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("NumbersAndUppercaseLetters", "Numbers and Uppercase letters", "Custom", MaskType.RegEx, @"[A-Z0-9]+");
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("UppercaseText", "Uppercase Text", "Custom", MaskType.RegEx, @"[A-Z0-9 ,-/]+");
        }
    }
}
