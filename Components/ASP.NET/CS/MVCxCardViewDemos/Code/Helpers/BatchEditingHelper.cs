using System.Web;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {
    public class BatchEditingDemoHelper {

        const string BatchEditingHelperSessionKey = "07DE028B-56CC-47C3-96CF-DA39BE6B374E";

        public static BatchEditingDemoOptions Options {
            get {
                if(Session[BatchEditingHelperSessionKey] == null)
                    Session[BatchEditingHelperSessionKey] = new BatchEditingDemoOptions();
                return (BatchEditingDemoOptions)Session[BatchEditingHelperSessionKey];
            }
            set { Session[BatchEditingHelperSessionKey] = value; }
        }
        protected static HttpSessionState Session { get { return HttpContext.Current.Session; } }
    }
}
