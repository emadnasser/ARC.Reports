using System;
using System.Collections;
using DevExpress.Data;
using System.ComponentModel;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	public class VirtualPropertyDescriptor : PropertyDescriptor {
		string fPropertyName;
		Type fPropertyType;
		bool fIsReadOnly;
		VirtualList fList;
		int fIndex;
		public VirtualPropertyDescriptor(VirtualList fList, int fIndex, string fPropertyName, Type fPropertyType, bool fIsReadOnly) : base(fPropertyName, null) {
			this.fPropertyName = fPropertyName;
			this.fPropertyType = fPropertyType;
			this.fIsReadOnly = fIsReadOnly;
			this.fList = fList;
			this.fIndex = fIndex;
		}
		public override bool CanResetValue(object component) {
			return false;
		}
		public override object GetValue(object component) {
			return fList.GetRowValue(component, fIndex);
		}
		public override void SetValue(object component, object val) {
			fList.SetRowValue(component, fIndex, val);
		}
		public override bool IsReadOnly {get { return fIsReadOnly; } }
		public override string Name { get { return fPropertyName; } }
		public override Type ComponentType { get { return typeof(VirtualList); } }
		public override Type PropertyType { get { return fPropertyType; } }
		public override void ResetValue(object component) {
		}
		public override bool ShouldSerializeValue(object component) { return true; }
	}
	public class VirtualList : IList, ITypedList {
		int fRecordCount;
		int fColumnCount;
		Hashtable fValues;
		PropertyDescriptorCollection fColumnCollection;
		bool fUseDataStore = false;
		public VirtualList() {
			fValues = new Hashtable();
			fRecordCount = 1000;
			fColumnCount = 1000;
			CreateColumnCollection();
		}
		public virtual Hashtable Values { get { return fValues; } }
		public virtual object GetRowKey(int rowIndex, int colIndex) {
			return string.Format("row {0}, col {1}", rowIndex, colIndex);
		}
		internal object GetRowValue(object row, int colIndex) {
			int fIndex = (int)row;
			if(!UseDataStore) return GetRowKey(fIndex, colIndex);
			return Values[GetRowKey(fIndex, colIndex)];
		}
		internal void SetRowValue(object row, int colIndex, object val) { 
			if(!UseDataStore) return;
			int fIndex = (int)row;
			Values[GetRowKey(fIndex, colIndex)] = val;
		}
		public virtual bool UseDataStore {
			get { return fUseDataStore; }
			set { fUseDataStore = value; }
		}
		public int RecordCount { 
			get { return fRecordCount; }
			set {
				if(value < 1) value = 0;
				if(RecordCount == value) return;
				fRecordCount = value;
			}
		}
		public int ColumnCount { 
			get { return fColumnCount; }
			set {
				if(value < 1) value = 0;
				if(ColumnCount == value) return;
				fColumnCount = value;
				CreateColumnCollection();
			}
		}
		protected virtual void CreateColumnCollection() {
			VirtualPropertyDescriptor[] pds = new VirtualPropertyDescriptor[ColumnCount];
			for(int n = 0; n < ColumnCount; n++) {
				pds[n] = new VirtualPropertyDescriptor(this, n, string.Format("Column{0}", n + 1), typeof(string), false);
			}
			fColumnCollection = new PropertyDescriptorCollection(pds);
		}
		
		#region ITypedList Interface
		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] descs) { return fColumnCollection; }
		string ITypedList.GetListName(PropertyDescriptor[] descs) { return ""; }
		#endregion
		#region IList Interface
		public virtual int Count { get { return RecordCount; }
		}
		public virtual bool IsSynchronized { get { return true; }
		}
		public virtual object SyncRoot { get { return true; }
		}
		public virtual bool IsReadOnly{ get { return false; } 
		}
		public virtual bool IsFixedSize{ get { return true; } 
		}
		public virtual IEnumerator GetEnumerator() { 
			return null;
		}
		public virtual void CopyTo(System.Array array, int fIndex) {
		}
		public virtual int Add(object val) {
			throw new NotImplementedException();
		}
		public virtual void Clear() {
			throw new NotImplementedException();
		}
		public virtual bool Contains(object val) {
			throw new NotImplementedException();
		}
		public virtual int IndexOf(object val) {
			throw new NotImplementedException();
		}
		public virtual void Insert(int fIndex, object val) {
			throw new NotImplementedException();
		}
		public virtual void Remove(object val) { 
			throw new NotImplementedException();
		}
		public virtual void RemoveAt(int fIndex) {
			throw new NotImplementedException();
		}
		object IList.this[int fIndex] { 
			get { return fIndex; }  
			set	{ }
		}
		#endregion
	}
}
