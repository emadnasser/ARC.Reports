using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace EventRegistration {

    public static class CurrentData {
        static HttpSessionState Session { get { return HttpContext.Current.Session; } }

        public static SessionList Sessions {
            get {
                if(Session["Sessions"] == null)
                    Session["Sessions"] = ((SessionList)HttpContext.Current.Application["Sessions"]).CreateCopy();
                return (SessionList)Session["Sessions"];
            }
        }
        public static SessionList FeaturedSessions {
            get {
                return Sessions.GetFeaturedSessions();
            }
        }

        public static FeaturedSessionsRotator FeaturedSessionsRotator {
            get {
                if(Session["FeaturedSessionsRotator"] == null)
                    Session["FeaturedSessionsRotator"] = new FeaturedSessionsRotator(FeaturedSessions);
                return (FeaturedSessionsRotator)Session["FeaturedSessionsRotator"];
            }
        }

        public static PersonalData RegistrationInfo {
            get {
                if(Session["RegistrationInfo"] == null)
                    Session["RegistrationInfo"] = new PersonalData();
                return (PersonalData)Session["RegistrationInfo"];
            }
            set {
                Session["RegistrationInfo"] = value;
            }
        }

        public static int SelectedDayIndex {
            get {
                if(Session["SelectedDayIndex"] == null)
                    Session["SelectedDayIndex"] = 0;
                return (int)Session["SelectedDayIndex"];
            }
            set {
                Session["SelectedDayIndex"] = value;
            }
        }

        public static DateTime RegistrationDate {
            get {
                return Session["RegistrationDate"] == null
                    ? new DateTime()
                    : (DateTime)Session["RegistrationDate"];
            }
            set {
                Session["RegistrationDate"] = value;
            }
        }

        public static string PrintingStatus {
            get {
                return Session["PrintingStatus"] == null
                    ? "Selected"
                    : (string)Session["PrintingStatus"];
            }
            set {
                Session["PrintingStatus"] = value;
            }
        }

    }

}
