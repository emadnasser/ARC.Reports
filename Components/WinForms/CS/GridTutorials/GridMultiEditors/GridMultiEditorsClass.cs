using System;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	public class GridMultiEditorsRecord {
		private string fCategory;
		private object fProduct1;
		private object fProduct2;
		private object fProduct3;
		

		public GridMultiEditorsRecord(string fCategory, object fProduct1, object fProduct2, object fProduct3) {
			this.fCategory = fCategory;
			this.fProduct1 = fProduct1;
			this.fProduct2 = fProduct2;
			this.fProduct3 = fProduct3;
		}

		public string Category {
			get { return fCategory; }
		}

		public object Product1 {
			get { return fProduct1; }
			set { fProduct1 = value; }
		}

		public object Product2 {
			get { return fProduct2; }
			set { fProduct2 = value; }
		}

		public object Product3 {
			get { return fProduct3; }
			set { fProduct3 = value; }
		}
	}
}
