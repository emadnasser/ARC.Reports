using DevExpress.Pdf;
using System;
using System.IO;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PdfController {
        const string fillFormDefaultFile = "~/App_Data/Pdf/FormDemo.pdf";
        const string fillFormSessionKey = "FillForm";

        public ActionResult FormFilling() {
            return GetDemoView<PdfFormFillingModel>("FormFilling", fillFormSessionKey, fillFormDefaultFile);
        }
        public ActionResult FillForm(string firstName, string lastName, bool? gender, string date, string passport, string nationality, string address, string visa, string flight) {
            using (PdfFormFillingModel model = new PdfFormFillingModel()) {
                model.LoadDocument((byte[])Session[fillFormSessionKey]);
                Session[fillFormSessionKey] = model.FillForm(firstName, lastName, gender ?? true, date, passport, nationality, address, visa, flight);
                return null;
            }
        }
    }
}
