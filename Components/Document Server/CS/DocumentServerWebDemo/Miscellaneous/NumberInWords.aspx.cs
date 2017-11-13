using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxTreeList;
using DevExpress.Docs.Text;

public partial class Miscellaneous_NumberInWords : System.Web.UI.Page {
    #region Fields
    const string cultureNodeName = "Culture";
    const string valueNodeName = "Value";
    static List<DevExpress.Docs.Demo.NumberCultureDescription> numberCultures = CreateNumberCultures();
    static INumberInWordsProvider cardinalNumbers = null;
    static INumberInWordsProvider ordinalNumbers = null;
    #endregion

    protected void Page_Load(object sender, EventArgs e) {
        if(cardinalNumbers == null)
            cardinalNumbers = NumberInWords.Cardinal;
        if(ordinalNumbers == null)
            ordinalNumbers = NumberInWords.Ordinal;
        PrepareTreeList(Convert.ToInt32(spnNumber.Value));
    }

    void PrepareTreeList(int value) {
        foreach(DevExpress.Docs.Demo.NumberCultureDescription item in numberCultures) {
            int key = (int)item.Id * 10;
            TreeListNode firstLevelNode = tlResult.AppendNode(key);
            firstLevelNode[cultureNodeName] = item.Name;
            TreeListNode secondLevelNode = tlResult.AppendNode(key + 1, firstLevelNode);
            secondLevelNode[cultureNodeName] = "Cardinal";
            secondLevelNode[valueNodeName] = GetTextualRepresentation(cardinalNumbers, item.Id, value);
            secondLevelNode = tlResult.AppendNode(key + 2, firstLevelNode);
            secondLevelNode[cultureNodeName] = "Ordinal";
            secondLevelNode[valueNodeName] = GetTextualRepresentation(ordinalNumbers, item.Id, value);
        }
        tlResult.ExpandAll();
    }

    protected void tlResult_CustomCallback(object sender, DevExpress.Web.ASPxTreeList.TreeListCustomCallbackEventArgs e) {
    }

    #region CreateNumberCultures
    static List<DevExpress.Docs.Demo.NumberCultureDescription> CreateNumberCultures() {
        List<DevExpress.Docs.Demo.NumberCultureDescription> result = new List<DevExpress.Docs.Demo.NumberCultureDescription>();
        result.Add(new DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.English, "English"));
        result.Add(new DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Roman, "Roman"));
        result.Add(new DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.French, "French(Français)"));
        result.Add(new DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.German, "German(Deutsch)"));
        result.Add(new DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Italian, "Italian(Italiano)"));
        result.Add(new DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Russian, "Russian(Русский)"));
        result.Add(new DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Swedish, "Swedish(Svensk)"));
        result.Add(new DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Turkish, "Turkish(Türkçe)"));
        result.Add(new DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Greek, "Greek(Ελληνικά)"));
        result.Add(new DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Spanish, "Spanish(Español)"));
        result.Add(new DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Portuguese, "Portuguese(Português)"));
        result.Add(new DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Ukrainian, "Ukrainian(Український)"));
        return result;
    }
    #endregion

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
}

namespace DevExpress.Docs.Demo {
    public class NumberCultureDescription {
        public NumberCulture Id { get; set; }
        public string Name { get; set; }
        public NumberCultureDescription(NumberCulture id, string name) {
            Id = id;
            Name = name;
        }
    }
}
