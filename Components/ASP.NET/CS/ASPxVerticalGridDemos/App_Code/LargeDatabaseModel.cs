using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

public partial class LargeDatabaseContext : ContextBase {
    static LargeDatabaseContext() {
        Database.SetInitializer<LargeDatabaseContext>(null);
    }

    public LargeDatabaseContext() : base("LargeDatabaseConnectionString") { }

    public DbSet<Email> Emails { get; set; }
    public DbSet<Person> Persons { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        modelBuilder.Configurations.Add(new EmailMap());
        modelBuilder.Configurations.Add(new PersonMap());
    }
}

public partial class Person {
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
}

public partial class Email {
    public int ID { get; set; }
    public string Subject { get; set; }
    public string From { get; set; }
    public System.DateTime Sent { get; set; }
    public long Size { get; set; }
    public bool HasAttachment { get; set; }
}


public class PersonMap : EntityTypeConfiguration<Person> {
    public PersonMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.FirstName)
            .IsRequired()
            .HasMaxLength(32);

        this.Property(t => t.LastName)
            .IsRequired()
            .HasMaxLength(32);

        this.Property(t => t.Phone)
            .IsRequired()
            .HasMaxLength(20);

        // Table & Column Mappings
        this.ToTable("Persons");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.FirstName).HasColumnName("FirstName");
        this.Property(t => t.LastName).HasColumnName("LastName");
        this.Property(t => t.Phone).HasColumnName("Phone");
    }
}

public class EmailMap : EntityTypeConfiguration<Email> {
    public EmailMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Subject)
            .IsRequired()
            .HasMaxLength(100);

        this.Property(t => t.From)
            .IsRequired()
            .HasMaxLength(32);

        // Table & Column Mappings
        this.ToTable("Emails");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.Subject).HasColumnName("Subject");
        this.Property(t => t.From).HasColumnName("From");
        this.Property(t => t.Sent).HasColumnName("Sent");
        this.Property(t => t.Size).HasColumnName("Size");
        this.Property(t => t.HasAttachment).HasColumnName("HasAttachment");
    }
}
