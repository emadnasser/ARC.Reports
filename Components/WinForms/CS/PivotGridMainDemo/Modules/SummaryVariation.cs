using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;
using System.Collections.Generic;
using DevExpress.Utils;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class SummaryVariation : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public SummaryVariation() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\SummaryVariation.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.SummaryVariation.xml";
		}
        
        enum SummaryDisplayTypeGroup { Variation = 0, Percentage = 1, Rank = 2, Index = 3 };

        SummaryDisplayTypeGroup SelectedGroup {
            get { return (SummaryDisplayTypeGroup)(rgSummaryDisplayTypeGroup.SelectedIndex); }
        }

        PivotGridField SourceDataField { get; set; }
        PivotGridField SummaryDisplayTypeDataField { get; set; }

        void InitSummaryDisplayTypeGroupRadioGroup() {
            Type typeGroupType = typeof(SummaryDisplayTypeGroup);
            foreach(SummaryDisplayTypeGroup typeGroup in Enum.GetValues(typeGroupType))
                rgSummaryDisplayTypeGroup.Properties.Items.Add(new RadioGroupItem(typeGroup, Enum.GetName(typeGroupType, typeGroup)));
            rgSummaryDisplayTypeGroup.SelectedIndex = 0;
        }

		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

		private void SummaryVariation_Load(object sender, System.EventArgs e) {
            pivotGridControl1.ValueImages = CategoryImageList;
            InitSummaryDisplayTypeGroupRadioGroup();
		}
        //<rgSummaryDisplayTypeGroup>
        void ConfigureSummaryDisplayTypeComboBox(SummaryDisplayTypeGroup typeGroup) {
            List<PivotSummaryDisplayType> types = new List<PivotSummaryDisplayType>();
            switch(typeGroup) {
                case SummaryDisplayTypeGroup.Variation:
                    types.Add(PivotSummaryDisplayType.AbsoluteVariation);
                    types.Add(PivotSummaryDisplayType.PercentVariation);
                    break;
                case SummaryDisplayTypeGroup.Percentage:
                    types.Add(PivotSummaryDisplayType.PercentOfColumn);
                    types.Add(PivotSummaryDisplayType.PercentOfRow);
                    types.Add(PivotSummaryDisplayType.PercentOfColumnGrandTotal);
                    types.Add(PivotSummaryDisplayType.PercentOfRowGrandTotal);
                    types.Add(PivotSummaryDisplayType.PercentOfGrandTotal);
                    break;
                case SummaryDisplayTypeGroup.Rank:
                    types.Add(PivotSummaryDisplayType.RankInColumnLargestToSmallest);
                    types.Add(PivotSummaryDisplayType.RankInColumnSmallestToLargest);
                    types.Add(PivotSummaryDisplayType.RankInRowLargestToSmallest);
                    types.Add(PivotSummaryDisplayType.RankInRowSmallestToLargest);
                    break;
                case SummaryDisplayTypeGroup.Index:
                    types.Add(PivotSummaryDisplayType.Index);
                    break;
            }
            icbSummaryDisplayType.Properties.Items.Clear();
            foreach(PivotSummaryDisplayType type in types)
                icbSummaryDisplayType.Properties.Items.Add(new ImageComboBoxItem(type));
            icbSummaryDisplayType.SelectedIndex = 0;
        }
        //<skip>
        void ConfigurePivotGridLayout(SummaryDisplayTypeGroup typeGroup) {
            pivotGridControl1.BeginUpdate();
            switch(typeGroup) {
                case SummaryDisplayTypeGroup.Variation:
                    {
                        pivotGridControl1.DataSource = GetNWindData("SalesPerson");
                        pivotGridControl1.Fields.Clear();
                        PivotGridField fieldYear = pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea);
                        fieldYear.GroupInterval = PivotGroupInterval.DateYear;
                        fieldYear.Caption = "Year";
                        PivotGridField fieldQuarter = pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea);
                        fieldQuarter.GroupInterval = PivotGroupInterval.DateQuarter;
                        fieldQuarter.ValueFormat.FormatString = "Qtr {0}";
                        fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        fieldQuarter.Caption = "Quarter";
                        pivotGridControl1.Fields.Add("Sales Person", PivotArea.RowArea);
                        SourceDataField = pivotGridControl1.Fields.Add("OrderID", PivotArea.DataArea);
                        SourceDataField.SummaryType = PivotSummaryType.Count;
                        SourceDataField.Caption = "Order Count";
                        SummaryDisplayTypeDataField = pivotGridControl1.Fields.Add(SourceDataField.FieldName, PivotArea.DataArea);
                        SummaryDisplayTypeDataField.SummaryType = SourceDataField.SummaryType;
                    }
                    break;
                case SummaryDisplayTypeGroup.Percentage:
                    {
                        pivotGridControl1.DataSource = GetNWindData("ProductReports");
                        pivotGridControl1.Fields.Clear();
                        PivotGridField fieldYear = pivotGridControl1.Fields.Add("ShippedDate", PivotArea.ColumnArea);
                        fieldYear.GroupInterval = PivotGroupInterval.DateYear;
                        fieldYear.Caption = "Year";
                        PivotGridField fieldMonth = pivotGridControl1.Fields.Add("ShippedDate", PivotArea.ColumnArea);
                        fieldMonth.GroupInterval = PivotGroupInterval.DateMonth;
                        fieldMonth.Caption = "Month";
                        pivotGridControl1.Fields.Add("CategoryName", PivotArea.RowArea);
                        pivotGridControl1.Fields.Add("ProductName", PivotArea.RowArea);
                        SourceDataField = pivotGridControl1.Fields.Add("ProductSales", PivotArea.DataArea);
                        SummaryDisplayTypeDataField = pivotGridControl1.Fields.Add(SourceDataField.FieldName, PivotArea.DataArea);
                    }
                    break;
                case SummaryDisplayTypeGroup.Rank: {
                        pivotGridControl1.DataSource = GetNWindData("SalesPerson");
                        pivotGridControl1.Fields.Clear();
                        PivotGridField fieldYear = pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea);
                        fieldYear.GroupInterval = PivotGroupInterval.DateYear;
                        fieldYear.Caption = "Year";
                        PivotGridField fieldQuarter = pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea);
                        fieldQuarter.GroupInterval = PivotGroupInterval.DateQuarter;
                        fieldQuarter.ValueFormat.FormatString = "Qtr {0}";
                        fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        fieldQuarter.Caption = "Quarter";
                        pivotGridControl1.Fields.Add("Country", PivotArea.RowArea);
                        pivotGridControl1.Fields.Add("Sales Person", PivotArea.RowArea);
                        SourceDataField = pivotGridControl1.Fields.Add("Extended Price", PivotArea.DataArea);
                        SourceDataField.Caption = "Sales";
                        SummaryDisplayTypeDataField = pivotGridControl1.Fields.Add(SourceDataField.FieldName, PivotArea.DataArea);
                    }
                    break;
                case SummaryDisplayTypeGroup.Index: {
                        pivotGridControl1.DataSource = GetNWindData("SalesPerson");
                        pivotGridControl1.Fields.Clear();
                        PivotGridField fieldYear = pivotGridControl1.Fields.Add("Country", PivotArea.ColumnArea);
                        pivotGridControl1.Fields.Add("CategoryName", PivotArea.RowArea);
                        SourceDataField = pivotGridControl1.Fields.Add("Extended Price", PivotArea.DataArea);
                        SourceDataField.Caption = "Sales";
                        SummaryDisplayTypeDataField = pivotGridControl1.Fields.Add(SourceDataField.FieldName, PivotArea.DataArea);
                    }
                    break;
            }

            pivotGridControl1.EndUpdate();
        }
        //</skip>
        private void rgSummaryDisplayTypeGroup_SelectedIndexChanged(object sender, System.EventArgs e) {
            ConfigurePivotGridLayout(SelectedGroup);
            bool isVariation = (SelectedGroup == SummaryDisplayTypeGroup.Variation);
            checkAllowCrossGroupVariation.Visible = isVariation;
            checkHideEmptyVariationItems.Visible = isVariation;
            if(SourceDataField != null)
                checkShowOriginalDataField.Checked = SourceDataField.Visible;
            ConfigureSummaryDisplayTypeComboBox(SelectedGroup);
        }
        //</rgSummaryDisplayTypeGroup>
		private void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
            if(e.Field != null && e.Field.FieldName == "CategoryName" && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
                e.ImageIndex = GetCategoryIndexByName(e.Value);
		}
        
        //<icbSummaryDisplayType>
		private void icbSummaryDisplayType_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(SummaryDisplayTypeDataField == null)
                return;
            SummaryDisplayTypeDataField.SummaryDisplayType = (PivotSummaryDisplayType)icbSummaryDisplayType.EditValue;
            SummaryDisplayTypeDataField.Caption = string.Format("{0}", SummaryDisplayTypeDataField.SummaryDisplayType);
		}
        //</icbSummaryDisplayType>
		private void pivotGridControl1_CustomDrawCell(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs e) {
            if(Comparer.ReferenceEquals(e.DataField, SummaryDisplayTypeDataField)) {
                if(e.Value == null)
                    return;
                DefaultBoolean isBlue = DefaultBoolean.Default;
                switch(SelectedGroup) {
                    case SummaryDisplayTypeGroup.Variation:
                        isBlue = Convert.ToDecimal(e.Value) >= 0 ? DefaultBoolean.True : DefaultBoolean.False;
                        break;
                    case SummaryDisplayTypeGroup.Percentage:
                    case SummaryDisplayTypeGroup.Rank:
                        if(SourceDataField != null && SourceDataField.Visible)
                            isBlue = DefaultBoolean.True;
                        break;
                    case SummaryDisplayTypeGroup.Index:
                        if(e.RowValueType != PivotGridValueType.GrandTotal && e.ColumnValueType != PivotGridValueType.GrandTotal)
                            isBlue = Convert.ToDecimal(e.Value) < 1 ? DefaultBoolean.True : DefaultBoolean.False;
                        break;
                }
                if(Comparer.Equals(isBlue, DefaultBoolean.Default))
                    return;
                e.Appearance.ForeColor = Comparer.Equals(isBlue, DefaultBoolean.True) ? Blue : Red;
            }
		}
        //<checkAllowCrossGroupVariation>
		private void checkAllowCrossGroupVariation_CheckedChanged(object sender, EventArgs e) {
			pivotGridControl1.OptionsData.AllowCrossGroupVariation = checkAllowCrossGroupVariation.Checked;
		}
        //</checkAllowCrossGroupVariation>
        //<checkHideEmptyVariationItems>
        private void checkHideEmptyVariationItems_CheckedChanged(object sender, EventArgs e) {
            if(SummaryDisplayTypeDataField != null)
                SummaryDisplayTypeDataField.Options.HideEmptyVariationItems = checkHideEmptyVariationItems.Checked;
        }
        //</checkHideEmptyVariationItems>
        //<checkShowOriginalDataField>
        private void checkShowOriginalDataField_CheckedChanged(object sender, EventArgs e) {
            if(SourceDataField != null)
                SourceDataField.Visible = checkShowOriginalDataField.Checked;
        }
        //</checkShowOriginalDataField>
	}
}

