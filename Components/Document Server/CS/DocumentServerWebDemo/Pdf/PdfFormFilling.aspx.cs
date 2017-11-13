using System;
using System.IO;
using System.Text;
using System.Web.UI;
using DevExpress.Pdf;
using DevExpress.Web;
using DevExpress.Web.Demos;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web.Hosting;

public partial class PdfFormFilling : Page {
    const string formKey = "Form";

    PdfDocumentProcessor CreateDocumentProcessor() {
        PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();
        Stream stream = Session[formKey] as Stream;
        if (stream == null) {
            documentProcessor.LoadDocument(HostingEnvironment.MapPath("~/App_Data/FormDemo.pdf"));
            documentProcessor.ResetFormData();
        } 
        else
            documentProcessor.LoadDocument(stream, true);
        return documentProcessor;
    }
    void UpdateImage() {
        using (PdfDocumentProcessor documentProcessor = CreateDocumentProcessor())
        using (Bitmap bitmap = documentProcessor.CreateBitmap(1, 900))
        using (MemoryStream outStream = new MemoryStream()) {
            bitmap.Save(outStream, ImageFormat.Png);
            pageImage.Src = "data:image/png;base64," + Convert.ToBase64String(outStream.GetBuffer());
        }
    }
    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/Content/PdfDemos.css");
        ASPxWebControl.SetIECompatibilityModeEdge();
        if (!IsPostBack) {
            UpdateImage();
            int selectedIndex = 0;
            using (PdfDocumentProcessor documentProcessor = CreateDocumentProcessor())
                foreach (PdfInteractiveFormField field in documentProcessor.Document.AcroForm.Fields) {
                    if (field.Name == "Nationality") {
                        PdfChoiceFormField choiceField = field as PdfChoiceFormField;
                        if (choiceField != null)
                            for (int i = 0; i < choiceField.Options.Count; i++) {
                                PdfOptionsFormFieldOption option = choiceField.Options[i];
                                if (option.ExportText == "United States")
                                    selectedIndex = i;
                                cbeNationality.Items.Add(option.ExportText);
                            }
                    }
                }
            cbeNationality.SelectedIndex = selectedIndex;
        }
    }

    protected void OnCallback(object source, CallbackEventArgsBase e) {
        PdfFormData formData = new PdfFormData();
        formData["FirstName"].Value = tbFirstName.Text;
        formData["LastName"].Value = tbLastName.Text;
        formData["Gender"].Value = rbMale.Checked ? "Male" : "Female";
        DateTime dateOfBirth = deDate.Date;
        formData["DD"].Value = dateOfBirth.Day.ToString();
        formData["MM"].Value = dateOfBirth.Month.ToString();
        formData["YYYY"].Value = dateOfBirth.Year.ToString();
        formData["PassportNo"].Value = tePassport.Text;
        formData["Nationality"].Value = cbeNationality.Text;
        formData["Address"].Value = tbAddress.Text;
        formData["VisaNo"].Value = tbVisa.Text;
        formData["FlightNo"].Value = tbFlight.Text;
        UpdateImage();
        using (PdfDocumentProcessor documentProcessor = CreateDocumentProcessor()) {
            if (formData.Value != null)
                documentProcessor.ApplyFormData(formData);
            Stream stream = new MemoryStream();
            documentProcessor.SaveDocument(stream, true);
            Session[formKey] = stream;
        }
        UpdateImage();
    }
}
