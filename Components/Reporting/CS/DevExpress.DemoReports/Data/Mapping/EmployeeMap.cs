using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DevExpress.DemoData.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmployeeID, t.LastName, t.FirstName });

            // Properties
            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Title)
                .HasMaxLength(30);

            this.Property(t => t.TitleOfCourtesy)
                .HasMaxLength(25);

            this.Property(t => t.Address)
                .HasMaxLength(60);

            this.Property(t => t.City)
                .HasMaxLength(15);

            this.Property(t => t.Region)
                .HasMaxLength(15);

            this.Property(t => t.PostalCode)
                .HasMaxLength(10);

            this.Property(t => t.Country)
                .HasMaxLength(15);

            this.Property(t => t.HomePhone)
                .HasMaxLength(24);

            this.Property(t => t.Extension)
                .HasMaxLength(4);

            this.Property(t => t.Photo)
                .HasMaxLength(2147483647);

            this.Property(t => t.Notes)
                .HasMaxLength(1073741823);

            // Table & Column Mappings
            this.ToTable("Employees");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.TitleOfCourtesy).HasColumnName("TitleOfCourtesy");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.HireDate).HasColumnName("HireDate");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.HomePhone).HasColumnName("HomePhone");
            this.Property(t => t.Extension).HasColumnName("Extension");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.ReportsTo).HasColumnName("ReportsTo");
        }
    }
}
