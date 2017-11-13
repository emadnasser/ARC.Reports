using System.Collections.Generic;
using System.Windows;
using DevExpress.Xpf.Printing.Parameters;
using DevExpress.Xpf.Printing.Parameters.Models;
using DevExpress.Xpf.Printing;
using DevExpress.Utils;
using DevExpress.XtraPrinting;

namespace ReportWpfDemo {
    public class DemoParameterTemplateSelector : ParameterTemplateSelector {
        Dictionary<object, DataTemplate> templates = new Dictionary<object, DataTemplate>();
        public Dictionary<object, DataTemplate> Templates { get { return templates; } }

        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            var parameter = item as ParameterModel;
            if(parameter == null)
                return null;
            if(Templates.ContainsKey(parameter.Name))
                return Templates[parameter.Name];
            return base.SelectTemplate(item, container);
        }
    }

    public class DemoEditingFieldTemplateSelector : EditingFieldTemplateSelector {
        Dictionary<object, DataTemplate> templates = new Dictionary<object, DataTemplate>();
        public Dictionary<object, DataTemplate> Templates { get { return templates; } }

        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            var editingField = Guard.ArgumentMatchType<TextEditingField>(item, "item");

            if(Templates.ContainsKey(editingField.EditorName))
                return Templates[editingField.EditorName];
            return base.SelectTemplate(item, container);
        }
    }
}
