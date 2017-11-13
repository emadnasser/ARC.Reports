using System.Drawing;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.Tutorials;


namespace DevExpress.XtraSpellChecker.Demos {
    public partial class About : ucOverviewPage {
        protected override string Line1Text {
            get {
                return "The XtraSpellChecker Suite";
            }
        }
        protected override string Line2Text {
            get {
                return "Office Inspired Spell Checking Controls.";
            }
        }
        protected override string Line3Text {
            get {
                return "DevExpress Desktop Controls";
            }
        }
        protected override string Line4Text {
            get {
                return votedVSM;
            }
        }
	}
}
