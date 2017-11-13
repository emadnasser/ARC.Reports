using System;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    //<gridControl1>
    public class Person : IDXDataErrorInfo {
    //...    
    //</gridControl1>
        string firstName;
        string lastName;
        string address;
        string phoneNumber;
        string email;
        public Person(string firstName, string lastName, string address, string phoneNumber, string email) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address {
            get { return address; }
            set { address = value; }
        }
        public string PhoneNumber {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Email {
            get { return email; }
            set { email = value; }
        }
        #region IDXDataErrorInfo Members 
        //<gridControl1>
        void IDXDataErrorInfo.GetPropertyError(string propertyName, ErrorInfo info) {
            switch(propertyName) {
                case "FirstName":
                case "LastName":
                    if(IsStringEmpty(propertyName == "FirstName" ? FirstName : LastName)) {
                        SetErrorInfo(info, propertyName + " field can't be empty", ErrorType.Critical);
                    }
                    break;
                case "Address":
                    if(IsStringEmpty(Address)) {
                        SetErrorInfo(info, "Address hasn't been entered", ErrorType.Information);
                    }
                    break;
                case "Email":
                    if(IsStringEmpty(Email)) {
                        SetErrorInfo(info, "Email hasn't been entered", ErrorType.Information);
                    }
                    else if(Email != "none" && !IsEmailCorrect(Email)) {
                        SetErrorInfo(info, "Wrong email address", ErrorType.Warning);
                    }
                    break;
            }
        }
        void IDXDataErrorInfo.GetError(ErrorInfo info) { }
        //</gridControl1>
        #endregion 
        bool IsStringEmpty(string str) {
            return (str != null && str.Trim().Length == 0);
        }
        bool IsEmailCorrect(string email) {
            return !(email != null && email.IndexOf("@") < 1);
        }
        void SetErrorInfo(ErrorInfo info, string errorText, ErrorType errorType) {
            info.ErrorText = errorText;
            info.ErrorType = errorType;
        }
    }
	public class Persons: CollectionBase {
		//Provides access to items
		public Person this[int index] {
			get {return (Person)List[index];}
		}
		//The method is called after a new item is added or inserted
		protected override void OnInsertComplete(int index, object value) {
			base.OnInsertComplete (index, value);
            Person customer = value as Person;
		}
		//Adds a new item to the collection
		public int Add(Person person) {
            int index = List.Add(person);            
			return index;
		}
		//Checks the item's membership
        public int IndexOf(Person person) {
            return List.IndexOf(person);
		}
	}
}
