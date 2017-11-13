using System;
using System.Collections;
using DevExpress.Data;
using System.ComponentModel;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	public class VirtualPropertyDescriptorDynamic : PropertyDescriptor {
		string fPropertyName;
		Type fPropertyType;
		bool fIsReadOnly;
		VirtualListDynamic fList;
		int fIndex;
		public VirtualPropertyDescriptorDynamic(VirtualListDynamic fList, int fIndex,string fPropertyName, Type fPropertyType, bool fIsReadOnly) : base(fPropertyName, null) {
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
		public override Type ComponentType { get { return typeof(VirtualListDynamic); } }
		public override Type PropertyType { get { return fPropertyType; } }
		public override void ResetValue(object component) {
		}
		public override bool ShouldSerializeValue(object component) { return true; }
	}
	public class VirtualListDynamic : IBindingList, ITypedList {
		int fRecordCount;
		int fColumnCount;
		Hashtable fValues;
		PropertyDescriptorCollection fColumnCollection;
		bool fUseDataStore = true;
		ListChangedEventHandler listChangedHandler;
		public VirtualListDynamic() {
			fValues = new Hashtable();
			fRecordCount = 7;
			fColumnCount = 3;
			CreateColumnCollection();
		}
		public virtual Hashtable Values { get { return fValues; } }
		public virtual object GetRowKey(int rowIndex, int colIndex) {
			return string.Format("row {0}, col {1}", rowIndex, colIndex);
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
			VirtualPropertyDescriptorDynamic[] pds = new VirtualPropertyDescriptorDynamic[ColumnCount];
			for(int n = 0; n < ColumnCount; n++) {
				pds[n] = new VirtualPropertyDescriptorDynamic(this, n, GetColumnName(n), typeof(string), false);
			}
			fColumnCollection = new PropertyDescriptorCollection(pds);
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
			RaiseListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, fIndex, fIndex));
		}

		#region IBindingList Interface
		void IBindingList.AddIndex(PropertyDescriptor pd) {
			throw new NotImplementedException();
		}
		object IBindingList.AddNew() { 
			++fRecordCount; 
			RaiseListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, RecordCount - 1, -1));
			return RecordCount - 1;
		}
		public virtual void AddColumn() {
			int cc = ColumnCount;
			ColumnCount ++;
			if(cc != ColumnCount) {
				RaiseListChanged(new ListChangedEventArgs(ListChangedType.PropertyDescriptorAdded, ColumnCount - 1, -1));
			}
		}
		public virtual string GetColumnName(int columnIndex) {
			return string.Format("Column{0}", columnIndex + 1);
		}
		public virtual void RemoveLastColumn() {
			int cc = ColumnCount;
			ColumnCount --;
			if(cc != ColumnCount) {
				RaiseListChanged(new ListChangedEventArgs(ListChangedType.PropertyDescriptorDeleted, -1, ColumnCount));
			}
		}
		public virtual void AddNew() {
			((IBindingList)this).AddNew();
		}
		bool IBindingList.AllowEdit { get { return true; } }
		bool IBindingList.AllowNew { get { return true; } }
		bool IBindingList.AllowRemove { get { return false; } }
		void IBindingList.ApplySort(PropertyDescriptor pd, ListSortDirection dir) {
			throw new NotImplementedException();
		}
		int IBindingList.Find(PropertyDescriptor pd, object key) {
			throw new NotImplementedException();
		}
		bool IBindingList.IsSorted { get { return false; } }
		void IBindingList.RemoveIndex(PropertyDescriptor pd) {
			throw new NotImplementedException();
		}
		public event ListChangedEventHandler ListChanged {
			add { listChangedHandler += value; }
			remove { listChangedHandler -= value; }
		}
		protected virtual void RaiseListChanged(ListChangedEventArgs args) {
			if (listChangedHandler != null) {
				listChangedHandler(this, args);
			}
		}
		void IBindingList.RemoveSort() {
			throw new NotImplementedException();
		}
		ListSortDirection IBindingList.SortDirection { get { return ListSortDirection.Ascending; } }
		PropertyDescriptor IBindingList.SortProperty { get { return null; } }
		bool IBindingList.SupportsChangeNotification { get { return true; } }
		bool IBindingList.SupportsSorting { get { return false; } }
		bool IBindingList.SupportsSearching { get { return false; } }
		#endregion
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
			get { return fIndex;  }  
			set	{ }
		}
		#endregion
	}
}
