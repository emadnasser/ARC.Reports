using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;

public partial class NewsGroupsContext : ContextBase {
    static NewsGroupsContext() {
        Database.SetInitializer<NewsGroupsContext>(null);
    }

    public NewsGroupsContext() : base("NewsGroupsConnectionString") { }

    public DbSet<Thread> Threads { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        modelBuilder.Configurations.Add(new ThreadMap());
    }
}

public partial class Thread {
    public int ID { get; set; }
    public Nullable<int> ParentID { get; set; }
    public string Subject { get; set; }
    public string From { get; set; }
    public string Text { get; set; }
    public Nullable<System.DateTime> DateCreated { get; set; }
    public Nullable<bool> IsNew { get; set; }
    public Nullable<bool> HasAttachment { get; set; }
}

public class ThreadMap : EntityTypeConfiguration<Thread> {
    public ThreadMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Subject)
            .HasMaxLength(50);

        this.Property(t => t.From)
            .HasMaxLength(50);

        // Table & Column Mappings
        this.ToTable("Threads");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.ParentID).HasColumnName("ParentID");
        this.Property(t => t.Subject).HasColumnName("Subject");
        this.Property(t => t.From).HasColumnName("From");
        this.Property(t => t.Text).HasColumnName("Text");
        this.Property(t => t.DateCreated).HasColumnName("Date");
        this.Property(t => t.IsNew).HasColumnName("IsNew");
        this.Property(t => t.HasAttachment).HasColumnName("HasAttachment");
    }
}
