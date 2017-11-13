using System.Web;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {
    public class FilterBuilderDemoHelper {
        const string FilterBuilderOptionsSessionKey = "D9007A0E-0096-4F1C-B759-EA9CD3E1D42C";

        public static FilterBuilderDemoOptions Options {
            get {
                if(Session[FilterBuilderOptionsSessionKey] == null)
                    Session[FilterBuilderOptionsSessionKey] = new FilterBuilderDemoOptions();
                return (FilterBuilderDemoOptions)Session[FilterBuilderOptionsSessionKey];
            }
            set { Session[FilterBuilderOptionsSessionKey] = value; }
        }
        protected static HttpSessionState Session { get { return HttpContext.Current.Session; } }
    }
}
