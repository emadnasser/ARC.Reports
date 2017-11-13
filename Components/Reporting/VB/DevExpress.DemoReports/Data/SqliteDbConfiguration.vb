Imports System
Imports System.Collections.Generic
Imports System.Data.Common
Imports System.Data.Entity
Imports System.Data.Entity.Core.Common
Imports System.Data.Entity.Core.EntityClient
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Infrastructure.DependencyResolution
Imports System.Data.SQLite
Imports System.Data.SQLite.EF6
Imports System.Linq
Imports System.Reflection

Namespace DevExpress.DemoData.Models
    'public class SqliteDbConfiguration : DbConfiguration {
    '    public SqliteDbConfiguration() {
    '        AddDependencyResolver(new SqliteDependencyResolver());
    '    }
    '}
    'public class SqliteDependencyResolver : IDbDependencyResolver {
    '    object IDbDependencyResolver.GetService(Type type, object key) {
    '        if(type == typeof(DbProviderServices)) {
    '            Type t = Type.GetType(
    '             "System.Data.SQLite.EF6.SQLiteProviderServices, System.Data.SQLite.EF6");
    '            if(t != null) {
    '                FieldInfo fi = t.GetField("Instance", BindingFlags.NonPublic | BindingFlags.Static);
    '                return (DbProviderServices)fi.GetValue(null);
    '            }
    '        } else if(type == typeof(System.Data.Common.DbProviderFactory))
    '            return SQLiteProviderFactory.Instance;
    '        else if(type == typeof(IProviderInvariantName))
    '            return new SqliteProviderInvariantName();
    '        else if(type == typeof(IDbProviderFactoryResolver))
    '            return new SqliteProviderFactoryResolver();
    '        return null;
    '    }
    '    IEnumerable<object> IDbDependencyResolver.GetServices(Type type, object key) {
    '        object service = ((IDbDependencyResolver)this).GetService(type, key);
    '        if(service != null)
    '            return new object[] { service };
    '        return Enumerable.Empty<object>();
    '    }
    '}
    'public class SqliteProviderInvariantName : IProviderInvariantName {
    '    string IProviderInvariantName.Name {
    '        get {
    '            return "System.Data.SQLite.EF6";
    '        }
    '    }
    '}
    'public class SqliteProviderFactoryResolver : IDbProviderFactoryResolver {
    '    DbProviderFactory IDbProviderFactoryResolver.ResolveProviderFactory(DbConnection connection) {
    '        if(connection is SQLiteConnection)
    '            return SQLiteProviderFactory.Instance;
    '        else if (connection is EntityConnection)
    '            return EntityProviderFactory.Instance;
    '        throw new NotSupportedException();
    '    }
    '}
End Namespace
