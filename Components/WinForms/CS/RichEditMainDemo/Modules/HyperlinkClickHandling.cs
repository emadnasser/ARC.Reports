using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.Office.Utils;
using DevExpress.XtraRichEdit.Demos.Forms;
using DevExpress.XtraRichEdit.Utils;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class HyperlinkClickHandlingModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        static List<string> products = CreateProducts();
        static List<string> managers = CreateManagers();
        static List<string> contactInfos = CreateContactInfos();
        static List<string> CreateProducts() {
            List<string> result = new List<string>();
            result.Add("XtraScheduler™ Suite");
            result.Add("XtraRichEdit™ Suite");
            result.Add("XtraSpellChecker™");
            result.Add("XtraReports™ Suite");
            result.Add("XtraGrid™ Suite");
            result.Add("XtraPivotGrid™ Suite");
            result.Add("XtraTreeList™ Suite");
            result.Add("XtraGauges™ Suite");
            result.Add("XtraWizard™ Control");
            result.Add("XtraVerticalGrid™ Suite");
            result.Add("XtraCharts™ Suite");
            result.Add("XtraLayoutControl™ Suite");
            result.Add("XtraNavBar™");
            result.Add("XtraEditors™ Library");
            result.Add("XtraPrinting™ Library");
            return result;
        }
        static List<string> CreateManagers() {
            List<string> result = new List<string>();
            result.Add("Mark M Leininger");
            result.Add("Caroline R Geraghty");
            result.Add("Dorothy M Salas");
            result.Add("Pete M Smith");
            result.Add("Lena D Carroll");
            result.Add("Shauna T Tuggle");
            result.Add("Mary R Spencer");
            result.Add("David G Rucker");
            result.Add("Barry D Phillips");
            result.Add("Ronald R Ross");
            result.Add("Nellie J Burdette");
            return result;
        }
        static List<string> CreateContactInfos() {
            List<string> result = new List<string>();
            result.Add("Mark.M.Leininger@dodgit.com, 773-384-2677");
            result.Add("Caroline.R.Geraghty@mailinator.com, 703-968-3712");
            result.Add("Dorothy.M.Salas@trashymail.com, 541-995-3154");
            result.Add("Pete.M.Smith@spambob.com, 954-568-0573");
            result.Add("Lena.D.Carroll@spambob.com, 772-663-2034");
            result.Add("Shauna.T.Tuggle@mailinator.com, 812-463-8021");
            result.Add("Mary.R.Spencer@dodgit.com, 510-819-1801");
            result.Add("David.G.Rucker@spambob.com, 423-550-7308");
            result.Add("Barry.D.Phillips@mailinator.com, 831-308-3866");
            result.Add("Ronald.R.Ross@dodgit.com, 847-242-3792");
            result.Add("Nellie.J.Burdette@pookmail.com, 937-777-5277");
            return result;
        }

        delegate PopupFormBase CreateFormDelegate();
        Dictionary<string, CreateFormDelegate> hyperlinkMappings;
        public HyperlinkClickHandlingModule() {
            InitializeComponent();
            RtfLoadHelper.Load("HyperlinkClickHandling.rtf", richEditControl);

            this.hyperlinkMappings = CreateHyperlinkMappings();
            SubscribeRichEditEvents();
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }
        Dictionary<string, CreateFormDelegate> CreateHyperlinkMappings() {
            Dictionary<string, CreateFormDelegate> result = new Dictionary<string, CreateFormDelegate>();
            HyperlinkCollection hyperlinks = this.richEditControl.Document.Hyperlinks;
            result.Add("OpenSelectProductForm", CreateSelectProductForm);
            result.Add("OpenSelectAmountForm", CreateSelectAmountForm);
            result.Add("OpenSelectDateForm", CreateSelectDateForm);
            result.Add("OpenSelectManagerForm", CreateSelectManagerForm);
            return result;
        }
        PopupFormBase CreateSelectProductForm() {
            SelectProductForm result = new SelectProductForm(products);
            result.Commit += OnProductFormCommit;
            return result;
        }
        void OnProductFormCommit(object sender, EventArgs e) {
            SelectProductForm form = (SelectProductForm)sender;
            string value = (string)form.EditValue;
            ReplaceRange(value, form.Range);
        }
        PopupFormBase CreateSelectDateForm() {
            SelectDateForm result = new SelectDateForm();
            result.Commit += OnSelectDateFormCommit;
            return result;
        }
        void OnSelectDateFormCommit(object sender, EventArgs e) {
            SelectDateForm form = (SelectDateForm)sender;
            string value = ((DateTime)form.EditValue).ToString("MMMM, dd yyyy");
            ReplaceRange(value, form.Range);
        }
        PopupFormBase CreateSelectAmountForm() {
            SelectAmountForm result = new SelectAmountForm();
            result.Commit += OnSelectAmountFormCommit;
            return result;
        }
        void OnSelectAmountFormCommit(object sender, EventArgs e) {
            SelectAmountForm form = (SelectAmountForm)sender;
            string value = ((decimal)form.EditValue).ToString("$0.00");
            ReplaceRange(value, form.Range);
        }
        PopupFormBase CreateSelectManagerForm() {
            SelectManagerForm result = new SelectManagerForm(managers, contactInfos);
            result.Commit += OnSelectManagerForm;
            return result;
        }
        void OnSelectManagerForm(object sender, EventArgs e) {
            SelectManagerForm form = (SelectManagerForm)sender;
            string value = (string)form.EditValue;
            ReplaceRange(value, form.Range);
        }
        private void SubscribeRichEditEvents() {
            this.richEditControl.HyperlinkClick += new HyperlinkClickEventHandler(OnHyperlinkClick);
        }
        void OnHyperlinkClick(object sender, HyperlinkClickEventArgs e) {
            if (e.ModifierKeys != this.richEditControl.Options.Hyperlinks.ModifierKeys)
                return;
            CreateFormDelegate createForm;
            if (!hyperlinkMappings.TryGetValue(e.Hyperlink.NavigateUri, out createForm))
                return;
            PopupFormBase form = createForm();
            form.Range = e.Hyperlink.Range;
            form.Location = GetFormLocation();
            form.Show();
            e.Handled = true;
        }
        Point GetFormLocation() {
            DocumentPosition position = this.richEditControl.Document.CaretPosition;
            Rectangle rect = this.richEditControl.GetBoundsFromPosition(position);
            Point location = new Point(rect.Right, rect.Bottom);
            Point localPoint = Units.DocumentsToPixels(location, this.richEditControl.DpiX, this.richEditControl.DpiY);
            return this.richEditControl.PointToScreen(localPoint);
        }
        int GetHyperlinkIndex(Hyperlink hyperlink) {
            HyperlinkCollection hyperlinks = this.richEditControl.Document.Hyperlinks;
            int count = hyperlinks.Count;
            for (int i = 0; i < count; i++) {
                if (hyperlinks[i] == hyperlink)
                    return i;
            }
            return -1;
        }
        void ReplaceRange(string value, DocumentRange range) {
            Document document = this.richEditControl.Document;
            document.BeginUpdate();
            try {
                document.Replace(range, value);
            }
            finally {
                document.EndUpdate();
            }
        }
    }
}
