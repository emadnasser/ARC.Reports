using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CommonController : DemoController {
        public ActionResult BuiltInValidation() {
            return DemoView("BuiltInValidation", new BuiltInValidationData());
        }
        [HttpPost]
        public ActionResult BuiltInValidation(FormCollection form) {
            BuiltInValidationData validationData;
            if(Request.Params["btnUpdate"] == null) { // Theme changing
                validationData = new BuiltInValidationData {
                    Name = EditorExtension.GetValue<string>("Name"),
                    Age = EditorExtension.GetValue<int?>("Age"),
                    Email = EditorExtension.GetValue<string>("Email"),
                    ArrivalDate = EditorExtension.GetValue<DateTime?>("ArrivalDate")
                };
                return DemoView("BuiltInValidation", validationData);
            }

            bool isValid = true;
            validationData = new BuiltInValidationData {
                Name = EditorExtension.GetValue<string>("Name", BuiltInValidationDemoHelper.NameValidationSettings, BuiltInValidationDemoHelper.OnNameValidation, ref isValid),
                Age = EditorExtension.GetValue<int?>("Age", BuiltInValidationDemoHelper.AgeValidationSettings, BuiltInValidationDemoHelper.OnAgeValidation, ref isValid),
                Email = EditorExtension.GetValue<string>("Email", BuiltInValidationDemoHelper.EmailValidationSettings, null, ref isValid),
                ArrivalDate = EditorExtension.GetValue<DateTime?>("ArrivalDate", BuiltInValidationDemoHelper.ArrivalDateValidationSettings, null, ref isValid)
            };
            if(isValid) {
                object redirectActionName = "BuiltInValidation";
                return DemoView("BuiltInValidation", "ValidationSuccess", redirectActionName);
            }
            return DemoView("BuiltInValidation", validationData);
        }
    }
}
