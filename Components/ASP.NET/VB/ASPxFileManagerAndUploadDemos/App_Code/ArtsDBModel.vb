Imports Microsoft.VisualBasic
Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.ModelConfiguration

Partial Public Class ArtsDBContext
	Inherits ContextBase
	Shared Sub New()
		Database.SetInitializer(Of ArtsDBContext)(Nothing)
	End Sub

	Public Sub New()
		MyBase.New("ArtsDBConnectionString")
	End Sub

	Public Property Arts() As DbSet(Of Art)

	Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
		modelBuilder.Configurations.Add(New ArtMap())
	End Sub
End Class

Partial Public Class Art
	Public Property LastWriteTime() As System.DateTime?
	Public Property Name() As String
	Public Property ID() As Integer
	Public Property ParentID() As Integer?
	Public Property IsFolder() As Boolean?
	Public Property Data() As Byte()
	Public Property OptimisticLockField() As Integer?
	Public Property GCRecord() As Integer?
	Public Property SSMA_TimeStamp() As Byte()
End Class

Public Class ArtMap
	Inherits EntityTypeConfiguration(Of Art)
	Public Sub New()
		' Primary Key
		Me.HasKey(Function(t) t.ID)

		' Properties
		Me.Property(Function(t) t.Name).HasMaxLength(100)

		Me.Property(Function(t) t.SSMA_TimeStamp).IsRequired().IsFixedLength().HasMaxLength(8).IsRowVersion()

		' Table & Column Mappings
		Me.ToTable("Arts")
		Me.Property(Function(t) t.LastWriteTime).HasColumnName("LastWriteTime")
		Me.Property(Function(t) t.Name).HasColumnName("Name")
		Me.Property(Function(t) t.ID).HasColumnName("ID")
		Me.Property(Function(t) t.ParentID).HasColumnName("ParentID")
		Me.Property(Function(t) t.IsFolder).HasColumnName("IsFolder")
		Me.Property(Function(t) t.Data).HasColumnName("Data")
		Me.Property(Function(t) t.OptimisticLockField).HasColumnName("OptimisticLockField")
		Me.Property(Function(t) t.GCRecord).HasColumnName("GCRecord")
		Me.Property(Function(t) t.SSMA_TimeStamp).HasColumnName("SSMA_TimeStamp")
	End Sub
End Class
