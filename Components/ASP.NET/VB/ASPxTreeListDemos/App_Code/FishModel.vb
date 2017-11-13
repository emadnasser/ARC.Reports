Imports Microsoft.VisualBasic
Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.ModelConfiguration

Partial Public Class FishContext
	Inherits ContextBase
	Shared Sub New()
		Database.SetInitializer(Of FishContext)(Nothing)
	End Sub

	Public Sub New()
		MyBase.New("FishConnectionString")
	End Sub

	Public Property BioLives() As DbSet(Of BioLife)

	Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
		modelBuilder.Configurations.Add(New BioLifeMap())
	End Sub
End Class

Partial Public Class BioLife
	Public Property ID() As Integer
	Public Property ParentID() As Integer?
	Public Property Species_No() As Integer?
	Public Property Length() As Single?
	Public Property Category() As String
	Public Property Common_Name() As String
	Public Property Species_Name() As String
	Public Property Notes() As String
	Public Property Picture() As Byte()
	Public Property Mark() As Boolean?
	Public Property RecordDate() As System.DateTime?
End Class

Public Class BioLifeMap
	Inherits EntityTypeConfiguration(Of BioLife)
	Public Sub New()
		' Primary Key
		Me.HasKey(Function(t) t.ID)

		' Properties
		Me.Property(Function(t) t.ID)

		Me.Property(Function(t) t.Category).HasMaxLength(255)

		Me.Property(Function(t) t.Common_Name).HasMaxLength(255)

		Me.Property(Function(t) t.Species_Name).HasMaxLength(255)

		' Table & Column Mappings
		Me.ToTable("BioLife")
		Me.Property(Function(t) t.ID).HasColumnName("ID")
		Me.Property(Function(t) t.ParentID).HasColumnName("ParentID")
		Me.Property(Function(t) t.Species_No).HasColumnName("Species_No")
		Me.Property(Function(t) t.Length).HasColumnName("Length")
		Me.Property(Function(t) t.Category).HasColumnName("Category")
		Me.Property(Function(t) t.Common_Name).HasColumnName("Common_Name")
		Me.Property(Function(t) t.Species_Name).HasColumnName("Species_Name")
		Me.Property(Function(t) t.Notes).HasColumnName("Notes")
		Me.Property(Function(t) t.Picture).HasColumnName("Picture")
		Me.Property(Function(t) t.Mark).HasColumnName("Mark")
		Me.Property(Function(t) t.RecordDate).HasColumnName("RecordDate")
	End Sub
End Class
