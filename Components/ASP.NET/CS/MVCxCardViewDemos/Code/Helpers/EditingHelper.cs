using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {
    public class EditingDemosHelper {
        const string EditingModeSessionKey = "E1D666FB-9692-4A88-A469-CE94D2458538";

        public static CardViewEditingMode EditMode {
            get {
                if(Session[EditingModeSessionKey] == null)
                    Session[EditingModeSessionKey] = CardViewEditingMode.EditForm;
                return (CardViewEditingMode)Session[EditingModeSessionKey];
            }
            set { Session[EditingModeSessionKey] = value; }
        }

        static List<CardViewEditingMode> availableEditModesList;
        public static List<CardViewEditingMode> AvailableEditModesList {
            get {
                if(availableEditModesList == null)
                    availableEditModesList = new List<CardViewEditingMode> {
                        CardViewEditingMode.EditForm,
                        CardViewEditingMode.PopupEditForm,
                    };
                return availableEditModesList;
            }
        }

        protected static HttpSessionState Session { get { return HttpContext.Current.Session; } }
    }
}
