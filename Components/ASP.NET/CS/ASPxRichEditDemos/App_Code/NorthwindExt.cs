using DevExpress.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NorthwindExt
/// </summary>
public class NorthwindDataContextExt : NorthwindDataContext {
    static string ConnectionString {
        get {
            string sqlExpressString = ConfigurationManager.ConnectionStrings["NWindConnectionString"].ConnectionString;
            return DbEngineDetector.PatchConnectionString(sqlExpressString);
        }
    }
    public NorthwindDataContextExt()
        : base(ConnectionString) { }
}
