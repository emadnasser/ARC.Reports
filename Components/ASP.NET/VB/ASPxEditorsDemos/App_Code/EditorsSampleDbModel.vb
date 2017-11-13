Imports Microsoft.VisualBasic
Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.ModelConfiguration

Partial Public Class EditorsSampleDBContext
	Inherits ContextBase
	Shared Sub New()
		Database.SetInitializer(Of EditorsSampleDBContext)(Nothing)
	End Sub

	Public Sub New()
		MyBase.New("EditorsSampleDBConnectionString")
	End Sub

	Public Property ClubMembers() As DbSet(Of ClubMember)
	Public Property Occupations() As DbSet(Of Occupation)
	Public Property Tasks() As DbSet(Of Task)
	Public Property UserRoles() As DbSet(Of UserRole)
	Public Property Users() As DbSet(Of User)

	Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
		modelBuilder.Configurations.Add(New ClubMemberMap())
		modelBuilder.Configurations.Add(New OccupationMap())
		modelBuilder.Configurations.Add(New TaskMap())
		modelBuilder.Configurations.Add(New UserRoleMap())
		modelBuilder.Configurations.Add(New UserMap())
	End Sub
End Class

Partial Public Class ClubMember
	Public Property ClubMemberId() As Integer
	Public Property Name() As String
	Public Property Email() As String
	Public Property Birthday() As System.DateTime?
	Public Property Occupation() As String
	Public Property Gender() As String
	Public Property SubscriptionFlag() As Byte
End Class

Partial Public Class Occupation
	Public Property OccupationName() As String
End Class

Partial Public Class Task
	Public Property ID() As Integer
	Public Property Name() As String
	Public Property Priority() As String
	Public Property Status() As String
	Public Property Complete() As Integer?
	Public Property Assigned_To() As String
End Class
Partial Public Class User
	Public Property ID() As Integer
	Public Property UserName() As String
	Public Property Roles() As String
End Class

Partial Public Class UserRole
	Public Property ID() As Integer
	Public Property Name() As String
End Class

Public Class ClubMemberMap
	Inherits EntityTypeConfiguration(Of ClubMember)
	Public Sub New()
		' Primary Key
		Me.HasKey(Function(t) t.ClubMemberId)

		' Properties
		Me.Property(Function(t) t.Name).IsRequired().HasMaxLength(128)

		Me.Property(Function(t) t.Email).IsRequired().HasMaxLength(64)

		Me.Property(Function(t) t.Occupation).HasMaxLength(128)

		Me.Property(Function(t) t.Gender).HasMaxLength(6)

		' Table & Column Mappings
		Me.ToTable("ClubMember")
		Me.Property(Function(t) t.ClubMemberId).HasColumnName("ClubMemberId")
		Me.Property(Function(t) t.Name).HasColumnName("Name")
		Me.Property(Function(t) t.Email).HasColumnName("Email")
		Me.Property(Function(t) t.Birthday).HasColumnName("Birthday")
		Me.Property(Function(t) t.Occupation).HasColumnName("Occupation")
		Me.Property(Function(t) t.Gender).HasColumnName("Gender")
		Me.Property(Function(t) t.SubscriptionFlag).HasColumnName("SubscriptionFlag")
	End Sub
End Class

Public Class OccupationMap
	Inherits EntityTypeConfiguration(Of Occupation)
	Public Sub New()
		' Primary Key
		Me.HasKey(Function(t) t.OccupationName)

		' Properties
		Me.Property(Function(t) t.OccupationName).IsRequired().HasMaxLength(64)

		' Table & Column Mappings
		Me.ToTable("Occupation")
		Me.Property(Function(t) t.OccupationName).HasColumnName("Occupation")
	End Sub
End Class

Public Class TaskMap
	Inherits EntityTypeConfiguration(Of Task)
	Public Sub New()
		' Primary Key
		Me.HasKey(Function(t) t.ID)

		' Properties
		Me.Property(Function(t) t.Name).HasMaxLength(50)

		Me.Property(Function(t) t.Priority).HasMaxLength(50)

		Me.Property(Function(t) t.Status).HasMaxLength(50)

		Me.Property(Function(t) t.Assigned_To).HasMaxLength(50)

		' Table & Column Mappings
		Me.ToTable("Tasks")
		Me.Property(Function(t) t.ID).HasColumnName("ID")
		Me.Property(Function(t) t.Name).HasColumnName("Name")
		Me.Property(Function(t) t.Priority).HasColumnName("Priority")
		Me.Property(Function(t) t.Status).HasColumnName("Status")
		Me.Property(Function(t) t.Complete).HasColumnName("Complete")
		Me.Property(Function(t) t.Assigned_To).HasColumnName("Assigned To")
	End Sub
End Class

Public Class UserMap
	Inherits EntityTypeConfiguration(Of User)
	Public Sub New()
		' Primary Key
		Me.HasKey(Function(t) t.ID)

		' Properties
		Me.Property(Function(t) t.UserName).HasMaxLength(50)

		Me.Property(Function(t) t.Roles).HasMaxLength(255)

		' Table & Column Mappings
		Me.ToTable("Users")
		Me.Property(Function(t) t.ID).HasColumnName("ID")
		Me.Property(Function(t) t.UserName).HasColumnName("UserName")
		Me.Property(Function(t) t.Roles).HasColumnName("Roles")
	End Sub
End Class

Public Class UserRoleMap
	Inherits EntityTypeConfiguration(Of UserRole)
	Public Sub New()
		' Primary Key
		Me.HasKey(Function(t) t.ID)

		' Properties
		Me.Property(Function(t) t.Name).HasMaxLength(50)

		' Table & Column Mappings
		Me.ToTable("UserRoles")
		Me.Property(Function(t) t.ID).HasColumnName("ID")
		Me.Property(Function(t) t.Name).HasColumnName("Name")
	End Sub
End Class


