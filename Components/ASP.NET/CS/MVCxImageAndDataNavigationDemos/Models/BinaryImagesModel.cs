using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;

public partial class BinaryImagesContext : ContextBase {
    static BinaryImagesContext() {
        Database.SetInitializer<BinaryImagesContext>(null);
    }

    public BinaryImagesContext() : base("BinaryImagesConnectionString") { }

    public DbSet<BinaryImage> BinaryImages { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        modelBuilder.Configurations.Add(new BinaryImageMap());
    }
}

public partial class BinaryImage {
    public int ID { get; set; }
    public string Text { get; set; }
    public byte[] Picture { get; set; }
    public Nullable<int> CategoryID { get; set; }
}

public class BinaryImageMap : EntityTypeConfiguration<BinaryImage> {
    public BinaryImageMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.ID);

        this.Property(t => t.Text)
            .IsRequired()
            .HasMaxLength(50);

        // Table & Column Mappings
        this.ToTable("BinaryImages");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.Text).HasColumnName("Text");
        this.Property(t => t.Picture).HasColumnName("Picture");
        this.Property(t => t.CategoryID).HasColumnName("CategoryID");
    }
}
