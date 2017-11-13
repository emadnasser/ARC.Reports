using System;
using System.Collections;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	public class GridUnboundMasterViewDynamicRecord	{
		private string fName;

		public string Name	{
			get { return fName;	}
			set { fName = value; }
		}
				
		public GridUnboundMasterViewDynamicRecord(string fName) {
			this.fName = fName;
		}
	}
	public class ChildRecordsProductsDynamic: ArrayList {
		public ChildRecordsProductsDynamic() {
			Add(new ChildRecordProductDynamic("Grandma's Boysenberry Spread", 25.00, 120, 0, 25));
			Add(new ChildRecordProductDynamic("Ikura", 31.00, 1, 0, 0));
			Add(new ChildRecordProductDynamic("Tofu", 23.25, 35, 0, 0));
			Add(new ChildRecordProductDynamic("Sir Rodney's Marmalade", 81.00, 40, 0, 0));
			Add(new ChildRecordProductDynamic("Ipoh Coffee", 46.00, 17, 10, 25));
		}
	}
	public class ChildRecordsCustomersDynamic: ArrayList {
		public ChildRecordsCustomersDynamic() {
			Add(new ChildRecordCustomerDynamic("Thomas Hardy", "120 Hanover Sq.", false));
			Add(new ChildRecordCustomerDynamic("Hanna Moos", "Forsterstr. 57", true));
			Add(new ChildRecordCustomerDynamic("Ann Devon", "35 King George", false));
			Add(new ChildRecordCustomerDynamic("Roland Mendel", "Kirchgasse 6", true));
		}
	}
	public class ChildRecordsShippersDynamic: ArrayList {
		public ChildRecordsShippersDynamic() {
			Add(new ChildRecordShipperDynamic("Speedy Express", "(503) 555-9831"));
			Add(new ChildRecordShipperDynamic("United Package", "(503) 555-3199"));
			Add(new ChildRecordShipperDynamic("Federal Shipping", "(503) 555-9931"));
		}
	}
	public class ChildRecordShipperDynamic {
		private string fName;
		private string fPhone;
		
		public string CompanyName {
			get { return fName; }
			set { fName = value; }
		}

		public string Phone {
			get { return fPhone; }
			set { fPhone = value; }
		}
				
		public ChildRecordShipperDynamic (string fName, string fPhone) {
			this.fName = fName;
			this.fPhone = fPhone;
		}
	}
	public class ChildRecordCustomerDynamic {
		private string fName;
		private string fAddress;
		private bool fHasDiscount;
        		
		public string ContactName {
			get { return fName; }
			set { fName = value; }
		}

		public string Address {
			get { return fAddress; }
			set { fAddress = value; }
		}

		public bool HasDiscount {
			get { return fHasDiscount; }
			set { fHasDiscount = value; }
		}

		public ChildRecordCustomerDynamic(string fName, string fAddress, bool fHasDiscount) {
			this.fName = fName;
			this.fAddress = fAddress;
			this.fHasDiscount = fHasDiscount;
		}
	}
	public class ChildRecordProductDynamic {
		private string fName;
		private double fPrice;
		private int fUnitsInStock;
		private int fUnitsOnOrder;
		private int fLevel;
		
		public string ProductName {
			get { return fName; }
			set { fName = value; }
		}

		public double UnitPrice {
			get { return fPrice; }
			set { fPrice = value; }
		}

		public int UnitsInStock {
			get { return fUnitsInStock; }
			set { fUnitsInStock = value; }
		}

		public int UnitsOnOrder {
			get { return fUnitsOnOrder; }
			set { fUnitsOnOrder = value; }
		}

		public int ReorderLevel {
			get { return fLevel; }
			set { fLevel = value; }
		}
				
		public ChildRecordProductDynamic(string fName, double fPrice, int fUnitsInStock, int fUnitsOnOrder, int fLevel) {
			this.fName = fName;
			this.fPrice = fPrice;
			this.fUnitsInStock = fUnitsInStock;
			this.fUnitsOnOrder = fUnitsOnOrder;
			this.fLevel = fLevel;
		}
	}
}
