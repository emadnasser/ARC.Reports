using System;
using System.Collections;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
	//<vGridControl1>
    public class Contacts : ArrayList {
		public Contacts() {
            this.Add(new Contact(1, "John", "Doe", "Doe Enterprises", "123 Home Lane", "Homesville", "CA", "74561", "(555)956-15-47", true, DateTime.Parse("12/02/2003", System.Globalization.CultureInfo.InvariantCulture), "Programmer", 1, "Enjoys horseback riding and paints.", "M", "Visa", 199.99, DateTime.Now));
            this.Add(new Contact(2, "Karen", "Holmes", "Holmes World", "933 Heart St. Suite ", "Chicago", "IL", "55561", "(555)342-25-74", false, DateTime.Parse("11/11/2004", System.Globalization.CultureInfo.InvariantCulture), "Doctor", 2, "Has five children. Loves to travel.", "F", "AmExpress", 78.25, DateTime.Now));
            this.Add(new Contact(3, "Frank", "Frankson", "Frankson Media", "349 Graphic Design L", "Newman", "OK", "12458", "(555)155-05-02", true, DateTime.Parse("01/01/2004", System.Globalization.CultureInfo.InvariantCulture), "Retired", 0, "Retired. Enjoys travel and bungee jumping.", "M", "Visa", 1299, DateTime.Now));
            this.Add(new Contact(4, "Leticia", "Ford", "Ford Consulting", "93900 Carter Lane", "Cartersville", "GA", "19564", "(555)776-15-66", true, DateTime.Parse("10/07/2004", System.Globalization.CultureInfo.InvariantCulture), "Engineer", 1, "none", "F", "Master", 354.12, DateTime.Now));
            this.Add(new Contact(5, "Henry", "McAllister", "McAllister Systems", "436 1st Ave.", "Cleveland", "OH", "99523", "(555)941-24-32", false, DateTime.Parse("09/08/2003", System.Globalization.CultureInfo.InvariantCulture), "Programmer", 0, "Enjoys fishing, skiing, and skydiving.", "M", "Cash", 9.99, DateTime.Now));
            this.Add(new Contact(6, "Roger", "Michelson", "Michelson Systems", "3920 Michelson Dr.", "Bridgeford", "CT", "74123", "(555)954-51-88", true, DateTime.Parse("06/04/2003", System.Globalization.CultureInfo.InvariantCulture), "Special agent", 2, "Archery, windsurfing and food.", "M", "Visa", 520, DateTime.Now));
		}
	}
    //</vGridControl1>
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
	
		public Contact(int clientID, string firstName, string lastName, string companyName,
			string address, string city, string state, string zipCode, string phone,
			bool customer, DateTime dateOpen, string occupation, int riskLevel, string interest, 
			string gender, string paymentType, double paymentAmount, DateTime paymentDate) {
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
	}
}
