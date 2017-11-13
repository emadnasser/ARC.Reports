using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using DevExpress.DXperience.Demos;
using DevExpress.Pdf;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
    public partial class PdfFormFilling : TutorialControlBase {
        static readonly string path = DemoUtils.GetRelativePath("FormDemo.pdf");

        Stream stream = new MemoryStream();

        public override bool NoGap { get { return true; } }

        public PdfFormFilling() {
            InitializeComponent();
            deDate.Properties.MinValue = new DateTime(1901, 1, 1);
            deDate.Properties.MaxValue = DateTime.Now;
            deDate.DateTime = new DateTime(1985, 8, 30);
            try {
                using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                    documentProcessor.LoadDocument(path);
                    documentProcessor.ResetFormData();
                    foreach (PdfInteractiveFormField field in documentProcessor.Document.AcroForm.Fields) {
                        if (field.Name == "Nationality") {
                            PdfChoiceFormField choiceField = field as PdfChoiceFormField;
                            if (choiceField != null)
                                foreach (PdfOptionsFormFieldOption option in choiceField.Options)
                                    cbeNationality.Properties.Items.Add(option.ExportText);
                        }
                    }
                    documentProcessor.SaveDocument(stream);
                }
                Enabled = PdfFileHelper.LoadDocument(pdfViewer, stream);
            }
            catch {
                XtraMessageBox.Show(PdfFileHelper.DemoOpeningErrorMessage, "Error");
            }
        }

        void SubmitClick(object sender, EventArgs e) {
            PdfFormData formData = new PdfFormData();
            formData["FirstName"].Value = teFirstName.Text;
            formData["LastName"].Value = teLastName.Text;
            formData["Gender"].Value = ceMale.Checked ? "Male" : "Female";
            DateTime dateOfBirth = deDate.DateTime;
            formData["DD"].Value = dateOfBirth.Day.ToString();
            formData["MM"].Value = dateOfBirth.Month.ToString();
            formData["YYYY"].Value = dateOfBirth.Year.ToString();
            formData["PassportNo"].Value = tePassport.Text;
            formData["Nationality"].Value = cbeNationality.Text;
            formData["Address"].Value = teAddress.Text;
            formData["VisaNo"].Value = teVisa.Text;
            formData["FlightNo"].Value = teFlight.Text;
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                documentProcessor.LoadDocument(stream);
                documentProcessor.ApplyFormData(formData);
                using (Stream newStream = new MemoryStream()) {
                    documentProcessor.SaveDocument(newStream);
                    stream.Position = 0;
                    pdfViewer.LoadDocument(newStream);
                }
            }
        }

        void DocumentClosing(object sender, PdfDocumentClosingEventArgs e) {
        }
    }
}
