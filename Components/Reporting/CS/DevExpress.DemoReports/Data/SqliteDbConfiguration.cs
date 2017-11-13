using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Linq;
using System.Reflection;

namespace DevExpress.DemoData.Models {
    //public class SqliteDbConfiguration : DbConfiguration {
    //    public SqliteDbConfiguration() {
    //        AddDependencyResolver(new SqliteDependencyResolver());
    //    }
    //}
    //public class SqliteDependencyResolver : IDbDependencyResolver {
    //    object IDbDependencyResolver.GetService(Type type, object key) {
    //        if(type == typeof(DbProviderServices)) {
    //            Type t = Type.GetType(
    //             "System.Data.SQLite.EF6.SQLiteProviderServices, System.Data.SQLite.EF6");
    //            if(t != null) {
    //                FieldInfo fi = t.GetField("Instance", BindingFlags.NonPublic | BindingFlags.Static);
    //                return (DbProviderServices)fi.GetValue(null);
    //            }
    //        } else if(type == typeof(System.Data.Common.DbProviderFactory))
    //            return SQLiteProviderFactory.Instance;
    //        else if(type == typeof(IProviderInvariantName))
    //            return new SqliteProviderInvariantName();
    //        else if(type == typeof(IDbProviderFactoryResolver))
    //            return new SqliteProviderFactoryResolver();
    //        return null;
    //    }
    //    IEnumerable<object> IDbDependencyResolver.GetServices(Type type, object key) {
    //        object service = ((IDbDependencyResolver)this).GetService(type, key);
    //        if(service != null)
    //            return new object[] { service };
    //        return Enumerable.Empty<object>();
    //    }
    //}
    //public class SqliteProviderInvariantName : IProviderInvariantName {
    //    string IProviderInvariantName.Name {
    //        get {
    //            return "System.Data.SQLite.EF6";
    //        }
    //    }
    //}
    //public class SqliteProviderFactoryResolver : IDbProviderFactoryResolver {
    //    DbProviderFactory IDbProviderFactoryResolver.ResolveProviderFactory(DbConnection connection) {
    //        if(connection is SQLiteConnection)
    //            return SQLiteProviderFactory.Instance;
    //        else if (connection is EntityConnection)
    //            return EntityProviderFactory.Instance;
    //        throw new NotSupportedException();
    //    }
    //}
}
