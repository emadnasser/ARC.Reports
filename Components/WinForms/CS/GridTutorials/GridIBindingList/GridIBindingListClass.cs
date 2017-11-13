using System;
using System.Collections;
using System.ComponentModel;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	public class GridIBindingListRecord : IEditableObject {
		private string fName;
		private double fPayment;
		private DateTime fDate;
		private GridIBindingListRecords fRecords;

		private bool committed;
		private bool editing;
		GridIBindingListRecord fRecordCache;

		public GridIBindingListRecord() {}
		public GridIBindingListRecord(GridIBindingListRecords fRecords) {
			this.fRecords = fRecords;
			this.fDate = DateTime.Now;
			committed = false;
		}
		public GridIBindingListRecord(GridIBindingListRecords fRecords, string fName, double fPayment, DateTime fDate) {
			this.fRecords = fRecords;
			this.fName = fName;
			this.fPayment = fPayment;
			this.fDate = fDate;
			committed = true;
		}
		private void OnListChanged() {
			if(fRecords == null) return;
			int index = fRecords.IndexOf(this);
			fRecords.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, index));
		}
		public string Name {
			get { return fName; }
			set { 
				fName = value; 
				OnListChanged();
			}
		}
		public double Payment {
			get { return fPayment; }
			set { 
				fPayment = value; 
				OnListChanged();
			}
		}
		public DateTime PurchaseDate {
			get { return fDate; }
			set { 
				fDate = value; 
				OnListChanged();
			}
		}
		public void Assign(GridIBindingListRecord rec) {
			this.Name = rec.Name;
			this.Payment = rec.Payment;
			this.PurchaseDate = rec.PurchaseDate;
		}
		GridIBindingListRecord RecordCache { 
			get {
				if(fRecordCache == null) fRecordCache = new GridIBindingListRecord();
				return fRecordCache;
			}
		}
		public void BeginEdit() {
			editing = true;
			RecordCache.Assign(this);
		}
		public void CancelEdit() {
			if (!committed) 
				((IList)fRecords).Remove(this);
			if(editing) this.Assign(RecordCache);
		}
		public void EndEdit() {
			committed = true;
			editing = false;
		}
	}
		
	public class GridIBindingListRecords : CollectionBase, IBindingList {
		public void Add(GridIBindingListRecord record) {
			base.List.Add(record);
		}
		public GridIBindingListRecord this[int idx] {
			get { return (GridIBindingListRecord) base.List[idx]; }
		}
		
		public int IndexOf(GridIBindingListRecord record) {
			return List.IndexOf(record);
		}

		public object AddNew() {
			GridIBindingListRecord record = new GridIBindingListRecord(this);
			List.Add(record);
			return record;
		}
		public bool AllowEdit { get { return true; }}
		public bool AllowNew { get { return true; }}
		public bool AllowRemove { get { return true; }}
				
		private ListChangedEventHandler listChangedHandler;
		public event ListChangedEventHandler ListChanged {
			add { listChangedHandler += value; }
			remove { listChangedHandler -= value; }
		}
		internal void OnListChanged(ListChangedEventArgs args) {
			if (listChangedHandler != null) {
				listChangedHandler(this, args);
			}
		}
		protected override void OnRemoveComplete(int index, object value) {
			OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index) );
		}
		protected override void OnInsertComplete(int index,	object value) {
			OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index) );
		}

		public void AddIndex(PropertyDescriptor pd) { throw new NotSupportedException(); }
		public void ApplySort(PropertyDescriptor pd, ListSortDirection dir) { throw new NotSupportedException(); }
		public int Find(PropertyDescriptor property, object key) { throw new NotSupportedException(); }
		public bool IsSorted { get { return false; }}
		public void RemoveIndex(PropertyDescriptor pd) { throw new NotSupportedException(); }
		public void RemoveSort() { throw new NotSupportedException(); }
		public ListSortDirection SortDirection { get { throw new NotSupportedException(); }}
		public PropertyDescriptor SortProperty { get { throw new NotSupportedException(); }}
		public bool SupportsChangeNotification {get { return true; }}
		public bool SupportsSearching {	get { return false; }}
		public bool SupportsSorting { get { return false; }}
	}
}
