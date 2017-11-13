Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.ModelConfiguration

Namespace DevExpress.DemoData.Models.Mapping
    Public Class EmployeeMap
        Inherits EntityTypeConfiguration(Of Employee)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.EmployeeID, Key t.LastName, Key t.FirstName})

            ' Properties
            Me.Property(Function(t) t.EmployeeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.LastName).IsRequired().HasMaxLength(20)

            Me.Property(Function(t) t.FirstName).IsRequired().HasMaxLength(10)

            Me.Property(Function(t) t.Title).HasMaxLength(30)

            Me.Property(Function(t) t.TitleOfCourtesy).HasMaxLength(25)

            Me.Property(Function(t) t.Address).HasMaxLength(60)

            Me.Property(Function(t) t.City).HasMaxLength(15)

            Me.Property(Function(t) t.Region).HasMaxLength(15)

            Me.Property(Function(t) t.PostalCode).HasMaxLength(10)

            Me.Property(Function(t) t.Country).HasMaxLength(15)

            Me.Property(Function(t) t.HomePhone).HasMaxLength(24)

            Me.Property(Function(t) t.Extension).HasMaxLength(4)

            Me.Property(Function(t) t.Photo).HasMaxLength(2147483647)

            Me.Property(Function(t) t.Notes).HasMaxLength(1073741823)

            ' Table & Column Mappings
            Me.ToTable("Employees")
            Me.Property(Function(t) t.EmployeeID).HasColumnName("EmployeeID")
            Me.Property(Function(t) t.LastName).HasColumnName("LastName")
            Me.Property(Function(t) t.FirstName).HasColumnName("FirstName")
            Me.Property(Function(t) t.Title).HasColumnName("Title")
            Me.Property(Function(t) t.TitleOfCourtesy).HasColumnName("TitleOfCourtesy")
            Me.Property(Function(t) t.BirthDate).HasColumnName("BirthDate")
            Me.Property(Function(t) t.HireDate).HasColumnName("HireDate")
            Me.Property(Function(t) t.Address).HasColumnName("Address")
            Me.Property(Function(t) t.City).HasColumnName("City")
            Me.Property(Function(t) t.Region).HasColumnName("Region")
            Me.Property(Function(t) t.PostalCode).HasColumnName("PostalCode")
            Me.Property(Function(t) t.Country).HasColumnName("Country")
            Me.Property(Function(t) t.HomePhone).HasColumnName("HomePhone")
            Me.Property(Function(t) t.Extension).HasColumnName("Extension")
            Me.Property(Function(t) t.Photo).HasColumnName("Photo")
            Me.Property(Function(t) t.Notes).HasColumnName("Notes")
            Me.Property(Function(t) t.ReportsTo).HasColumnName("ReportsTo")
        End Sub
    End Class
End Namespace
