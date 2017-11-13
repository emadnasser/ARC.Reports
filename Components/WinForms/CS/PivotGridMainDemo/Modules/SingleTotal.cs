using DevExpress.Data.PivotGrid;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class SingleTotal : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public SingleTotal() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\SingleTotal.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.SingleTotal.xml";

			// TODO: Add any initialization after the InitializeComponent call
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

		private void SingleTotal_Load(object sender, System.EventArgs e) {
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			fieldYear.FilterValues.FilterType = PivotFilterType.Included;
            fieldYear.FilterValues.Add(2015);
			fieldCategoryName.FilterValues.FilterType = PivotFilterType.Included;
			fieldCategoryName.FilterValues.Add("Beverages");
			fieldCategoryName.FilterValues.Add("Condiments");
			InitComboBoxes();
			AddOptions();
			pivotGridControl1.ValueImages = CategoryImageList;
            UpdateListBoxColor(clbOptions);
            ((PivotGridRibbonMenuManager)RibbonMenuManager).ViewOptionsChanged += OnRibbonViewOptionsChanged;
		}

        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            UpdateListBoxColor(clbOptions);
        }

		void InitComboBoxes() {
            icbSummaryType.Properties.Items.AddEnum(typeof(PivotSummaryType));
			foreach(PivotGridField field in pivotGridControl1.Fields) 
				if(field.Area == PivotArea.DataArea && field.Visible) {
					icbField.Properties.Items.Add(new ImageComboBoxItem(field.Caption.ToString(), field, -1));
				}
			icbField.SelectedIndex = 0;
		}
        //<clbOptions>
		void AddOptions() {
            List<string> excludedOptions = new List<string>(new string[] { "ShowCustomTotalsForSingleValues" });
            ArrayList arr = new ArrayList();
            PropertyDescriptorCollection pds = TypeDescriptor.GetProperties(pivotGridControl1.OptionsView);
            foreach(PropertyDescriptor pd in pds) {
                if (pd.PropertyType.Equals(typeof(bool)) && pd.Name.IndexOf("Total") > -1 && !excludedOptions.Contains(pd.Name)) {
                    arr.Add(pd.Name);
                }
            }
			arr.Sort();
			clbOptions.DataSource = arr;
			for(int i = 0; i < clbOptions.ItemCount; i++) 
				clbOptions.SetItemChecked(i, SetOptions.OptionValueByString(clbOptions.GetItemText(i), pivotGridControl1.OptionsView));
		}
        private void OnRibbonViewOptionsChanged(object s, DevExpress.XtraPivotGrid.Demos.ViewOptionsChangedEventArgs arg) {
			if(((PivotGridRibbonMenuManager)RibbonMenuManager).CurrentPivotGrid != pivotGridControl1)
				return;
            for(int i = 0; i < clbOptions.ItemCount; i++) {
                if(clbOptions.GetItemText(i) == arg.Name) {
                    clbOptions.SetItemChecked(i, arg.Value);
                    return;
                }
            }
        }
        private void clbOptions_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e) {
            SetOptions.SetOptionValueByString(clbOptions.GetItemText(e.Index), pivotGridControl1.OptionsView, e.State == CheckState.Checked);
            ((PivotGridRibbonMenuManager)RibbonMenuManager).RefreshOptionsMenu(pivotGridControl1);
		}
        //</clbOptions>
        //<icbField>
		private void icbField_SelectedIndexChanged(object sender, System.EventArgs e) {
			PivotGridField field = icbField.EditValue as PivotGridField;
			if(field == null) return;
			icbSummaryType.EditValue = field.SummaryType;
			SetFieldFont(field);
            field.Appearance.ValueTotal.BackColor = Color.LightSkyBlue;
		}        
		void SetFieldFont(PivotGridField field) {
			foreach(PivotGridField fld in pivotGridControl1.Fields) 
				if(fld != field) {
					if(fld.Appearance.Header.Font.Bold)
						fld.Appearance.Header.Font = new Font(fld.Appearance.Header.Font, FontStyle.Regular);	
				} else fld.Appearance.Header.Font = new Font(fld.Appearance.Header.Font, FontStyle.Bold);	
		}
        //</icbField>
        //<icbSummaryType>
		private void icbSummaryType_SelectedIndexChanged(object sender, System.EventArgs e) {
			PivotGridField field = icbField.EditValue as PivotGridField;
			if(field == null) return;
			field.SummaryType = (PivotSummaryType)icbSummaryType.EditValue;
            CorrectCellFormat(field);
		}        
        void CorrectCellFormat(PivotGridField field) {
            switch(field.SummaryType) {
                case PivotSummaryType.Average:
                case PivotSummaryType.Max:
                case PivotSummaryType.Min:
                case PivotSummaryType.Sum:
                case PivotSummaryType.Custom:
                case PivotSummaryType.StdDev:
                case PivotSummaryType.StdDevp:
                    if(field == fieldDiscount)
                        field.CellFormat.FormatString = "p";
                    else if(field == fieldQuantity)
                        field.CellFormat.FormatString = "n0";
                    else
                        field.CellFormat.FormatString = "c2";
                    break;
                case PivotSummaryType.Count:
                case PivotSummaryType.Var:
                case PivotSummaryType.Varp:
                    field.CellFormat.FormatString = "n0";
                    break;
                default:
                    throw new ArgumentException("Incorrect SummaryType");
            }
        }
        //</icbSummaryType>
        private void pivotGridControl1_CustomDrawFieldHeader(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawFieldHeaderEventArgs e) {
			if(e.Field.Area == PivotArea.DataArea)
				e.Appearance.ForeColor = Blue;
			if(e.Field.Caption == "Data")
				e.Appearance.ForeColor = Red;
		}

		private void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
			if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
				e.ImageIndex = GetCategoryIndexByName(e.Value);
		}

		protected override void OnSetCaption(string fCaption) {
			Caption.Text = "Single Total (Automatic Totals)";
		}
        //Custom total - percent of max value in sum
        void pivotGridControl1_CustomSummary(object sender, PivotGridCustomSummaryEventArgs e) {
            PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
            decimal max = 0, sum = 0;
            foreach(PivotDrillDownDataRow row in ds) {
                decimal value = Convert.ToDecimal(row[e.DataField]);
                max = max < value ? value : max;
                sum += value;
            }
            if(sum != 0)
                e.CustomValue = max / sum * 100;
            else
                e.CustomValue = "";
        }
	}
}

