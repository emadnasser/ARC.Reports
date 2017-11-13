Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.ModelConfiguration

Namespace DevExpress.DemoData.Models.Mapping
    Public Class SalesPersonMap
        Inherits EntityTypeConfiguration(Of SalesPerson)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.OrderID, Key t.FirstName, Key t.LastName, Key t.ProductName, Key t.CategoryName, Key t.UnitPrice, Key t.Quantity, Key t.Discount})

            ' Properties
            Me.Property(Function(t) t.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.Country).HasMaxLength(15)

            Me.Property(Function(t) t.FirstName).IsRequired().HasMaxLength(10)

            Me.Property(Function(t) t.LastName).IsRequired().HasMaxLength(20)

            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.CategoryName).IsRequired().HasMaxLength(15)

            Me.Property(Function(t) t.UnitPrice).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.Quantity).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            ' Table & Column Mappings
            Me.ToTable("SalesPerson")
            Me.Property(Function(t) t.OrderID).HasColumnName("OrderID")
            Me.Property(Function(t) t.Country).HasColumnName("Country")
            Me.Property(Function(t) t.FirstName).HasColumnName("FirstName")
            Me.Property(Function(t) t.LastName).HasColumnName("LastName")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
            Me.Property(Function(t) t.CategoryName).HasColumnName("CategoryName")
            Me.Property(Function(t) t.OrderDate).HasColumnName("OrderDate")
            Me.Property(Function(t) t.UnitPrice).HasColumnName("UnitPrice")
            Me.Property(Function(t) t.Quantity).HasColumnName("Quantity")
            Me.Property(Function(t) t.Discount).HasColumnName("Discount")
        End Sub
    End Class
End Namespace
