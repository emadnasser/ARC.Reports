using DevExpress.Internal;
using DevExpress.Web.Demos.PivotModels;
using System.Configuration;

namespace DevExpress.Web.Demos.Models {
    public class PivotGridDemoDBDataContextExt: PivotGridDemoDBDataContext {
        static string ConnectionString {
            get {
                string sqlExpressString = ConfigurationManager.ConnectionStrings["PivotGridServerModeDemoConnectionString"].ConnectionString;
                return DbEngineDetector.PatchConnectionString(sqlExpressString);
            }
        }
        public PivotGridDemoDBDataContextExt() : base(ConnectionString) { }
    }
}
