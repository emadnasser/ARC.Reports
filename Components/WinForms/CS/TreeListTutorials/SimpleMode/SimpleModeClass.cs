using System;
using System.Collections;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
	public enum RecordType {Category, Product}; 
	//<treeList1>
    public class SimpleModeRecords : ArrayList {
		public SimpleModeRecords() {
			this.Add(new SimpleModeRecord("Dairy Products", RecordType.Category, 0, "", 0));
			this.Add(new SimpleModeRecord("Queso Manchego La Pastora", RecordType.Product, 37.89, "Cooperativa de Quesos", 1, 0));
			this.Add(new SimpleModeRecord("Queso Cabrales", RecordType.Product, 21.0, "Cooperativa de Quesos", 2, 0));
			this.Add(new SimpleModeRecord("Gorgonzola Telino", RecordType.Product, 12.5, "Formaggi Fortini", 3, 0));
			this.Add(new SimpleModeRecord("Confections", RecordType.Category, 0, "", 4));
			this.Add(new SimpleModeRecord("Sir Rodney's Marmalade", RecordType.Product, 81.0, "Specialty Biscuits, Ltd.", 5, 4));
			this.Add(new SimpleModeRecord("Sir Rodney's Scones", RecordType.Product, 10.1, "Specialty Biscuits, Ltd.", 6, 4));
			this.Add(new SimpleModeRecord("Gula Malacca", RecordType.Product, 19.45, "Leka Trading", 7, 4));
			this.Add(new SimpleModeRecord("Grandma's Boysenberry Spread", RecordType.Product, 25.0, "Grandma Kelly's Homestead", 8, 4));
			this.Add(new SimpleModeRecord("Pavlova", RecordType.Product, 17.45, "Pavlova, Ltd.", 9, 4));
		}
	}
    //</treeList1>
	public class SimpleModeRecord {
		private int id;
		private int parentID;
		private string name;
		private RecordType status;
		private double price;
		private string supplier;
		public SimpleModeRecord(string name, RecordType status, double price, string supplier, int id) : this(name, status, price, supplier, id, -1) {}
		public SimpleModeRecord(string name, RecordType status, double price, string supplier, int id, int parentID) {
			this.id = id;
			this.parentID = parentID;
			this.name = name;
			this.status = status;
			this.price = price;
			this.supplier = supplier;
		}
		public int ID {
			get { return id; }
		}
		public int ParentID {
			get { return parentID; }
		}
		public int ImageIndex {
			get { return status == RecordType.Category ? 0 : 1; }
		}
		public string Name {
			get { return name; }
			set { name = value; }
		}
		public RecordType Status {
			get { return status; }
		}
		public double Price {
			get { return price; }
			set { 
				if(status == RecordType.Product)
					price = value; 
			}
		}
		public string Supplier {
			get { return supplier; }
			set { supplier = value; }
		}
	}
}
