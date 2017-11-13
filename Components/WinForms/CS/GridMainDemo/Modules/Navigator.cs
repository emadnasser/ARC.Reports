using System;
using System.Collections;
using DevExpress.Data;
using System.Data;

namespace DevExpress.XtraGrid.Demos {
	public class NWTables : ArrayList, DevExpress.Data.IRelationList {
		private DataSet dataSet;
		public NWTables(DataSet ds) {
			Add(new NWTable(Properties.Resources.SuppliersTable, "Suppliers"));
			Add(new NWTable(Properties.Resources.CategoriesTable, "Categories"));
			Add(new NWTable(Properties.Resources.EmployeesTable, "Employees"));
			Add(new NWTable(Properties.Resources.ShippersTable, "Shippers"));
			Add(new NWTable(Properties.Resources.CustomersTable, "Customers"));
            Add(new NWTable(Properties.Resources.OrdersTable, "Orders500"));
			dataSet = ds;
		}
		//IRelationList
		string IRelationList.GetRelationName(int index, int relationIndex) {
			if(index >= 0 && index < this.Count)
				return this[index].RelationName;
			return "";
		}
		
		int IRelationList.RelationCount {
			get { return dataSet.Tables.Count > 0 ? 1 : 0; }
		}

		IList IRelationList.GetDetailList(int index, int relationIndex)	{
			if(dataSet.Tables.Count > 0) 
				return dataSet.Tables[((NWTable)this[index]).TableName()].DefaultView;
			return null;
		}

		bool IRelationList.IsMasterRowEmpty(int index, int relationIndex) {
			return false;
		}
		//IRelationList

		public virtual new NWTable this[int index] {
			get {return (NWTable)(base[index]);}
		}
	}
	
	public class NWTable	{

		private string fname;
		private string ftablename;
		
		public string Name {
			get { return fname;	}
		}
		
		internal string RelationName {
			get { return ftablename;	}
		}

		public string TableName() {
			return ftablename;
		}
		
		public NWTable(string fname, string ftablename) {
			this.fname = fname;
			this.ftablename = ftablename;
		}
	}
}
