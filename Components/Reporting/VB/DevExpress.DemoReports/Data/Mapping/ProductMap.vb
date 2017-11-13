Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.ModelConfiguration

Namespace DevExpress.DemoData.Models.Mapping
    Public Class ProductMap
        Inherits EntityTypeConfiguration(Of Product)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.ProductID, Key t.ProductName, Key t.Discontinued})

            ' Properties
            Me.Property(Function(t) t.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.QuantityPerUnit).HasMaxLength(20)

            Me.Property(Function(t) t.EAN13).HasMaxLength(2147483647)

            ' Table & Column Mappings
            Me.ToTable("Products")
            Me.Property(Function(t) t.ProductID).HasColumnName("ProductID")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
            Me.Property(Function(t) t.SupplierID).HasColumnName("SupplierID")
            Me.Property(Function(t) t.CategoryID).HasColumnName("CategoryID")
            Me.Property(Function(t) t.QuantityPerUnit).HasColumnName("QuantityPerUnit")
            Me.Property(Function(t) t.UnitPrice).HasColumnName("UnitPrice")
            Me.Property(Function(t) t.UnitsInStock).HasColumnName("UnitsInStock")
            Me.Property(Function(t) t.UnitsOnOrder).HasColumnName("UnitsOnOrder")
            Me.Property(Function(t) t.ReorderLevel).HasColumnName("ReorderLevel")
            Me.Property(Function(t) t.Discontinued).HasColumnName("Discontinued")
            Me.Property(Function(t) t.EAN13).HasColumnName("EAN13")
            Me.HasOptional(Function(p) p.Category).WithMany(Function(c) c.Products).HasForeignKey(Function(p) p.CategoryID)
        End Sub
    End Class
End Namespace
