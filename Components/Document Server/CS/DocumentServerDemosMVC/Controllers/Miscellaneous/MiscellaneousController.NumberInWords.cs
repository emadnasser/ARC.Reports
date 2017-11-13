using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DevExpress.Docs.Text;
using DevExpress.Web.ASPxTreeList;

namespace DevExpress.Web.Demos {
    public partial class MiscellaneousController : DemoController {
        public ActionResult NumberInWords() {
            MiscellaneousNumberInWordsModel model = new MiscellaneousNumberInWordsModel();
            return DemoView("NumberInWords", model);
        }
        public ActionResult NumberInWordsTreeListPartial(int? number) {
            MiscellaneousNumberInWordsModel model = new MiscellaneousNumberInWordsModel() ;
            if (number.HasValue)
                model.Number = number.Value;
            return PartialView(model);
        }
    }
    public class NumberInWordsTreeHelper {
        public NumberInWordsTreeHelper(MiscellaneousNumberInWordsModel model) {
            Model = model;
        }

        MiscellaneousNumberInWordsModel Model { get; set; }
                        
        public void VirtualModeCreateChildren(TreeListVirtualModeCreateChildrenEventArgs e) {
            List<Object> nodeList = new List<Object>();
            if (e.NodeObject == null) {
                List<NumberCultureDescription> numberCultures = CreateNumberCultures();
                foreach (NumberCultureDescription item in numberCultures) {
                    nodeList.Add(item);
                }
            }
            else {
                NumberCultureDescription numberCulture = e.NodeObject as NumberCultureDescription;
                if (numberCulture == null)
                    return;
                string value1 = GetTextualRepresentation(NumberInWords.Cardinal, numberCulture.Id, Model.Number);
                string value2 = GetTextualRepresentation(NumberInWords.Ordinal, numberCulture.Id, Model.Number);

                nodeList.Add(new SubNode() { Id = String.Format("{0}_Cardinal", numberCulture.Id), Value = value1, Name = "Cardinal" });
                nodeList.Add(new SubNode() { Id = String.Format("{0}_Ordinal", numberCulture.Id), Value = value2, Name = "Ordinal" });
            }
            e.Children = nodeList;
        }
        string GetTextualRepresentation(INumberInWordsProvider provider, NumberCulture numberCulture, int value) {
            string result;
            try {
                result = provider.ConvertToText(value, numberCulture);
            }
            catch {
                result = string.Empty;
            }
            return result;
        }
        public void VirtualModeNodeCreating(TreeListVirtualModeNodeCreatingEventArgs e) {
            NumberCultureDescription nodeCultureDescriptoin = e.NodeObject as NumberCultureDescription;
            if (nodeCultureDescriptoin != null) {
                e.NodeKeyValue = nodeCultureDescriptoin.Id;
                e.IsLeaf = false;
                e.SetNodeValue("Name", nodeCultureDescriptoin.Name);
                return;
            }
            SubNode node = e.NodeObject as SubNode;
            if (node != null) { 
                e.NodeKeyValue = node.Id;
                e.IsLeaf = true;
                e.SetNodeValue("Name", node.Name);
                e.SetNodeValue("Value", node.Value);
            }
        }
        static string MapPath(string path) {
            return System.Web.HttpContext.Current.Request.MapPath(path);
        }
        static List<NumberCultureDescription> CreateNumberCultures() {
            List<NumberCultureDescription> result = new List<NumberCultureDescription>();
            result.Add(new NumberCultureDescription(NumberCulture.English, "English"));
            result.Add(new NumberCultureDescription(NumberCulture.Roman, "Roman"));
            result.Add(new NumberCultureDescription(NumberCulture.French, "French(Français)"));
            result.Add(new NumberCultureDescription(NumberCulture.German, "German(Deutsch)"));
            result.Add(new NumberCultureDescription(NumberCulture.Italian, "Italian(Italiano)"));
            result.Add(new NumberCultureDescription(NumberCulture.Russian, "Russian(Русский)"));
            result.Add(new NumberCultureDescription(NumberCulture.Swedish, "Swedish(Svensk)"));
            result.Add(new NumberCultureDescription(NumberCulture.Turkish, "Turkish(Türkçe)"));
            result.Add(new NumberCultureDescription(NumberCulture.Greek, "Greek(Ελληνικά)"));
            result.Add(new NumberCultureDescription(NumberCulture.Spanish, "Spanish(Español)"));
            result.Add(new NumberCultureDescription(NumberCulture.Portuguese, "Portuguese(Português)"));
            result.Add(new NumberCultureDescription(NumberCulture.Ukrainian, "Ukrainian(Український)"));
            return result;
        }
    }
    public class NumberCultureDescription {
        public NumberCulture Id { get; set; }
        public string Name { get; set; }
        public NumberCultureDescription(NumberCulture id, string name) {
            Id = id;
            Name = name;
        }
    }
    public class SubNode {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
