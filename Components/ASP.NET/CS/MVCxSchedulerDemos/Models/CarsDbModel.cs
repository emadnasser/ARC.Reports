using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;

public partial class CarsDBContext : ContextBase {
    static CarsDBContext() {
        Database.SetInitializer<CarsDBContext>(null);
    }

    public CarsDBContext() : base("CarsDbConnectionString") { }

    public DbSet<CarsDb_Car> Cars { get; set; }
    public DbSet<CarsDb_CarScheduling> CarSchedulings { get; set; }
    public DbSet<CarsDb_Customer> Customers { get; set; }
    public DbSet<CarsDb_Order> Orders { get; set; }
    public DbSet<CarsDb_UsageType> UsageTypes { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        modelBuilder.Configurations.Add(new CarsDb_CarMap());
        modelBuilder.Configurations.Add(new CarsDb_CarSchedulingMap());
        modelBuilder.Configurations.Add(new CarsDb_CustomerMap());
        modelBuilder.Configurations.Add(new CarsDb_OrderMap());
        modelBuilder.Configurations.Add(new CarsDb_UsageTypeMap());
    }
}

public partial class CarsDb_Car {
    public int ID { get; set; }
    public string Trademark { get; set; }
    public string Model { get; set; }
    public Nullable<short> HP { get; set; }
    public Nullable<double> Liter { get; set; }
    public Nullable<byte> Cyl { get; set; }
    public Nullable<byte> TransmissSpeedCount { get; set; }
    public string TransmissAutomatic { get; set; }
    public Nullable<byte> MPG_City { get; set; }
    public Nullable<byte> MPG_Highway { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public string Hyperlink { get; set; }
    public byte[] Picture { get; set; }
    public Nullable<decimal> Price { get; set; }
    public string RtfContent { get; set; }
}

public partial class CarsDb_CarScheduling {
    public int ID { get; set; }
    public Nullable<int> CarId { get; set; }
    public Nullable<int> UserId { get; set; }
    public Nullable<int> Status { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public Nullable<int> Label { get; set; }
    public Nullable<System.DateTime> StartTime { get; set; }
    public Nullable<System.DateTime> EndTime { get; set; }
    public string Location { get; set; }
    public bool AllDay { get; set; }
    public Nullable<int> EventType { get; set; }
    public string RecurrenceInfo { get; set; }
    public string ReminderInfo { get; set; }
    public Nullable<decimal> Price { get; set; }
    public string ContactInfo { get; set; }
}

public partial class CarsDb_Customer {
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Company { get; set; }
    public string Prefix { get; set; }
    public string Title { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Source { get; set; }
    public string Customer1 { get; set; }
    public string HomePhone { get; set; }
    public string FaxPhone { get; set; }
    public string Spouse { get; set; }
    public string Occupation { get; set; }
    public string Description { get; set; }
    public string Email { get; set; }
}

public partial class CarsDb_Order {
    public int ID { get; set; }
    public Nullable<int> CustomerID { get; set; }
    public Nullable<int> ProductID { get; set; }
    public Nullable<System.DateTime> PurchaseDate { get; set; }
    public Nullable<System.DateTime> Time { get; set; }
    public string PaymentType { get; set; }
    public Nullable<decimal> PaymentAmount { get; set; }
    public string Description { get; set; }
    public Nullable<int> Quantity { get; set; }
}

public partial class CarsDb_UsageType {
    public int ID { get; set; }
    public string Name { get; set; }
    public Nullable<int> Color { get; set; }
}

#region Mapping
public class CarsDb_CarMap : EntityTypeConfiguration<CarsDb_Car> {
    public CarsDb_CarMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Trademark)
            .HasMaxLength(50);

        this.Property(t => t.Model)
            .HasMaxLength(50);

        this.Property(t => t.TransmissAutomatic)
            .HasMaxLength(3);

        this.Property(t => t.Category)
            .HasMaxLength(7);

        this.Property(t => t.Hyperlink)
            .HasMaxLength(50);

        // Table & Column Mappings
        this.ToTable("Cars");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.Trademark).HasColumnName("Trademark");
        this.Property(t => t.Model).HasColumnName("Model");
        this.Property(t => t.HP).HasColumnName("HP");
        this.Property(t => t.Liter).HasColumnName("Liter");
        this.Property(t => t.Cyl).HasColumnName("Cyl");
        this.Property(t => t.TransmissSpeedCount).HasColumnName("TransmissSpeedCount");
        this.Property(t => t.TransmissAutomatic).HasColumnName("TransmissAutomatic");
        this.Property(t => t.MPG_City).HasColumnName("MPG_City");
        this.Property(t => t.MPG_Highway).HasColumnName("MPG_Highway");
        this.Property(t => t.Category).HasColumnName("Category");
        this.Property(t => t.Description).HasColumnName("Description");
        this.Property(t => t.Hyperlink).HasColumnName("Hyperlink");
        this.Property(t => t.Picture).HasColumnName("Picture");
        this.Property(t => t.Price).HasColumnName("Price");
        this.Property(t => t.RtfContent).HasColumnName("RtfContent");
    }
}

