using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;

public partial class DepartmentsContext : ContextBase {
    static DepartmentsContext() {
        Database.SetInitializer<DepartmentsContext>(null);
    }

    public DepartmentsContext() : base("DepartmentsConnectionString") { }

    public DbSet<Department> Departments { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        modelBuilder.Configurations.Add(new DepartmentMap());
    }
}

public partial class Department {
    public double ID { get; set; }
    public Nullable<double> ParentID { get; set; }
    public Nullable<double> ImageIndex { get; set; }
    public string DepartmentName { get; set; }
    public Nullable<decimal> Budget { get; set; }
    public string Location { get; set; }
    public string Phone1 { get; set; }
    public string Phone2 { get; set; }
}

public class DepartmentMap : EntityTypeConfiguration<Department> {
    public DepartmentMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.DepartmentName)
            .HasMaxLength(100);

        this.Property(t => t.Location)
            .HasMaxLength(50);

        this.Property(t => t.Phone1)
            .HasMaxLength(15);

        this.Property(t => t.Phone2)
            .HasMaxLength(15);

        // Table & Column Mappings
        this.ToTable("Departments");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.ParentID).HasColumnName("ParentID");
        this.Property(t => t.ImageIndex).HasColumnName("ImageIndex");
        this.Property(t => t.DepartmentName).HasColumnName("Department");
        this.Property(t => t.Budget).HasColumnName("Budget");
        this.Property(t => t.Location).HasColumnName("Location");
        this.Property(t => t.Phone1).HasColumnName("Phone1");
        this.Property(t => t.Phone2).HasColumnName("Phone2");
    }
}
