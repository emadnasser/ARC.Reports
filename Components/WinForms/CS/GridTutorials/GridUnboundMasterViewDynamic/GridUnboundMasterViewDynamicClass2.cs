using System;
using System.Collections;
using DevExpress.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	public class GridUnboundMasterViewDynamicRecords : ArrayList, DevExpress.Data.IRelationList {
		public GridUnboundMasterViewDynamicRecords() {
			Add(new GridUnboundMasterViewDynamicMainRecord(1, "John", "Smith"));
			Add(new GridUnboundMasterViewDynamicMainRecord(2, "Mike", "Jones"));
			Add(new GridUnboundMasterViewDynamicMainRecord(3, "Helene", "Andersson"));
			Add(new GridUnboundMasterViewDynamicMainRecord(4, "Nick", "Sandberg"));
			Add(new GridUnboundMasterViewDynamicMainRecord(5, "Joe", "Black"));
		}
		private GridUnboundMasterViewDynamicChildRecords cr = new GridUnboundMasterViewDynamicChildRecords();
		//IRelationList
		string IRelationList.GetRelationName(int index, int relationIndex) {
			return (relationIndex == 0) ? "Sons" : "Daughters";
		}
		
		int IRelationList.RelationCount {
			get { return 2; }
		}

		IList IRelationList.GetDetailList(int index, int relationIndex)	{
			return cr.GetSubset(this[index].ID, relationIndex);
		}

		bool IRelationList.IsMasterRowEmpty(int index, int relationIndex) {
			return cr.Childs(this[index].ID, relationIndex);
		}
		//IRelationList

		public virtual new GridUnboundMasterViewDynamicMainRecord this[int index] {
			get {return (GridUnboundMasterViewDynamicMainRecord)(base[index]);}
		}
	}
	public class GridUnboundMasterViewDynamicMainRecord	{

		private int fID;
		private string fFirstName;
		private string fLastName;

		public int ID {
			get { return fID; }
		}

		public string FirstName	{
			get { return fFirstName;	}
			set { fFirstName = value; }
		}
		
		public string LastName {
			get { return fLastName; }
			set { fLastName = value;	}
		}

		public GridUnboundMasterViewDynamicMainRecord(int fID, string fFirstName, string fLastName) {
			this.fID = fID;
			this.fFirstName = fFirstName;
			this.fLastName = fLastName;
		}

	}
	public class GridUnboundMasterViewDynamicChildRecords: ArrayList {
		public GridUnboundMasterViewDynamicChildRecords() {
			Add(new GridUnboundMasterViewDynamicChildRecord("Tom", 12, true, 1));
			Add(new GridUnboundMasterViewDynamicChildRecord("Susan", 13, false, 1));
			Add(new GridUnboundMasterViewDynamicChildRecord("Louis", 14, true, 1));
			Add(new GridUnboundMasterViewDynamicChildRecord("Irene", 5, false, 2));
			Add(new GridUnboundMasterViewDynamicChildRecord("Martha", 10, false, 2));
			Add(new GridUnboundMasterViewDynamicChildRecord("Samuel", 7, true, 3));
			Add(new GridUnboundMasterViewDynamicChildRecord("Louisa", 17, false, 3));
			Add(new GridUnboundMasterViewDynamicChildRecord("Mark", 8, true, 4));
			Add(new GridUnboundMasterViewDynamicChildRecord("Sadie", 4, false, 3));
		}
		
		public virtual new GridUnboundMasterViewDynamicChildRecord this[int index] {
			get {return (GridUnboundMasterViewDynamicChildRecord)(base[index]); }
		}
		
		public IList GetSubset(int index, int relationIndex) {
			IList list = new System.Collections.ArrayList();
			for(int i = 0; i < this.Count; i++) {
				if (this[i].ParentID == index) {
					if (this[i].IsSon() && relationIndex == 0)
						list.Add(this[i]);
					if (!this[i].IsSon() && relationIndex == 1)
						list.Add(this[i]);
				}
			}
			return list;
		}
		public bool Childs(int index, int relationIndex) {
			for(int i = 0; i < this.Count; i++) {
				if (this[i].ParentID == index) {
					if (this[i].IsSon() && relationIndex == 0)
						return false;
					if (!this[i].IsSon() && relationIndex == 1)
						return false;
				}
			}
			return true;
		}
	}
	public class GridUnboundMasterViewDynamicChildRecord {
		private int fAge;
		private string fName;
		private bool fIsSon;
		private int fParentID;
        
		public bool IsSon() {
			return fIsSon;
		}

		public int Age {
			get { return fAge; }
			set { fAge = value; }
		}
		public string Name {
			get { return fName; }
			set { fName = value; }
		}
		public int ParentID {
			get { return fParentID; }
		}
		public GridUnboundMasterViewDynamicChildRecord (string fName, int fAge, bool fIsSon, int fParentID) {
			this.fName = fName;
			this.fAge = fAge;
			this.fIsSon = fIsSon;
			this.fParentID = fParentID;
		}
	}
}
