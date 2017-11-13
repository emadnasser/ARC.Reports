using System;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	public class GridUnboundModeViaCollectionRecord {
		private int fID;
		private string fProductName;
		private string fCategory;
		private bool fDiscontinued;
		private double fUnitPrice;

		public GridUnboundModeViaCollectionRecord(int fID, string fProductName, string fCategory, bool fDiscontinued, double fUnitPrice) {
			this.fID = fID;
			this.fProductName = fProductName;
			this.fCategory = fCategory;
			this.fDiscontinued = fDiscontinued;
			this.fUnitPrice = fUnitPrice;
		}

		public int ID {
			get { return fID; }
		}

		public string ProductName {
			get { return fProductName; }
			set { fProductName = value; }
		}

		public string Category {
			get { return fCategory; }
			set { fCategory = value; }
		}

		public bool Discontinued {
			get { return fDiscontinued; }
			set { fDiscontinued = value; }
		}

		public double UnitPrice {
			get { return fUnitPrice; }
			set { fUnitPrice = value; }
		}
	}
}
