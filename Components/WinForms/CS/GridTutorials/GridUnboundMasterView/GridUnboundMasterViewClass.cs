using System;
using System.Collections;
using DevExpress.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	//<gridControl1>
	public class NestedRecords : ArrayList {
		public NestedRecords() {
			Add(new NestedRecord("Customers", new ChildRecordsCustomers()));
			Add(new NestedRecord("Products", new ChildRecordsProducts()));
			Add(new NestedRecord("Shippers", new ChildRecordsShippers()));
		}
		public virtual new NestedRecord this[int index] {
			get {return (NestedRecord)(base[index]);}
		}
	}
	public class NestedRecord	{
		private string fName;
		ArrayList fChildList = null;

		public NestedRecord(string name, ArrayList childList) {
			this.fName = name;
			this.fChildList = childList;
		}

		public string Name	{
			get { return fName;	}
			set { fName = value; }
		}

		public ArrayList ChildList {
			get { return fChildList; }
			set { fChildList = value; }
		}
	}
	public class IRelationListRecords : ArrayList, DevExpress.Data.IRelationList {
		public IRelationListRecords() {
			Add(new IRelationListRecord("Customers"));
			Add(new IRelationListRecord("Products"));
			Add(new IRelationListRecord("Shippers"));
		}
		//IRelationList
		string IRelationList.GetRelationName(int index, int relationIndex) {
			if(index != GridControl.InvalidRowHandle)
				return ((IRelationListRecord)this[index]).Name;
			else return "";
		}
		
		int IRelationList.RelationCount {
			get { return 1; }
		}

		IList IRelationList.GetDetailList(int index, int relationIndex)	{
			switch(((IRelationListRecord)this[index]).Name) {
				case "Customers":
					return new ChildRecordsCustomers();
				case "Products":
					return new ChildRecordsProducts();
				case "Shippers":
					return new ChildRecordsShippers();
			}
			return null;								
		}

		bool IRelationList.IsMasterRowEmpty(int index, int relationIndex) {
			return false;
		}
		//IRelationList

		public virtual new IRelationListRecord this[int index] {
			get {return (IRelationListRecord)(base[index]);}
		}
	}
	public class IRelationListRecord	{
		private string fName;

		public string Name	{
			get { return fName;	}
			set { fName = value; }
		}
				
		public IRelationListRecord(string fName) {
			this.fName = fName;
		}
	}
	//</gridControl1>
	public class ChildRecordsProducts: ArrayList {
		public ChildRecordsProducts() {
			Add(new ChildRecordProduct("Grandma's Boysenberry Spread", 25.00, 120, 0, 25));
			Add(new ChildRecordProduct("Ikura", 31.00, 1, 0, 0));
			Add(new ChildRecordProduct("Tofu", 23.25, 35, 0, 0));
			Add(new ChildRecordProduct("Sir Rodney's Marmalade", 81.00, 40, 0, 0));
			Add(new ChildRecordProduct("Ipoh Coffee", 46.00, 17, 10, 25));
		}
	}
	public class ChildRecordsCustomers: ArrayList {
		public ChildRecordsCustomers() {
			Add(new ChildRecordCustomer("Thomas Hardy", "120 Hanover Sq.", false));
			Add(new ChildRecordCustomer("Hanna Moos", "Forsterstr. 57", true));
			Add(new ChildRecordCustomer("Ann Devon", "35 King George", false));
			Add(new ChildRecordCustomer("Roland Mendel", "Kirchgasse 6", true));
		}
	}
	public class ChildRecordsShippers: ArrayList {
		public ChildRecordsShippers() {
			Add(new ChildRecordShipper("Speedy Express", "(503) 555-9831"));
			Add(new ChildRecordShipper("United Package", "(503) 555-3199"));
			Add(new ChildRecordShipper("Federal Shipping", "(503) 555-9931"));
		}
	}
	public class ChildRecordShipper {
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
				
		public ChildRecordShipper (string fName, string fPhone) {
			this.fName = fName;
			this.fPhone = fPhone;
		}
	}
	public class ChildRecordCustomer {
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

		public ChildRecordCustomer(string fName, string fAddress, bool fHasDiscount) {
			this.fName = fName;
			this.fAddress = fAddress;
			this.fHasDiscount = fHasDiscount;
		}
	}
	public class ChildRecordProduct {
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
				
		public ChildRecordProduct(string fName, double fPrice, int fUnitsInStock, int fUnitsOnOrder, int fLevel) {
			this.fName = fName;
			this.fPrice = fPrice;
			this.fUnitsInStock = fUnitsInStock;
			this.fUnitsOnOrder = fUnitsOnOrder;
			this.fLevel = fLevel;
		}
	}
}