public class CarsDb_CarSchedulingMap : EntityTypeConfiguration<CarsDb_CarScheduling> {
    public CarsDb_CarSchedulingMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Subject)
            .HasMaxLength(50);

        this.Property(t => t.Location)
            .HasMaxLength(50);

        // Table & Column Mappings
        this.ToTable("CarScheduling");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.CarId).HasColumnName("CarId");
        this.Property(t => t.UserId).HasColumnName("UserId");
        this.Property(t => t.Status).HasColumnName("Status");
        this.Property(t => t.Subject).HasColumnName("Subject");
        this.Property(t => t.Description).HasColumnName("Description");
        this.Property(t => t.Label).HasColumnName("Label");
        this.Property(t => t.StartTime).HasColumnName("StartTime");
        this.Property(t => t.EndTime).HasColumnName("EndTime");
        this.Property(t => t.Location).HasColumnName("Location");
        this.Property(t => t.AllDay).HasColumnName("AllDay");
        this.Property(t => t.EventType).HasColumnName("EventType");
        this.Property(t => t.RecurrenceInfo).HasColumnName("RecurrenceInfo");
        this.Property(t => t.ReminderInfo).HasColumnName("ReminderInfo");
        this.Property(t => t.Price).HasColumnName("Price");
        this.Property(t => t.ContactInfo).HasColumnName("ContactInfo");
    }
}

public class CarsDb_CustomerMap : EntityTypeConfiguration<CarsDb_Customer> {
    public CarsDb_CustomerMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.ID);

        this.Property(t => t.FirstName)
            .HasMaxLength(25);

        this.Property(t => t.LastName)
            .HasMaxLength(25);

        this.Property(t => t.Company)
            .HasMaxLength(50);

        this.Property(t => t.Prefix)
            .HasMaxLength(15);

        this.Property(t => t.Title)
            .HasMaxLength(15);

        this.Property(t => t.Address)
            .HasMaxLength(50);

        this.Property(t => t.City)
            .HasMaxLength(20);

        this.Property(t => t.State)
            .HasMaxLength(2);

        this.Property(t => t.ZipCode)
            .HasMaxLength(10);

        this.Property(t => t.Source)
            .HasMaxLength(10);

        this.Property(t => t.Customer1)
            .HasMaxLength(1);

        this.Property(t => t.HomePhone)
            .HasMaxLength(15);

        this.Property(t => t.FaxPhone)
            .HasMaxLength(15);

        this.Property(t => t.Spouse)
            .HasMaxLength(50);

        this.Property(t => t.Occupation)
            .HasMaxLength(25);

        this.Property(t => t.Email)
            .HasMaxLength(255);

        // Table & Column Mappings
        this.ToTable("Customers");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.FirstName).HasColumnName("FirstName");
        this.Property(t => t.LastName).HasColumnName("LastName");
        this.Property(t => t.Company).HasColumnName("Company");
        this.Property(t => t.Prefix).HasColumnName("Prefix");
        this.Property(t => t.Title).HasColumnName("Title");
        this.Property(t => t.Address).HasColumnName("Address");
        this.Property(t => t.City).HasColumnName("City");
        this.Property(t => t.State).HasColumnName("State");
        this.Property(t => t.ZipCode).HasColumnName("ZipCode");
        this.Property(t => t.Source).HasColumnName("Source");
        this.Property(t => t.Customer1).HasColumnName("Customer");
        this.Property(t => t.HomePhone).HasColumnName("HomePhone");
        this.Property(t => t.FaxPhone).HasColumnName("FaxPhone");
        this.Property(t => t.Spouse).HasColumnName("Spouse");
        this.Property(t => t.Occupation).HasColumnName("Occupation");
        this.Property(t => t.Description).HasColumnName("Description");
        this.Property(t => t.Email).HasColumnName("Email");
    }
}


public class CarsDb_OrderMap : EntityTypeConfiguration<CarsDb_Order> {
    public CarsDb_OrderMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.ID);

        this.Property(t => t.PaymentType)
            .HasMaxLength(7);

        // Table & Column Mappings
        this.ToTable("Orders");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.CustomerID).HasColumnName("CustomerID");
        this.Property(t => t.ProductID).HasColumnName("ProductID");
        this.Property(t => t.PurchaseDate).HasColumnName("PurchaseDate");
        this.Property(t => t.Time).HasColumnName("Time");
        this.Property(t => t.PaymentType).HasColumnName("PaymentType");
        this.Property(t => t.PaymentAmount).HasColumnName("PaymentAmount");
        this.Property(t => t.Description).HasColumnName("Description");
        this.Property(t => t.Quantity).HasColumnName("Quantity");
    }
}

public class CarsDb_UsageTypeMap : EntityTypeConfiguration<CarsDb_UsageType> {
    public CarsDb_UsageTypeMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Name)
            .HasMaxLength(50);

        // Table & Column Mappings
        this.ToTable("UsageType");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.Color).HasColumnName("Color");
    }
}

#endregion

