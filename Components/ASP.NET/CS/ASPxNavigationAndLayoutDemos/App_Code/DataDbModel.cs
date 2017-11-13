using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;

public partial class DataContext : ContextBase {
    static DataContext() {
        Database.SetInitializer<DataContext>(null);
    }

    public DataContext() : base("DataConnectionString") { }

    public DbSet<Art> Arts { get; set; }
    public DbSet<Camera> Cameras { get; set; }
    public DbSet<country> countries { get; set; }
    public DbSet<CountryLocation> CountryLocations { get; set; }
    public DbSet<Film> Films { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<VideoClip> VideoClips { get; set; }
    public DbSet<XPObjectType> XPObjectTypes { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        modelBuilder.Configurations.Add(new ArtMap());
        modelBuilder.Configurations.Add(new CameraMap());
        modelBuilder.Configurations.Add(new CountriesMap());
        modelBuilder.Configurations.Add(new CountryLocationMap());
        modelBuilder.Configurations.Add(new FilmMap());
        modelBuilder.Configurations.Add(new TopicMap());
        modelBuilder.Configurations.Add(new VideoClipMap());
        modelBuilder.Configurations.Add(new XPObjectTypeMap());
    }
}

public partial class Art {
    public Nullable<System.DateTime> LastWriteTime { get; set; }
    public string Name { get; set; }
    public int ID { get; set; }
    public Nullable<int> ParentID { get; set; }
    public Nullable<bool> IsFolder { get; set; }
    public byte[] Data { get; set; }
    public Nullable<int> OptimisticLockField { get; set; }
    public Nullable<int> GCRecord { get; set; }
    public byte[] SSMA_TimeStamp { get; set; }
}

public partial class Camera {
    public int ID { get; set; }
    public string Model { get; set; }
    public Nullable<double> Pixels { get; set; }
    public string ImageFileName { get; set; }
    public byte[] SSMA_TimeStamp { get; set; }
}

public partial class country {
    public int ID { get; set; }
    public string Name { get; set; }
    public string Capital { get; set; }
    public string Continent { get; set; }
    public Nullable<double> Area { get; set; }
    public Nullable<double> Population { get; set; }
    public byte[] SSMA_TimeStamp { get; set; }
}

public partial class CountryLocation {
    public int ID { get; set; }
    public string Text { get; set; }
    public string NavigateUrl { get; set; }
    public string Location { get; set; }
}

public partial class Film {
    public int ID { get; set; }
    public string Name { get; set; }
    public string Genre { get; set; }
    public Nullable<int> Year { get; set; }
    public string NavigateUrl { get; set; }
}

public partial class Topic {
    public int ID { get; set; }
    public string Text { get; set; }
    public string NavigateURL { get; set; }
    public Nullable<int> Popularity { get; set; }
}

public partial class VideoClip {
    public int ID { get; set; }
    public string CategoryName { get; set; }
    public string NavigateURL { get; set; }
    public Nullable<int> Popularity { get; set; }
}

public partial class XPObjectType {
    public int OID { get; set; }
    public string TypeName { get; set; }
    public string AssemblyName { get; set; }
}

#region Mapping
public class ArtMap : EntityTypeConfiguration<Art> {
    public ArtMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Name)
            .HasMaxLength(100);

        this.Property(t => t.SSMA_TimeStamp)
            .IsRequired()
            .IsFixedLength()
            .HasMaxLength(8)
            .IsRowVersion();

        // Table & Column Mappings
        this.ToTable("Arts");
        this.Property(t => t.LastWriteTime).HasColumnName("LastWriteTime");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.ParentID).HasColumnName("ParentID");
        this.Property(t => t.IsFolder).HasColumnName("IsFolder");
        this.Property(t => t.Data).HasColumnName("Data");
        this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
        this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        this.Property(t => t.SSMA_TimeStamp).HasColumnName("SSMA_TimeStamp");
    }
}

