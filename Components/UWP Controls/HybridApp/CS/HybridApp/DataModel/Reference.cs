using System.Runtime.Serialization;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System;

namespace HybridApp.HybridAppService {
    [DebuggerStepThrough]
    [DataContract(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class Employee : Person {
        EmployeeDepartment DepartmentField;
        Nullable<DateTime> HireDateField;
        int OrderField;
        string PersonalProfileField;
        Probation ProbationReasonField;
        EmployeeStatus StatusField;
        string TitleField;
        [DataMember]
        public EmployeeDepartment Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((this.DepartmentField.Equals(value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }
        [DataMember]
        public Nullable<DateTime> HireDate {
            get {
                return this.HireDateField;
            }
            set {
                if ((this.HireDateField.Equals(value) != true)) {
                    this.HireDateField = value;
                    this.RaisePropertyChanged("HireDate");
                }
            }
        }
        [DataMember]
        public int Order {
            get {
                return this.OrderField;
            }
            set {
                if ((this.OrderField.Equals(value) != true)) {
                    this.OrderField = value;
                    this.RaisePropertyChanged("Order");
                }
            }
        }
        [DataMember]
        public string PersonalProfile {
            get {
                return this.PersonalProfileField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonalProfileField, value) != true)) {
                    this.PersonalProfileField = value;
                    this.RaisePropertyChanged("PersonalProfile");
                }
            }
        }
        [DataMember]
        public Probation ProbationReason {
            get {
                return this.ProbationReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ProbationReasonField, value) != true)) {
                    this.ProbationReasonField = value;
                    this.RaisePropertyChanged("ProbationReason");
                }
            }
        }
        [DataMember]
        public EmployeeStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        [DataMember]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="DatabaseObject", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    [KnownType(typeof(Probation))]
    [KnownType(typeof(EmployeeTask))]
    [KnownType(typeof(Evaluation))]
    [KnownType(typeof(Customer))]
    [KnownType(typeof(Product))]
    [KnownType(typeof(Order))]
    [KnownType(typeof(Quote))]
    [KnownType(typeof(Crest))]
    [KnownType(typeof(CustomerEmployee))]
    [KnownType(typeof(CustomerStore))]
    [KnownType(typeof(ProductCatalog))]
    [KnownType(typeof(Picture))]
    [KnownType(typeof(Person))]
    [KnownType(typeof(Employee))]
    public partial class DatabaseObject : object, INotifyPropertyChanged {
        long IdField;
        [DataMember]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName) {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="Probation", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class Probation : DatabaseObject {
        string ReasonField;
        [DataMember]
        public string Reason {
            get {
                return this.ReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonField, value) != true)) {
                    this.ReasonField = value;
                    this.RaisePropertyChanged("Reason");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="EmployeeTask", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class EmployeeTask : DatabaseObject {
        Nullable<long> AssignedEmployeeIdField;
        int CompletionField;
        Nullable<long> CustomerEmployeeIdField;
        string DescriptionField;
        Nullable<DateTime> DueDateField;
        Nullable<long> OwnerIdField;
        EmployeeTaskPriority PriorityField;
        bool ReminderField;
        Nullable<DateTime> ReminderDateTimeField;
        Nullable<DateTime> StartDateField;
        EmployeeTaskStatus StatusField;
        string SubjectField;
        [DataMember]
        public Nullable<long> AssignedEmployeeId {
            get {
                return this.AssignedEmployeeIdField;
            }
            set {
                if ((this.AssignedEmployeeIdField.Equals(value) != true)) {
                    this.AssignedEmployeeIdField = value;
                    this.RaisePropertyChanged("AssignedEmployeeId");
                }
            }
        }
        [DataMember]
        public int Completion {
            get {
                return this.CompletionField;
            }
            set {
                if ((this.CompletionField.Equals(value) != true)) {
                    this.CompletionField = value;
                    this.RaisePropertyChanged("Completion");
                }
            }
        }
        [DataMember]
        public Nullable<long> CustomerEmployeeId {
            get {
                return this.CustomerEmployeeIdField;
            }
            set {
                if ((this.CustomerEmployeeIdField.Equals(value) != true)) {
                    this.CustomerEmployeeIdField = value;
                    this.RaisePropertyChanged("CustomerEmployeeId");
                }
            }
        }
        [DataMember]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        [DataMember]
        public Nullable<DateTime> DueDate {
            get {
                return this.DueDateField;
            }
            set {
                if ((this.DueDateField.Equals(value) != true)) {
                    this.DueDateField = value;
                    this.RaisePropertyChanged("DueDate");
                }
            }
        }
        [DataMember]
        public Nullable<long> OwnerId {
            get {
                return this.OwnerIdField;
            }
            set {
                if ((this.OwnerIdField.Equals(value) != true)) {
                    this.OwnerIdField = value;
                    this.RaisePropertyChanged("OwnerId");
                }
            }
        }
        [DataMember]
        public EmployeeTaskPriority Priority {
            get {
                return this.PriorityField;
            }
            set {
                if ((this.PriorityField.Equals(value) != true)) {
                    this.PriorityField = value;
                    this.RaisePropertyChanged("Priority");
                }
            }
        }
        public string PriorityForView {
            get {
                return Priority.ToString().ToUpper();
            }
        }
        [DataMember]
        public bool Reminder {
            get {
                return this.ReminderField;
            }
            set {
                if ((this.ReminderField.Equals(value) != true)) {
                    this.ReminderField = value;
                    this.RaisePropertyChanged("Reminder");
                }
            }
        }
        [DataMember]
        public Nullable<DateTime> ReminderDateTime {
            get {
                return this.ReminderDateTimeField;
            }
            set {
                if ((this.ReminderDateTimeField.Equals(value) != true)) {
                    this.ReminderDateTimeField = value;
                    this.RaisePropertyChanged("ReminderDateTime");
                }
            }
        }
        [DataMember]
        public Nullable<DateTime> StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        [DataMember]
        public EmployeeTaskStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        [DataMember]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="Evaluation", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class Evaluation : DatabaseObject {
        Nullable<long> CreatedByIdField;
        DateTime CreatedOnField;
        string DetailsField;
        Nullable<long> EmployeeIdField;
        EvaluationRating RatingField;
        string SubjectField;
        [DataMember]
        public Nullable<long> CreatedById {
            get {
                return this.CreatedByIdField;
            }
            set {
                if ((this.CreatedByIdField.Equals(value) != true)) {
                    this.CreatedByIdField = value;
                    this.RaisePropertyChanged("CreatedById");
                }
            }
        }
        [DataMember]
        public DateTime CreatedOn {
            get {
                return this.CreatedOnField;
            }
            set {
                if ((this.CreatedOnField.Equals(value) != true)) {
                    this.CreatedOnField = value;
                    this.RaisePropertyChanged("CreatedOn");
                }
            }
        }
        [DataMember]
        public string Details {
            get {
                return this.DetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailsField, value) != true)) {
                    this.DetailsField = value;
                    this.RaisePropertyChanged("Details");
                }
            }
        }
        [DataMember]
        public Nullable<long> EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((this.EmployeeIdField.Equals(value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
                }
            }
        }
        [DataMember]
        public EvaluationRating Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        [DataMember]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class Customer : DatabaseObject {
        decimal AnnualRevenueField;
        Address BillingAddressField;
        string FaxField;
        Address HomeOfficeField;
        byte[] LogoField;
        string NameField;
        string PhoneField;
        string ProfileField;
        CustomerStatus StatusField;
        int TotalEmployeesField;
        int TotalStoresField;
        string WebsiteField;
        [DataMember]
        public decimal AnnualRevenue {
            get {
                return this.AnnualRevenueField;
            }
            set {
                if ((this.AnnualRevenueField.Equals(value) != true)) {
                    this.AnnualRevenueField = value;
                    this.RaisePropertyChanged("AnnualRevenue");
                }
            }
        }
        [DataMember]
        public Address BillingAddress {
            get {
                return this.BillingAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.BillingAddressField, value) != true)) {
                    this.BillingAddressField = value;
                    this.RaisePropertyChanged("BillingAddress");
                }
            }
        }
        [DataMember]
        public string Fax {
            get {
                return this.FaxField;
            }
            set {
                if ((object.ReferenceEquals(this.FaxField, value) != true)) {
                    this.FaxField = value;
                    this.RaisePropertyChanged("Fax");
                }
            }
        }
        [DataMember]
        public Address HomeOffice {
            get {
                return this.HomeOfficeField;
            }
            set {
                if ((object.ReferenceEquals(this.HomeOfficeField, value) != true)) {
                    this.HomeOfficeField = value;
                    this.RaisePropertyChanged("HomeOffice");
                }
            }
        }
        [DataMember]
        public byte[] Logo {
            get {
                return this.LogoField;
            }
            set {
                if ((object.ReferenceEquals(this.LogoField, value) != true)) {
                    this.LogoField = value;
                    this.RaisePropertyChanged("Logo");
                }
            }
        }
        [DataMember]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        [DataMember]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        [DataMember]
        public string Profile {
            get {
                return this.ProfileField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfileField, value) != true)) {
                    this.ProfileField = value;
                    this.RaisePropertyChanged("Profile");
                }
            }
        }
        [DataMember]
        public CustomerStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        [DataMember]
        public int TotalEmployees {
            get {
                return this.TotalEmployeesField;
            }
            set {
                if ((this.TotalEmployeesField.Equals(value) != true)) {
                    this.TotalEmployeesField = value;
                    this.RaisePropertyChanged("TotalEmployees");
                }
            }
        }
        [DataMember]
        public int TotalStores {
            get {
                return this.TotalStoresField;
            }
            set {
                if ((this.TotalStoresField.Equals(value) != true)) {
                    this.TotalStoresField = value;
                    this.RaisePropertyChanged("TotalStores");
                }
            }
        }
        [DataMember]
        public string Website {
            get {
                return this.WebsiteField;
            }
            set {
                if ((object.ReferenceEquals(this.WebsiteField, value) != true)) {
                    this.WebsiteField = value;
                    this.RaisePropertyChanged("Website");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class Product : DatabaseObject {
        bool AvailableField;
        int BackorderField;
        byte[] BarcodeField;
        ProductCategory CategoryField;
        double ConsumerRatingField;
        decimal CostField;
        Nullable<int> CurrentInventoryField;
        string DescriptionField;
        Nullable<long> EngineerIdField;
        byte[] ImageField;
        int ManufacturingField;
        string NameField;
        Nullable<long> PrimaryImageIdField;
        DateTime ProductionStartField = DateTime.Now;
        decimal RetailPriceField;
        decimal SalePriceField;
        Nullable<long> SupportIdField;
        [DataMember]
        public bool Available {
            get {
                return this.AvailableField;
            }
            set {
                if ((this.AvailableField.Equals(value) != true)) {
                    this.AvailableField = value;
                    this.RaisePropertyChanged("Available");
                }
            }
        }
        [DataMember]
        public int Backorder {
            get {
                return this.BackorderField;
            }
            set {
                if ((this.BackorderField.Equals(value) != true)) {
                    this.BackorderField = value;
                    this.RaisePropertyChanged("Backorder");
                }
            }
        }
        [DataMember]
        public byte[] Barcode {
            get {
                return this.BarcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.BarcodeField, value) != true)) {
                    this.BarcodeField = value;
                    this.RaisePropertyChanged("Barcode");
                }
            }
        }
        [DataMember]
        public ProductCategory Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((this.CategoryField.Equals(value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        [DataMember]
        public double ConsumerRating {
            get {
                return this.ConsumerRatingField;
            }
            set {
                if ((this.ConsumerRatingField.Equals(value) != true)) {
                    this.ConsumerRatingField = value;
                    this.RaisePropertyChanged("ConsumerRating");
                }
            }
        }
        [DataMember]
        public decimal Cost {
            get {
                return this.CostField;
            }
            set {
                if ((this.CostField.Equals(value) != true)) {
                    this.CostField = value;
                    this.RaisePropertyChanged("Cost");
                }
            }
        }
        [DataMember]
        public Nullable<int> CurrentInventory {
            get {
                return this.CurrentInventoryField;
            }
            set {
                if ((this.CurrentInventoryField.Equals(value) != true)) {
                    this.CurrentInventoryField = value;
                    this.RaisePropertyChanged("CurrentInventory");
                }
            }
        }
        [DataMember]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        [DataMember]
        public Nullable<long> EngineerId {
            get {
                return this.EngineerIdField;
            }
            set {
                if ((this.EngineerIdField.Equals(value) != true)) {
                    this.EngineerIdField = value;
                    this.RaisePropertyChanged("EngineerId");
                }
            }
        }
        [DataMember]
        public byte[] Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        [DataMember]
        public int Manufacturing {
            get {
                return this.ManufacturingField;
            }
            set {
                if ((this.ManufacturingField.Equals(value) != true)) {
                    this.ManufacturingField = value;
                    this.RaisePropertyChanged("Manufacturing");
                }
            }
        }
        [DataMember]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        [DataMember]
        public Nullable<long> PrimaryImageId {
            get {
                return this.PrimaryImageIdField;
            }
            set {
                if ((this.PrimaryImageIdField.Equals(value) != true)) {
                    this.PrimaryImageIdField = value;
                    this.RaisePropertyChanged("PrimaryImageId");
                }
            }
        }
        [DataMember]
        public DateTime ProductionStart {
            get {
                return this.ProductionStartField;
            }
            set {
                if ((this.ProductionStartField.Equals(value) != true)) {
                    this.ProductionStartField = value;
                    this.RaisePropertyChanged("ProductionStart");
                }
            }
        }
        [DataMember]
        public decimal RetailPrice {
            get {
                return this.RetailPriceField;
            }
            set {
                if ((this.RetailPriceField.Equals(value) != true)) {
                    this.RetailPriceField = value;
                    this.RaisePropertyChanged("RetailPrice");
                }
            }
        }
        [DataMember]
        public decimal SalePrice {
            get {
                return this.SalePriceField;
            }
            set {
                if ((this.SalePriceField.Equals(value) != true)) {
                    this.SalePriceField = value;
                    this.RaisePropertyChanged("SalePrice");
                }
            }
        }
        [DataMember]
        public Nullable<long> SupportId {
            get {
                return this.SupportIdField;
            }
            set {
                if ((this.SupportIdField.Equals(value) != true)) {
                    this.SupportIdField = value;
                    this.RaisePropertyChanged("SupportId");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class Order : DatabaseObject {
        Nullable<long> CustomerIdField;
        Nullable<long> EmployeeIdField;
        string InvoiceNumberField;
        DateTime OrderDateField;
        string OrderTermsField;
        string PONumberField;
        decimal SaleAmountField;
        DateTime ShipDateField;
        OrderShipMethod ShipMethodField;
        decimal ShippingAmountField;
        Nullable<long> StoreIdField;
        decimal TotalAmountField;
        [DataMember]
        public Nullable<long> CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        [DataMember]
        public Nullable<long> EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((this.EmployeeIdField.Equals(value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
                }
            }
        }
        [DataMember]
        public string InvoiceNumber {
            get {
                return this.InvoiceNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.InvoiceNumberField, value) != true)) {
                    this.InvoiceNumberField = value;
                    this.RaisePropertyChanged("InvoiceNumber");
                }
            }
        }
        [DataMember]
        public DateTime OrderDate {
            get {
                return this.OrderDateField;
            }
            set {
                if ((this.OrderDateField.Equals(value) != true)) {
                    this.OrderDateField = value;
                    this.RaisePropertyChanged("OrderDate");
                }
            }
        }
        [DataMember]
        public string OrderTerms {
            get {
                return this.OrderTermsField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderTermsField, value) != true)) {
                    this.OrderTermsField = value;
                    this.RaisePropertyChanged("OrderTerms");
                }
            }
        }
        [DataMember]
        public string PONumber {
            get {
                return this.PONumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PONumberField, value) != true)) {
                    this.PONumberField = value;
                    this.RaisePropertyChanged("PONumber");
                }
            }
        }
        [DataMember]
        public decimal SaleAmount {
            get {
                return this.SaleAmountField;
            }
            set {
                if ((this.SaleAmountField.Equals(value) != true)) {
                    this.SaleAmountField = value;
                    this.RaisePropertyChanged("SaleAmount");
                }
            }
        }
        [DataMember]
        public DateTime ShipDate {
            get {
                return this.ShipDateField;
            }
            set {
                if ((this.ShipDateField.Equals(value) != true)) {
                    this.ShipDateField = value;
                    this.RaisePropertyChanged("ShipDate");
                }
            }
        }
        [DataMember]
        public OrderShipMethod ShipMethod {
            get {
                return this.ShipMethodField;
            }
            set {
                if ((this.ShipMethodField.Equals(value) != true)) {
                    this.ShipMethodField = value;
                    this.RaisePropertyChanged("ShipMethod");
                }
            }
        }
        [DataMember]
        public decimal ShippingAmount {
            get {
                return this.ShippingAmountField;
            }
            set {
                if ((this.ShippingAmountField.Equals(value) != true)) {
                    this.ShippingAmountField = value;
                    this.RaisePropertyChanged("ShippingAmount");
                }
            }
        }
        [DataMember]
        public Nullable<long> StoreId {
            get {
                return this.StoreIdField;
            }
            set {
                if ((this.StoreIdField.Equals(value) != true)) {
                    this.StoreIdField = value;
                    this.RaisePropertyChanged("StoreId");
                }
            }
        }
        [DataMember]
        public decimal TotalAmount {
            get {
                return this.TotalAmountField;
            }
            set {
                if ((this.TotalAmountField.Equals(value) != true)) {
                    this.TotalAmountField = value;
                    this.RaisePropertyChanged("TotalAmount");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="Quote", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class Quote : DatabaseObject {
        Nullable<long> CustomerIdField;
        Nullable<long> CustomerStoreIdField;
        DateTime DateField;
        Nullable<long> EmployeeIdField;
        string NumberField;
        double OpportunityField;
        decimal ShippingAmountField;
        decimal SubTotalField;
        decimal TotalField;
        [DataMember]
        public Nullable<long> CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        [DataMember]
        public Nullable<long> CustomerStoreId {
            get {
                return this.CustomerStoreIdField;
            }
            set {
                if ((this.CustomerStoreIdField.Equals(value) != true)) {
                    this.CustomerStoreIdField = value;
                    this.RaisePropertyChanged("CustomerStoreId");
                }
            }
        }
        [DataMember]
        public DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        [DataMember]
        public Nullable<long> EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((this.EmployeeIdField.Equals(value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
                }
            }
        }
        [DataMember]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        [DataMember]
        public double Opportunity {
            get {
                return this.OpportunityField;
            }
            set {
                if ((this.OpportunityField.Equals(value) != true)) {
                    this.OpportunityField = value;
                    this.RaisePropertyChanged("Opportunity");
                }
            }
        }
        [DataMember]
        public decimal ShippingAmount {
            get {
                return this.ShippingAmountField;
            }
            set {
                if ((this.ShippingAmountField.Equals(value) != true)) {
                    this.ShippingAmountField = value;
                    this.RaisePropertyChanged("ShippingAmount");
                }
            }
        }
        [DataMember]
        public decimal SubTotal {
            get {
                return this.SubTotalField;
            }
            set {
                if ((this.SubTotalField.Equals(value) != true)) {
                    this.SubTotalField = value;
                    this.RaisePropertyChanged("SubTotal");
                }
            }
        }
        [DataMember]
        public decimal Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="Crest", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class Crest : DatabaseObject {
        string CityNameField;
        [DataMember]
        public string CityName {
            get {
                return this.CityNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CityNameField, value) != true)) {
                    this.CityNameField = value;
                    this.RaisePropertyChanged("CityName");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="CustomerEmployee", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class CustomerEmployee : DatabaseObject {
        Nullable<long> CustomerIdField;
        Nullable<long> CustomerStoreIdField;
        string EmailField;
        string FirstNameField;
        string FullNameField;
        bool IsPurchaseAuthorityField;
        string LastNameField;
        string MobilePhoneField;
        Nullable<long> PictureIdField;
        string PositionField;
        PersonPrefix PrefixField;
        [DataMember]
        public Nullable<long> CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        [DataMember]
        public Nullable<long> CustomerStoreId {
            get {
                return this.CustomerStoreIdField;
            }
            set {
                if ((this.CustomerStoreIdField.Equals(value) != true)) {
                    this.CustomerStoreIdField = value;
                    this.RaisePropertyChanged("CustomerStoreId");
                }
            }
        }
        [DataMember]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        [DataMember]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        [DataMember]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        [DataMember]
        public bool IsPurchaseAuthority {
            get {
                return this.IsPurchaseAuthorityField;
            }
            set {
                if ((this.IsPurchaseAuthorityField.Equals(value) != true)) {
                    this.IsPurchaseAuthorityField = value;
                    this.RaisePropertyChanged("IsPurchaseAuthority");
                }
            }
        }
        [DataMember]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        [DataMember]
        public string MobilePhone {
            get {
                return this.MobilePhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.MobilePhoneField, value) != true)) {
                    this.MobilePhoneField = value;
                    this.RaisePropertyChanged("MobilePhone");
                }
            }
        }
        [DataMember]
        public Nullable<long> PictureId {
            get {
                return this.PictureIdField;
            }
            set {
                if ((this.PictureIdField.Equals(value) != true)) {
                    this.PictureIdField = value;
                    this.RaisePropertyChanged("PictureId");
                }
            }
        }
        [DataMember]
        public string Position {
            get {
                return this.PositionField;
            }
            set {
                if ((object.ReferenceEquals(this.PositionField, value) != true)) {
                    this.PositionField = value;
                    this.RaisePropertyChanged("Position");
                }
            }
        }
        [DataMember]
        public PersonPrefix Prefix {
            get {
                return this.PrefixField;
            }
            set {
                if ((this.PrefixField.Equals(value) != true)) {
                    this.PrefixField = value;
                    this.RaisePropertyChanged("Prefix");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="CustomerStore", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class CustomerStore : DatabaseObject {
        Address AddressField;
        Nullable<long> CrestIdField;
        Nullable<long> CustomerIdField;
        string FaxField;
        string PhoneField;
        int SquereFootageField;
        int TotalEmployeesField;
        [DataMember]
        public Address Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        [DataMember]
        public Nullable<long> CrestId {
            get {
                return this.CrestIdField;
            }
            set {
                if ((this.CrestIdField.Equals(value) != true)) {
                    this.CrestIdField = value;
                    this.RaisePropertyChanged("CrestId");
                }
            }
        }
        [DataMember]
        public Nullable<long> CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        [DataMember]
        public string Fax {
            get {
                return this.FaxField;
            }
            set {
                if ((object.ReferenceEquals(this.FaxField, value) != true)) {
                    this.FaxField = value;
                    this.RaisePropertyChanged("Fax");
                }
            }
        }
        [DataMember]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        [DataMember]
        public int SquereFootage {
            get {
                return this.SquereFootageField;
            }
            set {
                if ((this.SquereFootageField.Equals(value) != true)) {
                    this.SquereFootageField = value;
                    this.RaisePropertyChanged("SquereFootage");
                }
            }
        }
        [DataMember]
        public int TotalEmployees {
            get {
                return this.TotalEmployeesField;
            }
            set {
                if ((this.TotalEmployeesField.Equals(value) != true)) {
                    this.TotalEmployeesField = value;
                    this.RaisePropertyChanged("TotalEmployees");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="ProductCatalog", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class ProductCatalog : DatabaseObject {
        byte[] PDFField;
        Nullable<long> ProductIdField;
        [DataMember]
        public byte[] PDF {
            get {
                return this.PDFField;
            }
            set {
                if ((object.ReferenceEquals(this.PDFField, value) != true)) {
                    this.PDFField = value;
                    this.RaisePropertyChanged("PDF");
                }
            }
        }
        [DataMember]
        public Nullable<long> ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="Picture", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class Picture : DatabaseObject {
        byte[] DataField;
        [DataMember]
        public byte[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    [KnownType(typeof(Employee))]
    public partial class Person : DatabaseObject {
        Address AddressField;
        Nullable<DateTime> BirthDateField;
        string EmailField;
        string FirstNameField;
        string FullNameField;
        string HomePhoneField;
        string LastNameField;
        string MobilePhoneField;
        Nullable<long> PictureIdField;
        PersonPrefix PrefixField;
        string SkypeField;
        [DataMember]
        public Address Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        [DataMember]
        public Nullable<DateTime> BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        [DataMember]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        [DataMember]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        [DataMember]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        [DataMember]
        public string HomePhone {
            get {
                return this.HomePhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.HomePhoneField, value) != true)) {
                    this.HomePhoneField = value;
                    this.RaisePropertyChanged("HomePhone");
                }
            }
        }
        [DataMember]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        [DataMember]
        public string MobilePhone {
            get {
                return this.MobilePhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.MobilePhoneField, value) != true)) {
                    this.MobilePhoneField = value;
                    this.RaisePropertyChanged("MobilePhone");
                }
            }
        }
        [DataMember]
        public Nullable<long> PictureId {
            get {
                return this.PictureIdField;
            }
            set {
                if ((this.PictureIdField.Equals(value) != true)) {
                    this.PictureIdField = value;
                    this.RaisePropertyChanged("PictureId");
                }
            }
        }
        [DataMember]
        public PersonPrefix Prefix {
            get {
                return this.PrefixField;
            }
            set {
                if ((this.PrefixField.Equals(value) != true)) {
                    this.PrefixField = value;
                    this.RaisePropertyChanged("Prefix");
                }
            }
        }
        [DataMember]
        public string Skype {
            get {
                return this.SkypeField;
            }
            set {
                if ((object.ReferenceEquals(this.SkypeField, value) != true)) {
                    this.SkypeField = value;
                    this.RaisePropertyChanged("Skype");
                }
            }
        }
    }
    [DebuggerStepThrough]
    [DataContract(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public partial class Address : object, INotifyPropertyChanged {
        string CityField;
        double LatitudeField;
        string LineField;
        double LongitudeField;
        StateEnum StateField;
        string ZipCodeField;
        [DataMember]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        [DataMember]
        public double Latitude {
            get {
                return this.LatitudeField;
            }
            set {
                if ((this.LatitudeField.Equals(value) != true)) {
                    this.LatitudeField = value;
                    this.RaisePropertyChanged("Latitude");
                }
            }
        }
        [DataMember]
        public string Line {
            get {
                return this.LineField;
            }
            set {
                if ((object.ReferenceEquals(this.LineField, value) != true)) {
                    this.LineField = value;
                    this.RaisePropertyChanged("Line");
                }
            }
        }
        [DataMember]
        public double Longitude {
            get {
                return this.LongitudeField;
            }
            set {
                if ((this.LongitudeField.Equals(value) != true)) {
                    this.LongitudeField = value;
                    this.RaisePropertyChanged("Longitude");
                }
            }
        }
        [DataMember]
        public StateEnum State {
            get {
                return this.StateField;
            }
            set {
                if ((this.StateField.Equals(value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        [DataMember]
        public string ZipCode {
            get {
                return this.ZipCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipCodeField, value) != true)) {
                    this.ZipCodeField = value;
                    this.RaisePropertyChanged("ZipCode");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName) {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    [DataContract(Name="PersonPrefix", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public enum PersonPrefix : int {
        [EnumMember]
        Dr = 0,
        [EnumMember]
        Mr = 1,
        [EnumMember]
        Ms = 2,
        [EnumMember]
        Miss = 3,
        [EnumMember]
        Mrs = 4,
    }
    [System.FlagsAttribute()]
    [DataContract(Name="EmployeeDepartment", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public enum EmployeeDepartment : int {
        [EnumMember]
        Sales = 1,
        [EnumMember]
        Support = 2,
        [EnumMember]
        Shipping = 3,
        [EnumMember]
        Engineering = 4,
        [EnumMember]
        HumanResources = 5,
        [EnumMember]
        Management = 6,
        [EnumMember]
        IT = 7,
    }
    [DataContract(Name="EmployeeStatus", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public enum EmployeeStatus : int {
        [EnumMember]
        Salaried = 0,
        [EnumMember]
        Commission = 1,
        [EnumMember]
        Contract = 2,
        [EnumMember]
        Terminated = 3,
        [EnumMember]
        OnLeave = 4,
    }
    [DataContract(Name="EmployeeTaskPriority", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public enum EmployeeTaskPriority : int {
        [EnumMember]
        Low = 0,
        [EnumMember]
        Normal = 1,
        [EnumMember]
        High = 2,
        [EnumMember]
        Urgent = 3,
    }
    [DataContract(Name="EmployeeTaskStatus", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public enum EmployeeTaskStatus : int {
        [EnumMember]
        NotStarted = 0,
        [EnumMember]
        Completed = 1,
        [EnumMember]
        InProgress = 2,
        [EnumMember]
        NeedAssistance = 3,
        [EnumMember]
        Deferred = 4,
    }
    [DataContract(Name="EvaluationRating", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public enum EvaluationRating : int {
        [EnumMember]
        Unset = 0,
        [EnumMember]
        Good = 1,
        [EnumMember]
        Average = 2,
        [EnumMember]
        Poor = 3,
    }
    [DataContract(Name="CustomerStatus", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public enum CustomerStatus : int {
        [EnumMember]
        Active = 0,
        [EnumMember]
        Suspended = 1,
    }
    [DataContract(Name="StateEnum", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public enum StateEnum : int {
        [EnumMember]
        CA = 0,
        [EnumMember]
        AR = 1,
        [EnumMember]
        AL = 2,
        [EnumMember]
        AK = 3,
        [EnumMember]
        AZ = 4,
        [EnumMember]
        CO = 5,
        [EnumMember]
        CT = 6,
        [EnumMember]
        DE = 7,
        [EnumMember]
        DC = 8,
        [EnumMember]
        FL = 9,
        [EnumMember]
        GA = 10,
        [EnumMember]
        HI = 11,
        [EnumMember]
        ID = 12,
        [EnumMember]
        IL = 13,
        [EnumMember]
        IN = 14,
        [EnumMember]
        IA = 15,
        [EnumMember]
        KS = 16,
        [EnumMember]
        KY = 17,
        [EnumMember]
        LA = 18,
        [EnumMember]
        ME = 19,
        [EnumMember]
        MD = 20,
        [EnumMember]
        MA = 21,
        [EnumMember]
        MI = 22,
        [EnumMember]
        MN = 23,
        [EnumMember]
        MS = 24,
        [EnumMember]
        MO = 25,
        [EnumMember]
        MT = 26,
        [EnumMember]
        NE = 27,
        [EnumMember]
        NV = 28,
        [EnumMember]
        NH = 29,
        [EnumMember]
        NJ = 30,
        [EnumMember]
        NM = 31,
        [EnumMember]
        NY = 32,
        [EnumMember]
        NC = 33,
        [EnumMember]
        OH = 34,
        [EnumMember]
        OK = 35,
        [EnumMember]
        OR = 36,
        [EnumMember]
        PA = 37,
        [EnumMember]
        RI = 38,
        [EnumMember]
        SC = 39,
        [EnumMember]
        SD = 40,
        [EnumMember]
        TN = 41,
        [EnumMember]
        TX = 42,
        [EnumMember]
        UT = 43,
        [EnumMember]
        VT = 44,
        [EnumMember]
        VA = 45,
        [EnumMember]
        WA = 46,
        [EnumMember]
        WV = 47,
        [EnumMember]
        WI = 48,
        [EnumMember]
        WY = 49,
        [EnumMember]
        ND = 50,
    }
    [DataContract(Name="ProductCategory", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public enum ProductCategory : int {
        [EnumMember]
        VideoPlayers = 0,
        [EnumMember]
        Televisions = 1,
        [EnumMember]
        Monitors = 2,
        [EnumMember]
        Projectors = 3,
        [EnumMember]
        Automation = 4,
    }
    [DataContract(Name="OrderShipMethod", Namespace="http://schemas.datacontract.org/2004/07/DevExpress.DevAV")]
    public enum OrderShipMethod : int {
        [EnumMember]
        Ground = 0,
        [EnumMember]
        Air = 1,
    }
    [DebuggerStepThrough]
    [DataContract(Name="MonthlySale", Namespace="http://schemas.datacontract.org/2004/07/HybridAppService")]
    public partial class MonthlySale : object, INotifyPropertyChanged {
        long IdField;
        ObservableCollection<double> SalesField;
        [DataMember]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        [DataMember]
        public ObservableCollection<double> Sales {
            get {
                return this.SalesField;
            }
            set {
                if ((object.ReferenceEquals(this.SalesField, value) != true)) {
                    this.SalesField = value;
                    this.RaisePropertyChanged("Sales");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName) {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
