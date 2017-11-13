using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {
    public class PagerDemoHelper {
        const string PagerOptionsSessionKey = "AABB4AB7-6684-4FEF-9D04-BAC95E586E32";

        public static PagerDemoOptions Options {
            get {
                if(Session[PagerOptionsSessionKey] == null)
                    Session[PagerOptionsSessionKey] = new PagerDemoOptions();
                return (PagerDemoOptions)Session[PagerOptionsSessionKey];
            }
            set { Session[PagerOptionsSessionKey] = value; }
        }
        protected static HttpSessionState Session { get { return HttpContext.Current.Session; } }
    }
}
