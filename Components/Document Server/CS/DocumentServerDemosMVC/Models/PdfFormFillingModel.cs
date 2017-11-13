using System;
using System.IO;
using System.Collections.Generic;
using DevExpress.Pdf;

namespace DevExpress.Web.Demos {
    public class PdfFormFillingModel : PdfModelBase {
        IList<string> nationalityList;

        public IEnumerable<string> NationalityList { get { return nationalityList; } }

        public override void LoadDocument(byte[] data) {
            base.LoadDocument(data);
            PdfDocumentProcessor processor = Processor;
            processor.ResetFormData();
            nationalityList = new List<string>();
            foreach (PdfInteractiveFormField field in processor.Document.AcroForm.Fields) {
                if (field.Name == "Nationality") {
                    PdfChoiceFormField choiceField = field as PdfChoiceFormField;
                    if (choiceField != null)
                        foreach (PdfOptionsFormFieldOption option in choiceField.Options)
                            nationalityList.Add(option.ExportText);
                }
            }
        }
        internal byte[] FillForm(string firstName, string lastName, bool gender, string date, string passport, string nationality, string address, string visa, string flight) {
            if (Processor.Document.Pages.Count > 0) {
                PdfFormData formData = new PdfFormData();
                formData["LastName"].Value = lastName;
                formData["FirstName"].Value = firstName;
                formData["Gender"].Value = gender ? "Male" : "Female";
                string[] dateValues = date.Split('/');
                formData["MM"].Value = dateValues[0];
                formData["DD"].Value = dateValues[1];
                formData["YYYY"].Value = dateValues[2];
                formData["PassportNo"].Value = passport;
                formData["Nationality"].Value = nationality;
                formData["Address"].Value = address;
                formData["VisaNo"].Value = visa;
                formData["FlightNo"].Value = flight;
                Processor.ApplyFormData(formData);
            }
            using (MemoryStream stream = new MemoryStream()) {
                Processor.SaveDocument(stream);
                stream.Position = 0;
                Clear();
                LoadDocument(stream);
                return stream.GetBuffer();
            }
        }
    }
}