public class CameraMap : EntityTypeConfiguration<Camera> {
    public CameraMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Model)
            .HasMaxLength(50);

        this.Property(t => t.ImageFileName)
            .HasMaxLength(50);

        this.Property(t => t.SSMA_TimeStamp)
            .IsRequired()
            .IsFixedLength()
            .HasMaxLength(8)
            .IsRowVersion();

        // Table & Column Mappings
        this.ToTable("Cameras");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.Model).HasColumnName("Model");
        this.Property(t => t.Pixels).HasColumnName("Pixels");
        this.Property(t => t.ImageFileName).HasColumnName("ImageFileName");
        this.Property(t => t.SSMA_TimeStamp).HasColumnName("SSMA_TimeStamp");
    }
}

public class CountryLocationMap : EntityTypeConfiguration<CountryLocation> {
    public CountryLocationMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Text)
            .HasMaxLength(50);

        this.Property(t => t.NavigateUrl)
            .HasMaxLength(50);

        this.Property(t => t.Location)
            .HasMaxLength(50);

        // Table & Column Mappings
        this.ToTable("CountryLocation");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.Text).HasColumnName("Text");
        this.Property(t => t.NavigateUrl).HasColumnName("NavigateUrl");
        this.Property(t => t.Location).HasColumnName("Location");
    }
}

public class CountriesMap : EntityTypeConfiguration<country> {
    public CountriesMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Name)
            .HasMaxLength(255);

        this.Property(t => t.Capital)
            .HasMaxLength(255);

        this.Property(t => t.Continent)
            .HasMaxLength(255);

        this.Property(t => t.SSMA_TimeStamp)
            .IsRequired()
            .IsFixedLength()
            .HasMaxLength(8)
            .IsRowVersion();

        // Table & Column Mappings
        this.ToTable("country");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.Capital).HasColumnName("Capital");
        this.Property(t => t.Continent).HasColumnName("Continent");
        this.Property(t => t.Area).HasColumnName("Area");
        this.Property(t => t.Population).HasColumnName("Population");
        this.Property(t => t.SSMA_TimeStamp).HasColumnName("SSMA_TimeStamp");
    }
}

public class FilmMap : EntityTypeConfiguration<Film> {
    public FilmMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Name)
            .HasMaxLength(50);

        this.Property(t => t.Genre)
            .HasMaxLength(50);

        this.Property(t => t.NavigateUrl)
            .HasMaxLength(50);

        // Table & Column Mappings
        this.ToTable("Films");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.Genre).HasColumnName("Genre");
        this.Property(t => t.Year).HasColumnName("Year");
        this.Property(t => t.NavigateUrl).HasColumnName("NavigateUrl");
    }
}

public class TopicMap : EntityTypeConfiguration<Topic> {
    public TopicMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.Text)
            .HasMaxLength(50);

        this.Property(t => t.NavigateURL)
            .HasMaxLength(50);

        // Table & Column Mappings
        this.ToTable("Topics");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.Text).HasColumnName("Text");
        this.Property(t => t.NavigateURL).HasColumnName("NavigateURL");
        this.Property(t => t.Popularity).HasColumnName("Popularity");
    }
}

public class VideoClipMap : EntityTypeConfiguration<VideoClip> {
    public VideoClipMap() {
        // Primary Key
        this.HasKey(t => t.ID);

        // Properties
        this.Property(t => t.CategoryName)
            .HasMaxLength(50);

        this.Property(t => t.NavigateURL)
            .HasMaxLength(50);

        // Table & Column Mappings
        this.ToTable("VideoClips");
        this.Property(t => t.ID).HasColumnName("ID");
        this.Property(t => t.CategoryName).HasColumnName("CategoryName");
        this.Property(t => t.NavigateURL).HasColumnName("NavigateURL");
        this.Property(t => t.Popularity).HasColumnName("Popularity");
    }
}


public class XPObjectTypeMap : EntityTypeConfiguration<XPObjectType> {
    public XPObjectTypeMap() {
        // Primary Key
        this.HasKey(t => t.OID);

        // Properties
        this.Property(t => t.TypeName)
            .HasMaxLength(254);

        this.Property(t => t.AssemblyName)
            .HasMaxLength(254);

        // Table & Column Mappings
        this.ToTable("XPObjectType");
        this.Property(t => t.OID).HasColumnName("OID");
        this.Property(t => t.TypeName).HasColumnName("TypeName");
        this.Property(t => t.AssemblyName).HasColumnName("AssemblyName");
    }
}

#endregion
