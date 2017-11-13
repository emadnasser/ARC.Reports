using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System.Web.UI.WebControls;

namespace DevExpress.Web.Demos {
    [ValidateInput(false)]
    public partial class CommonController: DemoController {
        public override string Name { get { return "Common"; } }

        public ActionResult Index() {
            return RedirectToAction("ModelValidation");
        }
    }

    public class CommonDemoHelper {
        static Action<TextBoxSettings> textBoxSettingsMethod;
        static Action<LabelSettings> labelSettingsMethod;
        static Action<MVCxFormLayoutItem> formLayoutItemSettingsMethod;

        public static Action<TextBoxSettings> TextBoxSettingsMethod {
            get {
                if (textBoxSettingsMethod == null)
                    textBoxSettingsMethod = CreateTextBoxSettingsMethod();
                return textBoxSettingsMethod;
            }
        }
        public static Action<LabelSettings> LabelSettingsMethod {
            get {
                if (labelSettingsMethod == null)
                    labelSettingsMethod = CreateLabelSettingsMethod();
                return labelSettingsMethod;
            }
        }
        public static Action<MVCxFormLayoutItem> FormLayoutItemSettingsMethod {
            get {
                if(formLayoutItemSettingsMethod == null)
                    formLayoutItemSettingsMethod = CreateFormLayoutItemSettingsMethod();
                return formLayoutItemSettingsMethod;
            }
        }
        static Action<TextBoxSettings> CreateTextBoxSettingsMethod() {
            return settings => {
                settings.ControlStyle.CssClass = "editor";
                settings.ShowModelErrors = true;
                settings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText;
            };
        }
        static Action<LabelSettings> CreateLabelSettingsMethod() {
            return settings => { settings.ControlStyle.CssClass = "label"; };
        }
        static Action<MVCxFormLayoutItem> CreateFormLayoutItemSettingsMethod() {
            return itemSettings => {
                dynamic editorSettings = itemSettings.NestedExtensionSettings;
                editorSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText;
                editorSettings.ShowModelErrors = true;
                editorSettings.Width = Unit.Pixel(230);
            };
        }
    }
}
