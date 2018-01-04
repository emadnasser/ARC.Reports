using System;
using ARC.Reports.Classes;
using ARC.Reports.DataModel;
using System.Data.Entity;
using System.Linq;
using ARC.Reportss.Classes;

namespace ARC.Reports.DataModel
{
    public class Context : DbContext
    {
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public Context()
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    DataHelpers.NewDbWithSeed();
        //    modelBuilder.Types().
        //        Configure(c => c.Ignore("IsDirty"));
        //    base.OnModelCreating(modelBuilder);
        //}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>()
                .HasMany(e => e.Roles)
                .WithOptional(e => e.Application)
                .HasForeignKey(e => e.Application_ApplicationId);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("UserRoles"));
        }

        //public override int SaveChanges()
        //{
        //    foreach (var history in this.ChangeTracker.Entries()
        //      .Where(e => e.Entity is IModificationHistory && (e.State == EntityState.Added ||
        //              e.State == EntityState.Modified))
        //       .Select(e => e.Entity as IModificationHistory)
        //      )
        //    {
        //        history.DateModified = DateTime.Now;
        //        if (history.DateCreated == DateTime.MinValue)
        //        {
        //            history.DateCreated = DateTime.Now;
        //        }
        //    }
        //    int result = base.SaveChanges();
        //    foreach (var history in this.ChangeTracker.Entries()
        //                                  .Where(e => e.Entity is IModificationHistory)
        //                                  .Select(e => e.Entity as IModificationHistory)
        //      )
        //    {
        //        history.IsDirty = false;
        //    }
        //    return result;
        //}
    }
}
