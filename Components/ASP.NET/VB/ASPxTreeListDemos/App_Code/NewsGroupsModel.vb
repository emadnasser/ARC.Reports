Imports Microsoft.VisualBasic
Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.ModelConfiguration

Partial Public Class NewsGroupsContext
	Inherits ContextBase
	Shared Sub New()
		Database.SetInitializer(Of NewsGroupsContext)(Nothing)
	End Sub

	Public Sub New()
		MyBase.New("NewsGroupsConnectionString")
	End Sub

	Public Property Threads() As DbSet(Of Thread)

	Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
		modelBuilder.Configurations.Add(New ThreadMap())
	End Sub
End Class

Partial Public Class Thread
	Public Property ID() As Integer
	Public Property ParentID() As Integer?
	Public Property Subject() As String
	Public Property From() As String
	Public Property Text() As String
	Public Property DateCreated() As System.DateTime?
	Public Property IsNew() As Boolean?
	Public Property HasAttachment() As Boolean?
End Class

Public Class ThreadMap
	Inherits EntityTypeConfiguration(Of Thread)
	Public Sub New()
		' Primary Key
		Me.HasKey(Function(t) t.ID)

		' Properties
		Me.Property(Function(t) t.Subject).HasMaxLength(50)

		Me.Property(Function(t) t.From).HasMaxLength(50)

		' Table & Column Mappings
		Me.ToTable("Threads")
		Me.Property(Function(t) t.ID).HasColumnName("ID")
		Me.Property(Function(t) t.ParentID).HasColumnName("ParentID")
		Me.Property(Function(t) t.Subject).HasColumnName("Subject")
		Me.Property(Function(t) t.From).HasColumnName("From")
		Me.Property(Function(t) t.Text).HasColumnName("Text")
		Me.Property(Function(t) t.DateCreated).HasColumnName("Date")
		Me.Property(Function(t) t.IsNew).HasColumnName("IsNew")
		Me.Property(Function(t) t.HasAttachment).HasColumnName("HasAttachment")
	End Sub
End Class
