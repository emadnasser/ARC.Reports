using System;
using System.Collections.Generic;
using DevExpress.Docs.Text;
using DevExpress.DXperience.Demos;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;

namespace DevExpress.Docs.Demos {
    public partial class NumberToWords : TutorialControlBase {
        #region Fields
        List<NumberCultureDescription> numberCultures;
        INumberInWordsProvider cardinalNumbers;
        INumberInWordsProvider ordinalNumbers;
        long currentNumber;
        #endregion

        public NumberToWords() {
            InitializeComponent();
            SetMinMaxValues();
            numberCultures = CreateNumberCultures();
            cardinalNumbers = NumberInWords.Cardinal;
            ordinalNumbers = NumberInWords.Ordinal;
            PrepareTreeList();
        }

        void spinEdit1_ValueChanged(object sender, System.EventArgs e) {
            currentNumber = (long)numberSpinEdit.Value;
            ApplyNumber();
        }

        #region CreateNumberCultures
        static List<NumberCultureDescription> CreateNumberCultures() {
            List<NumberCultureDescription> result = new List<NumberCultureDescription>();
            result.Add(new NumberCultureDescription(NumberCulture.English, "English"));
            result.Add(new NumberCultureDescription(NumberCulture.English_UnitedKingdom, "English(United Kingdom)"));
            result.Add(new NumberCultureDescription(NumberCulture.French, "French(Français)"));
            result.Add(new NumberCultureDescription(NumberCulture.German, "German(Deutsch)"));
            result.Add(new NumberCultureDescription(NumberCulture.Greek, "Greek(Ελληνικά)"));
            result.Add(new NumberCultureDescription(NumberCulture.Hindi, "Hindi(हिन्दी)"));
            result.Add(new NumberCultureDescription(NumberCulture.Italian, "Italian(Italiano)"));
            result.Add(new NumberCultureDescription(NumberCulture.Portuguese, "Portuguese(Português)"));
            result.Add(new NumberCultureDescription(NumberCulture.Russian, "Russian(Русский)"));
            result.Add(new NumberCultureDescription(NumberCulture.Spanish, "Spanish(Español)"));
            result.Add(new NumberCultureDescription(NumberCulture.Swedish, "Swedish(Svensk)"));
            result.Add(new NumberCultureDescription(NumberCulture.Thai, "Thai(ไทย)"));
            result.Add(new NumberCultureDescription(NumberCulture.Turkish, "Turkish(Türkçe)"));
            result.Add(new NumberCultureDescription(NumberCulture.Ukrainian, "Ukrainian(Український)"));
            return result;
        }
        #endregion

        void SetMinMaxValues() {
            this.numberSpinEdit.Properties.MinValue = 0;
            this.numberSpinEdit.Properties.MaxValue = long.MaxValue;
        }

        string GetTextualRepresentation(INumberInWordsProvider provider, NumberCulture numberCulture, long value) {
            string result;
            try {
                result = provider.ConvertToText(value, numberCulture);
            }
            catch {
                result = string.Empty;
            }
            return result;
        }

        void PrepareTreeListColumns() {
            TreeListColumn column = resultTreeList.Columns.Add();
            column.Caption = "Culture";
            column.OptionsColumn.FixedWidth = true;
            column.Width = 150;
            column.VisibleIndex = 0;
            column = resultTreeList.Columns.Add();
            column.Caption = "Value";
            column.VisibleIndex = 1;
        }

        void PrepareTreeListNodes() {
            foreach (NumberCultureDescription item in numberCultures) {
                TreeListNode rootListNode = null;
                TreeListNode firstLevelNode = resultTreeList.AppendNode(new object[] { item.Name }, rootListNode);
                TreeListNode secondLevelNode = resultTreeList.AppendNode(new object[] { "Cardinal", GetTextualRepresentation(cardinalNumbers, item.Id, currentNumber) }, firstLevelNode);
                item.CardinalNodeId = secondLevelNode.Id;
                secondLevelNode = resultTreeList.AppendNode(new object[] { "Ordinal", GetTextualRepresentation(ordinalNumbers, item.Id, currentNumber) }, firstLevelNode);
                item.OrdinalNodeId = secondLevelNode.Id;
            }
        }

        void PrepareTreeList() {
            currentNumber = Convert.ToInt32(numberSpinEdit.Value); ;
            resultTreeList.BeginUpdate();
            try {
                PrepareTreeListColumns();
                PrepareTreeListNodes();
                resultTreeList.ExpandAll();
            }
            finally {
                resultTreeList.EndUpdate();
            }
        }

        void ApplyValue(INumberInWordsProvider provider, NumberCulture itemId, int nodeId, long value) {
            if (nodeId >= 0) {
                TreeListNode node = resultTreeList.FindNodeByID(nodeId);
                if (node != null)
                    node["Value"] = GetTextualRepresentation(provider, itemId, value);
            }
        }

        void ApplyNumber() {
            resultTreeList.BeginUpdate();
            try {
                foreach (NumberCultureDescription item in numberCultures) {
                    ApplyValue(cardinalNumbers, item.Id, item.CardinalNodeId, currentNumber);
                    ApplyValue(ordinalNumbers, item.Id, item.OrdinalNodeId, currentNumber);
                }
            }
            finally {
                resultTreeList.EndUpdate();
            }
        }
    }

    public class NumberCultureDescription {
        public NumberCulture Id { get; set; }
        public string Name { get; set; }
        public int CardinalNodeId { get; set; }
        public int OrdinalNodeId { get; set; }
        public NumberCultureDescription(NumberCulture id, string name) {
            Id = id;
            Name = name;
            CardinalNodeId = -1;
            OrdinalNodeId = -1;
        }
    }
}
