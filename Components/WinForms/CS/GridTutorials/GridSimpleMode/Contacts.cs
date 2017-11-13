using System;
using System.Collections;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	public class ContactList : System.Collections.CollectionBase {
		
		public static ContactList GetContacts() {
			ContactList cl = new ContactList();
			cl.Add(Contact.ReadContact1());
			cl.Add(Contact.ReadContact2());
			cl.Add(Contact.ReadContact3());
			cl.Add(Contact.ReadContact4());
			cl.Add(Contact.ReadContact5());
			return cl;
		}

		public Contact this[int index] {
			get {return (Contact)(List[index]);}
			set {List[index] = value;}
		}
        
		public int Add(Contact value) {
			return List.Add(value);
		}
        
		public void Insert(int index, Contact value) {
			List.Insert(index, value);
		}
        
		public int IndexOf(Contact value) {
			return List.IndexOf(value);
		}
        
		public bool Contains(Contact value) {
			return List.Contains(value);
		}
        
		public void Remove(Contact value) {
			List.Remove(value);
		}
        
		public void CopyTo(Contact[] array, int index) {
			List.CopyTo(array, index);
		}
	}
	public class Contact {
		private string fID;
		private string fFirstName;
		private string fLastName;
		private string fCompany;
		private string fAddress;
		private bool fCustomer;
		private DateTime fPurchaseDate;
		private string fPaymentType;
		private double fPaymentAmount; 

		internal Contact(string ID): base() {
			this.fID = ID;    
		}
		public string ID { 
			get  {return fID;}
		}
		public string FirstName { 
			get  {return fFirstName;}
			set {fFirstName = value;}
		}
		public string LastName { 
			get  {return fLastName;}
			set {fLastName = value;}
		}
		public string Company { 
			get  {return fCompany;}
			set {fCompany = value;}
		}
		public string Address { 
			get  {return fAddress;}
			set {fAddress = value;}
		}
		public bool Customer { 
			get  {return fCustomer;}
			set {fCustomer = value;}
		}
		public DateTime PurchaseDate { 
			get  {return fPurchaseDate;}
			set {fPurchaseDate = value;}
		}
		public string PaymentType { 
			get  {return fPaymentType;}
			set {fPaymentType = value;}
		}
		public double PaymentAmount { 
			get  {return fPaymentAmount;}
			set {fPaymentAmount = value;}
		}
		
		internal static Contact ReadContact1() {
			Contact c = new Contact("n1");
			c.FirstName = "John";
			c.LastName = "Doe";
			c.Company = "Doe Enterprises";
			c.Address = "123 Home Lane,\r\nHomesville,\r\nCA,\r\n55555";
			c.Customer = true;
            c.PurchaseDate = DateTime.Parse("5/3/2003", System.Globalization.CultureInfo.InvariantCulture);
			c.PaymentType = "M";
			c.PaymentAmount = 330.99;
			return c;
		}

		internal static Contact ReadContact2() {
			Contact c = new Contact("n2");
			c.FirstName = "Sam";
			c.LastName = "Hill";
			c.Company = "Hill Corporation";
			c.Address = "45 Hill St.,\r\nHillsville,\r\nNJ,\r\n44444";
			c.Customer = false;
            c.PurchaseDate = DateTime.Parse("5/7/2002", System.Globalization.CultureInfo.InvariantCulture);
			c.PaymentType = "A";
			c.PaymentAmount = 100.0;
			return c;
		}

		internal static Contact ReadContact3() {
			Contact c = new Contact("n3");
			c.FirstName = "Karen";
			c.LastName = "Holmes";
			c.Company = "Holmes World";
			c.Address = "933 Holmes Dr.,\r\nJohnsonville,\r\nNY,\r\n33333";
			c.Customer = true;
            c.PurchaseDate = DateTime.Parse("7/11/2001", System.Globalization.CultureInfo.InvariantCulture);
			c.PaymentType = "C";
			c.PaymentAmount = 230.50;
			return c;
		}

		internal static Contact ReadContact4() {
			Contact c = new Contact("n4");
			c.FirstName = "Bobbie";
			c.LastName = "Valentine";
			c.Company = "Valentine Hearts";
			c.Address = "533 Heart St.Suite,\r\nChicago,\r\nIL,\r\n89123";
			c.Customer = true;
            c.PurchaseDate = DateTime.Parse("6/1/2004", System.Globalization.CultureInfo.InvariantCulture);
			c.PaymentType = "V";
			c.PaymentAmount = 550.1;
			return c;
		}

		internal static Contact ReadContact5() {
			Contact c = new Contact("n5");
			c.FirstName = "Frank";
			c.LastName = "Frankson";
			c.Company = "Frankson Media";
			c.Address = "121 Media Center Dri,\r\nNew York,\r\nNY,\r\n12121";
			c.Customer = false;
            c.PurchaseDate = DateTime.Parse("2/2/2003", System.Globalization.CultureInfo.InvariantCulture);
			c.PaymentType = "A";
			c.PaymentAmount = 50.0;
			return c;
		}
	}
}
