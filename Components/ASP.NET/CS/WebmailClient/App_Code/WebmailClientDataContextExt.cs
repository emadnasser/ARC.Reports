using DevExpress.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

public partial class WebmailClientDataContextExt : WebmailClientDataContext {
    static string ConnectionString {
        get {
            string sqlExpressString = ConfigurationManager.ConnectionStrings["WebmailClientConnectionString"].ConnectionString;
            return DbEngineDetector.PatchConnectionString(sqlExpressString);
        }
    }
    public WebmailClientDataContextExt() : base(ConnectionString) { }
}
