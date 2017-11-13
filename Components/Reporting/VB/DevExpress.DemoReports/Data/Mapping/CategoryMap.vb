Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.ModelConfiguration

Namespace DevExpress.DemoData.Models.Mapping
    Public Class CategoryMap
        Inherits EntityTypeConfiguration(Of Category)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.CategoryID)

            ' Properties
            Me.Property(Function(t) t.CategoryID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.CategoryName).IsRequired().HasMaxLength(15)

            Me.Property(Function(t) t.Description).HasMaxLength(1073741823)

            Me.Property(Function(t) t.Picture).HasMaxLength(2147483647)

            ' Table & Column Mappings
            Me.ToTable("Categories")
            Me.Property(Function(t) t.CategoryID).HasColumnName("CategoryID")
            Me.Property(Function(t) t.CategoryName).HasColumnName("CategoryName")
            Me.Property(Function(t) t.Description).HasColumnName("Description")
            Me.Property(Function(t) t.Picture).HasColumnName("Picture")
        End Sub
    End Class
End Namespace
