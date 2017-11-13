using System;
using System.Collections;
using System.ComponentModel;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	public class NoteInfo : System.ComponentModel.IDataErrorInfo {
		int fDay;
		int fMonth;
		int fYear;
		int fNoteID;
		//References the item's owner
		ProjectNotes owner;
		//Stores error descriptions for the Day, Month, Year and NoteID properties
		Hashtable propertyErrors;
		//Stores an error description for the item
		string fNoteError;

            
		public NoteInfo(int noteID, int day, int month, int year) {
			fNoteID = noteID;
			fDay = day;
			fMonth = month;
			fYear = year;
			//Set errors to empty strings
			propertyErrors = new Hashtable();
			propertyErrors.Add("Day", "");
			propertyErrors.Add("Month", "");
			propertyErrors.Add("Year", "");
			propertyErrors.Add("NoteID", "");
			fNoteError = "";
			Owner = null;
		}

		public int NoteID {
			get { return fNoteID; }
			set { 
				if(fNoteID == value) return;
				fNoteID = value;
			}
		}

		public int Day {
			get { return fDay; }
			set { 
				if(fDay == value) return;
				fDay = value;
			}
		}

		public int Month {
			get { return fMonth; }
			set { 
				if(fMonth == value) return;
				fMonth = value;
			}
		}

		public int Year {
			get { return fYear; }
			set { 
				if(fYear == value) return;
				fYear = value;
			}
		}

		//Gets and sets an error for the current item
		internal string NoteError {
			get { return fNoteError; }
			set {
				if(fNoteError == value) return;
				fNoteError = value;
			}
		}

		public void ClearErrors() {
			SetColumnError("Day", "");
			SetColumnError("Month", "");
			SetColumnError("Year", "");
			NoteError = "";
		}

		//Sets an error for an item's property
		public void SetColumnError(string elem, string error) {
			if(propertyErrors.ContainsKey(elem)) {
				if((string)propertyErrors[elem] == error) return;
				propertyErrors[elem] = error;
			}
		}

		//Gets an error for an item's property
		public string GetColumnError(string elem) {
			if(propertyErrors.ContainsKey(elem))
				return (string)propertyErrors[elem];
			else
				return "";
		}

		//The owner collection
		internal ProjectNotes Owner {
			get { return owner; }
			set { owner = value; }
		}


    #region IDataErrorInfo Members

		//Returns an error description set for the item's property
		string IDataErrorInfo.this[string columnName] {
			get {
				return GetColumnError(columnName);
			}
		}

		//Returns an error description set for the current item
		string IDataErrorInfo.Error {
			get { return NoteError; }
		}
	#endregion
	}

	public class ProjectNotes: CollectionBase {
		//Provides access to items
		public NoteInfo this[int index] {
			get {return (NoteInfo)List[index];}
		}

		//The method is called after a new item is added or inserted
		protected override void OnInsertComplete(int index, object value) {
			base.OnInsertComplete (index, value);
			NoteInfo nInfo = value as NoteInfo;
			//Set the item's owner
			if(nInfo != null) nInfo.Owner = this;
		}

		//Adds a new item to the collection
		public int Add(NoteInfo nInfo) {
			int index = List.Add(nInfo);            
			return index;
		}
		//Checks the item's membership
		public int IndexOf(NoteInfo nInfo)  {
			return List.IndexOf(nInfo);
		}
	}
}
