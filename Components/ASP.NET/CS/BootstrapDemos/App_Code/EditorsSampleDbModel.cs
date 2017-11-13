using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;

public partial class EditorsSampleDBContext : ContextBase {
    static EditorsSampleDBContext() {
        Database.SetInitializer<EditorsSampleDBContext>(null);
    }

    public EditorsSampleDBContext() : base("EditorsSampleDBConnectionString") { }

    public DbSet<ClubMember> ClubMembers { get; set; }
    public DbSet<Occupation> Occupations { get; set; }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        modelBuilder.Configurations.Add(new ClubMemberMap());
        modelBuilder.Configurations.Add(new OccupationMap());
        modelBuilder.Configurations.Add(new TaskMap());
        modelBuilder.Configurations.Add(new UserRoleMap());
        modelBuilder.Configurations.Add(new UserMap());
    }
}

public partial class ClubMember {
    public int ClubMemberId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public Nullable<System.DateTime> Birthday { get; set; }
    public string Occupation { get; set; }
    public string Gender { get; set; }
    public byte SubscriptionFlag { get; set; }
}

public partial class Occupation {
    public string OccupationName { get; set; }
}

public partial class Task {
    public int ID { get; set; }
    public string Name { get; set; }
    public string Priority { get; set; }
    public string Status { get; set; }
    public Nullable<int> Complete { get; set; }
    public string Assigned_To { get; set; }
}
public partial class User {
    public int ID { get; set; }
    public string UserName { get; set; }
    public string Roles { get; set; }
}

public partial class UserRole {
    public int ID { get; set; }
    public string Name { get; set; }
}

public class ClubMemberMap : EntityTypeConfiguration<ClubMember> {
    public ClubMemberMap() {
        // Primary Key
        this.HasKey(t => t.ClubMemberId);

        // Properties
        this.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(128);

        this.Property(t => t.Email)
            .IsRequired()
            .HasMaxLength(64);

        this.Property(t => t.Occupation)
            .HasMaxLength(128);

        this.Property(t => t.Gender)
            .HasMaxLength(6);

        // Table & Column Mappings
        this.ToTable("ClubMember");
        this.Property(t => t.ClubMemberId).HasColumnName("ClubMemberId");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.Email).HasColumnName("Email");
        this.Property(t => t.Birthday).HasColumnName("Birthday");
        this.Property(t => t.Occupation).HasColumnName("Occupation");
        this.Property(t => t.Gender).HasColumnName("Gender");
        this.Property(t => t.SubscriptionFlag).HasColumnName("SubscriptionFlag");
    }
}

public class OccupationMap : EntityTypeConfiguration<Occupation> {
    public OccupationMap() {
        // Primary Key
        this.HasKey(t => t.OccupationName);

        // Properties
        this.Property(t => t.OccupationName)
            .IsRequired()
            .HasMaxLength(64);

        // Table & Column Mappings
        this.ToTable("Occupation");
        this.Property(t => t.OccupationName).HasColumnName("Occupation");
    }
}

public class TaskMap : EntityTypeConfiguration<Task> {
    public TaskMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Name)
            .HasMaxLength(50);

        this.Property(t => t.Priority)
            .HasMaxLength(50);

        this.Property(t => t.Status)
            .HasMaxLength(50);

        this.Property(t => t.Assigned_To)
            .HasMaxLength(50);

        // Table & Column Mappings
        this.ToTable("Tasks");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.Priority).HasColumnName("Priority");
        this.Property(t => t.Status).HasColumnName("Status");
        this.Property(t => t.Complete).HasColumnName("Complete");
        this.Property(t => t.Assigned_To).HasColumnName("Assigned To");
    }
}

public class UserMap : EntityTypeConfiguration<User> {
    public UserMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.UserName)
            .HasMaxLength(50);

        this.Property(t => t.Roles)
            .HasMaxLength(255);

        // Table & Column Mappings
        this.ToTable("Users");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.UserName).HasColumnName("UserName");
        this.Property(t => t.Roles).HasColumnName("Roles");
    }
}

public class UserRoleMap : EntityTypeConfiguration<UserRole> {
    public UserRoleMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Name)
            .HasMaxLength(50);

        // Table & Column Mappings
        this.ToTable("UserRoles");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.Name).HasColumnName("Name");
    }
}


