using System;
using System.Web.UI.WebControls;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Web.Editors;
using DevExpress.ExpressApp.Web.TestScripts;
using FeatureCenter.Module.PropertyEditors;
using DevExpress.ExpressApp.Model;

namespace FeatureCenter.Module.Web.PropertyEditors {
    [PropertyEditor(typeof(Int32), FeatureCenterEditorAliases.CustomIntegerEditor, false)]
    public class CustomIntegerEditor : WebPropertyEditor, ITestable {
        public CustomIntegerEditor(Type objectType, IModelMemberViewItem info) : base(objectType, info) { }
        protected override WebControl CreateViewModeControlCore() {
            return new Label();
        }
        protected override WebControl CreateEditModeControlCore() {
            DropDownList control = new DropDownList();
            control.ID = "editor";
            control.Items.Add("0");
            control.Items.Add("1");
            control.Items.Add("2");
            control.Items.Add("3");
            control.Items.Add("4");
            control.Items.Add("5");
            control.SelectedIndexChanged += control_SelectedIndexChanged;
            return control;
        }

        void control_SelectedIndexChanged(object sender, EventArgs e) {
            EditValueChangedHandler(sender, e);
        }
        protected override object GetControlValueCore() {
            int result = 0;
            if(int.TryParse(((DropDownList)Editor).SelectedValue, out result)) {
                return result;
            }
            return 0;
        }
        protected override void ReadEditModeValueCore() {
            ((DropDownList)Editor).SelectedValue = ((int)PropertyValue).ToString();
        }
        protected override void ReadViewModeValueCore() {
            ((Label)InplaceViewModeEditor).Text = ((int)PropertyValue).ToString();
        }
        protected override IJScriptTestControl GetInplaceViewModeEditorTestControlImpl() {
            return new JSCustomLabelTestControl();
        }
        protected override IJScriptTestControl GetEditorTestControlImpl() {
            return new JSCustomDropDownListTestControl();
        }
	}
    public class JSCustomLabelTestControl : IJScriptTestControl {
        public const string ClassName = "CustomLabelTestControl";
        private static StandardTestControlScriptsDeclaration scriptDeclatation;
        static JSCustomLabelTestControl() {
            scriptDeclatation = new StandardTestControlScriptsDeclaration();
            scriptDeclatation.GetTextFunctionBody = "return this.control.innerText;";
            scriptDeclatation.SetTextFunctionBody = @"this.LogOperationError('The ""' + this.caption + '"" editor is readonly.');";
        }
        public string JScriptClassName {
            get { return ClassName; }
        }
        public TestScriptsDeclarationBase ScriptsDeclaration {
            get {
                return scriptDeclatation;
            }
        }
    }

    public class JSCustomDropDownListTestControl : IJScriptTestControl {
        public const string ClassName = "CustomDropDownListTestControl";
        private static StandardTestControlScriptsDeclaration scriptDeclatation;
        static JSCustomDropDownListTestControl() {
            scriptDeclatation = new StandardTestControlScriptsDeclaration();
            scriptDeclatation.IsEnabledFunctionBody = "return !this.control.disabled;";
            scriptDeclatation.GetTextFunctionBody = "return this.control.value;";
            scriptDeclatation.SetTextFunctionBody = "this.control.value = value;";
        }
        public string JScriptClassName {
            get { return ClassName; }
        }
        public TestScriptsDeclarationBase ScriptsDeclaration {
            get {
                return scriptDeclatation;
            }
        }
    }
}
