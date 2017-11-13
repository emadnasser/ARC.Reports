using System;
using System.Collections;

namespace DevExpress.XtraVerticalGrid.Demos {
	public class Contacts : ArrayList {
		public Contacts() {
            this.Add(new Contact(1, "John", "Doe", "Doe Enterprises", "123 Home Lane", "Homesville", "CA", "74561", "(555)956-15-47", true, DateTime.Parse("12/02/2001", System.Globalization.CultureInfo.InvariantCulture), "Programmer", 1, "Enjoys horseback riding and paints.", "M", "VS", 199.99, DateTime.Now, 0, 4));
            this.Add(new Contact(2, "Karen", "Holmes", "Holmes World", "933 Heart St. Suite ", "Chicago", "IL", "55561", "(555)342-25-74", false, DateTime.Parse("11/11/2002", System.Globalization.CultureInfo.InvariantCulture), "Doctor", 2, "Has five children. Loves to travel.", "F", "AM", 78.25, DateTime.Now, 1, 4));
            this.Add(new Contact(3, "Frank", "Frankson", "Frankson Media", "349 Graphic Design L", "Newman", "OK", "12458", "(555)155-05-02", true, DateTime.Parse("01/01/2002", System.Globalization.CultureInfo.InvariantCulture), "Retired", 0, "Retired. Enjoys travel and bungee jumping.", "M", "VS", 1299, DateTime.Now, 0, 9));
            this.Add(new Contact(4, "Leticia", "Ford", "Ford Consulting", "93900 Carter Lane", "Cartersville", "GA", "19564", "(555)776-15-66", true, DateTime.Parse("10/07/2002", System.Globalization.CultureInfo.InvariantCulture), "Engineer", 1, "none", "F", "MS", 354.12, DateTime.Now, 2, 3));
            this.Add(new Contact(5, "Henry", "McAllister", "McAllister Systems", "436 1st Ave.", "Cleveland", "OH", "99523", "(555)941-24-32", false, DateTime.Parse("09/08/2002", System.Globalization.CultureInfo.InvariantCulture), "Programmer", 0, "Enjoys fishing, skiing, and skydiving.", "M", "CS", 9.99, DateTime.Now, 3, 1));
            this.Add(new Contact(6, "Roger", "Michelson", "Michelson Systems", "3920 Michelson Dr.", "Bridgeford", "CT", "74123", "(555)954-51-88", true, DateTime.Parse("06/04/2001", System.Globalization.CultureInfo.InvariantCulture), "Special agent", 2, "Archery, windsurfing and food.", "M", "VS", 520, DateTime.Now, 4, 2));
		}
	}
	public class Products : ArrayList {
		public Products() {
			this.Add(new Product(0, "XtraGrid", "The first and most comprehensive 100% native grid control suite for Visual Studio .NET!"));
			this.Add(new Product(1, "XtraEditors", "Like the XtraGrid, the XtraEditors Library is the first comprehensive suite of individual field editors - written from groud-up using the C# programming language."));
			this.Add(new Product(2, "XtraBars", "The XtraBars is our 100% native .NET component library which fully emulates the menu/toolbar and sidebar navigation systems introduced in MS Office(c) XP and the .NET IDE."));
			this.Add(new Product(3, "XtraTreeList", "The XtraTreeList Suite is our 100% native .NET component library which allows you to break passed the traditional limits of treeview controls and represent information - be it in bound or unbound mode - to your end users in an intuitive TreeList metaphor."));
			this.Add(new Product(4, "XtraPrinting", "The XtraPrinting Library is the perfect support library for those using the XtraGrid and XtraTreeList Suite."));
			this.Add(new Product(5, "XtraNavBar", "Bring the User Interface of Windows XP - MS Office - and Visual Studio .NET to your applications with the most advanced navigation bar available for .NET."));
			this.Add(new Product(6, "ASPxGrid", "An ultra-advanced Outlook(c) style WebForms Grid control engineered specifically for ASP.NET."));
		}
	}
	public class Contact {
		private int clientID;
		private string firstName;
		private string lastName;
		private string companyName;
		private string address; 
		private string city;
		private string state;
		private string zipCode;
		private string phone;
		private bool customer;
		private DateTime dateOpen;
		private string occupation;
		private int riskLevel;
		private string interest;
		private string gender;
		private string paymentType;
		private double paymentAmount;
		private DateTime paymentDate;
		private int productID;
		private int copies;
 
		public Contact(int clientID, string firstName, string lastName, string companyName,
			string address, string city, string state, string zipCode, string phone,
			bool customer, DateTime dateOpen, string occupation, int riskLevel, string interest, 
			string gender, string paymentType, double paymentAmount, DateTime paymentDate, int productID, int copies) {
			this.clientID = clientID;
			this.firstName = firstName;
			this.lastName = lastName;
			this.companyName = companyName;
			this.address = address; 
			this.city = city;
			this.state = state;
			this.zipCode = zipCode;
			this.phone = phone;
			this.customer = customer;
			this.dateOpen = dateOpen;
			this.occupation = occupation;
			this.riskLevel = riskLevel;
			this.interest = interest;
			this.gender = gender;
			this.paymentType = paymentType;
			this.paymentAmount = paymentAmount;
			this.paymentDate = paymentDate;
			this.productID = productID;
			this.copies = copies;
		}

		public int ClientID {
			get { return clientID; }
		}
		public string FirstName {
			get { return firstName; }
			set { firstName = value; }
		}
		public string LastName {
			get { return lastName; }
			set { lastName = value; }
		}
		public string CompanyName {
			get { return companyName; }
			set { companyName = value; }
		}
		public string Address {
			get { return address; }
			set { address = value; }
		} 
		public string City {
			get { return city; }
			set { city = value; }
		}
		public string State {
			get { return state; }
			set { state = value; }
		}
		public string ZipCode {
			get { return zipCode; }
			set { zipCode = value; }
		}
		public string Phone {
			get { return phone; }
			set { phone = value; }
		}
		public bool Customer {
			get { return customer; }
			set { customer = value; }
		}
		public DateTime DateOpen {
			get { return dateOpen; }
			set { dateOpen = value; }
		}
		public string Occupation {
			get { return occupation; }
			set { occupation = value; }
		}
		public int RiskLevel {
			get { return riskLevel; }
			set { riskLevel = value; }
		}
		public string Interest {
			get { return interest; }
			set { interest = value; }
		}
		public string Gender {
			get { return gender; }
			set { gender = value; }
		}
		public string PaymentType {
			get { return paymentType; }
			set { paymentType = value; }
		}
		public double PaymentAmount {
			get { return paymentAmount; }
			set { paymentAmount = value; }
		}
		public DateTime PaymentDate {
			get { return paymentDate; }
			set { paymentDate = value; }
		}
		public int ProductID {
			get { return productID; }
			set { productID = value; }
		}
		public int Copies {
			get { return copies; }
			set { copies = value; }
		}
	}
	public class Product {
		private int id;
		private string name;
		private string description;
		public Product(int id, string name, string description) {
			this.id = id;
			this.name = name;
			this.description = description;
		}
		public int ID {
			get { return id; }
		}
		public string Name {
			get { return name; }
		}
		public string Description {
			get { return description; }
		}
	}
}
