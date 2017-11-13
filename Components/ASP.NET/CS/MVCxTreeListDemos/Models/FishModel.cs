using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;

public partial class FishContext : ContextBase {
    static FishContext() {
        Database.SetInitializer<FishContext>(null);
    }

    public FishContext() : base("FishConnectionString") { }

    public DbSet<BioLife> BioLives { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        modelBuilder.Configurations.Add(new BioLifeMap());
    }
}

public partial class BioLife {
    public int ID { get; set; }
    public Nullable<int> ParentID { get; set; }
    public Nullable<int> Species_No { get; set; }
    public Nullable<float> Length { get; set; }
    public string Category { get; set; }
    public string Common_Name { get; set; }
    public string Species_Name { get; set; }
    public string Notes { get; set; }
    public byte[] Picture { get; set; }
    public Nullable<bool> Mark { get; set; }
    public Nullable<System.DateTime> RecordDate { get; set; }
}

public class BioLifeMap : EntityTypeConfiguration<BioLife> {
    public BioLifeMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.ID);

        this.Property(t => t.Category)
            .HasMaxLength(255);

        this.Property(t => t.Common_Name)
            .HasMaxLength(255);

        this.Property(t => t.Species_Name)
            .HasMaxLength(255);

        // Table & Column Mappings
        this.ToTable("BioLife");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.ParentID).HasColumnName("ParentID");
        this.Property(t => t.Species_No).HasColumnName("Species_No");
        this.Property(t => t.Length).HasColumnName("Length");
        this.Property(t => t.Category).HasColumnName("Category");
        this.Property(t => t.Common_Name).HasColumnName("Common_Name");
        this.Property(t => t.Species_Name).HasColumnName("Species_Name");
        this.Property(t => t.Notes).HasColumnName("Notes");
        this.Property(t => t.Picture).HasColumnName("Picture");
        this.Property(t => t.Mark).HasColumnName("Mark");
        this.Property(t => t.RecordDate).HasColumnName("RecordDate");
    }
}
