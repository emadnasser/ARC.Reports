using System;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	public class FilteredDataView : DataView {
		string fAdditionalRowFilter = "", fRegularRowFilter = "";
		public FilteredDataView() {
		}
		public FilteredDataView(DataTable table) : base(table) {
		}

		public virtual string AdditionalRowFilter {
			get { return fAdditionalRowFilter; }
			set {
				if(value == null) value = "";
				value = value.Trim();
				if(value == AdditionalRowFilter) return;
				fAdditionalRowFilter = value;
				OnFilterChanged();
			}
		}
		public override string RowFilter { 
			get { return fRegularRowFilter; }
			set {
				if(value == null) value = "";
				value = value.Trim();
				if(value == RowFilter) return;
				fRegularRowFilter = value;
				OnFilterChanged();
			}
		}
		protected virtual void OnFilterChanged() {
			string filterString = RowFilter;
			if(RowFilter.Length > 0 &&  AdditionalRowFilter.Length > 0) {
				filterString = string.Format("({0}) AND ({1})", AdditionalRowFilter, RowFilter);
			} else 
				filterString = AdditionalRowFilter + RowFilter;
			base.RowFilter = filterString;
		}
	}
}
