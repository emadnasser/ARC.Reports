using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;

public partial class MedicsSchedulingDBContext : ContextBase {
    static MedicsSchedulingDBContext() {
        Database.SetInitializer<MedicsSchedulingDBContext>(null);
    }

    public MedicsSchedulingDBContext() : base("MedicsSchedulingDbConnectionString") { }

    public DbSet<MedicsSchedulingDb_MedicalAppointments> MedicalAppointments { get; set; }
    public DbSet<MedicsSchedulingDb_Medics> Medics { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        modelBuilder.Configurations.Add(new MedicsSchedulingDb_MedicalAppointmentsMap());
        modelBuilder.Configurations.Add(new MedicsSchedulingDb_MedicsMap());
    }
}

public partial class MedicsSchedulingDb_MedicalAppointments {
    public int ID { get; set; }
    public Nullable<int> MedicId { get; set; }
    public string MedicIds { get; set; }
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
    public string ContactInfo { get; set; }
}

public partial class MedicsSchedulingDb_Medics {
    public int ID { get; set; }
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string Department { get; set; }
    public string Phone { get; set; }
    public byte[] PhotoBytes { get; set; }
}

#region Mapping
public class MedicsSchedulingDb_MedicalAppointmentsMap : EntityTypeConfiguration<MedicsSchedulingDb_MedicalAppointments> {
    public MedicsSchedulingDb_MedicalAppointmentsMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Subject)
            .HasMaxLength(50);

        this.Property(t => t.Location)
            .HasMaxLength(50);

        // Table & Column Mappings
        this.ToTable("MedicalAppointments");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.MedicId).HasColumnName("MedicId");
        this.Property(t => t.MedicIds).HasColumnName("MedicIds");
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
        this.Property(t => t.ContactInfo).HasColumnName("ContactInfo");
    }
}

public class MedicsSchedulingDb_MedicsMap : EntityTypeConfiguration<MedicsSchedulingDb_Medics> {
    public MedicsSchedulingDb_MedicsMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.ID);

        this.Property(t => t.Name)
            .HasMaxLength(50);

        this.Property(t => t.DisplayName)
            .HasMaxLength(50);

        this.Property(t => t.Department)
            .HasMaxLength(50);

        this.Property(t => t.Phone)
            .HasMaxLength(50);

        // Table & Column Mappings
        this.ToTable("Medics");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.DisplayName).HasColumnName("DisplayName");
        this.Property(t => t.Department).HasColumnName("Department");
        this.Property(t => t.Phone).HasColumnName("Phone");
        this.Property(t => t.PhotoBytes).HasColumnName("PhotoBytes");
    }
}
#endregion

