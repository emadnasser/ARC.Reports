namespace DevExpress.Xpo.Demos.OData {
    public partial class NorthwindEntities : global::System.Data.Services.Client.DataServiceContext {
        public NorthwindEntities(global::System.Uri serviceRoot) :
            base(serviceRoot) {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        protected global::System.Type ResolveTypeFromName(string typeName) {
            if(typeName.StartsWith("NorthwindModel", global::System.StringComparison.Ordinal)) {
                return this.GetType().Assembly.GetType(string.Concat("DevExpress.Xpo.Demos", typeName.Substring(14)), false);
            }
            return null;
        }
        protected string ResolveNameFromType(global::System.Type clientType) {
            if(clientType.Namespace.Equals("DevExpress.Xpo.Demos", global::System.StringComparison.Ordinal)) {
                return string.Concat("NorthwindModel.", clientType.Name);
            }
            return null;
        }
        public global::System.Data.Services.Client.DataServiceQuery<Customers> Customers {
            get {
                if((this._Customers == null)) {
                    this._Customers = base.CreateQuery<Customers>("Customers");
                }
                return this._Customers;
            }
        }
        private global::System.Data.Services.Client.DataServiceQuery<Customers> _Customers;
        public global::System.Data.Services.Client.DataServiceQuery<Orders> Orders {
            get {
                if((this._Orders == null)) {
                    this._Orders = base.CreateQuery<Orders>("Orders");
                }
                return this._Orders;
            }
        }
        private global::System.Data.Services.Client.DataServiceQuery<Orders> _Orders;
        public void AddToCustomers(Customers customers) {
            base.AddObject("Customers", customers);
        }
        public void AddToOrders(Orders orders) {
            base.AddObject("Orders", orders);
        }
    }
    [global::System.Data.Services.Common.EntitySetAttribute("Customers")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("CustomerID")]
    public partial class Customers : global::System.ComponentModel.INotifyPropertyChanged {
        public static Customers CreateCustomers(string customerID, string companyName) {
            Customers customers = new Customers();
            customers.CustomerID = customerID;
            customers.CompanyName = companyName;
            return customers;
        }
        public string CustomerID {
            get {
                return this._CustomerID;
            }
            set {
                this.OnCustomerIDChanging(value);
                this._CustomerID = value;
                this.OnCustomerIDChanged();
                this.OnPropertyChanged("CustomerID");
            }
        }
        private string _CustomerID;
        partial void OnCustomerIDChanging(string value);
        partial void OnCustomerIDChanged();
        public string CompanyName {
            get {
                return this._CompanyName;
            }
            set {
                this.OnCompanyNameChanging(value);
                this._CompanyName = value;
                this.OnCompanyNameChanged();
                this.OnPropertyChanged("CompanyName");
            }
        }
        private string _CompanyName;
        partial void OnCompanyNameChanging(string value);
        partial void OnCompanyNameChanged();
        public string ContactName {
            get {
                return this._ContactName;
            }
            set {
                this.OnContactNameChanging(value);
                this._ContactName = value;
                this.OnContactNameChanged();
                this.OnPropertyChanged("ContactName");
            }
        }
        private string _ContactName;
        partial void OnContactNameChanging(string value);
        partial void OnContactNameChanged();
        public string ContactTitle {
            get {
                return this._ContactTitle;
            }
            set {
                this.OnContactTitleChanging(value);
                this._ContactTitle = value;
                this.OnContactTitleChanged();
                this.OnPropertyChanged("ContactTitle");
            }
        }
        private string _ContactTitle;
        partial void OnContactTitleChanging(string value);
        partial void OnContactTitleChanged();
        public string Address {
            get {
                return this._Address;
            }
            set {
                this.OnAddressChanging(value);
                this._Address = value;
                this.OnAddressChanged();
                this.OnPropertyChanged("Address");
            }
        }
        private string _Address;
        partial void OnAddressChanging(string value);
        partial void OnAddressChanged();
        public string City {
            get {
                return this._City;
            }
            set {
                this.OnCityChanging(value);
                this._City = value;
                this.OnCityChanged();
                this.OnPropertyChanged("City");
            }
        }
        private string _City;
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
        public string Region {
            get {
                return this._Region;
            }
            set {
                this.OnRegionChanging(value);
                this._Region = value;
                this.OnRegionChanged();
                this.OnPropertyChanged("Region");
            }
        }
        private string _Region;
        partial void OnRegionChanging(string value);
        partial void OnRegionChanged();
        public string PostalCode {
            get {
                return this._PostalCode;
            }
            set {
                this.OnPostalCodeChanging(value);
                this._PostalCode = value;
                this.OnPostalCodeChanged();
                this.OnPropertyChanged("PostalCode");
            }
        }
        private string _PostalCode;
        partial void OnPostalCodeChanging(string value);
        partial void OnPostalCodeChanged();
        public string Country {
            get {
                return this._Country;
            }
            set {
                this.OnCountryChanging(value);
                this._Country = value;
                this.OnCountryChanged();
                this.OnPropertyChanged("Country");
            }
        }
        private string _Country;
        partial void OnCountryChanging(string value);
        partial void OnCountryChanged();
        public string Phone {
            get {
                return this._Phone;
            }
            set {
                this.OnPhoneChanging(value);
                this._Phone = value;
                this.OnPhoneChanged();
                this.OnPropertyChanged("Phone");
            }
        }
        private string _Phone;
        partial void OnPhoneChanging(string value);
        partial void OnPhoneChanged();
        public string Fax {
            get {
                return this._Fax;
            }
            set {
                this.OnFaxChanging(value);
                this._Fax = value;
                this.OnFaxChanged();
                this.OnPropertyChanged("Fax");
            }
        }
        private string _Fax;
        partial void OnFaxChanging(string value);
        partial void OnFaxChanged();
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property) {
            if((this.PropertyChanged != null)) {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    [global::System.Data.Services.Common.EntitySetAttribute("Orders")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("OrderID")]
    public partial class Orders : global::System.ComponentModel.INotifyPropertyChanged {
        public static Orders CreateOrders(int orderID) {
            Orders orders = new Orders();
            orders.OrderID = orderID;
            return orders;
        }
        public int OrderID {
            get {
                return this._OrderID;
            }
            set {
                this.OnOrderIDChanging(value);
                this._OrderID = value;
                this.OnOrderIDChanged();
                this.OnPropertyChanged("OrderID");
            }
        }
        private int _OrderID;
        partial void OnOrderIDChanging(int value);
        partial void OnOrderIDChanged();
        public global::System.Nullable<global::System.DateTime> OrderDate {
            get {
                return this._OrderDate;
            }
            set {
                this.OnOrderDateChanging(value);
                this._OrderDate = value;
                this.OnOrderDateChanged();
                this.OnPropertyChanged("OrderDate");
            }
        }
        private global::System.Nullable<global::System.DateTime> _OrderDate;
        partial void OnOrderDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnOrderDateChanged();
        public global::System.Nullable<global::System.DateTime> RequiredDate {
            get {
                return this._RequiredDate;
            }
            set {
                this.OnRequiredDateChanging(value);
                this._RequiredDate = value;
                this.OnRequiredDateChanged();
                this.OnPropertyChanged("RequiredDate");
            }
        }
        private global::System.Nullable<global::System.DateTime> _RequiredDate;
        partial void OnRequiredDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnRequiredDateChanged();
        public global::System.Nullable<global::System.DateTime> ShippedDate {
            get {
                return this._ShippedDate;
            }
            set {
                this.OnShippedDateChanging(value);
                this._ShippedDate = value;
                this.OnShippedDateChanged();
                this.OnPropertyChanged("ShippedDate");
            }
        }
        private global::System.Nullable<global::System.DateTime> _ShippedDate;
        partial void OnShippedDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnShippedDateChanged();
        public global::System.Nullable<int> ShipVia {
            get {
                return this._ShipVia;
            }
            set {
                this.OnShipViaChanging(value);
                this._ShipVia = value;
                this.OnShipViaChanged();
                this.OnPropertyChanged("ShipVia");
            }
        }
        private global::System.Nullable<int> _ShipVia;
        partial void OnShipViaChanging(global::System.Nullable<int> value);
        partial void OnShipViaChanged();
        public global::System.Nullable<decimal> Freight {
            get {
                return this._Freight;
            }
            set {
                this.OnFreightChanging(value);
                this._Freight = value;
                this.OnFreightChanged();
                this.OnPropertyChanged("Freight");
            }
        }
        private global::System.Nullable<decimal> _Freight;
        partial void OnFreightChanging(global::System.Nullable<decimal> value);
        partial void OnFreightChanged();
        public string ShipName {
            get {
                return this._ShipName;
            }
            set {
                this.OnShipNameChanging(value);
                this._ShipName = value;
                this.OnShipNameChanged();
                this.OnPropertyChanged("ShipName");
            }
        }
        private string _ShipName;
        partial void OnShipNameChanging(string value);
        partial void OnShipNameChanged();
        public string ShipAddress {
            get {
                return this._ShipAddress;
            }
            set {
                this.OnShipAddressChanging(value);
                this._ShipAddress = value;
                this.OnShipAddressChanged();
                this.OnPropertyChanged("ShipAddress");
            }
        }
        private string _ShipAddress;
        partial void OnShipAddressChanging(string value);
        partial void OnShipAddressChanged();
        public string ShipCity {
            get {
                return this._ShipCity;
            }
            set {
                this.OnShipCityChanging(value);
                this._ShipCity = value;
                this.OnShipCityChanged();
                this.OnPropertyChanged("ShipCity");
            }
        }
        private string _ShipCity;
        partial void OnShipCityChanging(string value);
        partial void OnShipCityChanged();
        public string ShipRegion {
            get {
                return this._ShipRegion;
            }
            set {
                this.OnShipRegionChanging(value);
                this._ShipRegion = value;
                this.OnShipRegionChanged();
                this.OnPropertyChanged("ShipRegion");
            }
        }
        private string _ShipRegion;
        partial void OnShipRegionChanging(string value);
        partial void OnShipRegionChanged();
        public string ShipPostalCode {
            get {
                return this._ShipPostalCode;
            }
            set {
                this.OnShipPostalCodeChanging(value);
                this._ShipPostalCode = value;
                this.OnShipPostalCodeChanged();
                this.OnPropertyChanged("ShipPostalCode");
            }
        }
        private string _ShipPostalCode;
        partial void OnShipPostalCodeChanging(string value);
        partial void OnShipPostalCodeChanged();
        public string ShipCountry {
            get {
                return this._ShipCountry;
            }
            set {
                this.OnShipCountryChanging(value);
                this._ShipCountry = value;
                this.OnShipCountryChanged();
                this.OnPropertyChanged("ShipCountry");
            }
        }
        private string _ShipCountry;
        partial void OnShipCountryChanging(string value);
        partial void OnShipCountryChanged();
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property) {
            if((this.PropertyChanged != null)) {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
