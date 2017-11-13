Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.ModelConfiguration

Partial Public Class WorldCitiesContext
	Inherits ContextBase
	Shared Sub New()
		Database.SetInitializer(Of WorldCitiesContext)(Nothing)
	End Sub

	Public Sub New()
		MyBase.New("WorldCitiesConnectionString")
	End Sub

	Public Property Cities() As DbSet(Of City)
	Public Property Countries() As DbSet(Of Country)

	Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
		modelBuilder.Configurations.Add(New CityMap())
		modelBuilder.Configurations.Add(New CountryMap())
	End Sub
End Class

Partial Public Class City
	Public Sub New()
		Me.Countries = New List(Of Country)()
	End Sub

	Public Property CityId() As Integer
	Public Property CityName() As String
	Public Property CountryId() As Integer?
	Public Overridable Property Country() As Country
	Public Overridable Property Countries() As ICollection(Of Country)
End Class


Partial Public Class Country
	Public Sub New()
		Me.Cities = New List(Of City)()
	End Sub

	Public Property CountryId() As Integer
	Public Property CountryName() As String
	Public Property CapitalId() As Integer?
	Public Overridable Property Cities() As ICollection(Of City)
	Public Overridable Property City() As City
End Class

Public Class CityMap
	Inherits EntityTypeConfiguration(Of City)
	Public Sub New()
		' Primary Key
		Me.HasKey(Function(t) t.CityId)

		' Properties
		Me.Property(Function(t) t.CityName).HasMaxLength(255)

		' Table & Column Mappings
		Me.ToTable("Cities")
		Me.Property(Function(t) t.CityId).HasColumnName("CityId")
		Me.Property(Function(t) t.CityName).HasColumnName("CityName")
		Me.Property(Function(t) t.CountryId).HasColumnName("CountryId")

		' Relationships
		Me.HasOptional(Function(t) t.Country).WithMany(Function(t) t.Cities).HasForeignKey(Function(d) d.CountryId)

	End Sub
End Class

Public Class CountryMap
	Inherits EntityTypeConfiguration(Of Country)
	Public Sub New()
		' Primary Key
		Me.HasKey(Function(t) t.CountryId)

		' Properties
		Me.Property(Function(t) t.CountryName).HasMaxLength(255)

		' Table & Column Mappings
		Me.ToTable("Countries")
		Me.Property(Function(t) t.CountryId).HasColumnName("CountryId")
		Me.Property(Function(t) t.CountryName).HasColumnName("CountryName")
		Me.Property(Function(t) t.CapitalId).HasColumnName("CapitalId")

		' Relationships
		Me.HasOptional(Function(t) t.City).WithMany(Function(t) t.Countries).HasForeignKey(Function(d) d.CapitalId)

	End Sub
End Class
