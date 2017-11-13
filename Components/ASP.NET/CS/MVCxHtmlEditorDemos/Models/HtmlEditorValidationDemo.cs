using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {

    public class ValidationDemoModel {

        public const int MaxLength = 50;
        public static readonly string ErrorMessage = string.Format("Custom validation fails because the HTML content's length exceeds {0} characters.", MaxLength);

        public string DemoHtml { get; set; }

        public HtmlEditorView ActiveView { get { return HtmlEditorExtension.GetActiveView("DemoHtml"); } }

        public static ValidationDemoModel CreateDefault() {
            ValidationDemoModel model = new ValidationDemoModel();
            model.DemoHtml = System.IO.File.ReadAllText(HttpContext.Current.Server.MapPath("~/Content/HtmlEditor/DemoHtml/Validation.htm"));
            return model;
        }
    }

    public class ValidationDemoBinder : DevExpressEditorsBinder {
        public ValidationDemoBinder() {
            HtmlEditorBinderSettings.ValidationSettings.RequiredField.IsRequired = true;
            HtmlEditorBinderSettings.ValidationSettings.ErrorText = ValidationDemoModel.ErrorMessage;
            HtmlEditorBinderSettings.ValidationHandler = (s, e) => { e.IsValid = e.Html.Length <= ValidationDemoModel.MaxLength; };
        }
    }

}
